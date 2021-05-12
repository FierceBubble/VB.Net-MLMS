<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffMainMenu))
        Me.LaundryStatusData = New System.Windows.Forms.DataGridView()
        Me.BillNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCloth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LaundryStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MlmsDataSet = New Mobile_Laundry_Management_System.mlmsDataSet()
        Me.StaffInfo = New System.Windows.Forms.Label()
        Me.StatusTableAdapter = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.statusTableAdapter()
        Me.TableAdapterManager = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UpdateButton = New FontAwesome.Sharp.IconButton()
        Me.AdminButton = New FontAwesome.Sharp.IconButton()
        Me.RefreshButton = New FontAwesome.Sharp.IconPictureBox()
        Me.NewLaundryButton = New FontAwesome.Sharp.IconButton()
        Me.TopUpButton = New FontAwesome.Sharp.IconButton()
        Me.SignOutButton = New FontAwesome.Sharp.IconButton()
        Me.EditInfoButton = New FontAwesome.Sharp.IconButton()
        CType(Me.LaundryStatusData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaundryStatusData
        '
        Me.LaundryStatusData.AllowUserToAddRows = False
        Me.LaundryStatusData.AutoGenerateColumns = False
        Me.LaundryStatusData.BackgroundColor = System.Drawing.Color.White
        Me.LaundryStatusData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaundryStatusData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillNumberDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.TotalCloth, Me.LaundryStatus})
        Me.LaundryStatusData.DataSource = Me.StatusBindingSource
        Me.LaundryStatusData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.LaundryStatusData.GridColor = System.Drawing.Color.Silver
        Me.LaundryStatusData.Location = New System.Drawing.Point(35, 149)
        Me.LaundryStatusData.Name = "LaundryStatusData"
        Me.LaundryStatusData.RowHeadersVisible = False
        Me.LaundryStatusData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LaundryStatusData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.LaundryStatusData.Size = New System.Drawing.Size(297, 314)
        Me.LaundryStatusData.TabIndex = 17
        '
        'BillNumberDataGridViewTextBoxColumn
        '
        Me.BillNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.BillNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber"
        Me.BillNumberDataGridViewTextBoxColumn.FillWeight = 13.56607!
        Me.BillNumberDataGridViewTextBoxColumn.HeaderText = "#"
        Me.BillNumberDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.BillNumberDataGridViewTextBoxColumn.Name = "BillNumberDataGridViewTextBoxColumn"
        Me.BillNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BillNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.FillWeight = 63.76054!
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TotalCloth
        '
        Me.TotalCloth.DataPropertyName = "TotalCloth"
        Me.TotalCloth.HeaderText = "Clothes"
        Me.TotalCloth.Name = "TotalCloth"
        Me.TotalCloth.ReadOnly = True
        Me.TotalCloth.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TotalCloth.Width = 50
        '
        'LaundryStatus
        '
        Me.LaundryStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.LaundryStatus.DataPropertyName = "LaundryStatus"
        Me.LaundryStatus.FillWeight = 229.8899!
        Me.LaundryStatus.HeaderText = "Status"
        Me.LaundryStatus.Items.AddRange(New Object() {"Waiting", "Washing", "Drying", "Ready for collection", "Collected"})
        Me.LaundryStatus.Name = "LaundryStatus"
        Me.LaundryStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LaundryStatus.Width = 110
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "status"
        Me.StatusBindingSource.DataSource = Me.MlmsDataSet
        '
        'MlmsDataSet
        '
        Me.MlmsDataSet.DataSetName = "mlmsDataSet"
        Me.MlmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffInfo
        '
        Me.StaffInfo.AutoSize = True
        Me.StaffInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInfo.Location = New System.Drawing.Point(73, 109)
        Me.StaffInfo.Name = "StaffInfo"
        Me.StaffInfo.Size = New System.Drawing.Size(72, 26)
        Me.StaffInfo.TabIndex = 20
        Me.StaffInfo.Text = "Staff Name : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Role :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.historyTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(74, 62)
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
        Me.PictureBox1.Location = New System.Drawing.Point(32, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'UpdateButton
        '
        Me.UpdateButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.UpdateButton.IconChar = FontAwesome.Sharp.IconChar.CloudUploadAlt
        Me.UpdateButton.IconColor = System.Drawing.Color.Gray
        Me.UpdateButton.IconSize = 18
        Me.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.Location = New System.Drawing.Point(257, 469)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rotation = 0R
        Me.UpdateButton.Size = New System.Drawing.Size(75, 25)
        Me.UpdateButton.TabIndex = 24
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AdminButton
        '
        Me.AdminButton.FlatAppearance.BorderSize = 0
        Me.AdminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AdminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.AdminButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.AdminButton.IconColor = System.Drawing.Color.Gray
        Me.AdminButton.IconSize = 40
        Me.AdminButton.Location = New System.Drawing.Point(144, 517)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Rotation = 0R
        Me.AdminButton.Size = New System.Drawing.Size(75, 67)
        Me.AdminButton.TabIndex = 23
        Me.AdminButton.Text = "Admin"
        Me.AdminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AdminButton.UseVisualStyleBackColor = True
        Me.AdminButton.Visible = False
        '
        'RefreshButton
        '
        Me.RefreshButton.BackColor = System.Drawing.Color.White
        Me.RefreshButton.ForeColor = System.Drawing.Color.Gray
        Me.RefreshButton.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.RefreshButton.IconColor = System.Drawing.Color.Gray
        Me.RefreshButton.Location = New System.Drawing.Point(35, 103)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(32, 32)
        Me.RefreshButton.TabIndex = 21
        Me.RefreshButton.TabStop = False
        '
        'NewLaundryButton
        '
        Me.NewLaundryButton.FlatAppearance.BorderSize = 0
        Me.NewLaundryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.NewLaundryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.NewLaundryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewLaundryButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.NewLaundryButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewLaundryButton.IconChar = FontAwesome.Sharp.IconChar.Tshirt
        Me.NewLaundryButton.IconColor = System.Drawing.Color.Gray
        Me.NewLaundryButton.IconSize = 40
        Me.NewLaundryButton.Location = New System.Drawing.Point(240, 517)
        Me.NewLaundryButton.Name = "NewLaundryButton"
        Me.NewLaundryButton.Rotation = 0R
        Me.NewLaundryButton.Size = New System.Drawing.Size(75, 67)
        Me.NewLaundryButton.TabIndex = 19
        Me.NewLaundryButton.Text = "New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laundry"
        Me.NewLaundryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.NewLaundryButton.UseVisualStyleBackColor = True
        '
        'TopUpButton
        '
        Me.TopUpButton.FlatAppearance.BorderSize = 0
        Me.TopUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.TopUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.TopUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopUpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.TopUpButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopUpButton.IconChar = FontAwesome.Sharp.IconChar.Wallet
        Me.TopUpButton.IconColor = System.Drawing.Color.Gray
        Me.TopUpButton.IconSize = 40
        Me.TopUpButton.Location = New System.Drawing.Point(47, 517)
        Me.TopUpButton.Name = "TopUpButton"
        Me.TopUpButton.Rotation = 0R
        Me.TopUpButton.Size = New System.Drawing.Size(75, 67)
        Me.TopUpButton.TabIndex = 18
        Me.TopUpButton.Text = "Top-Up"
        Me.TopUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TopUpButton.UseVisualStyleBackColor = True
        '
        'SignOutButton
        '
        Me.SignOutButton.BackColor = System.Drawing.Color.Transparent
        Me.SignOutButton.FlatAppearance.BorderSize = 0
        Me.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOutButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.SignOutButton.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOutButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.SignOutButton.IconColor = System.Drawing.Color.Gray
        Me.SignOutButton.IconSize = 35
        Me.SignOutButton.Location = New System.Drawing.Point(278, 29)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Rotation = 0R
        Me.SignOutButton.Size = New System.Drawing.Size(54, 49)
        Me.SignOutButton.TabIndex = 16
        Me.SignOutButton.Text = "Sign-Out"
        Me.SignOutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SignOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.SignOutButton.UseVisualStyleBackColor = False
        '
        'EditInfoButton
        '
        Me.EditInfoButton.FlatAppearance.BorderSize = 0
        Me.EditInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.EditInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.EditInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditInfoButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.EditInfoButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditInfoButton.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        Me.EditInfoButton.IconColor = System.Drawing.Color.Gray
        Me.EditInfoButton.IconSize = 40
        Me.EditInfoButton.Location = New System.Drawing.Point(144, 517)
        Me.EditInfoButton.Name = "EditInfoButton"
        Me.EditInfoButton.Rotation = 0R
        Me.EditInfoButton.Size = New System.Drawing.Size(75, 67)
        Me.EditInfoButton.TabIndex = 62
        Me.EditInfoButton.Text = "Edit Info"
        Me.EditInfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.EditInfoButton.UseVisualStyleBackColor = True
        Me.EditInfoButton.Visible = False
        '
        'StaffMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(351, 633)
        Me.ControlBox = False
        Me.Controls.Add(Me.EditInfoButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.StaffInfo)
        Me.Controls.Add(Me.NewLaundryButton)
        Me.Controls.Add(Me.TopUpButton)
        Me.Controls.Add(Me.LaundryStatusData)
        Me.Controls.Add(Me.SignOutButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StaffMainMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Main-Menu"
        CType(Me.LaundryStatusData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefreshButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignOutButton As FontAwesome.Sharp.IconButton
    Friend WithEvents LaundryStatusData As DataGridView
    Friend WithEvents TopUpButton As FontAwesome.Sharp.IconButton
    Friend WithEvents NewLaundryButton As FontAwesome.Sharp.IconButton
    Friend WithEvents StaffInfo As Label
    Friend WithEvents RefreshButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MlmsDataSet As mlmsDataSet
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As mlmsDataSetTableAdapters.statusTableAdapter
    Friend WithEvents TableAdapterManager As mlmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LaundryStatusDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents BillNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCloth As DataGridViewTextBoxColumn
    Friend WithEvents LaundryStatus As DataGridViewComboBoxColumn
    Friend WithEvents AdminButton As FontAwesome.Sharp.IconButton
    Friend WithEvents UpdateButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditInfoButton As FontAwesome.Sharp.IconButton
End Class
