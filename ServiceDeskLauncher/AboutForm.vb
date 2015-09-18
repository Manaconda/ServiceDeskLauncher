Public Class AboutForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkConnectUp.LinkClicked

        Dim webAddress As String = "http://www.connect-up.co.uk"
        Process.Start(webAddress)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnSupport.Click

        Dim webAddress As String = "http://servicedesk.connect-up.co.uk"
        Process.Start(webAddress)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxTeamViewer.Click

        Dim proc As New System.Diagnostics.Process()
        Dim strPath As String = Application.StartupPath

        proc = Process.Start(strPath + "\TeamViewerQS_en.exe", "")

    End Sub

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strHostname As String = My.Computer.Name
        Dim strDNSHostname As String
        Dim strIPAddress As String

        strDNSHostname = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostname).AddressList(0).ToString()

        Me.Text = "Hostname :  " + strHostname + "  |  IP Address:  " + strIPAddress

    End Sub
End Class