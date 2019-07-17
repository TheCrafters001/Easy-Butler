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
        Me.Username = New System.Windows.Forms.Label()
        Me.GameURL = New System.Windows.Forms.Label()
        Me.Folder = New System.Windows.Forms.Label()
        Me.OS = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(12, 70)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 3
        Me.Username.Text = "Username"
        '
        'GameURL
        '
        Me.GameURL.AutoSize = True
        Me.GameURL.Location = New System.Drawing.Point(12, 96)
        Me.GameURL.Name = "GameURL"
        Me.GameURL.Size = New System.Drawing.Size(60, 13)
        Me.GameURL.TabIndex = 4
        Me.GameURL.Text = "Game URL"
        '
        'Folder
        '
        Me.Folder.AutoSize = True
        Me.Folder.Location = New System.Drawing.Point(12, 122)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(36, 13)
        Me.Folder.TabIndex = 5
        Me.Folder.Text = "Folder"
        '
        'OS
        '
        Me.OS.AutoSize = True
        Me.OS.Location = New System.Drawing.Point(12, 148)
        Me.OS.Name = "OS"
        Me.OS.Size = New System.Drawing.Size(22, 13)
        Me.OS.TabIndex = 6
        Me.OS.Text = "OS"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Location = New System.Drawing.Point(12, 174)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(42, 13)
        Me.Version.TabIndex = 7
        Me.Version.Text = "Version"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(444, 20)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(439, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(54, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(430, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(60, 171)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(457, 20)
        Me.TextBox5.TabIndex = 12
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
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"windows", "linux", "mac", "android"})
        Me.ComboBox1.Location = New System.Drawing.Point(40, 145)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(477, 21)
        Me.ComboBox1.TabIndex = 16
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
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.OS)
        Me.Controls.Add(Me.Folder)
        Me.Controls.Add(Me.GameURL)
        Me.Controls.Add(Me.Username)
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
    Friend WithEvents Username As Label
    Friend WithEvents GameURL As Label
    Friend WithEvents Folder As Label
    Friend WithEvents OS As Label
    Friend WithEvents Version As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
