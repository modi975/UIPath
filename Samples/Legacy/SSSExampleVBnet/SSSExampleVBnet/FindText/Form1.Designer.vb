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
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.label11 = New System.Windows.Forms.Label
        Me.radioNative = New System.Windows.Forms.RadioButton
        Me.radioOCR = New System.Windows.Forms.RadioButton
        Me.comboLang = New System.Windows.Forms.ComboBox
        Me.checkLayout = New System.Windows.Forms.CheckBox
        Me.comboEngine = New System.Windows.Forms.ComboBox
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.button2 = New System.Windows.Forms.Button
        Me.comboClick = New System.Windows.Forms.ComboBox
        Me.comboMouseBtn = New System.Windows.Forms.ComboBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.button3 = New System.Windows.Forms.Button
        Me.label10 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.txtFoundH = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.txtFoundW = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.txtFoundY = New System.Windows.Forms.TextBox
        Me.label7 = New System.Windows.Forms.Label
        Me.txtFoundX = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.txtOccurence = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.grpCaptureParams = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
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
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.grpCaptureParams.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.label11)
        Me.groupBox5.Controls.Add(Me.radioNative)
        Me.groupBox5.Controls.Add(Me.radioOCR)
        Me.groupBox5.Controls.Add(Me.comboLang)
        Me.groupBox5.Controls.Add(Me.checkLayout)
        Me.groupBox5.Controls.Add(Me.comboEngine)
        Me.groupBox5.Location = New System.Drawing.Point(13, 301)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(258, 132)
        Me.groupBox5.TabIndex = 22
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Choose a screen Scraping method"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(6, 107)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(199, 13)
        Me.label11.TabIndex = 16
        Me.label11.Text = "-FullText cannot retreive text coordinates"
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
        'radioOCR
        '
        Me.radioOCR.AutoSize = True
        Me.radioOCR.Location = New System.Drawing.Point(6, 74)
        Me.radioOCR.Name = "radioOCR"
        Me.radioOCR.Size = New System.Drawing.Size(86, 17)
        Me.radioOCR.TabIndex = 5
        Me.radioOCR.TabStop = True
        Me.radioOCR.Text = "OCR method"
        Me.radioOCR.UseVisualStyleBackColor = True
        '
        'comboLang
        '
        Me.comboLang.FormattingEnabled = True
        Me.comboLang.Items.AddRange(New Object() {"eng", "deu", "ita", "fra", "nld", "spa"})
        Me.comboLang.Location = New System.Drawing.Point(184, 74)
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
        Me.comboEngine.FormattingEnabled = True
        Me.comboEngine.Items.AddRange(New Object() {"Tesseract OCR"})
        Me.comboEngine.Location = New System.Drawing.Point(95, 74)
        Me.comboEngine.Name = "comboEngine"
        Me.comboEngine.Size = New System.Drawing.Size(83, 21)
        Me.comboEngine.TabIndex = 10
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Controls.Add(Me.comboClick)
        Me.groupBox2.Controls.Add(Me.comboMouseBtn)
        Me.groupBox2.Location = New System.Drawing.Point(16, 664)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(254, 85)
        Me.groupBox2.TabIndex = 21
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Click on found text"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(27, 47)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(189, 24)
        Me.button2.TabIndex = 16
        Me.button2.Text = "Click on text"
        '
        'comboClick
        '
        Me.comboClick.FormattingEnabled = True
        Me.comboClick.Items.AddRange(New Object() {"Single Click", "Double Click"})
        Me.comboClick.Location = New System.Drawing.Point(118, 19)
        Me.comboClick.Name = "comboClick"
        Me.comboClick.Size = New System.Drawing.Size(121, 21)
        Me.comboClick.TabIndex = 1
        '
        'comboMouseBtn
        '
        Me.comboMouseBtn.FormattingEnabled = True
        Me.comboMouseBtn.Items.AddRange(New Object() {"Left", "Middle", "Right"})
        Me.comboMouseBtn.Location = New System.Drawing.Point(11, 19)
        Me.comboMouseBtn.Name = "comboMouseBtn"
        Me.comboMouseBtn.Size = New System.Drawing.Size(101, 21)
        Me.comboMouseBtn.TabIndex = 0
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.label10)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.txtFoundH)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtFoundW)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.txtFoundY)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txtFoundX)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.txtOccurence)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtSearch)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Location = New System.Drawing.Point(14, 464)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(257, 194)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Find text"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(29, 83)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(189, 24)
        Me.button3.TabIndex = 17
        Me.button3.Text = "Search text"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(15, 172)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(190, 13)
        Me.label10.TabIndex = 20
        Me.label10.Text = "-Coordinates are relative to the window"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(17, 117)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(222, 16)
        Me.label9.TabIndex = 19
        Me.label9.Text = "Text was found at this location:"
        '
        'txtFoundH
        '
        Me.txtFoundH.Location = New System.Drawing.Point(205, 138)
        Me.txtFoundH.Name = "txtFoundH"
        Me.txtFoundH.Size = New System.Drawing.Size(34, 20)
        Me.txtFoundH.TabIndex = 18
        Me.txtFoundH.Text = "0"
        Me.txtFoundH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(186, 142)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(26, 16)
        Me.label5.TabIndex = 17
        Me.label5.Text = "H:"
        '
        'txtFoundW
        '
        Me.txtFoundW.Location = New System.Drawing.Point(148, 138)
        Me.txtFoundW.Name = "txtFoundW"
        Me.txtFoundW.Size = New System.Drawing.Size(37, 20)
        Me.txtFoundW.TabIndex = 16
        Me.txtFoundW.Text = "0"
        Me.txtFoundW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(125, 142)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(26, 16)
        Me.label6.TabIndex = 15
        Me.label6.Text = "W:"
        '
        'txtFoundY
        '
        Me.txtFoundY.Location = New System.Drawing.Point(89, 138)
        Me.txtFoundY.Name = "txtFoundY"
        Me.txtFoundY.Size = New System.Drawing.Size(35, 20)
        Me.txtFoundY.TabIndex = 14
        Me.txtFoundY.Text = "0"
        Me.txtFoundY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(71, 142)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(26, 16)
        Me.label7.TabIndex = 13
        Me.label7.Text = "Y:"
        '
        'txtFoundX
        '
        Me.txtFoundX.Location = New System.Drawing.Point(29, 138)
        Me.txtFoundX.Name = "txtFoundX"
        Me.txtFoundX.Size = New System.Drawing.Size(39, 20)
        Me.txtFoundX.TabIndex = 12
        Me.txtFoundX.Text = "0"
        Me.txtFoundX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(11, 142)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(26, 16)
        Me.label8.TabIndex = 11
        Me.label8.Text = "X:"
        '
        'txtOccurence
        '
        Me.txtOccurence.Location = New System.Drawing.Point(162, 57)
        Me.txtOccurence.Name = "txtOccurence"
        Me.txtOccurence.Size = New System.Drawing.Size(77, 20)
        Me.txtOccurence.TabIndex = 4
        Me.txtOccurence.Text = "0"
        Me.txtOccurence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(17, 60)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(76, 16)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Occurence;"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(20, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 20)
        Me.txtSearch.TabIndex = 2
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(17, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(222, 16)
        Me.label3.TabIndex = 1
        Me.label3.Text = "What text do you want to find?"
        '
        'grpCaptureParams
        '
        Me.grpCaptureParams.Controls.Add(Me.label1)
        Me.grpCaptureParams.Controls.Add(Me.txtID)
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
        Me.grpCaptureParams.Location = New System.Drawing.Point(13, 28)
        Me.grpCaptureParams.Name = "grpCaptureParams"
        Me.grpCaptureParams.Size = New System.Drawing.Size(258, 258)
        Me.grpCaptureParams.TabIndex = 19
        Me.grpCaptureParams.TabStop = False
        Me.grpCaptureParams.Text = "Where is the text located?"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(18, 239)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(208, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "-You can manually change these attributes"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(15, 147)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(227, 51)
        Me.txtID.TabIndex = 14
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(35, 66)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(189, 24)
        Me.button1.TabIndex = 13
        Me.button1.Text = "INSIDE a window or control"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Window ID:"
        '
        'btnCollect
        '
        Me.btnCollect.Location = New System.Drawing.Point(35, 30)
        Me.btnCollect.Name = "btnCollect"
        Me.btnCollect.Size = New System.Drawing.Size(189, 24)
        Me.btnCollect.TabIndex = 11
        Me.btnCollect.Text = "INSIDE a region on the screen"
        '
        'txtHandle
        '
        Me.txtHandle.Location = New System.Drawing.Point(163, 108)
        Me.txtHandle.Name = "txtHandle"
        Me.txtHandle.Size = New System.Drawing.Size(77, 20)
        Me.txtHandle.TabIndex = 1
        Me.txtHandle.Text = "0"
        Me.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHandle
        '
        Me.lblHandle.Location = New System.Drawing.Point(12, 108)
        Me.lblHandle.Name = "lblHandle"
        Me.lblHandle.Size = New System.Drawing.Size(120, 16)
        Me.lblHandle.TabIndex = 0
        Me.lblHandle.Text = "Window handle (hexa):"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(206, 202)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(34, 20)
        Me.txtHeight.TabIndex = 10
        Me.txtHeight.Text = "0"
        Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHeight
        '
        Me.lblHeight.Location = New System.Drawing.Point(187, 204)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(20, 16)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "H:"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(149, 202)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(37, 20)
        Me.txtWidth.TabIndex = 8
        Me.txtWidth.Text = "0"
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWidth
        '
        Me.lblWidth.Location = New System.Drawing.Point(126, 204)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(26, 16)
        Me.lblWidth.TabIndex = 7
        Me.lblWidth.Text = "W:"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(90, 202)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(35, 20)
        Me.txtY.TabIndex = 6
        Me.txtY.Text = "0"
        Me.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblY
        '
        Me.lblY.Location = New System.Drawing.Point(72, 204)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(22, 16)
        Me.lblY.TabIndex = 5
        Me.lblY.Text = "Y:"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(30, 202)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(39, 20)
        Me.txtX.TabIndex = 4
        Me.txtX.Text = "0"
        Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblX
        '
        Me.lblX.Location = New System.Drawing.Point(12, 204)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(40, 16)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 758)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.grpCaptureParams)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.grpCaptureParams.ResumeLayout(False)
        Me.grpCaptureParams.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents radioNative As System.Windows.Forms.RadioButton
    Private WithEvents radioOCR As System.Windows.Forms.RadioButton
    Private WithEvents comboLang As System.Windows.Forms.ComboBox
    Private WithEvents checkLayout As System.Windows.Forms.CheckBox
    Private WithEvents comboEngine As System.Windows.Forms.ComboBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents comboClick As System.Windows.Forms.ComboBox
    Private WithEvents comboMouseBtn As System.Windows.Forms.ComboBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents txtFoundH As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtFoundW As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtFoundY As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtFoundX As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txtOccurence As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtSearch As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents grpCaptureParams As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtID As System.Windows.Forms.TextBox
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
