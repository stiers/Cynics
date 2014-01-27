Imports System.Windows.Forms
Imports System.Drawing
Imports CSCommon

Public MustInherit Class FormsInfoDef
    Private m_Forms As Dictionary(Of String, String)
    Private m_FormClasses As Dictionary(Of String, Object)
    Private m_FormImages As Dictionary(Of String, Object)

    Public Sub New()
        m_Forms = New Dictionary(Of String, String)
        m_FormClasses = New Dictionary(Of String, Object)
        m_FormImages = New Dictionary(Of String, Object)
    End Sub

    Public Sub AddForm(ByVal InFormName As String, ByVal InFormClassName As String, ByVal InFormClassType As Type, ByVal InFormImage As Bitmap)
        m_Forms.Add(InFormName, InFormClassName)
        m_FormClasses.Add(InFormClassName, InFormClassType)
        m_FormImages.Add(InFormClassName, InFormImage)
    End Sub

    Public Function Forms() As Dictionary(Of String, String)
        Return m_Forms
    End Function

    Public Function FormImages() As Dictionary(Of String, Object)
        Return m_FormImages
    End Function


    Public Function CreateForm(ByVal InFormClass As String) As StdForm
        If m_FormClasses(InFormClass) IsNot Nothing Then
            Dim MyType As Type = CType(m_FormClasses(InFormClass), Type)
            Dim MyForm As StdForm = Nothing
            Try
                MyForm = CType(Activator.CreateInstance(CType(m_FormClasses(InFormClass), Type)), StdForm)
            Catch ex As Exception
                MyForm = Nothing
                MsgBox(ex.Message)
            End Try
            Return MyForm
        Else
            Return Nothing
        End If
    End Function

End Class

Public Interface iCSReport
    Inherits IDisposable
    Property ReportName() As String
    Property ParentForm() As Form
    Property SystemManager() As ICSAccountDatabaseIntf
    Property SystemInfo() As CSSystemInfo
    Sub Preview(Optional ByVal InDataset As DataSet = Nothing, Optional ByVal FilterKey As String = "")
    Sub Print(Optional ByVal InDataset As DataSet = Nothing, Optional ByVal Filterkey As String = "")
    Sub DisposeForm()
End Interface
