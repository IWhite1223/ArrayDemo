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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoGlaze = New System.Windows.Forms.RadioButton()
        Me.rdoSug = New System.Windows.Forms.RadioButton()
        Me.rdoChoc = New System.Windows.Forms.RadioButton()
        Me.rdoFill = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoCap = New System.Windows.Forms.RadioButton()
        Me.rdoReg = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sales tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total due:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoGlaze)
        Me.GroupBox1.Controls.Add(Me.rdoSug)
        Me.GroupBox1.Controls.Add(Me.rdoChoc)
        Me.GroupBox1.Controls.Add(Me.rdoFill)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 213)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doughnuts choices"
        '
        'rdoGlaze
        '
        Me.rdoGlaze.AutoSize = True
        Me.rdoGlaze.Location = New System.Drawing.Point(25, 52)
        Me.rdoGlaze.Name = "rdoGlaze"
        Me.rdoGlaze.Size = New System.Drawing.Size(160, 32)
        Me.rdoGlaze.TabIndex = 21
        Me.rdoGlaze.TabStop = True
        Me.rdoGlaze.Text = "Glazed ($1.05)"
        Me.rdoGlaze.UseVisualStyleBackColor = True
        '
        'rdoSug
        '
        Me.rdoSug.AutoSize = True
        Me.rdoSug.Location = New System.Drawing.Point(25, 90)
        Me.rdoSug.Name = "rdoSug"
        Me.rdoSug.Size = New System.Drawing.Size(151, 32)
        Me.rdoSug.TabIndex = 22
        Me.rdoSug.TabStop = True
        Me.rdoSug.Text = "Sugar ($1.05)"
        Me.rdoSug.UseVisualStyleBackColor = True
        '
        'rdoChoc
        '
        Me.rdoChoc.AutoSize = True
        Me.rdoChoc.Location = New System.Drawing.Point(25, 127)
        Me.rdoChoc.Name = "rdoChoc"
        Me.rdoChoc.Size = New System.Drawing.Size(189, 32)
        Me.rdoChoc.TabIndex = 23
        Me.rdoChoc.TabStop = True
        Me.rdoChoc.Text = "Chocolate ($1.25)"
        Me.rdoChoc.UseVisualStyleBackColor = True
        '
        'rdoFill
        '
        Me.rdoFill.AutoSize = True
        Me.rdoFill.Location = New System.Drawing.Point(25, 165)
        Me.rdoFill.Name = "rdoFill"
        Me.rdoFill.Size = New System.Drawing.Size(147, 32)
        Me.rdoFill.TabIndex = 24
        Me.rdoFill.TabStop = True
        Me.rdoFill.Text = "Filled ($1.50)"
        Me.rdoFill.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoCap)
        Me.GroupBox2.Controls.Add(Me.rdoReg)
        Me.GroupBox2.Controls.Add(Me.rdoNone)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(89, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 166)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee choices"
        '
        'rdoCap
        '
        Me.rdoCap.AutoSize = True
        Me.rdoCap.Location = New System.Drawing.Point(11, 126)
        Me.rdoCap.Name = "rdoCap"
        Me.rdoCap.Size = New System.Drawing.Size(207, 32)
        Me.rdoCap.TabIndex = 2
        Me.rdoCap.TabStop = True
        Me.rdoCap.Text = "Cappuccino ($2.75)"
        Me.rdoCap.UseVisualStyleBackColor = True
        '
        'rdoReg
        '
        Me.rdoReg.AutoSize = True
        Me.rdoReg.Location = New System.Drawing.Point(11, 90)
        Me.rdoReg.Name = "rdoReg"
        Me.rdoReg.Size = New System.Drawing.Size(167, 32)
        Me.rdoReg.TabIndex = 1
        Me.rdoReg.TabStop = True
        Me.rdoReg.Text = "Regular ($1.50)"
        Me.rdoReg.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(11, 52)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(83, 32)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalc.Location = New System.Drawing.Point(626, 318)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(94, 29)
        Me.btnCalc.TabIndex = 17
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(626, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 29)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(470, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 185)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTotal.Location = New System.Drawing.Point(125, 136)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(68, 20)
        Me.lblTotal.TabIndex = 18
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Control
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblTax.Location = New System.Drawing.Point(125, 95)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(68, 20)
        Me.lblTax.TabIndex = 17
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSubtotal.Location = New System.Drawing.Point(125, 52)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(68, 20)
        Me.lblSubtotal.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(51, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 41)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Our doughnuts and coffee are the best in town!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoGlaze As RadioButton
    Friend WithEvents rdoSug As RadioButton
    Friend WithEvents rdoChoc As RadioButton
    Friend WithEvents rdoFill As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoCap As RadioButton
    Friend WithEvents rdoReg As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
End Class
