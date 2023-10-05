Imports System.Globalization

Public Class Tenant
    Private Sub Tenant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Tenant()
    End Sub
    Private Sub btnShowAddForm_Click(sender As Object, e As EventArgs) Handles btnShowAddForm.Click
        populate_cmbRoom()
        tenantAddForm.Show()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim tenantname As String
        Dim rowIndex As Integer
        rowIndex = dgvTenant.CurrentRow.Index
        tenantname = dgvTenant.Rows(rowIndex).Cells(1).Value.ToString

        tenantPayForm.lblTenantID.Text = dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
        tenantPayForm.lblTenantName.Text = tenantname
        tenantPayForm.Show()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        changePanel(tenantArchive)
    End Sub

    Private Sub btnTenantBillForm_Click(sender As Object, e As EventArgs) Handles btnShowTenantEditForm.Click
        Dim rowIndex As Integer
        rowIndex = dgvTenant.CurrentRow.Index
        populate_cmbRoom()
        ' Get the RoomName from the DataGridView
        Dim roomName As String = dgvTenant.Rows(rowIndex).Cells(3).Value.ToString

        ' Find the corresponding RoomID in the ComboBox and select it
        For Each item As DataRowView In tenantEditForm.cmbRoom.Items
            If item("RoomID").ToString() = roomName Then
                tenantEditForm.cmbRoom.SelectedItem = item
                Exit For ' Exit the loop once a match is found
            End If
        Next

        tenantEditForm.Show()
    End Sub

    Private Sub btnDeleteTenant_Click(sender As Object, e As EventArgs) Handles btnDeleteTenant.Click

        Dim ask As MsgBoxResult = MsgBox("Are you sure you want to delete this tenant?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then

            Dim rowIndex, TenantID As Integer
            Dim roomId As String

            rowIndex = dgvTenant.CurrentRow.Index
            TenantID = dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
            roomId = dgvTenant.Rows(rowIndex).Cells(8).Value.ToString
            delete_Tenant(TenantID)
            check_Occupant_Number(roomId)
            If Rooms.addroompanel IsNot Nothing Then
                Rooms.addroompanel.Controls.Clear()
                display_Rooms()
                Rooms.lblMonthlyRent.Text = "--"
                Rooms.lblNumOccupants.Text = "--"
                Rooms.lblStatus.Text = "--"
                Rooms.lblRoomNumber.Text = "--"
            End If
            display_Tenant()
        Else
            Return

        End If
    End Sub

    Private Sub dgvTenant_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTenant.CellClick
        Dim rowIndex, TenantID As Integer
        rowIndex = dgvTenant.CurrentRow.Index
        TenantID = dgvTenant.Rows(rowIndex).Cells(0).Value.ToString
        display_tenant_info(TenantID)
        display_Tenant_Billing_info(TenantID)
        display_monthly_pay_rent(TenantID)
    End Sub

    Private Sub txtTenantSearch_TextChanged(sender As Object, e As EventArgs) Handles txtTenantSearch.TextChanged
        Dim search As String
        search = txtTenantSearch.Text
        Search_Tenant_Function(search, Me.dgvTenant)
    End Sub
End Class