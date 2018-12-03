Public Class frmLab1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblIncomeyear.Text = Val(txtSalary.Text) * 12
        lblVat.Text = Val(lblIncomeyear.Text) * 0.05
        lblIncomeAfterVat.Text = lblIncomeyear.Text - lblVat.Text








    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
