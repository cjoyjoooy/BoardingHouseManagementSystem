Imports System.Data.SQLite

Public Class tenantArchive
    Private Sub tenantArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_TenantArchive()
    End Sub

    Private Sub dgvArchiveTenant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchiveTenant.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        changePanel(Tenant)
    End Sub

    Private Sub btnTenantRestore_Click(sender As Object, e As EventArgs) Handles btnTenantRestore.Click
        Try
            Dim rowIndex, tenantId, RoomId As Integer
            rowIndex = dgvArchiveTenant.CurrentRow.Index
            tenantId = dgvArchiveTenant.Rows(rowIndex).Cells(0).Value.ToString
            RoomId = dgvArchiveTenant.Rows(rowIndex).Cells(8).Value.ToString
            restore_Tenant("Active", tenantId)
            check_Occupant_Number(RoomId)
            If Rooms.addroompanel IsNot Nothing Then
                Rooms.addroompanel.Controls.Clear()
                display_Rooms()
                Rooms.lblMonthlyRent.Text = "--"
                Rooms.lblNumOccupants.Text = "--"
                Rooms.lblStatus.Text = "--"
                Rooms.lblRoomNumber.Text = "--"
            End If
            display_Tenant()
            display_TenantArchive()
        Catch ex As SQLiteException
            MessageBox.Show("Error:   " & ex.Message)
        End Try
    End Sub
End Class