Public Class tenantArchive
    Private Sub tenantArchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_TenantArchive()
    End Sub

    Private Sub dgvArchiveTenant_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchiveTenant.CellContentClick

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class