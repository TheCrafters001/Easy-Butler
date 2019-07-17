Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DarkTheme = "off" Then

        ElseIf My.Settings.DarkTheme = "on" Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
            Settings_Btn.BackColor = Color.DimGray
        Else
            'Do Nothing
        End If

        If My.Settings.RememVer = True Then
            Version.Text = My.Settings.Ver
        End If
        If My.Settings.RememUser = True Then
            Username.Text = My.Settings.User
        End If
        If My.Settings.RememURL = True Then
            GameURL.Text = My.Settings.URL
        End If
        If My.Settings.RememOS = True Then
            OS.Text = My.Settings.OS
        End If
        If My.Settings.RememFold = True Then
            Folder.Text = My.Settings.Folder
        End If
    End Sub

    Private Sub Settings_Btn_Click(sender As Object, e As EventArgs) Handles Settings_Btn.Click
        Settings.Show()
        Settings.TopMost = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "login"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("Failed to login. Butler is missing!", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "Update Butler.exe"
            pHelp.Arguments = ""
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Hidden
            Dim proc As Process = Process.Start(pHelp)
        Else
            MessageBox.Show("Failed to launch updater. 'Update Butler.exe' is missing.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim osselect As String
        Dim usernametext As String
        Dim GameURLText As String
        Dim foldertext As String
        Dim versiontext As String

        Try
            osselect = OS.Text
            usernametext = Username.Text
            GameURLText = GameURL.Text
            foldertext = Folder.Text
            versiontext = Version.Text

            If My.Settings.RememFold = True Then
                My.Settings.Folder = foldertext
            End If
            If My.Settings.RememOS = True Then
                My.Settings.OS = osselect
            End If
            If My.Settings.RememURL = True Then
                My.Settings.URL = GameURLText
            End If
            If My.Settings.RememUser = True Then
                My.Settings.User = usernametext
            End If
            If My.Settings.RememVer = True Then
                My.Settings.Ver = versiontext
            End If
            My.Settings.Save()


            Dim SourcePathUpdateButler As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathUpdateButler) Then
                Dim pHelp As New ProcessStartInfo
                pHelp.FileName = "butler.exe"
                pHelp.Arguments = "push """ + foldertext + """ " + usernametext + "/" + GameURLText + ":" + osselect + " --userversion " + versiontext
                pHelp.UseShellExecute = True
                pHelp.WindowStyle = ProcessWindowStyle.Hidden
                Dim proc As Process = Process.Start(pHelp)
            Else
                MessageBox.Show("Failed to update your game. 'butler.exe' is missing.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Something went wrong. \nPlease try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.ShowDialog()
        Folder.Text = FolderBrowserDialog1.SelectedPath()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
