Public Class FmFilterAccAccTypeYearDlg
    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSSummaryDataset = CType(value, CSAccountDatabaseIntf.CSSummaryDataset)
            SYS_ACCTYPEBindingSource.DataSource = Dataset
            MST_ACCOUNTBindingSource.DataSource = Dataset
            InitControls()
        End Set
    End Property

    Private AllowFiltertype As Boolean = False
    Private Sub FmFilterAccAccTypeYearDlg_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        AllowFilterType = True
    End Sub

    Private Sub FmFilterAccAccTypeYearDlg_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        AllowFiltertype = False
    End Sub

    Private Sub AccType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccType.TextChanged
        If AllowFiltertype Then
            FilterAccType()
        End If
    End Sub

    Public Sub FilterAccType()
        If AccType.Text = "" Then
            MST_ACCOUNTBindingSource.Filter = ""
        Else
            MST_ACCOUNTBindingSource.Filter = "ACC_TYPE=" + CStr(AccType.SelectedValue)
            Account.SelectedText = ""
        End If
    End Sub

End Class
