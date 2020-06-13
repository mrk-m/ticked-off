<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticsControl))
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.LabelShortestStay = New System.Windows.Forms.Label()
        Me.LabelShortestStayOutput = New System.Windows.Forms.Label()
        Me.LabelLowestBoardingCost = New System.Windows.Forms.Label()
        Me.LabelLowestBoardingCostOutput = New System.Windows.Forms.Label()
        Me.LabelLongestStay = New System.Windows.Forms.Label()
        Me.LabelLongestStayOutput = New System.Windows.Forms.Label()
        Me.LabelHighestBoardingCost = New System.Windows.Forms.Label()
        Me.LabelHighestBoardingCostOutput = New System.Windows.Forms.Label()
        Me.LabelAverageStay = New System.Windows.Forms.Label()
        Me.LabelAverageStayOutput = New System.Windows.Forms.Label()
        Me.LabelAverageBoardingCost = New System.Windows.Forms.Label()
        Me.LabelAverageBoardingCostOutput = New System.Windows.Forms.Label()
        Me.LabelSpecies = New System.Windows.Forms.Label()
        Me.ComboBoxSpecies = New System.Windows.Forms.ComboBox()
        Me.LabelNumberOfStays = New System.Windows.Forms.Label()
        Me.LabelNumberOfStaysOutput = New System.Windows.Forms.Label()
        Me.LabelTotalAmountPaid = New System.Windows.Forms.Label()
        Me.LabelTotalAmountPaidOutput = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelDescription.Location = New System.Drawing.Point(17, 128)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(872, 34)
        Me.LabelDescription.TabIndex = 20
        Me.LabelDescription.Text = resources.GetString("LabelDescription.Text")
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.LabelTitle.Location = New System.Drawing.Point(522, 81)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(120, 28)
        Me.LabelTitle.TabIndex = 19
        Me.LabelTitle.Text = "Statistics"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.TickedOffApplication.My.Resources.Resources.TickedOff_Logo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(236, 9)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(280, 100)
        Me.PictureBoxLogo.TabIndex = 18
        Me.PictureBoxLogo.TabStop = False
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(24, 9)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(107, 28)
        Me.ButtonBack.TabIndex = 17
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'LabelShortestStay
        '
        Me.LabelShortestStay.AutoSize = True
        Me.LabelShortestStay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelShortestStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelShortestStay.Location = New System.Drawing.Point(215, 209)
        Me.LabelShortestStay.Name = "LabelShortestStay"
        Me.LabelShortestStay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelShortestStay.Size = New System.Drawing.Size(112, 16)
        Me.LabelShortestStay.TabIndex = 21
        Me.LabelShortestStay.Text = ":Shortest Stay"
        '
        'LabelShortestStayOutput
        '
        Me.LabelShortestStayOutput.AutoSize = True
        Me.LabelShortestStayOutput.Location = New System.Drawing.Point(333, 209)
        Me.LabelShortestStayOutput.Name = "LabelShortestStayOutput"
        Me.LabelShortestStayOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelShortestStayOutput.TabIndex = 22
        Me.LabelShortestStayOutput.Text = "-"
        '
        'LabelLowestBoardingCost
        '
        Me.LabelLowestBoardingCost.AutoSize = True
        Me.LabelLowestBoardingCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelLowestBoardingCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelLowestBoardingCost.Location = New System.Drawing.Point(547, 210)
        Me.LabelLowestBoardingCost.Name = "LabelLowestBoardingCost"
        Me.LabelLowestBoardingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelLowestBoardingCost.Size = New System.Drawing.Size(171, 16)
        Me.LabelLowestBoardingCost.TabIndex = 23
        Me.LabelLowestBoardingCost.Text = ":Lowest Boarding Cost"
        '
        'LabelLowestBoardingCostOutput
        '
        Me.LabelLowestBoardingCostOutput.AutoSize = True
        Me.LabelLowestBoardingCostOutput.Location = New System.Drawing.Point(724, 210)
        Me.LabelLowestBoardingCostOutput.Name = "LabelLowestBoardingCostOutput"
        Me.LabelLowestBoardingCostOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelLowestBoardingCostOutput.TabIndex = 24
        Me.LabelLowestBoardingCostOutput.Text = "-"
        '
        'LabelLongestStay
        '
        Me.LabelLongestStay.AutoSize = True
        Me.LabelLongestStay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelLongestStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelLongestStay.Location = New System.Drawing.Point(219, 258)
        Me.LabelLongestStay.Name = "LabelLongestStay"
        Me.LabelLongestStay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelLongestStay.Size = New System.Drawing.Size(108, 16)
        Me.LabelLongestStay.TabIndex = 25
        Me.LabelLongestStay.Text = ":Longest Stay"
        '
        'LabelLongestStayOutput
        '
        Me.LabelLongestStayOutput.AutoSize = True
        Me.LabelLongestStayOutput.Location = New System.Drawing.Point(333, 258)
        Me.LabelLongestStayOutput.Name = "LabelLongestStayOutput"
        Me.LabelLongestStayOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelLongestStayOutput.TabIndex = 26
        Me.LabelLongestStayOutput.Text = "-"
        '
        'LabelHighestBoardingCost
        '
        Me.LabelHighestBoardingCost.AutoSize = True
        Me.LabelHighestBoardingCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelHighestBoardingCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelHighestBoardingCost.Location = New System.Drawing.Point(547, 258)
        Me.LabelHighestBoardingCost.Name = "LabelHighestBoardingCost"
        Me.LabelHighestBoardingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelHighestBoardingCost.Size = New System.Drawing.Size(175, 16)
        Me.LabelHighestBoardingCost.TabIndex = 27
        Me.LabelHighestBoardingCost.Text = ":Highest Boarding Cost"
        '
        'LabelHighestBoardingCostOutput
        '
        Me.LabelHighestBoardingCostOutput.AutoSize = True
        Me.LabelHighestBoardingCostOutput.Location = New System.Drawing.Point(724, 257)
        Me.LabelHighestBoardingCostOutput.Name = "LabelHighestBoardingCostOutput"
        Me.LabelHighestBoardingCostOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelHighestBoardingCostOutput.TabIndex = 28
        Me.LabelHighestBoardingCostOutput.Text = "-"
        '
        'LabelAverageStay
        '
        Me.LabelAverageStay.AutoSize = True
        Me.LabelAverageStay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelAverageStay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelAverageStay.Location = New System.Drawing.Point(215, 306)
        Me.LabelAverageStay.Name = "LabelAverageStay"
        Me.LabelAverageStay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelAverageStay.Size = New System.Drawing.Size(111, 16)
        Me.LabelAverageStay.TabIndex = 29
        Me.LabelAverageStay.Text = ":Average Stay"
        '
        'LabelAverageStayOutput
        '
        Me.LabelAverageStayOutput.AutoSize = True
        Me.LabelAverageStayOutput.Location = New System.Drawing.Point(333, 306)
        Me.LabelAverageStayOutput.Name = "LabelAverageStayOutput"
        Me.LabelAverageStayOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelAverageStayOutput.TabIndex = 30
        Me.LabelAverageStayOutput.Text = "-"
        '
        'LabelAverageBoardingCost
        '
        Me.LabelAverageBoardingCost.AutoSize = True
        Me.LabelAverageBoardingCost.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelAverageBoardingCost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelAverageBoardingCost.Location = New System.Drawing.Point(547, 306)
        Me.LabelAverageBoardingCost.Name = "LabelAverageBoardingCost"
        Me.LabelAverageBoardingCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelAverageBoardingCost.Size = New System.Drawing.Size(180, 16)
        Me.LabelAverageBoardingCost.TabIndex = 31
        Me.LabelAverageBoardingCost.Text = ":Average Boarding Cost"
        '
        'LabelAverageBoardingCostOutput
        '
        Me.LabelAverageBoardingCostOutput.AutoSize = True
        Me.LabelAverageBoardingCostOutput.Location = New System.Drawing.Point(724, 306)
        Me.LabelAverageBoardingCostOutput.Name = "LabelAverageBoardingCostOutput"
        Me.LabelAverageBoardingCostOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelAverageBoardingCostOutput.TabIndex = 32
        Me.LabelAverageBoardingCostOutput.Text = "-"
        '
        'LabelSpecies
        '
        Me.LabelSpecies.AutoSize = True
        Me.LabelSpecies.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelSpecies.Location = New System.Drawing.Point(365, 366)
        Me.LabelSpecies.Name = "LabelSpecies"
        Me.LabelSpecies.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelSpecies.Size = New System.Drawing.Size(69, 16)
        Me.LabelSpecies.TabIndex = 33
        Me.LabelSpecies.Text = ":Species"
        '
        'ComboBoxSpecies
        '
        Me.ComboBoxSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSpecies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.ComboBoxSpecies.FormattingEnabled = True
        Me.ComboBoxSpecies.Location = New System.Drawing.Point(440, 363)
        Me.ComboBoxSpecies.Name = "ComboBoxSpecies"
        Me.ComboBoxSpecies.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxSpecies.TabIndex = 34
        '
        'LabelNumberOfStays
        '
        Me.LabelNumberOfStays.AutoSize = True
        Me.LabelNumberOfStays.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelNumberOfStays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelNumberOfStays.Location = New System.Drawing.Point(335, 411)
        Me.LabelNumberOfStays.Name = "LabelNumberOfStays"
        Me.LabelNumberOfStays.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelNumberOfStays.Size = New System.Drawing.Size(99, 16)
        Me.LabelNumberOfStays.TabIndex = 35
        Me.LabelNumberOfStays.Text = ":No. of stays"
        '
        'LabelNumberOfStaysOutput
        '
        Me.LabelNumberOfStaysOutput.AutoSize = True
        Me.LabelNumberOfStaysOutput.Location = New System.Drawing.Point(440, 411)
        Me.LabelNumberOfStaysOutput.Name = "LabelNumberOfStaysOutput"
        Me.LabelNumberOfStaysOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelNumberOfStaysOutput.TabIndex = 36
        Me.LabelNumberOfStaysOutput.Text = "-"
        '
        'LabelTotalAmountPaid
        '
        Me.LabelTotalAmountPaid.AutoSize = True
        Me.LabelTotalAmountPaid.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelTotalAmountPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelTotalAmountPaid.Location = New System.Drawing.Point(289, 453)
        Me.LabelTotalAmountPaid.Name = "LabelTotalAmountPaid"
        Me.LabelTotalAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelTotalAmountPaid.Size = New System.Drawing.Size(145, 16)
        Me.LabelTotalAmountPaid.TabIndex = 37
        Me.LabelTotalAmountPaid.Text = ":Total Amount Paid"
        '
        'LabelTotalAmountPaidOutput
        '
        Me.LabelTotalAmountPaidOutput.AutoSize = True
        Me.LabelTotalAmountPaidOutput.Location = New System.Drawing.Point(440, 452)
        Me.LabelTotalAmountPaidOutput.Name = "LabelTotalAmountPaidOutput"
        Me.LabelTotalAmountPaidOutput.Size = New System.Drawing.Size(15, 17)
        Me.LabelTotalAmountPaidOutput.TabIndex = 38
        Me.LabelTotalAmountPaidOutput.Text = "-"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(567, 361)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(120, 28)
        Me.ButtonCalculate.TabIndex = 39
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'StatisticsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelTotalAmountPaidOutput)
        Me.Controls.Add(Me.LabelTotalAmountPaid)
        Me.Controls.Add(Me.LabelNumberOfStaysOutput)
        Me.Controls.Add(Me.LabelNumberOfStays)
        Me.Controls.Add(Me.ComboBoxSpecies)
        Me.Controls.Add(Me.LabelSpecies)
        Me.Controls.Add(Me.LabelAverageBoardingCostOutput)
        Me.Controls.Add(Me.LabelAverageBoardingCost)
        Me.Controls.Add(Me.LabelAverageStayOutput)
        Me.Controls.Add(Me.LabelAverageStay)
        Me.Controls.Add(Me.LabelHighestBoardingCostOutput)
        Me.Controls.Add(Me.LabelHighestBoardingCost)
        Me.Controls.Add(Me.LabelLongestStayOutput)
        Me.Controls.Add(Me.LabelLongestStay)
        Me.Controls.Add(Me.LabelLowestBoardingCostOutput)
        Me.Controls.Add(Me.LabelLowestBoardingCost)
        Me.Controls.Add(Me.LabelShortestStayOutput)
        Me.Controls.Add(Me.LabelShortestStay)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.ButtonBack)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Location = New System.Drawing.Point(0, 30)
        Me.Name = "StatisticsControl"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDescription As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonBack As Button
    Friend WithEvents LabelShortestStay As Label
    Friend WithEvents LabelShortestStayOutput As Label
    Friend WithEvents LabelLowestBoardingCost As Label
    Friend WithEvents LabelLowestBoardingCostOutput As Label
    Friend WithEvents LabelLongestStay As Label
    Friend WithEvents LabelLongestStayOutput As Label
    Friend WithEvents LabelHighestBoardingCost As Label
    Friend WithEvents LabelHighestBoardingCostOutput As Label
    Friend WithEvents LabelAverageStay As Label
    Friend WithEvents LabelAverageStayOutput As Label
    Friend WithEvents LabelAverageBoardingCost As Label
    Friend WithEvents LabelAverageBoardingCostOutput As Label
    Friend WithEvents LabelSpecies As Label
    Friend WithEvents ComboBoxSpecies As ComboBox
    Friend WithEvents LabelNumberOfStays As Label
    Friend WithEvents LabelNumberOfStaysOutput As Label
    Friend WithEvents LabelTotalAmountPaid As Label
    Friend WithEvents LabelTotalAmountPaidOutput As Label
    Friend WithEvents ButtonCalculate As Button
End Class
