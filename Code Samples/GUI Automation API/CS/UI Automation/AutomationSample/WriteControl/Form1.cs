using System;
using System.Windows.Forms;
using UiPath;

namespace WriteControl
{
    public partial class Form1 : Form
    {
        private UiNode uiNode;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectCtrlBtn_Click(object sender, EventArgs e)
        {
            uiNode = UiFactory.Instance.NewUiNode();
            try
            {
                WindowState = FormWindowState.Minimized;
                uiNode.SelectInteractive(UiSelectionType.UI_SELECT_NODE);
                SelectorTextBox.Text = uiNode.GetSelector(true);
                WindowState = FormWindowState.Normal;
            }
            catch (Exception ex)
            {
                WindowState = FormWindowState.Normal;
                MessageBox.Show(ex.Message);
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            if (uiNode == null)
            {
                try
                {
                    //first select a control
                    SelectCtrlBtn_Click(null, null);
                    if (!uiNode.IsValid())
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            //get wait for ready level
            UiWaitForReadyLevels wfrLevel = UiWaitForReadyLevels.UI_WFR_INTERACTIVE;
            if (NoneBtn.Checked)
            {
                wfrLevel = UiWaitForReadyLevels.UI_WFR_NONE;
            }
            if (CompleteBtn.Checked)
            {
                wfrLevel = UiWaitForReadyLevels.UI_WFR_COMPLETE;
            }

            //get input method
            UiInputMethod inputMethod = UiInputMethod.UI_HARDWARE_EVENTS;
            if (CtrlAPIBtn.Checked)
            {
                inputMethod = UiInputMethod.UI_CONTROL_API;
            }
            if (Win32Msg.Checked)
            {
                inputMethod = UiInputMethod.UI_WIN32_MSG;
            }

            try
            {
                uiNode.waitForReadyLevel = wfrLevel;
                //write to control
                uiNode.WriteText(InputTextBox.Text, inputMethod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
