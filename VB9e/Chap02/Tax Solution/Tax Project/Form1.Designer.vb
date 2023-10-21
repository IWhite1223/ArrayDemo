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
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAssessed = New System.Windows.Forms.Label()
        Me.txtAssessed = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalc.Location = New System.Drawing.Point(573, 137)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(82, 31)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(615, 413)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 25)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(680, 137)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(89, 31)
        Me.BtnClear.TabIndex = 6
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(197, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Property Tax Calculator"
        '
        'lblAssessed
        '
        Me.lblAssessed.AutoSize = True
        Me.lblAssessed.Location = New System.Drawing.Point(128, 148)
        Me.lblAssessed.Name = "lblAssessed"
        Me.lblAssessed.Size = New System.Drawing.Size(146, 20)
        Me.lblAssessed.TabIndex = 9
        Me.lblAssessed.Text = "Enter Assessed Value"
        '
        'txtAssessed
        '
        Me.txtAssessed.Location = New System.Drawing.Point(290, 141)
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.Size = New System.Drawing.Size(242, 27)
        Me.txtAssessed.TabIndex = 10
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 20
        Me.lstOutput.Location = New System.Drawing.Point(151, 205)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(408, 104)
        Me.lstOutput.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.lblAssessed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Property Tax Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAssessed As Label
    Friend WithEvents txtAssessed As TextBox
    Friend WithEvents lstOutput As ListBox
End Class
