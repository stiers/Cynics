Imports CSCommon
Imports System.Collections.Specialized
Imports CSAccountDatabaseIntf
Public Class FmLoginDlg

    Private NeedCloseScriptEngine As Boolean = False

    Private MyCrypto As CSSimpleCrypto = New CSSimpleCrypto

    Private m_UserNo As Integer
    Public ReadOnly Property UserNo() As Integer
        Get
            Return m_UserNo
        End Get
    End Property

    Private m_RoleNo As Integer
    Public ReadOnly Property RoleNo() As Integer
        Get
            Return m_RoleNo
        End Get
    End Property

    Public Overrides Property Dataset() As DataSet
        Get
            Return MyBase.Dataset
        End Get
        Set(ByVal value As DataSet)
            MyBase.Dataset = value
            CSSystemDBDataset = CType(value, CSAccountDatabaseIntf.CSSystemDBDataset)
            InitControls()
        End Set
    End Property

    Public Overrides Sub InitControls()
        MyBase.InitControls()

        BusinessDate.Value = Today
        StartDate.Value = Today.AddDays(-My.Settings.DEFAULT_VIEW_PERIOD)
        EndDate.Value = Today
    End Sub

    Private m_SystemManager As ICSAccountDatabaseIntf
    Public Property SystemManager() As ICSAccountDatabaseIntf
        Get
            Return m_SystemManager
        End Get
        Set(ByVal value As ICSAccountDatabaseIntf)
            m_SystemManager = value
            CompsDBs = m_SystemManager.GetCompsDBs
            CompDBBindingSource.DataSource = CompsDBs
            Dim MyRow As DataRow = CompsDBs.CompDB.FindByCompName(My.Settings.DEFAULT_COMP)
            If MyRow IsNot Nothing Then
                cmbCompany.SelectedValue = CStr(MyRow("DBName"))
            End If
        End Set
    End Property

    Private ValidYear As Int16
    Private ValidStartMonth As Int16

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
		If cmbCompany.SelectedValue Is Nothing Then
#If CSDebug = False Then
            MsgBox("Please select a company to connect !")
            Exit Sub
