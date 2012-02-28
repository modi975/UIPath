// ScreenScrapDemo.cpp : Defines the class behaviors for the application.
//

#include "stdafx.h"
#include "ScreenScrapDemo.h"
#include "ScreenScrapDemoDlg.h"
#include "WindowDlg.h"
#include "RegionDlg.h"
#include "ActiveWindowDlg.h"
#include ".\screenscrapdemo.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CScreenScrapDemoApp

BEGIN_MESSAGE_MAP(CScreenScrapDemoApp, CWinApp)
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()


// CScreenScrapDemoApp construction

CScreenScrapDemoApp::CScreenScrapDemoApp()
{
	// TODO: add construction code here,
	// Place all significant initialization in InitInstance
}


// The one and only CScreenScrapDemoApp object

CScreenScrapDemoApp theApp;


// CScreenScrapDemoApp initialization

BOOL CScreenScrapDemoApp::InitInstance()
{
	// InitCommonControls() is required on Windows XP if an application
	// manifest specifies use of ComCtl32.dll version 6 or later to enable
	// visual styles.  Otherwise, any window creation will fail.
	InitCommonControls();

	CWinApp::InitInstance();

	AfxEnableControlContainer();

    ::CoInitialize(NULL);
	// Standard initialization
	// If you are not using these features and wish to reduce the size
	// of your final executable, you should remove from the following
	// the specific initialization routines you do not need
	// Change the registry key under which our settings are stored
	// TODO: You should modify this string to be something appropriate
	// such as the name of your company or organization
	//SetRegistryKey(_T("Local AppWizard-Generated Applications"));

    CWnd *pDesktop = CWnd::GetDesktopWindow();
    if(NULL != pDesktop)
    {
        CDC *pDC = pDesktop->GetDC();
        if(NULL != pDC)
        {
            m_nLogPixelsY = pDC->GetDeviceCaps(LOGPIXELSY);
            pDesktop->ReleaseDC(pDC);
        }
    }

    E_SCENARIO enScenario = E_REGION;
    BOOL bSkipMainDlg = FALSE;
    do
    {
        if(!bSkipMainDlg)
        {
	        CScreenScrapDemoDlg dlg;
	        //m_pMainWnd = &dlg;
            dlg.m_nScenario = enScenario;
	        if(IDOK != dlg.DoModal())
                break;
            enScenario = (E_SCENARIO)dlg.m_nScenario;
        }

        INT_PTR nRes = IDCANCEL;
        switch(enScenario)
        {
            case E_REGION:
            {
                CRegionDlg dlgScenario;
                nRes = dlgScenario.DoModal();
                enScenario = (E_SCENARIO)dlgScenario.m_enScenario;
                break;
            }
            case E_WINDOW:
            {
                CWindowDlg dlgScenario;
                nRes = dlgScenario.DoModal();
                enScenario = (E_SCENARIO)dlgScenario.m_enScenario;
                break;
            }
            case E_ACTIVE:
            {
                CActiveWindowDlg dlgScenario;
                nRes = dlgScenario.DoModal();
                enScenario = (E_SCENARIO)dlgScenario.m_enScenario;
                break;
            }
        }
        bSkipMainDlg = (IDOK == nRes);
    }
    while(TRUE);

	// Since the dialog has been closed, return FALSE so that we exit the
	//  application, rather than start the application's message pump.
	return FALSE;
}


int CScreenScrapDemoApp::ExitInstance()
{
	// Create UiSystem.
    IUiSystemPtr spSys;
    HRESULT      hr = spSys.CreateInstance(CLSID_UiSystem);

    if (SUCCEEDED(hr) && spSys)
    {
		try
		{
			spSys->Cleanup();
		}
		catch (_com_error)
		{
		}

		spSys.Release();
    }

	::CoUninitialize();
    return CWinApp::ExitInstance();
}


BOOL CScreenScrapDemoApp::CopyTextToClipboard(const CString &strText)
{
	if (strText.IsEmpty())
	{
		return FALSE;
	}

	int nLength = strText.GetLength() + 1;
	int nSize = (nLength) * sizeof(WCHAR);

	LPWSTR wzCopy = NULL;
	BOOL   bOpen  = FALSE;

	HGLOBAL hglbCopy = ::GlobalAlloc(GMEM_MOVEABLE, nSize);
	if (NULL == hglbCopy)
	{
		goto CleanUp;
	}

	wzCopy = (LPWSTR)::GlobalLock(hglbCopy);                   		
	::CopyMemory(wzCopy, CT2W(strText), nSize);
	::GlobalUnlock(hglbCopy);

	bOpen = ::OpenClipboard(NULL);
	if (!bOpen)
		goto CleanUp;

	::SetClipboardData(CF_UNICODETEXT, hglbCopy);

CleanUp:
	if(NULL != hglbCopy)
		::GlobalDiscard( hglbCopy );
	if(bOpen)
		::CloseClipboard();

	return TRUE;
}

