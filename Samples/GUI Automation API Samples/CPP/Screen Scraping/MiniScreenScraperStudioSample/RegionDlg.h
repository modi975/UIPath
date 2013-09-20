#pragma once
#include "afxwin.h"


// CRegionDlg dialog

class CRegionDlg : public CDialog
{
	DECLARE_DYNAMIC(CRegionDlg)

public:
	CRegionDlg(CWnd* pParent = NULL);   // standard constructor
	virtual ~CRegionDlg();

// Dialog Data
	enum { IDD = IDD_REGION };

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

	DECLARE_MESSAGE_MAP()

public:
    virtual BOOL OnInitDialog();
    afx_msg void OnBnClickedSelect();
    afx_msg void OnBnClickedCopyClipboard();
    afx_msg void OnBnClickedExtract();
    afx_msg void OnCbnSelchangeComboScenario();

    void DoCapture(LONG hWnd, const CRect& rcCapture);
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
    LONG m_nX;
    LONG m_nY;
    LONG m_nWidth;
    LONG m_nHeight;
    CComboBox m_cboScenario;
    E_SCENARIO m_enScenario;
    CString m_strDuration;
    BOOL m_bUseFormatting;
    CFont   *m_pFontResult;
};
