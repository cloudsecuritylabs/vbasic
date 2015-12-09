Public Class FormCalculator
    'declare global variables to store two numbers
    Dim dblFirstNumber = 1 'default value
    Dim dblSecondNumber = 1 ' Default Value

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'Perform division; convert to number before math operations.
        dblFirstNumber = Convert.ToDouble(txtFirstNumber.Text)
        dblSecondNumber = Convert.ToDouble(TxtSecondNumber.Text)
        lblAnswer.Text = (dblFirstNumber / dblSecondNumber).ToString

    End Sub

    Private Sub txtFirstNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add the two numbers, convert to number before math operations.
        dblFirstNumber = Convert.ToDouble(txtFirstNumber.Text)
        dblSecondNumber = Convert.ToDouble(TxtSecondNumber.Text)
        lblAnswer.Text = (dblFirstNumber + dblSecondNumber).ToString

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        'Subtract the two numbers, convert to number before math operations.
        dblFirstNumber = Convert.ToDouble(txtFirstNumber.Text)
        dblSecondNumber = Convert.ToDouble(TxtSecondNumber.Text)
        lblAnswer.Text = (dblFirstNumber - dblSecondNumber).ToString

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'Multiply the two numbers, convert to number before math operations.
        dblFirstNumber = Convert.ToDouble(txtFirstNumber.Text)
        dblSecondNumber = Convert.ToDouble(TxtSecondNumber.Text)
        lblAnswer.Text = (dblFirstNumber * dblSecondNumber).ToString

    End Sub
End Class
