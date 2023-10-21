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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblPay = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(434, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Principal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(328, 378)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monthly payments:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(772, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rate(%):"
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 28
        Me.lstRates.Location = New System.Drawing.Point(772, 144)
        Me.lstRates.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(128, 200)
        Me.lstRates.TabIndex = 3
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPrincipal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPrincipal.Location = New System.Drawing.Point(434, 153)
        Me.TxtPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(210, 40)
        Me.TxtPrincipal.TabIndex = 4
        '
        'lblPay
        '
        Me.lblPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblPay.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPay.Location = New System.Drawing.Point(328, 410)
        Me.lblPay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(407, 40)
        Me.lblPay.TabIndex = 5
        '
        'BtnCalc
        '
        Me.BtnCalc.BackColor = System.Drawing.Color.Silver
        Me.BtnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalc.Location = New System.Drawing.Point(859, 463)
        Me.BtnCalc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(129, 60)
        Me.BtnCalc.TabIndex = 6
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Silver
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(859, 532)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(129, 55)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 630)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.TxtPrincipal)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Monthly Payment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstRates As ListBox
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents lblPay As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
