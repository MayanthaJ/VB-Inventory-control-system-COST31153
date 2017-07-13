Imports System.Data.SqlClient
Public Class stocks
    Public SQL As New SQLControl

    'Data Grid Load
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("SELECT * FROM Books;")
        Else
            Sql.ExecQuery(Query)
        End If

        ' ERROR HANDLING
        If Sql.HasException(True) Then Exit Sub

        dgvData.DataSource = Sql.DBDT
    End Sub

    'Authors Load
    Private Sub loadAuth()
        ' REFRESH COMBOBOX
        stockAuthor.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT author_name FROM author ORDER BY author_name ASC;")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            stockAuthor.Items.Add(r("author_name").ToString)
        Next
    End Sub

    'Suppliers Load
    Private Sub loadPublisher()
        ' REFRESH COMBOBOX
        stockPublisher.Items.Clear()

        ' RUN QUERY
        SQL.ExecQuery("SELECT * FROM Publisher ORDER BY sup_name ASC;")

        If SQL.HasException(True) Then Exit Sub

        ' LOOP ROW & ADD TO COMBOBOX
        For Each r As DataRow In SQL.DBDT.Rows
            stockPublisher.Items.Add(r("sup_name").ToString)
        Next
    End Sub

    Private Sub InsertBook()

        ' ADD SQL PARAMS & RUN THE COMMAND
        SQL.AddParam("@type", stockType_view_drop.SelectedItem)
        SQL.AddParam("@title", stockTitle.Text)
        SQL.AddParam("@isbn", TextBox4.Text)
        SQL.AddParam("@author", stockAuthor.SelectedItem)
        SQL.AddParam("@publisher", stockPublisher.SelectedItem)
        SQL.AddParam("@quantity", TextBox1.Text)
        SQL.AddParam("@retail", stockQuantity.Text)
        SQL.AddParam("@dis", TextBox2.Text)
        SQL.AddParam("@whole", TextBox3.Text)
        Dim thisDay As DateTime = DateTime.Today
        SQL.AddParam("@date", thisDay)

        SQL.ExecQuery("INSERT INTO Books VALUES (222,@title,@isbn,@quantity,@retail,@dis,@whole,@date,4,2,1);")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            MsgBox("Stock  Creation Failed!!!")
        Else
            MsgBox("New stock created successfully!")
            LoadGrid()
            loadAuth()
            loadPublisher()
        End If


    End Sub

    Private Sub UpdateBook()

        ' ADD SQL PARAMS & RUN THE COMMAND
        SQL.AddParam("@bookid", Convert.ToInt32(stockID_view.Text))
        SQL.AddParam("@title", stockTitle.Text)
        SQL.AddParam("@isbn", Convert.ToString(TextBox4.Text))
        SQL.AddParam("@quantity", TextBox1.Text)
        SQL.AddParam("@retail", stockQuantity.Text)
        SQL.AddParam("@dis", TextBox2.Text)
        SQL.AddParam("@whole", TextBox3.Text)
        Dim thisDay As DateTime = DateTime.Today
        SQL.AddParam("@date", thisDay)

        SQL.ExecQuery("UPDATE Books SET book_name=@title,book_ISBN=@isbn,book_quantity=@quantity,book_retail_price=@retail,book_retail_discount=@dis,book_whole_price=@whole WHERE book_id = @bookid;")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            MsgBox("Stock  Update Failed!!!")
        Else
            MsgBox("Record updated!")
            LoadGrid()
            loadAuth()
            loadPublisher()
        End If


    End Sub

    Private Sub DeleteBook()
        ' ADD SQL PARAMS & RUN THE COMMAND
        SQL.AddParam("@bookid", Convert.ToInt32(stockID_view.Text))
        ' RUN QUERY
        SQL.ExecQuery("DELETE From Books WHERE book_id = @bookid;")

        ' REPORT & ABORT ON ERRORS
        If SQL.HasException(True) Then Exit Sub

        If SQL.DBDT.Rows.Count > 0 Then
            MsgBox("Stock  Delete Failed!!!")
        Else
            MsgBox("Record Deleted!")
            LoadGrid()
            loadAuth()
            loadPublisher()
        End If
    End Sub

    Private Sub FindItem()
        SQL.AddParam("@item", "%" & txtSearch.Text & "%")
        LoadGrid("SELECT * FROM Books WHERE book_name LIKE @item OR book_supplier_id LIKE @item;")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MenuA.Show()
        Me.Close()
    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.Close()
    End Sub

    Private Sub stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        loadAuth()
        loadPublisher()

    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        FindItem()
    End Sub

    Private Sub stockQuantity_TextChangsed(sender As Object, e As EventArgs) Handles stockQuantity.TextChanged

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        InsertBook()
    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick
        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvData.Rows(index)

        'now show data from the selected row to textboxes
        stockID_view.Text = selectedRow.Cells(0).Value.ToString()
        'stockType_view_drop. = selectedRow.Cells(1).Value.ToString()
        stockTitle.Text = selectedRow.Cells(1).Value.ToString()
        TextBox4.Text = selectedRow.Cells(2).Value.ToString()
        'stockAuthor.Text = selectedRow.Cells(3).Value.ToString()
        'stockPublisher.Text = selectedRow.Cells(4).Value.ToString()
        TextBox1.Text = selectedRow.Cells(3).Value.ToString()
        stockQuantity.Text = selectedRow.Cells(4).Value.ToString()
        TextBox2.Text = selectedRow.Cells(5).Value.ToString()
        TextBox3.Text = selectedRow.Cells(6).Value.ToString()
        stockCreatedDate.Text = selectedRow.Cells(7).Value.ToString()


    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        UpdateBook()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DeleteBook()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
    End Sub
End Class