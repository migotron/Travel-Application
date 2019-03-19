<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question1))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdventurousButton = New System.Windows.Forms.RadioButton()
        Me.NatureLoverButton = New System.Windows.Forms.RadioButton()
        Me.DangerJunkieButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(218, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "What is your type of personality?"
        '
        'AdventurousButton
        '
        Me.AdventurousButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.AdventurousButton.Image = CType(resources.GetObject("AdventurousButton.Image"), System.Drawing.Image)
        Me.AdventurousButton.Location = New System.Drawing.Point(12, 110)
        Me.AdventurousButton.Name = "AdventurousButton"
        Me.AdventurousButton.Size = New System.Drawing.Size(293, 211)
        Me.AdventurousButton.TabIndex = 21
        Me.AdventurousButton.Text = "Adventurous"
        Me.AdventurousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.AdventurousButton.UseVisualStyleBackColor = True
        '
        'NatureLoverButton
        '
        Me.NatureLoverButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.NatureLoverButton.Image = CType(resources.GetObject("NatureLoverButton.Image"), System.Drawing.Image)
        Me.NatureLoverButton.Location = New System.Drawing.Point(311, 110)
        Me.NatureLoverButton.Name = "NatureLoverButton"
        Me.NatureLoverButton.Size = New System.Drawing.Size(279, 211)
        Me.NatureLoverButton.TabIndex = 20
        Me.NatureLoverButton.Text = "Nature Lover"
        Me.NatureLoverButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.NatureLoverButton.UseVisualStyleBackColor = True
        '
        'DangerJunkieButton
        '
        Me.DangerJunkieButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.DangerJunkieButton.Image = CType(resources.GetObject("DangerJunkieButton.Image"), System.Drawing.Image)
        Me.DangerJunkieButton.Location = New System.Drawing.Point(596, 110)
        Me.DangerJunkieButton.Name = "DangerJunkieButton"
        Me.DangerJunkieButton.Size = New System.Drawing.Size(267, 211)
        Me.DangerJunkieButton.TabIndex = 19
        Me.DangerJunkieButton.Text = "Danger Junkie"
        Me.DangerJunkieButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.DangerJunkieButton.UseVisualStyleBackColor = True
        '
        'Question1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 504)
        Me.Controls.Add(Me.AdventurousButton)
        Me.Controls.Add(Me.NatureLoverButton)
        Me.Controls.Add(Me.DangerJunkieButton)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Question1"
        Me.Text = "Question 1 of 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdventurousButton As RadioButton
    Friend WithEvents NatureLoverButton As RadioButton
    Friend WithEvents DangerJunkieButton As RadioButton
    Friend WithEvents Label4 As Label
End Class
