using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UiPath;

namespace ImageSample
{
    public partial class Form1 : Form
    {
        private UiImage image = null;
        private UiNode uiNode = UiFactory.Instance.NewUiNode();

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                WindowState = FormWindowState.Minimized;
                System.Threading.Thread.Sleep(200);

                image = UiFactory.Instance.NewUiImage();
                uiNode.FromScreenRegion(image.SelectInteractive());

                SelectorTextBox.Text = uiNode.GetSelector(true);
                //show image on form
                Bitmap pic = System.Drawing.Image.FromHbitmap((IntPtr)image.hBitmap);
                picture.Image = (Image)pic;
                picture.Visible = true;
                WindowState = FormWindowState.Normal;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (image == null)
                {
                    SelectImageMessageBox();
                    return;
                }
                if (FindImage())
                {
                    uiNode.StartHighlight();
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Image was not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectImageMessageBox()
        {
            MessageBox.Show("Please select an image and then choose what action to perform");
        }

        private void WaitBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }

            //get timeout
            int timeout = int.Parse(TimeoutTextBox.Text);
            //get wait options
            bool appear = false;
            if (AppearRadio.Checked)
            {
                appear = true;
            }

            try
            {
                uiNode.clippingRegion = null;
                uiNode.timeout = timeout;
                uiNode.WaitImage(image, GetAccuracy(), appear);
                if (appear)
                {
                    MessageBox.Show("Image appeared");
                }
                else
                {
                    MessageBox.Show("Image disappeared");
                }
            }
            catch (Exception)
            {
                if (appear)
                {
                    MessageBox.Show("Image didn't appear");
                }
                else
                {
                    MessageBox.Show("Image didn't disappear");
                }
            }

        }

        private void ClickBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }
            ClickImage(null, false);
        }

        private double GetAccuracy()
        {
            //get accuracy
            double accuracy = Double.Parse(AccuracyTextBox.Text);
            accuracy = accuracy / 100;
            if (accuracy <= 0 || accuracy > 1)
            {
                accuracy = 0.8;
            }
            return accuracy;
        }

        private void HoverBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }
            //hover instead of click
            ClickImage(null, true);
        }

        private void ClickImage(UiRegion[] regionCollection, bool hover)
        {
            UiClickType clickType = UiClickType.UI_CLICK_SINGLE;
            UiMouseButton mouseBtn = UiMouseButton.UI_BTN_LEFT;
            UiInputMethod inputMethod = UiInputMethod.UI_HARDWARE_EVENTS;

            //get input parameters
            if (DoubleBtn.Checked)
            {
                clickType = UiClickType.UI_CLICK_DOUBLE;
            }

            if (MiddleMouseBtn.Checked)
            {
                mouseBtn = UiMouseButton.UI_BTN_MIDDLE;
            }
            if (RightMouseBtn.Checked)
            {
                mouseBtn = UiMouseButton.UI_BTN_RIGHT;
            }

            if (Win32MsgBtn.Checked)
            {
                inputMethod = UiInputMethod.UI_WIN32_MSG;
            }
            if (ControlAPIBtn.Checked)
            {
                MessageBox.Show("Please select another input method for click or hover image");
                return;
            }

            try
            {
                if (regionCollection == null)
                {
                    if (!FindImage())
                    {
                        MessageBox.Show("The image was not found");
                        return;
                    }
                }
                if (hover)
                {
                    uiNode.Hover(uiNode.clippingRegion.width / 2, uiNode.clippingRegion.height / 2, inputMethod, 500);
                }
                else
                {
                    //click image
                    if (regionCollection == null)
                    {
                        uiNode.Click(uiNode.clippingRegion.width / 2, uiNode.clippingRegion.height / 2, clickType, mouseBtn, inputMethod);
                    }
                    else
                    {
                        //click all images
                        foreach (UiRegion region in regionCollection)
                        {
                            uiNode.clippingRegion = region;
                            uiNode.Click(uiNode.clippingRegion.width / 2, uiNode.clippingRegion.height / 2, clickType, mouseBtn, inputMethod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool FindImage()
        {
            //find image
            uiNode.clippingRegion = null;
            try
            {
                UiRegion imageRegion = uiNode.FindImage(image, GetAccuracy());
                if (imageRegion != null)
                {
                    uiNode.clippingRegion = imageRegion;
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void TypeBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }

            //get input method
            UiInputMethod inputMethod = UiInputMethod.UI_HARDWARE_EVENTS;
            if (Win32MsgBtn.Checked)
            {
                inputMethod = UiInputMethod.UI_WIN32_MSG;
            }
            if (ControlAPIBtn.Checked)
            {
                inputMethod = UiInputMethod.UI_CONTROL_API;
            }

            if (!FindImage())
            {
                MessageBox.Show("The image was not found");
            }
            else
            {
                try
                {
                    //remove clipping region
                    uiNode.clippingRegion = null;
                    //get text to type
                    string inputText = InputText.Text;
                    //type to control
                    uiNode.WriteText(inputText, inputMethod);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void DesktopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uiNode.FromDesktop();
                SelectorTextBox.Text = "Desktop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectUIObject_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            try
            {
                uiNode.SelectInteractive(UiSelectionType.UI_SELECT_NODE);
                SelectorTextBox.Text = uiNode.GetSelector(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            WindowState = FormWindowState.Normal;
        }

        private void FindAllBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }
            try
            {
                UiRegion[] imageRegions = GetAllImages();
                foreach (UiRegion region in imageRegions)
                {
                    uiNode.clippingRegion = region;
                    uiNode.StartHighlight();
                }
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private UiRegion[] GetAllImages()
        {
            uiNode.clippingRegion = null;
            UiImage UIObject = uiNode.Screenshot();
            return UIObject.FindAll(image, GetAccuracy()).Select(x => UiFactory.Instance.Cast<UiRegion>(x)).ToArray();
        }

        private void ClickAllBtn_Click(object sender, EventArgs e)
        {
            if (image == null)
            {
                SelectImageMessageBox();
                return;
            }
            try
            {
                UiRegion[] imageRegions = GetAllImages();
                ClickImage(imageRegions, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UiFactory.Instance.NewUiSystem().Cleanup();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            uiNode.StopHighlight();
        }

        private void HighlightBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uiNode.clippingRegion = null;
                uiNode.StartHighlight();
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
