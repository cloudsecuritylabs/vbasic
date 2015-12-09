Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim a_person As New Customer
        Dim collection_person As New Collection
        Dim blnTest As Boolean


        a_person.LastName = txtLastName.Text
        a_person.FirstName = txtFirstName.Text
        a_person.Address = txtAddress.Text
        a_person.City = txtCity.Text
        a_person.State = txtState.Text
        a_person.Zip = txtZip.Text
        a_person.Phone = txtPhone.Text
        a_person.CustomerNumber = txtCustomerNumber.Text
        a_person.Comments = txtComments.Text

        collection_person.Add(a_person)


        'MessageBox.Show(blnTest.ToString)

        ' MessageBox.Show(a_person.CustomerNumber & " " & a_person.FirstName & " " & a_person.LastName & " " & a_person.Address & " " & a_person.City & " " & a_person.State & " " & a_person.Zip & " " & a_person.Phone & " " & a_person.Comments)



        If blnTest = False Then
            If chkBoxMailingList.Checked Then
                lstBox.Items.Add(a_person.CustomerNumber & " " & a_person.FirstName & " " & a_person.LastName & " " & a_person.Address & " " & a_person.City & " " & a_person.State & " " & a_person.Zip & " " & a_person.Phone & " " & a_person.Comments)
                ' End If
                'Next
            Else
                lstBoxNotMailingList.Items.Add(a_person.CustomerNumber & " " & a_person.FirstName & " " & a_person.LastName & " " & a_person.Address & " " & a_person.City & " " & a_person.State & " " & a_person.Zip & " " & a_person.Phone & " " & a_person.Comments)

            End If
        End If





    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
