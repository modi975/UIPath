namespace SSSExampleCS
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioNative = new System.Windows.Forms.RadioButton();
            this.radioFullText = new System.Windows.Forms.RadioButton();
            this.radioOCR = new System.Windows.Forms.RadioButton();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.checkLayout = new System.Windows.Forms.CheckBox();
            this.comboEngine = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkIDorHWND = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.grpCaptureParams = new System.Windows.Forms.GroupBox();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCollect = new System.Windows.Forms.Button();
            this.txtHandle = new System.Windows.Forms.TextBox();
            this.lblHandle = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCaptureParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 583);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Output:";
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(36, 152);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(187, 24);
            this.btnPoint.TabIndex = 17;
            this.btnPoint.Text = "Get word from a X,Y point";
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnActive
            // 
            this.btnActive.Location = new System.Drawing.Point(36, 122);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(187, 24);
            this.btnActive.TabIndex = 19;
            this.btnActive.Text = "Get Text out of active window";
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioNative);
            this.groupBox5.Controls.Add(this.radioFullText);
            this.groupBox5.Controls.Add(this.radioOCR);
            this.groupBox5.Controls.Add(this.comboLang);
            this.groupBox5.Controls.Add(this.checkLayout);
            this.groupBox5.Controls.Add(this.comboEngine);
            this.groupBox5.Location = new System.Drawing.Point(14, 245);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 104);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Screen Scraping methods";
            // 
            // radioNative
            // 
            this.radioNative.AutoSize = true;
            this.radioNative.Location = new System.Drawing.Point(6, 23);
            this.radioNative.Name = "radioNative";
            this.radioNative.Size = new System.Drawing.Size(94, 17);
            this.radioNative.TabIndex = 5;
            this.radioNative.TabStop = true;
            this.radioNative.Text = "Native method";
            this.radioNative.UseVisualStyleBackColor = true;
            // 
            // radioFullText
            // 
            this.radioFullText.AutoSize = true;
            this.radioFullText.Location = new System.Drawing.Point(144, 23);
            this.radioFullText.Name = "radioFullText";
            this.radioFullText.Size = new System.Drawing.Size(96, 17);
            this.radioFullText.TabIndex = 5;
            this.radioFullText.TabStop = true;
            this.radioFullText.Text = "Fulltext method";
            this.radioFullText.UseVisualStyleBackColor = true;
            // 
            // radioOCR
            // 
            this.radioOCR.AutoSize = true;
            this.radioOCR.Location = new System.Drawing.Point(9, 72);
            this.radioOCR.Name = "radioOCR";
            this.radioOCR.Size = new System.Drawing.Size(86, 17);
            this.radioOCR.TabIndex = 5;
            this.radioOCR.TabStop = true;
            this.radioOCR.Text = "OCR method";
            this.radioOCR.UseVisualStyleBackColor = true;
            // 
            // comboLang
            // 
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(186, 72);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(66, 21);
            this.comboLang.TabIndex = 10;
            // 
            // checkLayout
            // 
            this.checkLayout.AutoSize = true;
            this.checkLayout.Location = new System.Drawing.Point(26, 46);
            this.checkLayout.Name = "checkLayout";
            this.checkLayout.Size = new System.Drawing.Size(99, 17);
            this.checkLayout.TabIndex = 6;
            this.checkLayout.Text = "Preserve layout";
            this.checkLayout.UseVisualStyleBackColor = true;
            // 
            // comboEngine
            // 
            this.comboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEngine.FormattingEnabled = true;
            this.comboEngine.Location = new System.Drawing.Point(98, 72);
            this.comboEngine.Name = "comboEngine";
            this.comboEngine.Size = new System.Drawing.Size(83, 21);
            this.comboEngine.TabIndex = 10;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 602);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(258, 119);
            this.txtResult.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkIDorHWND);
            this.groupBox1.Controls.Add(this.btnPoint);
            this.groupBox1.Controls.Add(this.btnActive);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnRectangle);
            this.groupBox1.Location = new System.Drawing.Point(14, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 189);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region screen scraping";
            // 
            // checkIDorHWND
            // 
            this.checkIDorHWND.AutoSize = true;
            this.checkIDorHWND.Location = new System.Drawing.Point(6, 32);
            this.checkIDorHWND.Name = "checkIDorHWND";
            this.checkIDorHWND.Size = new System.Drawing.Size(182, 17);
            this.checkIDorHWND.TabIndex = 20;
            this.checkIDorHWND.Text = "Use the ID instead of the HWND";
            this.checkIDorHWND.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get text from defined window";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(36, 58);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(187, 24);
            this.btnRectangle.TabIndex = 1;
            this.btnRectangle.Text = "Get text from defined region";
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // grpCaptureParams
            // 
            this.grpCaptureParams.Controls.Add(this.label1);
            this.grpCaptureParams.Controls.Add(this.textBox1);
            this.grpCaptureParams.Controls.Add(this.button1);
            this.grpCaptureParams.Controls.Add(this.label2);
            this.grpCaptureParams.Controls.Add(this.btnCollect);
            this.grpCaptureParams.Controls.Add(this.txtHandle);
            this.grpCaptureParams.Controls.Add(this.lblHandle);
            this.grpCaptureParams.Controls.Add(this.txtHeight);
            this.grpCaptureParams.Controls.Add(this.lblHeight);
            this.grpCaptureParams.Controls.Add(this.txtWidth);
            this.grpCaptureParams.Controls.Add(this.lblWidth);
            this.grpCaptureParams.Controls.Add(this.txtY);
            this.grpCaptureParams.Controls.Add(this.lblY);
            this.grpCaptureParams.Controls.Add(this.txtX);
            this.grpCaptureParams.Controls.Add(this.lblX);
            this.grpCaptureParams.Location = new System.Drawing.Point(13, 6);
            this.grpCaptureParams.Name = "grpCaptureParams";
            this.grpCaptureParams.Size = new System.Drawing.Size(258, 233);
            this.grpCaptureParams.TabIndex = 18;
            this.grpCaptureParams.TabStop = false;
            this.grpCaptureParams.Text = "What do you want to scrape";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(51, 555);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(116, 20);
            this.txtFont.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Font: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "You can manually change these attributes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 54);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Select a window or control";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Window ID:";
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(35, 21);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(185, 24);
            this.btnCollect.TabIndex = 11;
            this.btnCollect.Text = "Select a region from the screen";
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // txtHandle
            // 
            this.txtHandle.Location = new System.Drawing.Point(166, 82);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(74, 20);
            this.txtHandle.TabIndex = 1;
            this.txtHandle.Text = "0";
            this.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHandle
            // 
            this.lblHandle.Location = new System.Drawing.Point(12, 82);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(120, 16);
            this.lblHandle.TabIndex = 0;
            this.lblHandle.Text = "Window handle (hexa):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(204, 184);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(36, 20);
            this.txtHeight.TabIndex = 10;
            this.txtHeight.Text = "0";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(181, 183);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(19, 19);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "H:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(145, 184);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(33, 20);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWidth
            // 
            this.lblWidth.Location = new System.Drawing.Point(126, 183);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(28, 19);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "W:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(93, 184);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(30, 20);
            this.txtY.TabIndex = 6;
            this.txtY.Text = "0";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(74, 183);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(32, 19);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(35, 184);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(35, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(10, 183);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(40, 19);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Size:";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(212, 555);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(55, 20);
            this.txtFontSize.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 726);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCaptureParams);
            this.Name = "Form1";
            this.Text = "Screen Scraper Studio Sample";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCaptureParams.ResumeLayout(false);
            this.grpCaptureParams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioNative;
        private System.Windows.Forms.RadioButton radioFullText;
        private System.Windows.Forms.RadioButton radioOCR;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.CheckBox checkLayout;
        private System.Windows.Forms.ComboBox comboEngine;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.GroupBox grpCaptureParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtHandle;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkIDorHWND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFontSize;
    }
}

