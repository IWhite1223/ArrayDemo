Imports System.IO
Public Class Form1
    Dim waiters As New List(Of String)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String
        name = txtName.Text

        waiters.Add(name)
        lstWorkers.Items.Add(name)

        txtName.Clear()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        writeResult()
    End Sub

    Private Sub writeResult()
        Try
            Dim objWriter As StreamWriter
            objWriter = New StreamWriter("waiters.txt")

            For Each waiter In waiters
                objWriter.WriteLine(waiter)
            Next
            MessageBox.Show("Data has been saved.", "Saved File")

            objWriter.Close()

        Catch ex As Exception
            MessageBox.Show("Error!!! Processing file...", "File I/O Error")
        End Try
    End Sub

End Class
