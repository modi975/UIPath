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
        Me.grpCaptureParams = New System.Windows.Forms.GroupBox
        Me.label11 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.button1 = New System.Windows.Forms.Button
        Me.label2 = New System.Windows.Forms.Label
        Me.txtHandle = New System.Windows.Forms.TextBox
        Me.lblHandle = New System.Windows.Forms.Label
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.txtWriteText = New System.Windows.Forms.TextBox
        Me.btnRectangle = New System.Windows.Forms.Button
        Me.groupBox5 = New System.Windows.Forms.GroupBox
        Me.radioSendKeys = New System.Windows.Forms.RadioButton
        Me.radioAPI = New System.Windows.Forms.RadioButton
        Me.grpCaptureParams.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCaptureParams
        '
        Me.grpCaptureParams.Controls.Add(Me.label11)
        Me.grpCaptureParams.Controls.Add(Me.label1)
        Me.grpCaptureParams.Controls.Add(Me.txtID)
        Me.grpCaptureParams.Controls.Add(Me.button1)
        Me.grpCaptureParams.Controls.Add(Me.label2)
        Me.grpCaptureParams.Controls.Add(Me.txtHandle)
        Me.grpCaptureParams.Controls.Add(Me.lblHandle)
        Me.grpCaptureParams.Location = New System.Drawing.Point(13, 10)
        Me.grpCaptureParams.Name = "grpCaptureParams"
        Me.grpCaptureParams.Size = New System.Drawing.Size(258, 235)
        Me.grpCaptureParams.TabIndex = 28
        Me.grpCaptureParams.TabStop = False
        Me.grpCaptureParams.Text = "Select a control"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(1, 95)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(251, 13)
        Me.label11.TabIndex = 16
        Me.label11.Text = "If control don't have hwnd its parent window is used"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 211)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(183, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "-You can manually change Control ID"
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
        Me.button1.Location = New System.Drawing.Point(30, 29)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(189, 24)
        Me.button1.TabIndex = 13
        Me.button1.Text = "Select a control"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(12, 128)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 16)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Control ID:"
        '
        'txtHandle
        '
        Me.txtHandle.Location = New System.Drawing.Point(142, 72)
        Me.txtHandle.Name = "txtHandle"
        Me.txtHandle.Size = New System.Drawing.Size(77, 20)
        Me.txtHandle.TabIndex = 1
        Me.txtHandle.Text = "0"
        Me.txtHandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblHandle
        '
        Me.lblHandle.Location = New System.Drawing.Point(12, 75)
        Me.lblHandle.Name = "lblHandle"
        Me.lblHandle.Size = New System.Drawing.Size(120, 16)
        Me.lblHandle.TabIndex = 0
        Me.lblHandle.Text = "Control hwnd"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtWriteText)
        Me.groupBox1.Controls.Add(Me.btnRectangle)
        Me.groupBox1.Location = New System.Drawing.Point(13, 347)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(258, 139)
        Me.groupBox1.TabIndex = 26
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Write text"
        '
        'txtWriteText
        '
        Me.txtWriteText.Location = New System.Drawing.Point(15, 29)
        Me.txtWriteText.Multiline = True
        Me.txtWriteText.Name = "txtWriteText"
        Me.txtWriteText.Size = New System.Drawing.Size(227, 51)
        Me.txtWriteText.TabIndex = 17
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(35, 99)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(185, 24)
        Me.btnRectangle.TabIndex = 1
        Me.btnRectangle.Text = "Write text"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.radioSendKeys)
        Me.groupBox5.Controls.Add(Me.radioAPI)
        Me.groupBox5.Location = New System.Drawing.Point(13, 262)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(258, 79)
        Me.groupBox5.TabIndex = 27
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Choose a writing method"
        '
        'radioSendKeys
        '
        Me.radioSendKeys.AutoSize = True
        Me.radioSendKeys.Location = New System.Drawing.Point(6, 23)
        Me.radioSendKeys.Name = "radioSendKeys"
        Me.radioSendKeys.Size = New System.Drawing.Size(113, 17)
        Me.radioSendKeys.TabIndex = 5
        Me.radioSendKeys.TabStop = True
        Me.radioSendKeys.Text = "Send keys method"
        Me.radioSendKeys.UseVisualStyleBackColor = True
        '
        'radioAPI
        '
        Me.radioAPI.AutoSize = True
        Me.radioAPI.Location = New System.Drawing.Point(6, 46)
        Me.radioAPI.Name = "radioAPI"
        Me.radioAPI.Size = New System.Drawing.Size(116, 17)
        Me.radioAPI.TabIndex = 5
        Me.radioAPI.TabStop = True
        Me.radioAPI.Text = "Control API method"
        Me.radioAPI.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 497)
        Me.Controls.Add(Me.grpCaptureParams)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpCaptureParams.ResumeLayout(False)
        Me.grpCaptureParams.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grpCaptureParams As System.Windows.Forms.GroupBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtID As System.Windows.Forms.TextBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtHandle As System.Windows.Forms.TextBox
    Private WithEvents lblHandle As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtWriteText As System.Windows.Forms.TextBox
    Private WithEvents btnRectangle As System.Windows.Forms.Button
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents radioSendKeys As System.Windows.Forms.RadioButton
    Private WithEvents radioAPI As System.Windows.Forms.RadioButton

End Class