CString CScreenScrapDemoApp::GetWindowText(HWND hWnd)
{
    CString strRes;
    TCHAR szTitle[MAX_PATH+1];
    if(::SendMessage(hWnd, WM_GETTEXT, MAX_PATH, (LPARAM)szTitle) > 0)
        strRes = szTitle;

    return strRes;
}

BOOL CScreenScrapDemoApp::Select(TS_SELECTION selType, CComPtr<ITSelectionInfo> &pSelInfo)
{
    CComPtr<ITSelection> pSelection;
    HRESULT hr = pSelection.CoCreateInstance(CLSID_TSelection);
    if (FAILED(hr) || !pSelection)
    {
        AfxMessageBox(IDS_ERR_CREATE_CAPTURE_OBJ, MB_OK | MB_ICONERROR);
        return FALSE;
    }

    LONG nRes = 0;

    try
    {
        CComPtr<IDispatch> tSelInfo;
		tSelInfo = pSelection->Start(selType, tsSelFlagDefaultText);
		
		if (tSelInfo)
		{
			tSelInfo->QueryInterface(IID_ITSelectionInfo, (void**)&pSelInfo);
		}
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
    }

    return (tsSelResultSuccess == (TS_SELECTION_RESULT)nRes);
}

void CScreenScrapDemoApp::DecodeFont(CComPtr<IFontDisp>& pFontDisp, CString &strFont, LONG &nSize, LOGFONT &lf)
{
	strFont.Empty();
	nSize = 0;
    ::ZeroMemory(&lf, sizeof(LOGFONT));

	CComQIPtr<IFont> pFont = pFontDisp;
	if(pFont)
	{
		CComBSTR bstrFontName;
		HRESULT hr = pFont->get_Name(&bstrFontName);
		if(FAILED(hr))
			return;
		strFont = bstrFontName;
        ::lstrcpy(lf.lfFaceName, strFont);

		CY size;// = 0;
		hr = pFont->get_Size(&size);
		if(FAILED(hr))
			return;
        nSize = (int)(size.int64/10000);
        lf.lfHeight = (int)-(size.int64*m_nLogPixelsY)/(10000*72);

        BOOL bVal = FALSE;
        hr = pFont->get_Italic(&bVal);
        lf.lfItalic = bVal;
    
        hr = pFont->get_Strikethrough(&bVal);
        lf.lfStrikeOut = bVal;
    
        hr = pFont->get_Underline(&bVal);
        lf.lfUnderline = bVal;
    
        SHORT sVal = 0;
        hr = pFont->get_Charset(&sVal);
        lf.lfCharSet = (BYTE)sVal;
    
        hr = pFont->get_Weight(&sVal);
        lf.lfWeight = sVal;
	}
} 

void CScreenScrapDemoApp::RestoreWindow(CWnd *pWnd, int nNewHeight)
{
    ATLASSERT(NULL != pWnd);
    ATLASSERT(nNewHeight > 0);
    if(NULL != pWnd)
    {
        CRect rcWin;
        pWnd->GetWindowRect(rcWin);
        rcWin.bottom = rcWin.top + nNewHeight;
        pWnd->MoveWindow(rcWin, FALSE);
    }
}

void CScreenScrapDemoApp::InitComboScenario(CComboBox& cbo, E_SCENARIO enSkip)
{
    cbo.ResetContent();
    int nIndex = cbo.AddString(_T("Choose another scenario"));
    ATLASSERT(nIndex >= 0);

    if(E_REGION != enSkip)
    {
        nIndex = cbo.AddString(_T("Region"));
        ATLASSERT(nIndex >= 0);
        cbo.SetItemData(nIndex, E_REGION);
    }
    if(E_WINDOW != enSkip)
    {
        nIndex = cbo.AddString(_T("Window"));
        ATLASSERT(nIndex >= 0);
        cbo.SetItemData(nIndex, E_WINDOW);
    }
    if(E_ACTIVE != enSkip)
    {
        nIndex = cbo.AddString(_T("Active window"));
        ATLASSERT(nIndex >= 0);
        cbo.SetItemData(nIndex, E_ACTIVE);
    }

    cbo.SetCurSel(0);
}
