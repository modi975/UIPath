
// UiEventsSampleDlg.cpp : implementation file
//

#include "stdafx.h"
#include "UiEventsSample.h"
#include "UiEventsSampleDlg.h"
#include "afxdialogex.h"
#include "resource.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
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
};

CAboutDlg::CAboutDlg() : CDialogEx(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)

END_MESSAGE_MAP()


// CUiEventsSampleDlg dialog




CUiEventsSampleDlg::CUiEventsSampleDlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(CUiEventsSampleDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	m_bMouse = FALSE;
	m_bKeyboard = FALSE;
}

void CUiEventsSampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CUiEventsSampleDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_COMMAND(ID_ATTACH, AttachToEvent)
	ON_COMMAND(IDC_MOUSE_CHECK, UnCheckKeyboard)
	ON_COMMAND(IDC_KEYBOARD_CHECK, UnCheckMouse)
END_MESSAGE_MAP()


// CUiEventsSampleDlg message handlers

BOOL CUiEventsSampleDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
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

	// TODO: Add extra initialization here

	UpdateUI();
	
     
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CUiEventsSampleDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CUiEventsSampleDlg::OnPaint()
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
HCURSOR CUiEventsSampleDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CUiEventsSampleDlg::AttachToEvent()
{
	CButton* attachButton = (CButton*)GetDlgItem(ID_ATTACH);
	CString buttonText;
	attachButton->GetWindowText(buttonText);
	if(buttonText == _T("Attach to event"))
	{
		attachButton->SetWindowText(_T("Stop event"));
		HRESULT hr = GetEventInfo();
		if(!FAILED(hr))
		{
			if(hr == S_OK)
			{
				if( m_spNodeEvents!= nullptr)
				{
					m_evNodeHandler.DispEventUnadvise(m_spNodeEvents);
					m_spNodeEvents->StopMonitoring();
					m_spNodeEvents.Release();		
				}
				m_spNodeEvents.CoCreateInstance(CLSID_UiNodeMonitor);
				m_evNodeHandler.m_enEventMode = m_enEventMode;
				//Connect to UiNodeMonitor object
				m_evNodeHandler.DispEventAdvise(m_spNodeEvents);
				//a selector was inserted
				if(m_bMouse)
				{
					m_spNodeEvents->MonitorClick(m_enMouseBtn, m_enKeyModifier, m_enEventType, (_bstr_t)m_strSelector, m_bMatchChildren, NULL);
				}
				else
				{
					m_spNodeEvents->MonitorHotkey((_bstr_t)m_strKey, m_enKeyModifier, m_enEventType, (_bstr_t)m_strSelector, m_bMatchChildren);
				}
			}
			else
			{
				//system monitor

				if( m_spSystem!= nullptr)
				{
					m_evSystemHandler.DispEventUnadvise(m_spSystem);
					m_spSystem->StopMonitoring();
					m_spSystem.Release();		
				}
				m_spSystem.CoCreateInstance(CLSID_UiSystem);

				//Connect to UiSystem object
				m_evSystemHandler.DispEventAdvise(m_spSystem);

				if(m_bMouse)
				{
					m_spSystem->MonitorClick(m_enMouseBtn, m_enKeyModifier, m_enEventMode);
				}
				else
				{
					m_spSystem->MonitorHotkey((_bstr_t)m_strKey, m_enKeyModifier);
				}
			}
		}
		else
		{
			attachButton->SetWindowText(_T("Attach to event"));
		}
	}
	else
	{
		attachButton->SetWindowText(_T("Attach to event"));
		if( m_spNodeEvents != nullptr)
		{
			m_evNodeHandler.DispEventUnadvise(m_spNodeEvents);
			m_spNodeEvents->StopMonitoring();
			m_spNodeEvents.Release();		
		}
		if( m_spSystem != nullptr)
		{
			m_evSystemHandler.DispEventUnadvise(m_spSystem);
			m_spSystem->StopMonitoring();
			m_spSystem.Release();		
		}
	}
	

}

