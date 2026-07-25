Public Class Form4
    ' Form4: Flight Details Verification
    ' Displays and verifies: Departure Time, Arrival Time, Gate, Terminal, Airline
    ' All data read from CSV and validated
    
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear listbox and populate with flight details
        lstAirlineInt.Items.Clear()
        
        ' Add flight details to listbox
        lstAirlineInt.Items.Add("Airline: " & GetPassengerField(AIRLINE_INDEX))
        lstAirlineInt.Items.Add("Departure: " & GetPassengerField(DEPARTURE_TIME_INDEX))
        lstAirlineInt.Items.Add("Arrival: " & GetPassengerField(ARRIVAL_TIME_INDEX))
        lstAirlineInt.Items.Add("Gate: " & GetPassengerField(GATE_INDEX))
        lstAirlineInt.Items.Add("Terminal: " & GetPassengerField(TERMINAL_INDEX))
    End Sub
    
    Private Sub lstAirlineInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAirlineInt.SelectedIndexChanged
        ' Clear any previous warning when selection changes
        lblAirlineWarning.Text = ""
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Validate that user confirms the flight details
        ' In this context, the "selection" is confirmation of all details
        
        ' Verify that the passenger data is properly loaded
        If PassengerData Is Nothing Then
            lblAirlineWarning.Text = "Error: Flight data not loaded. Please return and re-enter your flight code."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        ' Verify critical fields exist and are not empty
        If String.IsNullOrWhiteSpace(GetPassengerField(AIRLINE_INDEX)) Then
            lblAirlineWarning.Text = "Error: Airline information is missing from our system."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        If String.IsNullOrWhiteSpace(GetPassengerField(DEPARTURE_TIME_INDEX)) Then
            lblAirlineWarning.Text = "Error: Departure time is missing from our system."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        If String.IsNullOrWhiteSpace(GetPassengerField(ARRIVAL_TIME_INDEX)) Then
            lblAirlineWarning.Text = "Error: Arrival time is missing from our system."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        If String.IsNullOrWhiteSpace(GetPassengerField(GATE_INDEX)) Then
            lblAirlineWarning.Text = "Error: Gate information is missing from our system."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        If String.IsNullOrWhiteSpace(GetPassengerField(TERMINAL_INDEX)) Then
            lblAirlineWarning.Text = "Error: Terminal information is missing from our system."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        ' All validations passed: proceed to Form5
        Me.Hide()
        Form5.Show()
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form3
        Me.Hide()
        Form3.Show()
    End Sub
End Class