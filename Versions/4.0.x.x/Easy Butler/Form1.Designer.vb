<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Settings_Btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Username_Label = New System.Windows.Forms.Label()
        Me.GameURL_Label = New System.Windows.Forms.Label()
        Me.Folder_Label = New System.Windows.Forms.Label()
        Me.OS_Label = New System.Windows.Forms.Label()
        Me.Version_Label = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.GameURL = New System.Windows.Forms.TextBox()
        Me.Folder = New System.Windows.Forms.TextBox()
        Me.Version = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OS = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Settings_Btn
        '
        Me.Settings_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Settings_Btn.Location = New System.Drawing.Point(12, 255)
        Me.Settings_Btn.Name = "Settings_Btn"
        Me.Settings_Btn.Size = New System.Drawing.Size(505, 23)
        Me.Settings_Btn.TabIndex = 0
        Me.Settings_Btn.Text = "Settings"
        Me.Settings_Btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(505, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(505, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Update Butler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Username_Label
        '
        Me.Username_Label.AutoSize = True
        Me.Username_Label.Location = New System.Drawing.Point(12, 70)
        Me.Username_Label.Name = "Username_Label"
        Me.Username_Label.Size = New System.Drawing.Size(55, 13)
        Me.Username_Label.TabIndex = 3
        Me.Username_Label.Text = "Username"
        '
        'GameURL_Label
        '
        Me.GameURL_Label.AutoSize = True
        Me.GameURL_Label.Location = New System.Drawing.Point(12, 96)
        Me.GameURL_Label.Name = "GameURL_Label"
        Me.GameURL_Label.Size = New System.Drawing.Size(60, 13)
        Me.GameURL_Label.TabIndex = 4
        Me.GameURL_Label.Text = "Game URL"
        '
        'Folder_Label
        '
        Me.Folder_Label.AutoSize = True
        Me.Folder_Label.Location = New System.Drawing.Point(12, 122)
        Me.Folder_Label.Name = "Folder_Label"
        Me.Folder_Label.Size = New System.Drawing.Size(36, 13)
        Me.Folder_Label.TabIndex = 5
        Me.Folder_Label.Text = "Folder"
        '
        'OS_Label
        '
        Me.OS_Label.AutoSize = True
        Me.OS_Label.Location = New System.Drawing.Point(12, 148)
        Me.OS_Label.Name = "OS_Label"
        Me.OS_Label.Size = New System.Drawing.Size(22, 13)
        Me.OS_Label.TabIndex = 6
        Me.OS_Label.Text = "OS"
        '
        'Version_Label
        '
        Me.Version_Label.AutoSize = True
        Me.Version_Label.Location = New System.Drawing.Point(12, 174)
        Me.Version_Label.Name = "Version_Label"
        Me.Version_Label.Size = New System.Drawing.Size(42, 13)
        Me.Version_Label.TabIndex = 7
        Me.Version_Label.Text = "Version"
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(73, 67)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(444, 20)
        Me.Username.TabIndex = 8
        '
        'GameURL
        '
        Me.GameURL.Location = New System.Drawing.Point(78, 93)
        Me.GameURL.Name = "GameURL"
        Me.GameURL.Size = New System.Drawing.Size(439, 20)
        Me.GameURL.TabIndex = 9
        '
        'Folder
        '
        Me.Folder.Location = New System.Drawing.Point(54, 119)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(430, 20)
        Me.Folder.TabIndex = 10
        '
        'Version
        '
        Me.Version.Location = New System.Drawing.Point(60, 171)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(457, 20)
        Me.Version.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(505, 52)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Update Game"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Location = New System.Drawing.Point(12, 284)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(505, 68)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Cancel && Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OS
        '
        Me.OS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OS.FormattingEnabled = True
        Me.OS.Items.AddRange(New Object() {"windows", "linux", "mac", "android"})
        Me.OS.Location = New System.Drawing.Point(40, 145)
        Me.OS.Name = "OS"
        Me.OS.Size = New System.Drawing.Size(477, 21)
        Me.OS.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(490, 117)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(27, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the folder your game is located."
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Button3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button5
        Me.ClientSize = New System.Drawing.Size(529, 364)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.OS)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Folder)
        Me.Controls.Add(Me.GameURL)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Version_Label)
        Me.Controls.Add(Me.OS_Label)
        Me.Controls.Add(Me.Folder_Label)
        Me.Controls.Add(Me.GameURL_Label)
        Me.Controls.Add(Me.Username_Label)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Settings_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(535, 389)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy Butler - By TheCrafters001"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Settings_Btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Username_Label As Label
    Friend WithEvents GameURL_Label As Label
    Friend WithEvents Folder_Label As Label
    Friend WithEvents OS_Label As Label
    Friend WithEvents Version_Label As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents GameURL As TextBox
    Friend WithEvents Folder As TextBox
    Friend WithEvents Version As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents OS As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
