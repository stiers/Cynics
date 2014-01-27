Public Class FmFilterAccTypeYearDlg
    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSSummaryDataset = CType(value, CSAccountDatabaseIntf.CSSummaryDataset)
            SYS_ACCTYPEBindingSource.DataSource = Dataset
            InitControls()
        End Set
    End Property

    Public Overrides Sub InitControls()
        MyBase.InitControls()
        FrYear.Value = SystemInfo.BusinessPeriod.AccYear - 1
        ToYear.Value = SystemInfo.BusinessPeriod.AccYear
    End Sub
End Class
