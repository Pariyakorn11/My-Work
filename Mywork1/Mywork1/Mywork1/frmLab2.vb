Public Class frmLab2

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim SalseVistra As Integer
        Dim SalseFrista As Integer
        Dim SumSalse As Integer
        Dim Commission5 As Long
        Dim Commission10 As Long
        Dim SumCommission As Long

        SalseVistra = Val(txtSalseViater.Text)
        SalseFrista = Val(txtSalseFrita.Text)
        Commission5 = SalseVistra * 0.05
        Commission10 = SalseFrista * 0.1
        SumSalse = SalseVistra + SalseFrista
        SumCommission = Commission5 + Commission10

        lblSumSalse.Text = Val(txtSalseViater.Text) + Val(txtSalseFrita.Text)
        lblCommission5.Text = Val(txtSalseViater.Text) * 0.05
        lblCommission10.Text = Val(txtSalseFrita.Text) * 0.1
        lblSumCommission.Text = Val(lblCommission5.Text) + Val(lblCommission10.Text)


        lblSumSalse.BackColor = Color.OrangeRed
        lblSumCommission.BackColor = Color.OrangeRed
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class