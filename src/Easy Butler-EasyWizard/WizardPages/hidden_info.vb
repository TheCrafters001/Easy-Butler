Public Class hidden_info
    Private Sub Hidden_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'This collects info directly from settings.
        'This is not shared with anyone.
        'All the information that is stored in settings
        'is never uploaded to the internet, or is
        'never saved, as it will get cleared out when the finish
        'page opens.
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = My.Settings.UserName
        Label2.Text = My.Settings.GameURL
        Label3.Text = My.Settings.OSVer
        Label4.Text = My.Settings.NewGameVer
        Label5.Text = My.Settings.Folder
    End Sub
End Class