Public Class Login
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim MainM As New MenuA
        MainM.Show()
        Me.Close()
    End Sub
End Class
