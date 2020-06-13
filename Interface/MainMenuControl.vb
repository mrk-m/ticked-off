Public Class MainMenuControl
    Private Sub MainMenuControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonManagePetInformation_Click(sender As Object, e As EventArgs) Handles ButtonManagePetInformation.Click
        CType(ParentForm, MainForm).ShowManagePetInformation()
    End Sub

    Private Sub ButtonStatistics_Click(sender As Object, e As EventArgs) Handles ButtonStatistics.Click
        CType(ParentForm, MainForm).ShowStatistics()
    End Sub

    Private Sub ButtonBoardingCostCalculator_Click(sender As Object, e As EventArgs) Handles ButtonBoardingCostCalculator.Click
        CType(ParentForm, MainForm).ShowBoardCostCalculator()
    End Sub

    Private Sub ButtonQuickExport_Click(sender As Object, e As EventArgs) Handles ButtonQuickExport.Click
        Dim saveDialog As New SaveFileDialog
        saveDialog.Filter = "CSV (comma delimeted)|*.csv"
        saveDialog.Title = "Save exported pet information"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            DataExporter.exportData(saveDialog.FileName)
        End If
    End Sub
End Class
