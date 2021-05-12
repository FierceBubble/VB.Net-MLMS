<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.signinButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.signupButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PowerButton = New FontAwesome.Sharp.IconPictureBox()
        Me.PasswordSOH = New FontAwesome.Sharp.IconPictureBox()
        Me.IconName = New System.Windows.Forms.Label()
        Me.ExclamationIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon2 = New FontAwesome.Sharp.IconPictureBox()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        '
        'id
        '
        Me.id.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.Location = New System.Drawing.Point(97, 232)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(163, 22)
        Me.id.TabIndex = 3
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(97, 300)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(163, 22)
        Me.password.TabIndex = 4
        Me.password.UseSystemPasswordChar = True
        '
        'signinButton
        '
        Me.signinButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinButton.Location = New System.Drawing.Point(112, 387)
        Me.signinButton.Name = "signinButton"
        Me.signinButton.Size = New System.Drawing.Size(127, 29)
        Me.signinButton.TabIndex = 5
        Me.signinButton.Text = "Sign-In"
        Me.signinButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label3.Location = New System.Drawing.Point(58, 469)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "---------------------------Or------------------------------"
        '
        'signupButton
        '
        Me.signupButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupButton.Location = New System.Drawing.Point(112, 547)
        Me.signupButton.Name = "signupButton"
        Me.signupButton.Size = New System.Drawing.Size(127, 29)
        Me.signupButton.TabIndex = 6
        Me.signupButton.Text = "Sign-Up"
        Me.signupButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(149, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'PowerButton
        '
        Me.PowerButton.BackColor = System.Drawing.Color.White
        Me.PowerButton.ForeColor = System.Drawing.Color.Gray
        Me.PowerButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.PowerButton.IconColor = System.Drawing.Color.Gray
        Me.PowerButton.IconSize = 35
        Me.PowerButton.Location = New System.Drawing.Point(301, 50)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(32, 32)
        Me.PowerButton.TabIndex = 35
        Me.PowerButton.TabStop = False
        '
        'PasswordSOH
        '
        Me.PasswordSOH.BackColor = System.Drawing.Color.White
        Me.PasswordSOH.ForeColor = System.Drawing.Color.Gray
        Me.PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.PasswordSOH.IconColor = System.Drawing.Color.Gray
        Me.PasswordSOH.IconSize = 20
        Me.PasswordSOH.Location = New System.Drawing.Point(263, 303)
        Me.PasswordSOH.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordSOH.MaximumSize = New System.Drawing.Size(30, 30)
        Me.PasswordSOH.Name = "PasswordSOH"
        Me.PasswordSOH.Size = New System.Drawing.Size(21, 20)
        Me.PasswordSOH.TabIndex = 34
        Me.PasswordSOH.TabStop = False
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(33, 169)
        Me.IconName.MinimumSize = New System.Drawing.Size(300, 0)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(300, 13)
        Me.IconName.TabIndex = 37
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExclamationIcon
        '
        Me.ExclamationIcon.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon.IconSize = 18
        Me.ExclamationIcon.Location = New System.Drawing.Point(237, 234)
        Me.ExclamationIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon.Name = "ExclamationIcon"
        Me.ExclamationIcon.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon.TabIndex = 38
        Me.ExclamationIcon.TabStop = False
        Me.ExclamationIcon.Visible = False
        '
        'ExclamationIcon2
        '
        Me.ExclamationIcon2.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon2.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon2.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconSize = 18
        Me.ExclamationIcon2.Location = New System.Drawing.Point(237, 302)
        Me.ExclamationIcon2.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon2.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon2.Name = "ExclamationIcon2"
        Me.ExclamationIcon2.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon2.TabIndex = 39
        Me.ExclamationIcon2.TabStop = False
        Me.ExclamationIcon2.Visible = False
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrongLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.WrongLabel.Location = New System.Drawing.Point(95, 325)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(118, 12)
        Me.WrongLabel.TabIndex = 40
        Me.WrongLabel.Text = "* Please fill your information!"
        Me.WrongLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 32)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "M.L.M.S"
        '
        'SignIn
        '
        Me.AcceptButton = Me.signinButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WrongLabel)
        Me.Controls.Add(Me.ExclamationIcon2)
        Me.Controls.Add(Me.ExclamationIcon)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.PasswordSOH)
        Me.Controls.Add(Me.signinButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.signupButton)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign-In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents signinButton As Button
    Friend WithEvents signupButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordSOH As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PowerButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconName As Label
    Friend WithEvents ExclamationIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents WrongLabel As Label
    Friend WithEvents Label4 As Label
End Class
