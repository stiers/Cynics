<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSecurity
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
		Me.components = New System.ComponentModel.Container
		Dim USERIDLabel As System.Windows.Forms.Label
		Dim ROLENOLabel As System.Windows.Forms.Label
		Dim PasswordLabel As System.Windows.Forms.Label
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSecurity))
		Me.UserInfoPage = New System.Windows.Forms.TabPage
		Me.UserInfoSplitContainer = New System.Windows.Forms.SplitContainer
		Me.UserInfoView = New System.Windows.Forms.DataGridView
		Me.USERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.MSTUSERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CSSystemDBDataset = New CSAccountDatabaseIntf.CSSystemDBDataset
		Me.PasswordTextBox = New System.Windows.Forms.TextBox
		Me.ROLENOComboBox = New System.Windows.Forms.ComboBox
		Me.MSTROLESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.USERIDTextBox = New System.Windows.Forms.TextBox
		Me.RoleSettingsPage = New System.Windows.Forms.TabPage
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
		Me.MST_ROLESDataGridView = New System.Windows.Forms.DataGridView
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.MST_ROLEFORMDataGridView = New System.Windows.Forms.DataGridView
		Me.FORM_NAME = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.MSTFORMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ROLENODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.FORMNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ALLOWADDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOWEDTDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOWDELDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOWPRNDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
		Me.MST_ROLEFORMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOW_ADD = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOW_EDT = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOW_DEL = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ALLOW_PRN = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.Button1 = New System.Windows.Forms.Button
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.tsbtnSave = New System.Windows.Forms.ToolStripButton
		Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton
		USERIDLabel = New System.Windows.Forms.Label
		ROLENOLabel = New System.Windows.Forms.Label
		PasswordLabel = New System.Windows.Forms.Label
		Me.TabControl.SuspendLayout()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.UserInfoPage.SuspendLayout()
		Me.UserInfoSplitContainer.Panel1.SuspendLayout()
		Me.UserInfoSplitContainer.Panel2.SuspendLayout()
		Me.UserInfoSplitContainer.SuspendLayout()
		CType(Me.UserInfoView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTUSERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTROLESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RoleSettingsPage.SuspendLayout()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		CType(Me.MST_ROLESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_ROLEFORMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MSTFORMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ContextMenuStrip1.SuspendLayout()
		CType(Me.MST_ROLEFORMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.UserInfoPage)
		Me.TabControl.Controls.Add(Me.RoleSettingsPage)
		Me.TabControl.Location = New System.Drawing.Point(0, 44)
		Me.TabControl.Size = New System.Drawing.Size(592, 479)
		Me.TabControl.TabIndex = 1
		'
		'HelpProvider1
		'
		Me.HelpProvider1.HelpNamespace = "C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\Cynics Accounting.chm"
		'
		'USERIDLabel
		'
		USERIDLabel.AutoSize = True
		USERIDLabel.Location = New System.Drawing.Point(13, 11)
		USERIDLabel.Name = "USERIDLabel"
		USERIDLabel.Size = New System.Drawing.Size(46, 13)
		USERIDLabel.TabIndex = 0
		USERIDLabel.Text = "User ID:"
		'
		'ROLENOLabel
		'
		ROLENOLabel.AutoSize = True
		ROLENOLabel.Location = New System.Drawing.Point(13, 36)
		ROLENOLabel.Name = "ROLENOLabel"
		ROLENOLabel.Size = New System.Drawing.Size(32, 13)
		ROLENOLabel.TabIndex = 2
		ROLENOLabel.Text = "Role:"
		'
		'PasswordLabel
		'
		PasswordLabel.AutoSize = True
		PasswordLabel.Location = New System.Drawing.Point(13, 63)
		PasswordLabel.Name = "PasswordLabel"
		PasswordLabel.Size = New System.Drawing.Size(56, 13)
		PasswordLabel.TabIndex = 4
		PasswordLabel.Text = "Password:"
		'
		'UserInfoPage
		'
		Me.UserInfoPage.Controls.Add(Me.UserInfoSplitContainer)
		Me.UserInfoPage.Location = New System.Drawing.Point(4, 22)
		Me.UserInfoPage.Name = "UserInfoPage"
		Me.UserInfoPage.Padding = New System.Windows.Forms.Padding(3)
		Me.UserInfoPage.Size = New System.Drawing.Size(584, 453)
		Me.UserInfoPage.TabIndex = 0
		Me.UserInfoPage.Text = "User Info"
		Me.UserInfoPage.UseVisualStyleBackColor = True
		'
		'UserInfoSplitContainer
		'
		Me.UserInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
		Me.UserInfoSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.UserInfoSplitContainer.Location = New System.Drawing.Point(3, 3)
		Me.UserInfoSplitContainer.Name = "UserInfoSplitContainer"
		'
		'UserInfoSplitContainer.Panel1
		'
		Me.UserInfoSplitContainer.Panel1.Controls.Add(Me.UserInfoView)
		'
		'UserInfoSplitContainer.Panel2
		'
		Me.UserInfoSplitContainer.Panel2.AutoScroll = True
		Me.UserInfoSplitContainer.Panel2.Controls.Add(PasswordLabel)
		Me.UserInfoSplitContainer.Panel2.Controls.Add(Me.PasswordTextBox)
		Me.UserInfoSplitContainer.Panel2.Controls.Add(ROLENOLabel)
		Me.UserInfoSplitContainer.Panel2.Controls.Add(Me.ROLENOComboBox)
		Me.UserInfoSplitContainer.Panel2.Controls.Add(USERIDLabel)
		Me.UserInfoSplitContainer.Panel2.Controls.Add(Me.USERIDTextBox)
		Me.UserInfoSplitContainer.Size = New System.Drawing.Size(578, 447)
		Me.UserInfoSplitContainer.SplitterDistance = 212
		Me.UserInfoSplitContainer.TabIndex = 0
		'
		'UserInfoView
		'
		Me.UserInfoView.AllowUserToAddRows = False
		Me.UserInfoView.AllowUserToDeleteRows = False
		Me.UserInfoView.AutoGenerateColumns = False
		Me.UserInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.UserInfoView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USERIDDataGridViewTextBoxColumn})
		Me.UserInfoView.DataSource = Me.MSTUSERBindingSource
		Me.UserInfoView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.UserInfoView.Location = New System.Drawing.Point(0, 0)
		Me.UserInfoView.MultiSelect = False
		Me.UserInfoView.Name = "UserInfoView"
		Me.UserInfoView.ReadOnly = True
		Me.UserInfoView.Size = New System.Drawing.Size(212, 447)
		Me.UserInfoView.StandardTab = True
		Me.UserInfoView.TabIndex = 0
		'
		'USERIDDataGridViewTextBoxColumn
		'
		Me.USERIDDataGridViewTextBoxColumn.DataPropertyName = "USERID"
		Me.USERIDDataGridViewTextBoxColumn.HeaderText = "User ID"
		Me.USERIDDataGridViewTextBoxColumn.Name = "USERIDDataGridViewTextBoxColumn"
		Me.USERIDDataGridViewTextBoxColumn.ReadOnly = True
		Me.USERIDDataGridViewTextBoxColumn.Width = 150
		'
		'MSTUSERBindingSource
		'
		Me.MSTUSERBindingSource.DataMember = "MST_USER"
		Me.MSTUSERBindingSource.DataSource = Me.CSSystemDBDataset
		'
		'CSSystemDBDataset
		'
		Me.CSSystemDBDataset.DataSetName = "CSSystemDBDataset"
		Me.CSSystemDBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'PasswordTextBox
		'
		Me.PasswordTextBox.Location = New System.Drawing.Point(97, 60)
		Me.PasswordTextBox.Name = "PasswordTextBox"
		Me.PasswordTextBox.Size = New System.Drawing.Size(247, 20)
		Me.PasswordTextBox.TabIndex = 5
		'
		'ROLENOComboBox
		'
		Me.ROLENOComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MSTUSERBindingSource, "ROLENO", True))
		Me.ROLENOComboBox.DataSource = Me.MSTROLESBindingSource
		Me.ROLENOComboBox.DisplayMember = "ROLE_NAME"
		Me.ROLENOComboBox.FormattingEnabled = True
		Me.ROLENOComboBox.Location = New System.Drawing.Point(97, 33)
		Me.ROLENOComboBox.Name = "ROLENOComboBox"
		Me.ROLENOComboBox.Size = New System.Drawing.Size(247, 21)
		Me.ROLENOComboBox.TabIndex = 3
		Me.ROLENOComboBox.ValueMember = "ROLENO"
		'
		'MSTROLESBindingSource
		'
		Me.MSTROLESBindingSource.DataMember = "MST_ROLES"
		Me.MSTROLESBindingSource.DataSource = Me.CSSystemDBDataset
		'
		'USERIDTextBox
		'
		Me.USERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MSTUSERBindingSource, "USERID", True))
		Me.USERIDTextBox.Location = New System.Drawing.Point(97, 8)
		Me.USERIDTextBox.Name = "USERIDTextBox"
		Me.USERIDTextBox.Size = New System.Drawing.Size(247, 20)
		Me.USERIDTextBox.TabIndex = 1
		'
		'RoleSettingsPage
		'
		Me.RoleSettingsPage.Controls.Add(Me.SplitContainer1)
		Me.RoleSettingsPage.Location = New System.Drawing.Point(4, 22)
		Me.RoleSettingsPage.Name = "RoleSettingsPage"
		Me.RoleSettingsPage.Padding = New System.Windows.Forms.Padding(3)
		Me.RoleSettingsPage.Size = New System.Drawing.Size(584, 453)
		Me.RoleSettingsPage.TabIndex = 1
		Me.RoleSettingsPage.Text = "Role Settings"
		Me.RoleSettingsPage.UseVisualStyleBackColor = True
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.AutoScroll = True
		Me.SplitContainer1.Panel1.Controls.Add(Me.MST_ROLESDataGridView)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.MST_ROLEFORMDataGridView)
		Me.SplitContainer1.Size = New System.Drawing.Size(578, 447)
		Me.SplitContainer1.SplitterDistance = 215
		Me.SplitContainer1.TabIndex = 0
		'
		'MST_ROLESDataGridView
		'
		Me.MST_ROLESDataGridView.AllowUserToAddRows = False
		Me.MST_ROLESDataGridView.AllowUserToDeleteRows = False
		Me.MST_ROLESDataGridView.AutoGenerateColumns = False
		Me.MST_ROLESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
		Me.MST_ROLESDataGridView.DataSource = Me.MSTROLESBindingSource
		Me.MST_ROLESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MST_ROLESDataGridView.Location = New System.Drawing.Point(0, 0)
		Me.MST_ROLESDataGridView.MultiSelect = False
		Me.MST_ROLESDataGridView.Name = "MST_ROLESDataGridView"
		Me.MST_ROLESDataGridView.ReadOnly = True
		Me.MST_ROLESDataGridView.Size = New System.Drawing.Size(215, 447)
		Me.MST_ROLESDataGridView.StandardTab = True
		Me.MST_ROLESDataGridView.TabIndex = 0
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "ROLE_NAME"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Role Name"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		Me.DataGridViewTextBoxColumn2.Width = 150
		'
		'MST_ROLEFORMDataGridView
		'
		Me.MST_ROLEFORMDataGridView.AllowUserToAddRows = False
		Me.MST_ROLEFORMDataGridView.AllowUserToDeleteRows = False
		Me.MST_ROLEFORMDataGridView.AutoGenerateColumns = False
		Me.MST_ROLEFORMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FORM_NAME, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.ROLENODataGridViewTextBoxColumn, Me.FORMNODataGridViewTextBoxColumn, Me.ALLOWADDDataGridViewCheckBoxColumn, Me.ALLOWEDTDataGridViewCheckBoxColumn, Me.ALLOWDELDataGridViewCheckBoxColumn, Me.ALLOWPRNDataGridViewCheckBoxColumn})
		Me.MST_ROLEFORMDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
		Me.MST_ROLEFORMDataGridView.DataSource = Me.MST_ROLEFORMBindingSource
		Me.MST_ROLEFORMDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.MST_ROLEFORMDataGridView.Location = New System.Drawing.Point(0, 0)
		Me.MST_ROLEFORMDataGridView.MultiSelect = False
		Me.MST_ROLEFORMDataGridView.Name = "MST_ROLEFORMDataGridView"
		Me.MST_ROLEFORMDataGridView.ReadOnly = True
		Me.MST_ROLEFORMDataGridView.Size = New System.Drawing.Size(359, 447)
		Me.MST_ROLEFORMDataGridView.StandardTab = True
		Me.MST_ROLEFORMDataGridView.TabIndex = 0
		'
		'FORM_NAME
		'
		Me.FORM_NAME.DataPropertyName = "FORMNO"
		Me.FORM_NAME.DataSource = Me.MSTFORMSBindingSource
		Me.FORM_NAME.DisplayMember = "FORM_NAME"
		Me.FORM_NAME.HeaderText = "Form Name"
		Me.FORM_NAME.Name = "FORM_NAME"
		Me.FORM_NAME.ReadOnly = True
		Me.FORM_NAME.ValueMember = "FORMNO"
		Me.FORM_NAME.Width = 180
		'
		'MSTFORMSBindingSource
		'
		Me.MSTFORMSBindingSource.DataMember = "MST_FORMS"
		Me.MSTFORMSBindingSource.DataSource = Me.CSSystemDBDataset
		'
		'DataGridViewCheckBoxColumn5
		'
		Me.DataGridViewCheckBoxColumn5.DataPropertyName = "ALLOW_ADD"
		Me.DataGridViewCheckBoxColumn5.HeaderText = "Add"
		Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
		Me.DataGridViewCheckBoxColumn5.ReadOnly = True
		Me.DataGridViewCheckBoxColumn5.Width = 30
		'
		'DataGridViewCheckBoxColumn6
		'
		Me.DataGridViewCheckBoxColumn6.DataPropertyName = "ALLOW_EDT"
		Me.DataGridViewCheckBoxColumn6.HeaderText = "Edit"
		Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
		Me.DataGridViewCheckBoxColumn6.ReadOnly = True
		Me.DataGridViewCheckBoxColumn6.Width = 30
		'
		'DataGridViewCheckBoxColumn7
		'
		Me.DataGridViewCheckBoxColumn7.DataPropertyName = "ALLOW_DEL"
		Me.DataGridViewCheckBoxColumn7.HeaderText = "Del"
		Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
		Me.DataGridViewCheckBoxColumn7.ReadOnly = True
		Me.DataGridViewCheckBoxColumn7.Width = 30
		'
		'DataGridViewCheckBoxColumn8
		'
		Me.DataGridViewCheckBoxColumn8.DataPropertyName = "ALLOW_PRN"
		Me.DataGridViewCheckBoxColumn8.HeaderText = "Print"
		Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
		Me.DataGridViewCheckBoxColumn8.ReadOnly = True
		Me.DataGridViewCheckBoxColumn8.Width = 30
		'
		'ROLENODataGridViewTextBoxColumn
		'
		Me.ROLENODataGridViewTextBoxColumn.DataPropertyName = "ROLENO"
		Me.ROLENODataGridViewTextBoxColumn.HeaderText = "ROLENO"
		Me.ROLENODataGridViewTextBoxColumn.Name = "ROLENODataGridViewTextBoxColumn"
		Me.ROLENODataGridViewTextBoxColumn.ReadOnly = True
		Me.ROLENODataGridViewTextBoxColumn.Visible = False
		'
		'FORMNODataGridViewTextBoxColumn
		'
		Me.FORMNODataGridViewTextBoxColumn.DataPropertyName = "FORMNO"
		Me.FORMNODataGridViewTextBoxColumn.HeaderText = "FORMNO"
		Me.FORMNODataGridViewTextBoxColumn.Name = "FORMNODataGridViewTextBoxColumn"
		Me.FORMNODataGridViewTextBoxColumn.ReadOnly = True
		Me.FORMNODataGridViewTextBoxColumn.Visible = False
		'
		'ALLOWADDDataGridViewCheckBoxColumn
		'
		Me.ALLOWADDDataGridViewCheckBoxColumn.DataPropertyName = "ALLOW_ADD"
		Me.ALLOWADDDataGridViewCheckBoxColumn.HeaderText = "ALLOW_ADD"
		Me.ALLOWADDDataGridViewCheckBoxColumn.Name = "ALLOWADDDataGridViewCheckBoxColumn"
		Me.ALLOWADDDataGridViewCheckBoxColumn.ReadOnly = True
		Me.ALLOWADDDataGridViewCheckBoxColumn.Visible = False
		'
		'ALLOWEDTDataGridViewCheckBoxColumn
		'
		Me.ALLOWEDTDataGridViewCheckBoxColumn.DataPropertyName = "ALLOW_EDT"
		Me.ALLOWEDTDataGridViewCheckBoxColumn.HeaderText = "ALLOW_EDT"
		Me.ALLOWEDTDataGridViewCheckBoxColumn.Name = "ALLOWEDTDataGridViewCheckBoxColumn"
		Me.ALLOWEDTDataGridViewCheckBoxColumn.ReadOnly = True
		Me.ALLOWEDTDataGridViewCheckBoxColumn.Visible = False
		'
		'ALLOWDELDataGridViewCheckBoxColumn
		'
		Me.ALLOWDELDataGridViewCheckBoxColumn.DataPropertyName = "ALLOW_DEL"
		Me.ALLOWDELDataGridViewCheckBoxColumn.HeaderText = "ALLOW_DEL"
		Me.ALLOWDELDataGridViewCheckBoxColumn.Name = "ALLOWDELDataGridViewCheckBoxColumn"
		Me.ALLOWDELDataGridViewCheckBoxColumn.ReadOnly = True
		Me.ALLOWDELDataGridViewCheckBoxColumn.Visible = False
		'
		'ALLOWPRNDataGridViewCheckBoxColumn
		'
		Me.ALLOWPRNDataGridViewCheckBoxColumn.DataPropertyName = "ALLOW_PRN"
		Me.ALLOWPRNDataGridViewCheckBoxColumn.HeaderText = "ALLOW_PRN"
		Me.ALLOWPRNDataGridViewCheckBoxColumn.Name = "ALLOWPRNDataGridViewCheckBoxColumn"
		Me.ALLOWPRNDataGridViewCheckBoxColumn.ReadOnly = True
		Me.ALLOWPRNDataGridViewCheckBoxColumn.Visible = False
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 26)
		'
		'AddItemToolStripMenuItem
		'
		Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
		Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
		Me.AddItemToolStripMenuItem.Text = "Add Forms"
		'
		'MST_ROLEFORMBindingSource
		'
		Me.MST_ROLEFORMBindingSource.DataMember = "FK_MST_ROLEFORM_MST_ROLES"
		Me.MST_ROLEFORMBindingSource.DataSource = Me.MSTROLESBindingSource
		'
		'DataGridViewCheckBoxColumn1
		'
		Me.DataGridViewCheckBoxColumn1.DataPropertyName = "ALLOW_ADD"
		Me.DataGridViewCheckBoxColumn1.HeaderText = "Add"
		Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
		Me.DataGridViewCheckBoxColumn1.Width = 30
		'
		'DataGridViewCheckBoxColumn2
		'
		Me.DataGridViewCheckBoxColumn2.DataPropertyName = "ALLOW_EDT"
		Me.DataGridViewCheckBoxColumn2.HeaderText = "Edit"
		Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
		Me.DataGridViewCheckBoxColumn2.Width = 30
		'
		'DataGridViewCheckBoxColumn3
		'
		Me.DataGridViewCheckBoxColumn3.DataPropertyName = "ALLOW_DEL"
		Me.DataGridViewCheckBoxColumn3.HeaderText = "Del"
		Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
		Me.DataGridViewCheckBoxColumn3.Width = 30
		'
		'DataGridViewCheckBoxColumn4
		'
		Me.DataGridViewCheckBoxColumn4.DataPropertyName = "ALLOW_PRN"
		Me.DataGridViewCheckBoxColumn4.HeaderText = "Print"
		Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
		Me.DataGridViewCheckBoxColumn4.Width = 30
		'
		'ALLOW_ADD
		'
		Me.ALLOW_ADD.DataPropertyName = "ALLOW_ADD"
		Me.ALLOW_ADD.HeaderText = "Add"
		Me.ALLOW_ADD.Name = "ALLOW_ADD"
		'
		'ALLOW_EDT
		'
		Me.ALLOW_EDT.DataPropertyName = "ALLOW_EDT"
		Me.ALLOW_EDT.HeaderText = "Edit"
		Me.ALLOW_EDT.Name = "ALLOW_EDT"
		'
		'ALLOW_DEL
		'
		Me.ALLOW_DEL.DataPropertyName = "ALLOW_DEL"
		Me.ALLOW_DEL.HeaderText = "Del"
		Me.ALLOW_DEL.Name = "ALLOW_DEL"
		'
		'ALLOW_PRN
		'
		Me.ALLOW_PRN.DataPropertyName = "ALLOW_PRN"
		Me.ALLOW_PRN.HeaderText = "Print"
		Me.ALLOW_PRN.Name = "ALLOW_PRN"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(50, 32)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Fuchsia
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'tsbtnSave
		'
		Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbtnSave.Name = "tsbtnSave"
		Me.tsbtnSave.Size = New System.Drawing.Size(23, 22)
		Me.tsbtnSave.Text = "ToolStripButton1"
		Me.tsbtnSave.ToolTipText = "Save Data"
		'
		'tsbtnCancel
		'
		Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.tsbtnCancel.Name = "tsbtnCancel"
		Me.tsbtnCancel.Size = New System.Drawing.Size(23, 22)
		Me.tsbtnCancel.Text = "ToolStripButton2"
		Me.tsbtnCancel.ToolTipText = "Cancel Changes"
		'
		'FmSecurity
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(592, 523)
		Me.HelpProvider1.SetHelpKeyword(Me, "30100")
		Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
		Me.Name = "FmSecurity"
		Me.HelpProvider1.SetShowHelp(Me, True)
		Me.Text = "Security Settings"
		Me.Controls.SetChildIndex(Me.TabControl, 0)
		Me.TabControl.ResumeLayout(False)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.UserInfoPage.ResumeLayout(False)
		Me.UserInfoSplitContainer.Panel1.ResumeLayout(False)
		Me.UserInfoSplitContainer.Panel2.ResumeLayout(False)
		Me.UserInfoSplitContainer.Panel2.PerformLayout()
		Me.UserInfoSplitContainer.ResumeLayout(False)
		CType(Me.UserInfoView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTUSERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CSSystemDBDataset, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTROLESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RoleSettingsPage.ResumeLayout(False)
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		Me.SplitContainer1.ResumeLayout(False)
		CType(Me.MST_ROLESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_ROLEFORMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSTFORMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ContextMenuStrip1.ResumeLayout(False)
		CType(Me.MST_ROLEFORMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents UserInfoPage As System.Windows.Forms.TabPage
    Friend WithEvents RoleSettingsPage As System.Windows.Forms.TabPage
    Friend WithEvents UserInfoSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents UserInfoView As System.Windows.Forms.DataGridView
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ROLENOComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents USERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MSTUSERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MSTROLESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MST_ROLESDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MST_ROLEFORMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MST_ROLEFORMDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MSTFORMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOW_ADD As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOW_EDT As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOW_DEL As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOW_PRN As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CSSystemDBDataset As CSAccountDatabaseIntf.CSSystemDBDataset
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Public WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORM_NAME As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ROLENODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORMNODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALLOWADDDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOWEDTDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOWDELDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ALLOWPRNDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tsbtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnCancel As System.Windows.Forms.ToolStripButton
End Class
