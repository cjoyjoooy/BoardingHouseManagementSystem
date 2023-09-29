Public Class tenantEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditTenant_Click(sender As Object, e As EventArgs) Handles btnEditTenant.Click
        Dim FirstName, LastName, Gender, Address, ContactNum, DateLeased As String
        Dim RoomID, TenandID As Integer

        FirstName = txtFname.Text
        LastName = txtLname.Text
        Gender = cmbGender.Text
        Address = txtAddress.Text
        ContactNum = txtContact.Text
        DateLeased = dtpDate.Value
        RoomID = cmbRoom.Text
        TenandID = txtTenandID.Text
        edit_Tenant(FirstName, LastName, Gender, Address, ContactNum, DateLeased, RoomID, TenandID)
        display_Tenant()
        Me.Close()
    End Sub
End Class