Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'method for conversion using a for loop
        For intCount As Integer = 0 To 20
            'just create a variable inside the scope of the loop to hold the text
            Dim strStore As String = "Centegrade: " & intCount & "  is equal to " & (1.8 * intCount + 32).ToString & "  Fahrenheit"
            'make sure that the item is already not in the listBox
            If Not lboxMain.Items.Contains(strStore) Then
                lboxMain.Items.Add(strStore)
            End If

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
