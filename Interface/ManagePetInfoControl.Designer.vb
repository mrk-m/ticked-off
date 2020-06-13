<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagePetInfoControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelSort = New System.Windows.Forms.Label()
        Me.ComboBoxSort = New System.Windows.Forms.ComboBox()
        Me.ButtonAscendingDescending = New System.Windows.Forms.Button()
        Me.DataGridViewPets = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewPets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(24, 9)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(107, 28)
        Me.ButtonBack.TabIndex = 0
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.LabelTitle.Location = New System.Drawing.Point(522, 81)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(160, 28)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Text = "Manage Pets"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelDescription.Location = New System.Drawing.Point(17, 128)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(343, 17)
        Me.LabelDescription.TabIndex = 3
        Me.LabelDescription.Text = "This area allows you to manage pet information"
        '
        'LabelSort
        '
        Me.LabelSort.AutoSize = True
        Me.LabelSort.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelSort.Location = New System.Drawing.Point(21, 169)
        Me.LabelSort.Name = "LabelSort"
        Me.LabelSort.Size = New System.Drawing.Size(43, 16)
        Me.LabelSort.TabIndex = 4
        Me.LabelSort.Text = "Sort:"
        '
        'ComboBoxSort
        '
        Me.ComboBoxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxSort.FormattingEnabled = True
        Me.ComboBoxSort.Location = New System.Drawing.Point(72, 166)
        Me.ComboBoxSort.Name = "ComboBoxSort"
        Me.ComboBoxSort.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxSort.TabIndex = 5
        '
        'ButtonAscendingDescending
        '
        Me.ButtonAscendingDescending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ButtonAscendingDescending.Location = New System.Drawing.Point(199, 163)
        Me.ButtonAscendingDescending.Name = "ButtonAscendingDescending"
        Me.ButtonAscendingDescending.Size = New System.Drawing.Size(120, 28)
        Me.ButtonAscendingDescending.TabIndex = 6
        Me.ButtonAscendingDescending.Text = "Ascending"
        Me.ButtonAscendingDescending.UseVisualStyleBackColor = True
        '
        'DataGridViewPets
        '
        Me.DataGridViewPets.AllowUserToAddRows = False
        Me.DataGridViewPets.AllowUserToDeleteRows = False
        Me.DataGridViewPets.AllowUserToResizeColumns = False
        Me.DataGridViewPets.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPets.EnableHeadersVisualStyles = False
        Me.DataGridViewPets.Location = New System.Drawing.Point(21, 212)
        Me.DataGridViewPets.Name = "DataGridViewPets"
        Me.DataGridViewPets.Size = New System.Drawing.Size(964, 224)
        Me.DataGridViewPets.TabIndex = 7
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(21, 454)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(110, 28)
        Me.ButtonSave.TabIndex = 8
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(137, 454)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(110, 28)
        Me.ButtonCancel.TabIndex = 9
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(254, 454)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(110, 28)
        Me.ButtonAdd.TabIndex = 10
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(370, 454)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(110, 28)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(486, 454)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(110, 28)
        Me.ButtonRefresh.TabIndex = 12
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.TickedOffApplication.My.Resources.Resources.TickedOff_Logo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(236, 9)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(280, 100)
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'ManagePetInfoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DataGridViewPets)
        Me.Controls.Add(Me.ButtonAscendingDescending)
        Me.Controls.Add(Me.ComboBoxSort)
        Me.Controls.Add(Me.LabelSort)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.ButtonBack)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Location = New System.Drawing.Point(0, 30)
        Me.Name = "ManagePetInfoControl"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.DataGridViewPets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBack As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelSort As Label
    Friend WithEvents ComboBoxSort As ComboBox
    Friend WithEvents ButtonAscendingDescending As Button
    Friend WithEvents DataGridViewPets As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonRefresh As Button
End Class
