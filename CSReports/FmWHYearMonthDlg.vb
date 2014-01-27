Public Class FmWHYearMonthDlg
	Public Overrides Property Dataset() As DataSet
		Get
			Return MyBase.Dataset
		End Get
		Set(ByVal value As DataSet)
			MyBase.Dataset = value
			CSAccReporting = CType(value, CSAccountDatabaseIntf.CSAccReporting)
			MST_WAREHOUSEBindingSource.DataSource = Dataset
			InitControls()
		End Set
	End Property

	Public Overrides Sub InitControls()
		MyBase.InitControls()
		udYear.Value = SystemInfo.BusinessPeriod.AccYear
		udMonth.Value = SystemInfo.BusinessPeriod.AccPeriod
	End Sub

End Class
