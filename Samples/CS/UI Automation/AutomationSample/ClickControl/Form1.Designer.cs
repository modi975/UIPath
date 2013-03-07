namespace AutomationSample
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
            this.SelectCtrlBtn = new System.Windows.Forms.Button();
            this.SelectorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LeftMouseBtn = new System.Windows.Forms.RadioButton();
            this.MiddleMouseBtn = new System.Windows.Forms.RadioButton();
            this.RightMouseBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SingleBtn = new System.Windows.Forms.RadioButton();
            this.DoubleButton = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.HardwareEvBtn = new System.Windows.Forms.RadioButton();
            this.CtrlAPIBtn = new System.Windows.Forms.RadioButton();
            this.Win32Msg = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NoneBtn = new System.Windows.Forms.RadioButton();
            this.InteractiveBtn = new System.Windows.Forms.RadioButton();
            this.CompleteBtn = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ClickControlBtn = new System.Windows.Forms.RadioButton();
            this.HoverOnlyBtn = new System.Windows.Forms.RadioButton();
            this.TestBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectCtrlBtn
            // 
            this.SelectCtrlBtn.Location = new System.Drawing.Point(13, 13);
            this.SelectCtrlBtn.Name = "SelectCtrlBtn";
            this.SelectCtrlBtn.Size = new System.Drawing.Size(116, 23);
            this.SelectCtrlBtn.TabIndex = 0;
            this.SelectCtrlBtn.Text = "Select control";
            this.SelectCtrlBtn.UseVisualStyleBackColor = true;
            this.SelectCtrlBtn.Click += new System.EventHandler(this.SelectCtrlBtn_Click);
            // 
            // SelectorTextBox
            // 
            this.SelectorTextBox.Location = new System.Drawing.Point(13, 46);
            this.SelectorTextBox.Multiline = true;
            this.SelectorTextBox.Name = "SelectorTextBox";
            this.SelectorTextBox.Size = new System.Drawing.Size(529, 135);
            this.SelectorTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(19, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RightMouseBtn);
            this.groupBox2.Controls.Add(this.MiddleMouseBtn);
            this.groupBox2.Controls.Add(this.LeftMouseBtn);
            this.groupBox2.Location = new System.Drawing.Point(10, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 106);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouse button";
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
            // RightMouseBtn
            // 
            this.RightMouseBtn.AutoSize = true;
            this.RightMouseBtn.Location = new System.Drawing.Point(7, 67);
            this.RightMouseBtn.Name = "RightMouseBtn";
            this.RightMouseBtn.Size = new System.Drawing.Size(50, 17);
            this.RightMouseBtn.TabIndex = 2;
            this.RightMouseBtn.Text = "Right";
            this.RightMouseBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DoubleButton);
            this.groupBox3.Controls.Add(this.SingleBtn);
            this.groupBox3.Location = new System.Drawing.Point(124, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(91, 106);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Click type";
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
            // DoubleButton
            // 
            this.DoubleButton.AutoSize = true;
            this.DoubleButton.Location = new System.Drawing.Point(7, 43);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(59, 17);
            this.DoubleButton.TabIndex = 1;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Win32Msg);
            this.groupBox4.Controls.Add(this.CtrlAPIBtn);
            this.groupBox4.Controls.Add(this.HardwareEvBtn);
            this.groupBox4.Location = new System.Drawing.Point(230, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input method";
            // 
            // HardwareEvBtn
            // 
            this.HardwareEvBtn.AutoSize = true;
            this.HardwareEvBtn.Checked = true;
            this.HardwareEvBtn.Location = new System.Drawing.Point(7, 20);
            this.HardwareEvBtn.Name = "HardwareEvBtn";
            this.HardwareEvBtn.Size = new System.Drawing.Size(106, 17);
            this.HardwareEvBtn.TabIndex = 0;
            this.HardwareEvBtn.TabStop = true;
            this.HardwareEvBtn.Text = "Hardware events";
            this.HardwareEvBtn.UseVisualStyleBackColor = true;
            // 
            // CtrlAPIBtn
            // 
            this.CtrlAPIBtn.AutoSize = true;
            this.CtrlAPIBtn.Location = new System.Drawing.Point(7, 43);
            this.CtrlAPIBtn.Name = "CtrlAPIBtn";
            this.CtrlAPIBtn.Size = new System.Drawing.Size(78, 17);
            this.CtrlAPIBtn.TabIndex = 1;
            this.CtrlAPIBtn.Text = "Control API";
            this.CtrlAPIBtn.UseVisualStyleBackColor = true;
            // 
            // Win32Msg
            // 
            this.Win32Msg.AutoSize = true;
            this.Win32Msg.Location = new System.Drawing.Point(7, 67);
            this.Win32Msg.Name = "Win32Msg";
            this.Win32Msg.Size = new System.Drawing.Size(107, 17);
            this.Win32Msg.TabIndex = 2;
            this.Win32Msg.Text = "Win32 Messages";
            this.Win32Msg.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CompleteBtn);
            this.groupBox5.Controls.Add(this.InteractiveBtn);
            this.groupBox5.Controls.Add(this.NoneBtn);
            this.groupBox5.Location = new System.Drawing.Point(372, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 105);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wait for ready level";
            // 
            // NoneBtn
            // 
            this.NoneBtn.AutoSize = true;
            this.NoneBtn.Location = new System.Drawing.Point(7, 20);
            this.NoneBtn.Name = "NoneBtn";
            this.NoneBtn.Size = new System.Drawing.Size(51, 17);
            this.NoneBtn.TabIndex = 0;
            this.NoneBtn.Text = "None";
            this.NoneBtn.UseVisualStyleBackColor = true;
            // 
            // InteractiveBtn
            // 
            this.InteractiveBtn.AutoSize = true;
            this.InteractiveBtn.Checked = true;
            this.InteractiveBtn.Location = new System.Drawing.Point(7, 43);
            this.InteractiveBtn.Name = "InteractiveBtn";
            this.InteractiveBtn.Size = new System.Drawing.Size(75, 17);
            this.InteractiveBtn.TabIndex = 1;
            this.InteractiveBtn.TabStop = true;
            this.InteractiveBtn.Text = "Interactive";
            this.InteractiveBtn.UseVisualStyleBackColor = true;
            // 
            // CompleteBtn
            // 
            this.CompleteBtn.AutoSize = true;
            this.CompleteBtn.Location = new System.Drawing.Point(7, 67);
            this.CompleteBtn.Name = "CompleteBtn";
            this.CompleteBtn.Size = new System.Drawing.Size(69, 17);
            this.CompleteBtn.TabIndex = 2;
            this.CompleteBtn.TabStop = true;
            this.CompleteBtn.Text = "Complete";
            this.CompleteBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.HoverOnlyBtn);
            this.groupBox6.Controls.Add(this.ClickControlBtn);
            this.groupBox6.Location = new System.Drawing.Point(13, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(97, 85);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Action";
            // 
            // ClickControlBtn
            // 
            this.ClickControlBtn.AutoSize = true;
            this.ClickControlBtn.Checked = true;
            this.ClickControlBtn.Location = new System.Drawing.Point(4, 20);
            this.ClickControlBtn.Name = "ClickControlBtn";
            this.ClickControlBtn.Size = new System.Drawing.Size(83, 17);
            this.ClickControlBtn.TabIndex = 0;
            this.ClickControlBtn.TabStop = true;
            this.ClickControlBtn.Text = "Click control";
            this.ClickControlBtn.UseVisualStyleBackColor = true;
            // 
            // HoverOnlyBtn
            // 
            this.HoverOnlyBtn.AutoSize = true;
            this.HoverOnlyBtn.Location = new System.Drawing.Point(4, 44);
            this.HoverOnlyBtn.Name = "HoverOnlyBtn";
            this.HoverOnlyBtn.Size = new System.Drawing.Size(76, 17);
            this.HoverOnlyBtn.TabIndex = 1;
            this.HoverOnlyBtn.TabStop = true;
            this.HoverOnlyBtn.Text = "Hover only";
            this.HoverOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(135, 13);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(116, 23);
            this.TestBtn.TabIndex = 3;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 431);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectorTextBox);
            this.Controls.Add(this.SelectCtrlBtn);
            this.Name = "Form1";
            this.Text = "Click control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectCtrlBtn;
        private System.Windows.Forms.TextBox SelectorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton DoubleButton;
        private System.Windows.Forms.RadioButton SingleBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RightMouseBtn;
        private System.Windows.Forms.RadioButton MiddleMouseBtn;
        private System.Windows.Forms.RadioButton LeftMouseBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton HoverOnlyBtn;
        private System.Windows.Forms.RadioButton ClickControlBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton CompleteBtn;
        private System.Windows.Forms.RadioButton InteractiveBtn;
        private System.Windows.Forms.RadioButton NoneBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Win32Msg;
        private System.Windows.Forms.RadioButton CtrlAPIBtn;
        private System.Windows.Forms.RadioButton HardwareEvBtn;
        private System.Windows.Forms.Button TestBtn;
    }
}

