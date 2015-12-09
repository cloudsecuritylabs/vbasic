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
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblOutputSubTotal = New System.Windows.Forms.Label()
        Me.lblOutputTax = New System.Windows.Forms.Label()
        Me.lblOutputShipping = New System.Windows.Forms.Label()
        Me.lblOutputTotal = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDidItYourWayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheHistoryOfScotlandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LearnCalculusInOneDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeelTheStressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LearnCalculusInOneDayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheHistoryOfScotlandToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheScienceOfBodyLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaxationTechniquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(363, 46)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(50, 13)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "SubTotal"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(378, 89)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax"
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.Location = New System.Drawing.Point(363, 137)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(48, 13)
        Me.lblShipping.TabIndex = 2
        Me.lblShipping.Text = "Shipping"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(380, 183)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total"
        '
        'lblOutputSubTotal
        '
        Me.lblOutputSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputSubTotal.Location = New System.Drawing.Point(428, 42)
        Me.lblOutputSubTotal.Name = "lblOutputSubTotal"
        Me.lblOutputSubTotal.Size = New System.Drawing.Size(68, 21)
        Me.lblOutputSubTotal.TabIndex = 4
        Me.lblOutputSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputTax
        '
        Me.lblOutputTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTax.Location = New System.Drawing.Point(428, 84)
        Me.lblOutputTax.Name = "lblOutputTax"
        Me.lblOutputTax.Size = New System.Drawing.Size(68, 23)
        Me.lblOutputTax.TabIndex = 5
        Me.lblOutputTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputShipping
        '
        Me.lblOutputShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputShipping.Location = New System.Drawing.Point(428, 131)
        Me.lblOutputShipping.Name = "lblOutputShipping"
        Me.lblOutputShipping.Size = New System.Drawing.Size(68, 25)
        Me.lblOutputShipping.TabIndex = 6
        Me.lblOutputShipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutputTotal
        '
        Me.lblOutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputTotal.Location = New System.Drawing.Point(428, 170)
        Me.lblOutputTotal.Name = "lblOutputTotal"
        Me.lblOutputTotal.Size = New System.Drawing.Size(68, 26)
        Me.lblOutputTotal.TabIndex = 7
        Me.lblOutputTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(324, 173)
        Me.ListBox1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.lblOutputTotal)
        Me.GroupBox1.Controls.Add(Me.lblOutputShipping)
        Me.GroupBox1.Controls.Add(Me.lblOutputTax)
        Me.GroupBox1.Controls.Add(Me.lblOutputSubTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblShipping)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubtotal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products Selected"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStripMenuItem, Me.AudioBooksToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'PrintBooksToolStripMenuItem
        '
        Me.PrintBooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDidItYourWayToolStripMenuItem, Me.TheHistoryOfScotlandToolStripMenuItem, Me.LearnCalculusInOneDayToolStripMenuItem, Me.FeelTheStressToolStripMenuItem})
        Me.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem"
        Me.PrintBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintBooksToolStripMenuItem.Text = "Print Books"
        '
        'AudioBooksToolStripMenuItem
        '
        Me.AudioBooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LearnCalculusInOneDayToolStripMenuItem1, Me.TheHistoryOfScotlandToolStripMenuItem1, Me.TheScienceOfBodyLanguageToolStripMenuItem, Me.RelaxationTechniquesToolStripMenuItem})
        Me.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem"
        Me.AudioBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AudioBooksToolStripMenuItem.Text = "Audio Books"
        '
        'IDidItYourWayToolStripMenuItem
        '
        Me.IDidItYourWayToolStripMenuItem.Name = "IDidItYourWayToolStripMenuItem"
        Me.IDidItYourWayToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.IDidItYourWayToolStripMenuItem.Text = "I Did It Your Way"
        '
        'TheHistoryOfScotlandToolStripMenuItem
        '
        Me.TheHistoryOfScotlandToolStripMenuItem.Name = "TheHistoryOfScotlandToolStripMenuItem"
        Me.TheHistoryOfScotlandToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.TheHistoryOfScotlandToolStripMenuItem.Text = "The History of Scotland"
        '
        'LearnCalculusInOneDayToolStripMenuItem
        '
        Me.LearnCalculusInOneDayToolStripMenuItem.Name = "LearnCalculusInOneDayToolStripMenuItem"
        Me.LearnCalculusInOneDayToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.LearnCalculusInOneDayToolStripMenuItem.Text = "Learn Calculus in One Day"
        '
        'FeelTheStressToolStripMenuItem
        '
        Me.FeelTheStressToolStripMenuItem.Name = "FeelTheStressToolStripMenuItem"
        Me.FeelTheStressToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FeelTheStressToolStripMenuItem.Text = "Feel the Stress"
        '
        'LearnCalculusInOneDayToolStripMenuItem1
        '
        Me.LearnCalculusInOneDayToolStripMenuItem1.Name = "LearnCalculusInOneDayToolStripMenuItem1"
        Me.LearnCalculusInOneDayToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.LearnCalculusInOneDayToolStripMenuItem1.Text = "Learn Calculus in One Day"
        '
        'TheHistoryOfScotlandToolStripMenuItem1
        '
        Me.TheHistoryOfScotlandToolStripMenuItem1.Name = "TheHistoryOfScotlandToolStripMenuItem1"
        Me.TheHistoryOfScotlandToolStripMenuItem1.Size = New System.Drawing.Size(236, 22)
        Me.TheHistoryOfScotlandToolStripMenuItem1.Text = "The History of Scotland"
        '
        'TheScienceOfBodyLanguageToolStripMenuItem
        '
        Me.TheScienceOfBodyLanguageToolStripMenuItem.Name = "TheScienceOfBodyLanguageToolStripMenuItem"
        Me.TheScienceOfBodyLanguageToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.TheScienceOfBodyLanguageToolStripMenuItem.Text = "The Science of Body Language"
        '
        'RelaxationTechniquesToolStripMenuItem
        '
        Me.RelaxationTechniquesToolStripMenuItem.Name = "RelaxationTechniquesToolStripMenuItem"
        Me.RelaxationTechniquesToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RelaxationTechniquesToolStripMenuItem.Text = "Relaxation Techniques"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Empty"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 309)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Shopping Cart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblShipping As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblOutputSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblOutputTax As System.Windows.Forms.Label
    Friend WithEvents lblOutputShipping As System.Windows.Forms.Label
    Friend WithEvents lblOutputTotal As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDidItYourWayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheHistoryOfScotlandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LearnCalculusInOneDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeelTheStressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LearnCalculusInOneDayToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheHistoryOfScotlandToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheScienceOfBodyLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelaxationTechniquesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
