using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ScreenScraper;

namespace FindTextProject
{
    public partial class Form1 : Form
    {
        TextCaptureX m_tCapture;
        TSelection m_tSelection;
        GetOCRText m_tOCRCapture;
        
        public Form1()
        {
            InitializeComponent();

            try
            {
                m_tCapture = ComFactory.Instance.NewTextCaptureX();
                m_tSelection = ComFactory.Instance.NewTSelection();
                m_tOCRCapture = ComFactory.Instance.NewGetOCRText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // add mouse buttons
            comboMouseBtn.Items.Add("Left");
            comboMouseBtn.Items.Add("Middle");
            comboMouseBtn.Items.Add("Right");
            comboMouseBtn.SelectedIndex = 0;

            // add click types
            comboClick.Items.Add("Single Click");
            comboClick.Items.Add("Double Click");
            comboClick.SelectedIndex = 0;

            //init OCR combos
            comboEngine.Items.Add("Tesseract");
            comboEngine.SelectedIndex = 0;

            comboLang.Items.Add("eng");
            comboLang.Items.Add("deu");
            comboLang.Items.Add("ita");
            comboLang.Items.Add("fra");
            comboLang.Items.Add("nld");
            comboLang.Items.Add("spa");
            comboLang.SelectedIndex = 0;

            //select native capture
            radioNative.Checked = true;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            TSelectionInfo tSelInfo = null;
            this.WindowState = FormWindowState.Minimized;
            try
            {
                tSelInfo = (TSelectionInfo)m_tSelection.Start((int)TS_SELECTION.tsSelectionRectangle, (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            tSelInfo.GetClientCoordinates();

            int hwnd = tSelInfo.WindowHandle;
            string strID = null;
            UIElem uiElem = null;           

            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
                uiElem.hwnd = hwnd;
                strID = uiElem.GetID(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            txtHandle.Text = hwnd.ToString("X");
            txtX.Text = tSelInfo.RCLeft.ToString();
            txtY.Text = tSelInfo.RCTop.ToString();
            txtWidth.Text = tSelInfo.RCWidth.ToString();
            txtHeight.Text = tSelInfo.RCHeight.ToString();
            txtID.Text = strID;
            this.WindowState = FormWindowState.Normal;
        }

        private void SearchText(bool bClickText)
        {
            // get the hwnd
            int hwnd;
            hwnd = int.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber);

            // get the rectangle
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int w = int.Parse(txtWidth.Text);
            int h = int.Parse(txtHeight.Text);

            int occurence = int.Parse(txtOccurence.Text);
            try
            {
                // create the rectangle of the of the
                // clicked region
                rect rectangle = ComFactory.Instance.NewRect();
                rectangle.RLeft = x;
                rectangle.RRight = x + w;
                rectangle.RTop = y;
                rectangle.RBottom = y + h;

                m_tCapture.UseClientCoordinates = true;

                // get the rectangle of the searched text
                rect foundRect = null;
                if (radioNative.Checked == true)
                {
                    foundRect = m_tCapture.GetRectFromText(hwnd, txtSearch.Text, rectangle, occurence);
                }
                else if (radioOCR.Checked == true)
                {
                    string strLang = (string)comboLang.Items[comboLang.SelectedIndex];
                    foundRect = m_tOCRCapture.GetRectFromText(hwnd, txtSearch.Text, rectangle, strLang, false, occurence);
                }

                // show the coordinates
                txtFoundX.Text = foundRect.RLeft.ToString();
                txtFoundY.Text = foundRect.RTop.ToString();
                txtFoundW.Text = foundRect.width().ToString();
                txtFoundH.Text = foundRect.height().ToString();

                if (bClickText)
                {
                    UIElem uiElem = ComFactory.Instance.NewUIElem();
                    uiElem.InitializeFromID(txtID.Text, false);
                    
                    uiElem.Click(foundRect.RLeft+2, foundRect.RTop+2, GetClickFlags());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchText(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchText(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSelectionInfo tSelInfo = null;
            this.WindowState = FormWindowState.Minimized;
            try
            {
                tSelInfo = (TSelectionInfo)m_tSelection.Start((int)TS_SELECTION.tsSelectionWindow, (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

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
            
            // get the hwnd
            uiElem.hwnd = tSelInfo.WindowHandle;
            string strID = uiElem.GetID(false);

            txtID.Text = strID;
            txtHandle.Text = uiElem.hwnd.ToString("X");

            int x1, y1, x2, y2;
            try
            {
                // get the rectangle
                uiElem.GetRectangle(out x1, out y1, out x2, out y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            // show the points
            txtX.Text = "0";
            txtY.Text = "0";
            txtWidth.Text = (x2 - x1).ToString();
            txtHeight.Text = (y2 - y1).ToString();
            this.WindowState = FormWindowState.Normal;
        }

        private void checkLayout_CheckedChanged(object sender, EventArgs e)
        {
            m_tCapture.FormattedText = checkLayout.Checked;
        }

        private int GetClickFlags()
        {
            int nRes = (int)UIE_ClickFlags.UIE_CF_MOVE_CURSOR;
            
            // get mouse button
            if (comboMouseBtn.SelectedIndex == 0)
            {
                nRes |= (int)UIE_ClickFlags.UIE_CF_LEFT;
            }
            else if (comboMouseBtn.SelectedIndex == 1)
            {
                nRes |= (int)UIE_ClickFlags.UIE_CF_MIDDLE;
            }
            else if (comboMouseBtn.SelectedIndex == 2)
            {
                nRes |= (int)UIE_ClickFlags.UIE_CF_RIGHT;
            }

            // get click type
            if (comboClick.SelectedIndex == 0)
            {
                nRes |= (int)UIE_ClickFlags.UIE_CF_SINGLE;
            }
            else if (comboClick.SelectedIndex == 1)
            {
                nRes |= (int)UIE_ClickFlags.UIE_CF_DOUBLE;
            }
            
            return nRes;
        }
    }
}
