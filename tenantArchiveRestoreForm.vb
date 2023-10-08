Imports System.Data.SQLite

Public Class tenantArchiveRestoreForm
    Private Sub btnRestoreTenant_Click(sender As Object, e As EventArgs) Handles btnRestoreTenant.Click
        Try
            Dim rowIndex, tenantId, RoomId As Integer
            rowIndex = tenantArchive.dgvArchiveTenant.CurrentRow.Index
            tenantId = tenantArchive.dgvArchiveTenant.Rows(rowIndex).Cells(0).Value.ToString
            RoomId = Integer.Parse(cmbRestoreRoom.SelectedValue.ToString())
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
            Me.Close()
        Catch ex As SQLiteException
            MessageBox.Show("Error:   " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class