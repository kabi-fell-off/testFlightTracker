<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblAirlineWarning = New Label()
        btnContinue = New Button()
        lstAirlinesDom = New ListBox()
        lblFlightList = New Label()
        SuspendLayout()
        ' 
        ' lblAirlineWarning
        ' 
        lblAirlineWarning.AutoSize = True
        lblAirlineWarning.Location = New Point(23, 202)
        lblAirlineWarning.Name = "lblAirlineWarning"
        lblAirlineWarning.Size = New Size(0, 20)
        lblAirlineWarning.TabIndex = 22
        ' 
        ' btnContinue
        ' 
        btnContinue.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnContinue.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnContinue.ForeColor = SystemColors.ButtonHighlight
        btnContinue.Location = New Point(221, 80)
        btnContinue.Margin = New Padding(3, 2, 3, 2)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(108, 38)
        btnContinue.TabIndex = 21
        btnContinue.Text = "Continue ➡️"
        btnContinue.UseVisualStyleBackColor = False
        ' 
        ' lstAirlinesDom
        ' 
        lstAirlinesDom.FormattingEnabled = True
        lstAirlinesDom.Location = New Point(23, 60)
        lstAirlinesDom.Margin = New Padding(3, 2, 3, 2)
        lstAirlinesDom.Name = "lstAirlinesDom"
        lstAirlinesDom.Size = New Size(193, 124)
        lstAirlinesDom.TabIndex = 20
        ' 
        ' lblFlightList
        ' 
        lblFlightList.AutoSize = True
        lblFlightList.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblFlightList.Location = New Point(12, 9)
        lblFlightList.Name = "lblFlightList"
        lblFlightList.Size = New Size(193, 45)
        lblFlightList.TabIndex = 19
        lblFlightList.Text = "FlghtTrackr"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 259)
        Controls.Add(lblAirlineWarning)
        Controls.Add(btnContinue)
        Controls.Add(lstAirlinesDom)
        Controls.Add(lblFlightList)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAirlineWarning As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents lstAirlinesDom As ListBox
    Friend WithEvents lblFlightList As Label
End Class
