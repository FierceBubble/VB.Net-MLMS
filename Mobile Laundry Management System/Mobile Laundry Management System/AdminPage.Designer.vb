<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminPage))
        Me.AdminInfo = New System.Windows.Forms.Label()
        Me.HistoryInfo = New System.Windows.Forms.DataGridView()
        Me.BillNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofCollectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoreInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MlmsDataSet = New Mobile_Laundry_Management_System.mlmsDataSet()
        Me.HistoryTableAdapter = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.historyTableAdapter()
        Me.TableAdapterManager = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.customerTableAdapter()
        Me.StaffTableAdapter = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.staffTableAdapter()
        Me.StaffEdit = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerList = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditCustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddStaff = New FontAwesome.Sharp.IconButton()
        Me.StaffEditButton = New FontAwesome.Sharp.IconButton()
        Me.CustomerEditButton = New FontAwesome.Sharp.IconButton()
        Me.HistoryButton = New FontAwesome.Sharp.IconButton()
        Me.BackButton = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.HistoryInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminInfo
        '
        Me.AdminInfo.AutoSize = True
        Me.AdminInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminInfo.Location = New System.Drawing.Point(109, 98)
        Me.AdminInfo.MinimumSize = New System.Drawing.Size(220, 0)
        Me.AdminInfo.Name = "AdminInfo"
        Me.AdminInfo.Size = New System.Drawing.Size(220, 65)
        Me.AdminInfo.TabIndex = 41
        Me.AdminInfo.Text = "Staff ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date of Birth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gender : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Role :"
        '
        'HistoryInfo
        '
        Me.HistoryInfo.AllowUserToAddRows = False
        Me.HistoryInfo.AllowUserToDeleteRows = False
        Me.HistoryInfo.AllowUserToResizeColumns = False
        Me.HistoryInfo.AllowUserToResizeRows = False
        Me.HistoryInfo.AutoGenerateColumns = False
        Me.HistoryInfo.BackgroundColor = System.Drawing.Color.White
        Me.HistoryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillNumberDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.DateofCollectionDataGridViewTextBoxColumn, Me.TotalAmountPaidDataGridViewTextBoxColumn, Me.MoreInfo})
        Me.HistoryInfo.DataSource = Me.HistoryBindingSource
        Me.HistoryInfo.GridColor = System.Drawing.Color.Silver
        Me.HistoryInfo.Location = New System.Drawing.Point(28, 171)
        Me.HistoryInfo.Name = "HistoryInfo"
        Me.HistoryInfo.ReadOnly = True
        Me.HistoryInfo.RowHeadersVisible = False
        Me.HistoryInfo.Size = New System.Drawing.Size(304, 351)
        Me.HistoryInfo.TabIndex = 40
        '
        'BillNumberDataGridViewTextBoxColumn
        '
        Me.BillNumberDataGridViewTextBoxColumn.DataPropertyName = "BillNumber"
        Me.BillNumberDataGridViewTextBoxColumn.HeaderText = "#"
        Me.BillNumberDataGridViewTextBoxColumn.Name = "BillNumberDataGridViewTextBoxColumn"
        Me.BillNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.BillNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillNumberDataGridViewTextBoxColumn.Width = 25
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.FillWeight = 29.05983!
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DateofCollectionDataGridViewTextBoxColumn
        '
        Me.DateofCollectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DateofCollectionDataGridViewTextBoxColumn.DataPropertyName = "DateofCollection"
        Me.DateofCollectionDataGridViewTextBoxColumn.FillWeight = 170.9402!
        Me.DateofCollectionDataGridViewTextBoxColumn.HeaderText = "Date collection"
        Me.DateofCollectionDataGridViewTextBoxColumn.Name = "DateofCollectionDataGridViewTextBoxColumn"
        Me.DateofCollectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofCollectionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TotalAmountPaidDataGridViewTextBoxColumn
        '
        Me.TotalAmountPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalAmountPaid"
        Me.TotalAmountPaidDataGridViewTextBoxColumn.HeaderText = "Cost (RM)"
        Me.TotalAmountPaidDataGridViewTextBoxColumn.Name = "TotalAmountPaidDataGridViewTextBoxColumn"
        Me.TotalAmountPaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalAmountPaidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TotalAmountPaidDataGridViewTextBoxColumn.Width = 50
        '
        'MoreInfo
        '
        Me.MoreInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MoreInfo.HeaderText = "More"
        Me.MoreInfo.Name = "MoreInfo"
        Me.MoreInfo.ReadOnly = True
        Me.MoreInfo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MoreInfo.Width = 40
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "history"
        Me.HistoryBindingSource.DataSource = Me.MlmsDataSet
        '
        'MlmsDataSet
        '
        Me.MlmsDataSet.DataSetName = "mlmsDataSet"
        Me.MlmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.historyTableAdapter = Me.HistoryTableAdapter
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffEdit
        '
        Me.StaffEdit.AllowUserToAddRows = False
        Me.StaffEdit.AllowUserToDeleteRows = False
        Me.StaffEdit.AllowUserToResizeColumns = False
        Me.StaffEdit.AllowUserToResizeRows = False
        Me.StaffEdit.AutoGenerateColumns = False
        Me.StaffEdit.BackgroundColor = System.Drawing.Color.White
        Me.StaffEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffEdit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.Edit})
        Me.StaffEdit.DataSource = Me.StaffBindingSource
        Me.StaffEdit.GridColor = System.Drawing.Color.Silver
        Me.StaffEdit.Location = New System.Drawing.Point(28, 171)
        Me.StaffEdit.Name = "StaffEdit"
        Me.StaffEdit.ReadOnly = True
        Me.StaffEdit.RowHeadersVisible = False
        Me.StaffEdit.Size = New System.Drawing.Size(304, 351)
        Me.StaffEdit.TabIndex = 44
        Me.StaffEdit.Visible = False
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FirstNameDataGridViewTextBoxColumn.Width = 80
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LastNameDataGridViewTextBoxColumn.Width = 80
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.GenderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GenderDataGridViewTextBoxColumn.Width = 35
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Edit.Width = 33
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MlmsDataSet
        '
        'CustomerList
        '
        Me.CustomerList.AllowUserToAddRows = False
        Me.CustomerList.AllowUserToDeleteRows = False
        Me.CustomerList.AllowUserToResizeColumns = False
        Me.CustomerList.AllowUserToResizeRows = False
        Me.CustomerList.AutoGenerateColumns = False
        Me.CustomerList.BackgroundColor = System.Drawing.Color.White
        Me.CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn1, Me.LastNameDataGridViewTextBoxColumn1, Me.CreditBalanceDataGridViewTextBoxColumn, Me.EditCustomer})
        Me.CustomerList.DataSource = Me.CustomerBindingSource
        Me.CustomerList.GridColor = System.Drawing.Color.Silver
        Me.CustomerList.Location = New System.Drawing.Point(28, 171)
        Me.CustomerList.Name = "CustomerList"
        Me.CustomerList.ReadOnly = True
        Me.CustomerList.RowHeadersVisible = False
        Me.CustomerList.Size = New System.Drawing.Size(304, 351)
        Me.CustomerList.TabIndex = 45
        Me.CustomerList.Visible = False
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "First name"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        Me.FirstNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FirstNameDataGridViewTextBoxColumn1.Width = 80
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "Last name"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        Me.LastNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LastNameDataGridViewTextBoxColumn1.Width = 80
        '
        'CreditBalanceDataGridViewTextBoxColumn
        '
        Me.CreditBalanceDataGridViewTextBoxColumn.DataPropertyName = "CreditBalance"
        Me.CreditBalanceDataGridViewTextBoxColumn.HeaderText = "Credit balance (RM)"
        Me.CreditBalanceDataGridViewTextBoxColumn.Name = "CreditBalanceDataGridViewTextBoxColumn"
        Me.CreditBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditBalanceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CreditBalanceDataGridViewTextBoxColumn.Width = 50
        '
        'EditCustomer
        '
        Me.EditCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EditCustomer.HeaderText = "Edit"
        Me.EditCustomer.Name = "EditCustomer"
        Me.EditCustomer.ReadOnly = True
        Me.EditCustomer.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EditCustomer.Width = 33
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.MlmsDataSet
        '
        'AddStaff
        '
        Me.AddStaff.FlatAppearance.BorderSize = 0
        Me.AddStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStaff.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.AddStaff.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaff.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.AddStaff.IconColor = System.Drawing.Color.Gray
        Me.AddStaff.IconSize = 40
        Me.AddStaff.Location = New System.Drawing.Point(50, 528)
        Me.AddStaff.Name = "AddStaff"
        Me.AddStaff.Rotation = 0R
        Me.AddStaff.Size = New System.Drawing.Size(75, 67)
        Me.AddStaff.TabIndex = 49
        Me.AddStaff.Text = "Add Staff"
        Me.AddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.AddStaff.UseVisualStyleBackColor = True
        '
        'StaffEditButton
        '
        Me.StaffEditButton.FlatAppearance.BorderSize = 0
        Me.StaffEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.StaffEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.StaffEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StaffEditButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.StaffEditButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffEditButton.IconChar = FontAwesome.Sharp.IconChar.UsersCog
        Me.StaffEditButton.IconColor = System.Drawing.Color.Gray
        Me.StaffEditButton.IconSize = 40
        Me.StaffEditButton.Location = New System.Drawing.Point(143, 528)
        Me.StaffEditButton.Name = "StaffEditButton"
        Me.StaffEditButton.Rotation = 0R
        Me.StaffEditButton.Size = New System.Drawing.Size(75, 67)
        Me.StaffEditButton.TabIndex = 48
        Me.StaffEditButton.Text = "Staff" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edit"
        Me.StaffEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.StaffEditButton.UseVisualStyleBackColor = True
        '
        'CustomerEditButton
        '
        Me.CustomerEditButton.FlatAppearance.BorderSize = 0
        Me.CustomerEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CustomerEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CustomerEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerEditButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.CustomerEditButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerEditButton.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.CustomerEditButton.IconColor = System.Drawing.Color.Gray
        Me.CustomerEditButton.IconSize = 40
        Me.CustomerEditButton.Location = New System.Drawing.Point(239, 528)
        Me.CustomerEditButton.Name = "CustomerEditButton"
        Me.CustomerEditButton.Rotation = 0R
        Me.CustomerEditButton.Size = New System.Drawing.Size(75, 67)
        Me.CustomerEditButton.TabIndex = 47
        Me.CustomerEditButton.Text = "Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edit"
        Me.CustomerEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.CustomerEditButton.UseVisualStyleBackColor = True
        '
        'HistoryButton
        '
        Me.HistoryButton.FlatAppearance.BorderSize = 0
        Me.HistoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HistoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.HistoryButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.HistoryButton.IconColor = System.Drawing.Color.Gray
        Me.HistoryButton.IconSize = 40
        Me.HistoryButton.Location = New System.Drawing.Point(28, 98)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Rotation = 0R
        Me.HistoryButton.Size = New System.Drawing.Size(75, 67)
        Me.HistoryButton.TabIndex = 46
        Me.HistoryButton.Text = "History"
        Me.HistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.ForeColor = System.Drawing.Color.Gray
        Me.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.BackButton.IconColor = System.Drawing.Color.Gray
        Me.BackButton.IconSize = 35
        Me.BackButton.Location = New System.Drawing.Point(294, 47)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 42
        Me.BackButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(70, 74)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 51
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(28, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AddStaff)
        Me.Controls.Add(Me.StaffEditButton)
        Me.Controls.Add(Me.CustomerEditButton)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.CustomerList)
        Me.Controls.Add(Me.StaffEdit)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AdminInfo)
        Me.Controls.Add(Me.HistoryInfo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPage"
        CType(Me.HistoryInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents AdminInfo As Label
    Friend WithEvents HistoryInfo As DataGridView
    Friend WithEvents MlmsDataSet As mlmsDataSet
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As mlmsDataSetTableAdapters.historyTableAdapter
    Friend WithEvents TableAdapterManager As mlmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffEdit As DataGridView
    Friend WithEvents CustomerList As DataGridView
    Friend WithEvents StaffTableAdapter As mlmsDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffEditButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CustomerEditButton As FontAwesome.Sharp.IconButton
    Friend WithEvents HistoryButton As FontAwesome.Sharp.IconButton
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As mlmsDataSetTableAdapters.customerTableAdapter
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BODDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents AddStaff As FontAwesome.Sharp.IconButton
    Friend WithEvents BillNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofCollectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoreInfo As DataGridViewButtonColumn
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CreditBalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditCustomer As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
