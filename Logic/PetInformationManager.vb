Imports MySql.Data.MySqlClient

Public Class PetInformationManager
    ' data source
    Friend Shared dataSource As DataTable
    ' last id of the pets
    Friend Shared lastID As Integer

    ' load data
    Public Shared Function loadDataSource() As DataTable
        ' get pet info from db
        dataSource = DatabaseManager.getPetInfo()

        ' set primary key
        dataSource.PrimaryKey = {dataSource.Columns("petID")}

        ' rename columns 
        dataSource.Columns("petID").ColumnName = "ID"
        dataSource.Columns("petName").ColumnName = "Name"
        dataSource.Columns("species").ColumnName = "Species"
        dataSource.Columns("breed").ColumnName = "Breed"
        dataSource.Columns("DOB").ColumnName = "DOB"
        dataSource.Columns("gender").ColumnName = "Gender"
        dataSource.Columns("weight").ColumnName = "Weight"
        dataSource.Columns("customerName").ColumnName = "Customer"

        ' find highest id
        For Each row As DataRow In dataSource.Rows
            If row("ID") > lastID Then
                lastID = row("ID")
            End If
        Next row

        Return dataSource
    End Function

    ' Add a pet
    Friend Shared Sub addPet(petName As String, species As String, dob As Date, gender As String, weight As String, customerID As String, customerName As String)
        dataSource.Rows.Add(getNextID(), petName, species, "", dob, gender, Double.Parse(weight), Integer.Parse(customerID), customerName)
    End Sub

    ' Delete pet(s)
    Friend Shared Sub deletePet(view As DataGridView, selectedRows As DataGridViewSelectedCellCollection)

        For Each cell As DataGridViewCell In selectedRows

            ' remove dupe rows (cant delete a pet twice)
            For Each cellRowDupe As DataGridViewCell In selectedRows
                If cell.RowIndex = cellRowDupe.RowIndex Then
                    cellRowDupe.Dispose()
                End If
            Next

            ' delete pet
            If (cell.Selected) Then
                dataSource.Rows.Find(view.Rows.Item(cell.RowIndex).Cells(0).Value).Delete()
            End If


        Next
    End Sub

    ' Get next id for aadding a pet, increment
    Private Shared Function getNextID() As Integer
        lastID += 1
        Return lastID
    End Function

    ' Get species
    Friend Shared Function getPetSpecies() As DataTable
        Return DatabaseManager.getPetSpecies()
    End Function

    ' Get customers
    Friend Shared Function getCustomers() As DataTable
        Return DatabaseManager.getCustomers()
    End Function

    ' Save dataset to database
    Friend Shared Sub saveData()
        DatabaseManager.saveData(dataSource)
    End Sub

    ' Cancel dataset changes
    Friend Shared Sub cancelChanges()
        dataSource.RejectChanges()
    End Sub
End Class
