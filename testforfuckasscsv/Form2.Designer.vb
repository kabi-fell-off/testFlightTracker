<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        radDomestic = New RadioButton()
        radInternational = New RadioButton()
        SuspendLayout()
        ' 
        ' radDomestic
        ' 
        radDomestic.AutoSize = True
        radDomestic.Location = New Point(134, 115)
        radDomestic.Name = "radDomestic"
        radDomestic.Size = New Size(93, 24)
        radDomestic.TabIndex = 0
        radDomestic.TabStop = True
        radDomestic.Text = "Domestic"
        radDomestic.UseVisualStyleBackColor = True
        ' 
        ' radInternational
        ' 
        radInternational.AutoSize = True
        radInternational.Location = New Point(134, 167)
        radInternational.Name = "radInternational"
        radInternational.Size = New Size(114, 24)
        radInternational.TabIndex = 1
        radInternational.TabStop = True
        radInternational.Text = "International"
        radInternational.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(425, 301)
        Controls.Add(radInternational)
        Controls.Add(radDomestic)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents radDomestic As RadioButton
    Friend WithEvents radInternational As RadioButton
End Class
