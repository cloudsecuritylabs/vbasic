Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtScore1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtScore3.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim result As Double
        result = CDbl(txtScore1.Text) + CDbl(txtScore2.Text) + CDbl(txtScore3.Text) + CDbl(txtScore4.Text) + CDbl(txtScore5.Text)
        result = result / 5
        lblAverage.Text = result.ToString


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAverage.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
