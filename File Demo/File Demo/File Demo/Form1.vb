Imports System.IO

Public Class Form1
    ' Class-level constant for the filename
    Private Const strFILENAME As String = "Numbers.txt"
    Private Const strStudentFILENAME As String = "StudentInformation.txt"

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        ' Local variables
        Dim outputFile As StreamWriter ' Object variable
        Dim intMaxNumbers As Integer   ' The number of values
        Dim intCount As Integer = 0    ' Loop counter, initialized to 0
        Dim intNumberGrade As Integer
        Dim strStudentName As String

        Try
            ' Get the number of students from the user.
            intMaxNumbers = CInt(InputBox("How many Students do " &
                                          "you want to enter?"))

            Try
                ' Create the file.
                outputFile = File.CreateText(strStudentFILENAME)

                ' Get the numbers and write then to the file.
                Do While intCount < intMaxNumbers
                    strStudentName = InputBox("Enter The Student Name:")
                    outputFile.WriteLine(strStudentName)
                    Try
                        ' Get an integer.
                        intNumberGrade = CInt(InputBox("Enter The grade:"))

                        ' Write that integer to the file.
                        outputFile.WriteLine(intNumberGrade)

                        ' Increment intCount.
                        intCount += 1
                    Catch
                        ' Error message for invalid integer.
                        MessageBox.Show("The value you entered was not " &
                                        "valid . Try again.")
                    End Try
                Loop

                ' Close the file.
                outputFile.Close()

            Catch
                ' Error message for file creation error.
                MessageBox.Show("Error creating the file" & strFILENAME)
            End Try

        Catch
            ' Error message for invalid number of numbers.
            MessageBox.Show("Enter a valid integer please.")
        End Try
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        ' Local variables
        Dim inputFile As StreamReader   ' Object variable
        Dim strInput As String          ' To hold a line of input

        Try
            ' Open the file.
            inputFile = File.OpenText(strStudentFILENAME)

            ' Clear the listbox.
            lstOutput.Items.Clear()

            ' Read the file's contents.
            Do Until inputFile.Peek = -1
                ' Read a line from the file.
                strInput = inputFile.ReadLine()

                ' Add the line of input to the list box.
                lstOutput.Items.Add(strInput)
            Loop

            ' Close the file.
            inputFile.Close()
        Catch
            ' Error message for file open error.
            MessageBox.Show(strStudentFILENAME & " cannot be opened.")
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
