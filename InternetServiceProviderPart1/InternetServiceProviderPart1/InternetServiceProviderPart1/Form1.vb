Public Class Form1

    'Package A
    Const PACKAGE_A_HOURS_IN_PLAN As Double = 10.0 ' ALLOWED HOURS AT MONTHLY RATE
    Const PACKAGE_A_RATE_PLAN As Double = 9.95 ' PER MONTH
    Const PACKAGE_A_ADDITIONAL_HOUR_RATE As Double = 2.0 'PER HOUR

    'Package B
    Const PACKAGE_B_HOURS_IN_PLAN As Double = 20.0
    Const PACKAGE_B_RATE_PLAN As Double = 14.95 ' PER MONTH
    Const PACKAGE_B_ADDITIONAL_HOUR_RATE As Double = 1.0

    'Package C
    'Const PACKAGE_C_HOURS_IN_PLAN As Double = UNLIMITED HOURS
    Const PACKAGE_C_RATE_PLAN As Double = 19.95 ' PER MONTH
    'Const PACKAGE_C_ADDITIONAL_HOUR_RATE As Double = NO CHARGE

    'DECLARE A VARIABLE FOR NUMBER OF HOURS
    Dim dblNumHours As Double = 0.0
    Dim dblExtraHours As Double = 0.0

    'DECLARE A FLAG VARIABLE
    Dim blnValidInput As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'MessageBox.Show("Program started")
        'FIRST CHECK FOR INPUT VALIDATION OF NUMBER OS HOURS
        If Double.TryParse(txtHoursUsed.Text, dblNumHours) Then
            blnValidInput = True
        Else
            MessageBox.Show("Input must be numeric")
            lblMessage.Text = "Bad Input"
        End If

        'do this when valid input received

        If CDbl(txtHoursUsed.Text) < 0 Then
            blnValidInput = False
            MessageBox.Show("Hours must be a positive number")
            lblMessage.Text = "Hours must be a positive number"
        Else
            blnValidInput = True

        End If

        If blnValidInput Then
            If radPackageA.Checked Then
                If dblNumHours > PACKAGE_A_HOURS_IN_PLAN Then
                    dblExtraHours = dblNumHours - PACKAGE_A_HOURS_IN_PLAN
                Else
                    dblExtraHours = 0.0
                End If


                If chkNonProfit.Checked Then
                    lblMessage.Text = ((PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE) * 0.8).ToString("c2")
                Else
                    lblMessage.Text = (PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE).ToString("c2")
                End If

            ElseIf radPackageB.Checked Then
                If dblNumHours > PACKAGE_B_HOURS_IN_PLAN Then
                    dblExtraHours = dblNumHours - PACKAGE_B_HOURS_IN_PLAN
                Else
                    dblExtraHours = 0.0
                End If

                If chkNonProfit.Checked Then
                    lblMessage.Text = ((PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE) * 0.8).ToString("c2")
                Else
                    lblMessage.Text = (PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE).ToString("c2")
                End If


            ElseIf radPackageC.Checked Then
                If chkNonProfit.Checked Then
                    lblMessage.Text = (PACKAGE_C_RATE_PLAN * 0.8).ToString("c2")
                Else
                    lblMessage.Text = (PACKAGE_C_RATE_PLAN).ToString("c2")
                End If

            End If

        End If





        'FIRST CHECK FOR WHICH BUTTON IS SELECTED



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHoursUsed.Clear()
        lblMessage.Text = String.Empty

    End Sub
End Class
