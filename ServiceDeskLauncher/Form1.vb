Public Class Form1

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then
            'Dim webAddress As String = "http://servicedesk.connect-up.co.uk"
            'Process.Start(webAddress)
            AboutForm.Visible = True
            AboutForm.BringToFront()
            AboutForm.Activate()
        End If
        If e.Button = Windows.Forms.MouseButtons.Right Then
            AboutForm.Visible = True
            AboutForm.BringToFront()
            AboutForm.Activate()
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width - 485
            y = Screen.PrimaryScreen.WorkingArea.Height - 367
            'AboutForm.Location = New Point(x, y)
        End If
    End Sub

End Class
