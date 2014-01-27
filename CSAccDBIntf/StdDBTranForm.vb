Public Class StdDBTranForm

    Private Sub StdDBTranForm_tsbtnEditClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.tsbtnEditClick
        TabControl.SelectedIndex = 1
    End Sub

    Private Sub StdDBTranForm_BeforeNewAndEdit(ByVal Sender As System.Object, ByVal e As CSAccountDatabaseIntf.BeforeAfterEditNewEventAgrs) Handles MyBase.BeforeNewAndEdit
        TabControl.SelectedIndex = 1
    End Sub

    Private Sub AfterSaveCancel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.AftertsbtnSaveclick, MyBase.AftertsbtnCancelClick
        TabControl.SelectedIndex = 0
    End Sub
End Class
