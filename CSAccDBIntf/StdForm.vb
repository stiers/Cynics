Imports CSCommon
Imports System.Windows.Forms
Public Class StdForm

    Public SystemInfo As CSCommon.CSSystemInfo
    Public Event AfterFormInit As EventHandler
    Private m_SystemManager As ICSAccountDatabaseIntf

    Public Overridable Property SystemManager() As ICSAccountDatabaseIntf
        Get
            Return m_SystemManager
        End Get
        Set(ByVal value As ICSAccountDatabaseIntf)
            m_SystemManager = value
        End Set
    End Property

    Public Overridable Sub CallAfterFormInit()
        RaiseEvent AfterFormInit(Me, New System.EventArgs)
    End Sub

    Private Sub StdForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HelpProvider1.HelpNamespace = Application.StartupPath + "\Cynics Accounting.chm"
    End Sub
End Class