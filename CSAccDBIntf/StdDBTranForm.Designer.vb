<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StdDBTranForm
    Inherits CSAccountDatabaseIntf.StdDBTabForm

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
        Me.BrowsePage = New System.Windows.Forms.TabPage
        Me.btnOKCancelPanel = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.EditPage = New System.Windows.Forms.TabPage
        Me.TabControl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrowsePage.SuspendLayout()
        Me.btnOKCancelPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl.Controls.Add(Me.BrowsePage)
        Me.TabControl.Controls.Add(Me.EditPage)
        Me.TabControl.Location = New System.Drawing.Point(0, 44)
        Me.TabControl.Size = New System.Drawing.Size(592, 479)
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\Cynics Accounting.chm"
        '
        'BrowsePage
        '
        Me.BrowsePage.BackColor = System.Drawing.Color.Silver
        Me.BrowsePage.Controls.Add(Me.btnOKCancelPanel)
        Me.BrowsePage.Location = New System.Drawing.Point(4, 25)
        Me.BrowsePage.Name = "BrowsePage"
        Me.BrowsePage.Padding = New System.Windows.Forms.Padding(3)
        Me.BrowsePage.Size = New System.Drawing.Size(584, 450)
        Me.BrowsePage.TabIndex = 0
        Me.BrowsePage.Text = "Browse"
        '
        'btnOKCancelPanel
        '
        Me.btnOKCancelPanel.Controls.Add(Me.btnCancel)
        Me.btnOKCancelPanel.Controls.Add(Me.btnOK)
        Me.btnOKCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOKCancelPanel.Location = New System.Drawing.Point(3, 418)
        Me.btnOKCancelPanel.Name = "btnOKCancelPanel"
        Me.btnOKCancelPanel.Size = New System.Drawing.Size(578, 29)
        Me.btnOKCancelPanel.TabIndex = 4
        Me.btnOKCancelPanel.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(499, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(416, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'EditPage
        '
        Me.EditPage.BackColor = System.Drawing.Color.Silver
        Me.EditPage.Location = New System.Drawing.Point(4, 25)
        Me.EditPage.Name = "EditPage"
        Me.EditPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EditPage.Size = New System.Drawing.Size(584, 450)
        Me.EditPage.TabIndex = 1
        Me.EditPage.Text = "Details"
        '
        'StdDBTranForm
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "StdDBTranForm"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrowsePage.ResumeLayout(False)
        Me.btnOKCancelPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BrowsePage As System.Windows.Forms.TabPage
    Public WithEvents EditPage As System.Windows.Forms.TabPage
    Public WithEvents btnCancel As System.Windows.Forms.Button
    Public WithEvents btnOK As System.Windows.Forms.Button
    Public WithEvents btnOKCancelPanel As System.Windows.Forms.Panel

End Class
