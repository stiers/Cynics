<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCurrency
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
        Dim CURR_CODELabel As System.Windows.Forms.Label
        Dim CURR_NAMELabel As System.Windows.Forms.Label
        Dim CURR_RATELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CSGLDataset = New CSAccountDatabaseIntf.CSGLDataset
        Me.MST_CURRENCYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrowseGrid = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CURR_CODETextBox = New System.Windows.Forms.TextBox
        Me.CURR_NAMETextBox = New System.Windows.Forms.TextBox
        Me.CURR_RATETextBox = New System.Windows.Forms.TextBox
        CURR_CODELabel = New System.Windows.Forms.Label
        CURR_NAMELabel = New System.Windows.Forms.Label
        CURR_RATELabel = New System.Windows.Forms.Label
        Me.BrowsePage.SuspendLayout()
        Me.EditPage.SuspendLayout()
        Me.btnOKCancelPanel.SuspendLayout()
        Me.TabControl.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.EditPage.Controls.Add(CURR_CODELabel)
        Me.EditPage.Controls.Add(Me.CURR_CODETextBox)
        Me.EditPage.Controls.Add(CURR_NAMELabel)
        Me.EditPage.Controls.Add(Me.CURR_NAMETextBox)
        Me.EditPage.Controls.Add(CURR_RATELabel)
        Me.EditPage.Controls.Add(Me.CURR_RATETextBox)
        '
        'TabControl
        '
        Me.TabControl.Location = New System.Drawing.Point(0, 44)
        Me.TabControl.Size = New System.Drawing.Size(592, 479)
        '
        'CURR_CODELabel
        '
        CURR_CODELabel.AutoSize = True
        CURR_CODELabel.Location = New System.Drawing.Point(34, 19)
        CURR_CODELabel.Name = "CURR_CODELabel"
        CURR_CODELabel.Size = New System.Drawing.Size(65, 13)
        CURR_CODELabel.TabIndex = 0
        CURR_CODELabel.Text = "Currency# : "
        CURR_CODELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CURR_NAMELabel
        '
        CURR_NAMELabel.AutoSize = True
        CURR_NAMELabel.Location = New System.Drawing.Point(10, 45)
        CURR_NAMELabel.Name = "CURR_NAMELabel"
        CURR_NAMELabel.Size = New System.Drawing.Size(89, 13)
        CURR_NAMELabel.TabIndex = 2
        CURR_NAMELabel.Text = "Currency Name : "
        CURR_NAMELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CURR_RATELabel
        '
        CURR_RATELabel.AutoSize = True
        CURR_RATELabel.Location = New System.Drawing.Point(15, 71)
        CURR_RATELabel.Name = "CURR_RATELabel"
        CURR_RATELabel.Size = New System.Drawing.Size(84, 13)
        CURR_RATELabel.TabIndex = 4
        CURR_RATELabel.Text = "Currency Rate : "
        CURR_RATELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CSGLDataset
        '
        Me.CSGLDataset.DataSetName = "CSGLDataset"
        Me.CSGLDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_CURRENCYBindingSource
        '
        Me.MST_CURRENCYBindingSource.DataMember = "MST_CURRENCY"
        Me.MST_CURRENCYBindingSource.DataSource = Me.CSGLDataset
        '
        'BrowseGrid
        '
        Me.BrowseGrid.AutoGenerateColumns = False
        Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.BrowseGrid.DataSource = Me.MST_CURRENCYBindingSource
        Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
        Me.BrowseGrid.Name = "BrowseGrid"
        Me.BrowseGrid.ReadOnly = True
        Me.BrowseGrid.Size = New System.Drawing.Size(578, 444)
        Me.BrowseGrid.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CURR_CODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Currency#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CURR_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Currency Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CURR_RATE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Exchange Rate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CURR_CODETextBox
        '
        Me.CURR_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_CURRENCYBindingSource, "CURR_CODE", True))
        Me.CURR_CODETextBox.Location = New System.Drawing.Point(105, 16)
        Me.CURR_CODETextBox.Name = "CURR_CODETextBox"
        Me.CURR_CODETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CURR_CODETextBox.TabIndex = 1
        '
        'CURR_NAMETextBox
        '
        Me.CURR_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_CURRENCYBindingSource, "CURR_NAME", True))
        Me.CURR_NAMETextBox.Location = New System.Drawing.Point(105, 42)
        Me.CURR_NAMETextBox.Name = "CURR_NAMETextBox"
        Me.CURR_NAMETextBox.Size = New System.Drawing.Size(220, 20)
        Me.CURR_NAMETextBox.TabIndex = 3
        '
        'CURR_RATETextBox
        '
        Me.CURR_RATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MST_CURRENCYBindingSource, "CURR_RATE", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N4"))
        Me.CURR_RATETextBox.Location = New System.Drawing.Point(105, 68)
        Me.CURR_RATETextBox.Name = "CURR_RATETextBox"
        Me.CURR_RATETextBox.Size = New System.Drawing.Size(100, 20)
        Me.CURR_RATETextBox.TabIndex = 5
        Me.CURR_RATETextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FmCurrency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 523)
        Me.HelpProvider1.SetHelpKeyword(Me, "40200")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Name = "FmCurrency"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Currency Settings"
        Me.BrowsePage.ResumeLayout(False)
        Me.EditPage.ResumeLayout(False)
        Me.EditPage.PerformLayout()
        Me.btnOKCancelPanel.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents MST_CURRENCYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSGLDataset As CSAccountDatabaseIntf.CSGLDataset
    Friend WithEvents CURR_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CURR_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents CURR_RATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
