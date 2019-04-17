Public Class Update_Movie_Inventory
    Public MovieID As Integer
    Private Sub MoviesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BlockbustersDataSet)

    End Sub

    Private Sub Update_Movie_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Movies' table. You can move, or remove it, as needed.
        Me.MoviesTableAdapter.Fill(Me.BlockbustersDataSet.Movies)

    End Sub

    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click
        Me.MoviesTableAdapter.InsertQuery(TBMovID.Text, TBTitle.Text, DTPRelease.Value, TBRate.Text, TBMov_Type.Text)
        TBMovID.Text = " "
        TBTitle.Text = " "
        TBRate.Text = " "
        TBMov_Type.Text = " "

        Me.MoviesTableAdapter.Update(BlockbustersDataSet.Movies)
        Me.Close()
    End Sub

    Private Sub BTNSave_Click(sender As Object, e As EventArgs) Handles BTNSave.Click
    End Sub
End Class