HRESULT CUiEventsSampleDlg::GetEventInfo()
{
	HRESULT hr;
	//Get event info
	CEdit* selectorEdit = (CEdit*)GetDlgItem(IDC_SELECTOR);
	selectorEdit->GetWindowText(m_strSelector);
	if(m_strSelector.IsEmpty())
	{
		hr = S_FALSE;
	}
	else
	{
		hr = S_OK;
	}
	CButton* mouseCheckBox = (CButton*) GetDlgItem(IDC_MOUSE_CHECK);
	CButton* keyboardCheckBox = (CButton*) GetDlgItem(IDC_KEYBOARD_CHECK);

	if(mouseCheckBox->GetCheck())
	{
		m_bMouse = TRUE;
		CComboBox* mouseBtn = (CComboBox*) GetDlgItem(IDC_MOUSE_BTN);

		//get mouse button
		m_enMouseBtn = (UiMouseButton)mouseBtn->GetCurSel();
	}
	if(keyboardCheckBox->GetCheck())
	{
		m_bKeyboard = TRUE;
		CComboBox* keyCombo = (CComboBox*)GetDlgItem(IDC_COMBO_KEY);
		keyCombo->GetLBText(keyCombo->GetCurSel(), m_strKey);
	}

	if(!m_bMouse && !m_bKeyboard)
	{
		AfxMessageBox(_T("You must check a checkbox"));
		hr = E_FAIL;
	}

	CComboBox* keyModifier = (CComboBox*)GetDlgItem(IDC_COMBO_KEY_MODIF);
	m_enKeyModifier = (UiKeyModifier)keyModifier->GetCurSel();

	CComboBox* eventType = (CComboBox*)GetDlgItem(IDC_COMBO_EVENT_TYPE);
	m_enEventType = (UiEventType)eventType->GetCurSel();

	m_bMatchChildren = ((CButton*)GetDlgItem(IDC_CHECK_INCLUDE_CHILDREN))->GetCheck();
	m_enEventMode = (UiEventMode)((CComboBox*)GetDlgItem(IDC_COMBO_MONITOR_TYPE))->GetCurSel();
	return hr;
}

