Public Class Form1
    ' Form1: Flight Code Entry & Validation
    ' User enters a flight code which is validated against the CSV file
    ' If match found: load passenger data and open Form2
    ' If not found: display specific error and stay on Form1
    
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim enteredFlightCode As String = txtPNR.Text.Trim()
        
        ' Validate that flight code is not empty
        If String.IsNullOrWhiteSpace(enteredFlightCode) Then
            MessageBox.Show("Flight code cannot be empty. Please enter a valid flight code.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Search CSV for matching flight code
        If FindAndLoadPassengerData(enteredFlightCode) Then
            ' Flight code found: proceed to Form2
            Me.Hide()
            Form2.Show()
        Else
            ' Flight code not found: display error
            MessageBox.Show("Flight code '" & enteredFlightCode & "' does not exist in our system. Please verify and try again.", "Invalid Flight Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPNR.Clear()
            txtPNR.Focus()
        End If
    End Sub
    
    Private Sub txtPNR_TextChanged(sender As Object, e As EventArgs) Handles txtPNR.TextChanged
        ' Convert input to uppercase for consistency with CSV
        If Not String.IsNullOrEmpty(txtPNR.Text) Then
            txtPNR.Text = txtPNR.Text.ToUpper()
            txtPNR.SelectionStart = txtPNR.Text.Length
        End If
    End Sub
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Clear any previous session data
        ClearPassengerData()
        txtPNR.Focus()
    End Sub
End Class