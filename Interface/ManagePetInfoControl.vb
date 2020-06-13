Imports System.ComponentModel

Public Class ManagePetInfoControl

    ' Sort the table
    Private Sub SortTable(columnName As String, direction As ListSortDirection)
        For Each column In DataGridViewPets.Columns
            If (column.Name = columnName) Then
                DataGridViewPets.Sort(column, direction)
            End If
        Next
    End Sub

    ' Go back to main menu
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        If (MessageBox.Show("Are you sure you want to go back? (you will lose any unsaved changes)", "Refresh Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            CType(ParentForm, MainForm).ShowMainMenu()
        End If
    End Sub

    ' If table is sorted, update buttons to reflect
    Private Sub DataGridViewPets_Sorted() Handles DataGridViewPets.Sorted
        ComboBoxSort.Text = DataGridViewPets.SortedColumn.Name
        If (DataGridViewPets.SortOrder = SortOrder.Ascending) Then
            ButtonAscendingDescending.Text = "Ascending"
        Else
            ButtonAscendingDescending.Text = "Descending"
        End If
    End Sub

    ' Toggle and sort
    Private Sub ButtonAscendingDescending_Click(sender As Object, e As EventArgs) Handles ButtonAscendingDescending.Click
        If ButtonAscendingDescending.Text = "Ascending" Then
            SortTable(ComboBoxSort.Text, ListSortDirection.Descending)
            ButtonAscendingDescending.Text = "Descending"
        Else
            SortTable(ComboBoxSort.Text, ListSortDirection.Ascending)
            ButtonAscendingDescending.Text = "Ascending"
        End If
    End Sub

    ' sort after change of selection
    Private Sub ComboBoxSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSort.SelectedIndexChanged
        If ButtonAscendingDescending.Text = "Ascending" Then
            SortTable(ComboBoxSort.Text, ListSortDirection.Ascending)
        Else
            SortTable(ComboBoxSort.Text, ListSortDirection.Descending)
        End If
    End Sub

    ' Load pet info control when it is made visible
    Private Sub ManagePetInfoControl_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then

            LoadData()

            ' Hide ID column
            DataGridViewPets.Columns("customerID").Visible = False
            ' Resize customer name column
            DataGridViewPets.Columns("Customer").Width = 200

            ' Lock editing of ID, species and customer name columns
            DataGridViewPets.Columns("ID").ReadOnly = True
            DataGridViewPets.Columns("Species").ReadOnly = True
            DataGridViewPets.Columns("Customer").ReadOnly = True

            ' Reset controls
            ButtonAscendingDescending.Text = "Ascending"
            ComboBoxSort.Items.Clear()
            ' Populate sorting box with each column
            For Each column In DataGridViewPets.Columns
                If (column.Visible) Then
                    ComboBoxSort.Items.Add(column.Name)
                End If
            Next
            ' Set to first one
            ComboBoxSort.Text = ComboBoxSort.Items(0)

            ' Sort by it
            SortTable(ComboBoxSort.Text, ListSortDirection.Ascending)

        End If
    End Sub

    ' Load data into the table
    Private Sub LoadData()
        ' Load the data
        PetInformationManager.loadDataSource()

        ' Populate Information Table

        DataGridViewPets.DataSource = PetInformationManager.dataSource

    End Sub

    ' Refresh data from database
    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        If (MessageBox.Show("Are you sure you want to refresh the database? (you will lose any unsaved changes)", "Refresh Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            LoadData()
        End If
    End Sub

    ' Sava data to database
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        PetInformationManager.saveData()
        MessageBox.Show("Information saved successfully", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Cancel data changes
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        If (MessageBox.Show("Are you sure you want to cancel the changes you have made?", "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            'LoadData()
            PetInformationManager.cancelChanges()
        End If
    End Sub

    ' Add a pet to the dataset
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        'add prompt
        DialogAddPet.Show()
    End Sub

    ' Delete pets from the dataset
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If (MessageBox.Show("Are you sure you want to delete the selected pet(s)?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            PetInformationManager.deletePet(DataGridViewPets, DataGridViewPets.SelectedCells)
        End If
    End Sub


    Private Sub DataGridViewPets_CellValidating(sender As DataGridView, e As DataGridViewCellValidatingEventArgs) Handles DataGridViewPets.CellValidating
        ' Check Name
        If (e.ColumnIndex = sender.Columns("Name").Index) Then
            If e.FormattedValue = "" Then
                MsgBox("Please enter a name.")
                e.Cancel = True
                sender.CancelEdit()
            End If
        End If
        ' Check Species
        If (e.ColumnIndex = sender.Columns("Species").Index) Then
            If e.FormattedValue = "" Then
                MsgBox("Please enter a species.")
                e.Cancel = True
                sender.CancelEdit()
            End If
        End If
        ' Check DOB
        If (e.ColumnIndex = sender.Columns("DOB").Index) Then
            If Not DateTime.TryParse(e.FormattedValue, New Date) Then
                MsgBox("Please specify a valid date.")
                e.Cancel = True
                sender.CancelEdit()
            End If
        End If
        ' Check Gender
        If (e.ColumnIndex = sender.Columns("Gender").Index) Then
            If Not (e.FormattedValue = "M" Or e.FormattedValue = "F" Or e.FormattedValue = "U") Then
                MsgBox("Please enter a valid gender.")
                e.Cancel = True
                sender.CancelEdit()
            End If
        End If
        ' Check Weight
        If (e.ColumnIndex = sender.Columns("Weight").Index) Then
            If Not Double.TryParse(e.FormattedValue, New Double) Then
                MsgBox("Please enter a valid weight.")
                e.Cancel = True
                sender.CancelEdit()
            End If
        End If

    End Sub
End Class
