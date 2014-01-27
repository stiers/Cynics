Public Class FmSelAccPeriodDlg
    Public Overrides Sub InitControls()
        MyBase.InitControls()
        AccYear.Value = SystemInfo.BusinessPeriod.AccYear
        AccMonth.Value = SystemInfo.BusinessPeriod.AccPeriod
    End Sub

End Class
