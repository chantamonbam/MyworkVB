Public Class frmLab2


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim SalseVistra As Integer
        Dim SalseFrista As Integer
        Dim TotalSelse As Integer
        Dim Commission1 As Long
        Dim Commission2 As Long
        Dim TotalCommission As Long

        SalseVistra = Val(txtSalesVistra.Text)
        SalseFrista = Val(txtSalseFrista.Text)

        TotalSelse = SalseVistra + SalseFrista

        Commission1 = SalseVistra * 0.05
        Commission2 = SalseFrista * 0.1
        TotalCommission = Commission1 + Commission2





        lblTotalSalse.Text = Val(txtSalesVistra.Text) + Val(txtSalseFrista.Text)
        lblCommission1.Text = Val(txtSalesVistra.Text) * 0.05
        lblCommossion2.Text = Val(txtSalseFrista.Text) * 0.1
        lblTotalCommission.Text = Val(lblCommission1.Text) + Val(lblCommossion2.Text)

        lblTotalSalse.BackColor = Color.DeepSkyBlue
        lblTotalCommission.BackColor = Color.ForestGreen



    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class