// ActiveWindowDlg.cpp : implementation file
//

#include "stdafx.h"
#include "ScreenScrapDemo.h"
#include "ActiveWindowDlg.h"
#include ".\activewindowdlg.h"


// CActiveWindowDlg dialog

IMPLEMENT_DYNAMIC(CActiveWindowDlg, CDialog)
CActiveWindowDlg::CActiveWindowDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CActiveWindowDlg::IDD, pParent)
    , m_strResult(_T(""))
    , m_strWindowName(_T(""))
    , m_strWindowHandle(_T(""))
    , m_strFont(_T(""))
    , m_nFontSize(0)
    , m_nType(0)
    , m_strDuration(_T(""))
    , m_bUseFormatting(TRUE)
{
    m_nFullHeight = 0;
    m_enScenario = E_ACTIVE;
    m_pFontResult = NULL;
}

CActiveWindowDlg::~CActiveWindowDlg()
{
    if(NULL != m_pFontResult)
    {
        m_pFontResult->DeleteObject();
        delete m_pFontResult;
        m_pFontResult = NULL;
    }
}

void CActiveWindowDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    DDX_Text(pDX, IDC_EDIT_RESULT, m_strResult);
    DDX_Text(pDX, IDC_EDIT_WND_NAME, m_strWindowName);
    DDX_Text(pDX, IDC_EDIT_WND_HANDLE, m_strWindowHandle);
    DDX_Text(pDX, IDC_EDIT_FONT, m_strFont);
    DDX_Text(pDX, IDC_EDIT_FONT_SIZE, m_nFontSize);
    DDX_Radio(pDX, IDC_RADIO1, m_nType);
    DDX_Control(pDX, IDC_COMBO_SCENARIO, m_cboScenario);
    DDX_Text(pDX, IDC_STATIC_DURATION, m_strDuration);
    DDX_Check(pDX, IDC_CHECK_USE_FORMATED_TEXT, m_bUseFormatting);
}


BEGIN_MESSAGE_MAP(CActiveWindowDlg, CDialog)
    ON_BN_CLICKED(IDC_EXTRACT, OnBnClickedExtract)
    ON_BN_CLICKED(IDC_COPY_CLIPBOARD, OnBnClickedCopyClipboard)
    ON_CBN_SELCHANGE(IDC_COMBO_SCENARIO, OnCbnSelchangeComboScenario)
END_MESSAGE_MAP()


// CActiveWindowDlg message handlers

BOOL CActiveWindowDlg::OnInitDialog()
{
    CDialog::OnInitDialog();

    CRect rcWin;
    GetWindowRect(rcWin);
    m_nFullHeight = rcWin.Height();

    //show only upper part
    CWnd *pWnd = GetDlgItem(IDC_STATIC_SELECTION);
    if(NULL != pWnd)
    {
        CRect rcCtrl;
        pWnd->GetWindowRect(rcCtrl);
        //set new height
        rcWin.bottom = rcCtrl.top;
        //now center
        int nPixelsX = ::GetSystemMetrics(SM_CXSCREEN);
        int nPixelsY = ::GetSystemMetrics(SM_CYSCREEN);
        rcWin.OffsetRect((nPixelsX-rcWin.Width())/2, (nPixelsY-m_nFullHeight)/2);

        MoveWindow(rcWin);
    }
    //init scenario combo
    theApp.InitComboScenario(m_cboScenario, E_ACTIVE);

    return TRUE;  // return TRUE unless you set the focus to a control
    // EXCEPTION: OCX Property Pages should return FALSE
}


void CActiveWindowDlg::OnBnClickedExtract()
{
    UpdateData();
    static BOOL bShowFullHeight = TRUE;
    //ShowWindow(SW_HIDE);
    ShowWindow(SW_MINIMIZE);

    //wait a bit :)
    ::Sleep(500);

    DoCapture();

    UpdateData(FALSE);    

    ::Sleep(500);
    //ShowWindow(SW_SHOW);
    ShowWindow(SW_RESTORE);
    if(m_nFullHeight > 0)
    {
        //restore the window
        theApp.RestoreWindow(this, m_nFullHeight);
        m_nFullHeight = 0;
    }
}

void CActiveWindowDlg::OnBnClickedCopyClipboard()
{
    UpdateData();
    theApp.CopyTextToClipboard(m_strResult);
}

void CActiveWindowDlg::DoCapture()
{
    CComPtr<ITextCaptureX7> pCapture;
    HRESULT hr = pCapture.CoCreateInstance(CLSID_TextCaptureX);
    if(FAILED(hr) || !pCapture)
    {
        AfxMessageBox(IDS_ERR_CREATE_CAPTURE_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

    CComPtr<IFontDisp> pFont;
    CComBSTR bstrRes;

    try
    {
        LONG hWnd = pCapture->GetActiveWindowHwnd();
        pCapture->FormattedText = m_bUseFormatting ? ATL_VARIANT_TRUE : ATL_VARIANT_FALSE;

        DWORD dwStart = ::GetTickCount();
        if(0 == m_nType)
            bstrRes = (BSTR)pCapture->CaptureWindowWithFont(hWnd, &pFont);
        else
            bstrRes = (BSTR)pCapture->GetFullTextAA(hWnd);
        DWORD dwEnd = ::GetTickCount();

        m_strDuration.Format(IDS_DURATION, dwEnd-dwStart);

        //fill the values
        m_strResult = bstrRes;
        m_strWindowName = theApp.GetWindowText((HWND)(LONG_PTR)hWnd);
        m_strWindowHandle.Format(_T("%X"), hWnd);
        m_strFont.Empty();
        m_nFontSize = 0;
        if(bstrRes.Length() > 0)
        {
            LOGFONT lf;
            theApp.DecodeFont(pFont, m_strFont, m_nFontSize, lf);
            ModifyFont(lf);
        }

        UpdateData(FALSE);    
    }
    catch(_com_error e)
    {
        //display error
        CComQIPtr<IErrorInfo> pErrInfo = e.ErrorInfo();
        CString strErr = e.ErrorMessage();
        if(pErrInfo)
        {
            CComBSTR bstrErr;
            if(S_OK == pErrInfo->GetDescription(&bstrErr))
                strErr = bstrErr;
        }
        AfxMessageBox(strErr, MB_OK | MB_ICONERROR);
    }
    catch(...)
    {
        //display error
        AfxMessageBox(IDS_CAPTURE_ERROR, MB_OK | MB_ICONERROR);
    }

}


void CActiveWindowDlg::OnCbnSelchangeComboScenario()
{
    int nIndex = m_cboScenario.GetCurSel();
    ATLASSERT(nIndex >= 0);
    if(0 == nIndex)
        return;
    m_enScenario = (E_SCENARIO)m_cboScenario.GetItemData(nIndex);
    EndDialog(IDOK);
}

void CActiveWindowDlg::ModifyFont(LOGFONT lf)
{
    CWnd *pWnd = GetDlgItem(IDC_EDIT_RESULT);
    if(NULL != pWnd)
    {
        BOOL bShouldDeleteOldObj = (NULL != m_pFontResult);
        CFont *pOldFont = pWnd->GetFont();

        m_pFontResult = new CFont();
        if(NULL != m_pFontResult)
        {
            if(m_bUseFormatting)
                ::lstrcpy(lf.lfFaceName, C_FIXED_FONT_NAME);

            m_pFontResult->CreateFontIndirect(&lf);
            pWnd->SetFont(m_pFontResult);

            if(bShouldDeleteOldObj)
            {
                pOldFont->DeleteObject();
                delete pOldFont;
            }
        }
    }
}
