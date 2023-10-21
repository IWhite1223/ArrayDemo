Public Class Form1
    Private Const SALE_TAX = 0.06 'declaring a const that is unchanging for the tax rate

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblSubtotal As Double

        'Subtotal Calc
        determineSubtotal(dblSubtotal)
        lblSubtotal.Text = dblSubtotal.ToString("c2")

        'sales Tac Calc
        Dim dblSalesTax As Double = calculateSalesTax(dblSubtotal)
        lblTax.Text = dblSalesTax.ToString("c2")

        'Display and calculate with a function
        lblTotal.Text = (dblSalesTax + dblSubtotal).ToString("c2")

    End Sub

    Private Sub determineSubtotal(ByRef dblSubtotal As Double)

        'donut

        Select Case True
            Case rdoGlaze.Checked
                dblSubtotal += 1.05

            Case rdoSug.Checked
                dblSubtotal += 1.05

            Case rdoChoc.Checked
                dblSubtotal += 1.25

            Case rdoFill.Checked
                dblSubtotal += 1.5

            Case Else

        End Select

        'coffee

        If rdoNone.Checked Then

        ElseIf rdoReg.Checked Then
            dblSubtotal += 1.5
        ElseIf rdoCap.Checked Then
            dblSubtotal += 2.75
        End If

        'Round Subtotal

        dblSubtotal = Math.Round(dblSubtotal, 2)

    End Sub

    Private Function calculateSalesTax(ByVal dblSubtotal As Double) As Double
        Return Math.Round(dblSubtotal * SALE_TAX, 2)
    End Function

    'Clear when omething else is clicked
    Private Sub clearLabels(sender As Object, e As EventArgs) Handles rdoSug.CheckedChanged, rdoReg.CheckedChanged, rdoNone.CheckedChanged, rdoGlaze.CheckedChanged, rdoFill.CheckedChanged, rdoChoc.CheckedChanged, rdoCap.CheckedChanged
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
    End Sub

    'exit 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
