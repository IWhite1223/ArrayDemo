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
        Me.CheckDiscount = New System.Windows.Forms.CheckBox()
        Me.CheckShipping = New System.Windows.Forms.CheckBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblOrdered = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtOrdered = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CheckDiscount
        '
        Me.CheckDiscount.AutoSize = True
        Me.CheckDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckDiscount.Location = New System.Drawing.Point(306, 110)
        Me.CheckDiscount.Name = "CheckDiscount"
        Me.CheckDiscount.Size = New System.Drawing.Size(199, 32)
        Me.CheckDiscount.TabIndex = 0
        Me.CheckDiscount.Text = "Employee Discount"
        Me.CheckDiscount.UseVisualStyleBackColor = True
        '
        'CheckShipping
        '
        Me.CheckShipping.AutoSize = True
        Me.CheckShipping.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckShipping.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckShipping.Location = New System.Drawing.Point(306, 179)
        Me.CheckShipping.Name = "CheckShipping"
        Me.CheckShipping.Size = New System.Drawing.Size(232, 32)
        Me.CheckShipping.TabIndex = 1
        Me.CheckShipping.Text = "$4.99 shipping coupon"
        Me.CheckShipping.UseVisualStyleBackColor = True
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.Silver
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCalc.Location = New System.Drawing.Point(565, 105)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(94, 37)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Silver
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(565, 176)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 35)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotal.Location = New System.Drawing.Point(286, 305)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(243, 27)
        Me.TxtTotal.TabIndex = 4
        '
        'LblOrdered
        '
        Me.LblOrdered.AutoSize = True
        Me.LblOrdered.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblOrdered.Location = New System.Drawing.Point(59, 105)
        Me.LblOrdered.Name = "LblOrdered"
        Me.LblOrdered.Size = New System.Drawing.Size(92, 28)
        Me.LblOrdered.TabIndex = 5
        Me.LblOrdered.Text = "Ordered:"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotal.Location = New System.Drawing.Point(209, 301)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(71, 31)
        Me.LblTotal.TabIndex = 6
        Me.LblTotal.Text = "Total:"
        '
        'TxtOrdered
        '
        Me.TxtOrdered.Location = New System.Drawing.Point(59, 157)
        Me.TxtOrdered.Name = "TxtOrdered"
        Me.TxtOrdered.Size = New System.Drawing.Size(92, 27)
        Me.TxtOrdered.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtOrdered)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblOrdered)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.CheckShipping)
        Me.Controls.Add(Me.CheckDiscount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckDiscount As CheckBox
    Friend WithEvents CheckShipping As CheckBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblOrdered As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents TxtOrdered As TextBox
End Class
