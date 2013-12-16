// ScreenScrapDemo.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols


// CScreenScrapDemoApp:
// See ScreenScrapDemo.cpp for the implementation of this class
//

enum E_SCENARIO
{
    E_REGION = 0x00,
    E_WINDOW = 0x01,
    E_ACTIVE = 0x02,
};

const TCHAR C_FIXED_FONT_NAME[] = _T("Courier");
const TCHAR C_SAMPLES_FOLDER[] = _T("Samples");
const TCHAR C_LICENSE[] = _T("ScreenScrapeLicense.rtf");
const TCHAR C_HOME[] = _T("http://www.deskperience.com/textcapture");

class CScreenScrapDemoApp : public CWinApp
{
public:
	CScreenScrapDemoApp();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation
    BOOL CopyTextToClipboard(const CString &strText);
    CString GetWindowText(HWND hWnd);
    BOOL Select(TS_SELECTION selType, CComPtr<ITSelectionInfo> &pSelInfo);
    void DecodeFont(CComPtr<IFontDisp>& pFontDisp, CString &strFont, LONG &nSize, LOGFONT &lf);
    void RestoreWindow(CWnd *pWnd, int nNewHeight);
    void InitComboScenario(CComboBox& cbo, E_SCENARIO enSkip);

	DECLARE_MESSAGE_MAP()
    virtual int ExitInstance();

public:
    int m_nLogPixelsY;
};

extern CScreenScrapDemoApp theApp;