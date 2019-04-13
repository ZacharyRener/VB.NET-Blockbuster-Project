Public Class Form1
    Public Tax As Double
    Public Total As Double
    Public RentalFee As Double


    Private Sub InvoiceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.InvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BlockbustersDataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Rentals' table. You can move, or remove it, as needed.
        Me.RentalsTableAdapter.Fill(Me.BlockbustersDataSet.Rentals)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movie_Inventory' table. You can move, or remove it, as needed.
        Me.Movie_InventoryTableAdapter.Fill(Me.BlockbustersDataSet.Movie_Inventory)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Memberships' table. You can move, or remove it, as needed.
        Me.MembershipsTableAdapter.Fill(Me.BlockbustersDataSet.Memberships)
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.BlockbustersDataSet.Invoice)



        CBDuration.Items.Add("2 Days")
        CBDuration.Items.Add("1 Week")
        CBDuration.Items.Add("2 Weeks")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub



    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

    End Sub

    Private Sub ADD_Remove_Click(sender As Object, e As EventArgs) Handles ADD_Remove.Click
        Update_Movie_Inventory.Show()
    End Sub
End Class
