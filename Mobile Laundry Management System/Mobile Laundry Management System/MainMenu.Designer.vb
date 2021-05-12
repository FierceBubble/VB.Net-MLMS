<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.CustomerInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LaundryStatus = New System.Windows.Forms.Label()
        Me.StaffInchargeLabel = New System.Windows.Forms.Label()
        Me.StaffName = New System.Windows.Forms.Label()
        Me.TotalCloth = New System.Windows.Forms.Label()
        Me.TotalClothesLabel = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.RefreshButton = New FontAwesome.Sharp.IconPictureBox()
        Me.MainMenuPictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomerInfoButton = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainMenuPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerInfo
        '
        Me.CustomerInfo.AutoSize = True
        Me.CustomerInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfo.Location = New System.Drawing.Point(73, 128)
        Me.CustomerInfo.Name = "CustomerInfo"
        Me.CustomerInfo.Size = New System.Drawing.Size(89, 26)
        Me.CustomerInfo.TabIndex = 0
        Me.CustomerInfo.Text = "Name : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Credit Balance : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(34, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Status:"
        '
        'LaundryStatus
        '
        Me.LaundryStatus.AutoSize = True
        Me.LaundryStatus.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaundryStatus.Location = New System.Drawing.Point(31, 410)
        Me.LaundryStatus.MinimumSize = New System.Drawing.Size(300, 0)
        Me.LaundryStatus.Name = "LaundryStatus"
        Me.LaundryStatus.Size = New System.Drawing.Size(300, 37)
        Me.LaundryStatus.TabIndex = 3
        Me.LaundryStatus.Text = "Status"
        Me.LaundryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffInchargeLabel
        '
        Me.StaffInchargeLabel.AutoSize = True
        Me.StaffInchargeLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInchargeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StaffInchargeLabel.Location = New System.Drawing.Point(256, 461)
        Me.StaffInchargeLabel.Name = "StaffInchargeLabel"
        Me.StaffInchargeLabel.Size = New System.Drawing.Size(82, 13)
        Me.StaffInchargeLabel.TabIndex = 5
        Me.StaffInchargeLabel.Text = "Staff incharge:"
        Me.StaffInchargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffName
        '
        Me.StaffName.AutoSize = True
        Me.StaffName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffName.Location = New System.Drawing.Point(31, 474)
        Me.StaffName.MinimumSize = New System.Drawing.Size(300, 0)
        Me.StaffName.Name = "StaffName"
        Me.StaffName.Size = New System.Drawing.Size(300, 13)
        Me.StaffName.TabIndex = 6
        Me.StaffName.Text = "StaffName"
        Me.StaffName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalCloth
        '
        Me.TotalCloth.AutoSize = True
        Me.TotalCloth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCloth.Location = New System.Drawing.Point(301, 188)
        Me.TotalCloth.MinimumSize = New System.Drawing.Size(30, 0)
        Me.TotalCloth.Name = "TotalCloth"
        Me.TotalCloth.Size = New System.Drawing.Size(30, 13)
        Me.TotalCloth.TabIndex = 7
        Me.TotalCloth.Text = "xx"
        Me.TotalCloth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalClothesLabel
        '
        Me.TotalClothesLabel.AutoSize = True
        Me.TotalClothesLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalClothesLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TotalClothesLabel.Location = New System.Drawing.Point(260, 175)
        Me.TotalClothesLabel.Name = "TotalClothesLabel"
        Me.TotalClothesLabel.Size = New System.Drawing.Size(77, 13)
        Me.TotalClothesLabel.TabIndex = 8
        Me.TotalClothesLabel.Text = "Total Clothes:"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(76, 80)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 39
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(34, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.IconButton1.IconColor = System.Drawing.Color.Gray
        Me.IconButton1.IconSize = 35
        Me.IconButton1.Location = New System.Drawing.Point(278, 42)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(54, 49)
        Me.IconButton1.TabIndex = 15
        Me.IconButton1.Text = "Sign-Out"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.White
        Me.RefreshButton.ForeColor = System.Drawing.Color.Gray
        Me.RefreshButton.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.RefreshButton.IconColor = System.Drawing.Color.Gray
        Me.RefreshButton.Location = New System.Drawing.Point(34, 128)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(32, 32)
        Me.RefreshButton.TabIndex = 13
        Me.RefreshButton.TabStop = False
        '
        'MainMenuPictureBox
        '
        Me.MainMenuPictureBox.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Waiting_Status
        Me.MainMenuPictureBox.Location = New System.Drawing.Point(-33, 145)
        Me.MainMenuPictureBox.Name = "MainMenuPictureBox"
        Me.MainMenuPictureBox.Size = New System.Drawing.Size(436, 293)
        Me.MainMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MainMenuPictureBox.TabIndex = 16
        Me.MainMenuPictureBox.TabStop = False
        '
        'CustomerInfoButton
        '
        Me.CustomerInfoButton.FlatAppearance.BorderSize = 0
        Me.CustomerInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CustomerInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CustomerInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerInfoButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CustomerInfoButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfoButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.CustomerInfoButton.IconColor = System.Drawing.Color.Gray
        Me.CustomerInfoButton.IconSize = 40
        Me.CustomerInfoButton.Location = New System.Drawing.Point(143, 520)
        Me.CustomerInfoButton.Name = "CustomerInfoButton"
        Me.CustomerInfoButton.Rotation = 0R
        Me.CustomerInfoButton.Size = New System.Drawing.Size(75, 67)
        Me.CustomerInfoButton.TabIndex = 40
        Me.CustomerInfoButton.Text = "Profile and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "History"
        Me.CustomerInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CustomerInfoButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "M.L.M.S"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomerInfoButton)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.TotalClothesLabel)
        Me.Controls.Add(Me.TotalCloth)
        Me.Controls.Add(Me.StaffName)
        Me.Controls.Add(Me.StaffInchargeLabel)
        Me.Controls.Add(Me.LaundryStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerInfo)
        Me.Controls.Add(Me.MainMenuPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main-Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainMenuPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerInfo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LaundryStatus As Label
    Friend WithEvents StaffInchargeLabel As Label
    Friend WithEvents StaffName As Label
    Friend WithEvents TotalCloth As Label
    Friend WithEvents TotalClothesLabel As Label
    Friend WithEvents RefreshButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents MainMenuPictureBox As PictureBox
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomerInfoButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
End Class
