Imports CSCommon
Imports System.Runtime.Remoting
Imports CSAccountDatabaseIntf
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.web
Imports System.IO
Imports System.Text

Public Class CSMain
    Const ReportAssembly As String = "CSReports"
    Private CurrentForm As StdForm = Nothing
    Private CurrentRpt As iCSReport = Nothing
    Private MyProxy As CSProxy
    Private ServerSystemManager As ICSAccountDatabaseIntf
    Private SystemInfo As CSSystemInfo
    Private FormsSecurityInfo As ArrayList = New ArrayList

    Private Sub CSMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
#If CSEXPIRECHECK = True Then
        If My.Settings.INSTALL_DATE = #12:00:00 AM# Then
            My.Settings.INSTALL_DATE = Today
            My.Settings.EXPIRED = False
            My.Settings.Save()
        End If

        If (My.Settings.EXPIRED = True) Or ((Today - My.Settings.INSTALL_DATE).Days > 180) Then
            My.Settings.EXPIRED = True
            My.Settings.Save()
            MessageBox.Show("Program trial expired, Please register to continue !", "Program Expired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Close()
            Exit Sub
        End If
#End If

#If CSNEEDLICENSE = True Then
        If (New CSLicense).CheckLicenseExists() = False Then
            MsgBox("Program need license to execute, please register with your nearest dealer !")
            Close()
            Exit Sub
        End If
#End If

        SystemInfo = New CSCommon.CSSystemInfo

        Dim LoginDlg As FmLoginDlg = New FmLoginDlg
        LoginDlg.SystemInfo = SystemInfo
        RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, False)
        MyProxy = New CSProxy
        ServerSystemManager = CType(MyProxy.CreateProxy(GetType(ICSAccountDatabaseIntf)), ICSAccountDatabaseIntf)
        tvMainView.Nodes.Clear()
        LoginDlg.UserID.Text = My.Settings.USERID
#If (CSDEBUG = True) Or (CSEXPIRECHECK = True) Then
        If My.Settings.USERID = "ADMIN" Then
            LoginDlg.UserPasswd.Text = "ADMIN"
		End If
