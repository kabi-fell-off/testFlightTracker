Public Class Form2
    ' Form2: Flight Type Selection (Domestic vs International)
    ' Validates selected flight type against CSV FlightType field
    ' Displays unique error if selection doesn't match CSV data
    
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form loaded; radio buttons ready for selection
    End Sub
    
    Private Sub radDomestic_CheckedChanged(sender As Object, e As EventArgs) Handles radDomestic.CheckedChanged
        ' Handle domestic selection
    End Sub
    
    Private Sub radInternational_CheckedChanged(sender As Object, e As EventArgs) Handles radInternational.CheckedChanged
        ' Handle international selection
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Determine selected flight type
        Dim selectedType As String = If(radDomestic.Checked, "Domestic", If(radInternational.Checked, "International", ""))
        
        ' Validate that a selection was made
        If String.IsNullOrEmpty(selectedType) Then
            MessageBox.Show("Please select either Domestic or International flight type.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Validate selected type against CSV FlightType
        If String.Equals(GetPassengerField(FLIGHT_TYPE_INDEX), selectedType, StringComparison.OrdinalIgnoreCase) Then
            ' Flight type matches CSV: proceed to Form3
            Me.Hide()
            Form3.Show()
        Else
            ' Flight type mismatch with CSV
            MessageBox.Show("Your selection of '" & selectedType & "' does not match the flight type in our system. The correct type is '" & GetPassengerField(FLIGHT_TYPE_INDEX) & "'. Please select the correct option.", "Flight Type Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form1
        Me.Hide()
        Form1.Show()
    End Sub
End Class