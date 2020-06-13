Imports System.IO
Imports System.Text

Public Class DataExporter

    ' Export data
    Friend Shared Sub exportData(fileName As String)
        ' Load data
        PetInformationManager.loadDataSource()
        PetInformationManager.dataSource.Columns.Remove("customerID")
        PetInformationManager.dataSource.Columns("Customer").ColumnName = "Customer Last Name"

        ' String builder
        Dim builder As New StringBuilder

        ' Column Names
        For Each column In PetInformationManager.dataSource.Columns
            builder.Append(column.ToString + ", ")
        Next
        builder.AppendLine("Customer First Name,")

        ' Rows
        For Each row In PetInformationManager.dataSource.Rows
            For Each item In row.ItemArray
                builder.Append(item.ToString + ", ")
            Next
            builder.AppendLine()
        Next

        ' Write to file
        File.WriteAllText(fileName, builder.ToString())
        'Console.WriteLine(fileName + ": " + builder.ToString)
    End Sub

End Class
