Public Class billEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        Dim ElectricityBill, WaterBill, MaintenanceBill, MiscBill As Double

        ElectricityBill = txtElectricityBill.Text
        WaterBill = txtWaterBill.Text
        MaintenanceBill = txtMaintenanceBill.Text
        MiscBill = txtMiscBill.Text

        edit_Bill(ElectricityBill, WaterBill, MaintenanceBill, MiscBill)
        Me.Close()
    End Sub
End Class