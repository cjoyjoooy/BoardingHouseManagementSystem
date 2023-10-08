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
            Dim fname, lname, name As String
            Dim rowIndex As Integer
            rowIndex = dgvArchiveTenant.CurrentRow.Index
            fname = dgvArchiveTenant.Rows(rowIndex).Cells(1).Value.ToString
            lname = dgvArchiveTenant.Rows(rowIndex).Cells(2).Value.ToString
            name = fname & " " & lname

            populate_cmbRoom()
            tenantArchiveRestoreForm.lbltenantName.Text = name
            tenantArchiveRestoreForm.Show()
        Catch ex As SQLiteException

        End Try



    End Sub
End Class