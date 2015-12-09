Public Class Form1
    Dim intNumArrayUser(9) As Integer


    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        'Do While intCount < intNumArrayUser.Length
        For i As Integer = 0 To intNumArrayUser.Length - 1

            Try
                intNumArrayUser(i) =
                    CInt(InputBox("Number " & i + 1))
                lbox.Items.Add(intNumArrayUser(i))

            Catch ex As Exception
                MessageBox.Show("Enter valid number")
            End Try
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMinMax_Click(sender As Object, e As EventArgs) Handles btnMinMax.Click
        Dim intCount As Integer
        Dim intHighest As Integer = intNumArrayUser(0)
        Dim intLowest As Integer = intNumArrayUser(0)

        'MessageBox.Show(intNumArrayUser.Min().ToString)
        'MessageBox.Show(intNumArrayUser.Max().ToString)

        'MessageBox.Show(intNumArrayUser(0).ToString)
        'MessageBox.Show(intLowest.ToString())

        For intCount = 1 To (intNumArrayUser.Length - 1)
            If intNumArrayUser(intCount) < intLowest Then
                intLowest = intNumArrayUser(intCount)
                'MessageBox.Show(intLowest.ToString())
            End If
        Next

        For intCount = 1 To (intNumArrayUser.Length - 1)
            If intNumArrayUser(intCount) > intHighest Then
                intHighest = intNumArrayUser(intCount)
            End If
        Next


        'MessageBox.Show(intNumArrayUser.Min().ToString)
        lblOutput.Text = intHighest.ToString & " " & intLowest.ToString


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
