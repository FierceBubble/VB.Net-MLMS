<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPersonalInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPersonalInfo))
        Me.SaveEdit = New System.Windows.Forms.Button()
        Me.EditDOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditCPasswordBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditPasswordBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EditFemaleRButton = New System.Windows.Forms.RadioButton()
        Me.EditMaleRButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EditLNameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditFNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditIDBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordSOH = New FontAwesome.Sharp.IconPictureBox()
        Me.CancelButton1 = New FontAwesome.Sharp.IconButton()
        Me.ExclamationIcon4 = New FontAwesome.Sharp.IconPictureBox()
        Me.pickgender = New System.Windows.Forms.Label()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.ExclamationIcon6 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon5 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon3 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon2 = New FontAwesome.Sharp.IconPictureBox()
        Me.ExclamationIcon1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveEdit
        '
        Me.SaveEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveEdit.Location = New System.Drawing.Point(118, 557)
        Me.SaveEdit.Name = "SaveEdit"
        Me.SaveEdit.Size = New System.Drawing.Size(127, 29)
        Me.SaveEdit.TabIndex = 29
        Me.SaveEdit.Text = "Save Changes"
        Me.SaveEdit.UseVisualStyleBackColor = True
        '
        'EditDOBPicker
        '
        Me.EditDOBPicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditDOBPicker.CustomFormat = "yyyyy-MM-dd"
        Me.EditDOBPicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EditDOBPicker.Location = New System.Drawing.Point(105, 366)
        Me.EditDOBPicker.Name = "EditDOBPicker"
        Me.EditDOBPicker.Size = New System.Drawing.Size(151, 22)
        Me.EditDOBPicker.TabIndex = 25
        Me.EditDOBPicker.Value = New Date(2020, 7, 22, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(102, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Confirm Password :"
        '
        'EditCPasswordBox
        '
        Me.EditCPasswordBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCPasswordBox.Location = New System.Drawing.Point(104, 491)
        Me.EditCPasswordBox.Name = "EditCPasswordBox"
        Me.EditCPasswordBox.Size = New System.Drawing.Size(152, 22)
        Me.EditCPasswordBox.TabIndex = 28
        Me.EditCPasswordBox.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Password :"
        '
        'EditPasswordBox
        '
        Me.EditPasswordBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditPasswordBox.Location = New System.Drawing.Point(104, 426)
        Me.EditPasswordBox.Name = "EditPasswordBox"
        Me.EditPasswordBox.Size = New System.Drawing.Size(152, 22)
        Me.EditPasswordBox.TabIndex = 26
        Me.EditPasswordBox.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Date of Birth :"
        '
        'EditFemaleRButton
        '
        Me.EditFemaleRButton.AutoSize = True
        Me.EditFemaleRButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditFemaleRButton.Location = New System.Drawing.Point(174, 311)
        Me.EditFemaleRButton.Name = "EditFemaleRButton"
        Me.EditFemaleRButton.Size = New System.Drawing.Size(61, 17)
        Me.EditFemaleRButton.TabIndex = 23
        Me.EditFemaleRButton.TabStop = True
        Me.EditFemaleRButton.Text = "Female"
        Me.EditFemaleRButton.UseVisualStyleBackColor = True
        '
        'EditMaleRButton
        '
        Me.EditMaleRButton.AutoSize = True
        Me.EditMaleRButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMaleRButton.Location = New System.Drawing.Point(105, 311)
        Me.EditMaleRButton.Name = "EditMaleRButton"
        Me.EditMaleRButton.Size = New System.Drawing.Size(50, 17)
        Me.EditMaleRButton.TabIndex = 22
        Me.EditMaleRButton.TabStop = True
        Me.EditMaleRButton.Text = "Male"
        Me.EditMaleRButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Gender :"
        '
        'EditLNameBox
        '
        Me.EditLNameBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditLNameBox.Location = New System.Drawing.Point(105, 248)
        Me.EditLNameBox.Name = "EditLNameBox"
        Me.EditLNameBox.ReadOnly = True
        Me.EditLNameBox.Size = New System.Drawing.Size(151, 22)
        Me.EditLNameBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Last Name :"
        '
        'EditFNameBox
        '
        Me.EditFNameBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditFNameBox.Location = New System.Drawing.Point(105, 176)
        Me.EditFNameBox.Name = "EditFNameBox"
        Me.EditFNameBox.ReadOnly = True
        Me.EditFNameBox.Size = New System.Drawing.Size(151, 22)
        Me.EditFNameBox.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "First Name :"
        '
        'EditIDBox
        '
        Me.EditIDBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditIDBox.Location = New System.Drawing.Point(105, 114)
        Me.EditIDBox.Name = "EditIDBox"
        Me.EditIDBox.Size = New System.Drawing.Size(151, 22)
        Me.EditIDBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Customer ID :"
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
        Me.PasswordSOH.TabIndex = 37
        Me.PasswordSOH.TabStop = False
        '
        'CancelButton1
        '
        Me.CancelButton1.BackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.FlatAppearance.BorderSize = 0
        Me.CancelButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CancelButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CancelButton1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.CancelButton1.IconColor = System.Drawing.Color.Gray
        Me.CancelButton1.IconSize = 35
        Me.CancelButton1.Location = New System.Drawing.Point(300, 29)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Rotation = 0R
        Me.CancelButton1.Size = New System.Drawing.Size(46, 49)
        Me.CancelButton1.TabIndex = 38
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CancelButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CancelButton1.UseVisualStyleBackColor = False
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
        Me.ExclamationIcon4.TabIndex = 55
        Me.ExclamationIcon4.TabStop = False
        Me.ExclamationIcon4.Visible = False
        '
        'pickgender
        '
        Me.pickgender.AutoSize = True
        Me.pickgender.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickgender.ForeColor = System.Drawing.Color.DarkRed
        Me.pickgender.Location = New System.Drawing.Point(156, 296)
        Me.pickgender.Name = "pickgender"
        Me.pickgender.Size = New System.Drawing.Size(59, 12)
        Me.pickgender.TabIndex = 54
        Me.pickgender.Text = "* Pick gender!"
        Me.pickgender.Visible = False
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrongLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.WrongLabel.Location = New System.Drawing.Point(103, 514)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(118, 12)
        Me.WrongLabel.TabIndex = 53
        Me.WrongLabel.Text = "* Please fill your information!"
        Me.WrongLabel.Visible = False
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
        Me.ExclamationIcon6.TabIndex = 52
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
        Me.ExclamationIcon5.TabIndex = 51
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
        Me.ExclamationIcon3.TabIndex = 50
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
        Me.ExclamationIcon2.TabIndex = 49
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
        Me.ExclamationIcon1.TabIndex = 48
        Me.ExclamationIcon1.TabStop = False
        Me.ExclamationIcon1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(77, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(79, 62)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 57
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
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'EditPersonalInfo
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
        Me.Controls.Add(Me.CancelButton1)
        Me.Controls.Add(Me.PasswordSOH)
        Me.Controls.Add(Me.EditDOBPicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EditCPasswordBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EditPasswordBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EditFemaleRButton)
        Me.Controls.Add(Me.EditMaleRButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EditLNameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EditFNameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EditIDBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveEdit)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditPersonalInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Personal Info"
        CType(Me.PasswordSOH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveEdit As Button
    Friend WithEvents EditDOBPicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents EditCPasswordBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EditPasswordBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EditFemaleRButton As RadioButton
    Friend WithEvents EditMaleRButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents EditLNameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EditFNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EditIDBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordSOH As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents CancelButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ExclamationIcon4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pickgender As Label
    Friend WithEvents WrongLabel As Label
    Friend WithEvents ExclamationIcon6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ExclamationIcon1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
