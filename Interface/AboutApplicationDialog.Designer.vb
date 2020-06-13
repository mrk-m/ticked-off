<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutApplicationDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutApplicationDialog))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.LabelText = New System.Windows.Forms.Label()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.LabelTitle.Location = New System.Drawing.Point(316, 89)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(263, 28)
        Me.LabelTitle.TabIndex = 8
        Me.LabelTitle.Text = "About this application"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.TickedOffApplication.My.Resources.Resources.TickedOff_Logo
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(30, 17)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(280, 100)
        Me.PictureBoxLogo.TabIndex = 7
        Me.PictureBoxLogo.TabStop = False
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(757, 316)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(100, 28)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "OK"
        '
        'LabelText
        '
        Me.LabelText.AutoSize = True
        Me.LabelText.Location = New System.Drawing.Point(27, 162)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(839, 85)
        Me.LabelText.TabIndex = 6
        Me.LabelText.Text = resources.GetString("LabelText.Text")
        '
        'AboutApplicationDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(884, 361)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.LabelText)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutApplicationDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About this application"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents OK_Button As Button
    Friend WithEvents LabelText As Label
End Class
