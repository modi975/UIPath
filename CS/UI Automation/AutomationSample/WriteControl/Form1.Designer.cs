namespace WriteControl
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
            this.TestBtn = new System.Windows.Forms.Button();
            this.SelectorTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CompleteBtn = new System.Windows.Forms.RadioButton();
            this.InteractiveBtn = new System.Windows.Forms.RadioButton();
            this.NoneBtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Win32Msg = new System.Windows.Forms.RadioButton();
            this.CtrlAPIBtn = new System.Windows.Forms.RadioButton();
            this.HardwareEvBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectCtrlBtn
            // 
            this.SelectCtrlBtn.Location = new System.Drawing.Point(12, 22);
            this.SelectCtrlBtn.Name = "SelectCtrlBtn";
            this.SelectCtrlBtn.Size = new System.Drawing.Size(116, 23);
            this.SelectCtrlBtn.TabIndex = 1;
            this.SelectCtrlBtn.Text = "Select control";
            this.SelectCtrlBtn.UseVisualStyleBackColor = true;
            this.SelectCtrlBtn.Click += new System.EventHandler(this.SelectCtrlBtn_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(134, 22);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(116, 23);
            this.TestBtn.TabIndex = 4;
            this.TestBtn.Text = "Test write";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // SelectorTextBox
            // 
            this.SelectorTextBox.Location = new System.Drawing.Point(12, 51);
            this.SelectorTextBox.Multiline = true;
            this.SelectorTextBox.Name = "SelectorTextBox";
            this.SelectorTextBox.Size = new System.Drawing.Size(502, 135);
            this.SelectorTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CompleteBtn);
            this.groupBox5.Controls.Add(this.InteractiveBtn);
            this.groupBox5.Controls.Add(this.NoneBtn);
            this.groupBox5.Location = new System.Drawing.Point(141, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 105);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wait for ready level";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Win32Msg);
            this.groupBox4.Controls.Add(this.CtrlAPIBtn);
            this.groupBox4.Controls.Add(this.HardwareEvBtn);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 106);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input method";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input text";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(62, 170);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(213, 20);
            this.InputTextBox.TabIndex = 5;
            this.InputTextBox.Text = "Sample text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectorTextBox);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.SelectCtrlBtn);
            this.Name = "Form1";
            this.Text = "Write control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectCtrlBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.TextBox SelectorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton CompleteBtn;
        private System.Windows.Forms.RadioButton InteractiveBtn;
        private System.Windows.Forms.RadioButton NoneBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Win32Msg;
        private System.Windows.Forms.RadioButton CtrlAPIBtn;
        private System.Windows.Forms.RadioButton HardwareEvBtn;
    }
}

