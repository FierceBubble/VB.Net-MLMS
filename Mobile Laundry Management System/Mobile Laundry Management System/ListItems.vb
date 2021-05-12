Imports MySql.Data.MySqlClient

Public Class ListItems
    Private Sub ListItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As MySqlConnection = New MySqlConnection(SignIn.connquery)

        If AdminPage.billnumber = 0 Then
            Try

                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.history where 
                                                        BillNumber='" & CustomerPersonalInformation.billnumber & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim count As Integer

                count = 0
                While rdr.Read
                    count += 1

                End While
                If count = 1 Then
                    CustomerLabel.Text = rdr("CustomerName")
                    BillLabel.Text = rdr("BillNumber")
                    StaffLabel.Text = rdr("StaffName")
                    DOLLabel.Text = rdr("DateofStart").ToString
                    DOCLabel.Text = rdr("DateofCollection").ToString
                    WeightLabel.Text = "" + Convert.ToInt32(rdr("Weight")).ToString + "kg"
                    CostLabel.Text = "RM" + rdr("TotalAmountPaid").ToString
                    TClothesLabel.Text = rdr("TotalCloth")

                    SuitsLabel.Text = rdr("Suits")
                    JacketsLabel.Text = rdr("Jackets")
                    SweaterLabel.Text = rdr("Sweater")
                    BatikLabel.Text = rdr("Batik")
                    ShirtsLabel.Text = rdr("Shirts")
                    DressesLabel.Text = rdr("Dresses")
                    TShirtLabel.Text = rdr("TShirt")
                    TrouserLabel.Text = rdr("Trouser")
                    PantsLabel.Text = rdr("Pants")
                    BedCLabel.Text = rdr("Bed_Cover")
                    SkirtsLabel.Text = rdr("Skirts")
                    PillowSLabel.Text = rdr("Pillow_Sheet")
                    BedSLabel.Text = rdr("Bed_Sheet")
                    TowelsLabel.Text = rdr("Towels")
                    BlanketsLabel.Text = rdr("Blankets")
                    OthersLabel.Text = rdr("Others")
                End If
                conn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        ElseIf CustomerPersonalInformation.billnumber = 0 Then
            Try

                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select * from mlms.history where 
                                                        BillNumber='" & AdminPage.billnumber & "'", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim count As Integer

                count = 0
                While rdr.Read
                    count += 1

                End While
                If count = 1 Then
                    CustomerLabel.Text = rdr("CustomerName")
                    BillLabel.Text = rdr("BillNumber")
                    StaffLabel.Text = rdr("StaffName")
                    DOLLabel.Text = rdr("DateofStart").ToString
                    DOCLabel.Text = rdr("DateofCollection").ToString
                    WeightLabel.Text = "" + Convert.ToInt32(rdr("Weight")).ToString + "kg"
                    CostLabel.Text = "RM" + rdr("TotalAmountPaid").ToString
                    TClothesLabel.Text = rdr("TotalCloth")

                    SuitsLabel.Text = rdr("Suits")
                    JacketsLabel.Text = rdr("Jackets")
                    SweaterLabel.Text = rdr("Sweater")
                    BatikLabel.Text = rdr("Batik")
                    ShirtsLabel.Text = rdr("Shirts")
                    DressesLabel.Text = rdr("Dresses")
                    TShirtLabel.Text = rdr("TShirt")
                    TrouserLabel.Text = rdr("Trouser")
                    PantsLabel.Text = rdr("Pants")
                    BedCLabel.Text = rdr("Bed_Cover")
                    SkirtsLabel.Text = rdr("Skirts")
                    PillowSLabel.Text = rdr("Pillow_Sheet")
                    BedSLabel.Text = rdr("Bed_Sheet")
                    TowelsLabel.Text = rdr("Towels")
                    BlanketsLabel.Text = rdr("Blankets")
                    OthersLabel.Text = rdr("Others")
                End If
                conn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try
        End If


    End Sub

    Private Sub OKList_Click(sender As Object, e As EventArgs) Handles OKList.Click
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class