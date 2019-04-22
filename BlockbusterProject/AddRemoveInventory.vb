'AddRemoveInventory.vb
'Caleb Stone
'04/15/2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class AddRemoveInventory

    Private Sub AddRemoveInventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddRemoveInventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MovieRentalDataSet)

    End Sub

    Private Sub AddRemoveInventoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AddRemoveInventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MovieRentalDataSet)

    End Sub


    Private Sub AddRemoveInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' temporary
        ' fix this
        Me.MovieRentalTableAdapter.Fill(Me.MovieRentalDataSet.Movie)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class