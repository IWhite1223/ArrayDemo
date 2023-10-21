Public Class Form1
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim rate As Double
        Dim discount As Double
        Dim shipping As Double
        Dim total As Decimal
        Dim item As Integer
        rate = 25.99
        discount = 0
        shipping = 9.99

        item = TxtOrdered.Text
        total = rate * item

        If checkDiscount.Checked = True Then
            discount = total * 10 / 100
        End If

        If checkShipping.Checked = True Then
            shipping = 4.99
        End If

        total = total - discount + shipping

        TxtTotal.Text = "$" + total.ToString

    End Sub

End Class
