Imports System.Data.SqlClient

Public Class MainForm

    ' Main menu
    Private controlMainMenu As MainMenuControl
    ' Manage Pet Information
    Private controlManagePetInfo As ManagePetInfoControl
    ' Board Cost Calculator
    Private controlBoardCostCalculator As BoardCostCalculatorControl
    ' Statistics
    Private controlStatistics As StatisticsControl

    ' Load the form and panels
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to the database
        If Not DatabaseManager.Load() Then
            Close()
        End If

        ' Create controls
        controlMainMenu = New MainMenuControl
        controlManagePetInfo = New ManagePetInfoControl
        controlBoardCostCalculator = New BoardCostCalculatorControl
        controlStatistics = New StatisticsControl

        ' Add the controls to the form
        Controls.Add(controlMainMenu)
        Controls.Add(controlManagePetInfo)
        Controls.Add(controlBoardCostCalculator)
        Controls.Add(controlStatistics)

        ' Set main menu
        ShowMainMenu()
    End Sub

    ' Hide all views
    Private Sub HideViews()
        controlMainMenu.Visible = False
        controlManagePetInfo.Visible = False
        controlBoardCostCalculator.Visible = False
        controlStatistics.Visible = False
    End Sub

    ' Show main menu
    Public Sub ShowMainMenu()
        HideViews()
        controlMainMenu.Visible = True
    End Sub

    ' Show manage pet information
    Public Sub ShowManagePetInformation()
        HideViews()
        controlManagePetInfo.Visible = True
    End Sub

    ' Show board cost calculator
    Public Sub ShowBoardCostCalculator()
        HideViews()
        controlBoardCostCalculator.Visible = True
    End Sub

    ' Show statistics
    Public Sub ShowStatistics()
        HideViews()
        controlStatistics.Visible = True
    End Sub

    ' Exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    ' Show about company
    Private Sub AboutThisCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisCompanyToolStripMenuItem.Click
        AboutCompanyDialog.Show()
    End Sub

    ' Show about application
    Private Sub AboutThisApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisApplicationToolStripMenuItem.Click
        AboutApplicationDialog.ShowDialog()
    End Sub

End Class