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
                m_tCapture = new TextCaptureXClass();
                m_tSelection = new TSelectionClass();
                m_tOCRCapture = new GetOCRTextClass();
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

        private int GetX(int number)
        {
            return number & 0xffff;
        }

        private int GetY(int number)
        {
            return (number >> 16) & 0xffff;
        }

        private void btnCollect_Click(object sender, EventArgs e)
        {
            TSelectionInfo tSelInfo = null;

            try
            {
                tSelInfo = (TSelectionInfo)m_tSelection.Start((int)TS_SELECTION.tsSelectionRectangle, (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            object[] points;
            points = (object[])tSelInfo.Points;

            // get the points
            int x1, y1, x2, y2, width, height;
            x1 = GetX((int)points[0]);
            y1 = GetY((int)points[0]);
            x2 = GetX((int)points[1]);
            y2 = GetY((int)points[1]);

            int top, bottom, left, right;
            if (x1 < x2)
            {
                left = x1;
                right = x2;
            }
            else
            {
                left = x2;
                right = x1;
            }

            if (y1 < y2)
            {
                top = y1;
                bottom = y2;
            }
            else
            {
                top = y2;
                bottom = y1;
            }

            width = right - left;
            height = bottom - top;

            int hwnd = tSelInfo.WindowHandle;
            string strID = null;
            UIElem uiElem = null;           

            try
            {
                uiElem = new UIElemClass();
                uiElem.hwnd = hwnd;
                strID = uiElem.GetID(true);
                uiElem.GetRectangle(out x1, out y1, out x2, out y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            top = top - y1;
            left = left - x1;

            txtHandle.Text = hwnd.ToString("X");
            txtX.Text = left.ToString();
            txtY.Text = top.ToString();
            txtWidth.Text = width.ToString();
            txtHeight.Text = height.ToString();
            txtID.Text = strID;
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
                rect rectangle = new rectClass();
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
                    UIElem uiElem = new UIElemClass();
                    uiElem.InitializeFromID(txtID.Text, false);
                    
                    uiElem.Click(foundRect.RLeft, foundRect.RTop, GetClickFlags());
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
                uiElem = new UIElemClass();
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
