Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SourcePathButler As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameButler As String = System.IO.Path.GetFileName(SourcePathButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathButler) Then

        Else
            MessageBox.Show("You seem to be missing butler.exe. You can still work in the app, you cannot update your games however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then

        Else
            MessageBox.Show("You seem to be missing Update Butler.exe. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePath7zip As String = "7z.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim Filename7zip As String = System.IO.Path.GetFileName(SourcePath7zip) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePath7zip) Then

        Else
            MessageBox.Show("You seem to be missing 7z.dll. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim SourcePathc7 As String = "c7zip.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim Filename As String = System.IO.Path.GetFileName(SourcePathc7) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathc7) Then

        Else
            MessageBox.Show("You seem to be missing c7zip.dll. You can still work in the app, you cannot update Butler however.", "Error: File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If My.Settings.DarkTheme = "off" Then

        ElseIf My.Settings.DarkTheme = "on" Then
            Me.BackColor = Color.DimGray
            Me.ForeColor = Color.White
            Settings_Btn.BackColor = Color.DimGray
        Else
            'Do Nothing
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
