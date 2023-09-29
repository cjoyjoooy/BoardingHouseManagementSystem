Public Class tenantAddForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        Dim fname, lname, gender, address, contact, lease As String
        Dim room As Integer
        fname = txtFname.Text
        lname = txtLname.Text
        gender = cmbGender.SelectedItem
        address = txtAddress.Text
        contact = txtContact.Text
        room = CInt(cmbRoom.SelectedValue)
        lease = dtpLease.Value

        add_Tenant(fname, lname, gender, address, contact, lease, "Active", room)
        check_Occupant_Number(room)
        If Rooms.addroompanel IsNot Nothing Then
            Rooms.addroompanel.Controls.Clear()
            display_Rooms()
            Rooms.lblMonthlyRent.Text = "--"
            Rooms.lblNumOccupants.Text = "--"
            Rooms.lblStatus.Text = "--"
            Rooms.lblRoomNumber.Text = "--"
        End If
        display_Tenant()
        Me.Close()
    End Sub

End Class