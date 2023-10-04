Public Class Dashboard
    Private Sub btnShowTransactionPanel_Click(sender As Object, e As EventArgs) Handles btnShowTransactionPanel.Click
        changePanel(Transaction)
        Home.btnDashboard.Checked = False
        Home.btnTransaction.Checked = True
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Recent_Transaction()
        display_dashboard_Earnigns()
        display_dashboard_Tenants()
        display_dashboard_Rooms()
    End Sub
End Class