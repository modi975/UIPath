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
	ON_CBN_SELCHANGE(IDC_COMBO_ENGINE, EngineChanged)
	ON_BN_CLICKED(IDOK, ScrapeUiNode)
	ON_BN_CLICKED(IDC_SELECT_UIOBJECT, SelectUIObject)
	ON_BN_CLICKED(IDC_SELECT_REGION, SelectRegion)
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
	m_enScrapingMethod = UI_NATIVE;
    ShowNativeOptions(SW_SHOW);
    ShowFullTextOptions(SW_HIDE);
    ShowOCROptions(SW_HIDE);

    CComboBox* OCREngineCombo = (CComboBox*)GetDlgItem(IDC_COMBO_ENGINE);
    OCREngineCombo->InsertString(0, L"TESSERACT");
    OCREngineCombo->InsertString(1, L"MODI");
    OCREngineCombo->SetCurSel(0);

	//Instantiate UiNode object
	spNode.CoCreateInstance(CLSID_UiNode);
	if(m_enScenario == ACTIVE_WINDOW)
	{
		CComPtr<IUiWindow> spWindow;
		try
		{
			spWindow.CoCreateInstance(CLSID_UiWindow);
			//Create UiNode from Active window
			spNode->FromWindow(spWindow->FromActiveWindow());
		}
		catch(_com_error e)
		{
			AfxMessageBox(L"An error appeared while trying to create UiNode from Active window");
		}
	}
	else
	{
		//Create UiNode from Selection
		if(m_enScenario == UIOBJECT)
		{
			SelectUIObject();
		}
		else
		{
			SelectRegion();
		}
	}
    return TRUE;
}

void CScrapeDlg::SelectUIObject()
{
	this->ShowWindow(SW_MINIMIZE);
	UiSelectionType selectionType = UI_SELECT_NODE;
	try
	{
		if(spNode != nullptr)
		{
			spNode.Release();
			spNode.CoCreateInstance(CLSID_UiNode);
		}
		spNode->SelectInteractive(selectionType);
		this->ShowWindow(SW_NORMAL);
	}
	catch(_com_error e)
	{
		this->ShowWindow(SW_NORMAL);
		AfxMessageBox(L"An error appeared while trying to select a UI Object");
		
	}

}

void CScrapeDlg::SelectRegion()
{
	UiSelectionType selectionType = UI_SELECT_REGION;
	this->ShowWindow(SW_MINIMIZE);
	try
	{
		if(spNode != nullptr)
		{
			spNode.Release();
			spNode.CoCreateInstance(CLSID_UiNode);
		}
		spNode->SelectInteractive(selectionType);
		this->ShowWindow(SW_NORMAL);
	}
	catch(_com_error e)
	{
		this->ShowWindow(SW_NORMAL);
		AfxMessageBox(L"An error appeared while trying to select a region");
	}
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
	m_enScrapingMethod = (UiScrapingMethod)(method + 1);
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
	CWnd* OCRCorrection = GetDlgItem(IDC_OCRCORRECTION);
	CWnd* OCRInvert = GetDlgItem(IDC_INVERT);
	CWnd* staticAllowed = GetDlgItem(IDC_ALLOWED);
	CWnd* staticDenied = GetDlgItem(IDC_DENIED);
	CWnd* allowedEdit = GetDlgItem(IDC_EDIT_ALLOWED);
	CWnd* deniedEdit = GetDlgItem(IDC_EDIT_DENIED);

	OCRCorrection->ShowWindow(nShow);
	OCRInvert->ShowWindow(nShow);
	staticAllowed->ShowWindow(nShow);
	staticDenied->ShowWindow(nShow);
	allowedEdit->ShowWindow(nShow);
	deniedEdit->ShowWindow(nShow);
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

    CComSafeArray<BSTR> Languages = spSystem->GetOCRLanguages(enOCREngine);
    
	LONG count;
	SafeArrayGetUBound(Languages, 1, &count);
    for(LONG i = 0; i <= count; i++)
    {
		CString strLang = Languages.GetAt(i);
		OCRLanguageCombo->InsertString((int)i, strLang);
    }
	if(enOCREngine == UI_OCR_TESSERACT)
	{
		OCRLanguageCombo->SetCurSel(OCRLanguageCombo->FindString(0, L"eng"));
	}
	else
	{
		OCRLanguageCombo->SetCurSel(OCRLanguageCombo->FindString(0, L"English"));
	}

}

