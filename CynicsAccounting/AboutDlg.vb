Imports System.Windows.Forms
Imports CSAccountDatabaseIntf
Imports System.IO
Imports System.Drawing

Public Class AboutDlg

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("IExplore.exe", String.Format("http://{0}", LinkLabel1.Text))
    End Sub

    Private Sub AboutDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim LicControl As CSLicenseControl = New CSLicense
        If LicControl.ReadLicenseFile Then
            Dim LicDataset As LicenseDataset = CType(LicControl.LicDataset, LicenseDataset)
            Dim CurrRow As LicenseDataset.LicenseTableRow = CType(LicDataset.LicenseTable.Rows(0), LicenseDataset.LicenseTableRow)
            lbDealerName.Text = CurrRow.CompName
            lbAddr1.Text = CurrRow.CompAddr1
            lbAddr2.Text = CurrRow.CompAddr2
            lbAddr3.Text = CurrRow.CompAddr3
            lbAddr4.Text = CurrRow.CompAddr4
            lbRegName.Text = CurrRow.CustName
            lbRegComp.Text = CurrRow.CustCompName
            lbPhoneFax.Text = String.Format("Phone : {0} , Fax : {1}", CurrRow.CompPhone, CurrRow.CompFax)
            If CurrRow("CompLogo") IsNot DBNull.Value Then
                Dim LogoStream As MemoryStream = New MemoryStream(CurrRow.CompLogo)
                PictureBox1.Image = Image.FromStream(LogoStream)
            End If
            LinkLabel1.Text = "www.cynics-services.com"
        End If
    End Sub

End Class
