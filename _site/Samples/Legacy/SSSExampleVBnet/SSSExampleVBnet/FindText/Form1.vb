Imports ScreenScraper
Public Class Form1
    Private m_tCapture As TextCaptureX
    Private m_tSelection As TSelection
    Private m_tOCRCapture As GetOCRText
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboClick.SelectedIndex = 0
        comboMouseBtn.SelectedIndex = 0
        radioNative.Checked = True
        Try
            m_tCapture = ComFactory.Instance.NewTextCaptureX
            m_tSelection = ComFactory.Instance.NewTSelection
            m_tOCRCapture = ComFactory.Instance.NewGetOCRText
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function GetClickFlags() As Integer
        Dim nRes As Integer
        nRes = UIE_ClickFlags.UIE_CF_MOVE_CURSOR

        If (comboMouseBtn.SelectedIndex = 0) Then
            nRes = nRes Or UIE_ClickFlags.UIE_CF_LEFT
        ElseIf (comboMouseBtn.SelectedIndex = 1) Then
            nRes = nRes Or UIE_ClickFlags.UIE_CF_MIDDLE
        ElseIf (comboMouseBtn.SelectedIndex = 2) Then
            nRes = nRes Or UIE_ClickFlags.UIE_CF_RIGHT
        End If

        If (comboClick.SelectedIndex = 0) Then
            nRes = nRes Or UIE_ClickFlags.UIE_CF_SINGLE
        ElseIf (comboClick.SelectedIndex = 1) Then
            nRes = nRes Or UIE_ClickFlags.UIE_CF_DOUBLE
        End If

        GetClickFlags = nRes
    End Function

    Private Sub checkLayout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkLayout.CheckedChanged
        m_tCapture.FormattedText = checkLayout.Checked
    End Sub

    Private Sub btnCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollect.Click
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

        tSelInfo.GetClientCoordinates()

        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
            uiElement.hwnd = hwnd

            'set the UI element ID
            txtID.Text = uiElement.GetID(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        'set the points
        txtX.Text = tSelInfo.RCLeft.ToString
        txtY.Text = tSelInfo.RCTop.ToString
        txtWidth.Text = tSelInfo.RCWidth.ToString
        txtHeight.Text = tSelInfo.RCHeight.ToString
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim tSelInfo As TSelectionInfo

        Try
            tSelInfo = m_tSelection.Start(TS_SELECTION.tsSelectionWindow, TS_SELECTION_OPTIONS.tsSelFlagDefaultText)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        Dim strID As String
        Dim x1, x2, y1, y2 As Integer

        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
            uiElement.hwnd = tSelInfo.WindowHandle
            strID = uiElement.GetID(False)
            uiElement.GetRectangle(x1, y1, x2, y2)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try

        txtX.Text = "0"
        txtY.Text = "0"
        txtWidth.Text = (x2 - x1).ToString
        txtHeight.Text = (y2 - y1).ToString

        txtHandle.Text = uiElement.hwnd.ToString("X")
        txtID.Text = strID
    End Sub
    Private Sub SearchText(ByVal bClickText As Boolean)
        Dim hwnd As Integer
        hwnd = Integer.Parse(txtHandle.Text, System.Globalization.NumberStyles.HexNumber)

        Dim x, y, w, h As Integer
        x = Integer.Parse(txtX.Text)
        y = Integer.Parse(txtY.Text)
        w = Integer.Parse(txtWidth.Text)
        h = Integer.Parse(txtHeight.Text)

        Dim occurrence As Integer
        occurrence = Integer.Parse(txtOccurence.Text)
        Try
            Dim rectangle As rect
            rectangle = ComFactory.Instance.NewRect

            rectangle.RLeft = x
            rectangle.RRight = x + w
            rectangle.RTop = y
            rectangle.RBottom = y + h

            m_tCapture.UseClientCoordinates = True

            Dim foundRect As rect
            If (radioNative.Checked = True) Then
                foundRect = m_tCapture.GetRectFromText(hwnd, txtSearch.Text, rectangle, occurrence)
            ElseIf radioOCR.Checked = True Then
                Dim strLang As String
                strLang = comboLang.Items(comboLang.SelectedIndex)
                foundRect = m_tOCRCapture.GetRectFromText(hwnd, txtSearch.Text, rectangle, strLang, False, occurrence)
            End If

            txtFoundX.Text = foundRect.RLeft.ToString
            txtFoundY.Text = foundRect.RTop.ToString
            txtFoundH.Text = foundRect.height().ToString
            txtFoundW.Text = foundRect.width().ToString

            If (bClickText = True) Then
                Dim uiElement As UIElem
                uiElement = ComFactory.Instance.NewUIElem

                uiElement.InitializeFromID(txtID.Text, True)

                uiElement.Click(foundRect.RLeft + 2, foundRect.RTop + 2, GetClickFlags())
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        SearchText(False)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        SearchText(True)
    End Sub
End Class
