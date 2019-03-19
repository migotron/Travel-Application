<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question6
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
        Me.Waterrafting = New System.Windows.Forms.PictureBox()
        Me.Skiing = New System.Windows.Forms.PictureBox()
        Me.Parasailing = New System.Windows.Forms.PictureBox()
        Me.Hiking = New System.Windows.Forms.PictureBox()
        CType(Me.Waterrafting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skiing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Parasailing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hiking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which of the following pictures looks the most fun for you?"
        '
        'Waterrafting
        '
        Me.Waterrafting.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.waterrafting
        Me.Waterrafting.Location = New System.Drawing.Point(39, 102)
        Me.Waterrafting.Name = "Waterrafting"
        Me.Waterrafting.Size = New System.Drawing.Size(325, 192)
        Me.Waterrafting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Waterrafting.TabIndex = 1
        Me.Waterrafting.TabStop = False
        '
        'Skiing
        '
        Me.Skiing.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.skiing
        Me.Skiing.Location = New System.Drawing.Point(370, 102)
        Me.Skiing.Name = "Skiing"
        Me.Skiing.Size = New System.Drawing.Size(309, 192)
        Me.Skiing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Skiing.TabIndex = 2
        Me.Skiing.TabStop = False
        '
        'Parasailing
        '
        Me.Parasailing.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.parasailinghawaii
        Me.Parasailing.Location = New System.Drawing.Point(39, 300)
        Me.Parasailing.Name = "Parasailing"
        Me.Parasailing.Size = New System.Drawing.Size(325, 174)
        Me.Parasailing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Parasailing.TabIndex = 3
        Me.Parasailing.TabStop = False
        '
        'Hiking
        '
        Me.Hiking.Image = Global.Adventure_Travel_Agency.My.Resources.Resources.hiking
        Me.Hiking.Location = New System.Drawing.Point(370, 300)
        Me.Hiking.Name = "Hiking"
        Me.Hiking.Size = New System.Drawing.Size(309, 174)
        Me.Hiking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hiking.TabIndex = 4
        Me.Hiking.TabStop = False
        '
        'Question6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(736, 499)
        Me.Controls.Add(Me.Hiking)
        Me.Controls.Add(Me.Parasailing)
        Me.Controls.Add(Me.Skiing)
        Me.Controls.Add(Me.Waterrafting)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Question6"
        Me.Text = "Question 6 of 10"
        CType(Me.Waterrafting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skiing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Parasailing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hiking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Waterrafting As PictureBox
    Friend WithEvents Skiing As PictureBox
    Friend WithEvents Parasailing As PictureBox
    Friend WithEvents Hiking As PictureBox
End Class
