Public Class tenantAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        Dim fname, lname, gender, address, contact, room, lease As String
        fname = txtFname.Text
        lname = txtLname.Text
        gender = cmbGender.SelectedItem
        address = txtAddress.Text
        contact = txtContact.Text
        room = cmbRoom.SelectedItem
        lease = dtpLease.Value

        add_tenant(fname, lname, gender, address, contact, room, lease, "Active")
    End Sub

End Class