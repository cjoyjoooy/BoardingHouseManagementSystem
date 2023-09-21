Public Class billEditForm
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEditBill_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        Dim ElectricityBill, WaterBill, MaintenanceBill, MiscBill As Double
        Dim BillID As Integer

        BillID = txtBillID.Text
        ElectricityBill = txtElectricity.Text
        WaterBill = txtWater.Text
        MaintenanceBill = txtMaintenance.Text
        MiscBill = txtMisc.Text

        edit_Bill(ElectricityBill, WaterBill, MaintenanceBill, MiscBill, BillID)
        display_Bill()
        Me.Close()
    End Sub
End Class