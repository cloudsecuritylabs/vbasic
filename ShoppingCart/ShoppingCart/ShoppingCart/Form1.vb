Public Class Form1

    Dim subtotal As Double = 0
    Dim tax As Double = 0
    Dim shipping As Double = 0
    Dim total As Double = 0

    Dim taxRate As Double = 0.06


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub IDidItYourWayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDidItYourWayToolStripMenuItem.Click
        ListBox1.Items.Add("I Did It Your Way")
        subtotal = subtotal + 11.95
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub TheHistoryOfScotlandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheHistoryOfScotlandToolStripMenuItem.Click
        ListBox1.Items.Add("The History of Scotland")
        subtotal = subtotal + 14.5
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub LearnCalculusInOneDayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LearnCalculusInOneDayToolStripMenuItem.Click
        ListBox1.Items.Add("Learn Calculus in One Day")
        subtotal = subtotal + 29.25
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub FeelTheStressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeelTheStressToolStripMenuItem.Click
        ListBox1.Items.Add("Feel the Stress")
        subtotal = subtotal + 18.0
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub LearnCalculusInOneDayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LearnCalculusInOneDayToolStripMenuItem1.Click
        ListBox1.Items.Add("Learn Calculus in One Day")
        subtotal = subtotal + 29.95
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub TheHistoryOfScotlandToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TheHistoryOfScotlandToolStripMenuItem1.Click
        ListBox1.Items.Add("The History of Scotlandy")
        subtotal = subtotal + 14.5
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub TheScienceOfBodyLanguageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TheScienceOfBodyLanguageToolStripMenuItem.Click
        ListBox1.Items.Add("The Science of Body Language")
        subtotal = subtotal + 12.95
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub RelaxationTechniquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaxationTechniquesToolStripMenuItem.Click
        ListBox1.Items.Add("Relaxation Techniques")
        subtotal = subtotal + 11.5
        tax = subtotal * taxRate
        shipping = shipping + 2
        total = subtotal + tax + shipping
        lblOutputSubTotal.Text = subtotal.ToString
        lblOutputShipping.Text = shipping.ToString
        lblOutputTax.Text = tax.ToString
        lblOutputTotal.Text = total.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        subtotal = 0.0
        tax = 0
        shipping = 0
        total = 0
        lblOutputSubTotal.Text = String.Empty

        lblOutputShipping.Text = String.Empty

        lblOutputTax.Text = String.Empty

        lblOutputTotal.Text = String.Empty



    End Sub
End Class
