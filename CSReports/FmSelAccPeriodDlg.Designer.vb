<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSelAccPeriodDlg
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.AccYear = New System.Windows.Forms.NumericUpDown
        Me.AccMonth = New System.Windows.Forms.NumericUpDown
        CType(Me.AccYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Location = New System.Drawing.Point(71, 64)
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(144, 64)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Acc Year : "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Acc Period : "
        '
        'AccYear
        '
        Me.AccYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccYear.Location = New System.Drawing.Point(91, 12)
        Me.AccYear.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.AccYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.AccYear.Name = "AccYear"
        Me.AccYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccYear.Size = New System.Drawing.Size(120, 20)
        Me.AccYear.TabIndex = 6
        Me.AccYear.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'AccMonth
        '
        Me.AccMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccMonth.Location = New System.Drawing.Point(91, 35)
        Me.AccMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.AccMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.AccMonth.Name = "AccMonth"
        Me.AccMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccMonth.Size = New System.Drawing.Size(120, 20)
        Me.AccMonth.TabIndex = 7
        Me.AccMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FmSelAccPeriodDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(218, 96)
        Me.Controls.Add(Me.AccYear)
        Me.Controls.Add(Me.AccMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FmSelAccPeriodDlg"
        Me.Text = "Select Account Period"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.AccMonth, 0)
        Me.Controls.SetChildIndex(Me.AccYear, 0)
        Me.Controls.SetChildIndex(Me.Cancel_Button, 0)
        Me.Controls.SetChildIndex(Me.OK_Button, 0)
        CType(Me.AccYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AccYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents AccMonth As System.Windows.Forms.NumericUpDown

End Class
