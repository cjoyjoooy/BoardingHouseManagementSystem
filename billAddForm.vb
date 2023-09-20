Public Class billAddForm
    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click
        Dim ElectricityBill, WaterBill, MaintenanceBill, MiscBill As Double

        ElectricityBill = txtElectricity.Text
        WaterBill = txtWaterBill.Text
        MaintenanceBill = txtMaintainance.Text
        MiscBill = txtMiscellaneous.Text

        add_Bill(ElectricityBill, WaterBill, MaintenanceBill, MiscBill)
        display_Bill()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class