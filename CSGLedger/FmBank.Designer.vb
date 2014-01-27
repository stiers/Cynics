<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmBank
    Inherits CSAccountDatabaseIntf.StdDBTranForm

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
        Dim BANK_CODELabel As System.Windows.Forms.Label
        Dim BANK_NAMELabel As System.Windows.Forms.Label
        Dim ACC_CODELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CSMasterDataset = New CSAccountDatabaseIntf.CSMasterDataset
        Me.MST_BANKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrowseGrid = New System.Windows.Forms.DataGridView
        Me.MSTACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BANK_CODETextBox = New System.Windows.Forms.TextBox
        Me.BANK_NAMETextBox = New System.Windows.Forms.TextBox
        Me.ACC_CODEComboBox = New System.Windows.Forms.ComboBox
        Me.btnAccount = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccNameComboboxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        BANK_CODELabel = New System.Windows.Forms.Label
        BANK_NAMELabel = New System.Windows.Forms.Label
        ACC_CODELabel = New System.Windows.Forms.Label
        Me.BrowsePage.SuspendLayout()
        Me.EditPage.SuspendLayout()
        Me.btnOKCancelPanel.SuspendLayout()
        Me.TabControl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_BANKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSTACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EditPage.Controls.Add(Me.btnAccount)
        Me.EditPage.Controls.Add(BANK_CODELabel)
        Me.EditPage.Controls.Add(Me.BANK_CODETextBox)
        Me.EditPage.Controls.Add(BANK_NAMELabel)
        Me.EditPage.Controls.Add(Me.BANK_NAMETextBox)
        Me.EditPage.Controls.Add(ACC_CODELabel)
        Me.EditPage.Controls.Add(Me.ACC_CODEComboBox)
        '
        'TabControl
        '
        Me.TabControl.Location = New System.Drawing.Point(0, 44)
        Me.TabControl.Size = New System.Drawing.Size(592, 479)
        '
        'BANK_CODELabel
        '
        BANK_CODELabel.AutoSize = True
        BANK_CODELabel.Location = New System.Drawing.Point(36, 25)
        BANK_CODELabel.Name = "BANK_CODELabel"
        BANK_CODELabel.Size = New System.Drawing.Size(48, 13)
        BANK_CODELabel.TabIndex = 0
        BANK_CODELabel.Text = "Bank# : "
        '
        'BANK_NAMELabel
        '
        BANK_NAMELabel.AutoSize = True
        BANK_NAMELabel.Location = New System.Drawing.Point(12, 51)
        BANK_NAMELabel.Name = "BANK_NAMELabel"
        BANK_NAMELabel.Size = New System.Drawing.Size(72, 13)
        BANK_NAMELabel.TabIndex = 2
        BANK_NAMELabel.Text = "Bank Name : "
        '
        'ACC_CODELabel
        '
        ACC_CODELabel.AutoSize = True
        ACC_CODELabel.Location = New System.Drawing.Point(15, 77)
        ACC_CODELabel.Name = "ACC_CODELabel"
        ACC_CODELabel.Size = New System.Drawing.Size(69, 13)
        ACC_CODELabel.TabIndex = 4
        ACC_CODELabel.Text = "Acc. Name : "
        '
        'CSMasterDataset
        '
        Me.CSMasterDataset.DataSetName = "CSMasterDataset"
        Me.CSMasterDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_BANKBindingSource
        '
        Me.MST_BANKBindingSource.DataMember = "MST_BANK"
        Me.MST_BANKBindingSource.DataSource = Me.CSMasterDataset
        '
        'BrowseGrid
        '
        Me.BrowseGrid.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.AccNameComboboxColumn})
        Me.BrowseGrid.DataSource = Me.MST_BANKBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BrowseGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
        Me.BrowseGrid.Name = "BrowseGrid"
        Me.BrowseGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BrowseGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BrowseGrid.Size = New System.Drawing.Size(578, 444)
        Me.BrowseGrid.TabIndex = 0
        '
        'MSTACCOUNTBindingSource
        '
        Me.MSTACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
        Me.MSTACCOUNTBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSMasterDataset)
        '
        'BANK_CODETextBox
        '
        Me.BANK_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_BANKBindingSource, "BANK_CODE", True))
        Me.BANK_CODETextBox.Location = New System.Drawing.Point(90, 22)
        Me.BANK_CODETextBox.Name = "BANK_CODETextBox"
        Me.BANK_CODETextBox.Size = New System.Drawing.Size(102, 20)
        Me.BANK_CODETextBox.TabIndex = 1
        '
        'BANK_NAMETextBox
        '
        Me.BANK_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_BANKBindingSource, "BANK_NAME", True))
        Me.BANK_NAMETextBox.Location = New System.Drawing.Point(90, 48)
        Me.BANK_NAMETextBox.Name = "BANK_NAMETextBox"
        Me.BANK_NAMETextBox.Size = New System.Drawing.Size(227, 20)
        Me.BANK_NAMETextBox.TabIndex = 3
        '
        'ACC_CODEComboBox
        '
        Me.ACC_CODEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MST_BANKBindingSource, "ACC_CODE", True))
        Me.ACC_CODEComboBox.DataSource = Me.MSTACCOUNTBindingSource
        Me.ACC_CODEComboBox.DisplayMember = "ACC_NAME"
        Me.ACC_CODEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ACC_CODEComboBox.FormattingEnabled = True
        Me.ACC_CODEComboBox.Location = New System.Drawing.Point(90, 74)
        Me.ACC_CODEComboBox.Name = "ACC_CODEComboBox"
        Me.ACC_CODEComboBox.Size = New System.Drawing.Size(200, 21)
        Me.ACC_CODEComboBox.TabIndex = 5
        Me.ACC_CODEComboBox.ValueMember = "ACC_CODE"
        '
        'btnAccount
        '
        Me.btnAccount.Location = New System.Drawing.Point(292, 75)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(25, 20)
        Me.btnAccount.TabIndex = 27
        Me.btnAccount.Text = "..."
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BANK_CODE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bank#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BANK_NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Bank Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ACC_CODE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Acc#"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'AccNameComboboxColumn
        '
        Me.AccNameComboboxColumn.DataPropertyName = "ACC_CODE"
        Me.AccNameComboboxColumn.DataSource = Me.MSTACCOUNTBindingSource
        Me.AccNameComboboxColumn.DisplayMember = "ACC_NAME"
        Me.AccNameComboboxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.AccNameComboboxColumn.HeaderText = "Acc. Name"
        Me.AccNameComboboxColumn.Name = "AccNameComboboxColumn"
        Me.AccNameComboboxColumn.ReadOnly = True
        Me.AccNameComboboxColumn.ValueMember = "ACC_CODE"
        Me.AccNameComboboxColumn.Width = 200
        '
        'FmBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.HelpProvider1.SetHelpKeyword(Me, "40500")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FmBank"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Bank"
        Me.BrowsePage.ResumeLayout(False)
        Me.EditPage.ResumeLayout(False)
        Me.EditPage.PerformLayout()
        Me.btnOKCancelPanel.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSMasterDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_BANKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSTACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MST_BANKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSMasterDataset As CSAccountDatabaseIntf.CSMasterDataset
    Friend WithEvents MSTACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BANK_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents BANK_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ACC_CODEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnAccount As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccNameComboboxColumn As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
