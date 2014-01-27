<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmFilterAccAccTypeYearDlg
    Inherits CSGLedger.FmFilterAccTypeYearDlg

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
        Dim ACC_CODELabel As System.Windows.Forms.Label
        Me.MST_ACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Account = New System.Windows.Forms.ComboBox
        ACC_CODELabel = New System.Windows.Forms.Label
        CType(Me.ToYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSSummaryDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS_ACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ACC_TYPELabel
        '
        Me.ACC_TYPELabel.Location = New System.Drawing.Point(15, 18)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 71)
        '
        'AccType
        '
        Me.AccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccType.Location = New System.Drawing.Point(85, 15)
        Me.AccType.TabIndex = 0
        '
        'ToYear
        '
        Me.ToYear.Location = New System.Drawing.Point(170, 69)
        Me.ToYear.TabIndex = 3
        '
        'FrYear
        '
        Me.FrYear.Location = New System.Drawing.Point(85, 69)
        Me.FrYear.TabIndex = 2
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(110, 102)
        Me.OK_Button.TabIndex = 4
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(183, 102)
        Me.Cancel_Button.TabIndex = 5
        '
        'ACC_CODELabel
        '
        ACC_CODELabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ACC_CODELabel.AutoSize = True
        ACC_CODELabel.Location = New System.Drawing.Point(21, 45)
        ACC_CODELabel.Name = "ACC_CODELabel"
        ACC_CODELabel.Size = New System.Drawing.Size(56, 13)
        ACC_CODELabel.TabIndex = 8
        ACC_CODELabel.Text = "Account : "
        '
        'MST_ACCOUNTBindingSource
        '
        Me.MST_ACCOUNTBindingSource.DataMember = "MST_ACCOUNT"
        Me.MST_ACCOUNTBindingSource.DataSource = Me.CSSummaryDataset
        '
        'Account
        '
        Me.Account.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Account.DataSource = Me.MST_ACCOUNTBindingSource
        Me.Account.DisplayMember = "ACC_NAME"
        Me.Account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Account.FormattingEnabled = True
        Me.Account.Location = New System.Drawing.Point(85, 42)
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(165, 21)
        Me.Account.TabIndex = 1
        Me.Account.ValueMember = "ACC_CODE"
        '
        'FmFilterAccAccTypeYearDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(257, 134)
        Me.Controls.Add(ACC_CODELabel)
        Me.Controls.Add(Me.Account)
        Me.Name = "FmFilterAccAccTypeYearDlg"
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        Me.Controls.SetChildIndex(Me.AccType, 0)
        Me.Controls.SetChildIndex(Me.ACC_TYPELabel, 0)
        Me.Controls.SetChildIndex(Me.ToYear, 0)
        Me.Controls.SetChildIndex(Me.FrYear, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Account, 0)
        Me.Controls.SetChildIndex(ACC_CODELabel, 0)
        CType(Me.ToYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSSummaryDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS_ACCTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MST_ACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MST_ACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Account As System.Windows.Forms.ComboBox

End Class
