Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalculateTicketRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateTicketRevenue.Click
        Dim dblGrossAdultTicketSold As Double = CDbl(txtAdultPrice.Text) * CDbl(txtAdultTickets.Text)
        Dim dblGrossChildTicketRevenue As Double = CDbl(txtChildPrice.Text) * CDbl(txtChildTickets.Text)

        lblGrossAdultTicketSold.Text = dblGrossAdultTicketSold.ToString("c")
        lblGrossChildTicketSale.Text = dblGrossChildTicketRevenue.ToString("c")
        lblGrossTotalRevenue.Text = (dblGrossAdultTicketSold + dblGrossChildTicketRevenue).ToString("c")


        lblNetAdultTicketSales.Text = (dblGrossAdultTicketSold * 0.2).ToString("c")
        lblNetChildTicketSales.Text = (dblGrossChildTicketRevenue * 0.2).ToString("c")
        lblTotalNetRevenue.Text = ((dblGrossAdultTicketSold + dblGrossChildTicketRevenue) * 0.2).ToString("c")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdultPrice.Clear()
        txtAdultTickets.Clear()
        txtChildPrice.Clear()
        txtChildTickets.Clear()

        lblGrossAdultTicketSold.Text = String.Empty
        lblGrossChildTicketSale.Text = String.Empty
        lblGrossTotalRevenue.Text = String.Empty
        lblNetAdultTicketSales.Text = String.Empty
        lblNetChildTicketSales.Text = String.Empty
        lblTotalNetRevenue.Text = String.Empty

        txtAdultPrice.Focus()


    End Sub
End Class
