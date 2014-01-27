Imports System.Management
Imports CSAccountDatabaseIntf
Imports System.Text
Imports CSCommon
Imports System.IO
Public MustInherit Class CSLicenseControl
    Public MustOverride Function CreateLicenseDataset() As DataSet
    Public LicDataset As DataSet = CreateLicenseDataset
    Public MustOverride Function CheckLicenseExists() As Boolean
    Public MustOverride Function ReadLicenseFile() As Boolean
    Public MustOverride Function GetComputerID() As String
End Class

Public Class CSLicense
    Inherits CSLicenseControl

    Public Overrides Function CheckLicenseExists() As Boolean
        If ReadLicenseFile() = False Then
            Dim MyDlg As CSLicenseDlg = New CSLicenseDlg
            If CSLicenseDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                If CSLicenseDlg.LicensePath <> "" Then
                    My.Settings.LICENSEFILE = CSLicenseDlg.LicensePath
                    My.Settings.Save()
                    Return ReadLicenseFile()
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Public Overrides Function ReadLicenseFile() As Boolean
        Try
            If My.Settings.LICENSEFILE <> "" Then
                Dim MyLicFile As FileStream = New FileStream(My.Settings.LICENSEFILE, FileMode.Open)
                Dim LicData() As Byte
                Dim DecodeFile As MemoryStream = New MemoryStream
                Dim DecodeData() As Byte
                Dim UnDec As UTF8Encoding = New UTF8Encoding
                Dim Rstream As New BinaryReader(MyLicFile)
                LicData = Rstream.ReadBytes(CInt(MyLicFile.Length))
                Dim MyCryto As CSSimpleCrypto = New CSSimpleCrypto
                DecodeData = UnDec.GetBytes(MyCryto.Decrypt(LicData))
                DecodeFile.Write(DecodeData, 0, DecodeData.Length)
                DecodeFile.Position = 0
                CType(LicDataset, LicenseDataset).LicenseTable.Clear()
                CType(LicDataset, LicenseDataset).LicenseTable.ReadXml(DecodeFile)
                If CType(LicDataset, LicenseDataset).LicenseTable.Rows.Count > 0 Then
                    If GetComputerID() = CStr(CType(LicDataset, LicenseDataset).LicenseTable.Rows(0)("ComputerID")) Then
                        Return True
                    Else
                        MsgBox("Wrong license file, please register new license !")
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Overrides Function CreateLicenseDataset() As System.Data.DataSet
        Return New LicenseDataset
    End Function

    Public Overrides Function GetComputerID() As String
        Dim objMOS As ManagementObjectSearcher
        Dim objMOC As Management.ManagementObjectCollection
        Dim objMO As Management.ManagementObject = Nothing

        objMOS = New ManagementObjectSearcher("Select * From Win32_Processor")
        objMOC = objMOS.Get

        If objMOC.Count > 0 Then
            For Each objMO In objMOC
                Return objMO("ProcessorID").ToString
                Exit For
            Next
        End If

        objMOS.Dispose()
        objMOS = Nothing
        If objMO IsNot Nothing Then
            objMO.Dispose()
        End If
        objMO = Nothing
        Return ""
    End Function
End Class


