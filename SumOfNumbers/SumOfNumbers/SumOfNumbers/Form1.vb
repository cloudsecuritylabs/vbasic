Public Class Form1
    Private Sub brnEnter_Click(sender As Object, e As EventArgs) Handles brnEnter.Click

        Dim intNumberInput As Integer = 0
        Dim intTotal As Integer = 0
        Dim strInput As String
        'MessageBox.Show(intNumberInput.ToString)
        strInput = InputBox("Enter an integer value")

        If Integer.TryParse(strInput, intNumberInput) AndAlso intNumberInput >= 0 Then
            Do While intNumberInput > 0
                intTotal += intNumberInput
                intNumberInput -= 1
            Loop
            lblMessage.Text = intTotal.ToString
            MessageBox.Show("The sum of numbers 1 through " & strInput & " is " & intTotal.ToString)
        Else
            'MessageBox.Show("Enter an positive integer value please")
            lblMessage.Text = "Enter a positive integer value please"
            lblMessage.ForeColor = Color.Red

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
