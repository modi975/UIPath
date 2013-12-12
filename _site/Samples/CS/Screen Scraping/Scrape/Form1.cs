using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UiPath;

namespace Scrape
{
    public partial class Form1 : Form
    {
        private UiScrapingMethod ScrapeMethod;
        private UiOCREngine OCREngine;

        private UiNode uiNode;

        public Form1()
        {
            InitializeComponent();
            //set default options
            ScrapeMethod = UiScrapingMethod.UI_AUTOMATIC;
            ScrapeMethod_Combo.SelectedIndex = 0;

            OCREngine = UiOCREngine.UI_OCR_TESSERACT;
            OCREngine_combo.SelectedIndex = 0;

            //create uiNode
            uiNode = UiFactory.Instance.NewUiNode();
        }

        private void NativeScrapeOptions(bool Visibile)
        {
            GetFont_Checkbox.Visible = Visibile;
            FormattedText_Checkbox.Visible = Visibile;
        }

        private void FullTextScrapeOptions(bool Visibile)
        {
            IgnoreHidden_Checkbox.Visible = Visibile;
        }

        private void OCRScrapeOptions(bool Visibile)
        {
            AllowedChars_label.Visible = Visibile;
            textBoxAllowedChars.Visible = Visibile;
            DeniedChars_label.Visible = Visibile;
            textBoxDeniedChars.Visible = Visibile;
            Correction_checkbox.Visible = Visibile;
            Invert_checkbox.Visible = Visibile;
            OCREngine_label.Visible = Visibile;
            OCREngine_combo.Visible = Visibile;
            OCRLanguage_label.Visible = Visibile;
            OCRLanguage_Combo.Visible = Visibile;
            OCREngine_combo.SelectedIndex = 0;
        }

        private void SetSelector()
        {
            try
            {
                textSelector.Text = uiNode.GetSelector(true);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to get the selector of a UiNode. Please make sure the UI object refered by the UiNode is still available on screen.");
            }

        }

        private void Select_UIObject_Click(object sender, EventArgs e)
        {
            //minimize application
            WindowState = FormWindowState.Minimized;

            //select a UI object
            UiSelectionType selType = UiSelectionType.UI_SELECT_NODE;
            try
            {
                uiNode.SelectInteractive(selType);
                SetSelector();
            }
            catch(Exception ex)
            {
                //restore application
                WindowState = FormWindowState.Normal;
                System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to select a UI object. Please try again or contact us at  support@deskover.com");
            }

            //restore application
            WindowState = FormWindowState.Normal;
        }

        private void Select_Region_Click(object sender, EventArgs e)
        {
            //minimize application
            WindowState = FormWindowState.Minimized;

            //select a region
            UiSelectionType selType = UiSelectionType.UI_SELECT_REGION;
            try
            {
                uiNode.SelectInteractive(selType);
                SetSelector();
            }
            catch (Exception ex)
            {
                //restore application
                WindowState = FormWindowState.Normal;

                System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to a region. Please try again or contact us at  support@deskover.com");
            }

            //restore application
            WindowState = FormWindowState.Normal;

        }

        private void btnActiveWindow_Click(object sender, EventArgs e)
        {
            //Minimize application
            WindowState = FormWindowState.Minimized;

           
            try
            {
                //get active window
                UiWindow uiWindow = UiFactory.Instance.NewUiWindow();
                uiWindow.FromActiveWindow();
           
                //initialize uiNode from active window
                uiNode.FromWindow(uiWindow);
                SetSelector();
            }
            catch(Exception ex)
            {
                //restore application
                WindowState = FormWindowState.Normal;
                System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to initialize an UiNode from an UiWindow");
            }

            //restore application
            WindowState = FormWindowState.Normal;
        }

