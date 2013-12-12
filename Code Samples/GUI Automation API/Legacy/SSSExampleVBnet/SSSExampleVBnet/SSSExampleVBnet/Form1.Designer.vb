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
        Me.txtFontSize = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.txtFont = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.radioNative = New System.Windows.Forms.RadioButton
        Me.radioFullText = New System.Windows.Forms.RadioButton
        Me.radioOCR = New System.Windows.Forms.RadioButton
        Me.comboLang = New System.Windows.Forms.ComboBox
        Me.checkLayout = New System.Windows.Forms.CheckBox
        Me.comboEngine = New System.Windows.Forms.ComboBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.checkIDorHWND = New System.Windows.Forms.CheckBox
        Me.btnPoint = New System.Windows.Forms.Button
        Me.btnActive = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.btnRectangle = New System.Windows.Forms.Button
        Me.grpCaptureParams = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.btnCollect = New System.Windows.Forms.Button
        Me.txtHandle = New System.Windows.Forms.TextBox
        Me.lblHandle = New System.Windows.Forms.Label
        Me.txtHeight = New System.Windows.Forms.TextBox
        Me.lblHeight = New System.Windows.Forms.Label
        Me.txtWidth = New System.Windows.Forms.TextBox
        Me.lblWidth = New System.Windows.Forms.Label
        Me.txtY = New System.Windows.Forms.TextBox
        Me.lblY = New System.Windows.Forms.Label
        Me.txtX = New System.Windows.Forms.TextBox
        Me.lblX = New System.Windows.Forms.Label
        Me.groupBox5.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.grpCaptureParams.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFontSize
        '
        Me.txtFontSize.Location = New System.Drawing.Point(213, 562)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(55, 20)
        Me.txtFontSize.TabIndex = 35
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(174, 565)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(30, 13)
        Me.label5.TabIndex = 34
        Me.label5.Text = "Size:"
        '
        'txtFont
        '
        Me.txtFont.Location = New System.Drawing.Point(52, 562)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.Size = New System.Drawing.Size(116, 20)
        Me.txtFont.TabIndex = 28
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 565)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(34, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Font: "
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(13, 590)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(72, 16)
        Me.label3.TabIndex = 33
        Me.label3.Text = "Output:"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.radioNative)
        Me.groupBox5.Controls.Add(Me.radioFullText)
        Me.groupBox5.Controls.Add(Me.radioOCR)
        Me.groupBox5.Controls.Add(Me.comboLang)
        Me.groupBox5.Controls.Add(Me.checkLayout)
        Me.groupBox5.Controls.Add(Me.comboEngine)
        Me.groupBox5.Location = New System.Drawing.Point(15, 252)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(258, 104)
        Me.groupBox5.TabIndex = 32
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Screen Scraping methods"
        '
        'radioNative
        '
        Me.radioNative.AutoSize = True
        Me.radioNative.Location = New System.Drawing.Point(6, 23)
        Me.radioNative.Name = "radioNative"
        Me.radioNative.Size = New System.Drawing.Size(94, 17)
        Me.radioNative.TabIndex = 5
        Me.radioNative.TabStop = True
        Me.radioNative.Text = "Native method"
        Me.radioNative.UseVisualStyleBackColor = True
        '
        'radioFullText
        '
        Me.radioFullText.AutoSize = True
        Me.radioFullText.Location = New System.Drawing.Point(144, 23)
        Me.radioFullText.Name = "radioFullText"
        Me.radioFullText.Size = New System.Drawing.Size(96, 17)
        Me.radioFullText.TabIndex = 5
        Me.radioFullText.TabStop = True
        Me.radioFullText.Text = "Fulltext method"
        Me.radioFullText.UseVisualStyleBackColor = True
        '
        'radioOCR
        '
        Me.radioOCR.AutoSize = True
        Me.radioOCR.Location = New System.Drawing.Point(9, 72)
        Me.radioOCR.Name = "radioOCR"
        Me.radioOCR.Size = New System.Drawing.Size(86, 17)
        Me.radioOCR.TabIndex = 5
        Me.radioOCR.TabStop = True
        Me.radioOCR.Text = "OCR method"
        Me.radioOCR.UseVisualStyleBackColor = True
        '
        'comboLang
        '
        Me.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLang.FormattingEnabled = True
        Me.comboLang.Location = New System.Drawing.Point(186, 72)
        Me.comboLang.Name = "comboLang"
        Me.comboLang.Size = New System.Drawing.Size(66, 21)
        Me.comboLang.TabIndex = 10
        '
        'checkLayout
        '
        Me.checkLayout.AutoSize = True
        Me.checkLayout.Location = New System.Drawing.Point(26, 46)
        Me.checkLayout.Name = "checkLayout"
        Me.checkLayout.Size = New System.Drawing.Size(99, 17)
        Me.checkLayout.TabIndex = 6
        Me.checkLayout.Text = "Preserve layout"
        Me.checkLayout.UseVisualStyleBackColor = True
        '
        'comboEngine
        '
        Me.comboEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEngine.FormattingEnabled = True
        Me.comboEngine.Location = New System.Drawing.Point(98, 72)
        Me.comboEngine.Name = "comboEngine"
        Me.comboEngine.Size = New System.Drawing.Size(83, 21)
        Me.comboEngine.TabIndex = 10
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(14, 609)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResult.Size = New System.Drawing.Size(258, 119)
        Me.txtResult.TabIndex = 31
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.checkIDorHWND)
        Me.groupBox1.Controls.Add(Me.btnPoint)
        Me.groupBox1.Controls.Add(Me.btnActive)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.btnRectangle)
        Me.groupBox1.Location = New System.Drawing.Point(15, 362)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(258, 189)
        Me.groupBox1.TabIndex = 30
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Region screen scraping"
        '
        'checkIDorHWND
        '
        Me.checkIDorHWND.AutoSize = True
        Me.checkIDorHWND.Location = New System.Drawing.Point(6, 32)
        Me.checkIDorHWND.Name = "checkIDorHWND"
        Me.checkIDorHWND.Size = New System.Drawing.Size(182, 17)
        Me.checkIDorHWND.TabIndex = 20
        Me.checkIDorHWND.Text = "Use the ID instead of the HWND"
        Me.checkIDorHWND.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Location = New System.Drawing.Point(36, 152)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(187, 24)
        Me.btnPoint.TabIndex = 17
        Me.btnPoint.Text = "Get word from a X,Y point"
        '
        'btnActive
        '
        Me.btnActive.Location = New System.Drawing.Point(36, 122)
        Me.btnActive.Name = "btnActive"
        Me.btnActive.Size = New System.Drawing.Size(187, 24)
        Me.btnActive.TabIndex = 19
        Me.btnActive.Text = "Get Text out of active window"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(36, 88)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(187, 24)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Get text from defined window"
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(36, 58)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(187, 24)
        Me.btnRectangle.TabIndex = 1
        Me.btnRectangle.Text = "Get text from defined region"
        '
        'grpCaptureParams
        '
        Me.grpCaptureParams.Controls.Add(Me.label1)
        Me.grpCaptureParams.Controls.Add(Me.textBox1)
        Me.grpCaptureParams.Controls.Add(Me.button1)
        Me.grpCaptureParams.Controls.Add(Me.label2)
        Me.grpCaptureParams.Controls.Add(Me.btnCollect)
        Me.grpCaptureParams.Controls.Add(Me.txtHandle)
        Me.grpCaptureParams.Controls.Add(Me.lblHandle)
        Me.grpCaptureParams.Controls.Add(Me.txtHeight)
        Me.grpCaptureParams.Controls.Add(Me.lblHeight)
        Me.grpCaptureParams.Controls.Add(Me.txtWidth)
        Me.grpCaptureParams.Controls.Add(Me.lblWidth)
        Me.grpCaptureParams.Controls.Add(Me.txtY)
        Me.grpCaptureParams.Controls.Add(Me.lblY)
        Me.grpCaptureParams.Controls.Add(Me.txtX)
        Me.grpCaptureParams.Controls.Add(Me.lblX)
        Me.grpCaptureParams.Location = New System.Drawing.Point(14, 13)
        Me.grpCaptureParams.Name = "grpCaptureParams"
        Me.grpCaptureParams.Size = New System.Drawing.Size(258, 233)
        Me.grpCaptureParams.TabIndex = 29
        Me.grpCaptureParams.TabStop = False
        Me.grpCaptureParams.Text = "What do you want to scrape"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(4, 211)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(205, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "You can manually change these attributes"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(13, 122)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(227, 54)
        Me.textBox1.TabIndex = 14
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(35, 52)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(185, 24)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Select a window or control"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 103)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 19)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Window ID:"
        '
        'btnCollect
        '
        Me.btnCollect.Location = New System.Drawing.Point(35, 21)
        Me.btnCollect.Name = "btnCollect"
        Me.btnCollect.Size = New System.Drawing.Size(185, 24)
        Me.btnCollect.TabIndex = 11
        Me.btnCollect.Text = "Select a region from the screen"
        '
        'txtHandle
        '
        Me.txtHandle.Location = New System.Drawing.Point(166, 82)
        Me.txtHandle.Name = "txtHandle"
        Me.txtHandle.Size = New System.Drawing.Size(74, 20)
        Me.txtHandle.TabIndex = 1
        Me.txtHandle.Text = "0"
        Me.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHandle
        '
        Me.lblHandle.Location = New System.Drawing.Point(12, 82)
        Me.lblHandle.Name = "lblHandle"
        Me.lblHandle.Size = New System.Drawing.Size(120, 16)
        Me.lblHandle.TabIndex = 0
        Me.lblHandle.Text = "Window handle (hexa):"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(204, 184)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(36, 20)
        Me.txtHeight.TabIndex = 10
        Me.txtHeight.Text = "0"
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHeight
        '
        Me.lblHeight.Location = New System.Drawing.Point(181, 183)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(19, 19)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "H:"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(145, 184)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(33, 20)
        Me.txtWidth.TabIndex = 8
        Me.txtWidth.Text = "0"
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWidth
        '
        Me.lblWidth.Location = New System.Drawing.Point(126, 183)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(28, 19)
        Me.lblWidth.TabIndex = 7
        Me.lblWidth.Text = "W:"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(93, 184)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(30, 20)
        Me.txtY.TabIndex = 6
        Me.txtY.Text = "0"
        Me.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblY
        '
        Me.lblY.Location = New System.Drawing.Point(74, 183)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(32, 19)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y:"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(35, 184)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(35, 20)
        Me.txtX.TabIndex = 4
        Me.txtX.Text = "0"
        Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblX
        '
        Me.lblX.Location = New System.Drawing.Point(10, 183)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(40, 19)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 748)
        Me.Controls.Add(Me.txtFontSize)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtFont)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.grpCaptureParams)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.grpCaptureParams.ResumeLayout(False)
        Me.grpCaptureParams.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtFontSize As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtFont As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents radioNative As System.Windows.Forms.RadioButton
    Private WithEvents radioFullText As System.Windows.Forms.RadioButton
    Private WithEvents radioOCR As System.Windows.Forms.RadioButton
    Private WithEvents comboLang As System.Windows.Forms.ComboBox
    Private WithEvents checkLayout As System.Windows.Forms.CheckBox
    Private WithEvents comboEngine As System.Windows.Forms.ComboBox
    Private WithEvents txtResult As System.Windows.Forms.TextBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents checkIDorHWND As System.Windows.Forms.CheckBox
    Private WithEvents btnPoint As System.Windows.Forms.Button
    Private WithEvents btnActive As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents btnRectangle As System.Windows.Forms.Button
    Private WithEvents grpCaptureParams As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents btnCollect As System.Windows.Forms.Button
    Private WithEvents txtHandle As System.Windows.Forms.TextBox
    Private WithEvents lblHandle As System.Windows.Forms.Label
    Private WithEvents txtHeight As System.Windows.Forms.TextBox
    Private WithEvents lblHeight As System.Windows.Forms.Label
    Private WithEvents txtWidth As System.Windows.Forms.TextBox
    Private WithEvents lblWidth As System.Windows.Forms.Label
    Private WithEvents txtY As System.Windows.Forms.TextBox
    Private WithEvents lblY As System.Windows.Forms.Label
    Private WithEvents txtX As System.Windows.Forms.TextBox
    Private WithEvents lblX As System.Windows.Forms.Label

End Class
