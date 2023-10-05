Public Class Transaction
    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_Transaction()
    End Sub

    Private Sub txtSearchTransaction_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTransaction.TextChanged
        Dim search As String
        search = txtSearchTransaction.Text
        Search_Function(search, "Tenant.FirstName || ' ' || Tenant.LastName AS 'Tenant Name', Transactions.DatePaid AS 'Date Paid', Transactions.AmountPaid AS 'Amount'", "Tenant JOIN 'Transaction' AS Transactions ON Tenant.TenandID = Transactions.TenantID", "Tenant.FirstName Or Tenant.LastName", Me.dgvTransaction)
    End Sub
End Class