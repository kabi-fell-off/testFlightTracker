Public Class Form3
    ' Form3 displays seat information: SeatNumber and SeatClass
    ' All data is retrieved from the shared PassengerData (CSV)
    
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve seat information from the shared passenger data
        Dim seatNumber As String = GetPassengerField(SEAT_NUMBER_INDEX)
        Dim seatClass As String = GetPassengerField(SEAT_CLASS_INDEX)
        
        ' Display seat number
        lblSeatNumber.Text = "Seat Number: " & seatNumber
        
        ' Display seat class
        lblSeatClass.Text = "Seat Class: " & seatClass
        
        ' Display passenger name for reference
        lblPassengerName.Text = "Passenger: " & GetPassengerField(PASSENGER_NAME_INDEX)
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Navigate to Form4 (Meal Selection)
        Me.Hide()
        Form4.Show()
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form2
        Me.Hide()
        Form2.Show()
    End Sub
    
    Private Sub lstAirlinesDom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAirlinesDom.SelectedIndexChanged
        ' This control is not used in the data-driven version
        ' It's kept for design compatibility
    End Sub
End Class