// ScreenScrapDemoDlg.cpp : implementation file
//

#include "stdafx.h"
#include "ScreenScrapDemo.h"
#include "ScreenScrapDemoDlg.h"
#include ".\screenscrapdemodlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
public:
    CString m_strVersion;
    CString m_strCopyright;
    virtual BOOL OnInitDialog();
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
, m_strVersion(_T(""))
, m_strCopyright(_T(""))
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    DDX_Text(pDX, IDC_STATIC_VERSION, m_strVersion);
    DDX_Text(pDX, IDC_STATIC_COPYRIGHT, m_strCopyright);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()

BOOL CAboutDlg::OnInitDialog()
{
    CDialog::OnInitDialog();

    //read resource information
    CString strModule;
    ::GetModuleFileName(AfxGetInstanceHandle(), strModule.GetBuffer(MAX_PATH+1), MAX_PATH);
    strModule.ReleaseBuffer();

    DWORD dwHandle = 0;
    DWORD dwSize = ::GetFileVersionInfoSize(strModule, &dwHandle); 
    if(dwSize > 0) 
    {
        LPBYTE lpData = new BYTE[dwSize+1];
        ::GetFileVersionInfo (strModule, NULL, dwSize, lpData); 

        //get the version
        VS_FIXEDFILEINFO *pVerInfo = NULL;
        UINT nSize = 0;
        if (::VerQueryValue(lpData, _T("\\"), (LPVOID*)&pVerInfo, &nSize))
        { 
            m_strVersion.Format(IDS_STR_VERSION, HIWORD(pVerInfo->dwProductVersionMS),
                                                 LOWORD(pVerInfo->dwProductVersionMS),
                                                 HIWORD(pVerInfo->dwProductVersionLS),
                                                 LOWORD(pVerInfo->dwProductVersionLS));
        } 

        //now the copyright
        DWORD *pdwLanguages = NULL;
        if (::VerQueryValue(lpData, _T("\\VarFileInfo\\Translation"), (void**)&pdwLanguages, &nSize))
        { 
            UINT nTempSize = 0;
            LPTSTR lpszData = NULL;
            CString strQuery;
            strQuery.Format(_T("\\StringFileInfo\\%04X%04X\\LegalCopyright"), LOWORD(*pdwLanguages), HIWORD(*pdwLanguages));
            ::VerQueryValue(lpData, strQuery.GetBuffer(), (void**)&lpszData, &nSize); 
            m_strCopyright = lpszData;
        } 
        delete [] lpData;
    }

    UpdateData(FALSE);

    return TRUE;  // return TRUE unless you set the focus to a control
    // EXCEPTION: OCX Property Pages should return FALSE
}

// CScreenScrapDemoDlg dialog



CScreenScrapDemoDlg::CScreenScrapDemoDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CScreenScrapDemoDlg::IDD, pParent)
    , m_nScenario(0)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

CScreenScrapDemoDlg::~CScreenScrapDemoDlg()
{
}

void CScreenScrapDemoDlg::DoDataExchange(CDataExchange* pDX)
{
    CDialog::DoDataExchange(pDX);
    DDX_Radio(pDX, IDC_RADIO1, m_nScenario);
}

BEGIN_MESSAGE_MAP(CScreenScrapDemoDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
    ON_BN_CLICKED(IDC_OPEN_SAMPLES, OnBnClickedOpenSamples)
    ON_BN_CLICKED(IDC_LICENSING, OnBnClickedLicensing)
    ON_BN_CLICKED(IDC_HOME, OnBnClickedHome)
    ON_BN_CLICKED(IDC_BTN_HELP, OnBnClickedBtnHelp)
END_MESSAGE_MAP()


// CScreenScrapDemoDlg message handlers

BOOL CScreenScrapDemoDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CScreenScrapDemoDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CScreenScrapDemoDlg::OnPaint() 
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
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CScreenScrapDemoDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CScreenScrapDemoDlg::OnBnClickedOpenSamples()
{
    CString strPath;
    ::GetModuleFileName(NULL, strPath.GetBuffer(MAX_PATH+1), MAX_PATH);
    strPath.ReleaseBuffer();

    CPath path(strPath);
    path.RemoveFileSpec();
    path.Append(C_SAMPLES_FOLDER);

    ::ShellExecute(NULL, _T("explore"), path.m_strPath, NULL, NULL, SW_SHOWNORMAL);
}

void CScreenScrapDemoDlg::OnBnClickedLicensing()
{
    CString strPath;
    ::GetModuleFileName(NULL, strPath.GetBuffer(MAX_PATH+1), MAX_PATH);
    strPath.ReleaseBuffer();

    CPath path(strPath);
    path.RemoveFileSpec();
    path.Append(C_LICENSE);

    ::ShellExecute(NULL, _T("open"), path.m_strPath, NULL, NULL, SW_SHOWNORMAL);
}

void CScreenScrapDemoDlg::OnBnClickedHome()
{
    ::ShellExecute(NULL, _T("open"), C_HOME, NULL, NULL, SW_SHOWNORMAL);
}

void CScreenScrapDemoDlg::OnBnClickedBtnHelp()
{
    // TODO: Add your control notification handler code here
}

