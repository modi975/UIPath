VERSION 5.00
Begin VB.Form Scraping 
   Caption         =   "Scraping Sample"
   ClientHeight    =   7530
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   7365
   LinkTopic       =   "Form1"
   ScaleHeight     =   7530
   ScaleWidth      =   7365
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox TextResult 
      Height          =   3015
      Left            =   360
      TabIndex        =   19
      Top             =   4200
      Width           =   6735
   End
   Begin VB.TextBox DeniedText 
      Height          =   285
      Left            =   1920
      TabIndex        =   18
      Top             =   2640
      Width           =   1215
   End
   Begin VB.TextBox AllowedText 
      Height          =   285
      Left            =   1920
      TabIndex        =   16
      Top             =   2280
      Width           =   1215
   End
   Begin VB.ComboBox OCRLanguageCombo 
      Height          =   315
      Left            =   360
      TabIndex        =   14
      Text            =   "OCR Language"
      Top             =   3600
      Width           =   1935
   End
   Begin VB.ComboBox OCREngineCombo 
      Height          =   315
      Left            =   360
      TabIndex        =   13
      Text            =   "OCR Engine"
      Top             =   3120
      Width           =   1935
   End
   Begin VB.CheckBox InvertCheck 
      Caption         =   "Check1"
      Height          =   255
      Left            =   360
      TabIndex        =   11
      Top             =   1920
      Width           =   255
   End
   Begin VB.CheckBox OcrCorrectionCheck 
      Caption         =   "Check1"
      Height          =   255
      Left            =   360
      TabIndex        =   8
      Top             =   1560
      Width           =   255
   End
   Begin VB.CheckBox IgnoreHiddenCheck 
      Caption         =   "Check1"
      Height          =   255
      Left            =   360
      TabIndex        =   7
      Top             =   1200
      Width           =   255
   End
   Begin VB.CheckBox FormattedText_Checkbox 
      Caption         =   "Check1"
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   840
      Width           =   255
   End
   Begin VB.ComboBox ScrapingMethodCombo 
      Height          =   315
      ItemData        =   "Scraping.frx":0000
      Left            =   360
      List            =   "Scraping.frx":0002
      TabIndex        =   4
      Text            =   "Scraping Method"
      Top             =   360
      Width           =   1935
   End
   Begin VB.CommandButton Scrape 
      Caption         =   "Scrape"
      Height          =   375
      Left            =   5040
      TabIndex        =   3
      Top             =   2760
      Width           =   1935
   End
   Begin VB.CommandButton ActiveWnd 
      Caption         =   "Get active window"
      Height          =   495
      Left            =   5040
      TabIndex        =   2
      Top             =   1920
      Width           =   1935
   End
   Begin VB.CommandButton SelectRegion 
      Caption         =   "Select region"
      Height          =   495
      Left            =   5040
      TabIndex        =   1
      Top             =   1080
      Width           =   1935
   End
   Begin VB.CommandButton SelectObj 
      Caption         =   "Select UI Object"
      Height          =   495
      Left            =   5040
      TabIndex        =   0
      Top             =   240
      Width           =   1935
   End
   Begin VB.Label Label6 
      Caption         =   "Denied characters:"
      Height          =   255
      Left            =   360
      TabIndex        =   17
      Top             =   2640
      Width           =   1455
   End
   Begin VB.Label Label5 
      Caption         =   "Allowed characters:"
      Height          =   255
      Left            =   360
      TabIndex        =   15
      Top             =   2280
      Width           =   1575
   End
   Begin VB.Label Label4 
      Caption         =   "Invert"
      Height          =   255
      Left            =   600
      TabIndex        =   12
      Top             =   1920
      Width           =   615
   End
   Begin VB.Label Label3 
      Caption         =   "OCR Correction"
      Height          =   255
      Left            =   600
      TabIndex        =   10
      Top             =   1560
      Width           =   1455
   End
   Begin VB.Label Label2 
      Caption         =   "Ignore hidden"
      Height          =   255
      Left            =   600
      TabIndex        =   9
      Top             =   1200
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "Formatted text"
      Height          =   255
      Left            =   600
      TabIndex        =   6
      Top             =   840
      Width           =   1455
   End
End
Attribute VB_Name = "Scraping"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Public uiNodeObject As UiNode
Public scrapeMethod As UiScrapingMethod
Public ok As Boolean


Private Sub Form_Load()
    ScrapingMethodCombo.AddItem ("Native")
    ScrapingMethodCombo.AddItem ("Fulltext")
    ScrapingMethodCombo.AddItem ("OCR")
    OCREngineCombo.AddItem ("Tesseract")
    OCREngineCombo.AddItem ("MODI")
    NativeOptions (False)
    FulltextOptions (False)
    OCROptions (False)
    ok = False
    Scrape.Enabled = False
End Sub

Private Sub NativeOptions(Enabled As Boolean)
    FormattedText_Checkbox.Enabled = Enabled
End Sub

Private Sub FulltextOptions(Enabled As Boolean)
    IgnoreHiddenCheck.Enabled = Enabled
