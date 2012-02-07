VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   7290
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   7290
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame3 
      Caption         =   "Write text"
      Height          =   2055
      Left            =   240
      TabIndex        =   9
      Top             =   5040
      Width           =   4095
      Begin VB.CommandButton Command2 
         Caption         =   "Write text"
         Height          =   375
         Left            =   1080
         TabIndex        =   11
         Top             =   1440
         Width           =   1935
      End
      Begin VB.TextBox txtWrite 
         Height          =   855
         Left            =   480
         TabIndex        =   10
         Text            =   "Text1"
         Top             =   360
         Width           =   3135
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Choose a writing method"
      Height          =   855
      Left            =   240
      TabIndex        =   6
      Top             =   4080
      Width           =   4095
      Begin VB.OptionButton radioAPI 
         Caption         =   "Control API method"
         Height          =   255
         Left            =   2040
         TabIndex        =   8
         Top             =   360
         Width           =   1815
      End
      Begin VB.OptionButton radioSendKeys 
         Caption         =   "Send keys method"
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   360
         Width           =   1935
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Select a control "
      Height          =   3735
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   4335
      Begin VB.TextBox txtHandle 
         Height          =   285
         Left            =   2640
         TabIndex        =   3
         Text            =   "Text1"
         Top             =   1080
         Width           =   975
      End
      Begin VB.TextBox txtID 
         Height          =   1575
         Left            =   240
         MultiLine       =   -1  'True
         TabIndex        =   2
         Text            =   "Form1.frx":0000
         Top             =   1920
         Width           =   3615
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Select a control"
         Height          =   375
         Left            =   840
         TabIndex        =   1
         Top             =   480
         Width           =   2655
      End
      Begin VB.Label Label1 
         Caption         =   "Window handle (hex):"
         Height          =   255
         Left            =   240
         TabIndex        =   5
         Top             =   1080
         Width           =   1815
      End
      Begin VB.Label Label2 
         Caption         =   "Window ID:"
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   1560
         Width           =   1575
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
        Call uiElement.InitializeFromID(txtID.Text, True)
        
        Dim method As Long
        If (radioSendKeys.Value = True) Then
            method = UIE_WriteTextMethod.UIE_WTM_SENDKEYS
        Else
            method = UIE_WriteTextMethod.UIE_WTM_NATIVE
        End If
        
        Call uiElement.WriteText(method, txtWrite.Text)
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    MsgBox Err.Number
    MsgBox Err.LastDllError
    Resume exit_sub
End Sub

Private Sub Form_Load()
    On Error GoTo error_treatment
        Set m_tCapture = New TextCaptureX
        Set m_tSelection = New TSelection
        
        radioSendKeys.Value = True
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
    
End Sub
