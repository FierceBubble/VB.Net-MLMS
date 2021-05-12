Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class TopUpForm

    Dim TotalTopUP As Decimal 'To capture amount of top-up when either 10 or 20 or 30 or 50 is checked 
    ''                        'or Other value is inserted'
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles TopUp10.CheckedChanged
        TotalTopUP = 10    'Capture value into a Integer, so it is readable for MySql database'
    End Sub

    Private Sub TopUp20_CheckedChanged(sender As Object, e As EventArgs) Handles TopUp20.CheckedChanged
        TotalTopUP = 20    'Capture value into a Integer, so it is readable for MySql database'
    End Sub

    Private Sub TopUp30_CheckedChanged(sender As Object, e As EventArgs) Handles TopUp30.CheckedChanged
        TotalTopUP = 30    'Capture value into a Integer, so it is readable for MySql database'
    End Sub

    Private Sub TopUp50_CheckedChanged(sender As Object, e As EventArgs) Handles TopUp50.CheckedChanged
        TotalTopUP = 50    'Capture value into a Integer, so it is readable for MySql database'
    End Sub


    Private Sub ConfirmTopUpButton(sender As Object, e As EventArgs) Handles ConfirmTopUp.Click
        ShowExclamation()
        'Check some conditions before Top-up'
        If CustomerIDBox.Text = "" Then
            WrongLabel.Text = "* Please fill the customer account ID"
            WrongLabel.Visible = True

        Else
            'Check if ther customer ID is exist'
            Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)
            Try
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.customer where 
                                                            CustomerID='" & CustomerIDBox.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                Dim count As Integer

                count = 0
                While rdr.Read
                    count += 1

                End While

                If count = 0 Then
                    CustomerIDBox.Clear()
                    WrongLabel.Text = "* Customer Account ID does not exist!"
                    WrongLabel.Visible = True
                    ExclamationIcon2.Visible = True

                ElseIf count = 1 Then
                    'When conditions met, initiate TopUp()'
                    TopUpID()

                End If

                conn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try


        End If
    End Sub

    Private Sub TopUpID()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)
        Try
            conn.Open()
            'Determine the value of top-up'
            If OtherValue.Text = "" Or OtherValue.Text = "0" Then
                Dim cmd As MySqlCommand = New MySqlCommand("update mlms.customer set 
                                                           CreditBalance= CreditBalance +'" & TotalTopUP & "'Where 
                                                           CustomerID ='" & CustomerIDBox.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                OtherValue.Clear()
                CustomerIDBox.Clear()
                WrongLabel.Visible = False
                MessageBox.Show("Top-Up is successful")
            Else
                TotalTopUP = OtherValue.Text
                Dim cmd As MySqlCommand = New MySqlCommand("update mlms.customer set 
                                                           CreditBalance=CreditBalance+'" & TotalTopUP & "'Where
                                                           CustomerID ='" & CustomerIDBox.Text & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                OtherValue.Clear()
                CustomerIDBox.Clear()
                WrongLabel.Visible = False
                MessageBox.Show("Top-Up is successful")
            End If


            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Back button to go back to the main menu'
        StaffMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ShowExclamation()
        'Show exclamation mark when field is blank'
        If CustomerIDBox.Text = "" Then
            ExclamationIcon2.Visible = True
        Else
            ExclamationIcon2.Visible = False
        End If

    End Sub

    Private Sub OtherValue_KeyPress(sender As Object, e As EventArgs) Handles OtherValue.KeyPress
        NumberOnlyDecimal(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Public Sub NumberOnlyDecimal(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then
            'Asc(e.KeyChar) >= 48 and Asc(e.KeyChar) <= 57 // Allow number 0 to 9'
            'Asc(e.KeyChar) = 46 // Allow decimal (comma)'
            'Asc(e.KeyChar) = 8 // Allow backspace'
        Else
            e.Handled = True
        End If
    End Sub


End Class