void CUiEventsSampleDlg::UpdateUI()
{
	CButton* mouseCheckBox = (CButton*) GetDlgItem(IDC_MOUSE_CHECK);
	mouseCheckBox->SetCheck(TRUE);
	UnCheckKeyboard();
	m_bMatchChildren = FALSE;

	//Add mouse btns
    CComboBox* mouseBtn = (CComboBox*) GetDlgItem(IDC_MOUSE_BTN);
	mouseBtn->InsertString(0, L"UI_BTN_LEFT");
	mouseBtn->InsertString(1, L"UI_BTN_RIGHT");
	mouseBtn->InsertString(2, L"UI_BTN_MIDDLE");
	mouseBtn->SetCurSel(0);


	//Add keys
	CComboBox* keyCombo = (CComboBox*)GetDlgItem(IDC_COMBO_KEY);
	keyCombo->InsertString(0, L"alt");
	keyCombo->InsertString(1, L"lalt");
	keyCombo->InsertString(2, L"ralt");
	keyCombo->InsertString(3, L"shift");
	keyCombo->InsertString(4, L"lshift");
	keyCombo->InsertString(5, L"rshift");
	keyCombo->InsertString(6, L"ctrl");
	keyCombo->InsertString(7, L"lctrl");
	keyCombo->InsertString(8, L"rctrl");
	keyCombo->InsertString(9, L"ins");
	keyCombo->InsertString(10, L"del");
	keyCombo->InsertString(11, L"home");
	keyCombo->InsertString(12, L"end");
	keyCombo->InsertString(13, L"pgup");
	keyCombo->InsertString(14, L"pgdn");
	keyCombo->InsertString(15, L"enter");
	keyCombo->InsertString(16, L"left");
	keyCombo->InsertString(17, L"right");
	keyCombo->InsertString(18, L"up");
	keyCombo->InsertString(19, L"down");
	keyCombo->InsertString(20, L"tab");
	keyCombo->InsertString(21, L"esc");
	keyCombo->InsertString(22, L"back");
	keyCombo->InsertString(23, L"pause");
	keyCombo->InsertString(24, L"f1");
	keyCombo->InsertString(25, L"f2");
	keyCombo->InsertString(26, L"f3");
	keyCombo->InsertString(27, L"f4");
	keyCombo->InsertString(28, L"f5");
	keyCombo->InsertString(29, L"f6");
	keyCombo->InsertString(30, L"f7");
	keyCombo->InsertString(31, L"f8");
	keyCombo->InsertString(32, L"f9");
	keyCombo->InsertString(33, L"f10");
	keyCombo->InsertString(34, L"f11");
	keyCombo->InsertString(35, L"f12");
	keyCombo->InsertString(36, L"caps");
	keyCombo->InsertString(37, L"num");
	keyCombo->InsertString(38, L"add");
	keyCombo->InsertString(39, L"sub");
	keyCombo->InsertString(40, L"mul");
	keyCombo->InsertString(41, L"div");
	keyCombo->InsertString(42, L"decimal");
	keyCombo->InsertString(43, L"break");
	keyCombo->InsertString(44, L"num0");
	keyCombo->InsertString(45, L"num1");
	keyCombo->InsertString(46, L"num2");
	keyCombo->InsertString(47, L"num3");
	keyCombo->InsertString(48, L"num4");
	keyCombo->InsertString(49, L"num5");
	keyCombo->InsertString(50, L"num6");
	keyCombo->InsertString(51, L"num7");
	keyCombo->InsertString(52, L"num8");
	keyCombo->InsertString(53, L"num9");
	keyCombo->InsertString(54, L"scroll");
	keyCombo->InsertString(55, L"sleep");
	keyCombo->SetCurSel(0);

	//Add key modifier
	CComboBox* keyModifier = (CComboBox*)GetDlgItem(IDC_COMBO_KEY_MODIF);
	keyModifier->InsertString(0, L"UiKeyEx_None");
	keyModifier->InsertString(2, L"UiKeyEx_Alt");
	keyModifier->InsertString(3, L"UiKeyEx_Ctrl");
	keyModifier->InsertString(4, L"UiKeyEx_AltCtrl");
	keyModifier->InsertString(5, L"UiKeyEx_Shift");
	keyModifier->InsertString(6, L"UiKeyEx_ShiftAlt");
	keyModifier->InsertString(7, L"UI_KEY_ShiftCtrl");
	keyModifier->InsertString(8, L"UI_KEY_ShiftAltCtrl");
	keyModifier->InsertString(9, L"UI_KEY_Win");
	keyModifier->InsertString(10, L"UI_KEY_WinAlt");
	keyModifier->InsertString(11, L"UI_KEY_WinCtrl");
	keyModifier->InsertString(12, L"UI_KEY_WinAltCtrl");
	keyModifier->InsertString(13, L"UI_KEY_WinShift");
	keyModifier->InsertString(14, L"UI_KEY_WinShiftAlt");
	keyModifier->InsertString(15, L"UI_KEY_WinShiftCtrl");
	keyModifier->InsertString(16, L"UI_KEY_WinShiftAltCtrl");
	keyModifier->SetCurSel(0);

	//Add Event type
	CComboBox* eventType = (CComboBox*)GetDlgItem(IDC_COMBO_EVENT_TYPE);
	eventType->InsertString(0, L"UI_EVENT_ASYNCHRONOUS");
	eventType->InsertString(1, L"UI_EVENT_SYNCHRONOUS");
	eventType->SetCurSel(0);

	//Add Monitor Type
	CComboBox* monitorType = (CComboBox*)GetDlgItem(IDC_COMBO_MONITOR_TYPE);
	monitorType->InsertString(0, L"UI_EVENT_FORWARD");
	monitorType->InsertString(1, L"UI_EVENT_BLOCK");
	monitorType->SetCurSel(0);
	m_enEventMode = UI_EVENT_FORWARD;
}

void CUiEventsSampleDlg::UnCheckKeyboard()
{
	CComboBox* mouseBtn = (CComboBox*) GetDlgItem(IDC_MOUSE_BTN);
	mouseBtn->EnableWindow(TRUE);
	CButton* keyboardCheckBox = (CButton*) GetDlgItem(IDC_KEYBOARD_CHECK);
	keyboardCheckBox->SetCheck(FALSE);
	CComboBox* keyCombo = (CComboBox*)GetDlgItem(IDC_COMBO_KEY);
	keyCombo->EnableWindow(FALSE);
}
void CUiEventsSampleDlg::UnCheckMouse()
{
	CComboBox* keyCombo = (CComboBox*)GetDlgItem(IDC_COMBO_KEY);
	keyCombo->EnableWindow(TRUE);
	CButton* mouseCheckBox = (CButton*) GetDlgItem(IDC_MOUSE_CHECK);
	mouseCheckBox->SetCheck(FALSE);
	CComboBox* mouseBtn = (CComboBox*) GetDlgItem(IDC_MOUSE_BTN);
	mouseBtn->EnableWindow(FALSE);
}