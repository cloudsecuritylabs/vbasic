Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        lblNum1.Text = String.Empty
        lblNum2.Text = String.Empty
        lblNum3.Text = String.Empty
        lblNum4.Text = String.Empty
        lblNum5.Text = String.Empty


        lblUserNum1.Text = String.Empty
        lblUserNum2.Text = String.Empty
        lblUserNum3.Text = String.Empty
        lblUserNum4.Text = String.Empty
        lblUserNum5.Text = String.Empty



        Dim intNumArray(5) As Integer
        Dim intCount As Integer = 0

        Dim rand As New Random

        For intCount = 0 To 4
            intNumArray(intCount) = rand.Next(10)
        Next

        lblNum1.Text = intNumArray(0).ToString
        lblNum2.Text = intNumArray(1).ToString
        lblNum3.Text = intNumArray(2).ToString
        lblNum4.Text = intNumArray(3).ToString
        lblNum5.Text = intNumArray(4).ToString

        lblNum1.Visible = False
        lblNum2.Visible = False
        lblNum3.Visible = False
        lblNum4.Visible = False
        lblNum5.Visible = False

        MessageBox.Show("Enter 5 numbers between 0-9")
        Dim intNumArrayUser(5) As Integer
        'Do While intCount < intNumArrayUser.Length
        For i As Integer = 0 To 4

            Try
                intNumArrayUser(i) =
                    CInt(InputBox("Number " & i + 1))


            Catch ex As Exception
                MessageBox.Show("Enter valid number")
            End Try
        Next

        'For i = 0 To 4
        '    MessageBox.Show(intNumArrayUser(i).ToString)
        'Next

        lblUserNum1.Text = intNumArrayUser(0).ToString
        lblUserNum2.Text = intNumArrayUser(1).ToString
        lblUserNum3.Text = intNumArrayUser(2).ToString
        lblUserNum4.Text = intNumArrayUser(3).ToString
        lblUserNum5.Text = intNumArrayUser(4).ToString


        Dim blnArray(5) As Boolean
        Dim intMatched As Integer = 0

        'let's copy the array
        Dim intNumArrayUserCopy(5) As Integer
        For i As Integer = 0 To 4
            intNumArrayUserCopy(i) = intNumArrayUserCopy(i)
        Next


        For intCount = 0 To 4
            If (intNumArray(intCount) = intNumArrayUserCopy(intCount)) Then
                blnArray(intCount) = True
                intMatched = intMatched + 1

            End If
        Next

        lblNum1.Visible = True
        lblNum2.Visible = True
        lblNum3.Visible = True
        lblNum4.Visible = True
        lblNum5.Visible = True

        If (intMatched < 5) Then
            MessageBox.Show("Matched " & intMatched.ToString)
        Else
            MessageBox.Show("Matched all 5, You are the grand prize winner")
        End If



    End Sub
End Class
