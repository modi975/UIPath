#pragma once
#include "afxwin.h"


// CActiveWindowDlg dialog

class CActiveWindowDlg : public CDialog
{
	DECLARE_DYNAMIC(CActiveWindowDlg)

public:
	CActiveWindowDlg(CWnd* pParent = NULL);   // standard constructor
	virtual ~CActiveWindowDlg();

// Dialog Data
	enum { IDD = IDD_TCXNEW_DIALOG_ACTIVE_WINDOW };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()

public:
    virtual BOOL OnInitDialog();
    afx_msg void OnBnClickedExtract();
    afx_msg void OnBnClickedCopyClipboard();
    afx_msg void OnCbnSelchangeComboScenario();

    void DoCapture();
    void ModifyFont(LOGFONT lf);

    //data members
protected:
    int m_nFullHeight;
public:
    CString m_strResult;
    CString m_strWindowName;
    CString m_strWindowHandle;
    CString m_strFont;
    LONG m_nFontSize;
    int m_nType;
    CComboBox m_cboScenario;
    E_SCENARIO m_enScenario;
    CString m_strDuration;
    BOOL m_bUseFormatting;
    CFont   *m_pFontResult;
};
