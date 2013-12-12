#pragma once

class CScrapeDlg : public CDialogEx
{
// Construction
public:
	CScrapeDlg(Scenario enScenario, CWnd* pParent = NULL);	// standard constructor
    ~CScrapeDlg();

// Dialog Data
	enum { IDD = IDD_SCRAPE_DLG };

    virtual BOOL OnInitDialog();
    void MethodChanged();
	void EngineChanged();
    void ShowNativeOptions(int nShow);
    void ShowFullTextOptions(int nShow);
    void ShowOCROptions(int nShow);
    void GetLanguages(UiOCREngine enOCREngine);
	void ScrapeUiNode();
	void SelectRegion();
	void SelectUIObject();
protected:
    Scenario m_enScenario;
	UiScrapingMethod m_enScrapingMethod;
	CComPtr<IUiNode> spNode;
    DECLARE_MESSAGE_MAP()

};

