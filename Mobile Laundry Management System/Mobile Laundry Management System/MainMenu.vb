Imports MySql.Data.MySqlClient
Public Class MainMenu



    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display their name and credit balance on top left of the main menu'
        CustomerInfo.Text = SignIn.COSName + "" & vbCrLf & "Credit Balance : RM" + SignIn.CBString

        'Connection to the database with table name: "status" to retrieve information' 
        'about the laundry and it is status'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.status where 
                                                        CustomerName='" & SignIn.COSName & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim LStatus, LStaffName As String
            Dim LCloth As Integer
            Dim count As Integer = 0

            While rdr.Read()
                count += 1

            End While

            If count = 1 Then
                LCloth = rdr("TotalCloth")
                LStatus = rdr("LaundryStatus")
                LStaffName = rdr("StaffName")
                StaffName.Text = LStaffName
                LaundryStatus.Text = LStatus
                TotalCloth.Text = LCloth

                'Notify the customer when they open tha application that their laundry is ready for collection'
                If LStatus = "Ready for collection" Then
                    MessageBox.Show("Your laundry is ready for collection!")
                    MainMenuPictureBox.Image = My.Resources.Readyforcollection
                ElseIf LStatus = "Washing" Then
                    MainMenuPictureBox.Image = My.Resources.WashingAndDrying
                ElseIf LStatus = "Drying" Then
                    MainMenuPictureBox.Image = My.Resources.WashingAndDrying
                End If


            ElseIf count = 0 Then
                StaffName.Visible = False
                TotalCloth.Visible = False
                TotalClothesLabel.Visible = False
                StaffInchargeLabel.Visible = False
                MainMenuPictureBox.Image = My.Resources.No_Laundry
                LaundryStatus.Text = "No active laundry"

            End If

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub CustomerInfoButton_Click(sender As Object, e As EventArgs) Handles CustomerInfoButton.Click
        'Button for customer to see their personal information and laundry history'
        Me.Close()
        CustomerPersonalInformation.Show()
    End Sub

    Private Sub SignOutAccount(sender As Object, e As EventArgs) Handles IconButton1.Click
        'This is a button for customer to sign-out from their account and bring them back to the sign-in form'
        Me.Close()
        SignIn.Show()
    End Sub

    Private Sub RefreshMainMenuPage(sender As Object, e As EventArgs) Handles RefreshButton.Click
        'Connection to the database with table name: "status" to retrieve information about the laundry and it is status'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.status where 
                                                        CustomerName='" & SignIn.COSName & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim LStatus, LStaffName As String
            Dim LCloth As Integer
            Dim count As Integer = 0

            While rdr.Read()
                count += 1

            End While

            If count = 1 Then
                LCloth = rdr("TotalCloth")
                LStatus = rdr("LaundryStatus")
                LStaffName = rdr("StaffName")
                StaffName.Text = LStaffName
                LaundryStatus.Text = LStatus
                TotalCloth.Text = LCloth

                'Notify the customer when they open tha application on the status of their laundry'
                If LStatus = "Ready for collection" Then
                    MessageBox.Show("Your laundry is ready for collection!")
                End If


            ElseIf count = 0 Then
                StaffName.Text = "n/a"
                LaundryStatus.Text = "No active laundry"
                TotalCloth.Text = "0"
            End If

            conn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()

        End Try

        'Connection to the database with table name: "customer" to retrieve information about the customer'
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
                'Display The name and their credit balance on top left of the main menu'
                Dim CBalance As Double = rdr("CreditBalance")
                Dim RCBalance As String = CBalance.ToString
                CustomerInfo.Text = SignIn.COSName + "" & vbCrLf & "Credit Balance : RM" + RCBalance
            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub


End Class