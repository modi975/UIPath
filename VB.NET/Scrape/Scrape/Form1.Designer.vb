<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExtractInfo_Checkbox = New System.Windows.Forms.CheckBox()
        Me.textBoxOutput = New System.Windows.Forms.TextBox()
        Me.Scrape = New System.Windows.Forms.Button()
        Me.textBoxDeniedChars = New System.Windows.Forms.TextBox()
        Me.textBoxAllowedChars = New System.Windows.Forms.TextBox()
        Me.DeniedChars_label = New System.Windows.Forms.Label()
        Me.AllowedChars_label = New System.Windows.Forms.Label()
        Me.Invert_checkbox = New System.Windows.Forms.CheckBox()
        Me.Correction_checkbox = New System.Windows.Forms.CheckBox()
        Me.OCRLanguage_Combo = New System.Windows.Forms.ComboBox()
        Me.OCRLanguage_label = New System.Windows.Forms.Label()
        Me.OCREngine_combo = New System.Windows.Forms.ComboBox()
        Me.OCREngine_label = New System.Windows.Forms.Label()
        Me.IgnoreHidden_Checkbox = New System.Windows.Forms.CheckBox()
        Me.FormattedText_Checkbox = New System.Windows.Forms.CheckBox()
        Me.GetFont_Checkbox = New System.Windows.Forms.CheckBox()
        Me.ScrapeMethod_Combo = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnActiveWindow = New System.Windows.Forms.Button()
        Me.Select_Region = New System.Windows.Forms.Button()
        Me.textSelector = New System.Windows.Forms.TextBox()
        Me.Select_UIObject = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExtractInfo_Checkbox
        '
        Me.ExtractInfo_Checkbox.AutoSize = True
        Me.ExtractInfo_Checkbox.Location = New System.Drawing.Point(19, 213)
        Me.ExtractInfo_Checkbox.Name = "ExtractInfo_Checkbox"
        Me.ExtractInfo_Checkbox.Size = New System.Drawing.Size(79, 17)
        Me.ExtractInfo_Checkbox.TabIndex = 44
        Me.ExtractInfo_Checkbox.Text = "Extract info"
        Me.ExtractInfo_Checkbox.UseVisualStyleBackColor = True
        '
        'textBoxOutput
        '
        Me.textBoxOutput.Location = New System.Drawing.Point(17, 446)
        Me.textBoxOutput.Multiline = True
        Me.textBoxOutput.Name = "textBoxOutput"
        Me.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxOutput.Size = New System.Drawing.Size(512, 155)
        Me.textBoxOutput.TabIndex = 43
        '
        'Scrape
        '
        Me.Scrape.Location = New System.Drawing.Point(372, 174)
        Me.Scrape.Name = "Scrape"
        Me.Scrape.Size = New System.Drawing.Size(75, 23)
        Me.Scrape.TabIndex = 42
        Me.Scrape.Text = "Scrape"
        Me.Scrape.UseVisualStyleBackColor = True
        '
        'textBoxDeniedChars
        '
        Me.textBoxDeniedChars.Location = New System.Drawing.Point(117, 380)
        Me.textBoxDeniedChars.Name = "textBoxDeniedChars"
        Me.textBoxDeniedChars.Size = New System.Drawing.Size(158, 20)
        Me.textBoxDeniedChars.TabIndex = 41
        Me.textBoxDeniedChars.Visible = False
        '
        'textBoxAllowedChars
        '
        Me.textBoxAllowedChars.Location = New System.Drawing.Point(117, 353)
        Me.textBoxAllowedChars.Name = "textBoxAllowedChars"
        Me.textBoxAllowedChars.Size = New System.Drawing.Size(158, 20)
        Me.textBoxAllowedChars.TabIndex = 40
        Me.textBoxAllowedChars.Visible = False
        '
        'DeniedChars_label
        '
        Me.DeniedChars_label.AutoSize = True
        Me.DeniedChars_label.Location = New System.Drawing.Point(16, 380)
        Me.DeniedChars_label.Name = "DeniedChars_label"
        Me.DeniedChars_label.Size = New System.Drawing.Size(94, 13)
        Me.DeniedChars_label.TabIndex = 39
        Me.DeniedChars_label.Text = "Denied characters"
        Me.DeniedChars_label.Visible = False
        '
        'AllowedChars_label
        '
        Me.AllowedChars_label.AutoSize = True
        Me.AllowedChars_label.Location = New System.Drawing.Point(16, 356)
        Me.AllowedChars_label.Name = "AllowedChars_label"
        Me.AllowedChars_label.Size = New System.Drawing.Size(97, 13)
        Me.AllowedChars_label.TabIndex = 38
        Me.AllowedChars_label.Text = "Allowed characters"
        Me.AllowedChars_label.Visible = False
        '
        'Invert_checkbox
        '
        Me.Invert_checkbox.AutoSize = True
        Me.Invert_checkbox.Location = New System.Drawing.Point(19, 327)
        Me.Invert_checkbox.Name = "Invert_checkbox"
        Me.Invert_checkbox.Size = New System.Drawing.Size(53, 17)
        Me.Invert_checkbox.TabIndex = 37
        Me.Invert_checkbox.Text = "Invert"
        Me.Invert_checkbox.UseVisualStyleBackColor = True
        Me.Invert_checkbox.Visible = False
        '
        'Correction_checkbox
        '
        Me.Correction_checkbox.AutoSize = True
        Me.Correction_checkbox.Location = New System.Drawing.Point(19, 304)
        Me.Correction_checkbox.Name = "Correction_checkbox"
        Me.Correction_checkbox.Size = New System.Drawing.Size(74, 17)
        Me.Correction_checkbox.TabIndex = 36
        Me.Correction_checkbox.Text = "Correction"
        Me.Correction_checkbox.UseVisualStyleBackColor = True
        Me.Correction_checkbox.Visible = False
        '
        'OCRLanguage_Combo
        '
        Me.OCRLanguage_Combo.FormattingEnabled = True
        Me.OCRLanguage_Combo.Location = New System.Drawing.Point(102, 275)
        Me.OCRLanguage_Combo.Name = "OCRLanguage_Combo"
        Me.OCRLanguage_Combo.Size = New System.Drawing.Size(121, 21)
        Me.OCRLanguage_Combo.TabIndex = 35
        Me.OCRLanguage_Combo.Visible = False
        '
        'OCRLanguage_label
        '
        Me.OCRLanguage_label.AutoSize = True
        Me.OCRLanguage_label.Location = New System.Drawing.Point(15, 278)
        Me.OCRLanguage_label.Name = "OCRLanguage_label"
        Me.OCRLanguage_label.Size = New System.Drawing.Size(81, 13)
        Me.OCRLanguage_label.TabIndex = 34
        Me.OCRLanguage_label.Text = "OCR Language"
        Me.OCRLanguage_label.Visible = False
        '
        'OCREngine_combo
        '
        Me.OCREngine_combo.FormattingEnabled = True
        Me.OCREngine_combo.Items.AddRange(New Object() {"UI_OCR_TESSERACT", "UI_OCR_MODI"})
        Me.OCREngine_combo.Location = New System.Drawing.Point(102, 243)
        Me.OCREngine_combo.Name = "OCREngine_combo"
        Me.OCREngine_combo.Size = New System.Drawing.Size(121, 21)
        Me.OCREngine_combo.TabIndex = 33
        Me.OCREngine_combo.Visible = False
        '
        'OCREngine_label
        '
        Me.OCREngine_label.AutoSize = True
        Me.OCREngine_label.Location = New System.Drawing.Point(17, 246)
        Me.OCREngine_label.Name = "OCREngine_label"
        Me.OCREngine_label.Size = New System.Drawing.Size(66, 13)
        Me.OCREngine_label.TabIndex = 32
        Me.OCREngine_label.Text = "OCR Engine"
        Me.OCREngine_label.Visible = False
        '
        'IgnoreHidden_Checkbox
        '
        Me.IgnoreHidden_Checkbox.AutoSize = True
        Me.IgnoreHidden_Checkbox.Location = New System.Drawing.Point(19, 247)
        Me.IgnoreHidden_Checkbox.Name = "IgnoreHidden_Checkbox"
        Me.IgnoreHidden_Checkbox.Size = New System.Drawing.Size(91, 17)
        Me.IgnoreHidden_Checkbox.TabIndex = 31
        Me.IgnoreHidden_Checkbox.Text = "Ignore hidden"
        Me.IgnoreHidden_Checkbox.UseVisualStyleBackColor = True
        Me.IgnoreHidden_Checkbox.Visible = False
        '
        'FormattedText_Checkbox
        '
        Me.FormattedText_Checkbox.AutoSize = True
        Me.FormattedText_Checkbox.Location = New System.Drawing.Point(88, 247)
        Me.FormattedText_Checkbox.Name = "FormattedText_Checkbox"
        Me.FormattedText_Checkbox.Size = New System.Drawing.Size(93, 17)
        Me.FormattedText_Checkbox.TabIndex = 30
        Me.FormattedText_Checkbox.Text = "Formatted text"
        Me.FormattedText_Checkbox.UseVisualStyleBackColor = True
        Me.FormattedText_Checkbox.Visible = False
        '
        'GetFont_Checkbox
        '
        Me.GetFont_Checkbox.AutoSize = True
        Me.GetFont_Checkbox.Location = New System.Drawing.Point(19, 247)
        Me.GetFont_Checkbox.Name = "GetFont_Checkbox"
        Me.GetFont_Checkbox.Size = New System.Drawing.Size(64, 17)
        Me.GetFont_Checkbox.TabIndex = 29
        Me.GetFont_Checkbox.Text = "Get font"
        Me.GetFont_Checkbox.UseVisualStyleBackColor = True
        Me.GetFont_Checkbox.Visible = False
        '
        'ScrapeMethod_Combo
        '
        Me.ScrapeMethod_Combo.FormattingEnabled = True
        Me.ScrapeMethod_Combo.Items.AddRange(New Object() {"UI_AUTOMATIC", "UI_NATIVE", "UI_FULLTEXT", "UI_OCR"})
        Me.ScrapeMethod_Combo.Location = New System.Drawing.Point(102, 181)
        Me.ScrapeMethod_Combo.Name = "ScrapeMethod_Combo"
        Me.ScrapeMethod_Combo.Size = New System.Drawing.Size(121, 21)
        Me.ScrapeMethod_Combo.TabIndex = 28
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 184)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 27
        Me.label1.Text = "Scrape method"
        '
        'btnActiveWindow
        '
        Me.btnActiveWindow.Location = New System.Drawing.Point(372, 132)
        Me.btnActiveWindow.Name = "btnActiveWindow"
        Me.btnActiveWindow.Size = New System.Drawing.Size(150, 23)
        Me.btnActiveWindow.TabIndex = 26
        Me.btnActiveWindow.Text = "Get active window"
        Me.btnActiveWindow.UseVisualStyleBackColor = True
        '
        'Select_Region
        '
        Me.Select_Region.Location = New System.Drawing.Point(200, 132)
        Me.Select_Region.Name = "Select_Region"
        Me.Select_Region.Size = New System.Drawing.Size(132, 23)
        Me.Select_Region.TabIndex = 25
        Me.Select_Region.Text = "Select a region"
        Me.Select_Region.UseVisualStyleBackColor = True
        '
        'textSelector
        '
        Me.textSelector.Location = New System.Drawing.Point(12, 12)
        Me.textSelector.Multiline = True
        Me.textSelector.Name = "textSelector"
        Me.textSelector.Size = New System.Drawing.Size(510, 113)
        Me.textSelector.TabIndex = 24
        '
        'Select_UIObject
        '
        Me.Select_UIObject.Location = New System.Drawing.Point(12, 132)
        Me.Select_UIObject.Name = "Select_UIObject"
        Me.Select_UIObject.Size = New System.Drawing.Size(147, 23)
        Me.Select_UIObject.TabIndex = 23
        Me.Select_UIObject.Text = "Select a UI object"
        Me.Select_UIObject.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 504)
        Me.Controls.Add(Me.ExtractInfo_Checkbox)
        Me.Controls.Add(Me.textBoxOutput)
        Me.Controls.Add(Me.Scrape)
        Me.Controls.Add(Me.textBoxDeniedChars)
        Me.Controls.Add(Me.textBoxAllowedChars)
        Me.Controls.Add(Me.DeniedChars_label)
        Me.Controls.Add(Me.AllowedChars_label)
        Me.Controls.Add(Me.Invert_checkbox)
        Me.Controls.Add(Me.Correction_checkbox)
        Me.Controls.Add(Me.OCRLanguage_Combo)
        Me.Controls.Add(Me.OCRLanguage_label)
        Me.Controls.Add(Me.OCREngine_combo)
        Me.Controls.Add(Me.OCREngine_label)
        Me.Controls.Add(Me.IgnoreHidden_Checkbox)
        Me.Controls.Add(Me.FormattedText_Checkbox)
        Me.Controls.Add(Me.GetFont_Checkbox)
        Me.Controls.Add(Me.ScrapeMethod_Combo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnActiveWindow)
        Me.Controls.Add(Me.Select_Region)
        Me.Controls.Add(Me.textSelector)
        Me.Controls.Add(Me.Select_UIObject)
        Me.Name = "Form1"
        Me.Text = "Scrape"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ExtractInfo_Checkbox As System.Windows.Forms.CheckBox
    Private WithEvents textBoxOutput As System.Windows.Forms.TextBox
    Private WithEvents Scrape As System.Windows.Forms.Button
    Private WithEvents textBoxDeniedChars As System.Windows.Forms.TextBox
    Private WithEvents textBoxAllowedChars As System.Windows.Forms.TextBox
    Private WithEvents DeniedChars_label As System.Windows.Forms.Label
    Private WithEvents AllowedChars_label As System.Windows.Forms.Label
    Private WithEvents Invert_checkbox As System.Windows.Forms.CheckBox
    Private WithEvents Correction_checkbox As System.Windows.Forms.CheckBox
    Private WithEvents OCRLanguage_Combo As System.Windows.Forms.ComboBox
    Private WithEvents OCRLanguage_label As System.Windows.Forms.Label
    Private WithEvents OCREngine_combo As System.Windows.Forms.ComboBox
    Private WithEvents OCREngine_label As System.Windows.Forms.Label
    Private WithEvents IgnoreHidden_Checkbox As System.Windows.Forms.CheckBox
    Private WithEvents FormattedText_Checkbox As System.Windows.Forms.CheckBox
    Private WithEvents GetFont_Checkbox As System.Windows.Forms.CheckBox
    Private WithEvents ScrapeMethod_Combo As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnActiveWindow As System.Windows.Forms.Button
    Private WithEvents Select_Region As System.Windows.Forms.Button
    Private WithEvents textSelector As System.Windows.Forms.TextBox
    Private WithEvents Select_UIObject As System.Windows.Forms.Button

End Class
