Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblSlices As Double

        Dim entirePizza As Rectangle

        Dim pizzaSlice As Rectangle

        Dim intEntireSide As Integer

        Dim intSliceSide As Integer


        Integer.TryParse(txtEntireSide.Text, intEntireSide)

        Integer.TryParse(txtSliceSide.Text, intSliceSide)

        If intEntireSide > 0 AndAlso intSliceSide > 0 Then

            entirePizza = New Rectangle()

            pizzaSlice = New Rectangle()


            entirePizza.Height = intEntireSide

            pizzaSlice.Width = intSliceSide





            'calculate number of slices

            dblSlices = intSliceSide / intEntireSide

        End If
        lblSlices.Text = dblSlices.ToString("N1")
    End Sub

    Private Sub txtEntireSide_Enter(sender As Object, e As EventArgs) Handles txtEntireSide.Enter
        txtEntireSide.SelectAll()
    End Sub

    Private Sub txtSliceSide_Enter(sender As Object, e As EventArgs) Handles txtSliceSide.Enter
        txtSliceSide.SelectAll()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtEntireSide.KeyPress, txtSliceSide.KeyPress
        ' Accept only numbers and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearSlices(sender As Object, e As EventArgs) Handles txtEntireSide.TextChanged, txtSliceSide.TextChanged
        lblSlices.Text = String.Empty
    End Sub
End Class
