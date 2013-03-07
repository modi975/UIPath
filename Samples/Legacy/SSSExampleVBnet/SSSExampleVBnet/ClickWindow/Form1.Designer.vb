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
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.button2 = New System.Windows.Forms.Button
        Me.comboClick = New System.Windows.Forms.ComboBox
        Me.comboMouseBtn = New System.Windows.Forms.ComboBox
        Me.grpCaptureParams.SuspendLayout()
        Me.groupBox2.SuspendLayout()
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
        Me.grpCaptureParams.Location = New System.Drawing.Point(13, 11)
        Me.grpCaptureParams.Name = "grpCaptureParams"
        Me.grpCaptureParams.Size = New System.Drawing.Size(258, 235)
        Me.grpCaptureParams.TabIndex = 9
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
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.button2)
        Me.groupBox2.Controls.Add(Me.comboClick)
        Me.groupBox2.Controls.Add(Me.comboMouseBtn)
        Me.groupBox2.Location = New System.Drawing.Point(16, 260)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(254, 85)
        Me.groupBox2.TabIndex = 10
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Click on control"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(27, 47)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(189, 24)
        Me.button2.TabIndex = 16
        Me.button2.Text = "Click on control"
        '
        'comboClick
        '
        Me.comboClick.FormattingEnabled = True
        Me.comboClick.Items.AddRange(New Object() {"Single Click", "Double Click"})
        Me.comboClick.Location = New System.Drawing.Point(119, 19)
        Me.comboClick.Name = "comboClick"
        Me.comboClick.Size = New System.Drawing.Size(121, 21)
        Me.comboClick.TabIndex = 1
        '
        'comboMouseBtn
        '
        Me.comboMouseBtn.FormattingEnabled = True
        Me.comboMouseBtn.Items.AddRange(New Object() {"Left", "Middle", "Right"})
        Me.comboMouseBtn.Location = New System.Drawing.Point(12, 20)
        Me.comboMouseBtn.Name = "comboMouseBtn"
        Me.comboMouseBtn.Size = New System.Drawing.Size(101, 21)
        Me.comboMouseBtn.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 356)
        Me.Controls.Add(Me.grpCaptureParams)
        Me.Controls.Add(Me.groupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpCaptureParams.ResumeLayout(False)
        Me.grpCaptureParams.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
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
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents comboClick As System.Windows.Forms.ComboBox
    Private WithEvents comboMouseBtn As System.Windows.Forms.ComboBox

End Class
