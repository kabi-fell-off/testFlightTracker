Public Class Form4
    ' Form4 displays meal information and enables/disables upgrade options
    ' based on the UpgradeAvailable value from the CSV (without any hard-coded conditions)
    
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Retrieve meal information from the shared passenger data
        Dim selectedMeal As String = GetPassengerField(MEAL_INDEX)
        
        ' Display the selected meal
        lblMeal.Text = "Selected Meal: " & selectedMeal
        
        ' Retrieve the upgrade availability status from CSV
        Dim upgradeAvailable As String = GetPassengerField(UPGRADE_AVAILABLE_INDEX)
        
        ' Display passenger name for reference
        lblPassengerName.Text = "Passenger: " & GetPassengerField(PASSENGER_NAME_INDEX)
        
        ' Enable or disable the Business Upgrade radio button based on CSV value
        ' The value is compared as-is from the CSV (case-insensitive)
        If String.Equals(upgradeAvailable, "Yes", StringComparison.OrdinalIgnoreCase) Then
            ' Upgrade is available: enable the radio button
            radBusinessUpgrade.Enabled = True
            radBusinessUpgrade.Text = "Business Class Upgrade (Available)"
        Else
            ' Upgrade is not available: disable the radio button
            radBusinessUpgrade.Enabled = False
            radBusinessUpgrade.Text = "Business Class Upgrade (Not Available)"
        End If
    End Sub
    
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Navigate to Form5 (Boarding Pass)
        Me.Hide()
        Form5.Show()
    End Sub
    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Return to Form3
        Me.Hide()
        Form3.Show()
    End Sub
    
    Private Sub lstAirlineInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAirlineInt.SelectedIndexChanged
        ' This control is not used in the data-driven version
        ' It's kept for design compatibility
    End Sub
End Class