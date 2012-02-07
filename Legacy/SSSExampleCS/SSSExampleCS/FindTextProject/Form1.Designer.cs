namespace FindTextProject
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radioNative = new System.Windows.Forms.RadioButton();
            this.radioOCR = new System.Windows.Forms.RadioButton();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.checkLayout = new System.Windows.Forms.CheckBox();
            this.comboEngine = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboClick = new System.Windows.Forms.ComboBox();
            this.comboMouseBtn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFoundH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoundW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoundY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFoundX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOccurence = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCaptureParams = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
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
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCaptureParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.radioNative);
            this.groupBox5.Controls.Add(this.radioOCR);
            this.groupBox5.Controls.Add(this.comboLang);
            this.groupBox5.Controls.Add(this.checkLayout);
            this.groupBox5.Controls.Add(this.comboEngine);
            this.groupBox5.Location = new System.Drawing.Point(13, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(258, 132);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose a screen Scraping method";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "-FullText cannot retreive text coordinates";
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
            // radioOCR
            // 
            this.radioOCR.AutoSize = true;
            this.radioOCR.Location = new System.Drawing.Point(6, 74);
            this.radioOCR.Name = "radioOCR";
            this.radioOCR.Size = new System.Drawing.Size(86, 17);
            this.radioOCR.TabIndex = 5;
            this.radioOCR.TabStop = true;
            this.radioOCR.Text = "OCR method";
            this.radioOCR.UseVisualStyleBackColor = true;
            // 
            // comboLang
            // 
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(184, 74);
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
            this.checkLayout.CheckedChanged += new System.EventHandler(this.checkLayout_CheckedChanged);
            // 
            // comboEngine
            // 
            this.comboEngine.FormattingEnabled = true;
            this.comboEngine.Location = new System.Drawing.Point(95, 74);
            this.comboEngine.Name = "comboEngine";
            this.comboEngine.Size = new System.Drawing.Size(83, 21);
            this.comboEngine.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboClick);
            this.groupBox2.Controls.Add(this.comboMouseBtn);
            this.groupBox2.Location = new System.Drawing.Point(16, 645);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 85);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Click on found text";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "Click on text";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboClick
            // 
            this.comboClick.FormattingEnabled = true;
            this.comboClick.Location = new System.Drawing.Point(118, 19);
            this.comboClick.Name = "comboClick";
            this.comboClick.Size = new System.Drawing.Size(121, 21);
            this.comboClick.TabIndex = 1;
            // 
            // comboMouseBtn
            // 
            this.comboMouseBtn.FormattingEnabled = true;
            this.comboMouseBtn.Location = new System.Drawing.Point(11, 19);
            this.comboMouseBtn.Name = "comboMouseBtn";
            this.comboMouseBtn.Size = new System.Drawing.Size(101, 21);
            this.comboMouseBtn.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtFoundH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFoundW);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFoundY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFoundX);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtOccurence);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 194);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find text";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 24);
            this.button3.TabIndex = 17;
            this.button3.Text = "Search text";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "-Coordinates are relative to the window";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Text was found at this location:";
            // 
            // txtFoundH
            // 
            this.txtFoundH.Location = new System.Drawing.Point(205, 138);
            this.txtFoundH.Name = "txtFoundH";
            this.txtFoundH.Size = new System.Drawing.Size(34, 20);
            this.txtFoundH.TabIndex = 18;
            this.txtFoundH.Text = "0";
            this.txtFoundH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(186, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "H:";
            // 
            // txtFoundW
            // 
            this.txtFoundW.Location = new System.Drawing.Point(148, 138);
            this.txtFoundW.Name = "txtFoundW";
            this.txtFoundW.Size = new System.Drawing.Size(37, 20);
            this.txtFoundW.TabIndex = 16;
            this.txtFoundW.Text = "0";
            this.txtFoundW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(125, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "W:";
            // 
            // txtFoundY
            // 
            this.txtFoundY.Location = new System.Drawing.Point(89, 138);
            this.txtFoundY.Name = "txtFoundY";
            this.txtFoundY.Size = new System.Drawing.Size(35, 20);
            this.txtFoundY.TabIndex = 14;
            this.txtFoundY.Text = "0";
            this.txtFoundY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(71, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Y:";
            // 
            // txtFoundX
            // 
            this.txtFoundX.Location = new System.Drawing.Point(29, 138);
            this.txtFoundX.Name = "txtFoundX";
            this.txtFoundX.Size = new System.Drawing.Size(39, 20);
            this.txtFoundX.TabIndex = 12;
            this.txtFoundX.Text = "0";
            this.txtFoundX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "X:";
            // 
            // txtOccurence
            // 
            this.txtOccurence.Location = new System.Drawing.Point(162, 57);
            this.txtOccurence.Name = "txtOccurence";
            this.txtOccurence.Size = new System.Drawing.Size(77, 20);
            this.txtOccurence.TabIndex = 4;
            this.txtOccurence.Text = "0";
            this.txtOccurence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Occurence;";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "What text do you want to find?";
            // 
            // grpCaptureParams
            // 
            this.grpCaptureParams.Controls.Add(this.label1);
            this.grpCaptureParams.Controls.Add(this.txtID);
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
            this.grpCaptureParams.Location = new System.Drawing.Point(13, 9);
            this.grpCaptureParams.Name = "grpCaptureParams";
            this.grpCaptureParams.Size = new System.Drawing.Size(258, 258);
            this.grpCaptureParams.TabIndex = 15;
            this.grpCaptureParams.TabStop = false;
            this.grpCaptureParams.Text = "Where is the text located?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 239);
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
            this.button1.Location = new System.Drawing.Point(35, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "INSIDE a window or control";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Window ID:";
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(35, 30);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(189, 24);
            this.btnCollect.TabIndex = 11;
            this.btnCollect.Text = "INSIDE a region on the screen";
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // txtHandle
            // 
            this.txtHandle.Location = new System.Drawing.Point(163, 108);
            this.txtHandle.Name = "txtHandle";
            this.txtHandle.Size = new System.Drawing.Size(77, 20);
            this.txtHandle.TabIndex = 1;
            this.txtHandle.Text = "0";
            this.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHandle
            // 
            this.lblHandle.Location = new System.Drawing.Point(12, 108);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(120, 16);
            this.lblHandle.TabIndex = 0;
            this.lblHandle.Text = "Window handle (hexa):";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(206, 202);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(34, 20);
            this.txtHeight.TabIndex = 10;
            this.txtHeight.Text = "0";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeight
            // 
            this.lblHeight.Location = new System.Drawing.Point(187, 204);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(20, 16);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "H:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(149, 202);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(37, 20);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWidth
            // 
            this.lblWidth.Location = new System.Drawing.Point(126, 204);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(26, 16);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "W:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(90, 202);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(35, 20);
            this.txtY.TabIndex = 6;
            this.txtY.Text = "0";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(72, 204);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(22, 16);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(30, 202);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(39, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(12, 204);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(40, 16);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 740);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCaptureParams);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCaptureParams.ResumeLayout(false);
            this.grpCaptureParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioNative;
        private System.Windows.Forms.RadioButton radioOCR;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.CheckBox checkLayout;
        private System.Windows.Forms.ComboBox comboEngine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboClick;
        private System.Windows.Forms.ComboBox comboMouseBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFoundH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFoundW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoundY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFoundX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOccurence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCaptureParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
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
    }
}