#End If
        Try
            LoginDlg.SystemManager = ServerSystemManager
            LoginDlg.InitControls()
            LoginDlg.SystemInfo = SystemInfo

            If LoginDlg.ShowDialog = DialogResult.OK Then
                My.Settings.USERID = LoginDlg.UserID.Text
                My.Settings.PASSWD = ""
                My.Settings.Save()
                Dim SystemDataset As CSSystemDBDataset
                SystemDataset = LoginDlg.CSSystemDBDataset
                SystemInfo.UserInfo.UserID = LoginDlg.UserID.Text
                SystemInfo.UserInfo.UserNo = LoginDlg.UserNo

                Dim RoleNo As Integer


                Dim TmpRows As DataRow() = SystemDataset.MST_USER.Select("USERNO=" + SystemInfo.UserInfo.UserNo.ToString)
                If TmpRows.Length <> 0 Then
                    RoleNo = CType(TmpRows(0)("ROLENO"), Integer)
                Else
                    Exit Sub
                End If


                tvMainView.BeginUpdate()
                For Each MyRow As DataRow In SystemDataset.MST_GRPS.Rows
                    Dim RootNode As TreeNode = tvMainView.Nodes.Add(CType(MyRow("GRPNAME"), String))
                    For Each MySubRow As DataRow In SystemDataset.GRPFORMDetail.Select("GRPNO='" + CType(MyRow("GRPNO"), String) + "'")
                        Dim MyformInfo As FormCreateInfoDef
                        MyformInfo.ImageIndex = 0
                        MyformInfo.FormNo = CType(MySubRow("FORMNO"), Integer)
                        MyformInfo.AssemblyName = CType(MySubRow("ASSEMBLY_NAME"), String)
                        MyformInfo.ClassName = CType(MySubRow("FORM_CLASS"), String)
                        MyformInfo.Description = CType(MySubRow("FORM_NAME"), String)
                        MyformInfo.AllowAdd = False
                        MyformInfo.AllowEdit = False
                        MyformInfo.AllowDel = False
                        MyformInfo.AllowPrint = False

                        Dim RoleFormRow As CSSystemDBDataset.MST_ROLEFORMRow = (SystemDataset.MST_ROLEFORM.FindByROLENOFORMNO(RoleNo, MyformInfo.FormNo))

                        If RoleFormRow IsNot Nothing Then
                            MyformInfo.AllowAdd = RoleFormRow.ALLOW_ADD
                            MyformInfo.AllowEdit = RoleFormRow.ALLOW_EDT
                            MyformInfo.AllowDel = RoleFormRow.ALLOW_DEL
                            MyformInfo.AllowPrint = RoleFormRow.ALLOW_PRN
                            MyformInfo.AllowView = True
                        Else
                            MyformInfo.AllowView = False
                        End If


                        If MyformInfo.AllowView = True Then
                            Dim FormsInfo As FormsInfoDef = CType(Activator.CreateInstance(MyformInfo.AssemblyName, MyformInfo.AssemblyName + ".FormsInfo").Unwrap, FormsInfoDef)
                            Dim TempImage As Bitmap = CType(FormsInfo.FormImages(MyformInfo.ClassName), Bitmap)
                            If TempImage IsNot Nothing Then
                                ImageList1.Images.Add(TempImage)
                                MyformInfo.ImageIndex = ImageList1.Images.Count - 1
                            End If

                            Dim NewTreeNode As TreeNode = RootNode.Nodes.Add(CType(MySubRow("FORM_NAME"), String))

                            FormsSecurityInfo.Add(MyformInfo)

                            NewTreeNode.Tag = MyformInfo
                            NewTreeNode.ImageIndex = MyformInfo.ImageIndex
                            NewTreeNode.SelectedImageIndex = MyformInfo.ImageIndex
                        End If
                    Next
                Next
                tvMainView.EndUpdate()
            Else
                Close()
            End If
        Catch ex As Exception
            If TypeOf ex Is System.Net.Sockets.SocketException Then
                MsgBox("Server inactive or no connection !")
                Close()
            Else
                MsgBox(ex.Message)
            End If
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub tvMainView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvMainView.DoubleClick
        If CType(sender, TreeView).SelectedNode IsNot Nothing Then
            If CType(sender, TreeView).SelectedNode.Tag IsNot Nothing Then
                Dim MyFormInfo As FormCreateInfoDef = CType(CType(sender, TreeView).SelectedNode.Tag, FormCreateInfoDef)

                Dim MyFormsInfo As FormsInfoDef = _
                CType(Activator.CreateInstance(MyFormInfo.AssemblyName, MyFormInfo.AssemblyName + ".FormsInfo").Unwrap, FormsInfoDef)

                If CurrentForm IsNot Nothing Then
                    CurrentForm.Close()
                    CurrentForm.Dispose()
                End If

                CurrentForm = CType(MyFormsInfo.CreateForm(MyFormInfo.ClassName), StdForm)

                If CurrentForm IsNot Nothing Then
                    CurrentForm.SystemInfo = SystemInfo
                    CurrentForm.MdiParent = Me

                    If TypeOf CurrentForm Is StdDBForm Then
                        CType(CurrentForm, StdDBForm).AllowAdd = MyFormInfo.AllowAdd
                        CType(CurrentForm, StdDBForm).AllowEdit = MyFormInfo.AllowEdit
                        CType(CurrentForm, StdDBForm).AllowDel = MyFormInfo.AllowDel
                        CType(CurrentForm, StdDBForm).AllowPrint = MyFormInfo.AllowPrint
                        CType(CurrentForm, StdDBForm).PrintEngine = CType(Activator.CreateInstance(ReportAssembly, ReportAssembly + ".CSRptEngine").Unwrap, iCSReport)
                    End If



                    CurrentForm.WindowState = FormWindowState.Maximized
                    CurrentForm.SystemManager = ServerSystemManager

                    CurrentForm.Text = MyFormInfo.Description
                    If TypeOf CurrentForm Is StdDBForm Then
                        CType(CurrentForm, StdDBForm).FormsSecurityInfo = FormsSecurityInfo
                    End If

                    CurrentForm.CallAfterFormInit()
                    StatusLabel.Text = CurrentForm.Text
                    CurrentForm.Show()
                Else
                    If CurrentRpt IsNot Nothing Then
                        CurrentRpt.DisposeForm()
                    Else
                        CurrentRpt = CType(Activator.CreateInstance(ReportAssembly, ReportAssembly + ".CSRptEngine").Unwrap, iCSReport)
                    End If
                    CurrentRpt.ReportName = MyFormInfo.ClassName
                    CurrentRpt.ParentForm = Me
                    CurrentRpt.SystemManager = ServerSystemManager
                    CurrentRpt.SystemInfo = SystemInfo
                    CurrentRpt.Preview()
                End If
            End If
        End If
    End Sub


    Private Sub tvMainView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tvMainView.KeyDown
        If e.KeyCode = Keys.Enter Then
            tvMainView_DoubleClick(tvMainView, New System.EventArgs)
        End If
    End Sub

    Private Sub tvMainView_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMainView.AfterExpand
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub

    Private Sub tvMainView_AfterCollapse(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvMainView.AfterCollapse
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub


    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.ShowHelp(Me, "file://" + Replace(Application.StartupPath, "\", "\\") + "\\Cynics Accounting.chm")
    End Sub

    Private Sub AboutDialogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDialogToolStripMenuItem.Click
        Dim AboutDlg As AboutDlg = New AboutDlg
        AboutDlg.ShowDialog()
        AboutDlg.Close()
        AboutDlg = Nothing
    End Sub

End Class
