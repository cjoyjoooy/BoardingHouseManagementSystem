Public Class tenantPayForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim amountPaid As Integer
        Dim tenantID As String


        tenantID = lblTenantID.Text

        If String.IsNullOrEmpty(amoundPaidtxt.Text) OrElse Not Integer.TryParse(amoundPaidtxt.Text, amountPaid) Then
            MessageBox.Show("Invalid or empty amount entered. Please enter a valid integer amount.")
            Return ' Exit the event handler.

        Else
            Dim currentDate As DateTime = DateTime.Today
            Dim dateNow As String = currentDate.ToString("yyyy-MM-dd")
            Dim monthNumber As Integer = DateAndTime.Month(DateTime.Now)
            Dim monthName As String = DateAndTime.MonthName(monthNumber)
            transactionPaid(amountPaid, tenantID, dateNow)
            earningsSec()
            profSummary()
            MessageBox.Show("Successful Transaction!")


        End If


        Me.Close()
    End Sub


End Class