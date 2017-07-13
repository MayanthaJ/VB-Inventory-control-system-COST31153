﻿Imports System.Data.SqlClient
Public Class Customers
    Public SQL As New SQLControl

    'Data Grid Load
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Customer;")
        Else
            SQL.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If SQL.HasException(True) Then Exit Sub

        DataGridView1.DataSource = SQL.DBDT
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MenuA.Show()
        Me.Close()
    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub stockCreatedDate_Click(sender As Object, e As EventArgs) Handles stockCreatedDate.Click

    End Sub
End Class