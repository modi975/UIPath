
// ClickNodeDlg.h : header file
//

#pragma once
#include "afxwin.h"


// CClickNodeDlg dialog
class CClickNodeDlg : public CDialogEx
{
// Construction
public:
	CClickNodeDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_WRITE_TEXT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
    afx_msg void OnBnClickedSelectBtn();
    afx_msg void OnBnClickedClickBtn();
    CString m_hwnd;
    CString m_selector;
    CComboBox m_inputMethodCombo;
    CString m_textToType;
};
