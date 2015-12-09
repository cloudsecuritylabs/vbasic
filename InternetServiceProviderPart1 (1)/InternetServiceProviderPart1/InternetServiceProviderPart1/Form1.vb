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

    'VARIABLE TO STORE PACKEGE COST FOR COMPARISON
    Dim dblpackageCostForA As Double = 0.0
    Dim dblpackageCostForB As Double = 0.0
    Dim dblpackageCostForC As Double = 0.0


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


        costOfPackageA(dblNumHours)
        costOfpackageB(dblExtraHours)
        costOfpackageC(dblExtraHours)

        If blnValidInput Then



            If radPackageA.Checked Then


                lblMessage.Text = costOfPackageA(dblNumHours).ToString("c2")

                If chkSavings.Checked Then
                    If costOfPackageA(dblNumHours) < costOfpackageB(dblNumHours) And costOfPackageA(dblNumHours) < costOfpackageC(dblNumHours) Then
                        lblMessage.Text = costOfPackageA(dblNumHours).ToString("c2") & " No Savings with Package B or Package C"
                    ElseIf costOfPackageA(dblNumHours) > costOfpackageB(dblNumHours) And costOfPackageA(dblNumHours) < costOfpackageB(dblNumHours) Then
                        lblMessage.Text = costOfPackageA(dblNumHours).ToString("c2") & ", save " & (costOfPackageA(dblExtraHours) - costOfpackageB(dblNumHours)).ToString("c2") & " dollars with Package B and No savings with package C"
                    ElseIf costOfPackageA(dblNumHours) > costOfpackageB(dblNumHours) And costOfPackageA(dblNumHours) > costOfpackageB(dblNumHours) Then
                        lblMessage.Text = costOfPackageA(dblNumHours).ToString("c2") & ", save " & (costOfPackageA(dblExtraHours) - costOfpackageB(dblNumHours)).ToString("c2") & " dollars with Package B and save" & (costOfPackageA(dblExtraHours) - costOfpackageC(dblNumHours)).ToString("c2") & " dollars with Package C"
                    End If
                End If
            End If

            If radPackageB.Checked Then
                'MessageBox.Show(costOfPackageA(dblNumHours) & " " & costOfpackageB(dblExtraHours) & " " & costOfpackageC(dblNumHours))
                lblMessage.Text = costOfpackageB(dblNumHours).ToString("c2")

                If chkSavings.Checked Then
                    If costOfpackageB(dblNumHours) < costOfPackageA(dblNumHours) And costOfpackageB(dblNumHours) < costOfpackageC(dblNumHours) Then
                        lblMessage.Text = costOfpackageB(dblNumHours).ToString("c2") & " No Savings with Package A or Package C"
                    ElseIf costOfpackageB(dblNumHours) > costOfPackageA(dblNumHours) And costOfpackageB(dblNumHours) < costOfpackageC(dblNumHours) Then
                        lblMessage.Text = costOfpackageB(dblNumHours).ToString("c2") & ", save " & (costOfpackageB(dblExtraHours) - costOfPackageA(dblNumHours)).ToString("c2") & " dollars with Package A and No savings with package C"
                    ElseIf costOfpackageB(dblNumHours) > costOfPackageA(dblNumHours) And costOfpackageB(dblNumHours) > costOfpackageC(dblNumHours) Then
                        lblMessage.Text = costOfpackageB(dblNumHours).ToString("c2") & ", save " & (costOfpackageB(dblExtraHours) - costOfPackageA(dblNumHours)).ToString("c2") & " dollars with Package A and save" & (costOfpackageB(dblExtraHours) - costOfpackageC(dblNumHours)).ToString("c2") & " dollars with Package C"
                    End If
                End If


                If radPackageC.Checked Then
                    lblMessage.Text = costOfpackageC(dblNumHours).ToString("c2")

                    If chkSavings.Checked Then
                        If costOfpackageC(dblNumHours) < costOfPackageA(dblNumHours) And costOfpackageC(dblNumHours) < costOfpackageB(dblNumHours) Then
                            lblMessage.Text = costOfpackageC(dblNumHours).ToString("c2") & " No Savings with Package A or Package B"
                        ElseIf costOfpackageC(dblNumHours) > costOfPackageA(dblNumHours) And costOfpackageC(dblNumHours) < costOfpackageB(dblNumHours) Then
                            lblMessage.Text = costOfpackageC(dblNumHours).ToString("c2") & ", save " & (costOfpackageC(dblExtraHours) - costOfPackageA(dblNumHours)).ToString("c2") & " dollars with Package A and No savings with package B"
                        ElseIf costOfpackageC(dblNumHours) > costOfPackageA(dblNumHours) And costOfpackageC(dblNumHours) > costOfpackageB(dblNumHours) Then
                            lblMessage.Text = costOfpackageC(dblNumHours).ToString("c2") & ", save " & (costOfpackageC(dblExtraHours) - costOfPackageA(dblNumHours)).ToString("c2") & " dollars with Package A and save" & (costOfpackageC(dblExtraHours) - costOfpackageB(dblNumHours)).ToString("c2") & " dollars with Package B"
                        End If
                    End If

                End If

            End If

        End If
        'FIRST CHECK FOR WHICH BUTTON IS SELECTED



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHoursUsed.Clear()
        lblMessage.Text = String.Empty


    End Sub

    Function costOfPackageA(ByVal hours As Double) As Double
        If dblNumHours > PACKAGE_A_HOURS_IN_PLAN Then
            dblExtraHours = dblNumHours - PACKAGE_A_HOURS_IN_PLAN
        Else
            dblExtraHours = 0.0
        End If

        If chkNonProfit.Checked Then
            dblpackageCostForA = (PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE) * 0.8
            'lblMessage.Text = dblpackageCostForA.ToString("c2")
            'lblMessage.Text = ((PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE) * 0.8).ToString("c2")
        Else
            dblpackageCostForA = (PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE)
            'lblMessage.Text = dblpackageCostForA.ToString("c2")
            'lblMessage.Text = (PACKAGE_A_RATE_PLAN + (dblExtraHours) * PACKAGE_A_ADDITIONAL_HOUR_RATE).ToString("c2")
        End If
        Return dblpackageCostForA
    End Function

    Function costOfpackageB(ByVal hours As Double) As Double
        If dblNumHours > PACKAGE_B_HOURS_IN_PLAN Then
            dblExtraHours = dblNumHours - PACKAGE_B_HOURS_IN_PLAN
        Else
            dblExtraHours = 0.0
        End If

        If chkNonProfit.Checked Then
            dblpackageCostForB = ((PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE) * 0.8)
            'lblMessage.Text = dblpackageCostForB.ToString("c2")
            'lblMessage.Text = ((PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE) * 0.8).ToString("c2")
        Else
            dblpackageCostForB = (PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE)
            'lblMessage.Text = (PACKAGE_B_RATE_PLAN + (dblExtraHours) * PACKAGE_B_ADDITIONAL_HOUR_RATE).ToString("c2")
        End If
        Return dblpackageCostForB

    End Function

    Function costOfpackageC(ByVal hours As Double) As Double
        If chkNonProfit.Checked Then
            dblpackageCostForC = (PACKAGE_C_RATE_PLAN * 0.8)
            'lblMessage.Text = dblpackageCostForC.ToString("c2")
        Else
            dblpackageCostForC = (PACKAGE_C_RATE_PLAN)
            'lblMessage.Text = dblpackageCostForC.ToString("c2")
        End If
        Return dblpackageCostForC

    End Function



End Class
