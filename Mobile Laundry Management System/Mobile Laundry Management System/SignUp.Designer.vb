<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.FNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LNameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaleRButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRButton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CPasswordBox = New System.Windows.Forms.TextBox()
        Me.SignUpButton = New System.Windows.Forms.Button()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.pickgender = New System.Windows.Forms.Label()
        Me.ExclamationIcon4 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon6 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon5 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon3 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon2 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon1 = New FontAwesome.Sharp.IconPictureBox()
        Me.CancelButton2 = New FontAwesome.Sharp.IconButton()
        Me.PasswordSOH = New FontAwesome.Sharp.IconPictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ExclamationIcon4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create an ID :"
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(105, 114)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(151, 22)
        Me.IDBox.TabIndex = 1
        '
        'FNameBox
        '
        Me.FNameBox.Location = New System.Drawing.Point(105, 176)
        Me.FNameBox.Name = "FNameBox"
        Me.FNameBox.Size = New System.Drawing.Size(151, 22)
        Me.FNameBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name :"
        '
        'LNameBox
        '
        Me.LNameBox.Location = New System.Drawing.Point(105, 248)
        Me.LNameBox.Name = "LNameBox"
        Me.LNameBox.Size = New System.Drawing.Size(151, 22)
        Me.LNameBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(102, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender :"
        '
        'MaleRButton
        '
        Me.MaleRButton.AutoSize = True
        Me.MaleRButton.Location = New System.Drawing.Point(105, 311)
        Me.MaleRButton.Name = "MaleRButton"
        Me.MaleRButton.Size = New System.Drawing.Size(50, 17)
        Me.MaleRButton.TabIndex = 7
        Me.MaleRButton.TabStop = True
        Me.MaleRButton.Text = "Male"
        Me.MaleRButton.UseVisualStyleBackColor = True
        '
        'FemaleRButton
        '
        Me.FemaleRButton.AutoSize = True
        Me.FemaleRButton.Location = New System.Drawing.Point(174, 311)
        Me.FemaleRButton.Name = "FemaleRButton"
        Me.FemaleRButton.Size = New System.Drawing.Size(61, 17)
        Me.FemaleRButton.TabIndex = 8
        Me.FemaleRButton.TabStop = True
        Me.FemaleRButton.Text = "Female"
        Me.FemaleRButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date of Birth :"
        '
        'PasswordBox
        '
        Me.PasswordBox.Location = New System.Drawing.Point(104, 426)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(152, 22)
        Me.PasswordBox.TabIndex = 11
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Password :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Confirm Password :"
        '
        'CPasswordBox
        '
        Me.CPasswordBox.Location = New System.Drawing.Point(104, 491)
        Me.CPasswordBox.Name = "CPasswordBox"
        Me.CPasswordBox.Size = New System.Drawing.Size(152, 22)
        Me.CPasswordBox.TabIndex = 13
        Me.CPasswordBox.UseSystemPasswordChar = True
        '
        'SignUpButton
        '
        Me.SignUpButton.Location = New System.Drawing.Point(118, 557)
        Me.SignUpButton.Name = "SignUpButton"
        Me.SignUpButton.Size = New System.Drawing.Size(127, 29)
        Me.SignUpButton.TabIndex = 15
        Me.SignUpButton.Text = "Sign-Up"
        Me.SignUpButton.UseVisualStyleBackColor = True
        '
        'DOBPicker
        '
        Me.DOBPicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOBPicker.CustomFormat = "yyyyy-MM-dd"
        Me.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOBPicker.Location = New System.Drawing.Point(105, 366)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(151, 22)
        Me.DOBPicker.TabIndex = 10
        Me.DOBPicker.Value = New Date(2020, 7, 22, 0, 0, 0, 0)
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrongLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.WrongLabel.Location = New System.Drawing.Point(103, 514)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(118, 12)
        Me.WrongLabel.TabIndex = 45
        Me.WrongLabel.Text = "* Please fill your information!"
        Me.WrongLabel.Visible = False
        '
        'pickgender
        '
        Me.pickgender.AutoSize = True
        Me.pickgender.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickgender.ForeColor = System.Drawing.Color.DarkRed
        Me.pickgender.Location = New System.Drawing.Point(156, 296)
        Me.pickgender.Name = "pickgender"
        Me.pickgender.Size = New System.Drawing.Size(59, 12)
        Me.pickgender.TabIndex = 46
        Me.pickgender.Text = "* Pick gender!"
        Me.pickgender.Visible = False
        '
        'ExclamationIcon4
        '
        Me.ExclamationIcon4.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon4.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon4.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon4.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon4.IconSize = 18
        Me.ExclamationIcon4.Location = New System.Drawing.Point(259, 370)
        Me.ExclamationIcon4.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon4.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon4.Name = "ExclamationIcon4"
        Me.ExclamationIcon4.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon4.TabIndex = 47
        Me.ExclamationIcon4.TabStop = False
        Me.ExclamationIcon4.Visible = False
        '
        'ExclamationIcon6
        '
        Me.ExclamationIcon6.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon6.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon6.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon6.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon6.IconSize = 18
        Me.ExclamationIcon6.Location = New System.Drawing.Point(259, 495)
        Me.ExclamationIcon6.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon6.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon6.Name = "ExclamationIcon6"
        Me.ExclamationIcon6.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon6.TabIndex = 44
        Me.ExclamationIcon6.TabStop = False
        Me.ExclamationIcon6.Visible = False
        '
        'ExclamationIcon5
        '
        Me.ExclamationIcon5.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon5.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon5.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon5.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon5.IconSize = 18
        Me.ExclamationIcon5.Location = New System.Drawing.Point(280, 430)
        Me.ExclamationIcon5.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon5.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon5.Name = "ExclamationIcon5"
        Me.ExclamationIcon5.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon5.TabIndex = 43
        Me.ExclamationIcon5.TabStop = False
        Me.ExclamationIcon5.Visible = False
        '
        'ExclamationIcon3
        '
        Me.ExclamationIcon3.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon3.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon3.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon3.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon3.IconSize = 18
        Me.ExclamationIcon3.Location = New System.Drawing.Point(259, 252)
        Me.ExclamationIcon3.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon3.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon3.Name = "ExclamationIcon3"
        Me.ExclamationIcon3.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon3.TabIndex = 42
        Me.ExclamationIcon3.TabStop = False
        Me.ExclamationIcon3.Visible = False
        '
        'ExclamationIcon2
        '
        Me.ExclamationIcon2.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon2.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon2.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconSize = 18
        Me.ExclamationIcon2.Location = New System.Drawing.Point(259, 180)
        Me.ExclamationIcon2.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon2.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon2.Name = "ExclamationIcon2"
        Me.ExclamationIcon2.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon2.TabIndex = 41
        Me.ExclamationIcon2.TabStop = False
        Me.ExclamationIcon2.Visible = False
        '
        'ExclamationIcon1
        '
        Me.ExclamationIcon1.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon1.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon1.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon1.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon1.IconSize = 18
        Me.ExclamationIcon1.Location = New System.Drawing.Point(259, 118)
        Me.ExclamationIcon1.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon1.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon1.Name = "ExclamationIcon1"
        Me.ExclamationIcon1.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon1.TabIndex = 40
        Me.ExclamationIcon1.TabStop = False
        Me.ExclamationIcon1.Visible = False
        '
        'CancelButton2
        '
        Me.CancelButton2.BackColor = System.Drawing.Color.Transparent
        Me.CancelButton2.FlatAppearance.BorderSize = 0
        Me.CancelButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CancelButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CancelButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CancelButton2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.CancelButton2.IconColor = System.Drawing.Color.Gray
        Me.CancelButton2.IconSize = 35
        Me.CancelButton2.Location = New System.Drawing.Point(300, 29)
        Me.CancelButton2.Name = "CancelButton2"
        Me.CancelButton2.Rotation = 0R
        Me.CancelButton2.Size = New System.Drawing.Size(46, 49)
        Me.CancelButton2.TabIndex = 39
        Me.CancelButton2.Text = "Cancel"
        Me.CancelButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CancelButton2.UseVisualStyleBackColor = False
        '
        'PasswordSOH
        '
        Me.PasswordSOH.BackColor = System.Drawing.Color.White
        Me.PasswordSOH.ForeColor = System.Drawing.Color.Gray
        Me.PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.PasswordSOH.IconColor = System.Drawing.Color.Gray
        Me.PasswordSOH.IconSize = 20
        Me.PasswordSOH.Location = New System.Drawing.Point(259, 428)
        Me.PasswordSOH.Margin = New System.Windows.Forms.Padding(0)
        Me.PasswordSOH.MaximumSize = New System.Drawing.Size(30, 30)
        Me.PasswordSOH.Name = "PasswordSOH"
        Me.PasswordSOH.Size = New System.Drawing.Size(21, 20)
        Me.PasswordSOH.TabIndex = 36
        Me.PasswordSOH.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(79, 62)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 60
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(37, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExclamationIcon4)
        Me.Controls.Add(Me.pickgender)
        Me.Controls.Add(Me.WrongLabel)
        Me.Controls.Add(Me.ExclamationIcon6)
        Me.Controls.Add(Me.ExclamationIcon5)
        Me.Controls.Add(Me.ExclamationIcon3)
        Me.Controls.Add(Me.ExclamationIcon2)
        Me.Controls.Add(Me.ExclamationIcon1)
        Me.Controls.Add(Me.CancelButton2)
        Me.Controls.Add(Me.PasswordSOH)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.SignUpButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CPasswordBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FemaleRButton)
        Me.Controls.Add(Me.MaleRButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LNameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FNameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign-Up"
        CType(Me.ExclamationIcon4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IDBox As TextBox
    Friend WithEvents FNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LNameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaleRButton As RadioButton
    Friend WithEvents FemaleRButton As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CPasswordBox As TextBox
    Friend WithEvents SignUpButton As Button
    Friend WithEvents DOBPicker As DateTimePicker
    Friend WithEvents PasswordSOH As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents CancelButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents ExclamationIcon1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents WrongLabel As Label
    Friend WithEvents pickgender As Label
    Friend WithEvents ExclamationIcon4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
