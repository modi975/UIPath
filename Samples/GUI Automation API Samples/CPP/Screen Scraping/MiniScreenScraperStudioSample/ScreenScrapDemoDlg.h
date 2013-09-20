// ScreenScrapDemoDlg.h : header file
//

#pragma once
#include "afxwin.h"


// CScreenScrapDemoDlg dialog
class CScreenScrapDemoDlg : public CDialog
{
// Construction
public:
	CScreenScrapDemoDlg(CWnd* pParent = NULL);	// standard constructor
	~CScreenScrapDemoDlg();

// Dialog Data
	enum { IDD = IDD_SCREENSCRAPDEMO_DIALOG };

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
    afx_msg void OnBnClickedOpenSamples();
    afx_msg void OnBnClickedLicensing();
    afx_msg void OnBnClickedHome();
    afx_msg void OnBnClickedBtnHelp();

	DECLARE_MESSAGE_MAP()

public:
    int m_nScenario;
};
