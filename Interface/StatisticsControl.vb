Public Class StatisticsControl

    ' Go back to the main menu when back is pressed
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        CType(ParentForm, MainForm).ShowMainMenu()
    End Sub

    ' Load control when it is made visible
    Private Sub StatisticsControl_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            ' Load statistics
            PetStatistics.loadStatistics()

            ' Show statistics
            LabelShortestStayOutput.Text = PetStatistics.getStat("shortestStay") + " days"
            LabelLongestStayOutput.Text = PetStatistics.getStat("longestStay") + " days"
            LabelAverageStayOutput.Text = Math.Round(PetStatistics.getStatDecimal("averageStay"), 2).ToString() + " days"

            LabelLowestBoardingCostOutput.Text = "$" + PetStatistics.getStatDecimal("lowestStayCost").ToString("0.00")
            LabelHighestBoardingCostOutput.Text = "$" + PetStatistics.getStatDecimal("highestStayCost").ToString("0.00")
            LabelAverageBoardingCostOutput.Text = "$" + PetStatistics.getStatDecimal("averageStayCost").ToString("0.00")

            ' Load species stats
            PetStatistics.loadSpeciesStatistics()

            ' Populate species drop box
            ComboBoxSpecies.DataSource = PetStatistics.dataSourceSpecies
            ComboBoxSpecies.DisplayMember = "species"

        End If
    End Sub

    ' Display data on calculate button press
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        LabelNumberOfStaysOutput.Text = PetStatistics.getSpeciesStat(ComboBoxSpecies.Text, "totalStays") + " days"
        LabelTotalAmountPaidOutput.Text = "$" + PetStatistics.getSpeciesStatDecimal(ComboBoxSpecies.Text, "totalPaid").ToString("0.00")
    End Sub

    ' Calculate on dropbox change
    'Private Sub ComboBoxSpecies_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBoxSpecies.SelectedValueChanged
    '    LabelNumberOfStaysOutput.Text = PetStatistics.getSpeciesStat(ComboBoxSpecies.Text, "totalStays") + " days"
    '    LabelTotalAmountPaidOutput.Text = "$" + PetStatistics.getSpeciesStatDecimal(ComboBoxSpecies.Text, "totalPaid").ToString("0.00")
    'End Sub


End Class
