Imports System.io
Imports CSAccountDatabaseIntf
Imports CSCommon
Imports System.text
Imports System.Drawing
Public Class CSLicenseDlg
    Public LicensePath As String = ""
    Private Sub btnReadLicense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadLicense.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim MyFile As FileStream = New FileStream(OpenFileDialog1.FileName, FileMode.Open)
                Dim NewFile As MemoryStream = New MemoryStream
                Dim ImageFile As MemoryStream = New MemoryStream
                Dim Rstream As New BinaryReader(MyFile)
                Dim MyData() As Byte = Rstream.ReadBytes(CInt(MyFile.Length))
                Dim NewData() As Byte
                Dim UniEnc As UTF8Encoding = New UTF8Encoding
                Dim MyCrypto As CSSimpleCrypto = New CSSimpleCrypto
                NewData = UniEnc.GetBytes(MyCrypto.Decrypt(MyData))
                NewFile.Write(NewData, 0, NewData.Length)
                Dim MyLic As LicenseDataset = New LicenseDataset
                NewFile.Position = 0
                MyLic.LicenseTable.Clear()
                MyLic.LicenseTable.ReadXml(NewFile)
                If (New CSLicense).GetComputerID <> CStr(MyLic.LicenseTable.Rows(0)("ComputerID")) Then
                    MsgBox("Wrong license file, please register new license !")
                    Exit Sub
                End If
                If MyLic.LicenseTable.Rows(0)("CompLogo") IsNot DBNull.Value Then
                    Dim ImageData() As Byte = CType(MyLic.LicenseTable.Rows(0)("CompLogo"), Byte())
                    ImageFile.Write(ImageData, 0, ImageData.Length)
                    ImageFile.Position = 0
                    PictureBox1.Image = Image.FromStream(ImageFile)
                End If
                lbDealerName.Text = CStr(MyLic.LicenseTable.Rows(0)("CompName"))
                lbDealerAddr1.Text = CStr(MyLic.LicenseTable.Rows(0)("CompAddr1"))
                lbDealerAddr2.Text = CStr(MyLic.LicenseTable.Rows(0)("CompAddr2"))
                lbDealerAddr3.Text = CStr(MyLic.LicenseTable.Rows(0)("CompAddr3"))
                lbDealerAddr4.Text = CStr(MyLic.LicenseTable.Rows(0)("CompAddr4"))
                lbCustName.Text = CStr(MyLic.LicenseTable.Rows(0)("CustName"))
                lbCustComp.Text = CStr(MyLic.LicenseTable.Rows(0)("CustCompName"))
                NewFile.Close()
                MyFile.Close()
                ImageFile.Close()
                LicensePath = OpenFileDialog1.FileName
            Catch ex As Exception
                MsgBox(ex.Message)
                LicensePath = ""
            End Try
        End If

    End Sub

    Private Sub CSLicenseDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtComputerID.Text = (New CSLicense).GetComputerID
    End Sub
End Class
