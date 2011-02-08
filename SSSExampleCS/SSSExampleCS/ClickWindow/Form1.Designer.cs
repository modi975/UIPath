namespace ClickWindow
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
            this.grpCaptureParams = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.lblHandle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboClick = new System.Windows.Forms.ComboBox();
            this.comboMouseBtn = new System.Windows.Forms.ComboBox();
            this.grpCaptureParams.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCaptureParams
            // 
            this.grpCaptureParams.Controls.Add(this.label11);
            this.grpCaptureParams.Controls.Add(this.label1);
            this.grpCaptureParams.Controls.Add(this.txtID);
            this.grpCaptureParams.Controls.Add(this.button1);
            this.grpCaptureParams.Controls.Add(this.label2);
            this.grpCaptureParams.Controls.Add(this.txtHandle);
            this.grpCaptureParams.Controls.Add(this.lblHandle);
            this.grpCaptureParams.Location = new System.Drawing.Point(14, 12);
            this.grpCaptureParams.Name = "grpCaptureParams";
            this.grpCaptureParams.Size = new System.Drawing.Size(258, 235);
            this.grpCaptureParams.TabIndex = 7;
            this.grpCaptureParams.TabStop = false;
            this.grpCaptureParams.Text = "Select a control";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "If control don\'t have hwnd its parent window is used";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "-You can manually change these attributes";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 147);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 51);
            this.txtID.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select a control";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Control ID:";
            // 
            // txtHandle
            // 
            this.txtHandle.Location = new System.Drawing.Point(142, 72);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(77, 20);
            this.txtHandle.TabIndex = 1;
            this.txtHandle.Text = "0";
            this.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHandle
            // 
            this.lblHandle.Location = new System.Drawing.Point(12, 75);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(120, 16);
            this.lblHandle.TabIndex = 0;
            this.lblHandle.Text = "Control hwnd";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboClick);
            this.groupBox2.Controls.Add(this.comboMouseBtn);
            this.groupBox2.Location = new System.Drawing.Point(17, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click on control";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "Click on control";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboClick
            // 
            this.comboClick.FormattingEnabled = true;
            this.comboClick.Items.AddRange(new object[] {
            "Single Click",
            "Double Click"});
            this.comboClick.Location = new System.Drawing.Point(119, 19);
            this.comboClick.Name = "comboClick";
            this.comboClick.Size = new System.Drawing.Size(121, 21);
            this.comboClick.TabIndex = 1;
            // 
            // comboMouseBtn
            // 
            this.comboMouseBtn.FormattingEnabled = true;
            this.comboMouseBtn.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.comboMouseBtn.Location = new System.Drawing.Point(12, 20);
            this.comboMouseBtn.Name = "comboMouseBtn";
            this.comboMouseBtn.Size = new System.Drawing.Size(101, 21);
            this.comboMouseBtn.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.grpCaptureParams);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCaptureParams.ResumeLayout(false);
            this.grpCaptureParams.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCaptureParams;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHandle;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboClick;
        private System.Windows.Forms.ComboBox comboMouseBtn;
    }
}

