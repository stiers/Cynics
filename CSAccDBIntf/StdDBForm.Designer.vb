<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StdDBForm
    Inherits CSAccountDatabaseIntf.StdForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StdDBForm))
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbtnEdit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbtnPrint = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.DataNavigatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FirstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\Essential Accounting.chm"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.tsbtnEdit, Me.ToolStripSeparator2, Me.tsbtnSave, Me.tsbtnCancel, Me.ToolStripSeparator3, Me.tsbtnPrint})
        Me.BindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(592, 23)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 23)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new data"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.CSAccountDatabaseIntf.My.Resources.Resources.minus24
        Me.BindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete data"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'tsbtnEdit
        '
        Me.tsbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEdit.Image = Global.CSAccountDatabaseIntf.My.Resources.Resources.edit24
        Me.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEdit.Name = "tsbtnEdit"
        Me.tsbtnEdit.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnEdit.Text = "Edit data"
        Me.tsbtnEdit.ToolTipText = "Edit Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSave.Enabled = False
        Me.tsbtnSave.Image = Global.CSAccountDatabaseIntf.My.Resources.Resources.save24
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnSave.Text = "Save data"
        Me.tsbtnSave.ToolTipText = "Save Data"
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancel.Enabled = False
        Me.tsbtnCancel.Image = Global.CSAccountDatabaseIntf.My.Resources.Resources.undo24
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnCancel.Text = "Cancel data"
        Me.tsbtnCancel.ToolTipText = "Cancel Changes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 23)
        '
        'tsbtnPrint
        '
        Me.tsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnPrint.Image = Global.CSAccountDatabaseIntf.My.Resources.Resources.HARDWA55
        Me.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrint.Name = "tsbtnPrint"
        Me.tsbtnPrint.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnPrint.Text = "Print"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataNavigatorToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.DataNavigatorToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(592, 23)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'DataNavigatorToolStripMenuItem
        '
        Me.DataNavigatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.NextToolStripMenuItem, Me.LastToolStripMenuItem, Me.ToolStripMenuItem1, Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripMenuItem3, Me.EditToolStripMenuItem, Me.ToolStripMenuItem2, Me.SaveToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.DataNavigatorToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.DataNavigatorToolStripMenuItem.MergeIndex = 1
        Me.DataNavigatorToolStripMenuItem.Name = "DataNavigatorToolStripMenuItem"
        Me.DataNavigatorToolStripMenuItem.Size = New System.Drawing.Size(92, 17)
        Me.DataNavigatorToolStripMenuItem.Text = "Data Navigator"
        '
        'FirstToolStripMenuItem
        '
        Me.FirstToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.FirstToolStripMenuItem.MergeIndex = 1
        Me.FirstToolStripMenuItem.Name = "FirstToolStripMenuItem"
        Me.FirstToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FirstToolStripMenuItem.Text = "First"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.PreviousToolStripMenuItem.MergeIndex = 2
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.NextToolStripMenuItem.MergeIndex = 3
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'LastToolStripMenuItem
        '
        Me.LastToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.LastToolStripMenuItem.MergeIndex = 4
        Me.LastToolStripMenuItem.Name = "LastToolStripMenuItem"
        Me.LastToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LastToolStripMenuItem.Text = "Last"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ToolStripMenuItem1.MergeIndex = 5
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(179, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.AddToolStripMenuItem.MergeIndex = 6
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert), System.Windows.Forms.Keys)
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.DeleteToolStripMenuItem.MergeIndex = 7
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ToolStripMenuItem3.MergeIndex = 8
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(179, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.EditToolStripMenuItem.MergeIndex = 9
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ToolStripMenuItem2.MergeIndex = 10
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(179, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.SaveToolStripMenuItem.MergeIndex = 11
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.CancelToolStripMenuItem.MergeIndex = 12
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'StdDBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StdDBForm"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "Data Form"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataNavigatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Protected Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Public WithEvents tsbtnPrint As System.Windows.Forms.ToolStripButton
    Public WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FirstToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LastToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator

End Class
