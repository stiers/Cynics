<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmGL
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
		Dim GNLJNLNOLabel As System.Windows.Forms.Label
		Dim JNL_DESCLabel As System.Windows.Forms.Label
		Dim JNL_DATELabel As System.Windows.Forms.Label
		Dim JNL_AMTLabel As System.Windows.Forms.Label
		Dim ACC_PERIODLabel As System.Windows.Forms.Label
		Dim ACC_YEARLabel As System.Windows.Forms.Label
		Dim CURR_CODELabel As System.Windows.Forms.Label
		Dim TOTAL_DEBITLabel As System.Windows.Forms.Label
		Dim JNL_CODELabel As System.Windows.Forms.Label
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.BrowseGrid = New System.Windows.Forms.DataGridView
		Me.GNLJNLNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JNL_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JNLDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JNLDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.JNLAMTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TRN_GNLJNLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CSGLDataset = New CSAccountDatabaseIntf.CSGLDataset
		Me.GNLJNLNOTextBox = New System.Windows.Forms.TextBox
		Me.JNL_DESCTextBox = New System.Windows.Forms.TextBox
		Me.JNL_DATEDateTimePicker = New System.Windows.Forms.DateTimePicker
		Me.JNL_AMTTextBox = New System.Windows.Forms.TextBox
		Me.TRN_GNLJNLDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TRN_GNLJNLDDataGridView = New System.Windows.Forms.DataGridView
		Me.ACC_AMT = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ACC_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.AccButtonColumn = New System.Windows.Forms.DataGridViewButtonColumn
		Me.ACC_NAME = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.MST_ACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.ACC_DEBIT = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ACC_CREDIT = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ACC_MEMO = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.TOTAL_DIFFLabel = New System.Windows.Forms.Label
		Me.TOTAL_DIFFLabel1 = New System.Windows.Forms.Label
		Me.ACC_YEARNumericUpDown = New System.Windows.Forms.NumericUpDown
		Me.ACC_PERIODNumericUpDown = New System.Windows.Forms.NumericUpDown
		Me.CURR_CODEComboBox = New System.Windows.Forms.ComboBox
		Me.MSTCURRENCYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CURR_RATELabel1 = New System.Windows.Forms.Label
		Me.TOTAL_DEBITLabel1 = New System.Windows.Forms.Label
		Me.TOTAL_CREDITLabel1 = New System.Windows.Forms.Label
		Me.btnCurrency = New System.Windows.Forms.Button
		Me.JNL_CODETextBox = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		GNLJNLNOLabel = New System.Windows.Forms.Label
		JNL_DESCLabel = New System.Windows.Forms.Label
		JNL_DATELabel = New System.Windows.Forms.Label
		JNL_AMTLabel = New System.Windows.Forms.Label
		ACC_PERIODLabel = New System.Windows.Forms.Label
		ACC_YEARLabel = New System.Windows.Forms.Label
		CURR_CODELabel = New System.Windows.Forms.Label
		TOTAL_DEBITLabel = New System.Windows.Forms.Label
		JNL_CODELabel = New System.Windows.Forms.Label
		Me.BrowsePage.SuspendLayout()
		Me.EditPage.SuspendLayout()
		Me.btnOKCancelPanel.SuspendLayout()
		Me.TabControl.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_GNLJNLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_GNLJNLDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TRN_GNLJNLDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ACC_PERIODNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTCURRENCYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
		Me.EditPage.AutoScroll = True
		Me.EditPage.Controls.Add(Me.Label2)
		Me.EditPage.Controls.Add(JNL_CODELabel)
		Me.EditPage.Controls.Add(Me.JNL_CODETextBox)
		Me.EditPage.Controls.Add(Me.btnCurrency)
		Me.EditPage.Controls.Add(Me.TOTAL_CREDITLabel1)
		Me.EditPage.Controls.Add(TOTAL_DEBITLabel)
		Me.EditPage.Controls.Add(Me.TOTAL_DEBITLabel1)
		Me.EditPage.Controls.Add(Me.CURR_RATELabel1)
		Me.EditPage.Controls.Add(CURR_CODELabel)
		Me.EditPage.Controls.Add(Me.CURR_CODEComboBox)
		Me.EditPage.Controls.Add(Me.ACC_PERIODNumericUpDown)
		Me.EditPage.Controls.Add(Me.ACC_YEARNumericUpDown)
		Me.EditPage.Controls.Add(ACC_PERIODLabel)
		Me.EditPage.Controls.Add(ACC_YEARLabel)
		Me.EditPage.Controls.Add(Me.TOTAL_DIFFLabel)
		Me.EditPage.Controls.Add(Me.TOTAL_DIFFLabel1)
		Me.EditPage.Controls.Add(Me.TRN_GNLJNLDDataGridView)
		Me.EditPage.Controls.Add(JNL_AMTLabel)
		Me.EditPage.Controls.Add(Me.JNL_AMTTextBox)
		Me.EditPage.Controls.Add(JNL_DATELabel)
		Me.EditPage.Controls.Add(Me.JNL_DATEDateTimePicker)
		Me.EditPage.Controls.Add(JNL_DESCLabel)
		Me.EditPage.Controls.Add(Me.JNL_DESCTextBox)
		Me.EditPage.Controls.Add(GNLJNLNOLabel)
		Me.EditPage.Controls.Add(Me.GNLJNLNOTextBox)
		'
		'TabControl
		'
		Me.TabControl.Location = New System.Drawing.Point(0, 44)
		Me.TabControl.Size = New System.Drawing.Size(592, 479)
		'
		'GNLJNLNOLabel
		'
		GNLJNLNOLabel.AutoSize = True
		GNLJNLNOLabel.Location = New System.Drawing.Point(14, 9)
		GNLJNLNOLabel.Name = "GNLJNLNOLabel"
		GNLJNLNOLabel.Size = New System.Drawing.Size(36, 13)
		GNLJNLNOLabel.TabIndex = 0
		GNLJNLNOLabel.Text = "Jnl# : "
		GNLJNLNOLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'JNL_DESCLabel
		'
		JNL_DESCLabel.AutoSize = True
		JNL_DESCLabel.Location = New System.Drawing.Point(5, 33)
		JNL_DESCLabel.Name = "JNL_DESCLabel"
		JNL_DESCLabel.Size = New System.Drawing.Size(45, 13)
		JNL_DESCLabel.TabIndex = 2
		JNL_DESCLabel.Text = "Memo : "
		JNL_DESCLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'JNL_DATELabel
		'
		JNL_DATELabel.AutoSize = True
		JNL_DATELabel.Location = New System.Drawing.Point(11, 60)
		JNL_DATELabel.Name = "JNL_DATELabel"
		JNL_DATELabel.Size = New System.Drawing.Size(39, 13)
		JNL_DATELabel.TabIndex = 4
		JNL_DATELabel.Text = "Date : "
		JNL_DATELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'JNL_AMTLabel
		'
		JNL_AMTLabel.AutoSize = True
		JNL_AMTLabel.Location = New System.Drawing.Point(10, 85)
		JNL_AMTLabel.Name = "JNL_AMTLabel"
		JNL_AMTLabel.Size = New System.Drawing.Size(40, 13)
		JNL_AMTLabel.TabIndex = 6
		JNL_AMTLabel.Text = "Total : "
		JNL_AMTLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'ACC_PERIODLabel
		'
		ACC_PERIODLabel.AutoSize = True
		ACC_PERIODLabel.Location = New System.Drawing.Point(266, 86)
		ACC_PERIODLabel.Name = "ACC_PERIODLabel"
		ACC_PERIODLabel.Size = New System.Drawing.Size(68, 13)
		ACC_PERIODLabel.TabIndex = 13
		ACC_PERIODLabel.Text = "Acc Period : "
		ACC_PERIODLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'ACC_YEARLabel
		'
		ACC_YEARLabel.AutoSize = True
		ACC_YEARLabel.Location = New System.Drawing.Point(274, 60)
		ACC_YEARLabel.Name = "ACC_YEARLabel"
		ACC_YEARLabel.Size = New System.Drawing.Size(60, 13)
		ACC_YEARLabel.TabIndex = 11
		ACC_YEARLabel.Text = "Acc Year : "
		ACC_YEARLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'CURR_CODELabel
		'
		CURR_CODELabel.AutoSize = True
		CURR_CODELabel.Location = New System.Drawing.Point(414, 33)
		CURR_CODELabel.Name = "CURR_CODELabel"
		CURR_CODELabel.Size = New System.Drawing.Size(65, 13)
		CURR_CODELabel.TabIndex = 15
		CURR_CODELabel.Text = "Currency# : "
		CURR_CODELabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TOTAL_DEBITLabel
		'
		TOTAL_DEBITLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		TOTAL_DEBITLabel.AutoSize = True
		TOTAL_DEBITLabel.Location = New System.Drawing.Point(239, 419)
		TOTAL_DEBITLabel.Name = "TOTAL_DEBITLabel"
		TOTAL_DEBITLabel.Size = New System.Drawing.Size(40, 13)
		TOTAL_DEBITLabel.TabIndex = 18
		TOTAL_DEBITLabel.Text = "Total : "
		TOTAL_DEBITLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'JNL_CODELabel
		'
		JNL_CODELabel.AutoSize = True
		JNL_CODELabel.Location = New System.Drawing.Point(175, 9)
		JNL_CODELabel.Name = "JNL_CODELabel"
		JNL_CODELabel.Size = New System.Drawing.Size(124, 13)
		JNL_CODELabel.TabIndex = 23
		JNL_CODELabel.Text = " Vourcher# / Cheque# : "
		'
		'BrowseGrid
		'
		Me.BrowseGrid.AutoGenerateColumns = False
		Me.BrowseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.BrowseGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GNLJNLNODataGridViewTextBoxColumn, Me.JNL_CODE, Me.JNLDESCDataGridViewTextBoxColumn, Me.JNLDATEDataGridViewTextBoxColumn, Me.JNLAMTDataGridViewTextBoxColumn})
		Me.BrowseGrid.DataSource = Me.TRN_GNLJNLBindingSource
		Me.BrowseGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.BrowseGrid.Location = New System.Drawing.Point(3, 3)
		Me.BrowseGrid.Name = "BrowseGrid"
		Me.BrowseGrid.ReadOnly = True
		Me.BrowseGrid.Size = New System.Drawing.Size(578, 444)
		Me.BrowseGrid.TabIndex = 0
		'
		'GNLJNLNODataGridViewTextBoxColumn
		'
		Me.GNLJNLNODataGridViewTextBoxColumn.DataPropertyName = "GNLJNLNO"
		DataGridViewCellStyle1.NullValue = Nothing
		Me.GNLJNLNODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
		Me.GNLJNLNODataGridViewTextBoxColumn.HeaderText = "Jnl#"
		Me.GNLJNLNODataGridViewTextBoxColumn.Name = "GNLJNLNODataGridViewTextBoxColumn"
		Me.GNLJNLNODataGridViewTextBoxColumn.ReadOnly = True
		'
		'JNL_CODE
		'
		Me.JNL_CODE.DataPropertyName = "JNL_CODE"
		Me.JNL_CODE.HeaderText = "Vourcher/Cheque"
		Me.JNL_CODE.Name = "JNL_CODE"
		Me.JNL_CODE.ReadOnly = True
		'
		'JNLDESCDataGridViewTextBoxColumn
		'
		Me.JNLDESCDataGridViewTextBoxColumn.DataPropertyName = "JNL_DESC"
		Me.JNLDESCDataGridViewTextBoxColumn.HeaderText = "Memo"
		Me.JNLDESCDataGridViewTextBoxColumn.Name = "JNLDESCDataGridViewTextBoxColumn"
		Me.JNLDESCDataGridViewTextBoxColumn.ReadOnly = True
		'
		'JNLDATEDataGridViewTextBoxColumn
		'
		Me.JNLDATEDataGridViewTextBoxColumn.DataPropertyName = "JNL_DATE"
		Me.JNLDATEDataGridViewTextBoxColumn.HeaderText = "Date"
		Me.JNLDATEDataGridViewTextBoxColumn.Name = "JNLDATEDataGridViewTextBoxColumn"
		Me.JNLDATEDataGridViewTextBoxColumn.ReadOnly = True
		'
		'JNLAMTDataGridViewTextBoxColumn
		'
		Me.JNLAMTDataGridViewTextBoxColumn.DataPropertyName = "JNL_AMT"
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle2.Format = "#,0.00;(#,0.00)"
		DataGridViewCellStyle2.NullValue = Nothing
		Me.JNLAMTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
		Me.JNLAMTDataGridViewTextBoxColumn.HeaderText = "Total Amount"
		Me.JNLAMTDataGridViewTextBoxColumn.Name = "JNLAMTDataGridViewTextBoxColumn"
		Me.JNLAMTDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TRN_GNLJNLBindingSource
		'
		Me.TRN_GNLJNLBindingSource.DataMember = "TRN_GNLJNL"
		Me.TRN_GNLJNLBindingSource.DataSource = Me.CSGLDataset
		'
		'CSGLDataset
		'
		Me.CSGLDataset.DataSetName = "CSGLDataset"
		Me.CSGLDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'GNLJNLNOTextBox
		'
		Me.GNLJNLNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "GNLJNLNO", True))
		Me.GNLJNLNOTextBox.Location = New System.Drawing.Point(56, 6)
		Me.GNLJNLNOTextBox.Name = "GNLJNLNOTextBox"
		Me.GNLJNLNOTextBox.Size = New System.Drawing.Size(87, 20)
		Me.GNLJNLNOTextBox.TabIndex = 0
		'
		'JNL_DESCTextBox
		'
		Me.JNL_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "JNL_DESC", True))
		Me.JNL_DESCTextBox.Location = New System.Drawing.Point(56, 30)
		Me.JNL_DESCTextBox.Name = "JNL_DESCTextBox"
		Me.JNL_DESCTextBox.Size = New System.Drawing.Size(349, 20)
		Me.JNL_DESCTextBox.TabIndex = 2
		'
		'JNL_DATEDateTimePicker
		'
		Me.JNL_DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_GNLJNLBindingSource, "JNL_DATE", True))
		Me.JNL_DATEDateTimePicker.Location = New System.Drawing.Point(56, 56)
		Me.JNL_DATEDateTimePicker.Name = "JNL_DATEDateTimePicker"
		Me.JNL_DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
		Me.JNL_DATEDateTimePicker.TabIndex = 3
		'
		'JNL_AMTTextBox
		'
		Me.JNL_AMTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "JNL_AMT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
		Me.JNL_AMTTextBox.Location = New System.Drawing.Point(56, 82)
		Me.JNL_AMTTextBox.Name = "JNL_AMTTextBox"
		Me.JNL_AMTTextBox.ReadOnly = True
		Me.JNL_AMTTextBox.Size = New System.Drawing.Size(200, 20)
		Me.JNL_AMTTextBox.TabIndex = 4
		Me.JNL_AMTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'TRN_GNLJNLDBindingSource
		'
		Me.TRN_GNLJNLDBindingSource.DataMember = "FK_TRN_GNLJNLD_GNLJNLNO"
		Me.TRN_GNLJNLDBindingSource.DataSource = Me.TRN_GNLJNLBindingSource
		'
		'TRN_GNLJNLDDataGridView
		'
		Me.TRN_GNLJNLDDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TRN_GNLJNLDDataGridView.AutoGenerateColumns = False
		Me.TRN_GNLJNLDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ACC_AMT, Me.ACC_CODE, Me.AccButtonColumn, Me.ACC_NAME, Me.ACC_DEBIT, Me.ACC_CREDIT, Me.ACC_MEMO})
		Me.TRN_GNLJNLDDataGridView.DataSource = Me.TRN_GNLJNLDBindingSource
		Me.TRN_GNLJNLDDataGridView.Location = New System.Drawing.Point(8, 126)
		Me.TRN_GNLJNLDDataGridView.Name = "TRN_GNLJNLDDataGridView"
		Me.TRN_GNLJNLDDataGridView.RowHeadersWidth = 15
		Me.TRN_GNLJNLDDataGridView.Size = New System.Drawing.Size(570, 282)
		Me.TRN_GNLJNLDDataGridView.TabIndex = 9
		'
		'ACC_AMT
		'
		Me.ACC_AMT.DataPropertyName = "ACC_AMT"
		DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
		DataGridViewCellStyle3.Format = "#,0.00;(#,0.00)"
		DataGridViewCellStyle3.NullValue = Nothing
		Me.ACC_AMT.DefaultCellStyle = DataGridViewCellStyle3
		Me.ACC_AMT.HeaderText = "Amount"
		Me.ACC_AMT.Name = "ACC_AMT"
		Me.ACC_AMT.Width = 70
		'
		'ACC_CODE
		'
		Me.ACC_CODE.DataPropertyName = "ACC_CODE"
		Me.ACC_CODE.HeaderText = "Acc#"
		Me.ACC_CODE.Name = "ACC_CODE"
		Me.ACC_CODE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ACC_CODE.Width = 60
		'
		'AccButtonColumn
		'
		Me.AccButtonColumn.HeaderText = ""
		Me.AccButtonColumn.Name = "AccButtonColumn"
		Me.AccButtonColumn.Text = "..."
		Me.AccButtonColumn.Width = 20
		'
		'ACC_NAME
		'
		Me.ACC_NAME.DataPropertyName = "ACC_CODE"
		Me.ACC_NAME.DataSource = Me.MST_ACCOUNTBindingSource
		DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.ACC_NAME.DefaultCellStyle = DataGridViewCellStyle4
		Me.ACC_NAME.DisplayMember = "ACC_NAME"
		Me.ACC_NAME.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.ACC_NAME.HeaderText = "Acc Name"
		Me.ACC_NAME.Name = "ACC_NAME"
		Me.ACC_NAME.ReadOnly = True
		Me.ACC_NAME.ValueMember = "ACC_CODE"
		Me.ACC_NAME.Width = 120
		'
		'MST_ACCOUNTBindingSource
		'
		Me.MST_ACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
		Me.MST_ACCOUNTBindingSource.DataSource = Me.CSGLDataset
		'
		'ACC_DEBIT
		'
		Me.ACC_DEBIT.DataPropertyName = "ACC_DEBIT"
		DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder
		DataGridViewCellStyle5.Format = "N2"
		DataGridViewCellStyle5.NullValue = Nothing
		Me.ACC_DEBIT.DefaultCellStyle = DataGridViewCellStyle5
		Me.ACC_DEBIT.HeaderText = "Debit"
		Me.ACC_DEBIT.Name = "ACC_DEBIT"
		Me.ACC_DEBIT.ReadOnly = True
		Me.ACC_DEBIT.Width = 70
		'
		'ACC_CREDIT
		'
		Me.ACC_CREDIT.DataPropertyName = "ACC_CREDIT"
		DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder
		DataGridViewCellStyle6.Format = "N2"
		DataGridViewCellStyle6.NullValue = Nothing
		Me.ACC_CREDIT.DefaultCellStyle = DataGridViewCellStyle6
		Me.ACC_CREDIT.HeaderText = "Credit"
		Me.ACC_CREDIT.Name = "ACC_CREDIT"
		Me.ACC_CREDIT.ReadOnly = True
		Me.ACC_CREDIT.Width = 70
		'
		'ACC_MEMO
		'
		Me.ACC_MEMO.DataPropertyName = "ACC_MEMO"
		Me.ACC_MEMO.HeaderText = "Memo"
		Me.ACC_MEMO.Name = "ACC_MEMO"
		Me.ACC_MEMO.Width = 130
		'
		'TOTAL_DIFFLabel
		'
		Me.TOTAL_DIFFLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TOTAL_DIFFLabel.AutoSize = True
		Me.TOTAL_DIFFLabel.Location = New System.Drawing.Point(440, 420)
		Me.TOTAL_DIFFLabel.Name = "TOTAL_DIFFLabel"
		Me.TOTAL_DIFFLabel.Size = New System.Drawing.Size(32, 13)
		Me.TOTAL_DIFFLabel.TabIndex = 9
		Me.TOTAL_DIFFLabel.Text = "Diff : "
		Me.TOTAL_DIFFLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TOTAL_DIFFLabel1
		'
		Me.TOTAL_DIFFLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TOTAL_DIFFLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TOTAL_DIFFLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "TOTAL_DIFF", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,0.00;(#,0.00)"))
		Me.TOTAL_DIFFLabel1.Location = New System.Drawing.Point(477, 416)
		Me.TOTAL_DIFFLabel1.Name = "TOTAL_DIFFLabel1"
		Me.TOTAL_DIFFLabel1.Size = New System.Drawing.Size(80, 20)
		Me.TOTAL_DIFFLabel1.TabIndex = 10
		Me.TOTAL_DIFFLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'ACC_YEARNumericUpDown
		'
		Me.ACC_YEARNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_GNLJNLBindingSource, "ACC_YEAR", True))
		Me.ACC_YEARNumericUpDown.Enabled = False
		Me.ACC_YEARNumericUpDown.Location = New System.Drawing.Point(340, 56)
		Me.ACC_YEARNumericUpDown.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
		Me.ACC_YEARNumericUpDown.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
		Me.ACC_YEARNumericUpDown.Name = "ACC_YEARNumericUpDown"
		Me.ACC_YEARNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ACC_YEARNumericUpDown.Size = New System.Drawing.Size(65, 20)
		Me.ACC_YEARNumericUpDown.TabIndex = 5
		Me.ACC_YEARNumericUpDown.Value = New Decimal(New Integer() {1900, 0, 0, 0})
		'
		'ACC_PERIODNumericUpDown
		'
		Me.ACC_PERIODNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TRN_GNLJNLBindingSource, "ACC_PERIOD", True))
		Me.ACC_PERIODNumericUpDown.Location = New System.Drawing.Point(340, 83)
		Me.ACC_PERIODNumericUpDown.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
		Me.ACC_PERIODNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.ACC_PERIODNumericUpDown.Name = "ACC_PERIODNumericUpDown"
		Me.ACC_PERIODNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ACC_PERIODNumericUpDown.Size = New System.Drawing.Size(65, 20)
		Me.ACC_PERIODNumericUpDown.TabIndex = 6
		Me.ACC_PERIODNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'CURR_CODEComboBox
		'
		Me.CURR_CODEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TRN_GNLJNLBindingSource, "CURR_CODE", True))
		Me.CURR_CODEComboBox.DataSource = Me.MSTCURRENCYBindingSource
		Me.CURR_CODEComboBox.DisplayMember = "CURR_NAME"
		Me.CURR_CODEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CURR_CODEComboBox.FormattingEnabled = True
		Me.CURR_CODEComboBox.Location = New System.Drawing.Point(412, 55)
		Me.CURR_CODEComboBox.Name = "CURR_CODEComboBox"
		Me.CURR_CODEComboBox.Size = New System.Drawing.Size(137, 21)
		Me.CURR_CODEComboBox.TabIndex = 7
		Me.CURR_CODEComboBox.ValueMember = "CURR_CODE"
		'
		'MSTCURRENCYBindingSource
		'
		Me.MSTCURRENCYBindingSource.DataMember = "MST_CURRENCY"
		Me.MSTCURRENCYBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSGLDataset)
		'
		'CURR_RATELabel1
		'
		Me.CURR_RATELabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CURR_RATELabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "CURR_RATE", True))
		Me.CURR_RATELabel1.Location = New System.Drawing.Point(414, 82)
		Me.CURR_RATELabel1.Name = "CURR_RATELabel1"
		Me.CURR_RATELabel1.Size = New System.Drawing.Size(162, 23)
		Me.CURR_RATELabel1.TabIndex = 5
		Me.CURR_RATELabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TOTAL_DEBITLabel1
		'
		Me.TOTAL_DEBITLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TOTAL_DEBITLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TOTAL_DEBITLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "TOTAL_DEBIT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,0.00;(#,0.00)"))
		Me.TOTAL_DEBITLabel1.Location = New System.Drawing.Point(284, 416)
		Me.TOTAL_DEBITLabel1.Name = "TOTAL_DEBITLabel1"
		Me.TOTAL_DEBITLabel1.Size = New System.Drawing.Size(69, 20)
		Me.TOTAL_DEBITLabel1.TabIndex = 19
		Me.TOTAL_DEBITLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'TOTAL_CREDITLabel1
		'
		Me.TOTAL_CREDITLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TOTAL_CREDITLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.TOTAL_CREDITLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "TOTAL_CREDIT", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,0.00;(#,0.00)"))
		Me.TOTAL_CREDITLabel1.Location = New System.Drawing.Point(361, 416)
		Me.TOTAL_CREDITLabel1.Name = "TOTAL_CREDITLabel1"
		Me.TOTAL_CREDITLabel1.Size = New System.Drawing.Size(69, 20)
		Me.TOTAL_CREDITLabel1.TabIndex = 21
		Me.TOTAL_CREDITLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'btnCurrency
		'
		Me.btnCurrency.Location = New System.Drawing.Point(551, 55)
		Me.btnCurrency.Name = "btnCurrency"
		Me.btnCurrency.Size = New System.Drawing.Size(25, 20)
		Me.btnCurrency.TabIndex = 8
		Me.btnCurrency.Text = "..."
		Me.btnCurrency.UseVisualStyleBackColor = True
		'
		'JNL_CODETextBox
		'
		Me.JNL_CODETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TRN_GNLJNLBindingSource, "JNL_CODE", True))
		Me.JNL_CODETextBox.Location = New System.Drawing.Point(305, 6)
		Me.JNL_CODETextBox.Name = "JNL_CODETextBox"
		Me.JNL_CODETextBox.Size = New System.Drawing.Size(100, 20)
		Me.JNL_CODETextBox.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.Label2.Location = New System.Drawing.Point(8, 111)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(396, 12)
		Me.Label2.TabIndex = 55
		Me.Label2.Text = "Please position to Acc# column and use keyboard <Space> key to activate select ac" & _
			"count dialog"
		'
		'FmGL
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(592, 523)
		Me.HelpProvider1.SetHelpKeyword(Me, "40100")
		Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
		Me.Name = "FmGL"
		Me.HelpProvider1.SetShowHelp(Me, True)
		Me.Text = "General Ledger"
		Me.BrowsePage.ResumeLayout(False)
		Me.EditPage.ResumeLayout(False)
		Me.EditPage.PerformLayout()
		Me.btnOKCancelPanel.ResumeLayout(False)
		Me.TabControl.ResumeLayout(False)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BrowseGrid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_GNLJNLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CSGLDataset, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_GNLJNLDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TRN_GNLJNLDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ACC_YEARNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ACC_PERIODNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTCURRENCYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents BrowseGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CSGLDataset As CSAccountDatabaseIntf.CSGLDataset
    Friend WithEvents JNL_AMTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JNL_DATEDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JNL_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GNLJNLNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TRN_GNLJNLDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRN_GNLJNLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MST_ACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOTAL_DIFFLabel1 As System.Windows.Forms.Label
    Friend WithEvents TOTAL_DIFFLabel As System.Windows.Forms.Label
    Friend WithEvents ACC_PERIODNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ACC_YEARNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TRN_GNLJNLDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CURR_CODEComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CURR_RATELabel1 As System.Windows.Forms.Label
    Friend WithEvents MSTCURRENCYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOTAL_CREDITLabel1 As System.Windows.Forms.Label
    Friend WithEvents TOTAL_DEBITLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents JNL_CODETextBox As System.Windows.Forms.TextBox
    Friend WithEvents GNLJNLNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JNL_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JNLDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JNLDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JNLAMTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ACC_AMT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACC_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccButtonColumn As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ACC_NAME As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ACC_DEBIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACC_CREDIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACC_MEMO As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
