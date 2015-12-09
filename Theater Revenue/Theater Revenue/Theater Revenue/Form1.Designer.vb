<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.txtAdultTickets = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.txtChildTickets = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdultTickets = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCalculateTicketRevenue = New System.Windows.Forms.Button()
        Me.lblGrossAdultTicketSold = New System.Windows.Forms.Label()
        Me.lblGrossChildTicketSale = New System.Windows.Forms.Label()
        Me.lblGrossTotalRevenue = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.lblNetChildTicketSales = New System.Windows.Forms.Label()
        Me.lblNetAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AdultTickets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAdultPrice.Location = New System.Drawing.Point(112, 18)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultPrice.TabIndex = 0
        Me.txtAdultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdultTickets
        '
        Me.txtAdultTickets.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAdultTickets.Location = New System.Drawing.Point(112, 52)
        Me.txtAdultTickets.Name = "txtAdultTickets"
        Me.txtAdultTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTickets.TabIndex = 1
        Me.txtAdultTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildPrice
        '
        Me.txtChildPrice.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtChildPrice.Location = New System.Drawing.Point(112, 21)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildPrice.TabIndex = 2
        Me.txtChildPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChildTickets
        '
        Me.txtChildTickets.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtChildTickets.Location = New System.Drawing.Point(112, 55)
        Me.txtChildTickets.Name = "txtChildTickets"
        Me.txtChildTickets.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTickets.TabIndex = 3
        Me.txtChildTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price Per Ticket"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tickets Sold"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.PaleGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price Per Ticket"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.PaleGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(6, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tickets Sold"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdultTickets
        '
        Me.AdultTickets.BackColor = System.Drawing.Color.PeachPuff
        Me.AdultTickets.Controls.Add(Me.Label1)
        Me.AdultTickets.Controls.Add(Me.txtAdultPrice)
        Me.AdultTickets.Controls.Add(Me.Label2)
        Me.AdultTickets.Controls.Add(Me.txtAdultTickets)
        Me.AdultTickets.Location = New System.Drawing.Point(52, 27)
        Me.AdultTickets.Name = "AdultTickets"
        Me.AdultTickets.Size = New System.Drawing.Size(228, 111)
        Me.AdultTickets.TabIndex = 9
        Me.AdultTickets.TabStop = False
        Me.AdultTickets.Text = "Adult Ticket Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtChildPrice)
        Me.GroupBox1.Controls.Add(Me.txtChildTickets)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Child Ticket Sales"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.lblGrossTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblGrossChildTicketSale)
        Me.GroupBox2.Controls.Add(Me.lblGrossAdultTicketSold)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 134)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gross Ticket Revenue"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Adult Ticket Sales"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.PaleGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(6, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Child Ticket Sales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.PaleGreen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(5, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 34)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Gross Revenue for Ticket"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculateTicketRevenue
        '
        Me.btnCalculateTicketRevenue.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCalculateTicketRevenue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculateTicketRevenue.Location = New System.Drawing.Point(52, 319)
        Me.btnCalculateTicketRevenue.Name = "btnCalculateTicketRevenue"
        Me.btnCalculateTicketRevenue.Size = New System.Drawing.Size(164, 39)
        Me.btnCalculateTicketRevenue.TabIndex = 11
        Me.btnCalculateTicketRevenue.Text = "Calculate Ticket Revenue"
        Me.btnCalculateTicketRevenue.UseVisualStyleBackColor = False
        '
        'lblGrossAdultTicketSold
        '
        Me.lblGrossAdultTicketSold.BackColor = System.Drawing.Color.Turquoise
        Me.lblGrossAdultTicketSold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultTicketSold.Location = New System.Drawing.Point(116, 16)
        Me.lblGrossAdultTicketSold.Name = "lblGrossAdultTicketSold"
        Me.lblGrossAdultTicketSold.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossAdultTicketSold.TabIndex = 8
        Me.lblGrossAdultTicketSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossChildTicketSale
        '
        Me.lblGrossChildTicketSale.BackColor = System.Drawing.Color.Turquoise
        Me.lblGrossChildTicketSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildTicketSale.Location = New System.Drawing.Point(116, 49)
        Me.lblGrossChildTicketSale.Name = "lblGrossChildTicketSale"
        Me.lblGrossChildTicketSale.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossChildTicketSale.TabIndex = 9
        Me.lblGrossChildTicketSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossTotalRevenue
        '
        Me.lblGrossTotalRevenue.BackColor = System.Drawing.Color.Turquoise
        Me.lblGrossTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossTotalRevenue.Location = New System.Drawing.Point(116, 93)
        Me.lblGrossTotalRevenue.Name = "lblGrossTotalRevenue"
        Me.lblGrossTotalRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossTotalRevenue.TabIndex = 10
        Me.lblGrossTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox3.Controls.Add(Me.lblTotalNetRevenue)
        Me.GroupBox3.Controls.Add(Me.lblNetChildTicketSales)
        Me.GroupBox3.Controls.Add(Me.lblNetAdultTicketSales)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(316, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 134)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Net Ticket Revenue"
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.BackColor = System.Drawing.Color.Turquoise
        Me.lblTotalNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(116, 93)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalNetRevenue.TabIndex = 10
        Me.lblTotalNetRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetChildTicketSales
        '
        Me.lblNetChildTicketSales.BackColor = System.Drawing.Color.Turquoise
        Me.lblNetChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildTicketSales.Location = New System.Drawing.Point(116, 49)
        Me.lblNetChildTicketSales.Name = "lblNetChildTicketSales"
        Me.lblNetChildTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblNetChildTicketSales.TabIndex = 9
        Me.lblNetChildTicketSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetAdultTicketSales
        '
        Me.lblNetAdultTicketSales.BackColor = System.Drawing.Color.Turquoise
        Me.lblNetAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultTicketSales.Location = New System.Drawing.Point(116, 16)
        Me.lblNetAdultTicketSales.Name = "lblNetAdultTicketSales"
        Me.lblNetAdultTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblNetAdultTicketSales.TabIndex = 8
        Me.lblNetAdultTicketSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.PaleGreen
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(5, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 34)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Total Net Revenue for Ticket"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.PaleGreen
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Adult Ticket Sales"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.PaleGreen
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Location = New System.Drawing.Point(6, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Child Ticket Sales"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Crimson
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(222, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 39)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(392, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(164, 39)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 383)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCalculateTicketRevenue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AdultTickets)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.AdultTickets.ResumeLayout(False)
        Me.AdultTickets.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultTickets As System.Windows.Forms.TextBox
    Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtChildTickets As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdultTickets As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateTicketRevenue As System.Windows.Forms.Button
    Friend WithEvents lblGrossTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblGrossChildTicketSale As System.Windows.Forms.Label
    Friend WithEvents lblGrossAdultTicketSold As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalNetRevenue As System.Windows.Forms.Label
    Friend WithEvents lblNetChildTicketSales As System.Windows.Forms.Label
    Friend WithEvents lblNetAdultTicketSales As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
