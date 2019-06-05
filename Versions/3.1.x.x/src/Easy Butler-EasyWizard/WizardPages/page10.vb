Public Class page10
    Private Sub Page10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim myCp As CreateParams = MyBase.CreateParams

            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON

            Return myCp

        End Get

    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(25)
        If ProgressBar1.Value = 50 Then
            Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathLogin) Then
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = "butler.exe"
                pHelp.Arguments = "push """ + My.Settings.Folder + """ " + My.Settings.UserName + "/" + My.Settings.GameURL + ":" + My.Settings.OSVer + " --userversion " + My.Settings.NewGameVer
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(pHelp)
            Else
                MessageBox.Show("You seem to be missing butler.exe. You cannot update your game without this file. Please try downloading the latest version of Easy Butler, or download butler manualy from here: https://fasterthanlime.itch.io/butler.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If ProgressBar1.Value = 100 Then
            finished.Show()
            Me.Close()
        End If
    End Sub
End Class