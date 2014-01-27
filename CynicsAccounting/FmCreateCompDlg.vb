Imports System.Windows.Forms
Public Class FmCreateCompDlg

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        If DatabaseName.Text = "" Then
            Me.DialogResult = DialogResult.None
            MsgBox("Database Name required !")
        End If

        If CompName.Text = "" Then
            Me.DialogResult = DialogResult.None
            MsgBox("Company Name required !")
        End If

        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CompName_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompName.Validated
        If CompName.Text <> "" Then
            DatabaseName.Text = CompName.Text + "DB"
        End If
    End Sub
End Class