Public Class page9
    Private Sub Page9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
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
        Dim error_string As String = 0
        ProgressBar1.Increment(25)
        If ProgressBar1.Value = "100" Then
            Dim SourcePathButler As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameButler As String = System.IO.Path.GetFileName(SourcePathButler) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathButler) Then

            Else
                error_string = 1
            End If
            Dim SourcePathUpdateButler As String = "Update Butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathUpdateButler) Then

            Else
                error_string = 1
            End If
            Dim SourcePath7zip As String = "7z.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim Filename7zip As String = System.IO.Path.GetFileName(SourcePath7zip) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePath7zip) Then

            Else
                error_string = 1
            End If
            Dim SourcePathc7 As String = "c7zip.dll" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim Filename As String = System.IO.Path.GetFileName(SourcePathc7) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathc7) Then

            Else
                error_string = 1
            End If
            If error_string = 1 Then
                end_failed.Show()
                Me.Close()
            Else

                Label4.Text = "Gathering required update information..."
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(5)
        If ProgressBar2.Value = 100 Then
            page10.Show()
            Me.Close()
        End If
    End Sub
End Class