VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   10950
   ClientLeft      =   225
   ClientTop       =   555
   ClientWidth     =   4560
   LinkTopic       =   "Form1"
   ScaleHeight     =   10950
   ScaleWidth      =   4560
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame4 
      Caption         =   "Click on found text "
      Height          =   2055
      Left            =   240
      TabIndex        =   24
      Top             =   9840
      Width           =   3975
      Begin VB.CommandButton Command2 
         Caption         =   "Click on text"
         Height          =   375
         Left            =   1080
         TabIndex        =   27
         Top             =   1440
         Width           =   1935
      End
      Begin VB.ComboBox cmbClick 
         Height          =   315
         Left            =   240
         TabIndex        =   26
         Text            =   "Combo1"
         Top             =   600
         Width           =   1575
      End
      Begin VB.ComboBox cmbBtn 
         Height          =   315
         Left            =   2040
         TabIndex        =   25
         Text            =   "Combo2"
         Top             =   600
         Width           =   1695
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Where is the text located? "
      Height          =   4575
      Left            =   240
      TabIndex        =   7
      Top             =   120
      Width           =   3975
      Begin VB.CommandButton regionBtn 
         Caption         =   "INSIDE a region from the screen"
         Height          =   375
         Left            =   480
         TabIndex        =   15
         Top             =   360
         Width           =   3015
      End
      Begin VB.CommandButton windowBtn 
         Caption         =   "INSIDE a window or control"
         Height          =   375
         Left            =   480
         TabIndex        =   14
         Top             =   840
         Width           =   3015
      End
      Begin VB.TextBox txtHandle 
         Height          =   285
         Left            =   2520
         TabIndex        =   13
         Text            =   "Text1"
         Top             =   1440
         Width           =   975
      End
      Begin VB.TextBox txtID 
         Height          =   1575
         Left            =   120
         MultiLine       =   -1  'True
         TabIndex        =   12
         Text            =   "Form1.frx":0000
         Top             =   2280
         Width           =   3615
      End
      Begin VB.TextBox txtX 
         Height          =   285
         Left            =   480
         TabIndex        =   11
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtY 
         Height          =   285
         Left            =   1320
         TabIndex        =   10
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtW 
         Height          =   285
         Left            =   2280
         TabIndex        =   9
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtH 
         Height          =   285
         Left            =   3360
         TabIndex        =   8
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.Label Label1 
         Caption         =   "Window handle (hex):"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   1440
         Width           =   1815
      End
      Begin VB.Label Label2 
         Caption         =   "Window ID:"
         Height          =   255
         Left            =   120
         TabIndex        =   20
         Top             =   1920
         Width           =   1575
      End
      Begin VB.Label Label3 
         Caption         =   "X:"
         Height          =   255
         Left            =   240
         TabIndex        =   19
         Top             =   4080
         Width           =   375
      End
      Begin VB.Label Label6 
         Caption         =   "Y:"
         Height          =   255
         Left            =   1080
         TabIndex        =   18
         Top             =   4080
         Width           =   375
      End
      Begin VB.Label Label7 
         Caption         =   "Width:"
         Height          =   255
         Left            =   1800
         TabIndex        =   17
         Top             =   4080
         Width           =   495
      End
      Begin VB.Label Label8 
         Caption         =   "Height:"
         Height          =   255
         Left            =   2760
         TabIndex        =   16
         Top             =   4080
         Width           =   495
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Screen Scraping Methods "
      Height          =   1695
      Left            =   240
      TabIndex        =   1
      Top             =   4920
      Width           =   3975
      Begin VB.OptionButton nativeRadio 
         Caption         =   "Native method"
         Height          =   255
         Left            =   240
         TabIndex        =   6
         Top             =   360
         Width           =   1695
      End
      Begin VB.CheckBox layoutCheck 
         Caption         =   "Preserve Layout"
         Height          =   255
         Left            =   720
         TabIndex        =   5
         Top             =   600
         Width           =   1695
      End
      Begin VB.OptionButton ocrRadio 
         Caption         =   "OCR method"
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   1200
         Width           =   1215
      End
      Begin VB.ComboBox cmbEngine 
         Height          =   315
         ItemData        =   "Form1.frx":0006
         Left            =   1680
         List            =   "Form1.frx":0008
         TabIndex        =   3
         Text            =   "Combo1"
         Top             =   1200
         Width           =   975
      End
      Begin VB.ComboBox cmbLang 
         Height          =   315
         ItemData        =   "Form1.frx":000A
         Left            =   2880
         List            =   "Form1.frx":000C
         TabIndex        =   2
         Text            =   "Combo2"
         Top             =   1200
         Width           =   975
      End
   End
   Begin VB.Frame Frame3 
      Caption         =   "Find text "
      Height          =   3015
      Left            =   240
      TabIndex        =   0
      Top             =   6720
      Width           =   3975
      Begin VB.TextBox txtX2 
         Height          =   285
         Left            =   360
         TabIndex        =   36
         Text            =   "Text1"
         Top             =   2520
         Width           =   495
      End
      Begin VB.TextBox txtY2 
         Height          =   285
         Left            =   1200
         TabIndex        =   35
         Text            =   "Text1"
         Top             =   2520
         Width           =   495
      End
      Begin VB.TextBox txtW2 
         Height          =   285
         Left            =   2160
         TabIndex        =   34
         Text            =   "Text1"
         Top             =   2520
         Width           =   495
      End
      Begin VB.TextBox txtH2 
         Height          =   285
         Left            =   3240
         TabIndex        =   33
         Text            =   "Text1"
         Top             =   2520
         Width           =   495
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Search text"
         Height          =   375
         Left            =   360
         TabIndex        =   32
         Top             =   1560
         Width           =   3255
      End
      Begin VB.TextBox txtOccurence 
         Height          =   285
         Left            =   2400
         TabIndex        =   31
         Text            =   "Text1"
         Top             =   1200
         Width           =   1215
      End
      Begin VB.TextBox txtFind 
         Height          =   285
         Left            =   360
         TabIndex        =   29
         Text            =   "Text1"
         Top             =   720
         Width           =   3255
      End
      Begin VB.Label Label15 
         Caption         =   "Text was found at this location:"
         Height          =   255
         Left            =   360
         TabIndex        =   41
         Top             =   2160
         Width           =   3255
      End
      Begin VB.Label Label14 
         Caption         =   "X:"
         Height          =   255
         Left            =   120
         TabIndex        =   40
         Top             =   2520
         Width           =   375
      End
      Begin VB.Label Label13 
         Caption         =   "Y:"
         Height          =   255
         Left            =   960
         TabIndex        =   39
         Top             =   2520
         Width           =   375
      End
      Begin VB.Label Label12 
         Caption         =   "Width:"
         Height          =   255
         Left            =   1680
         TabIndex        =   38
         Top             =   2520
         Width           =   495
      End
      Begin VB.Label Label11 
         Caption         =   "Height:"
         Height          =   255
         Left            =   2640
         TabIndex        =   37
         Top             =   2520
         Width           =   495
      End
      Begin VB.Label Label10 
         Caption         =   "Occurrence: "
         Height          =   255
         Left            =   360
         TabIndex        =   30
         Top             =   1200
         Width           =   1335
      End
      Begin VB.Label Label9 
         Caption         =   "What text do you want to find?"
         Height          =   255
         Left            =   360
         TabIndex        =   28
         Top             =   360
         Width           =   3015
      End
   End
   Begin VB.Label Label4 
      Caption         =   "X:"
      Height          =   255
      Left            =   1440
      TabIndex        =   23
      Top             =   4320
      Width           =   375
   End
   Begin VB.Label Label5 
      Caption         =   "Y:"
      Height          =   255
      Left            =   1200
      TabIndex        =   22
      Top             =   4320
      Width           =   375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)
