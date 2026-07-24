<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        lblFlightList = New Label()
        lblDeparting = New Label()
        txtDepart = New TextBox()
        txtArrive = New TextBox()
        lblArriving = New Label()
        txtFlyWith = New TextBox()
        lblFlyingWith = New Label()
        txtPNRMain = New TextBox()
        lblPNRMainWindow = New Label()
        SuspendLayout()
        ' 
        ' lblFlightList
        ' 
        lblFlightList.AutoSize = True
        lblFlightList.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblFlightList.Location = New Point(10, 7)
        lblFlightList.Name = "lblFlightList"
        lblFlightList.Size = New Size(155, 35)
        lblFlightList.TabIndex = 27
        lblFlightList.Text = "FlghtTrackr"
        ' 
        ' lblDeparting
        ' 
        lblDeparting.AutoSize = True
        lblDeparting.Location = New Point(167, 146)
        lblDeparting.Name = "lblDeparting"
        lblDeparting.Size = New Size(59, 15)
        lblDeparting.TabIndex = 28
        lblDeparting.Text = "Departing"
        ' 
        ' txtDepart
        ' 
        txtDepart.Location = New Point(250, 140)
        txtDepart.Margin = New Padding(3, 2, 3, 2)
        txtDepart.Name = "txtDepart"
        txtDepart.Size = New Size(183, 23)
        txtDepart.TabIndex = 29
        ' 
        ' txtArrive
        ' 
        txtArrive.Location = New Point(250, 184)
        txtArrive.Margin = New Padding(3, 2, 3, 2)
        txtArrive.Name = "txtArrive"
        txtArrive.Size = New Size(183, 23)
        txtArrive.TabIndex = 31
        ' 
        ' lblArriving
        ' 
        lblArriving.AutoSize = True
        lblArriving.Location = New Point(180, 186)
        lblArriving.Name = "lblArriving"
        lblArriving.Size = New Size(49, 15)
        lblArriving.TabIndex = 30
        lblArriving.Text = "Arriving"
        ' 
        ' txtFlyWith
        ' 
        txtFlyWith.Location = New Point(397, 9)
        txtFlyWith.Margin = New Padding(3, 2, 3, 2)
        txtFlyWith.Name = "txtFlyWith"
        txtFlyWith.Size = New Size(183, 23)
        txtFlyWith.TabIndex = 33
        ' 
        ' lblFlyingWith
        ' 
        lblFlyingWith.AutoSize = True
        lblFlyingWith.Location = New Point(312, 14)
        lblFlyingWith.Name = "lblFlyingWith"
        lblFlyingWith.Size = New Size(76, 15)
        lblFlyingWith.TabIndex = 32
        lblFlyingWith.Text = "Flying With..."
        ' 
        ' txtPNRMain
        ' 
        txtPNRMain.Location = New Point(38, 65)
        txtPNRMain.Margin = New Padding(3, 2, 3, 2)
        txtPNRMain.Name = "txtPNRMain"
        txtPNRMain.Size = New Size(112, 23)
        txtPNRMain.TabIndex = 35
        ' 
        ' lblPNRMainWindow
        ' 
        lblPNRMainWindow.AutoSize = True
        lblPNRMainWindow.Location = New Point(75, 48)
        lblPNRMainWindow.Name = "lblPNRMainWindow"
        lblPNRMainWindow.Size = New Size(30, 15)
        lblPNRMainWindow.TabIndex = 34
        lblPNRMainWindow.Text = "PNR"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(txtPNRMain)
        Controls.Add(lblPNRMainWindow)
        Controls.Add(txtFlyWith)
        Controls.Add(lblFlyingWith)
        Controls.Add(txtArrive)
        Controls.Add(lblArriving)
        Controls.Add(txtDepart)
        Controls.Add(lblDeparting)
        Controls.Add(lblFlightList)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form6"
        Text = "Form6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFlightList As Label
    Friend WithEvents lblDeparting As Label
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents txtArrive As TextBox
    Friend WithEvents lblArriving As Label
    Friend WithEvents txtFlyWith As TextBox
    Friend WithEvents lblFlyingWith As Label
    Friend WithEvents txtPNRMain As TextBox
    Friend WithEvents lblPNRMainWindow As Label
End Class
