Public Class FmSelVendorDlg
    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSAccReporting = CType(value, CSAccountDatabaseIntf.CSAccReporting)
            MST_VENDORBindingSource.DataSource = Dataset
            MST_VENDORBindingSource1.DataSource = Dataset
            InitControls()
        End Set
    End Property

    Public Overrides Sub InitControls()
        MyBase.InitControls()
        MST_VENDORBindingSource1.Position = MST_VENDORBindingSource1.Count
    End Sub

End Class
