<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BoardCostCalculatorControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BoardCostCalculatorControl))
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.LabelSpecies = New System.Windows.Forms.Label()
        Me.ComboBoxSpecies = New System.Windows.Forms.ComboBox()
        Me.LabelWeight = New System.Windows.Forms.Label()
        Me.TextBoxWeight = New System.Windows.Forms.TextBox()
        Me.LabelStayLength = New System.Windows.Forms.Label()
        Me.TextBoxLength = New System.Windows.Forms.TextBox()
        Me.LabelTotalCost = New System.Windows.Forms.Label()
        Me.LabelCostOutput = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelDescription.Location = New System.Drawing.Point(17, 128)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(994, 34)
        Me.LabelDescription.TabIndex = 16
        Me.LabelDescription.Text = resources.GetString("LabelDescription.Text")
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.LabelTitle.Location = New System.Drawing.Point(522, 81)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(305, 28)
        Me.LabelTitle.TabIndex = 15
        Me.LabelTitle.Text = "Boarding Cost Calculator"
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(24, 9)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(107, 28)
        Me.ButtonBack.TabIndex = 13
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'LabelSpecies
        '
        Me.LabelSpecies.AutoSize = True
        Me.LabelSpecies.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelSpecies.Location = New System.Drawing.Point(388, 222)
        Me.LabelSpecies.Name = "LabelSpecies"
        Me.LabelSpecies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelSpecies.Size = New System.Drawing.Size(69, 16)
        Me.LabelSpecies.TabIndex = 17
        Me.LabelSpecies.Text = ":Species"
        '
        'ComboBoxSpecies
        '
        Me.ComboBoxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxSpecies.FormattingEnabled = True
        Me.ComboBoxSpecies.Location = New System.Drawing.Point(463, 219)
        Me.ComboBoxSpecies.Name = "ComboBoxSpecies"
        Me.ComboBoxSpecies.Size = New System.Drawing.Size(189, 24)
        Me.ComboBoxSpecies.TabIndex = 18
        '
        'LabelWeight
        '
        Me.LabelWeight.AutoSize = True
        Me.LabelWeight.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelWeight.Location = New System.Drawing.Point(367, 275)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelWeight.Size = New System.Drawing.Size(92, 16)
        Me.LabelWeight.TabIndex = 19
        Me.LabelWeight.Text = ":Pet Weight"
        '
        'TextBoxWeight
        '
        Me.TextBoxWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TextBoxWeight.Location = New System.Drawing.Point(463, 272)
        Me.TextBoxWeight.Name = "TextBoxWeight"
        Me.TextBoxWeight.Size = New System.Drawing.Size(189, 24)
        Me.TextBoxWeight.TabIndex = 20
        '
        'LabelStayLength
        '
        Me.LabelStayLength.AutoSize = True
        Me.LabelStayLength.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStayLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelStayLength.Location = New System.Drawing.Point(357, 330)
        Me.LabelStayLength.Name = "LabelStayLength"
        Me.LabelStayLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelStayLength.Size = New System.Drawing.Size(100, 16)
        Me.LabelStayLength.TabIndex = 21
        Me.LabelStayLength.Text = ":Stay Length"
        '
        'TextBoxLength
        '
        Me.TextBoxLength.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.TextBoxLength.Location = New System.Drawing.Point(463, 327)
        Me.TextBoxLength.Name = "TextBoxLength"
        Me.TextBoxLength.Size = New System.Drawing.Size(189, 24)
        Me.TextBoxLength.TabIndex = 22
        '
        'LabelTotalCost
        '
        Me.LabelTotalCost.AutoSize = True
        Me.LabelTotalCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelTotalCost.Location = New System.Drawing.Point(372, 387)
        Me.LabelTotalCost.Name = "LabelTotalCost"
        Me.LabelTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelTotalCost.Size = New System.Drawing.Size(86, 16)
        Me.LabelTotalCost.TabIndex = 23
        Me.LabelTotalCost.Text = ":Total Cost"
        '
        'LabelCostOutput
        '
        Me.LabelCostOutput.AutoSize = True
        Me.LabelCostOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.LabelCostOutput.Location = New System.Drawing.Point(464, 386)
        Me.LabelCostOutput.Name = "LabelCostOutput"
        Me.LabelCostOutput.Size = New System.Drawing.Size(56, 17)
        Me.LabelCostOutput.TabIndex = 24
        Me.LabelCostOutput.Text = "$---.--"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(668, 323)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(110, 28)
        Me.ButtonCalculate.TabIndex = 25
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.TickedOffApplication.My.Resources.Resources.TickedOff_Logo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(236, 9)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(280, 100)
        Me.PictureBoxLogo.TabIndex = 14
        Me.PictureBoxLogo.TabStop = False
        '
        'BoardCostCalculatorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelCostOutput)
        Me.Controls.Add(Me.LabelTotalCost)
        Me.Controls.Add(Me.TextBoxLength)
        Me.Controls.Add(Me.LabelStayLength)
        Me.Controls.Add(Me.TextBoxWeight)
        Me.Controls.Add(Me.LabelWeight)
        Me.Controls.Add(Me.ComboBoxSpecies)
        Me.Controls.Add(Me.LabelSpecies)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.ButtonBack)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Location = New System.Drawing.Point(0, 30)
        Me.Name = "BoardCostCalculatorControl"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonBack As Button
    Friend WithEvents LabelSpecies As Label
    Friend WithEvents ComboBoxSpecies As ComboBox
    Friend WithEvents LabelWeight As Label
    Friend WithEvents TextBoxWeight As TextBox
    Friend WithEvents LabelStayLength As Label
    Friend WithEvents TextBoxLength As TextBox
    Friend WithEvents LabelTotalCost As Label
    Friend WithEvents LabelCostOutput As Label
    Friend WithEvents ButtonCalculate As Button
End Class
