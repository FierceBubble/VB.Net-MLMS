<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerPersonalInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerPersonalInformation))
        Me.PersonalInfo = New System.Windows.Forms.DataGridView()
        Me.BillNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofStartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofCollectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoreInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MlmsDataSet = New Mobile_Laundry_Management_System.mlmsDataSet()
        Me.CustomerInfo = New System.Windows.Forms.Label()
        Me.MlmsDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryTableAdapter = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.historyTableAdapter()
        Me.TableAdapterManager = New Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager()
        Me.EditIconButton = New FontAwesome.Sharp.IconButton()
        Me.BackButton = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PersonalInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MlmsDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonalInfo
        '
        Me.PersonalInfo.AllowUserToAddRows = False
        Me.PersonalInfo.AllowUserToDeleteRows = False
        Me.PersonalInfo.AllowUserToResizeColumns = False
        Me.PersonalInfo.AllowUserToResizeRows = False
        Me.PersonalInfo.AutoGenerateColumns = False
        Me.PersonalInfo.BackgroundColor = System.Drawing.Color.White
        Me.PersonalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonalInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillNumberDataGridViewTextBoxColumn, Me.DateofStartDataGridViewTextBoxColumn, Me.DateofCollectionDataGridViewTextBoxColumn, Me.TotalAmountPaidDataGridViewTextBoxColumn, Me.MoreInfo})
        Me.PersonalInfo.DataSource = Me.HistoryBindingSource
        Me.PersonalInfo.GridColor = System.Drawing.Color.Silver
        Me.PersonalInfo.Location = New System.Drawing.Point(29, 223)
        Me.PersonalInfo.Name = "PersonalInfo"
        Me.PersonalInfo.ReadOnly = True
        Me.PersonalInfo.RowHeadersVisible = False
        Me.PersonalInfo.Size = New System.Drawing.Size(304, 369)
        Me.PersonalInfo.TabIndex = 11
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
        'DateofStartDataGridViewTextBoxColumn
        '
        Me.DateofStartDataGridViewTextBoxColumn.DataPropertyName = "DateofStart"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DateofStartDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DateofStartDataGridViewTextBoxColumn.HeaderText = "Date laundry"
        Me.DateofStartDataGridViewTextBoxColumn.Name = "DateofStartDataGridViewTextBoxColumn"
        Me.DateofStartDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofStartDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DateofCollectionDataGridViewTextBoxColumn
        '
        Me.DateofCollectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateofCollectionDataGridViewTextBoxColumn.DataPropertyName = "DateofCollection"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DateofCollectionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DateofCollectionDataGridViewTextBoxColumn.HeaderText = "Date collection"
        Me.DateofCollectionDataGridViewTextBoxColumn.Name = "DateofCollectionDataGridViewTextBoxColumn"
        Me.DateofCollectionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateofCollectionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TotalAmountPaidDataGridViewTextBoxColumn
        '
        Me.TotalAmountPaidDataGridViewTextBoxColumn.DataPropertyName = "TotalAmountPaid"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.TotalAmountPaidDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
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
        'CustomerInfo
        '
        Me.CustomerInfo.AutoSize = True
        Me.CustomerInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerInfo.Location = New System.Drawing.Point(33, 102)
        Me.CustomerInfo.MinimumSize = New System.Drawing.Size(220, 0)
        Me.CustomerInfo.Name = "CustomerInfo"
        Me.CustomerInfo.Size = New System.Drawing.Size(220, 65)
        Me.CustomerInfo.TabIndex = 12
        Me.CustomerInfo.Text = "Customer ID :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Date of Birth :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gender : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Credit Balance : "
        '
        'MlmsDataSetBindingSource
        '
        Me.MlmsDataSetBindingSource.DataSource = Me.MlmsDataSet
        Me.MlmsDataSetBindingSource.Position = 0
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.historyTableAdapter = Me.HistoryTableAdapter
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mobile_Laundry_Management_System.mlmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EditIconButton
        '
        Me.EditIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.EditIconButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditIconButton.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.EditIconButton.IconColor = System.Drawing.Color.Gray
        Me.EditIconButton.IconSize = 18
        Me.EditIconButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EditIconButton.Location = New System.Drawing.Point(36, 170)
        Me.EditIconButton.Name = "EditIconButton"
        Me.EditIconButton.Rotation = 0R
        Me.EditIconButton.Size = New System.Drawing.Size(69, 23)
        Me.EditIconButton.TabIndex = 39
        Me.EditIconButton.Text = "Edit"
        Me.EditIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EditIconButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.White
        Me.BackButton.ForeColor = System.Drawing.Color.Gray
        Me.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.BackButton.IconColor = System.Drawing.Color.Gray
        Me.BackButton.IconSize = 35
        Me.BackButton.Location = New System.Drawing.Point(301, 50)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(32, 32)
        Me.BackButton.TabIndex = 38
        Me.BackButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "M.L.M.S"
        '
        'IconName
        '
        Me.IconName.AutoSize = True
        Me.IconName.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconName.Location = New System.Drawing.Point(71, 77)
        Me.IconName.Name = "IconName"
        Me.IconName.Size = New System.Drawing.Size(142, 11)
        Me.IconName.TabIndex = 43
        Me.IconName.Text = "Mobile Laundry Management System"
        Me.IconName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Mobile_Laundry_Management_System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(29, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'CustomerPersonalInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(358, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EditIconButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CustomerInfo)
        Me.Controls.Add(Me.PersonalInfo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CustomerPersonalInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personal Information"
        CType(Me.PersonalInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MlmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MlmsDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PersonalInfo As DataGridView
    Friend WithEvents CustomerInfo As Label
    Friend WithEvents BackButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents EditIconButton As FontAwesome.Sharp.IconButton
    Friend WithEvents MlmsDataSet As mlmsDataSet
    Friend WithEvents MlmsDataSetBindingSource As BindingSource
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As mlmsDataSetTableAdapters.historyTableAdapter
    Friend WithEvents TableAdapterManager As mlmsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BillNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofStartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateofCollectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MoreInfo As DataGridViewButtonColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents IconName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
