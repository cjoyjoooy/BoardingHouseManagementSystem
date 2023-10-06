Public Class billAddForm
    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click

        Try
            Dim ElectricityBill, WaterBill, MaintenanceBill, MiscBill As Double
            Dim currentDate As DateTime = DateTime.Today
            Dim monthh As String = currentDate.ToString("yyyy-MM-dd")

            If String.IsNullOrEmpty(txtElectricity.Text) OrElse Not Double.TryParse(txtElectricity.Text, ElectricityBill) Then
                MessageBox.Show("Invalid or empty number of persons entered. Please enter a valid integer value.")
                Return
            ElseIf String.IsNullOrEmpty(txtMaintainance.Text) OrElse Not Double.TryParse(txtMaintainance.Text, MaintenanceBill) Then
                MessageBox.Show("Invalid or empty number of persons entered. Please enter a valid integer value.")
                Return
            ElseIf String.IsNullOrEmpty(txtWaterBill.Text) OrElse Not Double.TryParse(txtWaterBill.Text, WaterBill) Then
                MessageBox.Show("Invalid or empty number of persons entered. Please enter a valid integer value.")
                Return
            ElseIf String.IsNullOrEmpty(txtMiscellaneous.Text) OrElse Not Double.TryParse(txtMiscellaneous.Text, MiscBill) Then
                MessageBox.Show("Invalid or empty number of persons entered. Please enter a valid integer value.")
                Return
            Else
                add_Bill(ElectricityBill, WaterBill, MaintenanceBill, MiscBill, monthh)
                billSec()
                display_Bill()
                earningsSec()
                display_Earnings()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class