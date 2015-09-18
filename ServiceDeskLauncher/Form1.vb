Public Class Form1

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        AboutForm.Visible = True
        AboutForm.BringToFront()
        AboutForm.Activate()
    End Sub

End Class
