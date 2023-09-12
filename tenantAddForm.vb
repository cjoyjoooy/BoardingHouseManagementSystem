Public Class tenantAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        Dim fname, lname, gender, address, contact, room, lease, status As String
        fname = txtFname.Text
        lname = txtLname.Text
        If rbdFemale.Checked = True Then
            gender = "Female"
        ElseIf Male.Checked = True Then
            gender = "Male"
        End If
        address = txtAddress.Text
        contact = txtContact.Text
        room = cmbRoom.SelectedItem
        status = cmbStatus.SelectedItem
        lease = dtpLease.Value

        add_tenant(fname, lname, gender, address, contact, room, lease, status)
    End Sub
End Class