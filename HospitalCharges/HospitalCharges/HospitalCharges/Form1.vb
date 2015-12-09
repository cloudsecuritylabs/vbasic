Public Class Form1
    'declare global variables
    Dim intNumDays As Integer = 0
    Dim dblMedication As Double = 0.0
    Dim dblSurgical As Double = 0.0
    Dim dblLabFee As Double = 0.0
    Dim dblPhysical As Double = 0.0

    Const dbl_HOSPITAL_CHARGES_PER_DAY As Double = 350.0
    Dim blnContinue As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStrip.Text = "Let's Go"
    End Sub

    Private Function ValidateInputFields() As Boolean
        If Not Integer.TryParse(txtNumDays.Text, intNumDays) OrElse intNumDays < 0 Then
            lblStrip.Text = "Number of stay must be numeric"
            lblStrip.ForeColor = Color.Red
            Return False
        Else
            lblStrip.Text = " "
        End If

        If Not Double.TryParse(txtMedication.Text, dblMedication) OrElse dblMedication < 0 Then
            lblStrip.Text = "Medication must be numeric"
            lblStrip.ForeColor = Color.Red
            Return False
        End If

        If Not Double.TryParse(txtSurgical.Text, dblSurgical) OrElse dblSurgical < 0 Then
            lblStrip.Text = "Surgical must be numeric"
            lblStrip.ForeColor = Color.Red
            Return False
        End If

        If Not Double.TryParse(txtLabFees.Text, dblLabFee) OrElse dblLabFee < 0 Then
            lblStrip.Text = "Lab fee must be numeric"
            lblStrip.ForeColor = Color.Red
            Return False
        End If

        If Not Double.TryParse(txtPhysical.Text, dblPhysical) OrElse dblPhysical < 0 Then
            lblStrip.Text = "Physical must be numeric"
            lblStrip.ForeColor = Color.Red
            Return False
        End If
        lblStrip.ForeColor = Color.Black
        Return True
    End Function

    Function CalcStayCharges() As Double
        Return dbl_HOSPITAL_CHARGES_PER_DAY * intNumDays
    End Function

    Function CalcMiscCharges() As Double
        Return dblMedication + dblSurgical + dblLabFee + dblPhysical
    End Function

    Function CalcTotalCharges() As Double
        Return CalcStayCharges() + CalcMiscCharges()
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblTotalCostMessage.Text = String.Empty
        lblStrip.Text = String.Empty
        blnContinue = False

        blnContinue = ValidateInputFields()

        If blnContinue = True Then
            lblTotalCostMessage.Text = CalcTotalCharges().ToString

        End If
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMedication.Clear()
        txtNumDays.Clear()
        txtPhysical.Clear()
        txtSurgical.Clear()
        txtLabFees.Clear()

        lblTotalCostMessage.Text = String.Empty
        lblStrip.Text = String.Empty

        txtNumDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
