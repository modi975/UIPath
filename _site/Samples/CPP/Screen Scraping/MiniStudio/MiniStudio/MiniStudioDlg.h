
// MiniStudioDlg.h : header file
//

#pragma once


enum Scenario
{
    ACTIVE_WINDOW = 0,
    UIOBJECT,
    REGION
};

// CMiniStudioDlg dialog
class CMiniStudioDlg : public CDialogEx
{
// Construction
public:
	CMiniStudioDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_MINISTUDIO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
    void SelectedActive();
    void SelectedUIObject();
    void SelectedRegion();
    void Scrape();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()

    Scenario m_enScenario;
};
