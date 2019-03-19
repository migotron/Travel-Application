<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IndiaButton = New System.Windows.Forms.Button()
        Me.SAButton = New System.Windows.Forms.Button()
        Me.USButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which of the following countries are you located within?"
        '
        'IndiaButton
        '
        Me.IndiaButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndiaButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.Indiaflag1
        Me.IndiaButton.Location = New System.Drawing.Point(608, 265)
        Me.IndiaButton.Name = "IndiaButton"
        Me.IndiaButton.Size = New System.Drawing.Size(285, 182)
        Me.IndiaButton.TabIndex = 4
        Me.IndiaButton.Text = "India"
        Me.IndiaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.IndiaButton.UseVisualStyleBackColor = True
        '
        'SAButton
        '
        Me.SAButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.SaudiArabiaflag1
        Me.SAButton.Location = New System.Drawing.Point(317, 177)
        Me.SAButton.Name = "SAButton"
        Me.SAButton.Size = New System.Drawing.Size(285, 182)
        Me.SAButton.TabIndex = 3
        Me.SAButton.Text = "Saudi Arabia"
        Me.SAButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SAButton.UseVisualStyleBackColor = True
        '
        'USButton
        '
        Me.USButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.USflag
        Me.USButton.Location = New System.Drawing.Point(26, 96)
        Me.USButton.Name = "USButton"
        Me.USButton.Size = New System.Drawing.Size(285, 182)
        Me.USButton.TabIndex = 2
        Me.USButton.Text = "United States"
        Me.USButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.USButton.UseVisualStyleBackColor = True
        '
        'Question3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 452)
        Me.Controls.Add(Me.IndiaButton)
        Me.Controls.Add(Me.SAButton)
        Me.Controls.Add(Me.USButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Question3"
        Me.Text = "Question3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents USButton As Button
    Friend WithEvents SAButton As Button
    Friend WithEvents IndiaButton As Button
End Class
