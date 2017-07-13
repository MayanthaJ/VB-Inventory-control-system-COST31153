Imports System.Data.SqlClient

Public Class Login
    Public SQL As New SQLControl
    Private Function loadAuth()
        SQL.AddParam("@uname", UserNameTxtbox.Text)
        SQL.AddParam("@pass", PwordTextbox.Text)
        ' RUN QUERY


        Try
            SQL.ExecQuery("SELECT * FROM Admin WHERE user_name=@uname AND user_password = @pass;")
        Catch ex As Exception
            Return False
        End Try
        If SQL.DBDT.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim strSQL As Boolean
        strSQL = loadAuth()
        If strSQL = True Then
            Dim MainM As New MenuA
            MainM.Show()
            Me.Close()

        Else
            MsgBox("Loging Failed!!!!")
        End If

    End Sub
End Class
