<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TopUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TopUpForm))
        Me.TopUp10 = New System.Windows.Forms.RadioButton()
        Me.TopUp20 = New System.Windows.Forms.RadioButton()
        Me.TopUp50 = New System.Windows.Forms.RadioButton()
        Me.TopUp30 = New System.Windows.Forms.RadioButton()
        Me.OtherValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerIDBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackButton = New FontAwesome.Sharp.IconPictureBox()
        Me.ConfirmTopUp = New FontAwesome.Sharp.IconButton()
        Me.WrongLabel = New System.Windows.Forms.Label()
        Me.ExclamationIcon2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopUp10
        '
        Me.TopUp10.Appearance = System.Windows.Forms.Appearance.Button
        Me.TopUp10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TopUp10.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopUp10.Location = New System.Drawing.Point(12, 178)
        Me.TopUp10.Name = "TopUp10"
        Me.TopUp10.Size = New System.Drawing.Size(160, 97)
        Me.TopUp10.TabIndex = 0
        Me.TopUp10.TabStop = True
        Me.TopUp10.Text = "10"
        Me.TopUp10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TopUp10.UseVisualStyleBackColor = True
        '
        'TopUp20
        '
        Me.TopUp20.Appearance = System.Windows.Forms.Appearance.Button
        Me.TopUp20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TopUp20.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.TopUp20.Location = New System.Drawing.Point(187, 178)
        Me.TopUp20.Name = "TopUp20"
        Me.TopUp20.Size = New System.Drawing.Size(160, 97)
        Me.TopUp20.TabIndex = 1
        Me.TopUp20.TabStop = True
        Me.TopUp20.Text = "20"
        Me.TopUp20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TopUp20.UseVisualStyleBackColor = True
        '
        'TopUp50
        '
        Me.TopUp50.Appearance = System.Windows.Forms.Appearance.Button
        Me.TopUp50.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TopUp50.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.TopUp50.Location = New System.Drawing.Point(187, 281)
        Me.TopUp50.Name = "TopUp50"
        Me.TopUp50.Size = New System.Drawing.Size(160, 97)
        Me.TopUp50.TabIndex = 3
        Me.TopUp50.TabStop = True
        Me.TopUp50.Text = "50"
        Me.TopUp50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TopUp50.UseVisualStyleBackColor = True
        '
        'TopUp30
        '
        Me.TopUp30.Appearance = System.Windows.Forms.Appearance.Button
        Me.TopUp30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TopUp30.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.TopUp30.Location = New System.Drawing.Point(12, 281)
        Me.TopUp30.Name = "TopUp30"
        Me.TopUp30.Size = New System.Drawing.Size(160, 97)
        Me.TopUp30.TabIndex = 2
        Me.TopUp30.TabStop = True
        Me.TopUp30.Text = "30"
        Me.TopUp30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TopUp30.UseVisualStyleBackColor = True
        '
        'OtherValue
        '
        Me.OtherValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherValue.Location = New System.Drawing.Point(167, 403)
        Me.OtherValue.Name = "OtherValue"
        Me.OtherValue.Size = New System.Drawing.Size(31, 22)
        Me.OtherValue.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Other value:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 60)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Customer's Credit Balance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Top-Up"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Customer Account ID:"
        '
        'CustomerIDBox
        '
        Me.CustomerIDBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDBox.Location = New System.Drawing.Point(167, 431)
        Me.CustomerIDBox.Name = "CustomerIDBox"
        Me.CustomerIDBox.Size = New System.Drawing.Size(140, 22)
        Me.CustomerIDBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(201, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "(Whole number)"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.ForeColor = System.Drawing.Color.Gray
        Me.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.BackButton.IconColor = System.Drawing.Color.Gray
        Me.BackButton.IconSize = 35
        Me.BackButton.Location = New System.Drawing.Point(301, 37)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 36
        Me.BackButton.TabStop = False
        '
        'ConfirmTopUp
        '
        Me.ConfirmTopUp.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ConfirmTopUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmTopUp.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ConfirmTopUp.IconColor = System.Drawing.Color.Black
        Me.ConfirmTopUp.IconSize = 16
        Me.ConfirmTopUp.Location = New System.Drawing.Point(108, 498)
        Me.ConfirmTopUp.Name = "ConfirmTopUp"
        Me.ConfirmTopUp.Rotation = 0R
        Me.ConfirmTopUp.Size = New System.Drawing.Size(140, 34)
        Me.ConfirmTopUp.TabIndex = 6
        Me.ConfirmTopUp.Text = "Confirm"
        Me.ConfirmTopUp.UseVisualStyleBackColor = True
        '
        'WrongLabel
        '
        Me.WrongLabel.AutoSize = True
        Me.WrongLabel.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrongLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.WrongLabel.Location = New System.Drawing.Point(106, 483)
        Me.WrongLabel.Name = "WrongLabel"
        Me.WrongLabel.Size = New System.Drawing.Size(145, 12)
        Me.WrongLabel.TabIndex = 91
        Me.WrongLabel.Text = "* Please fill the customer account ID"
        Me.WrongLabel.Visible = False
        '
        'ExclamationIcon2
        '
        Me.ExclamationIcon2.BackColor = System.Drawing.Color.Transparent
        Me.ExclamationIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExclamationIcon2.ForeColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.ExclamationIcon2.IconColor = System.Drawing.Color.DarkRed
        Me.ExclamationIcon2.IconSize = 18
        Me.ExclamationIcon2.Location = New System.Drawing.Point(312, 435)
        Me.ExclamationIcon2.Margin = New System.Windows.Forms.Padding(0)
        Me.ExclamationIcon2.MaximumSize = New System.Drawing.Size(30, 30)
        Me.ExclamationIcon2.Name = "ExclamationIcon2"
        Me.ExclamationIcon2.Size = New System.Drawing.Size(21, 18)
        Me.ExclamationIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ExclamationIcon2.TabIndex = 90
        Me.ExclamationIcon2.TabStop = False
        Me.ExclamationIcon2.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(77, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 21)
        Me.Label20.TabIndex = 167
        Me.Label20.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(79, 58)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 166
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(37, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 165
        Me.PictureBox1.TabStop = False
        '
        'TopUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.WrongLabel)
        Me.Controls.Add(Me.ExclamationIcon2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomerIDBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ConfirmTopUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OtherValue)
        Me.Controls.Add(Me.TopUp50)
        Me.Controls.Add(Me.TopUp30)
        Me.Controls.Add(Me.TopUp20)
        Me.Controls.Add(Me.TopUp10)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TopUpForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Top-Up Form"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExclamationIcon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopUp10 As RadioButton
    Friend WithEvents TopUp20 As RadioButton
    Friend WithEvents TopUp50 As RadioButton
    Friend WithEvents TopUp30 As RadioButton
    Friend WithEvents OtherValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ConfirmTopUp As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BackButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CustomerIDBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WrongLabel As Label
    Friend WithEvents ExclamationIcon2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
