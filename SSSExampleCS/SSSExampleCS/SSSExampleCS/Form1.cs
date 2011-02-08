using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TCaptureXLib;
using TSelectionLib;
using UIElementLib;

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
                m_tCapture = new TextCaptureXClass();
                m_tSelection = new TSelectionClass();
                m_tFullTextCapt = new GetAATextClass();
                m_tOCRCapture = new GetOCRTextClass();

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

        private int GetX(int number)
        {
            return number & 0xffff;
        }

        private int GetY(int number)
        {
            return (number >> 16) & 0xffff;
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

            UIElem uiElem = new UIElemClass();
            uiElem.hwnd = hwnd;

            // set the UI element ID
            textBox1.Text = uiElem.GetID(true);

            // get the selection points
            object[] points;
            points = (object[])tSelInfo.Points;

            // get the points
            int x1, y1, x2, y2, width, height;
            x1 = GetX((int)points[0]);
            y1 = GetY((int)points[0]);
            x2 = GetX((int)points[1]);
            y2 = GetY((int)points[1]);
            width = x2 - x1;
            height = y2 - y1;
            if (width < 0)
            {
                width = -1 * width;
            }
            if (height < 0)
            {
                height = -1 * height;
            }

            //translate to client coordinates
            int left, top, right, bottom;
            uiElem.GetRectangle(out left, out top, out right, out bottom);
            x1 = x1 - left;
            y1 = y1 - top;

            // set the points
            txtX.Text = x1.ToString();
            txtY.Text = y1.ToString();
            txtWidth.Text = width.ToString();
            txtHeight.Text = height.ToString();

            //PerformRegionCapture(hwnd, x1, y1, width, height);
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
            UIElem uiElem = new UIElemClass();

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
                uiElem = new UIElemClass();
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
                uiElem = new UIElemClass();
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
