Public Class billAddForm
    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        Dim ElectricityBill, WaterBill, MaintenanceBill, MiscBill As Double

        ElectricityBill = txtElectricity.Text
        WaterBill = txtWaterBill.Text
        MaintenanceBill = txtMaintainance.Text
        MiscBill = txtMiscellaneous.Text

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class