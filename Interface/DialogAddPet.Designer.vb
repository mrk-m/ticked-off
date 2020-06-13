<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogAddPet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelSpecies = New System.Windows.Forms.Label()
        Me.ComboBoxSpecies = New System.Windows.Forms.ComboBox()
        Me.LabelDateOfBirth = New System.Windows.Forms.Label()
        Me.DateTimePickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.LabelWeight = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.TextBoxWeight = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Add_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(158, 202)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Add_Button
        '
        Me.Add_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Add_Button.Location = New System.Drawing.Point(4, 4)
        Me.Add_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(89, 28)
        Me.Add_Button.TabIndex = 0
        Me.Add_Button.Text = "Add"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelName.Location = New System.Drawing.Point(48, 15)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelName.Size = New System.Drawing.Size(55, 16)
        Me.LabelName.TabIndex = 1
        Me.LabelName.Text = ":Name"
        '
        'LabelSpecies
        '
        Me.LabelSpecies.AutoSize = True
        Me.LabelSpecies.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelSpecies.Location = New System.Drawing.Point(34, 45)
        Me.LabelSpecies.Name = "LabelSpecies"
        Me.LabelSpecies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelSpecies.Size = New System.Drawing.Size(69, 16)
        Me.LabelSpecies.TabIndex = 3
        Me.LabelSpecies.Text = ":Species"
        '
        'ComboBoxSpecies
        '
        Me.ComboBoxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxSpecies.FormattingEnabled = True
        Me.ComboBoxSpecies.Location = New System.Drawing.Point(109, 42)
        Me.ComboBoxSpecies.Name = "ComboBoxSpecies"
        Me.ComboBoxSpecies.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxSpecies.TabIndex = 4
        '
        'LabelDateOfBirth
        '
        Me.LabelDateOfBirth.AutoSize = True
        Me.LabelDateOfBirth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelDateOfBirth.Location = New System.Drawing.Point(59, 78)
        Me.LabelDateOfBirth.Name = "LabelDateOfBirth"
        Me.LabelDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelDateOfBirth.Size = New System.Drawing.Size(44, 16)
        Me.LabelDateOfBirth.TabIndex = 5
        Me.LabelDateOfBirth.Text = ":DOB"
        '
        'DateTimePickerDOB
        '
        Me.DateTimePickerDOB.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.DateTimePickerDOB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.DateTimePickerDOB.Location = New System.Drawing.Point(109, 72)
        Me.DateTimePickerDOB.MaxDate = New Date(2019, 6, 25, 0, 0, 0, 0)
        Me.DateTimePickerDOB.Name = "DateTimePickerDOB"
        Me.DateTimePickerDOB.Size = New System.Drawing.Size(239, 24)
        Me.DateTimePickerDOB.TabIndex = 6
        Me.DateTimePickerDOB.Value = New Date(2019, 6, 25, 0, 0, 0, 0)
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelGender.Location = New System.Drawing.Point(38, 105)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelGender.Size = New System.Drawing.Size(65, 16)
        Me.LabelGender.TabIndex = 7
        Me.LabelGender.Text = ":Gender"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"M", "F", "U"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(109, 102)
        Me.ComboBoxGender.MaxLength = 1
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxGender.TabIndex = 8
        '
        'LabelWeight
        '
        Me.LabelWeight.AutoSize = True
        Me.LabelWeight.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelWeight.Location = New System.Drawing.Point(39, 135)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelWeight.Size = New System.Drawing.Size(64, 16)
        Me.LabelWeight.TabIndex = 9
        Me.LabelWeight.Text = ":Weight"
        '
        'TextBoxName
        '
        Me.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TextBoxName.Location = New System.Drawing.Point(109, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(239, 24)
        Me.TextBoxName.TabIndex = 2
        '
        'LabelCustomer
        '
        Me.LabelCustomer.AutoSize = True
        Me.LabelCustomer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelCustomer.Location = New System.Drawing.Point(19, 165)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelCustomer.Size = New System.Drawing.Size(84, 16)
        Me.LabelCustomer.TabIndex = 11
        Me.LabelCustomer.Text = ":Customer"
        '
        'ComboBoxCustomer
        '
        Me.ComboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxCustomer.FormattingEnabled = True
        Me.ComboBoxCustomer.Location = New System.Drawing.Point(109, 162)
        Me.ComboBoxCustomer.Name = "ComboBoxCustomer"
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(239, 24)
        Me.ComboBoxCustomer.TabIndex = 12
        '
        'TextBoxWeight
        '
        Me.TextBoxWeight.Location = New System.Drawing.Point(109, 132)
        Me.TextBoxWeight.Name = "TextBoxWeight"
        Me.TextBoxWeight.Size = New System.Drawing.Size(239, 24)
        Me.TextBoxWeight.TabIndex = 13
        '
        'DialogAddPet
        '
        Me.AcceptButton = Me.Add_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(369, 253)
        Me.Controls.Add(Me.TextBoxWeight)
        Me.Controls.Add(Me.ComboBoxCustomer)
        Me.Controls.Add(Me.LabelCustomer)
        Me.Controls.Add(Me.LabelWeight)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.DateTimePickerDOB)
        Me.Controls.Add(Me.LabelDateOfBirth)
        Me.Controls.Add(Me.ComboBoxSpecies)
        Me.Controls.Add(Me.LabelSpecies)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogAddPet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add a pet"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Add_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelSpecies As Label
    Friend WithEvents ComboBoxSpecies As ComboBox
    Friend WithEvents LabelDateOfBirth As Label
    Friend WithEvents DateTimePickerDOB As DateTimePicker
    Friend WithEvents LabelGender As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents LabelWeight As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents LabelCustomer As Label
    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents TextBoxWeight As TextBox
End Class
