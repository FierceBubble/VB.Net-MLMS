Imports MySql.Data.MySqlClient

Public Class StaffMainMenu
    Dim billnumber As Integer 'Capture the billnumber value in the database of a certain row'

    Private Sub StaffMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display staff name in the main menu'
        StaffInfo.Text = "Staff Name : " + SignIn.COSName +
                         "" & vbCrLf & "Role : " + SignIn.StaffRole

        'Display customer's laundry history in a data grid'
        If SignIn.StaffRole = "Staff" Then
            EditInfoButton.Visible = True
            LoadStaff()
        ElseIf SignIn.StaffRole = "Manager" Then
            AdminButton.Visible = True
            LoadAdmin()
        End If


    End Sub



    Private Sub LoadStaff()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Display customer's laundry history that the staff is incharge of in a data grid'
        Try
            conn.Open()
            'Connection to the database with table name: "status" to retrieve information about the laundry status'

            Dim cmd As MySqlCommand = New MySqlCommand("select BillNumber, CustomerName, TotalCloth, LaundryStatus 
                                                        from mlms.status where 
                                                        StaffName='" & SignIn.COSName & "'", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LaundryStatusData.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub LoadAdmin()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Display all customer's laundry history in a data grid'
        Try
            conn.Open()
            'Connection to the database with table name: "status" to retrieve information about the laundry status'

            Dim cmd As MySqlCommand = New MySqlCommand("select BillNumber, CustomerName, TotalCloth, LaundryStatus 
                                                        from mlms.status", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            LaundryStatusData.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'Button to update the table with new data if available'
        For i As Integer = 0 To LaundryStatusData.Rows.Count - 1
            Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)
            Dim cmd As MySqlCommand = New MySqlCommand("update mlms.status set 
                                                        LaundryStatus='" & LaundryStatusData.Rows(i).Cells(3).Value & "'
                                                        where BillNumber='" & LaundryStatusData.Rows(i).Cells(0).Value & "'", conn)
            conn.Open()
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            'When status changed to "Collected" the data in status will be removed and data in history will be updated"
            If LaundryStatusData.Rows(i).Cells(3).Value = "Collected" Then
                billnumber = LaundryStatusData.Rows(i).Cells(0).Value

                UpdateHistory()
                LaundryCollected()

            Else

            End If
            conn.Close()
        Next
        MessageBox.Show("Status updated successfuly")
    End Sub

    Private Sub LaundryCollected()
        'Remove the collected laundry data from the table'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)
        conn.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("delete from mlms.status where billnumber='" & billnumber & "'", conn)
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        conn.Close()
    End Sub

    Private Sub UpdateHistory()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)
        'Update data history with the collected laundry data'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("update mlms.history set dateofcollection='" & Date.Now.ToString("yyyy-MM-dd hh:mm:ss") & "'
                                                        where billnumber='" & billnumber & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub SignOutButton_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        'This is a button for staff to sign-out from their account and bring them back to the sign-in form'
        Me.Close()
        SignIn.Show()
    End Sub

    Private Sub TopUp_Click(sender As Object, e As EventArgs) Handles TopUpButton.Click
        'This is a button for staff to top-up customer's credit balance'
        Me.Visible = False
        TopUpForm.Show()
    End Sub

    Private Sub AddNewLaundry(sender As Object, e As EventArgs) Handles NewLaundryButton.Click
        'This is a button for staff to add new customer's laundry'
        Me.Close()
        NewLaundry.Show()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        'Display customer's laundry history in a data grid'
        If SignIn.StaffRole = "Staff" Then
            LoadStaff()
        ElseIf SignIn.StaffRole = "Manager" Then
            LoadAdmin()
        End If
    End Sub

    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        Me.Visible = False
        AdminPage.Show()
    End Sub

    Private Sub EditInfoButton_Click(sender As Object, e As EventArgs) Handles EditInfoButton.Click
        Me.Visible = False
        EditStaffInfoMainMenu.Show()
    End Sub
End Class