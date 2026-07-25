Public Class Form5
    ' Form5: Final Booking Confirmation
    ' Displays booked flight code and asks user to confirm
    ' All data from CSV
    
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the booked flight code from CSV
        txtBookedFlight.Text = GetPassengerField(FLIGHT_CODE_INDEX)
    End Sub
    
    Private Sub btnConfirmFlight_Click(sender As Object, e As EventArgs) Handles btnConfirmFlight.Click
        ' Confirm booking
        MessageBox.Show("Your flight booking has been confirmed. Flight " & GetPassengerField(FLIGHT_CODE_INDEX) & " is booked. Have a great flight!", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ' Clear passenger data and return to Form1 for next booking
        ClearPassengerData()
        Me.Hide()
        Form1.Show()
    End Sub
    
    Private Sub btnReturnBack_Click(sender As Object, e As EventArgs) Handles btnReturnBack.Click
        ' Return to Form4 to review details
        Me.Hide()
        Form4.Show()
    End Sub
    
    Private Sub txtBookedFlight_TextChanged(sender As Object, e As EventArgs) Handles txtBookedFlight.TextChanged
        ' Read-only textbox; no action needed
    End Sub
End Class