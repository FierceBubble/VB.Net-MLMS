Imports MySql.Data.MySqlClient
Public Class SignIn

    'Connection query to connect this mobile application to MySql database'
    Public connquery As String = "server=localhost;userid=root;password=root;database=mlms;"



    'The 4 information that the application will extract from the database'
    Public COSFName As String
    Public COSLName As String
    Public COSName As String
    Public CBString As String
    Public StaffRole As String


    Private Sub SignInPage(sender As Object, e As EventArgs) Handles signinButton.Click

        If id.Text = "" And password.Text = "" Then
            ExclamationIcon.Visible = True
            ExclamationIcon2.Visible = True
            WrongLabel.Visible = True
        ElseIf id.Text = "" Then
            ExclamationIcon.Visible = True
            ExclamationIcon2.Visible = False
            WrongLabel.Text = "* Please fill your account ID!"
            WrongLabel.Visible = True
        ElseIf password.Text = "" Then
            ExclamationIcon.Visible = False
            ExclamationIcon2.Visible = True
            WrongLabel.Text = "* Please fill your password!"
            WrongLabel.Visible = True
        Else
            'Connection to the database with table name: "customer" to retrieve information about the customer'
            'ID and password'
            Dim conn As MySqlConnection = New MySqlConnection(connquery)

            Try
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.customer 
                                                        where CustomerID='" & id.Text & "' and 
                                                        Password='" & password.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                Dim count As Integer

                count = 0
                While rdr.Read
                    count += 1
                End While

                If count = 1 Then
                    'Login is successful and data is collected for further use'
                    Dim Firstname As String
                    Dim Lastname As String

                    Firstname = rdr("FirstName")
                    Lastname = rdr("LastName")
                    COSFName = Firstname.ToString
                    COSLName = Lastname.ToString
                    COSName = Firstname.ToString + " " + Lastname.ToString
                    Dim CBalance As Double = rdr("CreditBalance")
                    CBString = CBalance.ToString

                    id.Clear()
                    password.Clear()
                    WrongLabel.Visible = False
                    ExclamationIcon.Visible = False
                    ExclamationIcon2.Visible = False
                    Me.Visible = False
                    MainMenu.Show()

                ElseIf count < 1 Then
                    'Check if the ID inputed is a staff ID'
                    Checkstaff()
                End If

                conn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
        End If



    End Sub

    Private Sub Checkstaff()
        Dim conn As MySqlConnection = New MySqlConnection(connquery)
        'Connection to the database with table name: "staff" to retrieve information about the staff ID and password'

        Try
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.staff where StaffID='" & id.Text &
                                                       "' and Password='" & password.Text & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim i As Integer = 0
            While rdr.Read
                i += 1

            End While

            If i = 1 Then
                'Login is successful and data is collected for further use'
                Dim Firstname As String
                Dim Lastname As String

                Firstname = rdr("FirstName")
                Lastname = rdr("LastName")
                StaffRole = rdr("Role")
                COSFName = Firstname.ToString
                COSLName = Lastname.ToString
                COSName = Firstname.ToString + " " + Lastname.ToString
                id.Clear()
                password.Clear()
                WrongLabel.Visible = False
                ExclamationIcon.Visible = False
                ExclamationIcon2.Visible = False
                Me.Visible = False
                StaffMainMenu.Show()


            ElseIf i < 1 Then
                'The ID or password is wrong'
                id.Clear()
                password.Clear()
                WrongLabel.Text = "* Account ID or Password is incorrect!"
                WrongLabel.Visible = True
                ExclamationIcon.Visible = False
                ExclamationIcon2.Visible = False
            End If
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub SignupButton_Click(sender As Object, e As EventArgs) Handles signupButton.Click
        'Button for customer to signup'
        Me.Visible = False
        SignUp.Show()
    End Sub

    Private Sub PasswordSOHButton(sender As Object, e As EventArgs) Handles PasswordSOH.Click
        'Button to show or hide password character'
        If (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye) Then
            password.UseSystemPasswordChar = False
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        ElseIf (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash) Then
            password.UseSystemPasswordChar = True
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles PowerButton.Click
        'Button to exit from the mobile application'
        Application.Exit()
    End Sub


End Class
