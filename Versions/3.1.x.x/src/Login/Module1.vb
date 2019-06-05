Module Module1

    Sub Main()
        Dim SourcePath As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim Filename As String = System.IO.Path.GetFileName(SourcePath) 'get the filename of the original file without the directory on it

        If System.IO.File.Exists(SourcePath) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "login"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            Console.WriteLine("Error: Butler.exe is missing, cannot preform update. (0x1)")
            Console.Write("Press any key to continue . . . ")
            Console.ReadKey(True)
            End
        End If
    End Sub

End Module
