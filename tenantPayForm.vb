Public Class tenantPayForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim amountPaid As Integer
        Dim tenantID As String

        amountPaid = amoundPaidtxt.Text
        tenantID = lblTenantID.Text
        Dim currentDate As DateTime = DateTime.Today
        Dim dateNow As String = currentDate.ToString("yyyy-MM-dd")
        Dim monthNumber As Integer = DateAndTime.Month(DateTime.Now)
        Dim monthName As String = DateAndTime.MonthName(monthNumber)
        transactionPaid(amountPaid, tenantID, dateNow)
        earningsSec()
        profSummary()
        MsgBox(amountPaid & tenantID & dateNow & monthName)

        Me.Close()
    End Sub


End Class