Private m_tCapture As TextCaptureX
Private m_tSelection As TSelection
Private m_tOCR As GetOCRText
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

Private Sub Command1_Click()
    On Error GoTo error_treatment
        Dim x As Long
        Dim y As Long
        Dim width As Long
        Dim height As Long
        Dim occurrence As Long
        
        x = txtX.Text
        y = txtY.Text
        width = txtW.Text
        height = txtH.Text
        occurrence = txtOccurence.Text
        
        Dim rectangle As rect
        Set rectangle = New rect
        
        rectangle.RLeft = x
        rectangle.RRight = x + width
        rectangle.RTop = y
        rectangle.RBottom = y + height
        
        m_tCapture.UseClientCoordinates = True
        
        Dim hwnd As Long
        hwnd = txtHandle.Text
        Dim strFind As String
        strFind = txtFind.Text
        
        Dim foundRect As rect
        If (nativeRadio.Value = True) Then
            Set foundRect = m_tCapture.GetRectFromText(hwnd, strFind, rectangle, occurrence)
        ElseIf (ocrRadio.Value = True) Then
            Dim strLang As String
            strLang = cmbLang.Text
            Set foundRect = m_tOCR.GetRectFromText(hwnd, strFind, rectangle, strLang, False, occurrence)
        End If
        
        txtX2.Text = foundRect.RLeft
        txtY2.Text = foundRect.RTop
        txtW2.Text = foundRect.width
        txtH2.Text = foundRect.height
        
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
        
        Dim left As Long
        Dim top As Long
               
        left = txtX2.Text
        top = txtY2.Text
        
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

