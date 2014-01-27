Imports System.Windows.Forms
Imports CSAccountDatabaseIntf
Imports CSCommon

Public Class CSStdDlg

    Private m_Dataset As DataSet
    Overridable Property Dataset() As DataSet
        Get
            Return m_Dataset
        End Get
        Set(ByVal value As DataSet)
            m_Dataset = value
        End Set
    End Property

    Public SystemInfo As CSSystemInfo

    Public Overridable Sub InitControls()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
