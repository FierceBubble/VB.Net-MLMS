Imports MySql.Data.MySqlClient

Public Class AdminPage

    Public billnumber As Integer = 0 'Capture bill number to list more items in that particular laundry'
    Public StaffID As String 'Capture the specific staffID that will be edited'
    Public CustomerID As String 'Capture the specific customerID that will be edited'
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection to the database with table name: "staff" to retrieve information about the staff'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.staff where 
                                                        FirstName='" & SignIn.COSFName & "'and 
                                                        LastName='" & SignIn.COSLName & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer

            count = 0
            While rdr.Read
                count += 1

            End While

            If count = 1 Then
                Dim AID As String = rdr("StaffID")
                Dim AGender As String = rdr("Gender")
                Dim ADOB As Date = rdr("DOB")
                Dim ARole As String = rdr("Role")
                'Display personal information on the top left of the page'
                AdminInfo.Text = "Staff ID : " + AID +
                                    "" & vbCrLf & "Name : " + SignIn.COSName +
                                    "" & vbCrLf & "Date of birth : " + ADOB +
                                    "" & vbCrLf & "Gender : " + AGender +
                                    "" & vbCrLf & "Role : " + ARole

            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try


        HistoryList()

    End Sub

    Private Sub HistoryList()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Display customer's laundry history in a data grid'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.history", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            HistoryInfo.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        StaffEdit.Visible = False
        CustomerList.Visible = False
        HistoryInfo.Visible = True
        HistoryList()

    End Sub

    Private Sub HistoryInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistoryInfo.CellContentClick
        'State which billnumber to choose from'
        Dim colname As String = HistoryInfo.Columns(e.ColumnIndex).Name
        If colname = "MoreInfo" Then
            billnumber = HistoryInfo.Rows(e.RowIndex).Cells(0).Value
            ListItems.Show()
        End If
    End Sub

    Private Sub StaffEdit_Click(sender As Object, e As EventArgs) Handles StaffEditButton.Click

        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Display list of staff in a data grid'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.staff", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            StaffEdit.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        StaffEdit.Visible = True
        CustomerList.Visible = False
        HistoryInfo.Visible = False
    End Sub

    Private Sub StaffEdit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffEdit.CellContentClick
        'State which staff ID to choose from'
        Dim colname As String = StaffEdit.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            StaffID = StaffEdit.Rows(e.RowIndex).Cells(0).Value
            EditStaffInfo.Show()
        End If

    End Sub

    Private Sub CustomerEdit_Click(sender As Object, e As EventArgs) Handles CustomerEditButton.Click
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Display list of customer's account in a data grid'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.customer", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            CustomerList.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        StaffEdit.Visible = False
        CustomerList.Visible = True
        HistoryInfo.Visible = False
    End Sub

    Private Sub CustomerList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerList.CellContentClick
        'State which customer ID to choose from'
        Dim colname As String = CustomerList.Columns(e.ColumnIndex).Name
        If colname = "EditCustomer" Then
            CustomerID = CustomerList.Rows(e.RowIndex).Cells(0).Value
            EditCustomerfromAdmin.Show()
        End If
    End Sub
    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaff.Click
        NewStaff.Show()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        StaffMainMenu.Show()
    End Sub


End Class