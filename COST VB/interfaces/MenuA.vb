Public Class MenuA
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Customers.Show()
        Me.Close()
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        stocks.Show()
        Me.Close()

    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Orders.Show()
        Me.Close()
    End Sub

    Private Sub pictureBox5_Click(sender As Object, e As EventArgs) Handles pictureBox5.Click
        Suppliers.Show()
        Me.Close()
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs)
        Sales.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Admin.Show()
        Me.Close()
    End Sub

    Private Sub MenuA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class