Public Class Form2
    ' Form2 displays passenger flight information retrieved from the shared CSV data
    ' This form shows: PassengerName, Airline, FlightType, Origin, Destination, 
    ' FlightDate, BoardingTime, DepartureTime, ArrivalTime, Duration, Terminal, Gate, Weather
    
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate all controls with data from the shared PassengerData
        ' Each field is retrieved using the constant index defined in SharedPassengerData module
        
        ' Display passenger name
        lblPassengerName.Text = "Passenger: " & GetPassengerField(PASSENGER_NAME_INDEX)
        
        ' Display airline information
        lblAirline.Text = "Airline: " & GetPassengerField(AIRLINE_INDEX)
        
        ' Display flight type (e.g., Domestic, International)
        lblFlightType.Text = "Flight Type: " & GetPassengerField(FLIGHT_TYPE_INDEX)
        
        ' Display origin city
        lblOrigin.Text = "From: " & GetPassengerField(ORIGIN_INDEX)
        
        ' Display destination city
        lblDestination.Text = "To: " & GetPassengerField(DESTINATION_INDEX)
        
        ' Display flight date
        lblFlightDate.Text = "Date: " & GetPassengerField(FLIGHT_DATE_INDEX)
        
        ' Display boarding time
        lblBoardingTime.Text = "Boarding: " & GetPassengerField(BOARDING_TIME_INDEX)
        
        ' Display departure time
        lblDepartureTime.Text = "Departure: " & GetPassengerField(DEPARTURE_TIME_INDEX)
        
        ' Display arrival time
        lblArrivalTime.Text = "Arrival: " & GetPassengerField(ARRIVAL_TIME_INDEX)
        
        ' Display flight duration
        lblDuration.Text = "Duration: " & GetPassengerField(DURATION_INDEX)
        
        ' Display terminal
        lblTerminal.Text = "Terminal: " & GetPassengerField(TERMINAL_INDEX)
        
        ' Display gate
        lblGate.Text = "Gate: " & GetPassengerField(GATE_INDEX)
        
        ' Display weather information
        lblWeather.Text = "Weather: " & GetPassengerField(WEATHER_INDEX)
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Navigate to Form3 (Seat Selection)
        Me.Hide()
        Form3.Show()
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form1
        Me.Hide()
        Form1.Show()
    End Sub
    
    Private Sub radDomestic_CheckedChanged(sender As Object, e As EventArgs) Handles radDomestic.CheckedChanged
        ' This control is not used in the data-driven version
        ' It's kept for design compatibility
    End Sub
End Class