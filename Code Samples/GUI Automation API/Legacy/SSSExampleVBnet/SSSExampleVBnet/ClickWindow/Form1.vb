Imports ScreenScraper

Public Class Form1
    Private m_tCapture As TextCaptureX
    Private m_tSelection As TSelection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboClick.SelectedIndex = 0
        comboMouseBtn.SelectedIndex = 0

        Try
            m_tCapture = ComFactory.Instance.NewTextCaptureX
            m_tSelection = ComFactory.Instance.NewTSelection
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
            uiElement.hwnd = tSelInfo.WindowHandle
            strID = uiElement.GetID(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return
        End Try
        txtHandle.Text = uiElement.hwnd.ToString("X")
        txtID.Text = strID

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
            uiElement.UseClientCoordinates = True
            uiElement.InitializeFromID(txtID.Text, True)

            Dim left, top, right, bottom As Integer
            uiElement.GetRectangle(left, top, right, bottom)

            Dim flags As Integer
            flags = GetClickFlags()
            uiElement.Click(left, top, flags)
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
End Class
