Public Class Form3
    ' Form3: Airline Selection
    ' Populates listbox with airlines from CSV matching the flight type
    ' Validates selected airline against CSV Airline field
    
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate airline listbox with CSV data for this flight type
        lstAirlinesDom.Items.Clear()
        lstAirlinesDom.Items.Add(GetPassengerField(AIRLINE_INDEX))
    End Sub
    
    Private Sub lstAirlinesDom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAirlinesDom.SelectedIndexChanged
        ' Clear any previous warning when selection changes
        lblAirlineWarning.Text = ""
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Validate that an airline was selected
        If lstAirlinesDom.SelectedIndex = -1 Then
            lblAirlineWarning.Text = "Please select an airline from the list."
            lblAirlineWarning.ForeColor = Color.Red
            Return
        End If
        
        ' Get selected airline
        Dim selectedAirline As String = lstAirlinesDom.SelectedItem.ToString()
        
        ' Validate selected airline against CSV
        If String.Equals(selectedAirline, GetPassengerField(AIRLINE_INDEX), StringComparison.OrdinalIgnoreCase) Then
            ' Airline matches CSV: proceed to Form4
            Me.Hide()
            Form4.Show()
        Else
            ' Airline mismatch with CSV
            lblAirlineWarning.Text = "Selected airline '" & selectedAirline & "' does not match the airline in our system: '" & GetPassengerField(AIRLINE_INDEX) & "'. Please reselect."
            lblAirlineWarning.ForeColor = Color.Red
        End If
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form2
        Me.Hide()
        Form2.Show()
    End Sub
End Class