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
        Me.txtPhysical = New System.Windows.Forms.TextBox()
        Me.txtLabFees = New System.Windows.Forms.TextBox()
        Me.txtSurgical = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtNumDays = New System.Windows.Forms.TextBox()
        Me.lblPhysical = New System.Windows.Forms.Label()
        Me.lblLabFees = New System.Windows.Forms.Label()
        Me.lblSurgical = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblNumDays = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalCostMessage = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.strip = New System.Windows.Forms.StatusStrip()
        Me.lblStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPhysical)
        Me.GroupBox1.Controls.Add(Me.txtLabFees)
        Me.GroupBox1.Controls.Add(Me.txtSurgical)
        Me.GroupBox1.Controls.Add(Me.txtMedication)
        Me.GroupBox1.Controls.Add(Me.txtNumDays)
        Me.GroupBox1.Controls.Add(Me.lblPhysical)
        Me.GroupBox1.Controls.Add(Me.lblLabFees)
        Me.GroupBox1.Controls.Add(Me.lblSurgical)
        Me.GroupBox1.Controls.Add(Me.lblMedication)
        Me.GroupBox1.Controls.Add(Me.lblNumDays)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hospital Stay Information"
        '
        'txtPhysical
        '
        Me.txtPhysical.Location = New System.Drawing.Point(143, 160)
        Me.txtPhysical.Multiline = True
        Me.txtPhysical.Name = "txtPhysical"
        Me.txtPhysical.Size = New System.Drawing.Size(152, 31)
        Me.txtPhysical.TabIndex = 8
        '
        'txtLabFees
        '
        Me.txtLabFees.Location = New System.Drawing.Point(143, 123)
        Me.txtLabFees.Multiline = True
        Me.txtLabFees.Name = "txtLabFees"
        Me.txtLabFees.Size = New System.Drawing.Size(152, 31)
        Me.txtLabFees.TabIndex = 7
        '
        'txtSurgical
        '
        Me.txtSurgical.Location = New System.Drawing.Point(143, 86)
        Me.txtSurgical.Multiline = True
        Me.txtSurgical.Name = "txtSurgical"
        Me.txtSurgical.Size = New System.Drawing.Size(152, 31)
        Me.txtSurgical.TabIndex = 6
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(143, 52)
        Me.txtMedication.Multiline = True
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(152, 31)
        Me.txtMedication.TabIndex = 5
        '
        'txtNumDays
        '
        Me.txtNumDays.Location = New System.Drawing.Point(143, 16)
        Me.txtNumDays.Multiline = True
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.Size = New System.Drawing.Size(152, 31)
        Me.txtNumDays.TabIndex = 1
        '
        'lblPhysical
        '
        Me.lblPhysical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhysical.Location = New System.Drawing.Point(6, 159)
        Me.lblPhysical.Name = "lblPhysical"
        Me.lblPhysical.Size = New System.Drawing.Size(131, 30)
        Me.lblPhysical.TabIndex = 4
        Me.lblPhysical.Text = "Physical"
        Me.lblPhysical.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLabFees
        '
        Me.lblLabFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLabFees.Location = New System.Drawing.Point(6, 121)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(131, 38)
        Me.lblLabFees.TabIndex = 3
        Me.lblLabFees.Text = "Lab Fees"
        Me.lblLabFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSurgical
        '
        Me.lblSurgical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSurgical.Location = New System.Drawing.Point(6, 86)
        Me.lblSurgical.Name = "lblSurgical"
        Me.lblSurgical.Size = New System.Drawing.Size(131, 35)
        Me.lblSurgical.TabIndex = 2
        Me.lblSurgical.Text = "Surgical Charges"
        Me.lblSurgical.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMedication
        '
        Me.lblMedication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedication.Location = New System.Drawing.Point(6, 47)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(131, 39)
        Me.lblMedication.TabIndex = 1
        Me.lblMedication.Text = "Medication"
        Me.lblMedication.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumDays
        '
        Me.lblNumDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumDays.Location = New System.Drawing.Point(6, 16)
        Me.lblNumDays.Name = "lblNumDays"
        Me.lblNumDays.Size = New System.Drawing.Size(131, 31)
        Me.lblNumDays.TabIndex = 0
        Me.lblNumDays.Text = "Length of Stay (Days)"
        Me.lblNumDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalCostMessage)
        Me.GroupBox2.Controls.Add(Me.lblTotalCost)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblTotalCostMessage
        '
        Me.lblTotalCostMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCostMessage.Location = New System.Drawing.Point(143, 16)
        Me.lblTotalCostMessage.Name = "lblTotalCostMessage"
        Me.lblTotalCostMessage.Size = New System.Drawing.Size(151, 30)
        Me.lblTotalCostMessage.TabIndex = 10
        Me.lblTotalCostMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCost.Location = New System.Drawing.Point(6, 16)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(131, 30)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "Total Cost"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 38)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(158, 325)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 38)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 325)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 38)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'strip
        '
        Me.strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStrip})
        Me.strip.Location = New System.Drawing.Point(0, 397)
        Me.strip.Name = "strip"
        Me.strip.Size = New System.Drawing.Size(421, 22)
        Me.strip.TabIndex = 5
        Me.strip.Text = "My Status"
        '
        'lblStrip
        '
        Me.lblStrip.Name = "lblStrip"
        Me.lblStrip.Size = New System.Drawing.Size(121, 17)
        Me.lblStrip.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 419)
        Me.Controls.Add(Me.strip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.strip.ResumeLayout(False)
        Me.strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPhysical As Label
    Friend WithEvents lblLabFees As Label
    Friend WithEvents lblSurgical As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblNumDays As Label
    Friend WithEvents txtPhysical As TextBox
    Friend WithEvents txtLabFees As TextBox
    Friend WithEvents txtSurgical As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents txtNumDays As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalCostMessage As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents strip As StatusStrip
    Friend WithEvents lblStrip As ToolStripStatusLabel
End Class
