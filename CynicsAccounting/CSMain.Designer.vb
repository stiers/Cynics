<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CSMain))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tvMainView = New System.Windows.Forms.TreeView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutDialogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Empty
        Me.ImageList1.Images.SetKeyName(0, "button2.bmp")
        Me.ImageList1.Images.SetKeyName(1, "button.bmp")
        Me.ImageList1.Images.SetKeyName(2, "account recenble1.bmp")
        Me.ImageList1.Images.SetKeyName(3, "account recenble2.bmp")
        '
        'tvMainView
        '
        Me.tvMainView.Dock = System.Windows.Forms.DockStyle.Left
        Me.tvMainView.HotTracking = True
        Me.tvMainView.ImageIndex = 0
        Me.tvMainView.ImageList = Me.ImageList1
        Me.tvMainView.Location = New System.Drawing.Point(0, 0)
        Me.tvMainView.Name = "tvMainView"
        Me.tvMainView.SelectedImageIndex = 0
        Me.tvMainView.ShowLines = False
        Me.tvMainView.ShowPlusMinus = False
        Me.tvMainView.ShowRootLines = False
        Me.tvMainView.Size = New System.Drawing.Size(184, 528)
        Me.tvMainView.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(184, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.HelpToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(603, 24)
        Me.MenuStrip1.TabIndex = 8
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutDialogToolStripMenuItem})
        Me.HelpToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.HelpToolStripMenuItem.MergeIndex = 50
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.HelpToolStripMenuItem1.MergeIndex = 51
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutDialogToolStripMenuItem
        '
        Me.AboutDialogToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.AboutDialogToolStripMenuItem.MergeIndex = 52
        Me.AboutDialogToolStripMenuItem.Name = "AboutDialogToolStripMenuItem"
        Me.AboutDialogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutDialogToolStripMenuItem.Text = "About Dialog"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(184, 506)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(603, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = False
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(300, 17)
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(184, 24)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 482)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(138, 20)
        Me.ToolStripMenuItem1.Text = "UnSortMergePlaceHolder"
        Me.ToolStripMenuItem1.ToolTipText = "This is just a dummy place holder that will not sort by mergeindex"
        Me.ToolStripMenuItem1.Visible = False
        '
        'CSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(787, 528)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.tvMainView)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CSMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cynics Account Client"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tvMainView As System.Windows.Forms.TreeView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDialogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
