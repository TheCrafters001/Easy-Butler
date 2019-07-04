Imports System.Threading

Module Module1

    Sub Main()
        Console.WriteLine("=========================")
        Console.WriteLine("|      EASY BUTLER      |")
        Console.WriteLine("|   By TheCrafters001   |")
        Console.WriteLine("=========================")
        Console.WriteLine("Hello. Welcome to Easy Butler.")
        Console.WriteLine("This guide should help you though the")
        Console.WriteLine("process of updating your game!")
        Console.WriteLine("")
        Console.WriteLine("Let's Start!")
        Console.WriteLine("Please wait... Preparing Butler...")
        Console.Title = "Please wait..."
        Thread.Sleep(5000)
        Console.Clear()
        Console.Title = "Main Menu"
        Console.WriteLine("=========================")
        Console.WriteLine("|       MAIN MENU       |")
        Console.WriteLine("=========================")
        Console.WriteLine("What would you like to do?")
        Console.WriteLine("1. Update Game")
        Console.WriteLine("2. Check Status of Game")
        Console.WriteLine("3. Logout")
        Console.WriteLine("4. Exit")
        Console.WriteLine("Please enter a number: ")
        Dim selectoption As Integer = Console.ReadLine()


        'Check if Number is in the list
        If selectoption = 1 Then
            Console.Clear()
            Update()
        ElseIf selectoption = 2 Then
            Console.Clear()
            Status()
        ElseIf selectoption = 3 Then
            Console.Clear()
            Logout()
        ElseIf selectoption = 4 Then
            Environment.Exit(0)
        Else
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("ERROR: Not a number in the list/not a number.")
            Console.WriteLine("Press any button to restart...")
            Console.ReadLine()
            Console.Clear()
            Main()
        End If

    End Sub

    Sub Logout()
        Console.WriteLine("Are you sure you want to logout?")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")
        Console.WriteLine("Enter a number:")
        Dim choice As String = Console.ReadLine()
        If choice = 1 Then
            Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathLogin) Then
                Using compiler As New Process()
                    compiler.StartInfo.FileName = "butler.exe"
                    compiler.StartInfo.Arguments = "--assume-yes logout"
                    compiler.StartInfo.UseShellExecute = False
                    compiler.StartInfo.RedirectStandardOutput = True
                    compiler.Start()

                    Console.WriteLine(compiler.StandardOutput.ReadToEnd())

                    compiler.WaitForExit()
                End Using
            Else
                Console.WriteLine("Failed to login. Butler is missing!")
                Console.WriteLine("Press any key to exit...")
                Console.ReadLine()
                Environment.Exit(0)
            End If
            Console.WriteLine("Press any key...")
            Console.ReadLine()
            Main()
        ElseIf choice = 2 Then
            Console.Clear()
            Main()
        Else
            Console.WriteLine("Sorry. That was not an option, I will take you to the main menu.")
            Main()
        End If
    End Sub

    Sub Status()
        Console.Title = "Check Status of game."
        Console.Clear()
        Console.WriteLine("Let's get you your game status!")
        Console.WriteLine("First, I need your username: ")
        Dim username As String = Console.ReadLine
        Console.Clear()
        Console.WriteLine("Now, please enter the game URL you want:")
        Console.Write(username + ".itch.io/")
        Dim gameurl As String = Console.ReadLine()
        Console.WriteLine("Okay, I will check if you are logged in.")
        Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Using compiler As New Process()
                compiler.StartInfo.FileName = "butler.exe"
                compiler.StartInfo.Arguments = "login"
                compiler.StartInfo.UseShellExecute = False
                compiler.StartInfo.RedirectStandardOutput = True
                compiler.Start()

                Console.WriteLine(compiler.StandardOutput.ReadToEnd())

                compiler.WaitForExit()
            End Using
        Else
            Console.WriteLine("Failed to login. Butler is missing!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadLine()
            Environment.Exit(0)
        End If
        Console.WriteLine("Okay, please wait...")

        ' STATUS CHECK

        Console.WriteLine("butler status " + username + "/" + gameurl)
        Dim SourcePathLogin2 As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate2 As String = System.IO.Path.GetFileName(SourcePathLogin2) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin2) Then
            Using compiler As New Process()
                compiler.StartInfo.FileName = "butler.exe"
                compiler.StartInfo.Arguments = "status " + username + "/" + gameurl
                compiler.StartInfo.UseShellExecute = False
                compiler.StartInfo.RedirectStandardOutput = True
                compiler.Start()

                Console.WriteLine(compiler.StandardOutput.ReadToEnd())

                compiler.WaitForExit()
            End Using
        Else
            Console.WriteLine("Failed to login. Butler is missing!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadLine()
            Environment.Exit(0)
        End If
        Console.WriteLine("Press any key...")
        Console.ReadLine()
        Main()
    End Sub

    Sub Update()
        Console.WriteLine("Okay. First, let me log you into Butler.")
        Console.Title = "Update game"

        'Login to Butler

        Dim SourcePathLogin As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathLogin) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathLogin) Then
            Using compiler As New Process()
                compiler.StartInfo.FileName = "butler.exe"
                compiler.StartInfo.Arguments = "login"
                compiler.StartInfo.UseShellExecute = False
                compiler.StartInfo.RedirectStandardOutput = True
                compiler.Start()

                Console.WriteLine(compiler.StandardOutput.ReadToEnd())

                compiler.WaitForExit()
            End Using
        Else
            Console.WriteLine("Failed to login. Butler is missing!")
            Console.WriteLine("Press any key to exit...")
            Console.ReadLine()
            Environment.Exit(0)
        End If
        Console.WriteLine("Okay. Let's move on.")

        'Get Username

        Console.WriteLine("Please enter your Itch.IO Username: ")
        Dim username As String = Console.ReadLine()
        Console.WriteLine("Alright, " + username + ", let's move on.")
        Thread.Sleep(3000)
        Console.Clear()

        'Get Game URL

        Console.WriteLine("Please enter the game URL you are using.")
        Console.Write(vbCrLf + username + ".itch.io/")
        Dim url As String = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Good!")
        Thread.Sleep(3000)
        Console.Clear()

        'Get Folder Path

        Console.WriteLine("Please enter a direct folder (not file) path: ")
        Console.WriteLine("(Drag and drop is supported, just remove the quotes on both ends)")
        Dim folder As String = Console.ReadLine()
        Console.Clear()

        'Get OS

        Console.WriteLine("Please enter the OS you are publishing to.")
        Console.WriteLine("Options: win, windows, mac, osx, linux, android")
        Console.WriteLine("(You may have multiple options, like: win-linux-mac)")
        Dim os As String = Console.ReadLine()
        Console.Clear()

        'Get Version

        Console.WriteLine("Please enter the new version of your game.")
        Dim version As String = Console.ReadLine()

        ' Get ready to update game.

        Console.Clear()
        Console.WriteLine("Okay, " + username + ", I got the following info from you.")
        Console.WriteLine("Username: " + username)
        Console.WriteLine("Game URL: " + url)
        Console.WriteLine("Folder: " + folder)
        Console.WriteLine("OS: " + os)
        Console.WriteLine("Version: " + version)

        Console.WriteLine("Is this correct?")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")

        Console.Write("Please enter a number: ")
        Dim correct As Integer = Console.ReadLine()


        If correct = 1 Then
            Console.Clear()
            Console.WriteLine("Please wait...")
            Console.WriteLine("You will see some code. Do not be alarmed. This is normal.")

            Console.WriteLine("IT WILL LOOK LIKE THE WINDOW IS FROZEN. DO NOT CLOSE THIS WINDOW.")
            Console.WriteLine("WAIT UNTIL IT SAYS THAT IT IS DONE, THE FOLLOW THE ON-SCREEN ")
            Console.WriteLine("INSTRUCTIONS.")

            Thread.Sleep(5000)
            Console.WriteLine("")
            Console.WriteLine("butler push """ + folder + """ " + username + "/" + url + ":" + os + " --userversion " + version)
            Dim SourcePathUpdateButler As String = "butler.exe" 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            Dim FilenameUpdate2 As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
            If System.IO.File.Exists(SourcePathUpdateButler) Then
                Using compiler As New Process()
                    compiler.StartInfo.FileName = "butler.exe"
                    compiler.StartInfo.Arguments = "push """ + folder + """ " + username + "/" + url + ":" + os + " --userversion " + version
                    compiler.StartInfo.UseShellExecute = False
                    compiler.StartInfo.RedirectStandardOutput = True
                    compiler.Start()

                    Console.WriteLine(compiler.StandardOutput.ReadToEnd())

                    compiler.WaitForExit()
                End Using
            Else
                Console.WriteLine("Failed to update your game. 'butler.exe' is missing.")
                Console.WriteLine("Press any key to exit...")
                Console.ReadLine()
                Environment.Exit(0)
            End If
            Console.WriteLine("Above, you should see what happened.")
            Console.WriteLine("Read carfully, then press any key.")
            Console.ReadLine()
            Main()
        Else
            Console.WriteLine("Restarting...")
            Thread.Sleep(2000)
            Main()
        End If
    End Sub

End Module
