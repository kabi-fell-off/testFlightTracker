' SharedPassengerData.vb
' This module stores the passenger data read from Flights.csv
' All forms access this shared data instead of re-reading the CSV file

Module SharedPassengerData
    ' Array to store the current passenger's flight data
    ' Index 0: FlightCode, 1: PassengerName, 2: FlightType, 3: Airline, 4: Origin, 5: Destination
    ' Index 6: FlightDate, 7: Terminal, 8: Gate, 9: BoardingTime, 10: DepartureTime
    ' Index 11: ArrivalTime, 12: Duration, 13: SeatClass, 14: SeatNumber, 15: Meal
    ' Index 16: UpgradeAvailable, 17: Weather
    Public PassengerData() As String = Nothing
    
    ' Path to the CSV file - uses application's running directory
    Public ReadOnly CSV_FILE_PATH As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Flights.csv")
    
    ' CSV Header indices (for reference and validation)
    Public Const FLIGHT_CODE_INDEX As Integer = 0
    Public Const PASSENGER_NAME_INDEX As Integer = 1
    Public Const FLIGHT_TYPE_INDEX As Integer = 2
    Public Const AIRLINE_INDEX As Integer = 3
    Public Const ORIGIN_INDEX As Integer = 4
    Public Const DESTINATION_INDEX As Integer = 5
    Public Const FLIGHT_DATE_INDEX As Integer = 6
    Public Const TERMINAL_INDEX As Integer = 7
    Public Const GATE_INDEX As Integer = 8
    Public Const BOARDING_TIME_INDEX As Integer = 9
    Public Const DEPARTURE_TIME_INDEX As Integer = 10
    Public Const ARRIVAL_TIME_INDEX As Integer = 11
    Public Const DURATION_INDEX As Integer = 12
    Public Const SEAT_CLASS_INDEX As Integer = 13
    Public Const SEAT_NUMBER_INDEX As Integer = 14
    Public Const MEAL_INDEX As Integer = 15
    Public Const UPGRADE_AVAILABLE_INDEX As Integer = 16
    Public Const WEATHER_INDEX As Integer = 17
    
    ''' <summary>
    ''' Searches the CSV file for a matching flight code and loads the passenger data
    ''' </summary>
    ''' <param name="flightCodeToFind">The flight code entered by the user</param>
    ''' <returns>True if the flight code is found; otherwise False</returns>
    Public Function FindAndLoadPassengerData(flightCodeToFind As String) As Boolean
        Try
            ' Check if the CSV file exists
            If Not System.IO.File.Exists(CSV_FILE_PATH) Then
                MessageBox.Show("Error: Flights.csv file not found at: " & CSV_FILE_PATH & vbCrLf & vbCrLf & "Please ensure Flights.csv is in the application directory.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            
            ' Read all lines from the CSV file
            Dim allLines() As String = System.IO.File.ReadAllLines(CSV_FILE_PATH)
            
            ' Ensure there is at least a header row
            If allLines.Length < 2 Then
                MessageBox.Show("Error: Flights.csv is empty or contains only headers.", "Invalid CSV", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            
            ' Skip the header row (index 0) and search the remaining rows
            For i As Integer = 1 To allLines.Length - 1
                ' Split the line by comma to extract individual fields
                Dim fields() As String = allLines(i).Split(New Char() {","c}, StringSplitOptions.None)
                
                ' Trim whitespace from the flight code field
                Dim csvFlightCode As String = fields(FLIGHT_CODE_INDEX).Trim()
                
                ' Compare the CSV flight code with the input (case-insensitive)
                If String.Equals(csvFlightCode, flightCodeToFind, StringComparison.OrdinalIgnoreCase) Then
                    ' Match found: store the entire row in PassengerData
                    PassengerData = fields
                    Return True
                End If
            Next
            
            ' No matching flight code found
            Return False
            
        Catch ex As Exception
            MessageBox.Show("Error reading Flights.csv: " & ex.Message, "File Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Safely retrieves a value from PassengerData at the specified index
    ''' </summary>
    ''' <param name="index">The index of the field to retrieve</param>
    ''' <returns>The field value or an empty string if the index is out of range</returns>
    Public Function GetPassengerField(index As Integer) As String
        If PassengerData IsNot Nothing AndAlso index >= 0 AndAlso index < PassengerData.Length Then
            Return PassengerData(index).Trim()
        End If
        Return ""
    End Function
    
    ''' <summary>
    ''' Clears the stored passenger data (typically called when exiting the application)
    ''' </summary>
    Public Sub ClearPassengerData()
        PassengerData = Nothing
    End Sub
End Module
