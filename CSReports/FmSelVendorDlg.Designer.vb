<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSelVendorDlg
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
        Dim VENDOR_CODELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.CSAccReporting = New CSAccountDatabaseIntf.CSAccReporting
        Me.MST_VENDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrVendor = New System.Windows.Forms.ComboBox
        Me.ToVendor = New System.Windows.Forms.ComboBox
        Me.MST_VENDORBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        VENDOR_CODELabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_VENDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_VENDORBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(142, 67)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(215, 67)
        '
        'VENDOR_CODELabel
        '
        VENDOR_CODELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        VENDOR_CODELabel.AutoSize = True
        VENDOR_CODELabel.Location = New System.Drawing.Point(6, 15)
        VENDOR_CODELabel.Name = "VENDOR_CODELabel"
        VENDOR_CODELabel.Size = New System.Drawing.Size(62, 13)
        VENDOR_CODELabel.TabIndex = 4
        VENDOR_CODELabel.Text = "Fr Vendor : "
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(5, 41)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 13)
        Label1.TabIndex = 6
        Label1.Text = "To Vendor : "
        '
        'CSAccReporting
        '
        Me.CSAccReporting.DataSetName = "CSAccReporting"
        Me.CSAccReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MST_VENDORBindingSource
        '
        Me.MST_VENDORBindingSource.DataMember = "MST_VENDOR"
        Me.MST_VENDORBindingSource.DataSource = Me.CSAccReporting
        '
        'FrVendor
        '
        Me.FrVendor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrVendor.DataSource = Me.MST_VENDORBindingSource
        Me.FrVendor.DisplayMember = "VENDOR_NAME"
        Me.FrVendor.FormattingEnabled = True
        Me.FrVendor.Location = New System.Drawing.Point(74, 12)
        Me.FrVendor.Name = "FrVendor"
        Me.FrVendor.Size = New System.Drawing.Size(208, 21)
        Me.FrVendor.TabIndex = 5
        Me.FrVendor.ValueMember = "VENDOR_CODE"
        '
        'ToVendor
        '
        Me.ToVendor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToVendor.DataSource = Me.MST_VENDORBindingSource1
        Me.ToVendor.DisplayMember = "VENDOR_NAME"
        Me.ToVendor.FormattingEnabled = True
        Me.ToVendor.Location = New System.Drawing.Point(73, 38)
        Me.ToVendor.Name = "ToVendor"
        Me.ToVendor.Size = New System.Drawing.Size(208, 21)
        Me.ToVendor.TabIndex = 7
        Me.ToVendor.ValueMember = "VENDOR_CODE"
        '
        'MST_VENDORBindingSource1
        '
        Me.MST_VENDORBindingSource1.DataMember = "MST_VENDOR"
        Me.MST_VENDORBindingSource1.DataSource = Me.CSAccReporting
        '
        'FmSelVendorDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(289, 99)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ToVendor)
        Me.Controls.Add(VENDOR_CODELabel)
        Me.Controls.Add(Me.FrVendor)
        Me.Name = "FmSelVendorDlg"
        Me.Text = "Select Vendor"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.FrVendor, 0)
        Me.Controls.SetChildIndex(VENDOR_CODELabel, 0)
        Me.Controls.SetChildIndex(Me.ToVendor, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        CType(Me.CSAccReporting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_VENDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_VENDORBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CSAccReporting As CSAccountDatabaseIntf.CSAccReporting
    Friend WithEvents MST_VENDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrVendor As System.Windows.Forms.ComboBox
    Friend WithEvents ToVendor As System.Windows.Forms.ComboBox
    Friend WithEvents MST_VENDORBindingSource1 As System.Windows.Forms.BindingSource

End Class
