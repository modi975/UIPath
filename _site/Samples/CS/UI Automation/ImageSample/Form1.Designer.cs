namespace ImageSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClickAllBtn = new System.Windows.Forms.Button();
            this.TypeBtn = new System.Windows.Forms.Button();
            this.HoverBtn = new System.Windows.Forms.Button();
            this.ClickBtn = new System.Windows.Forms.Button();
            this.WaitBtn = new System.Windows.Forms.Button();
            this.FindAllBtn = new System.Windows.Forms.Button();
            this.FindImageBtn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.SelectImage = new System.Windows.Forms.Button();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClickOptions = new System.Windows.Forms.GroupBox();
            this.MouseBtnGroupBox = new System.Windows.Forms.GroupBox();
            this.RightMouseBtn = new System.Windows.Forms.RadioButton();
            this.MiddleMouseBtn = new System.Windows.Forms.RadioButton();
            this.LeftMouseBtn = new System.Windows.Forms.RadioButton();
            this.InputText = new System.Windows.Forms.TextBox();
            this.ClickTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.DoubleBtn = new System.Windows.Forms.RadioButton();
            this.SingleBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.Win32MsgBtn = new System.Windows.Forms.RadioButton();
            this.ControlAPIBtn = new System.Windows.Forms.RadioButton();
            this.HardwareEventsBtn = new System.Windows.Forms.RadioButton();
            this.WaitGroupBox = new System.Windows.Forms.GroupBox();
            this.AppearRadio = new System.Windows.Forms.RadioButton();
            this.TimeoutTextBox = new System.Windows.Forms.TextBox();
            this.DissapearRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccuracyTextBox = new System.Windows.Forms.TextBox();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.SelectUIObject = new System.Windows.Forms.Button();
            this.SelectorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DesktopBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HighlightBtn = new System.Windows.Forms.Button();
            this.ActionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.OptionsGroupBox.SuspendLayout();
            this.ClickOptions.SuspendLayout();
            this.MouseBtnGroupBox.SuspendLayout();
            this.ClickTypeGroupBox.SuspendLayout();
            this.InputMethodGroupBox.SuspendLayout();
            this.WaitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionsGroupBox
            // 
            this.ActionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ActionsGroupBox.Controls.Add(this.ClickAllBtn);
            this.ActionsGroupBox.Controls.Add(this.TypeBtn);
            this.ActionsGroupBox.Controls.Add(this.HoverBtn);
            this.ActionsGroupBox.Controls.Add(this.ClickBtn);
            this.ActionsGroupBox.Controls.Add(this.WaitBtn);
            this.ActionsGroupBox.Controls.Add(this.FindAllBtn);
            this.ActionsGroupBox.Controls.Add(this.FindImageBtn);
            this.ActionsGroupBox.Location = new System.Drawing.Point(6, 232);
            this.ActionsGroupBox.Name = "ActionsGroupBox";
            this.ActionsGroupBox.Size = new System.Drawing.Size(222, 300);
            this.ActionsGroupBox.TabIndex = 1;
            this.ActionsGroupBox.TabStop = false;
            this.ActionsGroupBox.Text = "Actions";
            // 
            // ClickAllBtn
            // 
            this.ClickAllBtn.Location = new System.Drawing.Point(7, 151);
            this.ClickAllBtn.Name = "ClickAllBtn";
            this.ClickAllBtn.Size = new System.Drawing.Size(119, 23);
            this.ClickAllBtn.TabIndex = 6;
            this.ClickAllBtn.Text = "Click all images";
            this.ClickAllBtn.UseVisualStyleBackColor = true;
            this.ClickAllBtn.Click += new System.EventHandler(this.ClickAllBtn_Click);
            // 
            // TypeBtn
            // 
            this.TypeBtn.Location = new System.Drawing.Point(7, 207);
            this.TypeBtn.Name = "TypeBtn";
            this.TypeBtn.Size = new System.Drawing.Size(119, 23);
            this.TypeBtn.TabIndex = 5;
            this.TypeBtn.Text = "Type on image";
            this.TypeBtn.UseVisualStyleBackColor = true;
            this.TypeBtn.Click += new System.EventHandler(this.TypeBtn_Click);
            // 
            // HoverBtn
            // 
            this.HoverBtn.Location = new System.Drawing.Point(7, 178);
            this.HoverBtn.Name = "HoverBtn";
            this.HoverBtn.Size = new System.Drawing.Size(119, 23);
            this.HoverBtn.TabIndex = 4;
            this.HoverBtn.Text = "Hover image";
            this.HoverBtn.UseVisualStyleBackColor = true;
            this.HoverBtn.Click += new System.EventHandler(this.HoverBtn_Click);
            // 
            // ClickBtn
            // 
            this.ClickBtn.Location = new System.Drawing.Point(7, 122);
            this.ClickBtn.Name = "ClickBtn";
            this.ClickBtn.Size = new System.Drawing.Size(119, 23);
            this.ClickBtn.TabIndex = 3;
            this.ClickBtn.Text = "Click on image";
            this.ClickBtn.UseVisualStyleBackColor = true;
            this.ClickBtn.Click += new System.EventHandler(this.ClickBtn_Click);
            // 
            // WaitBtn
            // 
            this.WaitBtn.Location = new System.Drawing.Point(7, 92);
            this.WaitBtn.Name = "WaitBtn";
            this.WaitBtn.Size = new System.Drawing.Size(119, 23);
            this.WaitBtn.TabIndex = 2;
            this.WaitBtn.Text = "Wait image";
            this.WaitBtn.UseVisualStyleBackColor = true;
            this.WaitBtn.Click += new System.EventHandler(this.WaitBtn_Click);
            // 
            // FindAllBtn
            // 
            this.FindAllBtn.Location = new System.Drawing.Point(7, 62);
            this.FindAllBtn.Name = "FindAllBtn";
            this.FindAllBtn.Size = new System.Drawing.Size(119, 23);
            this.FindAllBtn.TabIndex = 1;
            this.FindAllBtn.Text = "Find all images";
            this.FindAllBtn.UseVisualStyleBackColor = true;
            this.FindAllBtn.Click += new System.EventHandler(this.FindAllBtn_Click);
            // 
            // FindImageBtn
            // 
            this.FindImageBtn.Location = new System.Drawing.Point(7, 32);
            this.FindImageBtn.Name = "FindImageBtn";
            this.FindImageBtn.Size = new System.Drawing.Size(119, 23);
            this.FindImageBtn.TabIndex = 0;
            this.FindImageBtn.Text = "Find image";
            this.FindImageBtn.UseVisualStyleBackColor = true;
            this.FindImageBtn.Click += new System.EventHandler(this.FindImageBtn_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(158, 30);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(220, 196);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(6, 21);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(116, 23);
            this.SelectImage.TabIndex = 3;
            this.SelectImage.Text = "Select Image";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.SelectImage_Click);
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Controls.Add(this.ClickOptions);
            this.OptionsGroupBox.Controls.Add(this.WaitGroupBox);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.AccuracyTextBox);
            this.OptionsGroupBox.Controls.Add(this.AccuracyLabel);
            this.OptionsGroupBox.Location = new System.Drawing.Point(234, 232);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(617, 300);
            this.OptionsGroupBox.TabIndex = 5;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // ClickOptions
            // 
            this.ClickOptions.Controls.Add(this.MouseBtnGroupBox);
            this.ClickOptions.Controls.Add(this.InputText);
            this.ClickOptions.Controls.Add(this.ClickTypeGroupBox);
            this.ClickOptions.Controls.Add(this.label3);
            this.ClickOptions.Controls.Add(this.InputMethodGroupBox);
            this.ClickOptions.Location = new System.Drawing.Point(188, 18);
            this.ClickOptions.Name = "ClickOptions";
            this.ClickOptions.Size = new System.Drawing.Size(418, 270);
            this.ClickOptions.TabIndex = 13;
            this.ClickOptions.TabStop = false;
            this.ClickOptions.Text = "Click  and Type Options";
            // 
            // MouseBtnGroupBox
            // 
            this.MouseBtnGroupBox.Controls.Add(this.RightMouseBtn);
            this.MouseBtnGroupBox.Controls.Add(this.MiddleMouseBtn);
            this.MouseBtnGroupBox.Controls.Add(this.LeftMouseBtn);
            this.MouseBtnGroupBox.Location = new System.Drawing.Point(6, 29);
            this.MouseBtnGroupBox.Name = "MouseBtnGroupBox";
            this.MouseBtnGroupBox.Size = new System.Drawing.Size(126, 108);
            this.MouseBtnGroupBox.TabIndex = 8;
            this.MouseBtnGroupBox.TabStop = false;
            this.MouseBtnGroupBox.Text = "Mouse button";
            // 
            // RightMouseBtn
            // 
            this.RightMouseBtn.AutoSize = true;
            this.RightMouseBtn.Location = new System.Drawing.Point(7, 66);
            this.RightMouseBtn.Name = "RightMouseBtn";
            this.RightMouseBtn.Size = new System.Drawing.Size(50, 17);
            this.RightMouseBtn.TabIndex = 2;
            this.RightMouseBtn.Text = "Right";
            this.RightMouseBtn.UseVisualStyleBackColor = true;
            // 
            // MiddleMouseBtn
            // 
            this.MiddleMouseBtn.AutoSize = true;
            this.MiddleMouseBtn.Location = new System.Drawing.Point(7, 43);
            this.MiddleMouseBtn.Name = "MiddleMouseBtn";
            this.MiddleMouseBtn.Size = new System.Drawing.Size(56, 17);
            this.MiddleMouseBtn.TabIndex = 1;
            this.MiddleMouseBtn.Text = "Middle";
            this.MiddleMouseBtn.UseVisualStyleBackColor = true;
            // 
            // LeftMouseBtn
            // 
            this.LeftMouseBtn.AutoSize = true;
            this.LeftMouseBtn.Checked = true;
            this.LeftMouseBtn.Location = new System.Drawing.Point(7, 20);
            this.LeftMouseBtn.Name = "LeftMouseBtn";
            this.LeftMouseBtn.Size = new System.Drawing.Size(43, 17);
            this.LeftMouseBtn.TabIndex = 0;
            this.LeftMouseBtn.TabStop = true;
            this.LeftMouseBtn.Text = "Left";
            this.LeftMouseBtn.UseVisualStyleBackColor = true;
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(190, 157);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(132, 20);
            this.InputText.TabIndex = 12;
            this.InputText.Text = "sample text";
            // 
            // ClickTypeGroupBox
            // 
            this.ClickTypeGroupBox.Controls.Add(this.DoubleBtn);
            this.ClickTypeGroupBox.Controls.Add(this.SingleBtn);
            this.ClickTypeGroupBox.Location = new System.Drawing.Point(149, 30);
            this.ClickTypeGroupBox.Name = "ClickTypeGroupBox";
            this.ClickTypeGroupBox.Size = new System.Drawing.Size(113, 107);
            this.ClickTypeGroupBox.TabIndex = 9;
            this.ClickTypeGroupBox.TabStop = false;
            this.ClickTypeGroupBox.Text = "Click type";
            // 
            // DoubleBtn
            // 
            this.DoubleBtn.AutoSize = true;
            this.DoubleBtn.Location = new System.Drawing.Point(7, 43);
            this.DoubleBtn.Name = "DoubleBtn";
            this.DoubleBtn.Size = new System.Drawing.Size(59, 17);
            this.DoubleBtn.TabIndex = 1;
            this.DoubleBtn.Text = "Double";
            this.DoubleBtn.UseVisualStyleBackColor = true;
            // 
            // SingleBtn
            // 
            this.SingleBtn.AutoSize = true;
            this.SingleBtn.Checked = true;
            this.SingleBtn.Location = new System.Drawing.Point(7, 20);
            this.SingleBtn.Name = "SingleBtn";
            this.SingleBtn.Size = new System.Drawing.Size(54, 17);
            this.SingleBtn.TabIndex = 0;
            this.SingleBtn.TabStop = true;
            this.SingleBtn.Text = "Single";
            this.SingleBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text:";
            // 
            // InputMethodGroupBox
            // 
            this.InputMethodGroupBox.Controls.Add(this.Win32MsgBtn);
            this.InputMethodGroupBox.Controls.Add(this.ControlAPIBtn);
            this.InputMethodGroupBox.Controls.Add(this.HardwareEventsBtn);
            this.InputMethodGroupBox.Location = new System.Drawing.Point(6, 143);
            this.InputMethodGroupBox.Name = "InputMethodGroupBox";
            this.InputMethodGroupBox.Size = new System.Drawing.Size(126, 107);
            this.InputMethodGroupBox.TabIndex = 10;
            this.InputMethodGroupBox.TabStop = false;
            this.InputMethodGroupBox.Text = "Input method";
            // 
            // Win32MsgBtn
            // 
            this.Win32MsgBtn.AutoSize = true;
            this.Win32MsgBtn.Location = new System.Drawing.Point(7, 68);
            this.Win32MsgBtn.Name = "Win32MsgBtn";
            this.Win32MsgBtn.Size = new System.Drawing.Size(107, 17);
            this.Win32MsgBtn.TabIndex = 2;
            this.Win32MsgBtn.Text = "Win32 Messages";
            this.Win32MsgBtn.UseVisualStyleBackColor = true;
            // 
            // ControlAPIBtn
            // 
            this.ControlAPIBtn.AutoSize = true;
            this.ControlAPIBtn.Location = new System.Drawing.Point(7, 44);
            this.ControlAPIBtn.Name = "ControlAPIBtn";
            this.ControlAPIBtn.Size = new System.Drawing.Size(78, 17);
            this.ControlAPIBtn.TabIndex = 1;
            this.ControlAPIBtn.Text = "Control API";
            this.ControlAPIBtn.UseVisualStyleBackColor = true;
            // 
            // HardwareEventsBtn
            // 
            this.HardwareEventsBtn.AutoSize = true;
            this.HardwareEventsBtn.Checked = true;
            this.HardwareEventsBtn.Location = new System.Drawing.Point(7, 20);
            this.HardwareEventsBtn.Name = "HardwareEventsBtn";
            this.HardwareEventsBtn.Size = new System.Drawing.Size(106, 17);
            this.HardwareEventsBtn.TabIndex = 0;
            this.HardwareEventsBtn.TabStop = true;
            this.HardwareEventsBtn.Text = "Harwdare events";
            this.HardwareEventsBtn.UseVisualStyleBackColor = true;
            // 
            // WaitGroupBox
            // 
            this.WaitGroupBox.Controls.Add(this.AppearRadio);
            this.WaitGroupBox.Controls.Add(this.TimeoutTextBox);
            this.WaitGroupBox.Controls.Add(this.DissapearRadio);
            this.WaitGroupBox.Controls.Add(this.label2);
            this.WaitGroupBox.Location = new System.Drawing.Point(6, 46);
            this.WaitGroupBox.Name = "WaitGroupBox";
            this.WaitGroupBox.Size = new System.Drawing.Size(176, 145);
            this.WaitGroupBox.TabIndex = 7;
            this.WaitGroupBox.TabStop = false;
            this.WaitGroupBox.Text = "Wait options";
            // 
            // AppearRadio
            // 
            this.AppearRadio.AutoSize = true;
            this.AppearRadio.Checked = true;
            this.AppearRadio.Location = new System.Drawing.Point(6, 20);
            this.AppearRadio.Name = "AppearRadio";
            this.AppearRadio.Size = new System.Drawing.Size(74, 17);
            this.AppearRadio.TabIndex = 5;
            this.AppearRadio.TabStop = true;
            this.AppearRadio.Text = "To appear";
            this.AppearRadio.UseVisualStyleBackColor = true;
            // 
            // TimeoutTextBox
            // 
            this.TimeoutTextBox.Location = new System.Drawing.Point(78, 79);
            this.TimeoutTextBox.Name = "TimeoutTextBox";
            this.TimeoutTextBox.Size = new System.Drawing.Size(40, 20);
            this.TimeoutTextBox.TabIndex = 4;
            this.TimeoutTextBox.Text = "5000";
            this.TimeoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DissapearRadio
            // 
            this.DissapearRadio.AutoSize = true;
            this.DissapearRadio.Location = new System.Drawing.Point(6, 43);
            this.DissapearRadio.Name = "DissapearRadio";
            this.DissapearRadio.Size = new System.Drawing.Size(86, 17);
            this.DissapearRadio.TabIndex = 6;
            this.DissapearRadio.Text = "To dissapear";
            this.DissapearRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wait timeout:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "%";
            // 
            // AccuracyTextBox
            // 
            this.AccuracyTextBox.Location = new System.Drawing.Point(82, 18);
            this.AccuracyTextBox.Name = "AccuracyTextBox";
            this.AccuracyTextBox.Size = new System.Drawing.Size(26, 20);
            this.AccuracyTextBox.TabIndex = 1;
            this.AccuracyTextBox.Text = "80";
            this.AccuracyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Location = new System.Drawing.Point(7, 20);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(61, 13);
            this.AccuracyLabel.TabIndex = 0;
            this.AccuracyLabel.Text = "Accuracy : ";
            // 
            // SelectUIObject
            // 
            this.SelectUIObject.Location = new System.Drawing.Point(707, 21);
            this.SelectUIObject.Name = "SelectUIObject";
            this.SelectUIObject.Size = new System.Drawing.Size(144, 26);
            this.SelectUIObject.TabIndex = 6;
            this.SelectUIObject.Text = "Select another UI Object";
            this.SelectUIObject.UseVisualStyleBackColor = true;
            this.SelectUIObject.Click += new System.EventHandler(this.SelectUIObject_Click);
            // 
            // SelectorTextBox
            // 
            this.SelectorTextBox.Location = new System.Drawing.Point(400, 30);
            this.SelectorTextBox.Multiline = true;
            this.SelectorTextBox.Name = "SelectorTextBox";
            this.SelectorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.SelectorTextBox.Size = new System.Drawing.Size(294, 196);
            this.SelectorTextBox.TabIndex = 7;
            this.SelectorTextBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Source image ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Target UI Object selector";
            // 
            // DesktopBtn
            // 
            this.DesktopBtn.Location = new System.Drawing.Point(707, 54);
            this.DesktopBtn.Name = "DesktopBtn";
            this.DesktopBtn.Size = new System.Drawing.Size(144, 23);
            this.DesktopBtn.TabIndex = 10;
            this.DesktopBtn.Text = "Get Desktop";
            this.DesktopBtn.UseVisualStyleBackColor = true;
            this.DesktopBtn.Click += new System.EventHandler(this.DesktopBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HighlightBtn
            // 
            this.HighlightBtn.Location = new System.Drawing.Point(707, 84);
            this.HighlightBtn.Name = "HighlightBtn";
            this.HighlightBtn.Size = new System.Drawing.Size(144, 23);
            this.HighlightBtn.TabIndex = 11;
            this.HighlightBtn.Text = "Highlight target";
            this.HighlightBtn.UseVisualStyleBackColor = true;
            this.HighlightBtn.Click += new System.EventHandler(this.HighlightBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 538);
            this.Controls.Add(this.HighlightBtn);
            this.Controls.Add(this.DesktopBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectorTextBox);
            this.Controls.Add(this.SelectUIObject);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.SelectImage);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.ActionsGroupBox);
            this.Name = "Form1";
            this.Text = "Image sample";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ActionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ClickOptions.ResumeLayout(false);
            this.ClickOptions.PerformLayout();
            this.MouseBtnGroupBox.ResumeLayout(false);
            this.MouseBtnGroupBox.PerformLayout();
            this.ClickTypeGroupBox.ResumeLayout(false);
            this.ClickTypeGroupBox.PerformLayout();
            this.InputMethodGroupBox.ResumeLayout(false);
            this.InputMethodGroupBox.PerformLayout();
            this.WaitGroupBox.ResumeLayout(false);
            this.WaitGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ActionsGroupBox;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Button TypeBtn;
        private System.Windows.Forms.Button HoverBtn;
        private System.Windows.Forms.Button ClickBtn;
        private System.Windows.Forms.Button WaitBtn;
        private System.Windows.Forms.Button FindAllBtn;
        private System.Windows.Forms.Button FindImageBtn;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.GroupBox ClickOptions;
        private System.Windows.Forms.GroupBox MouseBtnGroupBox;
        private System.Windows.Forms.RadioButton RightMouseBtn;
        private System.Windows.Forms.RadioButton MiddleMouseBtn;
        private System.Windows.Forms.RadioButton LeftMouseBtn;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.GroupBox ClickTypeGroupBox;
        private System.Windows.Forms.RadioButton DoubleBtn;
        private System.Windows.Forms.RadioButton SingleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox InputMethodGroupBox;
        private System.Windows.Forms.RadioButton Win32MsgBtn;
        private System.Windows.Forms.RadioButton ControlAPIBtn;
        private System.Windows.Forms.RadioButton HardwareEventsBtn;
        private System.Windows.Forms.GroupBox WaitGroupBox;
        private System.Windows.Forms.RadioButton AppearRadio;
        private System.Windows.Forms.TextBox TimeoutTextBox;
        private System.Windows.Forms.RadioButton DissapearRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccuracyTextBox;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.Button SelectUIObject;
        private System.Windows.Forms.Button ClickAllBtn;
        private System.Windows.Forms.TextBox SelectorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DesktopBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button HighlightBtn;
    }
}

