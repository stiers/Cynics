<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAccountDlg
    Inherits CSAccountDatabaseIntf.CSStdDlg

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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView
		Me.ACCCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ACCNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.ACCTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
		Me.SYSACCTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.ISACTIVEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.MST_ACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CSAccountDataset = New CSAccountDatabaseIntf.CSAccountDataset
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.TextBox1 = New System.Windows.Forms.TextBox
		Me.rbAccountCode = New System.Windows.Forms.RadioButton
		Me.rbAccountName = New System.Windows.Forms.RadioButton
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SYSACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CSAccountDataset, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OK_Button
		'
		Me.OK_Button.Location = New System.Drawing.Point(480, 344)
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Location = New System.Drawing.Point(553, 344)
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ACCCODEDataGridViewTextBoxColumn, Me.ACCNAMEDataGridViewTextBoxColumn, Me.ACCTYPEDataGridViewTextBoxColumn, Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn, Me.ISACTIVEDataGridViewCheckBoxColumn})
		Me.DataGridView1.DataSource = Me.MST_ACCOUNTBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(16, 74)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RowHeadersWidth = 10
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(603, 259)
		Me.DataGridView1.TabIndex = 10
		'
		'ACCCODEDataGridViewTextBoxColumn
		'
		Me.ACCCODEDataGridViewTextBoxColumn.DataPropertyName = "ACC_CODE"
		Me.ACCCODEDataGridViewTextBoxColumn.HeaderText = "Account#"
		Me.ACCCODEDataGridViewTextBoxColumn.Name = "ACCCODEDataGridViewTextBoxColumn"
		Me.ACCCODEDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ACCNAMEDataGridViewTextBoxColumn
		'
		Me.ACCNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACC_NAME"
		Me.ACCNAMEDataGridViewTextBoxColumn.HeaderText = "Account Name"
		Me.ACCNAMEDataGridViewTextBoxColumn.Name = "ACCNAMEDataGridViewTextBoxColumn"
		Me.ACCNAMEDataGridViewTextBoxColumn.ReadOnly = True
		Me.ACCNAMEDataGridViewTextBoxColumn.Width = 150
		'
		'ACCTYPEDataGridViewTextBoxColumn
		'
		Me.ACCTYPEDataGridViewTextBoxColumn.DataPropertyName = "ACC_TYPE"
		Me.ACCTYPEDataGridViewTextBoxColumn.DataSource = Me.SYSACCTYPEBindingSource
		Me.ACCTYPEDataGridViewTextBoxColumn.DisplayMember = "TYPE_NAME"
		Me.ACCTYPEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
		Me.ACCTYPEDataGridViewTextBoxColumn.HeaderText = "Account type"
		Me.ACCTYPEDataGridViewTextBoxColumn.Name = "ACCTYPEDataGridViewTextBoxColumn"
		Me.ACCTYPEDataGridViewTextBoxColumn.ReadOnly = True
		Me.ACCTYPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.ACCTYPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
		Me.ACCTYPEDataGridViewTextBoxColumn.ValueMember = "ACC_TYPE"
		'
		'SYSACCTYPEBindingSource
		'
		Me.SYSACCTYPEBindingSource.DataMember = "SYS_ACCTYPE"
		Me.SYSACCTYPEBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSAccountDataset)
		'
		'RETAINEDEARNINGSDataGridViewCheckBoxColumn
		'
		Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn.DataPropertyName = "RETAINED_EARNINGS"
		Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn.HeaderText = "Retained Earnings"
		Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn.Name = "RETAINEDEARNINGSDataGridViewCheckBoxColumn"
		Me.RETAINEDEARNINGSDataGridViewCheckBoxColumn.ReadOnly = True
		'
		'ISACTIVEDataGridViewCheckBoxColumn
		'
		Me.ISACTIVEDataGridViewCheckBoxColumn.DataPropertyName = "IS_ACTIVE"
		Me.ISACTIVEDataGridViewCheckBoxColumn.HeaderText = "Active"
		Me.ISACTIVEDataGridViewCheckBoxColumn.Name = "ISACTIVEDataGridViewCheckBoxColumn"
		Me.ISACTIVEDataGridViewCheckBoxColumn.ReadOnly = True
		Me.ISACTIVEDataGridViewCheckBoxColumn.Width = 80
		'
		'MST_ACCOUNTBindingSource
		'
		Me.MST_ACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
		Me.MST_ACCOUNTBindingSource.DataSource = Me.CSAccountDataset
		'
		'CSAccountDataset
		'
		Me.CSAccountDataset.DataSetName = "CSAccountDataset"
		Me.CSAccountDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(14, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(50, 13)
		Me.Label1.TabIndex = 11
		Me.Label1.Text = "Search : "
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
		Me.Label2.Location = New System.Drawing.Point(18, 58)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(359, 13)
		Me.Label2.TabIndex = 14
		Me.Label2.Text = "Type the search word then <ctrl+spacebar> to start search"
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Location = New System.Drawing.Point(70, 35)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(549, 20)
		Me.TextBox1.TabIndex = 9
		'
		'rbAccountCode
		'
		Me.rbAccountCode.AutoSize = True
		Me.rbAccountCode.Checked = True
		Me.rbAccountCode.Location = New System.Drawing.Point(73, 12)
		Me.rbAccountCode.Name = "rbAccountCode"
		Me.rbAccountCode.Size = New System.Drawing.Size(114, 17)
		Me.rbAccountCode.TabIndex = 12
		Me.rbAccountCode.TabStop = True
		Me.rbAccountCode.Text = "[Ctrl+1] - Account#"
		Me.rbAccountCode.UseVisualStyleBackColor = True
		'
		'rbAccountName
		'
		Me.rbAccountName.AutoSize = True
		Me.rbAccountName.Location = New System.Drawing.Point(198, 12)
		Me.rbAccountName.Name = "rbAccountName"
		Me.rbAccountName.Size = New System.Drawing.Size(138, 17)
		Me.rbAccountName.TabIndex = 13
		Me.rbAccountName.Text = "[Ctrl+2] - Account Name"
		Me.rbAccountName.UseVisualStyleBackColor = True
		'
		'FmAccountDlg
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(627, 376)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.rbAccountCode)
		Me.Controls.Add(Me.rbAccountName)
		Me.KeyPreview = True
		Me.Name = "FmAccountDlg"
		Me.Text = "Search Account"
		Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
		Me.Controls.SetChildIndex(Me.OK_Button, 0)
		Me.Controls.SetChildIndex(Me.rbAccountName, 0)
		Me.Controls.SetChildIndex(Me.rbAccountCode, 0)
		Me.Controls.SetChildIndex(Me.TextBox1, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.DataGridView1, 0)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SYSACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CSAccountDataset, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rbAccountCode As System.Windows.Forms.RadioButton
    Friend WithEvents rbAccountName As System.Windows.Forms.RadioButton
    Friend WithEvents MST_ACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CSAccountDataset As CSAccountDatabaseIntf.CSAccountDataset
    Friend WithEvents ACCCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SYSACCTYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RETAINEDEARNINGSDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ISACTIVEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
