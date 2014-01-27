Imports System.Runtime.Remoting
Imports CSAccountDatabaseIntf
Imports Microsoft.VisualBasic
Imports CSCommon
Imports System.io
Imports System.Configuration
Public Class FmMain
    Private MyData As CompsDBs = New CompsDBs
    Private MyCrypto As CSSimpleCrypto = New CSSimpleCrypto


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Directory.Exists(My.Settings.CompDBPath) = False Then
            Directory.CreateDirectory(My.Settings.CompDBPath)
        End If
        Visible = False
        NotifyIcon1.Visible = True
        RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, False)
        Size = New Size(365, 109)
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        MyData.Clear()
        If File.Exists(My.Settings.CompDBPath + "CompsDBs.xml") Then
            MyData.ReadXml(My.Settings.CompDBPath + "CompsDBs.xml")
        End If

        If MyData.AdminData.Rows.Count = 0 Then
            MyData.AdminData.AddAdminDataRow(MyCrypto.Encrypt("ADMIN"), MyCrypto.Encrypt("ADMIN"))
        End If

        Dim MyRow As DataRow = MyData.AdminData.Rows(0)
        If MyCrypto.Decrypt(CType(MyRow("AdminName"), Byte())) = AdminName.Text Then
            If MyCrypto.Decrypt(CType(MyRow("AdminPass"), Byte())) = AdminPass.Text Then
                GrpChange.Visible = True
                NewName.Select()
                NewName.SelectAll()
                AcceptButton = btnSave
            Else
                MsgBox("Invalid Password !")
                AdminPass.Select()
                AdminPass.SelectAll()
            End If
        Else
            MsgBox("Invalid Admin Name !")
            AdminName.Select()
            AdminName.SelectAll()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If NewPass.Text = ConfirmPass.Text Then
            MyData.AdminData.Rows(0).Delete()
            MyData.AdminData.AcceptChanges()
            MyData.AdminData.AddAdminDataRow(MyCrypto.Encrypt(NewName.Text), MyCrypto.Encrypt(NewPass.Text))
            MyData.WriteXml(My.Settings.CompDBPath + "CompsDBs.xml")
            AdminName.Text = ""
            AdminPass.Text = ""
            NewName.Text = ""
            NewPass.Text = ""
            ConfirmPass.Text = ""
            GrpChange.Visible = False
            AcceptButton = btnChange
            AdminName.Select()
            AdminName.SelectAll()
        Else
            MsgBox("Invalid Confirm Password !")
            ConfirmPass.Select()
            ConfirmPass.SelectAll()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GrpChange.Visible = False
        AcceptButton = btnChange
        AdminName.Text = ""
        AdminPass.Text = ""
        AdminName.Select()
        AdminName.SelectAll()
    End Sub

    Private Sub FmMain_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Move
        If WindowState = FormWindowState.Minimized Then
            Visible = False
        End If
    End Sub

    Private Sub GrpChange_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpChange.VisibleChanged
        If GrpChange.Visible Then
            Size = New Size(365, 209)
        Else
            Size = New Size(365, 109)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
