Imports MySql.Data.MySqlClient

Public Class NewLaundry
    Dim Fullname As String      'To canputer the full name of the customer from the customer database table'

    Dim TotalClothes As Integer 'To capture the amount of clothes will be in the laundry'

    Dim TotalPaid As Decimal    'To determine the total price (RM5 per kg)'

    Dim CCB As Decimal

    Private Sub NewLaundryConfirmation(sender As Object, e As EventArgs) Handles ConfirmNewLaundry.Click
        'Check some conditions before adding new laundry'
        ShowExclamation()

        If CustomerIDBox.Text = "" Or TotalWeight.Text = "" Or TotalWeight.Text = "0" Then
            WrongLabel.Text = "* Please fill the blank fields!"
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
                    ExclamationIcon1.Visible = True


                ElseIf count = 1 Then

                    'To determine the total piece(s) of clothes for laundry'
                    TotalClothes = Convert.ToInt32(SuitsTotal.Text) + Convert.ToInt32(JacketsTotal.Text) +
                                   Convert.ToInt32(ShirtsTotal.Text) + Convert.ToInt32(SweaterTotal.Text) +
                                   Convert.ToInt32(BatikTotal.Text) + Convert.ToInt32(TShirtTotal.Text) +
                                   Convert.ToInt32(DressesTotal.Text) + Convert.ToInt32(PantsTotal.Text) +
                                   Convert.ToInt32(TrouserTotal.Text) + Convert.ToInt32(SkirtsTotal.Text) +
                                   Convert.ToInt32(BedCoverTotal.Text) + Convert.ToInt32(BedSheetTotal.Text) +
                                   Convert.ToInt32(PillowSheetTotal.Text) + Convert.ToInt32(BlanketsTotal.Text) +
                                   Convert.ToInt32(TowelsTotal.Text) + Convert.ToInt32(OthersTotal.Text)


                    TotalPaid = CDec(TotalWeight.Text) * 5


                    'When conditions met, initiate ConfirmNewLaundryInfo()'
                    Dim Fname As String = rdr("FirstName")
                    Dim Lname As String = rdr("LastName")
                    CCB = rdr("CreditBalance")
                    Fullname = Fname.ToString + " " + Lname.ToString

                    Dim dialog As DialogResult
                    dialog = MessageBox.Show("Total cost: RM" & TotalPaid & "", "Confirmation", MessageBoxButtons.OKCancel)

                    If dialog = DialogResult.OK Then
                        CheckCreditBalance()
                    Else

                    End If

                End If

                conn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
        End If

    End Sub

    'Private Sub ConfirmationOKCancel(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs)

    ' End Sub

    Private Sub CheckCreditBalance()

        'Check if customer have enough credit balance in their account'
        Dim CBCompare As Decimal = CCB - TotalPaid

        If (CBCompare >= 0) Then
            InsertNewStatus()        'Inserting new data to status database'
            InsertNewHistory()       'Inserting new data to history database'
            UpdateNewCreditBalance() 'Updating the amount of credit balance the customer has 
            ''                       'after paying for the laundry'
            WrongLabel.Visible = False
            MessageBox.Show("New laundry is created successfuly!")

            'Resetting all the values to "0" for other customers'
            CustomerIDBox.Clear()
            TotalWeight.Clear()
            SuitsTotal.Text = "0"
            JacketsTotal.Text = "0"
            SweaterTotal.Text = "0"
            ShirtsTotal.Text = "0"
            BatikTotal.Text = "0"
            TShirtTotal.Text = "0"
            DressesTotal.Text = "0"
            PantsTotal.Text = "0"
            TrouserTotal.Text = "0"
            SkirtsTotal.Text = "0"
            BedCoverTotal.Text = "0"
            BedSheetTotal.Text = "0"
            PillowSheetTotal.Text = "0"
            BlanketsTotal.Text = "0"
            TowelsTotal.Text = "0"
            OthersTotal.Text = "0"

        ElseIf (CBCompare < 0) Then
            'A pop-up will show if customer's credit balance is insufficient
            MessageBox.Show("Customer's credit balance is insufficient" & vbCrLf & "Please top-up!")
        End If

    End Sub
    Private Sub InsertNewStatus()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Inserting new data to status database'
        Try
            Dim LStatus As String = "Waiting"
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("insert into mlms.status (LaundryStatus, StaffName, 
                                                        CustomerName, TotalCloth) values
                                                      ('" & LStatus & "','" & SignIn.COSName & "',
                                                      '" & Fullname & "','" & TotalClothes & "')", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub InsertNewHistory()
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Inserting new data to history database'
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("insert into mlms.history 
                                     (CustomerName, StaffName, DateofStart, TotalAmountPaid, TotalCloth, 
                                      Weight, Suits, Jackets, Sweater, Shirts, Batik, TShirt, Dresses, Pants, 
                                      Trouser, Skirts, Bed_Cover, Bed_Sheet, Pillow_Sheet, Blankets, Towels, Others) 
                                      values ('" & Fullname & "','" & SignIn.COSName & "',
                                      '" & DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") & "','" & TotalPaid & "',
                                      '" & TotalClothes & "','" & Convert.ToDecimal(TotalWeight.Text) & "','" & Convert.ToInt32(SuitsTotal.Text) & "',
                                      '" & Convert.ToInt32(JacketsTotal.Text) & "','" & Convert.ToInt32(SweaterTotal.Text) & "','" & Convert.ToInt32(ShirtsTotal.Text) & "',
                                      '" & Convert.ToInt32(BatikTotal.Text) & "','" & Convert.ToInt32(TShirtTotal.Text) & "','" & Convert.ToInt32(DressesTotal.Text) & "',
                                      '" & Convert.ToInt32(PantsTotal.Text) & "','" & Convert.ToInt32(TrouserTotal.Text) & "','" & Convert.ToInt32(SkirtsTotal.Text) & "',
                                      '" & Convert.ToInt32(BedCoverTotal.Text) & "','" & Convert.ToInt32(BedSheetTotal.Text) & "',
                                      '" & Convert.ToInt32(PillowSheetTotal.Text) & "','" & Convert.ToInt32(BlanketsTotal.Text) & "',
                                      '" & Convert.ToInt32(TowelsTotal.Text) & "','" & Convert.ToInt32(OthersTotal.Text) & "')
                                      ", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub UpdateNewCreditBalance()

        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        'Updating the amount of credit balance the customer has after paying for the laundry'
        Try
            conn.Open()

            'Changes that is made to their personal information'
            Dim cmd As MySqlCommand = New MySqlCommand("update  mlms.customer set 
                                          CreditBalance =CreditBalance-'" & TotalPaid & "'where 
                                          CustomerID='" & CustomerIDBox.Text & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            conn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub
    Private Sub ShowExclamation()
        'Show exclamation mark when field is blank'
        If CustomerIDBox.Text = "" Then
            ExclamationIcon1.Visible = True
        Else
            ExclamationIcon1.Visible = False
        End If

        If TotalWeight.Text = "0" Then
            ExclamationIcon2.Visible = True
        Else
            ExclamationIcon2.Visible = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Button to cancel new laundry and return them to the main menu'

        StaffMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub TotalWeight_KeyPress(sender As Object, e As EventArgs) Handles TotalWeight.KeyPress
        'To make sure that the input only allow numbers through conditions from NumberOnlyDecimal(e)'
        TopUpForm.NumberOnlyDecimal(e)
    End Sub

    Private Sub SuitsTotal_KeyPress(sender As Object, e As EventArgs) Handles SuitsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub JacketsTotal_KeyPress(sender As Object, e As EventArgs) Handles JacketsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub ShirtsTotal_KeyPress(sender As Object, e As EventArgs) Handles ShirtsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub BatikTotal_KeyPress(sender As Object, e As EventArgs) Handles BatikTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub TShirtTotal_KeyPress(sender As Object, e As EventArgs) Handles TShirtTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub DressesTotal_KeyPress(sender As Object, e As EventArgs) Handles DressesTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub PantsTotal_KeyPress(sender As Object, e As EventArgs) Handles PantsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub TrouserTotal_KeyPress(sender As Object, e As EventArgs) Handles TrouserTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub SkirtsTotal_KeyPress(sender As Object, e As EventArgs) Handles SkirtsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub BedCoverTotal_KeyPress(sender As Object, e As EventArgs) Handles BedCoverTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub BedSheetTotal_KeyPress(sender As Object, e As EventArgs) Handles BedSheetTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub PillowSheet_KeyPress(sender As Object, e As EventArgs) Handles PillowSheetTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub BlanketsTotal_KeyPress(sender As Object, e As EventArgs) Handles BlanketsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub TowelsTotal_KeyPress(sender As Object, e As EventArgs) Handles TowelsTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub OthersTotal_KeyPress(sender As Object, e As EventArgs) Handles OthersTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Private Sub SweaterTotal_KeyPress(sender As Object, e As EventArgs) Handles SweaterTotal.KeyPress
        NumberOnly(e)  'To make sure that the input only allow numbers through conditions from NumberOnly(e)'
    End Sub

    Public Sub NumberOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then
            'Asc(e.KeyChar) >= 48 and Asc(e.KeyChar) <= 57 // Allow number 0 to 9'
            'Asc(e.KeyChar) = 8 // Allow backspace'
        Else
            e.Handled = True
        End If
    End Sub


End Class