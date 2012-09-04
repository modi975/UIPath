Imports UiPath

Public Class Form1
    Private ScrapeMethod As UiScrapingMethod
    Private OCREngine As UiOCREngine

    Private uiNode As UiNode

    Private Sub FullTextScrapeOptions(Visibile As Boolean)
        IgnoreHidden_Checkbox.Visible = Visibile
    End Sub

    Private Sub OCRScrapeOptions(Visibile As Boolean)

        AllowedChars_label.Visible = Visibile
        textBoxAllowedChars.Visible = Visibile
        DeniedChars_label.Visible = Visibile
        textBoxDeniedChars.Visible = Visibile
        Correction_checkbox.Visible = Visibile
        Invert_checkbox.Visible = Visibile
        OCREngine_label.Visible = Visibile
        OCREngine_combo.Visible = Visibile
        OCRLanguage_label.Visible = Visibile
        OCRLanguage_Combo.Visible = Visibile
        OCREngine_combo.SelectedIndex = 0
    End Sub

    Private Sub SetSelector()
        Try

            textSelector.Text = uiNode.GetSelector(True)
        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to get the selector of a UiNode. Please make sure the UI object refered by the UiNode is still available on screen.")
        End Try

    End Sub

    Private Sub SetOCRLanguages(languages As String())
        OCRLanguage_Combo.Items.Clear()
        For Each lang As String In languages

            OCRLanguage_Combo.Items.Add(lang)
        Next
    End Sub

    Private Sub SetResult(uiScrapeResult As UiScrapeResult)

        textBoxOutput.ResetText()

        If GetFont_Checkbox.Checked Then

            'set font info
            textBoxOutput.AppendText("Font Name: " + uiScrapeResult.font.Name + " Font Size:" + uiScrapeResult.font.Size + "\r\n\r\n")
        End If

        If (ExtractInfo_Checkbox.Checked) Then
            'get information about each word
            For Each word As UiTextInfo In uiScrapeResult.textInfo

                'append info about word in output
                textBoxOutput.AppendText("left: " + word.rectangle.left + " top: " + word.rectangle.top + " right: " + word.rectangle.right + " bottom: " + word.rectangle.bottom + " text = " + word.text + "\r\n")
            Next
        Else

            'add entire scrape result
            textBoxOutput.AppendText(uiScrapeResult.text)
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'set default options
        ScrapeMethod = UiScrapingMethod.UI_AUTOMATIC
        ScrapeMethod_Combo.SelectedIndex = 0

        OCREngine = UiOCREngine.UI_OCR_TESSERACT
        OCREngine_combo.SelectedIndex = 0

        'create uiNode
        uiNode = UiFactory.Instance.NewUiNode()

    End Sub

    Private Sub NativeScrapeOptions(Visibile As Boolean)
        GetFont_Checkbox.Visible = Visibile
        FormattedText_Checkbox.Visible = Visibile
    End Sub

    Private Sub Select_UIObject_Click(sender As System.Object, e As System.EventArgs) Handles Select_UIObject.Click
        'minimize application
        WindowState = FormWindowState.Minimized

        'select a UI object
        Dim selType As UiSelectionType
        selType = UiSelectionType.UI_SELECT_NODE
        Try
            uiNode.SelectInteractive(selType)
            SetSelector()
        Catch ex As Exception
            'restore application
            WindowState = FormWindowState.Normal
            System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to select a UI object. Please try again or contact us at  support@deskover.com")
        End Try
        'restore application
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub Select_Region_Click(sender As System.Object, e As System.EventArgs) Handles Select_Region.Click
        'minimize application
        WindowState = FormWindowState.Minimized

        'select a region
        Dim selType As UiSelectionType
        selType = UiSelectionType.UI_SELECT_REGION
        Try
            uiNode.SelectInteractive(selType)
            SetSelector()
        Catch ex As Exception
            'restore application
            WindowState = FormWindowState.Normal
            System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to a region. Please try again or contact us at  support@deskover.com")
        End Try
        'restore application
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnActiveWindow_Click(sender As System.Object, e As System.EventArgs) Handles btnActiveWindow.Click
        'Minimize application
        WindowState = FormWindowState.Minimized
        Try

            'get active window
            Dim UiWindow As UiWindow
            UiWindow = UiFactory.Instance.NewUiWindow
            UiWindow.FromActiveWindow()

            'initialize uiNode from active window
            uiNode.FromWindow(UiWindow)
            SetSelector()

        Catch ex As Exception
            'restore application
            WindowState = FormWindowState.Normal
            System.Windows.Forms.MessageBox.Show(ex.Message + "\r\nAn error appear while trying to initialize an UiNode from an UiWindow")
        End Try

        'restore application
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub Scrape_Click(sender As System.Object, e As System.EventArgs) Handles Scrape.Click
        'Create UiScrapeOptions object
        Dim UiScrapeOptions As UiScrapeOptions
        UiScrapeOptions = UiFactory.Instance.NewUiScrapeOptions

        'Set scraping options
        UiScrapeOptions.Set("scrapingmethod", ScrapeMethod)
        UiScrapeOptions.Set("extractinfo", ExtractInfo_Checkbox.Checked)
        UiScrapeOptions.Set("getfont", GetFont_Checkbox.Checked)
        UiScrapeOptions.Set("formattedtext", FormattedText_Checkbox.Checked)
        UiScrapeOptions.Set("ignorehidden", IgnoreHidden_Checkbox.Checked)
        UiScrapeOptions.Set("allowedcharacters", textBoxAllowedChars.Text)
        UiScrapeOptions.Set("deniedcharacters", textBoxDeniedChars.Text)
        UiScrapeOptions.Set("ocrcorrection", Correction_checkbox.Checked)
        UiScrapeOptions.Set("ocrengine", OCREngine)
        UiScrapeOptions.Set("ocrlanguage", OCRLanguage_Combo.SelectedText)
        UiScrapeOptions.Set("invert", Invert_checkbox.Checked)

        Dim UiScrapeResult As UiScrapeResult
        UiScrapeResult = uiNode.Scrape(UiScrapeOptions)
        'set output
        SetResult(UiScrapeResult)
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub ScrapeMethod_Combo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ScrapeMethod_Combo.SelectedIndexChanged
        'get the selected scraping method
        ScrapeMethod = CType(ScrapeMethod_Combo.SelectedIndex, UiScrapingMethod)

        'Update ui
        Select Case ScrapeMethod
            Case UiScrapingMethod.UI_AUTOMATIC
                NativeScrapeOptions(False)
                FullTextScrapeOptions(False)
                OCRScrapeOptions(False)
                Exit Select
            Case UiScrapingMethod.UI_NATIVE
                NativeScrapeOptions(True)
                FullTextScrapeOptions(False)
                OCRScrapeOptions(False)
                Exit Select
            Case UiScrapingMethod.UI_FULLTEXT
                NativeScrapeOptions(False)
                FullTextScrapeOptions(True)
                OCRScrapeOptions(False)
                Exit Select
            Case UiScrapingMethod.UI_OCR
                NativeScrapeOptions(False)
                FullTextScrapeOptions(False)
                OCRScrapeOptions(True)
                Exit Select
        End Select

    End Sub

    Private Sub OCREngine_combo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles OCREngine_combo.SelectedIndexChanged
        'get OCR engine selected
        OCREngine = CType(OCREngine_combo.SelectedIndex, UiOCREngine)

        'get OCR specific languages
        Dim UiSystem As UiSystem
        UiSystem = UiFactory.Instance.NewUiSystem
        Try
            Dim languages As String()
            languages = UiSystem.GetOCRLanguages(OCREngine)
            'Set languages as items source for OCRLanguage combo
            SetOCRLanguages(languages)

        Catch ex As Exception

            System.Windows.Forms.MessageBox.Show("An error appeared while trying to retrive the languages for " + OCREngine.ToString())

            Exit Sub

        End Try
        'Set english as default language
        If (OCREngine = UiOCREngine.UI_OCR_TESSERACT) Then

            OCRLanguage_Combo.SelectedItem = "eng"
            Dim index As Integer
            index = OCRLanguage_Combo.SelectedIndex
        Else
            OCRLanguage_Combo.SelectedItem = "English"
        End If
    End Sub
End Class
