Public Class FmBLPLDlg
    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSAccRptDataset = CType(value, CSAccountDatabaseIntf.CSAccRptDataset)
            MSTACCREPORTBindingSource.DataSource = Dataset
            InitControls()
        End Set
    End Property

    Public Overrides Sub InitControls()
        MyBase.InitControls()
        ThisYear.Value = SystemInfo.BusinessPeriod.AccYear
        ThisMonth.Value = SystemInfo.BusinessPeriod.AccPeriod
        LastYear.Value = SystemInfo.BusinessPeriod.AccYear - 1
        LastMonth.Value = SystemInfo.BusinessPeriod.AccPeriod
    End Sub

    Private Sub FmProfitAndLostDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
