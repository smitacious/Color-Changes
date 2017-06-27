<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignment_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.lblBackground = New System.Windows.Forms.Label()
        Me.lblForeground = New System.Windows.Forms.Label()
        Me.txtQuote = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBlue
        '
        Me.btnBlue.BackColor = System.Drawing.SystemColors.Control
        Me.btnBlue.Location = New System.Drawing.Point(262, 31)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(85, 30)
        Me.btnBlue.TabIndex = 0
        Me.btnBlue.Text = "&Blue"
        Me.btnBlue.UseVisualStyleBackColor = False
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(427, 99)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(85, 30)
        Me.btnGreen.TabIndex = 3
        Me.btnGreen.Text = "&Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(262, 99)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(85, 30)
        Me.btnRed.TabIndex = 2
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.Location = New System.Drawing.Point(427, 31)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(85, 30)
        Me.btnYellow.TabIndex = 1
        Me.btnYellow.Text = "&Yellow"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'lblBackground
        '
        Me.lblBackground.AutoSize = True
        Me.lblBackground.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackground.Location = New System.Drawing.Point(41, 38)
        Me.lblBackground.Name = "lblBackground"
        Me.lblBackground.Size = New System.Drawing.Size(111, 23)
        Me.lblBackground.TabIndex = 4
        Me.lblBackground.Text = "Background"
        '
        'lblForeground
        '
        Me.lblForeground.AutoSize = True
        Me.lblForeground.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForeground.Location = New System.Drawing.Point(41, 106)
        Me.lblForeground.Name = "lblForeground"
        Me.lblForeground.Size = New System.Drawing.Size(107, 23)
        Me.lblForeground.TabIndex = 5
        Me.lblForeground.Text = "Foreground"
        '
        'txtQuote
        '
        Me.txtQuote.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuote.Location = New System.Drawing.Point(45, 155)
        Me.txtQuote.Multiline = True
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.Size = New System.Drawing.Size(467, 92)
        Me.txtQuote.TabIndex = 6
        Me.txtQuote.Text = """Education is the key to success in life and teachers make a lasting impacts in t" & _
    "he lives of their students"" - Solomon Ortiz"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(142, 253)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(93, 41)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(351, 253)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(93, 41)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmAssignment_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 361)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtQuote)
        Me.Controls.Add(Me.lblForeground)
        Me.Controls.Add(Me.lblBackground)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.btnGreen)
        Me.Controls.Add(Me.btnBlue)
        Me.Name = "frmAssignment_1"
        Me.Text = "Assignment # 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBlue As System.Windows.Forms.Button
    Friend WithEvents btnGreen As System.Windows.Forms.Button
    Friend WithEvents btnRed As System.Windows.Forms.Button
    Friend WithEvents btnYellow As System.Windows.Forms.Button
    Friend WithEvents lblBackground As System.Windows.Forms.Label
    Friend WithEvents lblForeground As System.Windows.Forms.Label
    Friend WithEvents txtQuote As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button

End Class
