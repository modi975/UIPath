Imports ScreenScraper

Enum CaptureMethod
    NATIVE
    FULL_TEXT
    OCR
End Enum

Public Class Form1
    Private m_tCapture As TextCaptureX
    Private m_tFulltextCapt As GetAAText
    Private m_tOCRCapture As GetOCRText
    Private m_tSelection As TSelection
    Private m_bRegOrWnd As Boolean
    Private m_bCanTryAgain As Boolean
    Private Function GetCaptureMethod() As CaptureMethod
        If (radioNative.Checked = True) Then
            GetCaptureMethod = CaptureMethod.NATIVE
        ElseIf (radioFullText.Checked = True) Then
            GetCaptureMethod = CaptureMethod.FULL_TEXT
        Else
            GetCaptureMethod = CaptureMethod.OCR
        End If
    End Function
    Private Sub btnCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollect.Click
        m_bRegOrWnd = True
        Dim tSelInfo As TSelectionInfo

        Try
            tSelInfo = m_tSelection.Start(TS_SELECTION.tsSelectionRectangle, TS_SELECTION_OPTIONS.tsSelFlagDefaultText)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        'get the hwnd
        Dim hwnd As Integer
        hwnd = tSelInfo.WindowHandle
        txtHandle.Text = hwnd.ToString("X")

        Dim uiElement As UIElem
        uiElement = ComFactory.Instance.NewUIElem
        uiElement.hwnd = hwnd

        'set the UI element ID
        textBox1.Text = uiElement.GetID(True)

        'get the selection points
        tSelInfo.GetClientCoordinates()

        'set the points
        txtX.Text = tSelInfo.RCLeft.ToString
        txtY.Text = tSelInfo.RCTop.ToString
        txtWidth.Text = tSelInfo.RCWidth.ToString
        txtHeight.Text = tSelInfo.RCHeight.ToString
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            m_tCapture = ComFactory.Instance.NewTextCaptureX
            m_tFulltextCapt = ComFactory.Instance.NewGetAAText
            m_tOCRCapture = ComFactory.Instance.NewGetOCRText
            m_tSelection = ComFactory.Instance.NewTSelection

            m_tCapture.UseClientCoordinates = True
            m_tOCRCapture.UseClientCoordinates = True
            m_tFulltextCapt.UseClientCoordinates = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'init ui 
        radioNative.Checked = True
        checkIDorHWND.Checked = True

        'init ocr
        comboEngine.Items.Add("Tesseract")
        comboEngine.SelectedIndex = 0

        comboLang.Items.Add("eng")
        comboLang.Items.Add("deu")
        comboLang.Items.Add("spa")
        comboLang.Items.Add("ita")
        comboLang.Items.Add("fra")
        comboLang.Items.Add("nld")
        comboLang.Items.Add("spa")
        comboLang.SelectedIndex = 0
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        m_bRegOrWnd = False
        Dim tSelInfo As TSelectionInfo

        WindowState = FormWindowState.Minimized

        Try
            tSelInfo = m_tSelection.Start(TS_SELECTION.tsSelectionUIElement, TS_SELECTION_OPTIONS.tsSelFlagDefaultText)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        WindowState = FormWindowState.Normal

        'get the hwnd
        Dim hwnd As Integer
        hwnd = tSelInfo.WindowHandle
        txtHandle.Text = hwnd.ToString("X")

        'set the UI elemend ID
        Dim uiElement As UIElem
        uiElement = ComFactory.Instance.NewUIElem

        If (tSelInfo.UIElementID = "") Then
            textBox1.Text = "A valid ID could not be generated!"
            Exit Sub
        Else

            uiElement.InitializeFromID(tSelInfo.UIElementID, True)
            Dim uiElemID As String
            uiElemID = uiElement.GetID(True)
            textBox1.Text = uiElemID

        End If


    End Sub
    Private Sub PerformRegionCapture(ByVal hwnd As Integer, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer)
        If (m_bRegOrWnd = False) Then
            'if a window was selected
            MessageBox.Show("You selected a window!")
            Return
        End If

        Dim currentMethod As CaptureMethod
        currentMethod = GetCaptureMethod()
        Dim strText As String
        strText = ""

        If (currentMethod = CaptureMethod.NATIVE) Then
            Dim font As stdole.IFontDisp

            Try
                'preserve layout checkbox
                If (checkLayout.Checked = True) Then
                    m_tCapture.FormattedText = True
                End If

                strText = m_tCapture.GetTextFromRectWithFont(hwnd, x, y, width, height, font)
                txtFont.Text = font.Name
                txtFontSize.Text = font.Size.ToString
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformRegionCapture(hwnd, x, y, width, height)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If

            End Try
        ElseIf (currentMethod = CaptureMethod.FULL_TEXT) Then
            Try
                strText = m_tFulltextCapt.GetFullTextFromRectangle(hwnd, x, y, width, height)
                txtFont.Text = ""
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformRegionCapture(hwnd, x, y, width, height)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If
            End Try
        ElseIf (currentMethod = CaptureMethod.OCR) Then
            Try
                Dim strLang As String
                strLang = comboLang.Items(comboLang.SelectedIndex)
                strText = m_tOCRCapture.GetTextFromRect(hwnd, x, y, width, height, strLang, False)
                txtFont.Text = ""
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformRegionCapture(hwnd, x, y, width, height)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If
            End Try

        End If
        txtResult.Text = strText
    End Sub

    Private Sub btnRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangle.Click
        Dim x, y, width, height As Integer
        x = Integer.Parse(txtX.Text)
        y = Integer.Parse(txtY.Text)
        width = Integer.Parse(txtWidth.Text)
        height = Integer.Parse(txtHeight.Text)

        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        If (checkIDorHWND.Checked = True) Then
            Dim strId As String
            strId = textBox1.Text
            Try
                uiElement.InitializeFromID(strId, True)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        Else
            Dim hwnd As Integer
            hwnd = Integer.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber)
            uiElement.hwnd = hwnd
        End If

        m_bCanTryAgain = True
        PerformRegionCapture(uiElement.hwnd, x, y, width, height)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If (checkIDorHWND.Checked = True) Then
            'get id
            Dim strID As String
            strID = textBox1.Text
            Try
                uiElement.InitializeFromID(strID, True)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Dim hwnd As Integer
            hwnd = Integer.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber)
            uiElement.hwnd = hwnd
        End If

        m_bCanTryAgain = True
        PerformWndCapture(uiElement)
    End Sub
    Private Sub PerformWndCapture(ByVal uiElement As UIElem)
        If (m_bRegOrWnd = True) Then
            MessageBox.Show("You selected a region!")
            Return
        End If

        Dim font As stdole.IFontDisp
        Dim strText As String
        strText = ""

        Dim captMethod As CaptureMethod
        captMethod = GetCaptureMethod()
        If (captMethod = CaptureMethod.NATIVE) Then
            Try
                'preserve layout checkbox
                If (checkLayout.Checked = True) Then
                    m_tCapture.FormattedText = True
                End If
                strText = m_tCapture.GetTextFromUIElemWithFont(uiElement, font)
                txtFont.Text = font.Name
                txtFontSize.Text = font.Size.ToString
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformWndCapture(uiElement)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If
            End Try
        ElseIf (captMethod = CaptureMethod.FULL_TEXT) Then
            Try
                strText = m_tFulltextCapt.GetFullTextFromUIElem(uiElement)
                txtFont.Text = ""
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformWndCapture(uiElement)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If
            End Try
        ElseIf (captMethod = CaptureMethod.OCR) Then
            Try
                Dim strlang As String
                strlang = comboLang.Items(comboLang.SelectedIndex)
                strText = m_tOCRCapture.GetTextFromUIElem(uiElement, strlang, False)
                txtFont.Text = ""
            Catch ex As Exception
                Dim ComEx As System.Runtime.InteropServices.COMException
                ComEx = ex
                If (ComEx.ErrorCode = -2147220989) And (m_bCanTryAgain = True) Then
                    m_bCanTryAgain = False
                    MessageBox.Show("Capture timeout! Trying again!")
                    System.Threading.Thread.Sleep(4000) 'sleep for 4 seconds
                    PerformWndCapture(uiElement)
                    Return
                Else
                    strText = "Capture Error!"
                    MessageBox.Show(ex.Message)
                End If
            End Try
        End If
        txtResult.Text = strText
    End Sub

    Private Sub btnActive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActive.Click
        Dim activeHwnd As Integer
        WindowState = FormWindowState.Minimized
        Try
            activeHwnd = m_tCapture.GetActiveWindowHwnd()
            Dim strResult As String
            strResult = m_tCapture.CaptureWindow(activeHwnd)
            txtResult.Text = strResult
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtResult.Text = "Capture Error!"
        End Try
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoint.Click
        Dim x, y, hwnd As Integer
        x = Integer.Parse(txtX.Text)
        y = Integer.Parse(txtY.Text)
        hwnd = Integer.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber)

        Try
            Dim strResult As String
            strResult = m_tCapture.GetTextFromPoint(hwnd, x, y)
            txtResult.Text = strResult
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtResult.Text = "Capture Error!"
        End Try
    End Sub
End Class
