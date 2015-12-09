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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPackageA = New System.Windows.Forms.RadioButton()
        Me.radPackageB = New System.Windows.Forms.RadioButton()
        Me.radPackageC = New System.Windows.Forms.RadioButton()
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkNonProfit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox1.Controls.Add(Me.chkNonProfit)
        Me.GroupBox1.Controls.Add(Me.radPackageC)
        Me.GroupBox1.Controls.Add(Me.radPackageB)
        Me.GroupBox1.Controls.Add(Me.radPackageA)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packages"
        '
        'radPackageA
        '
        Me.radPackageA.AutoSize = True
        Me.radPackageA.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.radPackageA.Location = New System.Drawing.Point(3, 16)
        Me.radPackageA.Name = "radPackageA"
        Me.radPackageA.Size = New System.Drawing.Size(78, 17)
        Me.radPackageA.TabIndex = 0
        Me.radPackageA.TabStop = True
        Me.radPackageA.Text = "Package A"
        Me.radPackageA.UseVisualStyleBackColor = False
        '
        'radPackageB
        '
        Me.radPackageB.AutoSize = True
        Me.radPackageB.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.radPackageB.Location = New System.Drawing.Point(3, 39)
        Me.radPackageB.Name = "radPackageB"
        Me.radPackageB.Size = New System.Drawing.Size(78, 17)
        Me.radPackageB.TabIndex = 1
        Me.radPackageB.TabStop = True
        Me.radPackageB.Text = "Package B"
        Me.radPackageB.UseVisualStyleBackColor = False
        '
        'radPackageC
        '
        Me.radPackageC.AutoSize = True
        Me.radPackageC.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.radPackageC.Location = New System.Drawing.Point(3, 62)
        Me.radPackageC.Name = "radPackageC"
        Me.radPackageC.Size = New System.Drawing.Size(78, 17)
        Me.radPackageC.TabIndex = 2
        Me.radPackageC.TabStop = True
        Me.radPackageC.Text = "Package C"
        Me.radPackageC.UseVisualStyleBackColor = False
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.Location = New System.Drawing.Point(269, 38)
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(123, 20)
        Me.txtHoursUsed.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(120, 120)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(217, 120)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.PaleGreen
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(120, 78)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(272, 23)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MistyRose
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(120, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter Hours"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkNonProfit
        '
        Me.chkNonProfit.AutoSize = True
        Me.chkNonProfit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chkNonProfit.Location = New System.Drawing.Point(3, 85)
        Me.chkNonProfit.Name = "chkNonProfit"
        Me.chkNonProfit.Size = New System.Drawing.Size(70, 17)
        Me.chkNonProfit.TabIndex = 7
        Me.chkNonProfit.Text = "NonProfit"
        Me.chkNonProfit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(404, 153)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHoursUsed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Internet Service Provider"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radPackageC As System.Windows.Forms.RadioButton
    Friend WithEvents radPackageB As System.Windows.Forms.RadioButton
    Friend WithEvents radPackageA As System.Windows.Forms.RadioButton
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkNonProfit As System.Windows.Forms.CheckBox

End Class
