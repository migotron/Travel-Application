<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question2))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AloneButton = New System.Windows.Forms.RadioButton()
        Me.FamilyButton = New System.Windows.Forms.RadioButton()
        Me.FriendsButton = New System.Windows.Forms.RadioButton()
        Me.SpouseButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 24)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Who are you traveling with?"
        '
        'AloneButton
        '
        Me.AloneButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.AloneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AloneButton.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.travelalone
        Me.AloneButton.Location = New System.Drawing.Point(768, 118)
        Me.AloneButton.Name = "AloneButton"
        Me.AloneButton.Size = New System.Drawing.Size(215, 228)
        Me.AloneButton.TabIndex = 39
        Me.AloneButton.Text = "Alone"
        Me.AloneButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.AloneButton.UseVisualStyleBackColor = True
        '
        'FamilyButton
        '
        Me.FamilyButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.FamilyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FamilyButton.Image = CType(resources.GetObject("FamilyButton.Image"), System.Drawing.Image)
        Me.FamilyButton.Location = New System.Drawing.Point(13, 118)
        Me.FamilyButton.Name = "FamilyButton"
        Me.FamilyButton.Size = New System.Drawing.Size(221, 228)
        Me.FamilyButton.TabIndex = 38
        Me.FamilyButton.Text = "Family"
        Me.FamilyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.FamilyButton.UseVisualStyleBackColor = True
        '
        'FriendsButton
        '
        Me.FriendsButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.FriendsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FriendsButton.Image = CType(resources.GetObject("FriendsButton.Image"), System.Drawing.Image)
        Me.FriendsButton.Location = New System.Drawing.Point(264, 118)
        Me.FriendsButton.Name = "FriendsButton"
        Me.FriendsButton.Size = New System.Drawing.Size(227, 228)
        Me.FriendsButton.TabIndex = 37
        Me.FriendsButton.Text = "Friends"
        Me.FriendsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.FriendsButton.UseVisualStyleBackColor = True
        '
        'SpouseButton
        '
        Me.SpouseButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.SpouseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SpouseButton.Image = CType(resources.GetObject("SpouseButton.Image"), System.Drawing.Image)
        Me.SpouseButton.Location = New System.Drawing.Point(509, 118)
        Me.SpouseButton.Name = "SpouseButton"
        Me.SpouseButton.Size = New System.Drawing.Size(229, 228)
        Me.SpouseButton.TabIndex = 36
        Me.SpouseButton.Text = "Spouse"
        Me.SpouseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SpouseButton.UseVisualStyleBackColor = True
        '
        'Question2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1049, 476)
        Me.Controls.Add(Me.AloneButton)
        Me.Controls.Add(Me.FamilyButton)
        Me.Controls.Add(Me.FriendsButton)
        Me.Controls.Add(Me.SpouseButton)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Question2"
        Me.Text = "Question 2 of 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AloneButton As RadioButton
    Friend WithEvents FamilyButton As RadioButton
    Friend WithEvents FriendsButton As RadioButton
    Friend WithEvents SpouseButton As RadioButton
    Friend WithEvents Label8 As Label
End Class
