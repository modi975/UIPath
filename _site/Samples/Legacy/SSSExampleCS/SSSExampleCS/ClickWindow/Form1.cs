using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ScreenScraper;

namespace ClickWindow
{
    public partial class Form1 : Form
    {
        TextCaptureX m_tCapture;
        TSelection m_tSelection;

        public Form1()
        {
            InitializeComponent();

            comboClick.SelectedIndex = 0;
            comboMouseBtn.SelectedIndex = 0;

            try
            {
                m_tCapture = ComFactory.Instance.NewTextCaptureX();
                m_tSelection = ComFactory.Instance.NewTSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSelectionInfo tSelInfo = null;

            this.WindowState = FormWindowState.Minimized;
            try
            {
                tSelInfo = (TSelectionInfo)m_tSelection.Start((int)TS_SELECTION.tsSelectionUIElement, (int)TS_SELECTION_OPTIONS.tsSelFlagDefaultText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.WindowState = FormWindowState.Normal;
            string strID = null;
            strID = tSelInfo.UIElementID;

            txtHandle.Text = tSelInfo.WindowHandle.ToString("X");
            txtID.Text = strID;
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

        private void button2_Click(object sender, EventArgs e)
        {
            UIElem uiElem = null;
            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
                uiElem.UseClientCoordinates = true;
                uiElem.InitializeFromID(txtID.Text, true);

                int left, top, right, bottom;
                uiElem.GetRectangle(out left, out top, out right, out bottom);

                int flags = GetClickFlags();
                uiElem.Click(2, 2, flags);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
