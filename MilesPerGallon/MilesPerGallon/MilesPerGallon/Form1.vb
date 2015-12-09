Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim result As Double = CDbl(txtMiles.Text) / CDbl(txtGallons.Text)
        lblGallonsPerMile.Text = result.ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Text = " "
        txtMiles.Text = " "
        lblGallonsPerMile.Text = " "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
