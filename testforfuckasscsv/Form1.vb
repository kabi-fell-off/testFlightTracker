Public Class Form1
    ' Form1 handles flight code validation
    ' The user enters a flight code, which is validated against the CSV file
    ' If found, the passenger data is loaded into SharedPassengerData module
    ' If not found, an error is displayed and the user remains on this form
    
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        ' Retrieve the flight code entered by the user
        Dim enteredFlightCode As String = txtPNR.Text.Trim()
        
        ' Validate that the flight code is not empty
        If String.IsNullOrWhiteSpace(enteredFlightCode) Then
            MessageBox.Show("Please enter a flight code.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Search for the flight code in the CSV file
        ' This method reads the CSV, searches for the matching flight code, and stores the data
        If FindAndLoadPassengerData(enteredFlightCode) Then
            ' Flight code found: proceed to Form2
            ' Hide Form1 and show Form2
            Me.Hide()
            Form2.Show()
        Else
            ' Flight code not found: display error and remain on Form1
            MessageBox.Show("Flight code '" & enteredFlightCode & "' not found. Please check and try again.", "Flight Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Clear the text box for the next attempt
            txtPNR.Clear()
            txtPNR.Focus()
        End If
    End Sub
    
    Private Sub txtPNR_TextChanged(sender As Object, e As EventArgs) Handles txtPNR.TextChanged
        ' Optional: Convert input to uppercase for consistency
        If Not String.IsNullOrEmpty(txtPNR.Text) Then
            txtPNR.Text = txtPNR.Text.ToUpper()
            ' Move cursor to the end
            txtPNR.SelectionStart = txtPNR.Text.Length
        End If
    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear any previous passenger data when Form1 is loaded
        ClearPassengerData()
        ' Set focus to the text box
        txtPNR.Focus()
    End Sub
End Class