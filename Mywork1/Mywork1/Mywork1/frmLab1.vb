Public Class frmLab1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblYear.Text = Val(txtSalary.Text) * 12
        lblTax.Text = Val(lblYear.Text) * 0.05
        lblAfterTax.Text = lblYear.Text - lblTax.Text

        lblAfterTax.BackColor = Color.OrangeRed
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
