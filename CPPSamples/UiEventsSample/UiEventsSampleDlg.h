
// UiEventsSampleDlg.h : header file
//

#pragma once
#include "EventHandler.h"


// CUiEventsSampleDlg dialog
class CUiEventsSampleDlg : public CDialogEx
{
// Construction
public:
	CUiEventsSampleDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_UIEVENTSSAMPLE_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()



	HRESULT GetEventInfo();
	void UpdateUI();
	void UnCheckKeyboard();
	void UnCheckMouse();
	//Attach to event
	void AttachToEvent();

	//attributes
protected:
	CComPtr<IUiEvents> m_spEvents;
	CEventHandler      m_evHandler;

	BOOL               m_bMouse;
	BOOL               m_bKeyboard;
	CString            m_strSelector;
	CString            m_strKey;
	UiMouseButton      m_enMouseBtn;
	UiKeyModifier      m_enKeyModifier;
	UiEventType        m_enEventType;
};
