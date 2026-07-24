Public Class Form5
    ' Form5 generates and displays a digital boarding pass
    ' All information is retrieved from the shared PassengerData (CSV)
    ' The boarding pass displays: PassengerName, Airline, FlightCode, Destination, 
    ' Terminal, Gate, BoardingTime, SeatNumber
    
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generate the boarding pass using data from the shared PassengerData
        GenerateBoardingPass()
    End Sub
    
    ''' <summary>
    ''' Generates a formatted boarding pass string using CSV data
    ''' </summary>
    Private Sub GenerateBoardingPass()
        ' Retrieve all relevant fields from the shared passenger data
        Dim passengerName As String = GetPassengerField(PASSENGER_NAME_INDEX)
        Dim airline As String = GetPassengerField(AIRLINE_INDEX)
        Dim flightCode As String = GetPassengerField(FLIGHT_CODE_INDEX)
        Dim destination As String = GetPassengerField(DESTINATION_INDEX)
        Dim terminal As String = GetPassengerField(TERMINAL_INDEX)
        Dim gate As String = GetPassengerField(GATE_INDEX)
        Dim boardingTime As String = GetPassengerField(BOARDING_TIME_INDEX)
        Dim seatNumber As String = GetPassengerField(SEAT_NUMBER_INDEX)
        
        ' Format the boarding pass as a structured text
        Dim boardingPassText As String = ""
        boardingPassText &= "════════════════════════════════════" & vbCrLf
        boardingPassText &= "        DIGITAL BOARDING PASS        " & vbCrLf
        boardingPassText &= "════════════════════════════════════" & vbCrLf
        boardingPassText &= vbCrLf
        boardingPassText &= "Passenger Name: " & passengerName & vbCrLf
        boardingPassText &= "Airline: " & airline & vbCrLf
        boardingPassText &= "Flight Code: " & flightCode & vbCrLf
        boardingPassText &= "Destination: " & destination & vbCrLf
        boardingPassText &= vbCrLf
        boardingPassText &= "Terminal: " & terminal & vbCrLf
        boardingPassText &= "Gate: " & gate & vbCrLf
        boardingPassText &= "Boarding Time: " & boardingTime & vbCrLf
        boardingPassText &= "Seat Number: " & seatNumber & vbCrLf
        boardingPassText &= vbCrLf
        boardingPassText &= "════════════════════════════════════" & vbCrLf
        boardingPassText &= "      Have a great flight!          " & vbCrLf
        boardingPassText &= "════════════════════════════════════" & vbCrLf
        
        ' Display the boarding pass in the text box
        txtBookedFlight.Text = boardingPassText
        ' Make the text box read-only so the user cannot edit it
        txtBookedFlight.ReadOnly = True
    End Sub
    
    Private Sub btnConfirmFlight_Click(sender As Object, e As EventArgs) Handles btnConfirmFlight.Click
        ' Show a confirmation message
        MessageBox.Show("Your boarding pass has been confirmed. Have a great flight!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ' Clear the passenger data and return to Form1
        ClearPassengerData()
        Me.Hide()
        Form1.Show()
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form4
        Me.Hide()
        Form4.Show()
    End Sub
    
    Private Sub txtBookedFlight_TextChanged(sender As Object, e As EventArgs) Handles txtBookedFlight.TextChanged
        ' This event is handled automatically; no action needed
    End Sub
End Class
