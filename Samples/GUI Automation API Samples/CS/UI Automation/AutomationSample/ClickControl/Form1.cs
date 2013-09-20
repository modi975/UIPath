using System;
using System.Windows.Forms;
using UiPath;

namespace AutomationSample
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
            if(NoneBtn.Checked)
            {
                wfrLevel = UiWaitForReadyLevels.UI_WFR_NONE;
            }
            if(CompleteBtn.Checked)
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

                //get control position
                UiRegion position = (UiRegion)uiNode.Get("position");

                //set offsets to the center of the control
                int offsetX = position.width / 2;
                int offsetY = position.height / 2;

                //set wait for ready level
                uiNode.waitForReadyLevel = wfrLevel;

                if(HoverOnlyBtn.Checked)
                {
                    //hover control
                    uiNode.Hover(offsetX, offsetY, inputMethod, 500);
                }
                else
                {
                    //click control
                    //get mouse button
                    UiMouseButton mouseBtn = UiMouseButton.UI_BTN_LEFT;
                    if(RightMouseBtn.Checked)
                    {
                        mouseBtn = UiMouseButton.UI_BTN_RIGHT;
                    }
                    if(MiddleMouseBtn.Checked)
                    {
                        mouseBtn = UiMouseButton.UI_BTN_MIDDLE;
                    }

                    //get click type
                    UiClickType clickType = UiClickType.UI_CLICK_SINGLE;
                    if(DoubleButton.Checked)
                    {
                        clickType = UiClickType.UI_CLICK_DOUBLE;    
                    }

                    uiNode.Click(offsetX, offsetY, clickType, mouseBtn, inputMethod);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
