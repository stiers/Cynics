<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CSRptPreview
    Inherits System.Windows.Forms.Form

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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportBLBudgetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.ReportBLBudgetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportBLBudgetBindingSource
        '
        Me.ReportBLBudgetBindingSource.DataMember = "ReportBLBudget"
        Me.ReportBLBudgetBindingSource.DataSource = GetType(CSAccountDatabaseIntf.CSAccReporting)
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CSAccReporting_ReportBLBudget"
        ReportDataSource1.Value = Me.ReportBLBudgetBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = ""
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(492, 423)
        Me.ReportViewer.TabIndex = 0
        Me.ReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        Me.ReportViewer.ZoomPercent = 125
        '
        'CSRptPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 423)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "CSRptPreview"
        Me.Text = "CSRptPreview"
        CType(Me.ReportBLBudgetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportBLBudgetBindingSource As System.Windows.Forms.BindingSource
End Class
