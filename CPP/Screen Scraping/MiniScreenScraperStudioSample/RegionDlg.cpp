// RegionDlg.cpp : implementation file
#include "stdafx.h"
#include "ScreenScrapDemo.h"
#include "RegionDlg.h"


// CRegionDlg dialog
IMPLEMENT_DYNAMIC(CRegionDlg, CDialog)
CRegionDlg::CRegionDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CRegionDlg::IDD, pParent)
    , m_strResult(_T(""))
    , m_strWindowName(_T(""))
    , m_strWindowHandle(_T(""))
    , m_strFont(_T(""))
    , m_nFontSize(0)
    , m_nX(0)
    , m_nY(0)
    , m_nWidth(0)
    , m_nHeight(0)
    , m_strDuration(_T(""))
    , m_bUseFormatting(TRUE)
{
    m_nFullHeight = 0;
    m_enScenario = E_REGION;
    m_pFontResult = NULL;
}


CRegionDlg::~CRegionDlg()
{
    if (NULL != m_pFontResult)
    {
        m_pFontResult->DeleteObject();
        delete m_pFontResult;
        m_pFontResult = NULL;
    }
}


void CRegionDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    DDX_Text(pDX, IDC_EDIT_RESULT, m_strResult);
    DDX_Text(pDX, IDC_EDIT_WND_NAME, m_strWindowName);
    DDX_Text(pDX, IDC_EDIT_WND_HANDLE, m_strWindowHandle);
    DDX_Text(pDX, IDC_EDIT_FONT, m_strFont);
    DDX_Text(pDX, IDC_EDIT_FONT_SIZE, m_nFontSize);
    DDX_Text(pDX, IDC_EDIT_X, m_nX);
    DDX_Text(pDX, IDC_EDIT_Y, m_nY);
    DDX_Text(pDX, IDC_EDIT_WIDTH, m_nWidth);
    DDX_Text(pDX, IDC_EDIT_HEIGHT, m_nHeight);
    DDX_Control(pDX, IDC_COMBO_SCENARIO, m_cboScenario);
    DDX_Text(pDX, IDC_STATIC_DURATION, m_strDuration);
    DDX_Check(pDX, IDC_CHECK_USE_FORMATED_TEXT, m_bUseFormatting);
}


BEGIN_MESSAGE_MAP(CRegionDlg, CDialog)
    ON_BN_CLICKED(IDC_SELECT, OnBnClickedSelect)
    ON_BN_CLICKED(IDC_COPY_CLIPBOARD, OnBnClickedCopyClipboard)
    ON_BN_CLICKED(IDC_EXTRACT, OnBnClickedExtract)
    ON_CBN_SELCHANGE(IDC_COMBO_SCENARIO, OnCbnSelchangeComboScenario)
END_MESSAGE_MAP()


// CRegionDlg message handlers

BOOL CRegionDlg::OnInitDialog()
{
    CDialog::OnInitDialog();

    CRect rcWin;
    GetWindowRect(rcWin);
    m_nFullHeight = rcWin.Height();

    // Show only upper part
    CWnd *pWnd = GetDlgItem(IDC_STATIC_SELECTION);
    if (NULL != pWnd)
    {
        CRect rcCtrl;
        pWnd->GetWindowRect(rcCtrl);

        // Set new height
        rcWin.bottom = rcCtrl.top;

        //now center
        int nPixelsX = ::GetSystemMetrics(SM_CXSCREEN);
        int nPixelsY = ::GetSystemMetrics(SM_CYSCREEN);
        rcWin.OffsetRect((nPixelsX-rcWin.Width())/2, (nPixelsY-m_nFullHeight)/2);

        MoveWindow(rcWin);
    }

    // Init scenario combo
    theApp.InitComboScenario(m_cboScenario, E_REGION);

    return TRUE;  // return TRUE unless you set the focus to a control
    // EXCEPTION: OCX Property Pages should return FALSE
}


void CRegionDlg::OnBnClickedSelect()
{
    UpdateData();

    ShowWindow(SW_HIDE);

    CRect rcCapture;
    CComPtr<ITSelectionInfo> pSelInfo;
	CComSafeArray<VARIANT, VT_VARIANT> arSafePoints;
    int nCount = 0;
    LONG hWnd = NULL;
    VARIANT points;

    if (!theApp.Select(tsSelectionRectangle, pSelInfo))
	{
        goto Exit;
	}

    // Capture region
    hWnd = pSelInfo->WindowHandle;
    pSelInfo->get_Points(&points);

	// Ttransform safe arry points
	arSafePoints.CopyFrom(points.parray);
	nCount = (int)arSafePoints.GetCount();
    ATLASSERT(2 == nCount);
    if (2 != nCount)
	{
        goto Exit;
	}

    rcCapture.SetRect(GET_X_LPARAM(arSafePoints[0].lVal), GET_Y_LPARAM(arSafePoints[0].lVal),
                      GET_X_LPARAM(arSafePoints[1].lVal), GET_Y_LPARAM(arSafePoints[1].lVal));

    // Fill the values
    m_strWindowName = theApp.GetWindowText((HWND)(LONG_PTR)hWnd);
    m_strWindowHandle.Format(_T("%X"), hWnd);

    m_nX = rcCapture.left;
    m_nY = rcCapture.top;

    m_nWidth  = rcCapture.Width();
    m_nHeight = rcCapture.Height();

    // Capture
    DoCapture(hWnd, rcCapture);

    UpdateData(FALSE);

Exit:
    if (m_nFullHeight > 0)
    {
        //restore the window
        theApp.RestoreWindow(this, m_nFullHeight);
        m_nFullHeight = 0;
    }

    ShowWindow(SW_SHOW);
}

