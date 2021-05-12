Imports MySql.Data.MySqlClient

Public Class NewStaff
    Dim Gender As String = ""              'To capture gender value when either radio button is checked'
    Private Sub MaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles MaleRButton.CheckedChanged
        Gender = "M"                       'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub FemaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles FemaleRButton.CheckedChanged
        Gender = "F"                       'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaffButton.Click

        ShowExclamation()


        'Check some conditions before customer create a new ID'
        If Gender = "" Or IDBox.Text = "" Or
           FNameBox.Text = "" Or LNameBox.Text = "" Or
           DOBPicker.Text = Date.Now.ToString("yyyy-MM-dd") Or
           PasswordBox.Text = "" Or CPasswordBox.Text = "" Then
            'Check if there is any blank'
            WrongLabel.Visible = True


        ElseIf PasswordBox.Text <> CPasswordBox.Text Then
            'Check if both password and password confirmation matched'
            PasswordBox.Clear()
            CPasswordBox.Clear()
            WrongLabel.Text = "* Please make sure the password match!"
            WrongLabel.Visible = True
            ExclamationIcon5.Visible = True
            ExclamationIcon6.Visible = True

        Else

            Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

            Try
                'Check the ID availability through database'
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.staff where 
                                                            StaffID='" & IDBox.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                Dim count As Integer

                count = 0
                While rdr.Read
                    count += 1

                End While

                If count > 0 Then
                    WrongLabel.Text = "* ID is taken, please use other ID!"
                    WrongLabel.Visible = True
                    IDBox.Clear()
                    FNameBox.Clear()
                    LNameBox.Clear()
                    PasswordBox.Clear()
                    CPasswordBox.Clear()

                ElseIf count < 1 Then
                    'When every condition is met, CreateID() will be invoked'
                    CreateID()

                End If

                conn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()

            End Try

        End If



    End Sub

    Private Sub CreateID()

        'Adding new staff information'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("insert into mlms.staff 
                                     (staffid, firstname, lastname, gender, dob, password, role) values 
                                     ('" & IDBox.Text & "','" & FNameBox.Text & "','" & LNameBox.Text & "',
                                     '" & Gender & "','" & DOBPicker.Text & "','" & PasswordBox.Text & "','Staff')", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            conn.Close()

            MessageBox.Show("New Account is created successfuly!")
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            conn.Dispose()

        End Try

    End Sub

    Private Sub ShowExclamation()
        'Show exclamation mark when field is blank'
        If IDBox.Text = "" Then
            ExclamationIcon1.Visible = True
        Else
            ExclamationIcon1.Visible = False
        End If

        If FNameBox.Text = "" Then
            ExclamationIcon2.Visible = True
        Else
            ExclamationIcon2.Visible = False
        End If

        If LNameBox.Text = "" Then
            ExclamationIcon3.Visible = True
        Else
            ExclamationIcon3.Visible = False
        End If

        If Gender = "" Then
            pickgender.Visible = True
        Else
            pickgender.Visible = False
        End If

        If DOBPicker.Text = Date.Now.ToString("yyyy-MM-dd") Then
            ExclamationIcon4.Visible = True
        Else
            ExclamationIcon4.Visible = False
        End If

        If PasswordBox.Text = "" Then
            ExclamationIcon5.Visible = True
        Else
            ExclamationIcon5.Visible = False
        End If

        If CPasswordBox.Text = "" Then
            ExclamationIcon6.Visible = True
        Else
            ExclamationIcon6.Visible = False
        End If
    End Sub

    Private Sub PasswordSOH_Click(sender As Object, e As EventArgs) Handles PasswordSOH.Click
        'Button to show or hide password character"
        If (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye) Then
            PasswordBox.UseSystemPasswordChar = False
            CPasswordBox.UseSystemPasswordChar = False
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        ElseIf (PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.EyeSlash) Then
            PasswordBox.UseSystemPasswordChar = True
            CPasswordBox.UseSystemPasswordChar = True
            PasswordSOH.IconChar = FontAwesome.Sharp.IconChar.Eye
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton2.Click
        'Button to cancel creation of new staff ID'
        Me.Close()
        AdminPage.Show()
    End Sub

End Class