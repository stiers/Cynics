<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.AdminName = New System.Windows.Forms.TextBox
        Me.AdminPass = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GrpChange = New System.Windows.Forms.GroupBox
        Me.ConfirmPass = New System.Windows.Forms.TextBox
        Me.NewPass = New System.Windows.Forms.TextBox
        Me.NewName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnChange = New System.Windows.Forms.Button
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrpChange.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Admin Password : "
        '
        'AdminName
        '
        Me.AdminName.Location = New System.Drawing.Point(122, 14)
        Me.AdminName.Name = "AdminName"
        Me.AdminName.Size = New System.Drawing.Size(133, 20)
        Me.AdminName.TabIndex = 0
        '
        'AdminPass
        '
        Me.AdminPass.Location = New System.Drawing.Point(122, 41)
        Me.AdminPass.Name = "AdminPass"
        Me.AdminPass.Size = New System.Drawing.Size(133, 20)
        Me.AdminPass.TabIndex = 1
        Me.AdminPass.UseSystemPasswordChar = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(267, 21)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(267, 50)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GrpChange
        '
        Me.GrpChange.Controls.Add(Me.ConfirmPass)
        Me.GrpChange.Controls.Add(Me.btnCancel)
        Me.GrpChange.Controls.Add(Me.NewPass)
        Me.GrpChange.Controls.Add(Me.btnSave)
        Me.GrpChange.Controls.Add(Me.NewName)
        Me.GrpChange.Controls.Add(Me.Label5)
        Me.GrpChange.Controls.Add(Me.Label4)
        Me.GrpChange.Controls.Add(Me.Label3)
        Me.GrpChange.Location = New System.Drawing.Point(3, 72)
        Me.GrpChange.Name = "GrpChange"
        Me.GrpChange.Size = New System.Drawing.Size(355, 107)
        Me.GrpChange.TabIndex = 3
        Me.GrpChange.TabStop = False
        Me.GrpChange.Text = " Changes "
        Me.GrpChange.Visible = False
        '
        'ConfirmPass
        '
        Me.ConfirmPass.Location = New System.Drawing.Point(121, 73)
        Me.ConfirmPass.Name = "ConfirmPass"
        Me.ConfirmPass.Size = New System.Drawing.Size(133, 20)
        Me.ConfirmPass.TabIndex = 2
        Me.ConfirmPass.UseSystemPasswordChar = True
        '
        'NewPass
        '
        Me.NewPass.Location = New System.Drawing.Point(121, 47)
        Me.NewPass.Name = "NewPass"
        Me.NewPass.Size = New System.Drawing.Size(133, 20)
        Me.NewPass.TabIndex = 1
        Me.NewPass.UseSystemPasswordChar = True
        '
        'NewName
        '
        Me.NewName.Location = New System.Drawing.Point(121, 19)
        Me.NewName.Name = "NewName"
        Me.NewName.Size = New System.Drawing.Size(133, 20)
        Me.NewName.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Confirm Password : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "New Password : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Name : "
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(270, 14)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 2
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Cynics Account Server"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FmMain
        '
        Me.AcceptButton = Me.btnChange
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 184)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.GrpChange)
        Me.Controls.Add(Me.AdminPass)
        Me.Controls.Add(Me.AdminName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cynics Account Server"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.GrpChange.ResumeLayout(False)
        Me.GrpChange.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AdminName As System.Windows.Forms.TextBox
    Friend WithEvents AdminPass As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GrpChange As System.Windows.Forms.GroupBox
    Friend WithEvents ConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents NewPass As System.Windows.Forms.TextBox
    Friend WithEvents NewName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
