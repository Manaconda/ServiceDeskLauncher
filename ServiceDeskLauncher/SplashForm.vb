Public Class AboutForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = "http://www.connect-up.co.uk"
        Process.Start(webAddress)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim webAddress As String = "http://servicedesk.connect-up.co.uk"
        Process.Start(webAddress)
    End Sub
End Class