void CRegionDlg::OnBnClickedCopyClipboard()
{
    UpdateData();
    theApp.CopyTextToClipboard(m_strResult);
}


void CRegionDlg::OnBnClickedExtract()
{
    if (!UpdateData())
	{
        return;
	}

    LONG  hWnd = _tcstol(m_strWindowHandle, NULL, 16);
    CRect rcCapture(m_nX, m_nY, m_nX + m_nWidth, m_nY + m_nHeight);

    DoCapture(hWnd, rcCapture);

    UpdateData(FALSE);
}


void CRegionDlg::DoCapture(LONG nWnd, const CRect& rcCapture)
{
	HWND hWnd = static_cast<HWND>(LongToHandle(nWnd));

	// rcCapture is in screen coordinates. Convert to client.
	POINT ptTopLeft = { rcCapture.left, rcCapture.top };
	::ScreenToClient(hWnd, &ptTopLeft);
	
	// Create node.
    IUiNodePtr spNode;
    HRESULT    hr = spNode.CreateInstance(CLSID_UiNode);

    if (FAILED(hr) || !spNode)
    {
        AfxMessageBox(IDS_ERR_CREATE_NODE_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

	// Create scraping option.
	IUiScrapeOptionsPtr spOpt;

	hr = spOpt.CreateInstance(CLSID_UiScrapeOptions);
    if (FAILED(hr) || !spOpt)
    {
        AfxMessageBox(IDS_ERR_CREATE_OPTION_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

	// Create region.
    IUiRegionPtr spRegion;
    
	hr = spRegion.CreateInstance(CLSID_UiRegion);
    if (FAILED(hr) || !spNode)
    {
        AfxMessageBox(IDS_ERR_CREATE_REGION_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

    try
    {
		// Initialize region.
		spRegion->left   = ptTopLeft.x;
		spRegion->top    = ptTopLeft.y;
		spRegion->right  = ptTopLeft.x + rcCapture.Width();
		spRegion->bottom = ptTopLeft.y + rcCapture.Height();

		// Attach  the node to hwnd.
		spNode->Set(_bstr_t("hwnd"), _variant_t(nWnd));

		// Set clipping region.
		spNode->clippingRegion = spRegion;

		// Specify scraping options.
		spOpt->Set(_bstr_t("getfont"), _variant_t(true));

		// Set native extraction method.
		spOpt->Set(_bstr_t("scrapingmethod"), _variant_t(UI_NATIVE));

		if (m_bUseFormatting)
		{
			// formattedtext - default false.
			spOpt->Set(_bstr_t("formattedtext"), _variant_t(true));
		}

        DWORD dwStart = ::GetTickCount();;
        //bstrRes = (BSTR)pCapture->GetTextFromRectWithFont(hWnd, rcCapture.left, rcCapture.top, rcCapture.Width(), rcCapture.Height(), &pFont);

		IUiScrapeResultPtr scrapeResult = spNode->Scrape(spOpt);

        DWORD dwEnd = ::GetTickCount();

        m_strDuration.Format(IDS_DURATION, dwEnd-dwStart);

        // Fill the values
        m_strResult = (LPCTSTR)scrapeResult->text;
        m_strFont.Empty();
        m_nFontSize = 0;

        if (m_strResult.GetLength() > 0)
        {
            LOGFONT lf;
            theApp.DecodeFont(CComQIPtr<IFontDisp>(scrapeResult->font), m_strFont, m_nFontSize, lf);
            ModifyFont(lf);
        }
    }
    catch (_com_error e)
    {
        // Display error
        AfxMessageBox(e.Description(), MB_OK | MB_ICONERROR);
    }
    catch (...)
    {
        // Display error
        AfxMessageBox(IDS_CAPTURE_ERROR, MB_OK | MB_ICONERROR);
    }
}


void CRegionDlg::OnCbnSelchangeComboScenario()
{
    int nIndex = m_cboScenario.GetCurSel();
    ATLASSERT(nIndex >= 0);

    if (0 == nIndex)
	{
        return;
	}

    m_enScenario = (E_SCENARIO)m_cboScenario.GetItemData(nIndex);
    EndDialog(IDOK);
}


void CRegionDlg::ModifyFont(LOGFONT lf)
{
    CWnd *pWnd = GetDlgItem(IDC_EDIT_RESULT);
    if (NULL != pWnd)
    {
        BOOL bShouldDeleteOldObj = (NULL != m_pFontResult);
        CFont *pOldFont = pWnd->GetFont();

        m_pFontResult = new CFont();
        if (NULL != m_pFontResult)
        {
            if (m_bUseFormatting)
			{
                ::lstrcpy(lf.lfFaceName, C_FIXED_FONT_NAME);
			}

            m_pFontResult->CreateFontIndirect(&lf);
            pWnd->SetFont(m_pFontResult);

            if (bShouldDeleteOldObj)
            {
                pOldFont->DeleteObject();
                delete pOldFont;
            }
        }
    }
}
