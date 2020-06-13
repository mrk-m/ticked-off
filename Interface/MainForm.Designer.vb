<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStripMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.MenuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripMain
        '
        Me.MenuStripMain.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.MenuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripMain.Name = "MenuStripMain"
        Me.MenuStripMain.Size = New System.Drawing.Size(1008, 25)
        Me.MenuStripMain.TabIndex = 0
        Me.MenuStripMain.Text = "MenuStripMain"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisCompanyToolStripMenuItem, Me.AboutThisApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(50, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutThisCompanyToolStripMenuItem
        '
        Me.AboutThisCompanyToolStripMenuItem.Name = "AboutThisCompanyToolStripMenuItem"
        Me.AboutThisCompanyToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AboutThisCompanyToolStripMenuItem.Text = "About this &company"
        '
        'AboutThisApplicationToolStripMenuItem
        '
        Me.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem"
        Me.AboutThisApplicationToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AboutThisApplicationToolStripMenuItem.Text = "About this &application"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.LabelCopyright.Location = New System.Drawing.Point(404, 535)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(212, 17)
        Me.LabelCopyright.TabIndex = 1
        Me.LabelCopyright.Text = "Copyright © 2019 Ticked Off"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.LabelCopyright)
        Me.Controls.Add(Me.MenuStripMain)
        Me.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripMain
        Me.Name = "MainForm"
        Me.Text = "Ticked Off"
        Me.MenuStripMain.ResumeLayout(False)
        Me.MenuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelCopyright As Label
End Class
