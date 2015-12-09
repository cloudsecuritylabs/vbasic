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
        Me.radAir = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.radSteel = New System.Windows.Forms.RadioButton()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.lblTimeCalculated = New System.Windows.Forms.Label()
        Me.lblEnterDistance = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radAir
        '
        Me.radAir.BackColor = System.Drawing.Color.LightSeaGreen
        Me.radAir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.radAir.Location = New System.Drawing.Point(6, 19)
        Me.radAir.Name = "radAir"
        Me.radAir.Size = New System.Drawing.Size(104, 24)
        Me.radAir.TabIndex = 0
        Me.radAir.TabStop = True
        Me.radAir.Text = "Air"
        Me.radAir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.radSteel)
        Me.GroupBox1.Controls.Add(Me.radWater)
        Me.GroupBox1.Controls.Add(Me.radAir)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Window"
        '
        'radWater
        '
        Me.radWater.BackColor = System.Drawing.Color.LightSeaGreen
        Me.radWater.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.radWater.Location = New System.Drawing.Point(6, 49)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(104, 24)
        Me.radWater.TabIndex = 1
        Me.radWater.TabStop = True
        Me.radWater.Text = "Water"
        Me.radWater.UseVisualStyleBackColor = False
        '
        'radSteel
        '
        Me.radSteel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.radSteel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.radSteel.Location = New System.Drawing.Point(6, 79)
        Me.radSteel.Name = "radSteel"
        Me.radSteel.Size = New System.Drawing.Size(104, 24)
        Me.radSteel.TabIndex = 2
        Me.radSteel.TabStop = True
        Me.radSteel.Text = "Steel"
        Me.radSteel.UseVisualStyleBackColor = False
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(303, 58)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(100, 20)
        Me.txtDistance.TabIndex = 3
        '
        'lblTimeCalculated
        '
        Me.lblTimeCalculated.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblTimeCalculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeCalculated.Location = New System.Drawing.Point(303, 89)
        Me.lblTimeCalculated.Name = "lblTimeCalculated"
        Me.lblTimeCalculated.Size = New System.Drawing.Size(100, 23)
        Me.lblTimeCalculated.TabIndex = 4
        Me.lblTimeCalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnterDistance
        '
        Me.lblEnterDistance.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblEnterDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEnterDistance.Location = New System.Drawing.Point(178, 59)
        Me.lblEnterDistance.Name = "lblEnterDistance"
        Me.lblEnterDistance.Size = New System.Drawing.Size(100, 23)
        Me.lblEnterDistance.TabIndex = 5
        Me.lblEnterDistance.Text = "Enter Distance"
        Me.lblEnterDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(178, 89)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate Time"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(303, 119)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(439, 177)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblEnterDistance)
        Me.Controls.Add(Me.lblTimeCalculated)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Speed of Sound "
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radAir As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSteel As System.Windows.Forms.RadioButton
    Friend WithEvents radWater As System.Windows.Forms.RadioButton
    Friend WithEvents txtDistance As System.Windows.Forms.TextBox
    Friend WithEvents lblTimeCalculated As System.Windows.Forms.Label
    Friend WithEvents lblEnterDistance As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
