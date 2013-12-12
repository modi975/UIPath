namespace WriteText
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWriteText = new System.Windows.Forms.TextBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioSendKeys = new System.Windows.Forms.RadioButton();
            this.radioAPI = new System.Windows.Forms.RadioButton();
            this.grpCaptureParams.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.grpCaptureParams.TabIndex = 25;
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
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "-You can manually change Control ID";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWriteText);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Location = new System.Drawing.Point(14, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 139);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write text";
            // 
            // txtWriteText
            // 
            this.txtWriteText.Location = new System.Drawing.Point(15, 29);
            this.txtWriteText.Multiline = true;
            this.txtWriteText.Name = "txtWriteText";
            this.txtWriteText.Size = new System.Drawing.Size(227, 51);
            this.txtWriteText.TabIndex = 17;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(35, 99);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(185, 24);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Write text";
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioSendKeys);
            this.groupBox5.Controls.Add(this.radioAPI);
            this.groupBox5.Location = new System.Drawing.Point(14, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 79);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose a writing method";
            // 
            // radioSendKeys
            // 
            this.radioSendKeys.AutoSize = true;
            this.radioSendKeys.Location = new System.Drawing.Point(6, 23);
            this.radioSendKeys.Name = "radioSendKeys";
            this.radioSendKeys.Size = new System.Drawing.Size(113, 17);
            this.radioSendKeys.TabIndex = 5;
            this.radioSendKeys.TabStop = true;
            this.radioSendKeys.Text = "Send keys method";
            this.radioSendKeys.UseVisualStyleBackColor = true;
            // 
            // radioAPI
            // 
            this.radioAPI.AutoSize = true;
            this.radioAPI.Location = new System.Drawing.Point(6, 46);
            this.radioAPI.Name = "radioAPI";
            this.radioAPI.Size = new System.Drawing.Size(116, 17);
            this.radioAPI.TabIndex = 5;
            this.radioAPI.TabStop = true;
            this.radioAPI.Text = "Control API method";
            this.radioAPI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 497);
            this.Controls.Add(this.grpCaptureParams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCaptureParams.ResumeLayout(false);
            this.grpCaptureParams.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWriteText;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioSendKeys;
        private System.Windows.Forms.RadioButton radioAPI;
    }
}

