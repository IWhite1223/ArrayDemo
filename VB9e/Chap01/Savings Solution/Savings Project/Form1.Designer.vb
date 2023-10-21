<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deposit:"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(309, 157)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(125, 27)
        Me.txtDeposit.TabIndex = 1
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalc.Location = New System.Drawing.Point(619, 187)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(94, 29)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(619, 249)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 29)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(309, 249)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBalance.Size = New System.Drawing.Size(230, 27)
        Me.txtBalance.TabIndex = 4
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(224, 258)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(64, 20)
        Me.lblBalance.TabIndex = 5
        Me.lblBalance.Text = "Balance:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents lblBalance As Label
End Class
