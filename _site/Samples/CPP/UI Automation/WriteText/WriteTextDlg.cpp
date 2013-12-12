// ClickNodeDlg.cpp : implementation file
#include "stdafx.h"
#include "WriteText.h"
#include "WriteTextDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

using namespace UiPathLib;


CClickNodeDlg::CClickNodeDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CClickNodeDlg::IDD, pParent)
    , m_hwnd(_T(""))
    , m_selector(_T(""))
    , m_textToType(_T(""))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CClickNodeDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialogEx::DoDataExchange(pDX);
    DDX_Text(pDX, IDC_HWND_EDIT, m_hwnd);
    DDX_Text(pDX, IDC_SELECTOR_EDIT, m_selector);
    DDX_Control(pDX, IDC_INPUT_METHOD_COMBO, m_inputMethodCombo);
    DDX_Text(pDX, IDC_TEXT_EDIT, m_textToType);
}

BEGIN_MESSAGE_MAP(CClickNodeDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
    ON_BN_CLICKED(IDC_SELECT_BTN, &CClickNodeDlg::OnBnClickedSelectBtn)
    ON_BN_CLICKED(IDC_CLICK_BTN, &CClickNodeDlg::OnBnClickedClickBtn)
END_MESSAGE_MAP()


// CClickNodeDlg message handlers

BOOL CClickNodeDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

    m_inputMethodCombo.AddString(_T("Hardware Events"));
    m_inputMethodCombo.AddString(_T("Win32 Messages"));
    m_inputMethodCombo.AddString(_T("Control API"));
    m_inputMethodCombo.SetCurSel(0);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CClickNodeDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CClickNodeDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CClickNodeDlg::OnBnClickedSelectBtn()
{
	// Create node.
    IUiNodePtr spNode;
    HRESULT    hr = spNode.CreateInstance(CLSID_UiNode);

    if (FAILED(hr) || !spNode)
    {
        AfxMessageBox(IDS_ERR_CREATE_NODE_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

    ShowWindow(SW_HIDE);

    try
    {
        spNode->SelectInteractive(UI_SELECT_NODE);

        m_hwnd.Format(_T("0x%x"), spNode->Get(_bstr_t("hwnd")).lVal);
        m_selector = (LPCWSTR)spNode->GetSelector(false);
    }
    catch (_com_error e)
    {
        // display error
        AfxMessageBox(e.Description(), MB_OK | MB_ICONERROR);
    }

    UpdateData(FALSE);
    ShowWindow(SW_SHOW);
}


void CClickNodeDlg::OnBnClickedClickBtn()
{
	// Create node.
    IUiNodePtr spNode;
    HRESULT    hr = spNode.CreateInstance(CLSID_UiNode);

    if (FAILED(hr) || !spNode)
    {
        AfxMessageBox(IDS_ERR_CREATE_NODE_OBJ, MB_OK | MB_ICONERROR);
        return;
    }

    UpdateData();

    UiInputMethod inputMeth = (UiInputMethod)m_inputMethodCombo.GetCurSel();

    ShowWindow(SW_HIDE);

    try
    {
        spNode->timeout = 1000;
        spNode->FromSelector(_bstr_t(m_selector));

        if (UI_HARDWARE_EVENTS == inputMeth)
        {
            spNode->Click(2, 2, UI_CLICK_SINGLE, UI_BTN_LEFT, inputMeth);
        }

        spNode->WriteText(_bstr_t(m_textToType), inputMeth);
        
    }
    catch (_com_error e)
    {
        // display error
        AfxMessageBox(e.Description(), MB_OK | MB_ICONERROR);
    }

    ::Sleep(250);
    ShowWindow(SW_RESTORE);
}