Private Sub Form_Load()
     On Error GoTo error_treatment
        Set m_tCapture = New TextCaptureX
        Set m_tSelection = New TSelection
        Set m_tOCR = New GetOCRText
        
        nativeRadio.Value = vbChecked
        layoutCheck.Value = vbChecked
        
        cmbEngine.AddItem ("Tesseract")
        cmbEngine.Text = "Engine"
        
        cmbLang.AddItem ("eng")
        cmbLang.AddItem ("fra")
        cmbLang.AddItem ("spa")
        cmbLang.AddItem ("deu")
        cmbLang.Text = "Language"
        
        cmbClick.AddItem ("Single Click")
        cmbClick.AddItem ("Double Click")
        
        cmbClick.Text = "Click type"
        
        cmbBtn.AddItem ("Left")
        cmbBtn.AddItem ("Middle")
        cmbBtn.AddItem ("Right")
        
        cmbBtn.Text = "Mouse Button"
        
        txtFind.Text = ""
        txtOccurence.Text = "0"
        txtX2.Text = "0"
        txtY2.Text = "0"
        txtH2.Text = "0"
        txtW2.Text = "0"
        
        
        
        
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub

Private Sub regionBtn_Click()
    Dim tSelInfo As TSelectionInfo
    Dim uiElement As UIElem
    Dim strID As String
    Dim x1, y1, x2, y2, height, width As Long
    
    On Error GoTo error_treatment
        Set tSelInfo = m_tSelection.Start(TS_SELECTION.tsSelectionRectangle, TS_SELECTION_OPTIONS.tsSelFlagDefaultText)
        Set uiElement = New UIElem
        
        uiElement.hwnd = tSelInfo.WindowHandle
        strID = uiElement.GetID(True)
        
        Dim points As Variant
        
        points = tSelInfo.points
        Dim pointInfo1, pointInfo2 As Long
        pointInfo1 = points(0)
        pointInfo2 = points(1)
        
        x1 = GetX(pointInfo1)
        y1 = GetY(pointInfo1)
        
        x2 = GetX(pointInfo2)
        y2 = GetY(pointInfo2)
        
        If (x1 < x2) Then
            width = x2 - x1
        Else
            width = x1 - x2
            x1 = x2
        End If
        
        If y1 < y2 Then
            height = y2 - y1
        Else
            height = y1 - y2
            y1 = y2
        End If
        
        Dim left As Long, top As Long, right As Long, bottom As Long
        
        Call uiElement.GetRectangle(left, top, right, bottom)
        
        txtX.Text = x1 - left
        txtY.Text = y1 - top
        txtH.Text = height
        txtW.Text = width
        txtID.Text = strID
        txtHandle.Text = uiElement.hwnd
    
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub

Private Sub windowBtn_Click()
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
        
        Dim left As Long, top As Long, right As Long, bottom As Long
        
        Call uiElement.GetRectangle(left, top, right, bottom)
        
        txtX.Text = "0"
        txtY.Text = "0"
        txtW.Text = right - left
        txtH.Text = bottom - top
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub
Private Function GetX(ByVal n As Long) As Long
    Dim p As Long
    p = (2 ^ 16) - 1
    GetX = n And p
End Function
Private Function GetY(ByVal n As Long) As Long
    'right shift n by 16 bits
    n = n / 2 ^ 16
    Dim p As Long
    p = (2 ^ 16) - 1
    GetY = n And p
End Function
