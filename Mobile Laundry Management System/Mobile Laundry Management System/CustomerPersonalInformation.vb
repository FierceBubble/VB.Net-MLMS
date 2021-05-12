Imports MySql.Data.MySqlClient

Public Class CustomerPersonalInformation

    Public billnumber As Integer = 0 'Capture bill number to list more items in that particular laundry'

    Private Sub CustomerPersonalInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Connection to the database with table name: "customer" to retrieve information about the customer'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.customer where 
                                                        FirstName='" & SignIn.COSFName & "'and 
                                                        LastName='" & SignIn.COSLName & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer

            count = 0
            While rdr.Read
                count += 1

            End While

            If count = 1 Then
                Dim CID As String = rdr("CustomerID")
                Dim CGender As String = rdr("Gender")
                Dim CDOB As Date = rdr("DOB")
                Dim CBalance As Double = rdr("CreditBalance")
                Dim RCBalance As String = CBalance.ToString

                'Display personal information on the top left of the page'
                CustomerInfo.Text = "CustomerID: " + CID +
                                    "" & vbCrLf & "Name: " + SignIn.COSName +
                                    "" & vbCrLf & "Date of birth: " + CDOB +
                                    "" & vbCrLf & "Gender: " + CGender +
                                    "" & vbCrLf & "Credit balance: RM" + RCBalance

            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try


        'Display customer's laundry history in a data grid'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select BillNumber, StaffName, DateofStart, DateofCollection, TotalAmountPaid, TotalCloth, Weight from mlms.history where 
                                                        CustomerName='" & SignIn.COSName & "'", conn)
            Dim sda As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            sda.SelectCommand = cmd
            sda.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            PersonalInfo.DataSource = bSource
            sda.Update(dbDataSet)

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub PersonalInfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PersonalInfo.CellContentClick
        'State which billnumber to choose from'
        Dim colname As String = PersonalInfo.Columns(e.ColumnIndex).Name

        If colname = "MoreInfo" Then
            billnumber = PersonalInfo.Rows(e.RowIndex).Cells(0).Value
            ListItems.Show()
        End If
    End Sub

    Private Sub EditIconButton_PersonalInfo(sender As Object, e As EventArgs) Handles EditIconButton.Click
        'Button for customer to edit their personal information'
        Me.Close()
        EditPersonalInfo.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Button for customer to go back to the main menu with an updated information if available'
        Me.Close()
        MainMenu.Show()
    End Sub


End Class