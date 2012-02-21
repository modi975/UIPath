#include "stdafx.h"
#include "resource.h"
#include "MiniStudioDlg.h"
#include "Scrape.h"

CScrapeDlg::CScrapeDlg(Scenario enScenario, CWnd* pParent):CDialogEx(CScrapeDlg::IDD, pParent)
{
    m_enScenario = enScenario;
}

BEGIN_MESSAGE_MAP(CScrapeDlg, CDialogEx)
    ON_CBN_SELCHANGE(IDC_SCRAPE_METHOD, MethodChanged)
END_MESSAGE_MAP()

CScrapeDlg::~CScrapeDlg()
{
}

BOOL CScrapeDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();
    CComboBox* methodCombo = (CComboBox*)GetDlgItem(IDC_SCRAPE_METHOD);
    methodCombo->InsertString(0, L"Native");
    methodCombo->InsertString(1, L"FullText");
    methodCombo->InsertString(2, L"OCR");
    methodCombo->SetCurSel(0);  
    ShowNativeOptions(SW_SHOW);
    ShowFullTextOptions(SW_HIDE);
    ShowOCROptions(SW_HIDE);

    CComboBox* OCREngineCombo = (CComboBox*)GetDlgItem(IDC_COMBO_ENGINE);
    OCREngineCombo->InsertString(0, L"TESSERACT");
    OCREngineCombo->InsertString(1, L"MODI");
    OCREngineCombo->SetCurSel(0);
    return TRUE;
}

void CScrapeDlg::MethodChanged()
{
    CComboBox* methodCombo = (CComboBox*)GetDlgItem(IDC_SCRAPE_METHOD);
    int method = methodCombo->GetCurSel();
    if(method == 0)
    {
        ShowNativeOptions(SW_SHOW);
        ShowFullTextOptions(SW_HIDE);
        ShowOCROptions(SW_HIDE);
    }
    else if (method == 1)
    {
        ShowNativeOptions(SW_HIDE);
        ShowFullTextOptions(SW_SHOW);
        ShowOCROptions(SW_HIDE);
    }
    else
    {
        ShowNativeOptions(SW_HIDE);
        ShowFullTextOptions(SW_HIDE);
        ShowOCROptions(SW_SHOW);
    }
}

void CScrapeDlg::ShowNativeOptions(int nShow)
{
    CWnd* formatting = GetDlgItem(IDC_FORMATTED);
    CWnd* font = GetDlgItem(IDC_GET_FONT);
    formatting->ShowWindow(nShow);
    font->ShowWindow(nShow);
}

void CScrapeDlg::ShowFullTextOptions(int nShow)
{
    CWnd* ignoreHidden = GetDlgItem(IDC_IGNORE_HIDDEN);
    ignoreHidden->ShowWindow(nShow);
}

void CScrapeDlg::ShowOCROptions(int nShow)
{
    CWnd* staticOCREngine = GetDlgItem(IDC_OCRENGINE);
    CWnd* OCREngineCombo = GetDlgItem(IDC_COMBO_ENGINE);
    staticOCREngine->ShowWindow(nShow);
    OCREngineCombo->ShowWindow(nShow);
    CWnd* staticOCRLanguage = GetDlgItem(IDC_OCRLANGUAGE);
    CWnd* OCRLanguageCombo = GetDlgItem(IDC_COMBO_LANGUAGE);
    staticOCRLanguage->ShowWindow(nShow);
    OCRLanguageCombo->ShowWindow(nShow);
    GetLanguages(UI_OCR_TESSERACT);
}

void CScrapeDlg::GetLanguages(UiOCREngine enOCREngine)
{
    CComboBox* OCRLanguageCombo = (CComboBox*)GetDlgItem(IDC_COMBO_LANGUAGE);
    OCRLanguageCombo->ResetContent();
    
    //Get available languages
    CComPtr<IUiSystem> spSystem;
    try
    {
        spSystem.CoCreateInstance(CLSID_UiSystem);
    }
    catch(_com_error e)
    {
        AfxMessageBox(L"An error appeared while trying to instantiate UiSystem");
    }

    SAFEARRAY* Languages = spSystem->GetOCRLanguages(enOCREngine);
    LONG count;
    ::SafeArrayGetUBound(Languages, 1, &count);
    for(int i = 0; i <= count; i++)
    {
        CString strLang;
    }

}