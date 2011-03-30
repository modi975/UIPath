Imports ScreenScraper

Public Class Form1
    Private m_tCapture As TextCaptureX
    Private m_tSelection As TSelection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radioAPI.Checked = True
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

    Private Sub btnRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangle.Click
        Dim uiElement As UIElem
        Try
            uiElement = ComFactory.Instance.NewUIElem
            uiElement.UseClientCoordinates = True
            uiElement.InitializeFromID(txtID.Text, True)

            Dim left, top, right, bottom As Integer
            uiElement.GetRectangle(left, top, right, bottom)

            Dim flags As Integer
            flags = UIE_ClickFlags.UIE_CF_MOVE_CURSOR Or UIE_ClickFlags.UIE_CF_SINGLE

            Dim method As Integer
            method = 0
            If (radioAPI.Checked = True) Then
                method = UIE_WriteTextMethod.UIE_WTM_NATIVE
            Else
                method = UIE_WriteTextMethod.UIE_WTM_SENDKEYS
            End If

            uiElement.WriteText(method, txtWriteText.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
