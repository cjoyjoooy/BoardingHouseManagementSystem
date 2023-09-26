Public Class Dashboard
    Private Sub btnShowTransactionPanel_Click(sender As Object, e As EventArgs) Handles btnShowTransactionPanel.Click
        changePanel(Transaction)
        Home.btnDashboard.Checked = False
        Home.btnTransaction.Checked = True
    End Sub
End Class