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
   Begin VB.TextBox txtResult 
      Height          =   2055
      Left            =   360
      MultiLine       =   -1  'True
      TabIndex        =   34
      Text            =   "Form1.frx":0000
      Top             =   9840
      Width           =   3975
   End
   Begin VB.TextBox txtFontSize 
      Height          =   405
      Left            =   3480
      TabIndex        =   32
      Text            =   "Text1"
      Top             =   9360
      Width           =   855
   End
   Begin VB.TextBox txtFont 
      Height          =   375
      Left            =   960
      TabIndex        =   30
      Text            =   "Text1"
      Top             =   9360
      Width           =   1335
   End
   Begin VB.Frame Frame3 
      Caption         =   "Region Screen Scraping "
      Height          =   2415
      Left            =   240
      TabIndex        =   24
      Top             =   6840
      Width           =   3975
      Begin VB.CommandButton Command4 
         Caption         =   "Get word from a X, Y point"
         Height          =   255
         Left            =   480
         TabIndex        =   29
         Top             =   1920
         Width           =   2655
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Get text out of active window"
         Height          =   255
         Left            =   480
         TabIndex        =   28
         Top             =   1560
         Width           =   2655
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Get text from defined window"
         Height          =   255
         Left            =   480
         TabIndex        =   27
         Top             =   1200
         Width           =   2655
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Get text from defined region"
         Height          =   255
         Left            =   480
         TabIndex        =   26
         Top             =   840
         Width           =   2655
      End
      Begin VB.CheckBox useIDChk 
         Caption         =   "Use the ID instead of the HWND"
         Height          =   255
         Left            =   360
         TabIndex        =   25
         Top             =   480
         Width           =   3135
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Screen Scraping Methods "
      Height          =   1695
      Left            =   240
      TabIndex        =   17
      Top             =   5040
      Width           =   3975
      Begin VB.ComboBox cmbLang 
         Height          =   315
         ItemData        =   "Form1.frx":0006
         Left            =   2880
         List            =   "Form1.frx":0008
         TabIndex        =   23
         Text            =   "Combo2"
         Top             =   1200
         Width           =   975
      End
      Begin VB.ComboBox cmbEngine 
         Height          =   315
         ItemData        =   "Form1.frx":000A
         Left            =   1680
         List            =   "Form1.frx":000C
         TabIndex        =   22
         Text            =   "Combo1"
         Top             =   1200
         Width           =   975
      End
      Begin VB.OptionButton ocrRadio 
         Caption         =   "OCR method"
         Height          =   255
         Left            =   240
         TabIndex        =   21
         Top             =   1200
         Width           =   1215
      End
      Begin VB.CheckBox layoutCheck 
         Caption         =   "Preserve Layout"
         Height          =   255
         Left            =   720
         TabIndex        =   20
         Top             =   600
         Width           =   1695
      End
      Begin VB.OptionButton fullTextRadio 
         Caption         =   "FullText Method"
         Height          =   255
         Left            =   2280
         TabIndex        =   19
         Top             =   360
         Width           =   1455
      End
      Begin VB.OptionButton nativeRadio 
         Caption         =   "Native method"
         Height          =   255
         Left            =   240
         TabIndex        =   18
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "What do you want to scrape"
      Height          =   4575
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3975
      Begin VB.TextBox txtH 
         Height          =   285
         Left            =   3360
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
      Begin VB.TextBox txtY 
         Height          =   285
         Left            =   1320
         TabIndex        =   8
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtX 
         Height          =   285
         Left            =   480
         TabIndex        =   7
         Text            =   "Text1"
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtID 
         Height          =   1575
         Left            =   120
         MultiLine       =   -1  'True
         TabIndex        =   6
         Text            =   "Form1.frx":000E
         Top             =   2280
         Width           =   3615
      End
      Begin VB.TextBox txtHandle 
         Height          =   285
         Left            =   2520
         TabIndex        =   4
         Text            =   "Text1"
         Top             =   1440
         Width           =   975
      End
      Begin VB.CommandButton windowBtn 
         Caption         =   "Select a window or control"
         Height          =   375
         Left            =   480
         TabIndex        =   2
         Top             =   840
         Width           =   3015
      End
      Begin VB.CommandButton regionBtn 
         Caption         =   "Select a region from the screen"
         Height          =   375
         Left            =   480
         TabIndex        =   1
         Top             =   360
         Width           =   3015
      End
      Begin VB.Label Label8 
         Caption         =   "Height:"
         Height          =   255
         Left            =   2760
         TabIndex        =   16
         Top             =   4080
         Width           =   495
      End
      Begin VB.Label Label7 
         Caption         =   "Width:"
         Height          =   255
         Left            =   1800
         TabIndex        =   15
         Top             =   4080
         Width           =   495
      End
      Begin VB.Label Label6 
         Caption         =   "Y:"
         Height          =   255
         Left            =   1080
         TabIndex        =   14
         Top             =   4080
         Width           =   375
      End
      Begin VB.Label Label3 
         Caption         =   "X:"
         Height          =   255
         Left            =   240
         TabIndex        =   11
         Top             =   4080
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "Window ID:"
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   1920
         Width           =   1575
      End
      Begin VB.Label Label1 
         Caption         =   "Window handle (hex):"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   1440
         Width           =   1815
      End
   End
   Begin VB.Label Label10 
      Caption         =   "Size:"
      Height          =   255
      Left            =   2640
      TabIndex        =   33
      Top             =   9480
      Width           =   735
   End
   Begin VB.Label Label9 
      Caption         =   "Font:"
      Height          =   255
      Left            =   360
      TabIndex        =   31
      Top             =   9480
      Width           =   495
   End
   Begin VB.Label Label5 
      Caption         =   "Y:"
      Height          =   255
      Left            =   1200
      TabIndex        =   13
      Top             =   4440
      Width           =   375
   End
   Begin VB.Label Label4 
      Caption         =   "X:"
      Height          =   255
      Left            =   1440
      TabIndex        =   12
      Top             =   4440
      Width           =   375
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Sub Sleep Lib "kernel32.dll" (ByVal dwMilliseconds As Long)
Private Type RECT
   x1 As Long
   y1 As Long
   x2 As Long
   y2 As Long