End Sub

Private Sub OCROptions(Enabled As Boolean)
    OcrCorrectionCheck.Enabled = Enabled
    InvertCheck.Enabled = Enabled
    OCREngineCombo.Enabled = Enabled
    OCRLanguageCombo.Enabled = Enabled
    AllowedText.Enabled = Enabled
    DeniedText.Enabled = Enabled
End Sub

Private Sub OCREngineCombo_Click()
    Dim uiSystemObject As UiSystem
    Set uiSystemObject = New UiSystem
    Dim Languages() As String
    If OCREngineCombo = "Tesseract" Then
        Languages = uiSystemObject.GetOCRLanguages(UI_OCR_TESSERACT)
    Else
        Languages = uiSystemObject.GetOCRLanguages(UI_OCR_MODI)
    End If
    Dim i As Integer
    Dim count As Integer
    count = UBound(Languages)
    OCRLanguageCombo.Clear
    For i = 0 To count
        OCRLanguageCombo.AddItem (Languages(i))
    Next i
    OCRLanguageCombo.SelText = "OCR Language"
End Sub

Private Sub OCRLanguageCombo_Click()
    ok = True
End Sub

Private Sub Scrape_Click()
'Create scrape options object
Dim scrapeOptionsObject As UiScrapeOptions
Set scrapeOptionsObject = New UiScrapeOptions

'set scraping method
Call scrapeOptionsObject.Set("scrapingmethod", scrapeMethod)

'set method options
If scrapeMethod = UI_NATIVE Then
    If FormattedText_Checkbox = vbChecked Then
        Call scrapeOptionsObject.Set("formattedtext", True)
    Else
        Call scrapeOptionsObject.Set("formattedtext", False)
    End If
End If
If scrapeMethod = UI_FULLTEXT Then
    If IgnoreHiddenCheck = vbChecked Then
        Call scrapeOptionsObject.Set("ignorehidden", True)
    Else
        Call scrapeOptionsObject.Set("ignorehidden", False)
    End If
End If

If scrapeMethod = UI_OCR Then
    If InvertCheck = vbChecked Then
        Call scrapeOptionsObject.Set("invert", True)
    Else
        Call scrapeOptionsObject.Set("invert", False)
    End If
    
    If OcrCorrectionCheck = vbChecked Then
        Call scrapeOptionsObject.Set("ocrcorrection", True)
    Else
        Call scrapeOptionsObject.Set("ocrcorrection", False)
    End If
    If OCREngineCombo = "Tesseract" Then
        Call scrapeOptionsObject.Set("ocrengine", UI_OCR_TESSERACT)
    Else
        Call scrapeOptionsObject.Set("ocrengine", UI_OCR_MODI)
    End If
    Call scrapeOptions.Set("allowedcharacters", AllowedText.Text)
    Call scrapeOptions.Set("deniedcharacters", DeniedText.Text)
    If ok = True Then
        Call scrapeOptions.Set("ocrlanguage", OCRLanguageCombo)
    Else
        MsgBox ("Please select an OCR language")
    End If
End If

' Get scrape result
Dim scrapeResultObject As UiScrapeResult
Set scrapeResultObject = uiNodeObject.Scrape(scrapeOptionsObject)

TextResult = scrapeResultObject.Text

End Sub

Private Sub ScrapingMethodCombo_Click()
    If ScrapingMethodCombo = "Native" Then
        scrapeMethod = UI_NATIVE
        Call NativeOptions(True)
        Call FulltextOptions(False)
        Call OCROptions(False)
                
    Else
        If ScrapingMethodCombo = "Fulltext" Then
            scrapeMethod = UI_FULLTEXT
            Call NativeOptions(False)
            Call FulltextOptions(True)
            Call OCROptions(False)
        
        Else
            scrapeMethod = UI_OCR
            Call NativeOptions(False)
            Call FulltextOptions(False)
            Call OCROptions(True)
        End If
    End If
    Scrape.Enabled = True
End Sub


Private Sub ActiveWnd_Click()
    WindowState = vbMinimized
    ' Get active window
    Dim uiWindowObject As UiWindow
    Set uiWindowObject = New UiWindow
    Set uiNodeObject = New UiNode
    ' Initialize uiNodeObject with active window
    Call uiNodeObject.FromWindow(uiWindowObject.FromActiveWindow())
    WindowState = vbNormal
End Sub



Private Sub SelectObj_Click()
    WindowState = vbMinimized
    ' Select a UI Object
    Dim selectionType As UiSelectionType
    selectionType = UI_SELECT_NODE
    Set uiNodeObject = New UiNode
    Call uiNodeObject.SelectInteractive(selectionType)
    WindowState = vbNormal
End Sub

Private Sub SelectRegion_Click()
    WindowState = vbMinimized
    ' Select a region
    Dim selectionType As UiSelectionType
    selectionType = UI_SELECT_REGION
    Set uiNodeObject = New UiNode
    Call uiNodeObject.SelectInteractive(selectionType)
    WindowState = vbNormal
End Sub
