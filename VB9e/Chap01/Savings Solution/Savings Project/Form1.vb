Option Explicit On
Option Strict On
Option Infer Off



Public Class Form1
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim dblDeposit As Double
        Dim dblBalance As Double

        Double.TryParse(txtDeposit.Text, dblDeposit)

        txtBalance.Text = "Rate" & ControlChars.Tab &
            "Year" & ControlChars.Tab & "Balance" &
            ControlChars.NewLine

        ' Calculate and display account balances. 

    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged
        txtDeposit.SelectAll()
    End Sub

    Private Sub txtDeposit_Enter(sender As Object, e As EventArgs) Handles txtDeposit.Enter
        txtDeposit.SelectAll()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeposit.KeyPress
        ' Allows the text box to accept only numbers, the period, and the Backspace key.

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



End Class
