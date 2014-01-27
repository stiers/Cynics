<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmWHYearMonthDlg
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
		Dim WH_NAMELabel As System.Windows.Forms.Label
		Me.CSAccReporting = New CSAccountDatabaseIntf.CSAccReporting
		Me.MST_WAREHOUSEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.WH_NAMEComboBox = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.udYear = New System.Windows.Forms.NumericUpDown
		Me.udMonth = New System.Windows.Forms.NumericUpDown
		WH_NAMELabel = New System.Windows.Forms.Label
		CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MST_WAREHOUSEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.udYear, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.udMonth, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'OK_Button
		'
		Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OK_Button.Location = New System.Drawing.Point(258, 8)
		'
		'Cancel_Button
		'
		Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cancel_Button.Location = New System.Drawing.Point(258, 33)
		'
		'CSAccReporting
		'
		Me.CSAccReporting.DataSetName = "CSAccReporting"
		Me.CSAccReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MST_WAREHOUSEBindingSource
		'
		Me.MST_WAREHOUSEBindingSource.DataMember = "MST_WAREHOUSE"
		Me.MST_WAREHOUSEBindingSource.DataSource = Me.CSAccReporting
		'
		'WH_NAMELabel
		'
		WH_NAMELabel.AutoSize = True
		WH_NAMELabel.Location = New System.Drawing.Point(12, 15)
		WH_NAMELabel.Name = "WH_NAMELabel"
		WH_NAMELabel.Size = New System.Drawing.Size(71, 13)
		WH_NAMELabel.TabIndex = 4
		WH_NAMELabel.Text = "Warehouse : "
		'
		'WH_NAMEComboBox
		'
		Me.WH_NAMEComboBox.DataSource = Me.MST_WAREHOUSEBindingSource
		Me.WH_NAMEComboBox.DisplayMember = "WH_NAME"
		Me.WH_NAMEComboBox.FormattingEnabled = True
		Me.WH_NAMEComboBox.Location = New System.Drawing.Point(83, 12)
		Me.WH_NAMEComboBox.Name = "WH_NAMEComboBox"
		Me.WH_NAMEComboBox.Size = New System.Drawing.Size(162, 21)
		Me.WH_NAMEComboBox.TabIndex = 5
		Me.WH_NAMEComboBox.ValueMember = "WHNO"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(4, 42)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(79, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Year / Month : "
		'
		'udYear
		'
		Me.udYear.Location = New System.Drawing.Point(83, 38)
		Me.udYear.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
		Me.udYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
		Me.udYear.Name = "udYear"
		Me.udYear.Size = New System.Drawing.Size(78, 20)
		Me.udYear.TabIndex = 7
		Me.udYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
		'
		'udMonth
		'
		Me.udMonth.Location = New System.Drawing.Point(173, 38)
		Me.udMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
		Me.udMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.udMonth.Name = "udMonth"
		Me.udMonth.Size = New System.Drawing.Size(72, 20)
		Me.udMonth.TabIndex = 8
		Me.udMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'FmWHYearMonthDlg
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.ClientSize = New System.Drawing.Size(332, 86)
		Me.Controls.Add(Me.udMonth)
		Me.Controls.Add(Me.udYear)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(WH_NAMELabel)
		Me.Controls.Add(Me.WH_NAMEComboBox)
		Me.Name = "FmWHYearMonthDlg"
		Me.Text = "Warehouse Year Month"
		Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
		Me.Controls.SetChildIndex(Me.OK_Button, 0)
		Me.Controls.SetChildIndex(Me.WH_NAMEComboBox, 0)
		Me.Controls.SetChildIndex(WH_NAMELabel, 0)
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.udYear, 0)
		Me.Controls.SetChildIndex(Me.udMonth, 0)
		CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MST_WAREHOUSEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.udYear, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.udMonth, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents CSAccReporting As CSAccountDatabaseIntf.CSAccReporting
	Friend WithEvents MST_WAREHOUSEBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents WH_NAMEComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents udYear As System.Windows.Forms.NumericUpDown
	Friend WithEvents udMonth As System.Windows.Forms.NumericUpDown

End Class