        private void Scrape_Click(object sender, EventArgs e)
        {
            //Create UiScrapeOptions object
            UiScrapeOptions uiScrapeOptions = UiFactory.Instance.NewUiScrapeOptions();

            //Set scraping options
            uiScrapeOptions.Set("scrapingmethod", ScrapeMethod);
            uiScrapeOptions.Set("extractinfo", ExtractInfo_Checkbox.Checked);
            uiScrapeOptions.Set("getfont", GetFont_Checkbox.Checked);
            uiScrapeOptions.Set("formattedtext", FormattedText_Checkbox.Checked);
            uiScrapeOptions.Set("ignorehidden", IgnoreHidden_Checkbox.Checked);
            uiScrapeOptions.Set("allowedcharacters", textBoxAllowedChars.Text);
            uiScrapeOptions.Set("deniedcharacters", textBoxDeniedChars.Text);
            uiScrapeOptions.Set("ocrcorrection", Correction_checkbox.Checked);
            uiScrapeOptions.Set("ocrengine", OCREngine);
            uiScrapeOptions.Set("ocrlanguage", OCRLanguage_Combo.SelectedText);
            uiScrapeOptions.Set("invert", Invert_checkbox.Checked);

            UiScrapeResult uiScrapeResult = uiNode.Scrape(uiScrapeOptions);

            //set output
            SetResult(uiScrapeResult);

            WindowState = FormWindowState.Normal;
                
        }

        private void ScrapeMethod_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the selected scraping method
            ScrapeMethod = (UiScrapingMethod)ScrapeMethod_Combo.SelectedIndex;

            //Update ui
            switch (ScrapeMethod)
            {
                case UiScrapingMethod.UI_AUTOMATIC:
                    {
                        NativeScrapeOptions(false);
                        FullTextScrapeOptions(false);
                        OCRScrapeOptions(false);
                    }
                    break;
                case UiScrapingMethod.UI_NATIVE:
                    {
                        NativeScrapeOptions(true);
                        FullTextScrapeOptions(false);
                        OCRScrapeOptions(false);
                    }
                    break;
                case UiScrapingMethod.UI_FULLTEXT:
                    {
                        NativeScrapeOptions(false);
                        FullTextScrapeOptions(true);
                        OCRScrapeOptions(false);
                    }
                    break;
                case UiScrapingMethod.UI_OCR:
                    {
                        NativeScrapeOptions(false);
                        FullTextScrapeOptions(false);
                        OCRScrapeOptions(true);
                    }
                    break;
            }
        }

        private void OCREngine_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get OCR engine selected
            OCREngine = (UiOCREngine)OCREngine_combo.SelectedIndex;
            
            //get OCR specific languages
            UiSystem uiSystem = UiFactory.Instance.NewUiSystem();
            try
            {
                string[] languages = uiSystem.GetOCRLanguages(OCREngine);
                //Set languages as items source for OCRLanguage combo
                SetOCRLanguages(languages);
            }
            catch (Exception)
            {
                 System.Windows.Forms.MessageBox.Show("An error appeared while trying to retrive the languages for " + OCREngine.ToString());
                 return;
            }

            

            //Set english as default language
            if (OCREngine == UiOCREngine.UI_OCR_TESSERACT)
            {
                OCRLanguage_Combo.SelectedItem = "eng";
                int index = OCRLanguage_Combo.SelectedIndex;
            }
            else
            {
                OCRLanguage_Combo.SelectedItem = "English";
            }
        }

        private void SetOCRLanguages(string[] languages)
        {
            OCRLanguage_Combo.Items.Clear();
            foreach (string lang in languages)
            {
                OCRLanguage_Combo.Items.Add(lang);
            }
        }

        private void SetResult(UiScrapeResult uiScrapeResult)
        {
            textBoxOutput.ResetText();

            if (GetFont_Checkbox.Checked)
            {
                //set font info
                textBoxOutput.AppendText("Font Name: " + uiScrapeResult.font.Name + " Font Size:" + uiScrapeResult.font.Size + "\r\n\r\n");
            }

            if (ExtractInfo_Checkbox.Checked)
            {
                //get information about each word
                foreach (UiTextInfo word in uiScrapeResult.textInfo)
                {
                    //append info about word in output
                    textBoxOutput.AppendText("left: " + word.rectangle.left + " top: " + word.rectangle.top + " right: " + word.rectangle.right + " bottom: " + word.rectangle.bottom + " text = " + word.text + "\r\n");
                }
            }
            else
            {
                //add entire scrape result
                textBoxOutput.AppendText(uiScrapeResult.text);
            }
        }

    }
}
