Imports MySql.Data.MySqlClient

Public Class EditCustomerfromAdmin

    Dim EditGender As String                'To capture gender value when either radio button is checked'
    Private Sub MaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles EditMaleRButton.CheckedChanged
        EditGender = "M"                    'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub FemaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles EditFemaleRButton.CheckedChanged
        EditGender = "F"                    'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub EditPersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Connection to the database with table name: "customer" to retrieve information about the customer'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.customer where 
                                      CustomerID='" & AdminPage.CustomerID & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer

            count = 0
            While rdr.Read
                count += 1

            End While

            If count = 1 Then
                Dim CID As String = rdr("CustomerID")
                EditGender = rdr("Gender")
                Dim CDOB As Date = rdr("DOB")

                EditIDBox.Text = CID
                EditFNameBox.Text = rdr("FirstName")
                EditLNameBox.Text = rdr("LastName")
                EditDOBPicker.Text = CDOB

                If EditGender = "M" Then
                    EditMaleRButton.Checked = True
                ElseIf EditGender = "F" Then
                    EditFemaleRButton.Checked = True
                End If

            End If

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try


    End Sub


    Private Sub SaveEdit_Click(sender As Object, e As EventArgs) Handles SaveEdit.Click

        'There are a few conditions before a customer can change their personal information'
        ShowExclamation()

        If EditIDBox.Text = "" Or EditFNameBox.Text = "" Or
                            EditLNameBox.Text = "" Or
                            EditDOBPicker.Text = "" Or
                            EditPasswordBox.Text = "" Or
                            EditCPasswordBox.Text = "" Then
            'Check if there is any blank box'
            WrongLabel.Visible = True

        ElseIf EditPasswordBox.Text <> EditCPasswordBox.Text Then
            'Check if both password and password confirmation matched'
            WrongLabel.Text = "* Please make sure the password match!"
            WrongLabel.Visible = True
            ExclamationIcon5.Visible = True
            ExclamationIcon6.Visible = True
            EditPasswordBox.Clear()
            EditCPasswordBox.Clear()
        Else
            'Conditions are met and customer is allowed to change their personal infromation'
            Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

            Try

                conn.Open()
                'Changes that is made to their personal information'
                Dim cmd As MySqlCommand = New MySqlCommand("update  mlms.customer set 
                                          Password='" & EditPasswordBox.Text & "',
                                          FirstName='" & EditFNameBox.Text & "',
                                          LastName='" & EditLNameBox.Text & "',
                                          Gender='" & EditGender & "',
                                          DOB='" & EditDOBPicker.Text & "',
                                          CustomerID='" & EditIDBox.Text & "'where 
                                          CustomerID='" & AdminPage.CustomerID & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                MessageBox.Show("Personal information successfuly changed!")

                conn.Close()

                Me.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        End If

    End Sub


    Private Sub PasswordSOH_Click(sender As Object, e As EventArgs) Handles PasswordSOH.Click
        'Button to show or hide password character"
        If (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye) Then
            EditPasswordBox.UseSystemPasswordChar = False
            EditCPasswordBox.UseSystemPasswordChar = False
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        ElseIf (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash) Then
            EditPasswordBox.UseSystemPasswordChar = True
            EditCPasswordBox.UseSystemPasswordChar = True
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        'Button to cancel changes in their personal information and bring the customer back to their'
        'personal Information page'
        Me.Close()
        AdminPage.Show()
    End Sub

    Private Sub ShowExclamation()
        'Show exclamation mark when field is blank'
        If EditIDBox.Text = "" Then
            ExclamationIcon1.Visible = True
        Else
            ExclamationIcon1.Visible = False
        End If

        If EditFNameBox.Text = "" Then
            ExclamationIcon2.Visible = True
        Else
            ExclamationIcon2.Visible = False
        End If

        If EditLNameBox.Text = "" Then
            ExclamationIcon3.Visible = True
        Else
            ExclamationIcon3.Visible = False
        End If

        If EditGender = "" Then
            pickgender.Visible = True
        Else
            pickgender.Visible = False
        End If

        If EditDOBPicker.Text = Date.Now.ToString("yyyy-MM-dd") Then
            ExclamationIcon4.Visible = True
        Else
            ExclamationIcon4.Visible = False
        End If

        If EditPasswordBox.Text = "" Then
            ExclamationIcon5.Visible = True
        Else
            ExclamationIcon5.Visible = False
        End If

        If EditCPasswordBox.Text = "" Then
            ExclamationIcon6.Visible = True
        Else
            ExclamationIcon6.Visible = False
        End If
    End Sub

End Class