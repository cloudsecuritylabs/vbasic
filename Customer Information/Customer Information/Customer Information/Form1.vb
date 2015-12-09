Public Class Form1
    Dim a_Person As New Person
    Dim collection_person As New Collection

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        a_Person.LastName = txtLastName.Text
        a_Person.FirstName = txtFirstName.Text
        a_Person.Address = txtAddress.Text
        a_Person.City = txtCity.Text
        a_Person.State = txtState.Text
        a_Person.Zip = txtZip.Text
        a_Person.Phone = txtPhone.Text

        MessageBox.Show(a_Person.FirstName & " " & a_Person.LastName & " " & a_Person.Address & " " & a_Person.City & " " & a_Person.State & " " & a_Person.Zip & " " & a_Person.Phone)

        'If collection_person.Contains(a_Person.FirstName) = False Then
        '    collection_person.Add(a_Person)
        'End If

        lstBox.Items.Add(a_Person.FirstName & " " & a_Person.LastName & " " & a_Person.Address & " " & a_Person.City & " " & a_Person.State & " " & a_Person.Zip & " " & a_Person.Phone)


    End Sub
End Class
