Public Class tenantAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        Dim fname, lname, gender, address, contact, room, lease, status As String
        add_tenant(fname, lname, gender, address, contact, room, lease, status)
    End Sub
End Class