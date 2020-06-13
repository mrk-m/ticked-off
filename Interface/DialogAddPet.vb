Imports System.Windows.Forms

Public Class DialogAddPet

    ' Add a pet if the data is valid
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Button.Click
        If dataIsValid() Then

            ' Add a pet
            PetInformationManager.addPet(TextBoxName.Text, ComboBoxSpecies.Text, DateTimePickerDOB.Value, ComboBoxGender.Text, TextBoxWeight.Text, ComboBoxCustomer.SelectedValue, ComboBoxCustomer.Text)

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    ' Validate the form data
    Private Function dataIsValid() As Object
        If (TextBoxName.Text = "") Then
            MessageBox.Show("Please enter a pet name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (ComboBoxSpecies.Text = "") Then
            MessageBox.Show("Please select a pet species", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (ComboBoxGender.Text = "") Then
            MessageBox.Show("Please select a pet gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Decimal.TryParse(TextBoxWeight.Text, New Decimal) Then
            MessageBox.Show("Please enter a valid weight", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf (ComboBoxCustomer.Text = "") Then
            MessageBox.Show("Please select a customer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ' Cancel adding a pet
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ' Populate and set constraints on the form loadings
    Private Sub DialogAddPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set max date to now
        DateTimePickerDOB.MaxDate = Date.Now

        ' populate species the drop box
        ComboBoxSpecies.DataSource = PetInformationManager.GetPetSpecies()
        ComboBoxSpecies.DisplayMember = "species"
        ComboBoxSpecies.Text = ""

        ' populate customers the drop box
        ComboBoxCustomer.DataSource = PetInformationManager.getCustomers()
        ComboBoxCustomer.DisplayMember = "customerName"
        ComboBoxCustomer.ValueMember = "customerID"
        ComboBoxCustomer.Text = ""

    End Sub
End Class
