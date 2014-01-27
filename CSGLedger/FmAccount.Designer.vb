<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAccount
    Inherits CSAccountDatabaseIntf.StdDBTranForm

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
        Me.components = New System.ComponentModel.Container
        Dim ACC_CODELabel As System.Windows.Forms.Label
        Dim ACC_NAMELabel As System.Windows.Forms.Label
        Dim ACC_TYPELabel As System.Windows.Forms.Label
        Me.CSGLDataset = New CSAccountDatabaseIntf.CSGLDataset
        Me.MST_ACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYSACCTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACC_CODETextBox = New System.Windows.Forms.TextBox
        Me.ACC_NAMETextBox = New System.Windows.Forms.TextBox
        Me.ACC_TYPEComboBox = New System.Windows.Forms.ComboBox
        Me.RETAINED_EARNINGSCheckBox = New System.Windows.Forms.CheckBox
        Me.IS_ACTIVECheckBox = New System.Windows.Forms.CheckBox
        Me.CSMasterDataset = New CSAccountDatabaseIntf.CSMasterDataset
        Me.BrowseGrid = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        ACC_CODELabel = New System.Windows.Forms.Label
        ACC_NAMELabel = New System.Windows.Forms.Label
        ACC_TYPELabel = New System.Windows.Forms.Label
        Me.BrowsePage.SuspendLayout()
        Me.EditPage.SuspendLayout()
        Me.btnOKCancelPanel.SuspendLayout()
        Me.TabControl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYSACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BrowsePage
        '
        Me.BrowsePage.Controls.Add(Me.BrowseGrid)
        Me.BrowsePage.Controls.SetChildIndex(Me.BrowseGrid, 0)
        Me.BrowsePage.Controls.SetChildIndex(Me.btnOKCancelPanel, 0)
        '
        'EditPage
        '
        Me.EditPage.Controls.Add(Me.IS_ACTIVECheckBox)
        Me.EditPage.Controls.Add(Me.RETAINED_EARNINGSCheckBox)
        Me.EditPage.Controls.Add(ACC_TYPELabel)
        Me.EditPage.Controls.Add(Me.ACC_TYPEComboBox)
        Me.EditPage.Controls.Add(ACC_NAMELabel)
        Me.EditPage.Controls.Add(Me.ACC_NAMETextBox)
        Me.EditPage.Controls.Add(ACC_CODELabel)
        Me.EditPage.Controls.Add(Me.ACC_CODETextBox)
        '
        'TabControl
        '
        Me.TabControl.Location = New System.Drawing.Point(0, 44)
        Me.TabControl.Size = New System.Drawing.Size(592, 479)
        '
        'ACC_CODELabel
        '
        ACC_CODELabel.AutoSize = True
        ACC_CODELabel.Location = New System.Drawing.Point(43, 26)
        ACC_CODELabel.Name = "ACC_CODELabel"
        ACC_CODELabel.Size = New System.Drawing.Size(39, 13)
        ACC_CODELabel.TabIndex = 0
        ACC_CODELabel.Text = "Acc# :"
        ACC_CODELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ACC_NAMELabel
        '
        ACC_NAMELabel.AutoSize = True
        ACC_NAMELabel.Location = New System.Drawing.Point(16, 50)
        ACC_NAMELabel.Name = "ACC_NAMELabel"
        ACC_NAMELabel.Size = New System.Drawing.Size(66, 13)
        ACC_NAMELabel.TabIndex = 2
        ACC_NAMELabel.Text = "Acc Name : "
        ACC_NAMELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ACC_TYPELabel
        '
        ACC_TYPELabel.AutoSize = True
        ACC_TYPELabel.Location = New System.Drawing.Point(20, 76)
        ACC_TYPELabel.Name = "ACC_TYPELabel"
        ACC_TYPELabel.Size = New System.Drawing.Size(62, 13)
        ACC_TYPELabel.TabIndex = 4
        ACC_TYPELabel.Text = "Acc Type : "
        ACC_TYPELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CSGLDataset
        '
        Me.CSGLDataset.DataSetName = "CSGLDataset"
        Me.CSGLDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_ACCOUNTBindingSource
        '
        Me.MST_ACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
        Me.MST_ACCOUNTBindingSource.DataSource = Me.CSGLDataset
        '
        'SYSACCTYPEBindingSource
        '
        Me.SYSACCTYPEBindingSource.DataMember = "SYS_ACCTYPE"
        Me.SYSACCTYPEBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSGLDataset)
        '
        'ACC_CODETextBox
        '
        Me.ACC_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_ACCOUNTBindingSource, "ACC_CODE", True))
        Me.ACC_CODETextBox.Location = New System.Drawing.Point(84, 23)
        Me.ACC_CODETextBox.Name = "ACC_CODETextBox"
        Me.ACC_CODETextBox.Size = New System.Drawing.Size(64, 20)
        Me.ACC_CODETextBox.TabIndex = 0
        '
        'ACC_NAMETextBox
        '
        Me.ACC_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_ACCOUNTBindingSource, "ACC_NAME", True))
        Me.ACC_NAMETextBox.Location = New System.Drawing.Point(84, 47)
        Me.ACC_NAMETextBox.Name = "ACC_NAMETextBox"
        Me.ACC_NAMETextBox.Size = New System.Drawing.Size(198, 20)
        Me.ACC_NAMETextBox.TabIndex = 1
        '
        'ACC_TYPEComboBox
        '
        Me.ACC_TYPEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_ACCOUNTBindingSource, "ACC_TYPE", True))
        Me.ACC_TYPEComboBox.DataSource = Me.SYSACCTYPEBindingSource
        Me.ACC_TYPEComboBox.DisplayMember = "TYPE_NAME"
        Me.ACC_TYPEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_TYPEComboBox.FormattingEnabled = True
        Me.ACC_TYPEComboBox.Location = New System.Drawing.Point(84, 73)
        Me.ACC_TYPEComboBox.Name = "ACC_TYPEComboBox"
        Me.ACC_TYPEComboBox.Size = New System.Drawing.Size(198, 21)
        Me.ACC_TYPEComboBox.TabIndex = 2
        Me.ACC_TYPEComboBox.ValueMember = "ACC_TYPE"
        '
        'RETAINED_EARNINGSCheckBox
        '
        Me.RETAINED_EARNINGSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MST_ACCOUNTBindingSource, "RETAINED_EARNINGS", True))
        Me.RETAINED_EARNINGSCheckBox.Location = New System.Drawing.Point(84, 100)
        Me.RETAINED_EARNINGSCheckBox.Name = "RETAINED_EARNINGSCheckBox"
        Me.RETAINED_EARNINGSCheckBox.Size = New System.Drawing.Size(198, 21)
        Me.RETAINED_EARNINGSCheckBox.TabIndex = 3
        Me.RETAINED_EARNINGSCheckBox.Text = "Retained Earnings"
        '
        'IS_ACTIVECheckBox
        '
        Me.IS_ACTIVECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MST_ACCOUNTBindingSource, "IS_ACTIVE", True))
        Me.IS_ACTIVECheckBox.Location = New System.Drawing.Point(84, 124)
        Me.IS_ACTIVECheckBox.Name = "IS_ACTIVECheckBox"
        Me.IS_ACTIVECheckBox.Size = New System.Drawing.Size(198, 24)
        Me.IS_ACTIVECheckBox.TabIndex = 4
        Me.IS_ACTIVECheckBox.Text = "Active"
        '
        'CSMasterDataset
        '
        Me.CSMasterDataset.DataSetName = "CSMasterDataset"
        Me.CSMasterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BrowseGrid
        '
        Me.BrowseGrid.AutoGenerateColumns = False
        Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.BrowseGrid.DataSource = Me.MST_ACCOUNTBindingSource
        Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
        Me.BrowseGrid.Name = "BrowseGrid"
        Me.BrowseGrid.Size = New System.Drawing.Size(578, 444)
        Me.BrowseGrid.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ACC_CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Acc#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ACC_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Acc Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ACC_TYPE"
        Me.Column1.DataSource = Me.SYSACCTYPEBindingSource
        Me.Column1.DisplayMember = "TYPE_NAME"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Acc Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ValueMember = "ACC_TYPE"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "RETAINED_EARNINGS"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Retain"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "IS_ACTIVE"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Active"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 40
        '
        'FmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.HelpProvider1.SetHelpKeyword(Me, "30200")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FmAccount"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Account Setup"
        Me.BrowsePage.ResumeLayout(False)
        Me.EditPage.ResumeLayout(False)
        Me.EditPage.PerformLayout()
        Me.btnOKCancelPanel.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYSACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CSGLDataset As CSAccountDatabaseIntf.CSGLDataset
    Friend WithEvents MST_ACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYSACCTYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IS_ACTIVECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RETAINED_EARNINGSCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ACC_TYPEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ACC_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACC_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CSMasterDataset As CSAccountDatabaseIntf.CSMasterDataset

End Class
