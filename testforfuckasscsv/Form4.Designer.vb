<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnContinue = New Button()
        Label1 = New Label()
        lblAirlineWarning = New Label()
        lstAirlineInt = New ListBox()
        lblFlightList = New Label()
        SuspendLayout()
        ' 
        ' btnContinue
        ' 
        btnContinue.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnContinue.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnContinue.ForeColor = SystemColors.ButtonHighlight
        btnContinue.Location = New Point(221, 79)
        btnContinue.Margin = New Padding(3, 2, 3, 2)
        btnContinue.Name = "btnContinue"
        btnContinue.Size = New Size(108, 41)
        btnContinue.TabIndex = 30
        btnContinue.Text = "Continue ➡️"
        btnContinue.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(211, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 46)
        Label1.TabIndex = 29
        Label1.Text = "🌐"
        ' 
        ' lblAirlineWarning
        ' 
        lblAirlineWarning.AutoSize = True
        lblAirlineWarning.Location = New Point(23, 199)
        lblAirlineWarning.Name = "lblAirlineWarning"
        lblAirlineWarning.Size = New Size(0, 20)
        lblAirlineWarning.TabIndex = 28
        ' 
        ' lstAirlineInt
        ' 
        lstAirlineInt.FormattingEnabled = True
        lstAirlineInt.Location = New Point(23, 60)
        lstAirlineInt.Margin = New Padding(3, 2, 3, 2)
        lstAirlineInt.Name = "lstAirlineInt"
        lstAirlineInt.Size = New Size(193, 124)
        lstAirlineInt.TabIndex = 27
        ' 
        ' lblFlightList
        ' 
        lblFlightList.AutoSize = True
        lblFlightList.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblFlightList.Location = New Point(12, 9)
        lblFlightList.Name = "lblFlightList"
        lblFlightList.Size = New Size(193, 45)
        lblFlightList.TabIndex = 26
        lblFlightList.Text = "FlghtTrackr"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 238)
        Controls.Add(btnContinue)
        Controls.Add(Label1)
        Controls.Add(lblAirlineWarning)
        Controls.Add(lstAirlineInt)
        Controls.Add(lblFlightList)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnContinue As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAirlineWarning As Label
    Friend WithEvents lstAirlineInt As ListBox
    Friend WithEvents lblFlightList As Label
End Class
