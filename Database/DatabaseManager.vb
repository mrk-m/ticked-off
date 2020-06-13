Imports MySql.Data.MySqlClient

Public Class DatabaseManager

    ' Database connection
    Shared connection As MySqlConnection
    Shared dataAdapter As MySqlDataAdapter

    ' Get board statistics
    Friend Shared Function getBoardStatistics() As DataTable
        Dim selectSQL As String = "SELECT MIN(DATEDIFF(stayEndDate, stayStartDate)) AS 'shortestStay', MAX(DATEDIFF(stayEndDate, stayStartDate)) AS 'longestStay', AVG(DATEDIFF(stayEndDate, stayStartDate)) AS 'averageStay', MIN(`stayCost`) AS 'lowestStayCost', MAX(`stayCost`) AS 'highestStayCost', AVG(`stayCost`) AS 'averageStayCost' FROM `stay`"
        Dim command As MySqlCommand = connection.CreateCommand()
        command.CommandText = selectSQL
        dataAdapter = New MySqlDataAdapter(command)
        Dim dataSet = New DataSet
        dataAdapter.Fill(dataSet, "x")

        Dim commandBuilder = New MySqlCommandBuilder(dataAdapter)

        Return dataSet.Tables("x")
    End Function

    ' Get species statistics
    Friend Shared Function getSpeciesStatistics() As DataTable
        Dim selectSQL As String = "SELECT `pet`.`species`, COUNT(`stay`.`stayCost`) AS 'totalStays', SUM(`stay`.`stayCost`) AS 'totalPaid' FROM `stay` LEFT JOIN `pet` ON `stay`.`petID`=`pet`.`petID` GROUP BY `pet`.`species`"
        Dim command As MySqlCommand = connection.CreateCommand()
        command.CommandText = selectSQL
        dataAdapter = New MySqlDataAdapter(command)
        Dim dataSet = New DataSet
        dataAdapter.Fill(dataSet, "x")

        Dim commandBuilder = New MySqlCommandBuilder(dataAdapter)

        Return dataSet.Tables("x")
    End Function

    ' connect to the database and setup adapters
    Shared Function Load() As Boolean
        ' Connect to the database, retry if fail, close if cancel

        While True
            Try
                connection = New MySqlConnection("server=localhost;userid=root;database=tickedoff")
                connection.Open()
                connection.Close()
                Return True
            Catch ex As Exception
                If MessageBox.Show("Unable to connect to the database!", "Database Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) = DialogResult.Cancel Then
                    Return False
                End If
            End Try
        End While
        Return True
    End Function

    ' get pet species
    Friend Shared Function getPetSpecies() As DataTable
        Dim query As New MySqlCommand("SELECT DISTINCT `species` FROM `pet`")
        query.Connection = connection
        Dim adapter As New MySqlDataAdapter(query)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table
    End Function

    ' get customers
    Friend Shared Function getCustomers() As DataTable
        Dim query As New MySqlCommand("SELECT `customerID`, CONCAT(`firstName`, ' ', `lastName`) AS 'customerName' FROM `customer`")
        query.Connection = connection
        Dim adapter As New MySqlDataAdapter(query)
        Dim table As New DataTable()
        adapter.Fill(table)

        Return table
    End Function

    ' get pet info
    Shared Function getPetInfo() As DataTable
        Dim selectSQL As String = "SELECT `pet`.*, CONCAT(`customer`.`lastName`, ', ',`customer`.`firstName`) As 'customerName' FROM `pet` LEFT JOIN `customer` ON `pet`.`customerID` = `customer`.`customerID`"
        Dim command As MySqlCommand = connection.CreateCommand()
        command.CommandText = selectSQL
        dataAdapter = New MySqlDataAdapter(command)
        Dim dataSet = New DataSet
        dataAdapter.Fill(dataSet, "x")

        Dim commandBuilder = New MySqlCommandBuilder(dataAdapter)

        Return dataSet.Tables("x")
    End Function

    ' update pet info
    Friend Shared Sub saveData(data As DataTable)
        Dim dataSource = data.Copy()
        'fix column names
        dataSource.Columns("ID").ColumnName = "petID"
        dataSource.Columns("Name").ColumnName = "petName"
        dataSource.Columns("Species").ColumnName = "species"
        dataSource.Columns("Breed").ColumnName = "breed"
        dataSource.Columns("DOB").ColumnName = "DOB"
        dataSource.Columns("Gender").ColumnName = "gender"
        dataSource.Columns("Weight").ColumnName = "weight"
        dataSource.Columns.Remove(dataSource.Columns("Customer"))


        Dim selectSQL As String = "SELECT * FROM `pet` "
        Dim command As MySqlCommand = connection.CreateCommand()
        command.CommandText = selectSQL
        Dim da = New MySqlDataAdapter(command)
        Dim ds = New DataSet
        da.Fill(ds, "Pet")

        Dim cb = New MySqlCommandBuilder(da)

        'update
        'da.UpdateCommand = cb.GetUpdateCommand()
        'da.InsertCommand = cb.GetInsertCommand()
        'da.DeleteCommand = cb.GetDeleteCommand()
        'Console.WriteLine(cb.GetUpdateCommand().CommandText)
        'Console.WriteLine(cb.GetInsertCommand().CommandText)
        'Console.WriteLine(cb.GetDeleteCommand().CommandText)

        da.UpdateCommand = New MySqlCommand("UPDATE `pet` Set `petName` = @p2, `species` = @p3, `breed` = @p4, `DOB` = @p5, `gender` = @p6, `weight` = @p7, `customerID` = @p8 WHERE `petID` = @p1")
        da.UpdateCommand.Parameters.Add("@p1", MySqlDbType.Int16, 11, "petID")
        da.UpdateCommand.Parameters.Add("@p2", MySqlDbType.VarChar, 80, "petName")
        da.UpdateCommand.Parameters.Add("@p3", MySqlDbType.VarChar, 50, "species")
        da.UpdateCommand.Parameters.Add("@p4", MySqlDbType.VarChar, 50, "breed")
        da.UpdateCommand.Parameters.Add("@p5", MySqlDbType.Date, 3, "DOB")
        da.UpdateCommand.Parameters.Add("@p6", MySqlDbType.VarChar, 1, "gender")
        da.UpdateCommand.Parameters.Add("@p7", MySqlDbType.Float, 8, "weight")
        da.UpdateCommand.Parameters.Add("@p8", MySqlDbType.Int16, 11, "customerID")


        da.InsertCommand = New MySqlCommand("INSERT INTO `pet` (`petID`, `petName`, `species`, `breed`, `DOB`, `gender`, `weight`, `customerID`) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)")
        da.InsertCommand.Parameters.Add("@p1", MySqlDbType.Int16, 11, "petID")
        da.InsertCommand.Parameters.Add("@p2", MySqlDbType.VarChar, 80, "petName")
        da.InsertCommand.Parameters.Add("@p3", MySqlDbType.VarChar, 50, "species")
        da.InsertCommand.Parameters.Add("@p4", MySqlDbType.VarChar, 50, "breed")
        da.InsertCommand.Parameters.Add("@p5", MySqlDbType.Date, 3, "DOB")
        da.InsertCommand.Parameters.Add("@p6", MySqlDbType.VarChar, 1, "gender")
        da.InsertCommand.Parameters.Add("@p7", MySqlDbType.Float, 8, "weight")
        da.InsertCommand.Parameters.Add("@p8", MySqlDbType.Int16, 11, "customerID")

        da.DeleteCommand = New MySqlCommand("DELETE FROM `pet` WHERE `petID` = @p1")
        da.DeleteCommand.Parameters.Add("@p1", MySqlDbType.Int16, 11, "petID")

        Try
            da.Update(dataSource)
        Catch ex As Exception
            MessageBox.Show("Unable to complete saving. One or more deletions can not be completed due to the pet having a booking", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dataSource.AcceptChanges()

    End Sub
End Class
