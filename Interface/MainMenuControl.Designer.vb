<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuControl
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
        Me.ButtonManagePetInformation = New System.Windows.Forms.Button()
        Me.ButtonStatistics = New System.Windows.Forms.Button()
        Me.ButtonBoardingCostCalculator = New System.Windows.Forms.Button()
        Me.ButtonQuickExport = New System.Windows.Forms.Button()
        Me.ButtonPromoVideo = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonManagePetInformation
        '
        Me.ButtonManagePetInformation.Location = New System.Drawing.Point(279, 169)
        Me.ButtonManagePetInformation.Name = "ButtonManagePetInformation"
        Me.ButtonManagePetInformation.Size = New System.Drawing.Size(221, 100)
        Me.ButtonManagePetInformation.TabIndex = 1
        Me.ButtonManagePetInformation.Text = "Manage Pet Information"
        Me.ButtonManagePetInformation.UseVisualStyleBackColor = True
        '
        'ButtonStatistics
        '
        Me.ButtonStatistics.Location = New System.Drawing.Point(506, 169)
        Me.ButtonStatistics.Name = "ButtonStatistics"
        Me.ButtonStatistics.Size = New System.Drawing.Size(221, 100)
        Me.ButtonStatistics.TabIndex = 2
        Me.ButtonStatistics.Text = "Statistics"
        Me.ButtonStatistics.UseVisualStyleBackColor = True
        '
        'ButtonBoardingCostCalculator
        '
        Me.ButtonBoardingCostCalculator.Location = New System.Drawing.Point(279, 275)
        Me.ButtonBoardingCostCalculator.Name = "ButtonBoardingCostCalculator"
        Me.ButtonBoardingCostCalculator.Size = New System.Drawing.Size(221, 100)
        Me.ButtonBoardingCostCalculator.TabIndex = 3
        Me.ButtonBoardingCostCalculator.Text = "Boarding Cost Calculator"
        Me.ButtonBoardingCostCalculator.UseVisualStyleBackColor = True
        '
        'ButtonQuickExport
        '
        Me.ButtonQuickExport.Location = New System.Drawing.Point(506, 275)
        Me.ButtonQuickExport.Name = "ButtonQuickExport"
        Me.ButtonQuickExport.Size = New System.Drawing.Size(221, 100)
        Me.ButtonQuickExport.TabIndex = 4
        Me.ButtonQuickExport.Text = "Quick Export Pet Information (CSV)"
        Me.ButtonQuickExport.UseVisualStyleBackColor = True
        '
        'ButtonPromoVideo
        '
        Me.ButtonPromoVideo.Enabled = False
        Me.ButtonPromoVideo.Location = New System.Drawing.Point(279, 381)
        Me.ButtonPromoVideo.Name = "ButtonPromoVideo"
        Me.ButtonPromoVideo.Size = New System.Drawing.Size(448, 50)
        Me.ButtonPromoVideo.TabIndex = 5
        Me.ButtonPromoVideo.Text = "Watch the new promo video!"
        Me.ButtonPromoVideo.UseVisualStyleBackColor = True
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.TickedOffApplication.My.Resources.Resources.TickedOff_Logo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(279, 3)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(448, 160)
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'MainMenuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.ButtonPromoVideo)
        Me.Controls.Add(Me.ButtonQuickExport)
        Me.Controls.Add(Me.ButtonBoardingCostCalculator)
        Me.Controls.Add(Me.ButtonStatistics)
        Me.Controls.Add(Me.ButtonManagePetInformation)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Location = New System.Drawing.Point(0, 30)
        Me.Name = "MainMenuControl"
        Me.Size = New System.Drawing.Size(1000, 500)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonManagePetInformation As Button
    Friend WithEvents ButtonStatistics As Button
    Friend WithEvents ButtonBoardingCostCalculator As Button
    Friend WithEvents ButtonQuickExport As Button
    Friend WithEvents ButtonPromoVideo As Button
End Class
