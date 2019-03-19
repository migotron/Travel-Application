<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Question10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question10))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.RadioButton()
        Me.NoButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(141, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(434, 24)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Do you require any special handicap assistance?"
        '
        'YesButton
        '
        Me.YesButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.YesButton.AutoSize = True
        Me.YesButton.Image = CType(resources.GetObject("YesButton.Image"), System.Drawing.Image)
        Me.YesButton.Location = New System.Drawing.Point(64, 121)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(230, 248)
        Me.YesButton.TabIndex = 46
        Me.YesButton.Text = "Yes"
        Me.YesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.NoButton.AutoSize = True
        Me.NoButton.Image = CType(resources.GetObject("NoButton.Image"), System.Drawing.Image)
        Me.NoButton.Location = New System.Drawing.Point(451, 121)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(231, 248)
        Me.NoButton.TabIndex = 45
        Me.NoButton.Text = "No"
        Me.NoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'Question10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(839, 485)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.Label10)
        Me.Name = "Question10"
        Me.Text = "Question 10 of 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YesButton As RadioButton
    Friend WithEvents NoButton As RadioButton
    Friend WithEvents Label10 As Label
End Class
