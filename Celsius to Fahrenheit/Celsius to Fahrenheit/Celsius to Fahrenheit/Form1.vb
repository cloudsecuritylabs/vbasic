Public Class Form1

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dblTemp As Double = CDbl(txtCelcius.Text)

        lblFahrenheit.Text = (dblTemp * 1.8 + 32).ToString

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelcius.Clear()
        lblFahrenheit.Text = String.Empty
        txtCelcius.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