void CScrapeDlg::EngineChanged()
{
	CComboBox* OCREngineCombo = (CComboBox*)GetDlgItem(IDC_COMBO_ENGINE);
	int selectedEngine = OCREngineCombo->GetCurSel();
	if(selectedEngine == 0)
	{
		GetLanguages(UI_OCR_TESSERACT);
	}
	else
	{
		GetLanguages(UI_OCR_MODI);
	}
}

void CScrapeDlg::ScrapeUiNode()
{

	BOOL bExtractInfo;
	//create scrape options object
	CComPtr<IUiScrapeOptions> spScrapeOptions;
	try
	{
		spScrapeOptions.CoCreateInstance(CLSID_UiScrapeOptions);
		//set scraping method
		spScrapeOptions->Set(L"scrapingmethod", m_enScrapingMethod);
		//set extract info option
		bExtractInfo = ((CButton*)GetDlgItem(IDC_EXTRACT_INFO))->GetCheck();
		spScrapeOptions->Set(L"extractinfo", bExtractInfo);
		switch(m_enScrapingMethod)
		{
		case UI_NATIVE:
			{
				spScrapeOptions->Set(L"formattedtext", ((CButton*)GetDlgItem(IDC_FORMATTED))->GetCheck());
				spScrapeOptions->Set(L"getfont", ((CButton*)GetDlgItem(IDC_GET_FONT))->GetCheck());
			}
			break;
		case UI_FULLTEXT:
			{
				spScrapeOptions->Set(L"ignorehidden", ((CButton*)GetDlgItem(IDC_IGNORE_HIDDEN))->GetCheck());
			}
			break;
		case UI_OCR:
			{
				spScrapeOptions->Set(L"ocrcorrection", ((CButton*)GetDlgItem(IDC_OCRCORRECTION))->GetCheck());
				spScrapeOptions->Set(L"invert", ((CButton*)GetDlgItem(IDC_INVERT))->GetCheck());
				spScrapeOptions->Set(L"ocrengine", (UiOCREngine)((CComboBox*)GetDlgItem(IDC_COMBO_ENGINE))->GetCurSel());
				CComboBox* LanguageCombo = (CComboBox*)GetDlgItem(IDC_COMBO_LANGUAGE);
				CString strLanguage;
				LanguageCombo->GetLBText(LanguageCombo->GetCurSel(), strLanguage);
				spScrapeOptions->Set(L"ocrlanguage", CComVariant(strLanguage));
				CString strAllowedChars;
				CString strDeniedChars;
				GetDlgItemText(IDC_EDIT_ALLOWED, strAllowedChars);
				GetDlgItemText(IDC_EDIT_DENIED, strDeniedChars);
				spScrapeOptions->Set(L"allowedcharacters", CComVariant(strAllowedChars));
				spScrapeOptions->Set(L"deniedcharacters", CComVariant(strDeniedChars));
			}
			break;
		default:
			break;
		}
	}
	catch(_com_error e)
	{
		AfxMessageBox(L"An error appeared while trying to set scraping options");
		return;
	}

	//get scrape result
	try
	{
		CComPtr<IUiScrapeResult> spScrapeResult;
		spScrapeResult = spNode->Scrape(spScrapeOptions);
		CEdit* editResult = (CEdit*) GetDlgItem(IDC_EDIT_RESULT);
		if(bExtractInfo && spScrapeResult->textInfo != nullptr)
		{
			CComSafeArray<VARIANT> saTextInfo;
			saTextInfo.CopyFrom(spScrapeResult->textInfo);
			LONG count;
			SafeArrayGetUBound(saTextInfo, 1, &count);
			
			CString strResult;
			//get each word's rectangle
			for(int i = 0; i <= count; i++)
			{
				CComQIPtr<IUiTextInfo> spTextInfo;
				spTextInfo.CoCreateInstance(CLSID_UiTextInfo);
				spTextInfo = saTextInfo.GetAt(i).pdispVal;
				CString strLeft;
				CString strRight;
				CString strTop;
				CString strBottom;
				strLeft.Format(_T("%d"), spTextInfo->rectangle->left);
				strRight.Format(_T("%d"), spTextInfo->rectangle->right);
				strTop.Format(_T("%d"), spTextInfo->rectangle->top);
				strBottom.Format(_T("%d"), spTextInfo->rectangle->bottom);
				CString strText = spTextInfo->text;
				strResult = strResult + _T("(") + strLeft + _T(", ") + strRight + _T(", ") + strTop + _T(", ") + strBottom + _T(") ") + strText + _T("\r\n");
				
			}
			editResult->SetWindowTextW(strResult);
		}
		else
		{
			editResult->SetWindowText(spScrapeResult->text);
		}
	}
	catch(_com_error e)
	{
		AfxMessageBox(L"An error appeared while trying to scrape a UiNode");
	}
}