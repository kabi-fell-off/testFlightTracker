<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnConfirmFlight = New Button()
        Label2 = New Label()
        lblFlightList = New Label()
        btnReturnBack = New Button()
        lblWarning = New Label()
        txtBookedFlight = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnConfirmFlight
        ' 
        btnConfirmFlight.BackColor = Color.MediumAquamarine
        btnConfirmFlight.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        btnConfirmFlight.ForeColor = SystemColors.ButtonHighlight
        btnConfirmFlight.Location = New Point(279, 267)
        btnConfirmFlight.Margin = New Padding(3, 2, 3, 2)
        btnConfirmFlight.Name = "btnConfirmFlight"
        btnConfirmFlight.Size = New Size(170, 28)
        btnConfirmFlight.TabIndex = 25
        btnConfirmFlight.Text = "Yes, this is my flight ✔️"
        btnConfirmFlight.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(317, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 45)
        Label2.TabIndex = 24
        Label2.Text = "🗓️"
        ' 
        ' lblFlightList
        ' 
        lblFlightList.AutoSize = True
        lblFlightList.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblFlightList.Location = New Point(155, 102)
        lblFlightList.Name = "lblFlightList"
        lblFlightList.Size = New Size(193, 45)
        lblFlightList.TabIndex = 23
        lblFlightList.Text = "FlghtTrackr"
        ' 
        ' btnReturnBack
        ' 
        btnReturnBack.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnReturnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnReturnBack.ForeColor = SystemColors.ButtonHighlight
        btnReturnBack.Location = New Point(513, 327)
        btnReturnBack.Margin = New Padding(3, 2, 3, 2)
        btnReturnBack.Name = "btnReturnBack"
        btnReturnBack.Size = New Size(82, 28)
        btnReturnBack.TabIndex = 22
        btnReturnBack.Text = "Return"
        btnReturnBack.UseVisualStyleBackColor = False
        ' 
        ' lblWarning
        ' 
        lblWarning.AutoSize = True
        lblWarning.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblWarning.Location = New Point(165, 297)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(395, 17)
        lblWarning.TabIndex = 21
        lblWarning.Text = "If not, please return and check that you have entered the correct code"
        ' 
        ' txtBookedFlight
        ' 
        txtBookedFlight.Enabled = False
        txtBookedFlight.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBookedFlight.Location = New Point(219, 230)
        txtBookedFlight.Margin = New Padding(3, 2, 3, 2)
        txtBookedFlight.Name = "txtBookedFlight"
        txtBookedFlight.Size = New Size(282, 27)
        txtBookedFlight.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(165, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(480, 49)
        Label1.TabIndex = 19
        Label1.Text = "Is this your booked flight?"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnConfirmFlight)
        Controls.Add(Label2)
        Controls.Add(lblFlightList)
        Controls.Add(btnReturnBack)
        Controls.Add(lblWarning)
        Controls.Add(txtBookedFlight)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConfirmFlight As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFlightList As Label
    Friend WithEvents btnReturnBack As Button
    Friend WithEvents lblWarning As Label
    Friend WithEvents txtBookedFlight As TextBox
    Friend WithEvents Label1 As Label
End Class
