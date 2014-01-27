Imports System.Windows.forms

Public Class StdDBTabForm

    Private Sub TabControl_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles TabControl.Selecting
        If NeedSave Then
            If MessageBox.Show("Data not save, save now ?", "Save data", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                tsbtnSave_Click(tsbtnSave, Nothing)
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class
