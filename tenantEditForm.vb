Public Class tenantEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddTenant_Click(sender As Object, e As EventArgs) Handles btnAddTenant.Click
        Dim FirstName, LastName, Gender, Address, ContactNum, DateLeased, Status As String
        Dim RoomID, TenandID As Integer

        FirstName = txtFname.Text
        LastName = txtLname.Text
        Gender = cmbGender.Text
        Address = txtAddress.Text
        ContactNum = txtContact.Text
        DateLeased = dtpDate.Value
        Status = cmbStatus.Text
        RoomID = cmbRoom.Text
        TenandID = txtTenandID.Text
        edit_Tenant(FirstName, LastName, Gender, Address, ContactNum, DateLeased, Status, RoomID, TenandID)
        display_Tenant()
        Me.Close()
    End Sub
End Class