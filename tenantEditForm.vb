Public Class tenantEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditTenant_Click(sender As Object, e As EventArgs) Handles btnEditTenant.Click
        Dim FirstName, LastName, Gender, Address, ContactNum, DateLeased As String
        Dim RoomID, TenandID, checkroomId, rowIndex As Integer

        rowIndex = Tenant.dgvTenant.CurrentRow.Index
        checkroomId = Tenant.dgvTenant.Rows(rowIndex).Cells(8).Value.ToString

        FirstName = txtFname.Text
        LastName = txtLname.Text
        Gender = cmbGender.Text
        Address = txtAddress.Text
        ContactNum = txtContact.Text
        DateLeased = dtpDate.Value
        RoomID = Integer.Parse(cmbRoom.SelectedValue.ToString())
        TenandID = Integer.Parse(txtTenandID.Text)
        edit_Tenant(FirstName, LastName, Gender, Address, ContactNum, DateLeased, RoomID, TenandID)
        check_Occupant_Number(checkroomId)
        check_Occupant_Number(RoomID)
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