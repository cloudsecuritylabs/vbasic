Public Class Form1
    'coded by Ankan Basu
    'date 10/13/2015
    Dim intSelectedNumberOfDays As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'update the combobox with some default values
        With cboxInput.Items
            .Add(5)
            .Add(10)
            .Add(20)
            .Add(30)
        End With



    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If Integer.TryParse(cboxInput.Text, intSelectedNumberOfDays) AndAlso intSelectedNumberOfDays >= 0 Then
            If intSelectedNumberOfDays = 0 Then
                lblMessage.Text = "Total Pay in pennies at the end of  " & intSelectedNumberOfDays & " days is 0"

            Else
                'MessageBox.Show("good job")
                Dim intCount As Integer
                Dim dblDailyTotalPay As Double = 1.0
                Dim dblTotalPay As Double = 1.0

                'MessageBox.Show(intSelectedNumberOfDays.ToString)
                For intCount = 2 To intSelectedNumberOfDays
                    dblDailyTotalPay = dblDailyTotalPay * 2
                    dblTotalPay += dblDailyTotalPay
                Next

                lblMessage.Text = "Total Pay in pennies at the end of  " & intSelectedNumberOfDays & " days is " & dblTotalPay.ToString("n0")
                lblMessage.ForeColor = Color.Black
            End If


        Else
            lblMessage.Text = "Please enter a positive number or select a number from the list"
            lblMessage.ForeColor = Color.Red
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblMessage.Text = String.Empty
        cboxInput.SelectedIndex = -1
        cboxInput.Text = String.Empty
        cboxInput.Focus()
    End Sub
End Class
