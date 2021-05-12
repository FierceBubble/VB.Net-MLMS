Imports MySql.Data.MySqlClient

Public Class EditStaffInfo

    Dim EditGender As String                'To capture gender value when either radio button is checked'
    Private Sub MaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles EditMaleRButton.CheckedChanged
        EditGender = "M"                    'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub FemaleRButton_CheckedChanged(sender As Object, e As EventArgs) Handles EditFemaleRButton.CheckedChanged
        EditGender = "F"                    'Capture value into a String, so it is readable for MySql database'
    End Sub

    Private Sub EditPersonalInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Connection to the database with table name: "staff" to retrieve information about the customer'
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.staff where 
                                      StaffID='" & AdminPage.StaffID & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            Dim count As Integer

            count = 0
            While rdr.Read
                count += 1

            End While

            If count = 1 Then
                Dim AID As String = rdr("StaffID")
                EditGender = rdr("Gender")
                Dim ADOB As Date = rdr("DOB")

                EditIDBox.Text = AID
                EditFNameBox.Text = rdr("FirstName")
                EditLNameBox.Text = rdr("LastName")
                EditDOBPicker.Text = ADOB
                StaffRole.Text = rdr("Role")

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
                            EditDOBPicker.Text = "" Then
            'Check if there is any blank box'
            WrongLabel.Visible = True
        Else
            'Conditions are met and customer is allowed to change their personal infromation'
            Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

            Try

                conn.Open()
                'Changes that is made to their personal information'
                Dim cmd As MySqlCommand = New MySqlCommand("update  mlms.staff set 
                                          FirstName='" & EditFNameBox.Text & "',
                                          LastName='" & EditLNameBox.Text & "',
                                          Gender='" & EditGender & "',
                                          DOB='" & EditDOBPicker.Text & "',
                                          Role='" & StaffRole.Text & "',
                                          StaffID='" & EditIDBox.Text & "'where 
                                          FirstName='" & EditFNameBox.Text & "'and 
                                          LastName='" & EditLNameBox.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                MessageBox.Show("Staff information successfuly changed!")

                conn.Close()


                Me.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton1.Click
        'Button to cancel changes made to staff personal infromation'
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

    End Sub
End Class