Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblInputValidated As Double = 0.0

        If Double.TryParse(txtDistance.Text, dblInputValidated) AndAlso CDbl(txtDistance.Text) > 0 Then

            If radAir.Checked Then
                lblTimeCalculated.Text = (dblInputValidated / 1100.0).ToString("n2") & " seconds"
            ElseIf radWater.Checked Then
                lblTimeCalculated.Text = (dblInputValidated / 4900.0).ToString("n2") & " seconds"
            ElseIf radSteel.Checked Then
                lblTimeCalculated.Text = (dblInputValidated / 16400.0).ToString("n2") & " seconds"
            End If
        Else
            MessageBox.Show("Please correct input. Must ne numeric and greater than zero")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDistance.Clear()
        lblTimeCalculated.Text = String.Empty
    End Sub
End Class
