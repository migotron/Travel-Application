<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question4))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WinterButton = New System.Windows.Forms.RadioButton()
        Me.SpringButton = New System.Windows.Forms.RadioButton()
        Me.SummerButton = New System.Windows.Forms.RadioButton()
        Me.FallButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(117, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(265, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Which season do you prefer?"
        '
        'WinterButton
        '
        Me.WinterButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.WinterButton.Image = CType(resources.GetObject("WinterButton.Image"), System.Drawing.Image)
        Me.WinterButton.Location = New System.Drawing.Point(315, 301)
        Me.WinterButton.Name = "WinterButton"
        Me.WinterButton.Size = New System.Drawing.Size(263, 188)
        Me.WinterButton.TabIndex = 27
        Me.WinterButton.Text = "Winter"
        Me.WinterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.WinterButton.UseVisualStyleBackColor = True
        '
        'SpringButton
        '
        Me.SpringButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.SpringButton.Image = CType(resources.GetObject("SpringButton.Image"), System.Drawing.Image)
        Me.SpringButton.Location = New System.Drawing.Point(15, 87)
        Me.SpringButton.Name = "SpringButton"
        Me.SpringButton.Size = New System.Drawing.Size(260, 191)
        Me.SpringButton.TabIndex = 26
        Me.SpringButton.Text = "Spring"
        Me.SpringButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SpringButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SpringButton.UseVisualStyleBackColor = True
        '
        'SummerButton
        '
        Me.SummerButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.SummerButton.Image = CType(resources.GetObject("SummerButton.Image"), System.Drawing.Image)
        Me.SummerButton.Location = New System.Drawing.Point(315, 87)
        Me.SummerButton.Name = "SummerButton"
        Me.SummerButton.Size = New System.Drawing.Size(263, 192)
        Me.SummerButton.TabIndex = 25
        Me.SummerButton.Text = "Summer"
        Me.SummerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SummerButton.UseVisualStyleBackColor = True
        '
        'FallButton
        '
        Me.FallButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.FallButton.Image = CType(resources.GetObject("FallButton.Image"), System.Drawing.Image)
        Me.FallButton.Location = New System.Drawing.Point(15, 300)
        Me.FallButton.Name = "FallButton"
        Me.FallButton.Size = New System.Drawing.Size(258, 189)
        Me.FallButton.TabIndex = 24
        Me.FallButton.Text = "Fall"
        Me.FallButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.FallButton.UseVisualStyleBackColor = True
        '
        'Question4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(686, 537)
        Me.Controls.Add(Me.WinterButton)
        Me.Controls.Add(Me.SpringButton)
        Me.Controls.Add(Me.SummerButton)
        Me.Controls.Add(Me.FallButton)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Question4"
        Me.Text = "Question 4 of 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinterButton As RadioButton
    Friend WithEvents SpringButton As RadioButton
    Friend WithEvents SummerButton As RadioButton
    Friend WithEvents FallButton As RadioButton
    Friend WithEvents Label5 As Label
End Class
