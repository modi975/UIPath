namespace Scrape
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
            this.Select_UIObject = new System.Windows.Forms.Button();
            this.textSelector = new System.Windows.Forms.TextBox();
            this.Select_Region = new System.Windows.Forms.Button();
            this.btnActiveWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScrapeMethod_Combo = new System.Windows.Forms.ComboBox();
            this.GetFont_Checkbox = new System.Windows.Forms.CheckBox();
            this.FormattedText_Checkbox = new System.Windows.Forms.CheckBox();
            this.IgnoreHidden_Checkbox = new System.Windows.Forms.CheckBox();
            this.OCREngine_label = new System.Windows.Forms.Label();
            this.OCREngine_combo = new System.Windows.Forms.ComboBox();
            this.OCRLanguage_label = new System.Windows.Forms.Label();
            this.OCRLanguage_Combo = new System.Windows.Forms.ComboBox();
            this.Correction_checkbox = new System.Windows.Forms.CheckBox();
            this.Invert_checkbox = new System.Windows.Forms.CheckBox();
            this.AllowedChars_label = new System.Windows.Forms.Label();
            this.DeniedChars_label = new System.Windows.Forms.Label();
            this.textBoxAllowedChars = new System.Windows.Forms.TextBox();
            this.textBoxDeniedChars = new System.Windows.Forms.TextBox();
            this.Scrape = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.ExtractInfo_Checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Select_UIObject
            // 
            this.Select_UIObject.Location = new System.Drawing.Point(12, 140);
            this.Select_UIObject.Name = "Select_UIObject";
            this.Select_UIObject.Size = new System.Drawing.Size(147, 23);
            this.Select_UIObject.TabIndex = 0;
            this.Select_UIObject.Text = "Select a UI object";
            this.Select_UIObject.UseVisualStyleBackColor = true;
            this.Select_UIObject.Click += new System.EventHandler(this.Select_UIObject_Click);
            // 
            // textSelector
            // 
            this.textSelector.Location = new System.Drawing.Point(12, 20);
            this.textSelector.Multiline = true;
            this.textSelector.Name = "textSelector";
            this.textSelector.Size = new System.Drawing.Size(510, 113);
            this.textSelector.TabIndex = 1;
            // 
            // Select_Region
            // 
            this.Select_Region.Location = new System.Drawing.Point(200, 140);
            this.Select_Region.Name = "Select_Region";
            this.Select_Region.Size = new System.Drawing.Size(132, 23);
            this.Select_Region.TabIndex = 2;
            this.Select_Region.Text = "Select a region";
            this.Select_Region.UseVisualStyleBackColor = true;
            this.Select_Region.Click += new System.EventHandler(this.Select_Region_Click);
            // 
            // btnActiveWindow
            // 
            this.btnActiveWindow.Location = new System.Drawing.Point(372, 140);
            this.btnActiveWindow.Name = "btnActiveWindow";
            this.btnActiveWindow.Size = new System.Drawing.Size(150, 23);
            this.btnActiveWindow.TabIndex = 3;
            this.btnActiveWindow.Text = "Get active window";
            this.btnActiveWindow.UseVisualStyleBackColor = true;
            this.btnActiveWindow.Click += new System.EventHandler(this.btnActiveWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scrape method";
            // 
            // ScrapeMethod_Combo
            // 
            this.ScrapeMethod_Combo.FormattingEnabled = true;
            this.ScrapeMethod_Combo.Items.AddRange(new object[] {
            "UI_AUTOMATIC",
            "UI_NATIVE",
            "UI_FULLTEXT",
            "UI_OCR"});
            this.ScrapeMethod_Combo.Location = new System.Drawing.Point(102, 189);
            this.ScrapeMethod_Combo.Name = "ScrapeMethod_Combo";
            this.ScrapeMethod_Combo.Size = new System.Drawing.Size(121, 21);
            this.ScrapeMethod_Combo.TabIndex = 5;
            this.ScrapeMethod_Combo.SelectedIndexChanged += new System.EventHandler(this.ScrapeMethod_Combo_SelectedIndexChanged);
            // 
            // GetFont_Checkbox
            // 
            this.GetFont_Checkbox.AutoSize = true;
            this.GetFont_Checkbox.Location = new System.Drawing.Point(19, 255);
            this.GetFont_Checkbox.Name = "GetFont_Checkbox";
            this.GetFont_Checkbox.Size = new System.Drawing.Size(64, 17);
            this.GetFont_Checkbox.TabIndex = 7;
            this.GetFont_Checkbox.Text = "Get font";
            this.GetFont_Checkbox.UseVisualStyleBackColor = true;
            this.GetFont_Checkbox.Visible = false;
            // 
            // FormattedText_Checkbox
            // 
            this.FormattedText_Checkbox.AutoSize = true;
            this.FormattedText_Checkbox.Location = new System.Drawing.Point(88, 255);
            this.FormattedText_Checkbox.Name = "FormattedText_Checkbox";
            this.FormattedText_Checkbox.Size = new System.Drawing.Size(93, 17);
            this.FormattedText_Checkbox.TabIndex = 8;
            this.FormattedText_Checkbox.Text = "Formatted text";
            this.FormattedText_Checkbox.UseVisualStyleBackColor = true;
            this.FormattedText_Checkbox.Visible = false;
            // 
            // IgnoreHidden_Checkbox
            // 
            this.IgnoreHidden_Checkbox.AutoSize = true;
            this.IgnoreHidden_Checkbox.Location = new System.Drawing.Point(19, 255);
            this.IgnoreHidden_Checkbox.Name = "IgnoreHidden_Checkbox";
            this.IgnoreHidden_Checkbox.Size = new System.Drawing.Size(91, 17);
            this.IgnoreHidden_Checkbox.TabIndex = 9;
            this.IgnoreHidden_Checkbox.Text = "Ignore hidden";
            this.IgnoreHidden_Checkbox.UseVisualStyleBackColor = true;
            this.IgnoreHidden_Checkbox.Visible = false;
            // 
            // OCREngine_label
            // 
            this.OCREngine_label.AutoSize = true;
            this.OCREngine_label.Location = new System.Drawing.Point(17, 254);
            this.OCREngine_label.Name = "OCREngine_label";
            this.OCREngine_label.Size = new System.Drawing.Size(66, 13);
            this.OCREngine_label.TabIndex = 10;
            this.OCREngine_label.Text = "OCR Engine";
            this.OCREngine_label.Visible = false;
            // 
            // OCREngine_combo
            // 
            this.OCREngine_combo.FormattingEnabled = true;
            this.OCREngine_combo.Items.AddRange(new object[] {
            "UI_OCR_TESSERACT",
            "UI_OCR_MODI"});
            this.OCREngine_combo.Location = new System.Drawing.Point(102, 251);
            this.OCREngine_combo.Name = "OCREngine_combo";
            this.OCREngine_combo.Size = new System.Drawing.Size(121, 21);
            this.OCREngine_combo.TabIndex = 11;
            this.OCREngine_combo.Visible = false;
            this.OCREngine_combo.SelectedIndexChanged += new System.EventHandler(this.OCREngine_combo_SelectedIndexChanged);
            // 
            // OCRLanguage_label
            // 
            this.OCRLanguage_label.AutoSize = true;
            this.OCRLanguage_label.Location = new System.Drawing.Point(15, 286);
            this.OCRLanguage_label.Name = "OCRLanguage_label";
            this.OCRLanguage_label.Size = new System.Drawing.Size(81, 13);
            this.OCRLanguage_label.TabIndex = 12;
            this.OCRLanguage_label.Text = "OCR Language";
            this.OCRLanguage_label.Visible = false;
            // 
            // OCRLanguage_Combo
            // 
            this.OCRLanguage_Combo.FormattingEnabled = true;
            this.OCRLanguage_Combo.Location = new System.Drawing.Point(102, 283);
            this.OCRLanguage_Combo.Name = "OCRLanguage_Combo";
            this.OCRLanguage_Combo.Size = new System.Drawing.Size(121, 21);
            this.OCRLanguage_Combo.TabIndex = 13;
            this.OCRLanguage_Combo.Visible = false;
            // 
            // Correction_checkbox
            // 
            this.Correction_checkbox.AutoSize = true;
            this.Correction_checkbox.Location = new System.Drawing.Point(19, 312);
            this.Correction_checkbox.Name = "Correction_checkbox";
            this.Correction_checkbox.Size = new System.Drawing.Size(74, 17);
            this.Correction_checkbox.TabIndex = 14;
            this.Correction_checkbox.Text = "Correction";
            this.Correction_checkbox.UseVisualStyleBackColor = true;
            this.Correction_checkbox.Visible = false;
            // 
            // Invert_checkbox
            // 
            this.Invert_checkbox.AutoSize = true;
            this.Invert_checkbox.Location = new System.Drawing.Point(19, 335);
            this.Invert_checkbox.Name = "Invert_checkbox";
            this.Invert_checkbox.Size = new System.Drawing.Size(53, 17);
            this.Invert_checkbox.TabIndex = 15;
            this.Invert_checkbox.Text = "Invert";
            this.Invert_checkbox.UseVisualStyleBackColor = true;
            this.Invert_checkbox.Visible = false;
            // 
            // AllowedChars_label
            // 
            this.AllowedChars_label.AutoSize = true;
            this.AllowedChars_label.Location = new System.Drawing.Point(16, 364);
            this.AllowedChars_label.Name = "AllowedChars_label";
            this.AllowedChars_label.Size = new System.Drawing.Size(97, 13);
            this.AllowedChars_label.TabIndex = 16;
            this.AllowedChars_label.Text = "Allowed characters";
            this.AllowedChars_label.Visible = false;
            // 
            // DeniedChars_label
            // 
            this.DeniedChars_label.AutoSize = true;
            this.DeniedChars_label.Location = new System.Drawing.Point(16, 388);
            this.DeniedChars_label.Name = "DeniedChars_label";
            this.DeniedChars_label.Size = new System.Drawing.Size(94, 13);
            this.DeniedChars_label.TabIndex = 17;
            this.DeniedChars_label.Text = "Denied characters";
            this.DeniedChars_label.Visible = false;
            // 
            // textBoxAllowedChars
            // 
            this.textBoxAllowedChars.Location = new System.Drawing.Point(117, 361);
            this.textBoxAllowedChars.Name = "textBoxAllowedChars";
            this.textBoxAllowedChars.Size = new System.Drawing.Size(158, 20);
            this.textBoxAllowedChars.TabIndex = 18;
            this.textBoxAllowedChars.Visible = false;
            // 
            // textBoxDeniedChars
            // 
            this.textBoxDeniedChars.Location = new System.Drawing.Point(117, 388);
            this.textBoxDeniedChars.Name = "textBoxDeniedChars";
            this.textBoxDeniedChars.Size = new System.Drawing.Size(158, 20);
            this.textBoxDeniedChars.TabIndex = 19;
            this.textBoxDeniedChars.Visible = false;
            // 
            // Scrape
            // 
            this.Scrape.Location = new System.Drawing.Point(372, 182);
            this.Scrape.Name = "Scrape";
            this.Scrape.Size = new System.Drawing.Size(75, 23);
            this.Scrape.TabIndex = 20;
            this.Scrape.Text = "Scrape";
            this.Scrape.UseVisualStyleBackColor = true;
            this.Scrape.Click += new System.EventHandler(this.Scrape_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(17, 454);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(512, 155);
            this.textBoxOutput.TabIndex = 21;
            // 
            // ExtractInfo_Checkbox
            // 
            this.ExtractInfo_Checkbox.AutoSize = true;
            this.ExtractInfo_Checkbox.Location = new System.Drawing.Point(19, 221);
            this.ExtractInfo_Checkbox.Name = "ExtractInfo_Checkbox";
            this.ExtractInfo_Checkbox.Size = new System.Drawing.Size(79, 17);
            this.ExtractInfo_Checkbox.TabIndex = 22;
            this.ExtractInfo_Checkbox.Text = "Extract info";
            this.ExtractInfo_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 621);
            this.Controls.Add(this.ExtractInfo_Checkbox);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.Scrape);
            this.Controls.Add(this.textBoxDeniedChars);
            this.Controls.Add(this.textBoxAllowedChars);
            this.Controls.Add(this.DeniedChars_label);
            this.Controls.Add(this.AllowedChars_label);
            this.Controls.Add(this.Invert_checkbox);
            this.Controls.Add(this.Correction_checkbox);
            this.Controls.Add(this.OCRLanguage_Combo);
            this.Controls.Add(this.OCRLanguage_label);
            this.Controls.Add(this.OCREngine_combo);
            this.Controls.Add(this.OCREngine_label);
            this.Controls.Add(this.IgnoreHidden_Checkbox);
            this.Controls.Add(this.FormattedText_Checkbox);
            this.Controls.Add(this.GetFont_Checkbox);
            this.Controls.Add(this.ScrapeMethod_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActiveWindow);
            this.Controls.Add(this.Select_Region);
            this.Controls.Add(this.textSelector);
            this.Controls.Add(this.Select_UIObject);
            this.Name = "Form1";
            this.Text = "Scrape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Select_UIObject;
        private System.Windows.Forms.TextBox textSelector;
        private System.Windows.Forms.Button Select_Region;
        private System.Windows.Forms.Button btnActiveWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ScrapeMethod_Combo;
        private System.Windows.Forms.CheckBox GetFont_Checkbox;
        private System.Windows.Forms.CheckBox FormattedText_Checkbox;
        private System.Windows.Forms.CheckBox IgnoreHidden_Checkbox;
        private System.Windows.Forms.Label OCREngine_label;
        private System.Windows.Forms.ComboBox OCREngine_combo;
        private System.Windows.Forms.Label OCRLanguage_label;
        private System.Windows.Forms.ComboBox OCRLanguage_Combo;
        private System.Windows.Forms.CheckBox Correction_checkbox;
        private System.Windows.Forms.CheckBox Invert_checkbox;
        private System.Windows.Forms.Label AllowedChars_label;
        private System.Windows.Forms.Label DeniedChars_label;
        private System.Windows.Forms.TextBox textBoxAllowedChars;
        private System.Windows.Forms.TextBox textBoxDeniedChars;
        private System.Windows.Forms.Button Scrape;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.CheckBox ExtractInfo_Checkbox;
    }
}

