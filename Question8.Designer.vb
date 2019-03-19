<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question8
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
        Me.LocalButton = New System.Windows.Forms.RadioButton()
        Me.ForeignTravelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Would you be willing to travel to a foreign country?"
        '
        'LocalButton
        '
        Me.LocalButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.LocalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocalButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.localtravel
        Me.LocalButton.Location = New System.Drawing.Point(35, 106)
        Me.LocalButton.Name = "LocalButton"
        Me.LocalButton.Size = New System.Drawing.Size(300, 261)
        Me.LocalButton.TabIndex = 22
        Me.LocalButton.Text = "No thank you, I would like to stay local!"
        Me.LocalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.LocalButton.UseVisualStyleBackColor = True
        '
        'ForeignTravelButton
        '
        Me.ForeignTravelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeignTravelButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.foreigntravel
        Me.ForeignTravelButton.Location = New System.Drawing.Point(366, 106)
        Me.ForeignTravelButton.Name = "ForeignTravelButton"
        Me.ForeignTravelButton.Size = New System.Drawing.Size(295, 261)
        Me.ForeignTravelButton.TabIndex = 2
        Me.ForeignTravelButton.Text = "Yes, I would be willing to experience new adventures!"
        Me.ForeignTravelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ForeignTravelButton.UseVisualStyleBackColor = True
        '
        'Question8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 413)
        Me.Controls.Add(Me.LocalButton)
        Me.Controls.Add(Me.ForeignTravelButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Question8"
        Me.Text = "Question 8 of 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ForeignTravelButton As Button
    Friend WithEvents LocalButton As RadioButton
End Class
