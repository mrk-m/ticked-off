Public Class BoardCostCalculatorControl


    ' Go back to main menu
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        CType(ParentForm, MainForm).ShowMainMenu()
    End Sub

    ' Load when visible
    Private Sub BoardCostCalculatorControl_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            ' Populate drop down list
            ComboBoxSpecies.DataSource = PetInformationManager.getPetSpecies()
            ComboBoxSpecies.DisplayMember = "species"
            ComboBoxSpecies.Text = ""
        End If
    End Sub

    ' Validate and calculate
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        If (BoardCostCalculator.validateData(TextBoxWeight.Text, TextBoxLength.Text)) Then
            LabelCostOutput.Text = "$" + BoardCostCalculator.calculateCost(ComboBoxSpecies.Text, TextBoxWeight.Text, TextBoxLength.Text).ToString("0.00")
        End If
    End Sub
End Class
