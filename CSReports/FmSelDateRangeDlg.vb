Public Class FmSelDateRangeDlg
    Public Overrides Sub InitControls()
        MyBase.InitControls()
        FrDate.Value = SystemInfo.StartDate
        ToDate.Value = SystemInfo.EndDate
    End Sub
End Class
