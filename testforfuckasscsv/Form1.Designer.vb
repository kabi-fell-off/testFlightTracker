<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtPNR = New TextBox()
        btnProceed = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(138, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 0
        Label1.Text = "Please enter code"
        ' 
        ' txtPNR
        ' 
        txtPNR.Location = New Point(87, 236)
        txtPNR.Name = "txtPNR"
        txtPNR.Size = New Size(232, 27)
        txtPNR.TabIndex = 1
        ' 
        ' btnProceed
        ' 
        btnProceed.Location = New Point(155, 269)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(94, 29)
        btnProceed.TabIndex = 2
        btnProceed.Text = "Proceed"
        btnProceed.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(421, 452)
        Controls.Add(btnProceed)
        Controls.Add(txtPNR)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPNR As TextBox
    Friend WithEvents btnProceed As Button

End Class
