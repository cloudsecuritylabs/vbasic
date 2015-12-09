Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Const dblSLICE As Double = 14.125
        Const dblPI As Double = 3.14159

        Dim dblArea As Double = dblPI * CDbl(txtDiameterOfPizza.Text) * CDbl(txtDiameterOfPizza.Text) / 4.0

        lblSlices.Text = (dblArea / dblSLICE).ToString("n0")
        txtDiameterOfPizza.Focus()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblSlices.Text = String.Empty
        txtDiameterOfPizza.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
