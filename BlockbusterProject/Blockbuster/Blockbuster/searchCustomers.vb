Public Class searchCustomers
    Private Sub searchCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlockbustersDataSet.Memberships' table. You can move, or remove it, as needed.
        Me.MembershipsTableAdapter.Fill(Me.BlockbustersDataSet.Memberships)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If radMembershipID.Checked = True Then
            Try
                Me.MembershipsTableAdapter.FillByID(Me.BlockbustersDataSet.Memberships, CType(txtSearch.Text, Integer))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        ElseIf radLastName.Checked = True Then
            Try
                Me.MembershipsTableAdapter.FillByName(Me.BlockbustersDataSet.Memberships, CType(txtSearch.Text, String))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please Select a Search Criteria")
        End If
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(0)
        Form1.selectedCustomerID = Convert.ToInt32(row.Cells(2).Value.ToString)
    End Sub
End Class