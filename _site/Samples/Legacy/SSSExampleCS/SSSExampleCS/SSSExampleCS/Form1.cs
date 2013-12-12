using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenScraper;

namespace SSSExampleCS
{
    enum CaptureMethod
    {
        NATIVE,
        FULL_TEXT,
        OCR
    };

    public partial class Form1 : Form
    {
        TextCaptureX m_tCapture;
        GetAAText m_tFullTextCapt;
        TSelection m_tSelection;
        GetOCRText m_tOCRCapture;
        bool m_bRegOrWnd;
        bool m_bCanTryAgain;

        public Form1()
        {
            InitializeComponent();

            try
            {
                m_tCapture = ComFactory.Instance.NewTextCaptureX();
                m_tSelection = ComFactory.Instance.NewTSelection();
                m_tFullTextCapt = ComFactory.Instance.NewGetAAText();
                m_tOCRCapture = ComFactory.Instance.NewGetOCRText();

                m_tCapture.UseClientCoordinates = true;
                m_tFullTextCapt.UseClientCoordinates = true;
                m_tOCRCapture.UseClientCoordinates = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // init radios
            radioNative.Checked = true;       
 
            // init checkbox
            checkIDorHWND.Checked = true;

            // init OCR
            comboEngine.Items.Add("Tesseract");
            comboEngine.SelectedIndex = 0;

            comboLang.Items.Add("eng");
            comboLang.Items.Add("deu");
            comboLang.Items.Add("ita");
            comboLang.Items.Add("fra");
            comboLang.Items.Add("nld");
            comboLang.Items.Add("spa");
            comboLang.SelectedIndex = 0;
        }

        private CaptureMethod GetCaptureMethod()
        {
            if (radioNative.Checked)
            {
                return CaptureMethod.NATIVE;
            }
            else if (radioFullText.Checked)
            {
                return CaptureMethod.FULL_TEXT;
            }
            return CaptureMethod.OCR;
        }

        private void PerformRegionCapture(int hwnd, int x, int y, int width, int height)
        {
            if (m_bRegOrWnd == false)
            {
                // if a window was selected
                MessageBox.Show("You selected a window!");
                return;
            }

            CaptureMethod currentMethod = GetCaptureMethod();
            string strText = "";
            if (currentMethod == CaptureMethod.NATIVE)
            {
                //stdole.IFontDisp font;
                try
                {
                    // preserve layout checkbox
                    if (checkLayout.Checked == true)
                    {
                        m_tCapture.FormattedText = true;
                    }
                    strText = m_tCapture.GetTextFromRect(hwnd, x, y, width, height);
                    //txtFont.Text = font.Name;
                    //txtFontSize.Text = font.Size.ToString();
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(4000); // sleep for 4 seconds
                        PerformRegionCapture(hwnd, x, y, width, height); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (currentMethod == CaptureMethod.FULL_TEXT)
            {
                try
                {
                    strText = m_tFullTextCapt.GetFullTextFromRectangle(hwnd, x, y, width, height);
                    txtFont.Text = "";
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(5000); // sleep for 4 seconds
                        PerformRegionCapture(hwnd, x, y, width, height); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (currentMethod == CaptureMethod.OCR)
            {
                try
                {                 
                    string strLang = (string)comboLang.Items[comboLang.SelectedIndex];
                    strText = m_tOCRCapture.GetTextFromRect(hwnd, x, y, width, height, strLang, false);
                    txtFont.Text = "";
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(5000); // sleep for 4 seconds
                        PerformRegionCapture(hwnd, x, y, width, height); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            txtResult.Text = strText;
        }

        private void PerformWndCapture(UIElem uiElem)
        {
            if (m_bRegOrWnd == true)
            {
                // if a region was selected
                MessageBox.Show("You selected a region!");
                return;
            }

            if (uiElem == null)
            {
                return;
            }

            // get the text and font
            //stdole.IFontDisp font;
            string strText = "";
            CaptureMethod captMethod = GetCaptureMethod();
            if (captMethod == CaptureMethod.NATIVE)
            {
                try
                {
                    // preserve layout checkbox
                    if (checkLayout.Checked == true)
                    {
                        m_tCapture.FormattedText = true;
                    }
                    strText = m_tCapture.GetTextFromUIElem(uiElem);
                    //txtFont.Text = font.Name;
                    //txtFontSize.Text = font.Size.ToString();
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(5000); // sleep for 4 seconds
                        PerformWndCapture(uiElem); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (captMethod == CaptureMethod.FULL_TEXT)
            {
                try
                {
                    strText = m_tFullTextCapt.GetFullTextFromUIElem(uiElem);
                    txtFont.Text = "";
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(5000); // sleep for 4 seconds
                        PerformWndCapture(uiElem); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (captMethod == CaptureMethod.OCR)
            {
                try
                {
                    string strLang = (string)comboLang.Items[comboLang.SelectedIndex];
                    
                    strText = m_tOCRCapture.GetTextFromUIElem(uiElem, strLang, false);
                    txtFont.Text = "";
                }
                catch (Exception ex)
                {
                    System.Runtime.InteropServices.COMException COMEx = (System.Runtime.InteropServices.COMException)ex;
                    if (COMEx.ErrorCode == -2147220989 && m_bCanTryAgain)
                    {
                        // this is the timeout exception

                        m_bCanTryAgain = false;
                        MessageBox.Show("Trying again!");
                        System.Threading.Thread.Sleep(5000); // sleep for 4 seconds
                        PerformWndCapture(uiElem); // and try again

                        return;
                    }
                    else
                    {
                        strText = "Capture Error!";
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            txtResult.Text = strText;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            m_bRegOrWnd = true;
            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(100);

            TSelectionInfo tSelInfo = null;

            try
            {
                tSelInfo = (TSelectionInfo)m_tSelection.Start(
                            (int)TS_SELECTION.tsSelectionRectangle,
                            (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // get the hwnd
            int hwnd = tSelInfo.WindowHandle;
            txtHandle.Text = hwnd.ToString("X");

            UIElem uiElem = ComFactory.Instance.NewUIElem();
            uiElem.hwnd = hwnd;

            // set the UI element ID
            textBox1.Text = uiElem.GetID(true);

            // get the selection points
            tSelInfo.GetClientCoordinates();


            // set the points
            txtX.Text = tSelInfo.RCLeft.ToString();
            txtY.Text = tSelInfo.RCTop.ToString();
            txtWidth.Text = tSelInfo.RCWidth.ToString();
            txtHeight.Text = tSelInfo.RCHeight.ToString();

            //PerformRegionCapture(hwnd, x1, y1, width, height);
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_bRegOrWnd = false;
            
            TSelectionInfo tSelInfo = null;

            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(100);

            try
            {              
                tSelInfo = (TSelectionInfo)m_tSelection.Start(
                            (int)TS_SELECTION.tsSelectionUIElement,
                            (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText
                        );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // get the hwnd
            int hwnd = tSelInfo.WindowHandle;
            txtHandle.Text = hwnd.ToString("X");

            // set the UI element ID
            UIElem uiElem = ComFactory.Instance.NewUIElem();

            if (tSelInfo.UIElementID == "")
            {
                textBox1.Text = "A valid ID could not be generated!";
                this.WindowState = FormWindowState.Normal;

                return;
            }
            try
            {
                uiElem.InitializeFromID(tSelInfo.UIElementID, true);
                string uiElemID = uiElem.GetID(false);
                textBox1.Text = uiElemID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.WindowState = FormWindowState.Normal;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int width = int.Parse(txtWidth.Text);
            int height = int.Parse(txtHeight.Text);

            UIElem uiElem = null;
            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (checkIDorHWND.Checked == true)
            {
                // get id
                string strID = textBox1.Text;
                try
                {
                    uiElem.InitializeFromID(strID, true);
                    m_bCanTryAgain = true;
                    PerformRegionCapture(uiElem.hwnd, x, y, width, height);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                // get the hwnd
                int hwnd = int.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber);
                m_bCanTryAgain = true;
                PerformRegionCapture(hwnd, x, y, width, height);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIElem uiElem = null;
            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (checkIDorHWND.Checked == true)
            {
                // get id
                string strID = textBox1.Text;
                try
                {
                    uiElem.InitializeFromID(strID, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                // get the hwnd
                int hwnd = int.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber);
                uiElem.hwnd = hwnd;
            }

            m_bCanTryAgain = true;
            PerformWndCapture(uiElem);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            int activeHwnd;

            this.WindowState = FormWindowState.Minimized;
            try
            {
                activeHwnd = m_tCapture.GetActiveWindowHwnd();
                string strResult = m_tCapture.CaptureWindow(activeHwnd);
                txtResult.Text = strResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtResult.Text = "Capture Error!";
            }
            this.WindowState = FormWindowState.Normal;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int hwnd = int.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber);

            try
            {
                string strResult = m_tCapture.GetTextFromPoint(hwnd, x, y);
                txtResult.Text = strResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