#End If
		Else
			SystemManager.SetConnectionStr(CStr(cmbCompany.SelectedValue))
		End If

        Try
            SystemManager.LoadCSSystemDBDataset()
        Catch Ex As Exception
            If TypeOf Ex Is System.Net.Sockets.SocketException Then
                MsgBox("Server inactive or no network connection !")
                Exit Sub
            End If
            Throw Ex
        End Try

        CSSystemDBDataset = SystemManager.GetCSSystemDBDataset

        Dim CompRow As DataRow
        If CSSystemDBDataset.MST_COMPANY.Rows.Count > 0 Then
            CompRow = CSSystemDBDataset.MST_COMPANY.Rows(0)
            ValidYear = CShort(CompRow("ACC_YEAR"))
            ValidStartMonth = CShort(CompRow("START_MONTH"))
        Else
            ValidYear = CShort(BusinessDate.Value.Year)
            ValidStartMonth = 1
        End If
        SystemInfo.GenerateAccPeriod(ValidYear, ValidStartMonth)
        SystemInfo.BusinessDate = BusinessDate.Value
        SystemInfo.StartDate = StartDate.Value
        SystemInfo.EndDate = EndDate.Value


        If SystemInfo.BusinessPeriod.AccYear = 0 Then
            MsgBox("Business date out of range, Valid Acc Year is " + CStr(ValidYear))
            Exit Sub
        End If

        If ValidateUser() Then
            Me.DialogResult = DialogResult.OK
            My.Settings.DEFAULT_COMP = cmbCompany.Text
            My.Settings.Save()
            SystemManager.CloseScriptEngineDatabase()
        Else
            Me.DialogResult = DialogResult.None
        End If
    End Sub

    Private Function ValidateUser() As Boolean
        Dim MyUsers() As DataRow = CSSystemDBDataset.MST_USER.Select("(USERID='" + UserID.Text + "')")
        If MyUsers.Length > 0 Then
            Dim IncorrectPass As Boolean = True
            For Each MyUser As DataRow In MyUsers
                If MyCrypto.Decrypt(CType(MyUser("PASSWD"), Byte())) = UserPasswd.Text Then
                    IncorrectPass = False
                    m_UserNo = CInt(MyUser("USERNO"))
                    m_RoleNo = CInt(MyUser("ROLENO"))
                    Return True
                End If
            Next
            If IncorrectPass Then
                MsgBox("Incorrect Passoword !")
                UserPasswd.Select()
                UserPasswd.SelectAll()
                Return False
            End If
        Else
            MsgBox("No such User !")
            UserID.Select()
            UserID.SelectAll()
            Return False
        End If
    End Function

    Private Function ValidateAdmin() As Boolean
        CompsDBs = SystemManager.GetCompsDBs
        Dim AdminRow As DataRow = CompsDBs.AdminData.Rows(0)

        If MyCrypto.Decrypt(CType(AdminRow("AdminName"), Byte())) = UserID.Text Then
            If MyCrypto.Decrypt(CType(AdminRow("AdminPass"), Byte())) = UserPasswd.Text Then
                Return True
            Else
                MsgBox("Invalid Admin password !")
                UserPasswd.Select()
                UserPasswd.SelectAll()
            End If
        Else
            MsgBox("Invalid Admin Name !")
            UserID.Select()
            UserID.SelectAll()
        End If
        Return False
    End Function


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If ValidateAdmin() Then
            Dim MyDlg As FmCreateCompDlg = New FmCreateCompDlg
            Dim ScriptSuccess As Boolean = False
            Dim DBcreated As Boolean = False
            If MyDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                ScriptSuccess = SystemManager.RunScript(My.Resources.CreateDB, MyDlg.DatabaseName.Text)
                If ScriptSuccess Then
                    NeedCloseScriptEngine = True
                    DBcreated = True
                    ScriptSuccess = SystemManager.RunScript(My.Resources.CreateTableProc, MyDlg.DatabaseName.Text)
                Else
                    DBcreated = False
                End If

                If MyDlg.cbSampleData.Checked Then
                    If ScriptSuccess Then
                        ScriptSuccess = SystemManager.RunScript(My.Resources.CSAccountDBData, MyDlg.DatabaseName.Text)
                    End If
                Else
                    If ScriptSuccess Then
                        ScriptSuccess = SystemManager.RunScript(My.Resources.CSAccountDBSystemData, MyDlg.DatabaseName.Text)
                    End If
                End If

                If ScriptSuccess Then
                    CompsDBs.CompDB.AddCompDBRow(MyDlg.CompName.Text, MyDlg.DatabaseName.Text)
                    SystemManager.SaveCompsDBs(CompsDBs)
                    CompsDBs.CompDB.AcceptChanges()
                    CompDBBindingSource.DataSource = CompsDBs
                    cmbCompany.Text = MyDlg.CompName.Text
                Else
                    If DBcreated Then
                        SystemManager.RunScript(My.Resources.DropDB, MyDlg.DatabaseName.Text)
                    End If
                End If
            End If
            MyDlg.Close()
            MyDlg.Dispose()
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If ValidateAdmin() Then
            If CompDBBindingSource.Count > 0 Then
                If MessageBox.Show("Confirm to delete current company database ?", "Confirm delete database", _
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, _
                MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Yes Then
                    If NeedCloseScriptEngine Then
                        SystemManager.CloseScriptEngineDatabase()
                        NeedCloseScriptEngine = False
                    End If
                    Dim MyRow As DataRowView = CType(CompDBBindingSource.Current, DataRowView)
                    If SystemManager.RunScript(My.Resources.DropDB, CStr(MyRow("DBName"))) Then
                        Dim MyRows() As DataRow = CompsDBs.CompDB.Select("DBNAME='" + CStr(MyRow("DBName")) + "'")
                        MyRows(0).Delete()
                        CompDBBindingSource.RemoveCurrent()
                        CompsDBs.CompDB.AcceptChanges()
                        SystemManager.SaveCompsDBs(CompsDBs)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        If SystemManager IsNot Nothing Then
            SystemManager.CloseScriptEngineDatabase()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BusinessDate.Value = #3/1/2007#
        StartDate.Value = #1/1/2007#
        EndDate.Value = #6/1/2007#
        UserID.Text = "ADMIN"
        UserPasswd.Text = "ADMIN"
#If CSDEBUG = False Then
        If CompDBBindingSource.Count = 0 Then
            btnAdd_Click(btnAdd, Nothing)
        End If
#End If
    End Sub

    Private Sub FmLoginDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
#If CSDebug = True Then
        'LinkLabel1_LinkClicked(Nothing, Nothing)
        cmbCompany.SelectedValue = ""
        cmbCompany.Text = ""
#End If
    End Sub
End Class

