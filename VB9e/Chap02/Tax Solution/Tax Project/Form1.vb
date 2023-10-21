
Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtAssessed.Text = ""
        lstOutput.Items.Clear()

    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim Assessed As Integer = 0
        Dim PropertyTax As Double = 0

        Assessed = CInt(txtAssessed.Text)
        PropertyTax = Assessed * 0.0135

        lstOutput.Items.Add("Property Tax is " & FormatCurrency(PropertyTax))

    End Sub

End Class
