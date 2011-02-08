VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6315
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   6315
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      Caption         =   "Select a control "
      Height          =   3735
      Left            =   120
      TabIndex        =   2
      Top             =   240
      Width           =   4335
      Begin VB.CommandButton Command1 
         Caption         =   "Select a control"
         Height          =   375
         Left            =   840
         TabIndex        =   5
         Top             =   480
         Width           =   2655
      End
      Begin VB.TextBox txtID 
         Height          =   1575
         Left            =   240
         MultiLine       =   -1  'True
         TabIndex        =   4
         Text            =   "Form1.frx":0000
         Top             =   1920
         Width           =   3615
      End
      Begin VB.TextBox txtHandle 
         Height          =   285
         Left            =   2640
         TabIndex        =   3
         Text            =   "Text1"
         Top             =   1080
         Width           =   975
      End
      Begin VB.Label Label2 
         Caption         =   "Window ID:"
         Height          =   255
         Left            =   240
         TabIndex        =   7
         Top             =   1560
         Width           =   1575
      End
      Begin VB.Label Label1 
         Caption         =   "Window handle (hex):"
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   1080
         Width           =   1815
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Select a control"
      Height          =   2055
      Left            =   240
      TabIndex        =   0
      Top             =   4080
      Width           =   4095
      Begin VB.ComboBox cmbBtn 
         Height          =   315
         Left            =   2040
         TabIndex        =   9
         Text            =   "Combo2"
         Top             =   600
         Width           =   1695
      End
      Begin VB.ComboBox cmbClick 
         Height          =   315
         Left            =   240
         TabIndex        =   8
         Text            =   "Combo1"
         Top             =   600
         Width           =   1575
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Click on control"
         Height          =   375
         Left            =   1080
         TabIndex        =   1
         Top             =   1440
         Width           =   1935
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function GetWindowRect Lib "user32.dll" (ByVal hwnd As Long, lpRect As rect) As Long

Private Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)


Private m_tCapture As TextCaptureX
Private m_tSelection As TSelection

Private Sub Command1_Click()
    Dim tSelInfo As TSelectionInfo
    Dim uiElement As UIElem
    Dim strID As String
    
    On Error GoTo error_treatment
        
        Me.WindowState = vbMinimized
        
        Sleep (200)
        Set tSelInfo = m_tSelection.Start(TS_SELECTION.tsSelectionUIElement, TS_SELECTION_OPTIONS.tsSelFlagDefaultText)
        
        Me.WindowState = vbNormal
        
        strID = tSelInfo.UIElementID
        
        Set uiElement = New UIElem
        Call uiElement.InitializeFromID(strID, True)
        
        txtID.Text = strID
        txtHandle.Text = uiElement.hwnd
    
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub

Private Sub Command2_Click()
    On Error GoTo error_treatment
        Dim uiElement As UIElem
        Set uiElement = New UIElem
        uiElement.UseClientCoordinates = True
        Call uiElement.InitializeFromID(txtID.Text, False)
        
        Dim left As Long
        Dim top As Long
        Dim right As Long
        Dim bottom As Long
        
        Call uiElement.GetRectangle(left, top, right, bottom)
        
        Dim flags As Long
        flags = GetClickFlags()
        
        Call uiElement.Click(left, top, flags)
       
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    MsgBox Err.Number
    MsgBox Err.LastDllError
    Resume exit_sub
End Sub
Private Function GetClickFlags() As Long
    Dim nRes As Long
    
    nRes = UIE_ClickFlags.UIE_CF_MOVE_CURSOR
    
    If (cmbBtn.Text = "Left") Then
        nRes = nRes Or UIE_ClickFlags.UIE_CF_LEFT
    ElseIf (cmbBtn.Text = "Right") Then
        nRes = nRes Or UIE_ClickFlags.UIE_CF_LEFT
    ElseIf (cmbBtn.Text = "Middle") Then
        nRes = nRes Or UIE_ClickFlags.UIE_CF_MIDDLE
    End If
    
    If (cmbClick.Text = "Single Click") Then
        nRes = nRes Or UIE_ClickFlags.UIE_CF_SINGLE
    ElseIf (cmbClick.Text = "Double Click") Then
        nRes = nRes Or UIE_ClickFlags.UIE_CF_DOUBLE
    End If
    
    GetClickFlags = nRes
End Function

Private Sub Form_Load()
    On Error GoTo error_treatment
        Set m_tCapture = New TextCaptureX
        Set m_tSelection = New TSelection
        
        cmbClick.AddItem ("Single Click")
        cmbClick.AddItem ("Double Click")
        
        cmbClick.Text = "Click type"
        
        cmbBtn.AddItem ("Left")
        cmbBtn.AddItem ("Middle")
        cmbBtn.AddItem ("Right")
        
        cmbBtn.Text = "Mouse Button"
        
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
    
End Sub

