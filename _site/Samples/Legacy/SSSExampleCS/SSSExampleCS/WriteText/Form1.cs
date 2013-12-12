using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ScreenScraper;

namespace WriteText
{
    public partial class Form1 : Form
    {
        TextCaptureX m_tCapture;
        TSelection m_tSelection;

        public Form1()
        {
            InitializeComponent();

            radioAPI.Checked = true;

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
            UIElem uiElem = null;
            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
                uiElem.InitializeFromID(tSelInfo.UIElementID, false);
                strID = tSelInfo.UIElementID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            txtHandle.Text = uiElem.hwnd.ToString("X");
            txtID.Text = strID;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            UIElem uiElem = null;
            try
            {
                uiElem = ComFactory.Instance.NewUIElem();
                uiElem.UseClientCoordinates = false;
                uiElem.InitializeFromID(txtID.Text, false);

                // click on the element
                int flags = (int)UIE_ClickFlags.UIE_CF_MOVE_CURSOR | (int)UIE_ClickFlags.UIE_CF_SINGLE | (int)UIE_ClickFlags.UIE_CF_LEFT;
                uiElem.Activate();
                uiElem.Click(2, 2, flags);

                // write text
                int method = 0;
                if (radioAPI.Checked == true)
                {
                    method = (int)UIE_WriteTextMethod.UIE_WTM_NATIVE;
                }
                else if (radioSendKeys.Checked == true)
                {
                    method = (int)UIE_WriteTextMethod.UIE_WTM_SENDKEYS;
                }
                string strErase = "[k(end)d(shift)k(home)u(shift)k(del)]";
                uiElem.WriteText(method, strErase + txtWriteText.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
