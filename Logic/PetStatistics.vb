Public Class PetStatistics

    ' Data sources
    Friend Shared dataSource As DataTable
    Friend Shared dataSourceSpecies As DataTable

    ' Load statistics
    Friend Shared Sub loadStatistics()
        dataSource = DatabaseManager.getBoardStatistics()
    End Sub

    ' Load species statistics
    Friend Shared Sub loadSpeciesStatistics()
        dataSourceSpecies = DatabaseManager.getSpeciesStatistics()
        ' Create a primary key
        'dataSourceSpecies.PrimaryKey = {dataSourceSpecies.Columns("species")}
    End Sub

    ' Get a stat 
    Friend Shared Function getStat(stat As String) As String
        Return dataSource.Rows(0).Item(dataSource.Columns.IndexOf(dataSource.Columns(stat))).ToString()
    End Function

    ' Get a stat as a decimal
    Friend Shared Function getStatDecimal(stat As String) As Double
        Return Double.Parse(dataSource.Rows(0).Item(dataSource.Columns.IndexOf(dataSource.Columns(stat))).ToString())
    End Function

    ' Get a species stat
    Friend Shared Function getSpeciesStat(species As String, stat As String) As String
        'Dim x = dataSourceSpecies.Rows.Find(species)
        'Return x
        '.Item(dataSourceSpecies.Columns.IndexOf(dataSourceSpecies.Columns(stat))).ToString()
        For Each row In dataSourceSpecies.Rows
            If row("species") = species Then
                Return row(stat)
            End If
        Next
        Return ""
    End Function

    ' Get a species stat as a decimal
    Friend Shared Function getSpeciesStatDecimal(species As String, stat As String) As Double
        'Dim x = dataSourceSpecies.Rows.Find(species)
        'Return x
        '.Item(dataSourceSpecies.Columns.IndexOf(dataSourceSpecies.Columns(stat))).ToString()
        For Each row In dataSourceSpecies.Rows
            If row("species") = species Then
                Return Double.Parse(row(stat))
            End If
        Next
        Return 0
    End Function
End Class