End Type
Private Declare Function GetWindowRect Lib "user32.dll" (ByVal hwnd As Long, ByRef lpRect As RECT) As Long


Private m_tCapture As TextCaptureX
Private m_tSelection As TSelection
Private m_tFullText As GetAAText
Private m_tOCR As GetOCRText

Private Sub PerformRegionCapture()
    Dim x, y, width, height As Long
    
    Dim uiElement As UIElem
    
    x = txtX.Text
    y = txtY.Text
    width = txtW.Text
    height = txtH.Text
    
    Dim strResult As String
    Dim font As stdole.StdFont
    Dim strFont, strFontSize As String
    
    strResult = ""
    strFont = ""
    strFontSize = ""
    
    On Error GoTo error_treatment
    
        Set uiElement = New UIElem

        If (useIDChk.Value = vbChecked) Then
            Call uiElement.InitializeFromID(txtID.Text, True)
        Else
            uiElement.hwnd = txtHandle.Text
        End If
    
        If (nativeRadio.Value = True) Then
            strResult = m_tCapture.GetTextFromRectWithFont(uiElement.hwnd, x, y, width, height, font)
            strFont = font.Name
            strFontSize = font.Size
        ElseIf (fullTextRadio.Value = True) Then
            strResult = m_tFullText.GetFullTextFromRectangle(uiElement.hwnd, x, y, width, height)
        ElseIf (ocrRadio.Value = True) Then
            'translate to client coordinates
            Dim rc As RECT
            GetWindowRect uiElement.hwnd, rc
            Dim left, top As Long
            left = x - rc.x1
            top = y - rc.y1
            
            'get the language
            Dim strLang As String
            strLang = cmbLang.Text
            strResult = m_tOCR.GetTextFromRect(uiElement.hwnd, left, top, width, height, strLang, False)
        End If
        
        
exit_sub:
    txtResult.Text = strResult
    txtFont.Text = strFont
    txtFontSize.Text = strFontSize
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub

Private Sub PerformWindowCapture()
    Dim uiElement As UIElem
    
    Dim strResult As String
    Dim font As stdole.StdFont
    Dim strFont, strFontSize As String
    
    strResult = ""
    strFont = ""
    strFontSize = ""
    
    On Error GoTo error_treatment
    
        Set uiElement = New UIElem

        If (useIDChk.Value = vbChecked) Then
            Call uiElement.InitializeFromID(txtID.Text, True)
        Else
            uiElement.hwnd = txtHandle.Text
        End If
    
        If (nativeRadio.Value = True) Then
            strResult = m_tCapture.GetTextFromUIElemWithFont(uiElement, font)
            strFont = font.Name
            strFontSize = font.Size
        ElseIf (fullTextRadio.Value = True) Then
            strResult = m_tFullText.GetFullTextFromUIElem(uiElement)
        ElseIf (ocrRadio.Value = True) Then
            Dim strLang As String
            strLang = cmbLang.Text
            strResult = m_tOCR.GetTextFromUIElem(uiElement, strLang, False)
        End If
        
        
exit_sub:
    txtResult.Text = strResult
    txtFont.Text = strFont
    txtFontSize.Text = strFontSize
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub
Private Sub Command1_Click()
    PerformRegionCapture
End Sub

Private Sub Command2_Click()
    PerformWindowCapture
End Sub

Private Sub Command3_Click()
    Dim strResult As String
    strResult = ""
    
    Me.WindowState = vbMinimized
    
    On Error GoTo error_treatment
        Dim hActive As Long
        hActive = m_tCapture.GetActiveWindowHwnd()
        Sleep 300
        strResult = m_tCapture.CaptureWindow(hActive)
        
exit_sub:
    txtResult.Text = strResult
    txtFont.Text = ""
    txtFontSize.Text = ""
    Me.WindowState = vbNormal
    
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
    
End Sub

Private Sub Command4_Click()
    Dim hwnd, x, y As Long
    hwnd = txtHandle.Text
    x = txtX.Text
    y = txtY.Text
    
    Dim strResult As String
    strResult = ""
    On Error GoTo error_treatment:
        strResult = m_tCapture.GetTextFromPoint(hwnd, x, y)
        
exit_sub:
    txtResult.Text = strResult
    txtFont.Text = ""
    txtFontSize.Text = ""
       
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
    
End Sub

Private Sub Form_Load()
    On Error GoTo error_treatment
        Set m_tCapture = New TextCaptureX
        Set m_tSelection = New TSelection
        Set m_tFullText = New GetAAText
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
        
        txtX.Text = x1
        txtY.Text = y1
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
        
        txtX.Text = "0"
        txtY.Text = "0"
        txtW.Text = "0"
        txtH.Text = "0"
exit_sub:
    Exit Sub
    
error_treatment:
    MsgBox Err.Description
    Resume exit_sub
End Sub
