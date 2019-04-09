Public Class Form1
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

        chkList_Movies.Items.Add("Attack of the Killer Tomatoes")
        chkList_Movies.Items.Add("Elvira: Mistress of the Dark")
        chkList_Movies.Items.Add("Hunger Games")
        chkList_Movies.Items.Add("Iron Giant")
        chkList_Movies.Items.Add("Pulp Fiction")
        chkList_Movies.Items.Add("Reservoir Dogs")
        chkList_Movies.Items.Add("Resident Evil")
        chkList_Movies.Items.Add("Revenge of the Nerds")
        chkList_Movies.Items.Add("Star Wars")
        chkList_Movies.Items.Add("Titan A.E.")

        CBDuration.Items.Add("2 Days")
        CBDuration.Items.Add("1 Week")
        CBDuration.Items.Add("2 Weeks")
    End Sub





    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
