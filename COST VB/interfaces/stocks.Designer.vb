<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.stockTitle = New System.Windows.Forms.TextBox()
        Me.stockQuantity = New System.Windows.Forms.TextBox()
        Me.stockID_view = New System.Windows.Forms.Label()
        Me.stockType_view_drop = New System.Windows.Forms.ComboBox()
        Me.stockAuthor = New System.Windows.Forms.ComboBox()
        Me.stockPublisher = New System.Windows.Forms.ComboBox()
        Me.stockUpdatedDate = New System.Windows.Forms.Label()
        Me.stockCreatedDate = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.searchBtn = New System.Windows.Forms.PictureBox()
        Me.deleteBtn = New System.Windows.Forms.PictureBox()
        Me.editBtn = New System.Windows.Forms.PictureBox()
        Me.addBtn = New System.Windows.Forms.PictureBox()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.searchBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Stock ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(370, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Publisher"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Title"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(370, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Updated Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Oswald", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(370, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 24)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Created Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Oswald", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 40)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Stock Management"
        '
        'stockTitle
        '
        Me.stockTitle.BackColor = System.Drawing.Color.White
        Me.stockTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stockTitle.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockTitle.Location = New System.Drawing.Point(127, 137)
        Me.stockTitle.Name = "stockTitle"
        Me.stockTitle.Size = New System.Drawing.Size(179, 25)
        Me.stockTitle.TabIndex = 30
        '
        'stockQuantity
        '
        Me.stockQuantity.BackColor = System.Drawing.Color.White
        Me.stockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stockQuantity.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockQuantity.Location = New System.Drawing.Point(501, 101)
        Me.stockQuantity.Name = "stockQuantity"
        Me.stockQuantity.Size = New System.Drawing.Size(179, 25)
        Me.stockQuantity.TabIndex = 33
        '
        'stockID_view
        '
        Me.stockID_view.AutoSize = True
        Me.stockID_view.BackColor = System.Drawing.Color.Transparent
        Me.stockID_view.Font = New System.Drawing.Font("Oswald", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockID_view.Location = New System.Drawing.Point(125, 68)
        Me.stockID_view.Name = "stockID_view"
        Me.stockID_view.Size = New System.Drawing.Size(50, 20)
        Me.stockID_view.TabIndex = 34
        Me.stockID_view.Text = "Stock ID"
        '
        'stockType_view_drop
        '
        Me.stockType_view_drop.DropDownHeight = 150
        Me.stockType_view_drop.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockType_view_drop.FormattingEnabled = True
        Me.stockType_view_drop.IntegralHeight = False
        Me.stockType_view_drop.Items.AddRange(New Object() {"Childern", "Novel", "Education"})
        Me.stockType_view_drop.Location = New System.Drawing.Point(127, 102)
        Me.stockType_view_drop.Name = "stockType_view_drop"
        Me.stockType_view_drop.Size = New System.Drawing.Size(179, 25)
        Me.stockType_view_drop.TabIndex = 35
        '
        'stockAuthor
        '
        Me.stockAuthor.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockAuthor.FormattingEnabled = True
        Me.stockAuthor.Location = New System.Drawing.Point(127, 172)
        Me.stockAuthor.Name = "stockAuthor"
        Me.stockAuthor.Size = New System.Drawing.Size(179, 25)
        Me.stockAuthor.TabIndex = 36
        '
        'stockPublisher
        '
        Me.stockPublisher.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockPublisher.FormattingEnabled = True
        Me.stockPublisher.Location = New System.Drawing.Point(501, 70)
        Me.stockPublisher.Name = "stockPublisher"
        Me.stockPublisher.Size = New System.Drawing.Size(179, 25)
        Me.stockPublisher.TabIndex = 37
        '
        'stockUpdatedDate
        '
        Me.stockUpdatedDate.AutoSize = True
        Me.stockUpdatedDate.BackColor = System.Drawing.Color.Transparent
        Me.stockUpdatedDate.Font = New System.Drawing.Font("Oswald", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockUpdatedDate.Location = New System.Drawing.Point(497, 136)
        Me.stockUpdatedDate.Name = "stockUpdatedDate"
        Me.stockUpdatedDate.Size = New System.Drawing.Size(50, 20)
        Me.stockUpdatedDate.TabIndex = 38
        Me.stockUpdatedDate.Text = "Stock ID"
        '
        'stockCreatedDate
        '
        Me.stockCreatedDate.AutoSize = True
        Me.stockCreatedDate.BackColor = System.Drawing.Color.Transparent
        Me.stockCreatedDate.Font = New System.Drawing.Font("Oswald", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockCreatedDate.Location = New System.Drawing.Point(498, 169)
        Me.stockCreatedDate.Name = "stockCreatedDate"
        Me.stockCreatedDate.Size = New System.Drawing.Size(50, 20)
        Me.stockCreatedDate.TabIndex = 39
        Me.stockCreatedDate.Text = "Stock ID"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(52, 287)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(644, 195)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.Transparent
        Me.searchBtn.BackgroundImage = Global.COST_VB.My.Resources.Resources.icons8_Search_Filled_100
        Me.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBtn.Location = New System.Drawing.Point(354, 221)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(27, 29)
        Me.searchBtn.TabIndex = 42
        Me.searchBtn.TabStop = False
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.BackgroundImage = Global.COST_VB.My.Resources.Resources.icons8_Delete_File_96
        Me.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.Location = New System.Drawing.Point(541, 221)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(27, 29)
        Me.deleteBtn.TabIndex = 43
        Me.deleteBtn.TabStop = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.Transparent
        Me.editBtn.BackgroundImage = Global.COST_VB.My.Resources.Resources.icons8_Edit_100
        Me.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.editBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBtn.Location = New System.Drawing.Point(500, 221)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(27, 29)
        Me.editBtn.TabIndex = 44
        Me.editBtn.TabStop = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.Transparent
        Me.addBtn.BackgroundImage = Global.COST_VB.My.Resources.Resources.icons8_Plus_96
        Me.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.Location = New System.Drawing.Point(419, 221)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(27, 29)
        Me.addBtn.TabIndex = 45
        Me.addBtn.TabStop = False
        '
        'searchBox
        '
        Me.searchBox.BackColor = System.Drawing.Color.White
        Me.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchBox.Font = New System.Drawing.Font("Oswald", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.Location = New System.Drawing.Point(166, 224)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(179, 25)
        Me.searchBox.TabIndex = 46
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.COST_VB.My.Resources.Resources.icons8_Document_100
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(459, 221)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 29)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = "Logout"
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.COST_VB.My.Resources.Resources.icons8_Back_Arrow_104
        Me.PictureBox1.InitialImage = Global.COST_VB.My.Resources.Resources.icons8_Exit_64
        Me.PictureBox1.Location = New System.Drawing.Point(584, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 108
        Me.PictureBox1.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.AccessibleDescription = "Logout"
        Me.pictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox6.Image = Global.COST_VB.My.Resources.Resources.icons8_Exit_64
        Me.pictureBox6.InitialImage = Global.COST_VB.My.Resources.Resources.icons8_Exit_64
        Me.pictureBox6.Location = New System.Drawing.Point(618, 27)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(28, 25)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox6.TabIndex = 107
        Me.pictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = Global.COST_VB.My.Resources.Resources.icons8_Logout_Rounded_Up_Filled_50__1_
        Me.PictureBox8.Location = New System.Drawing.Point(652, 27)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 106
        Me.PictureBox8.TabStop = False
        '
        'stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COST_VB.My.Resources.Resources._751
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 526)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.stockCreatedDate)
        Me.Controls.Add(Me.stockUpdatedDate)
        Me.Controls.Add(Me.stockPublisher)
        Me.Controls.Add(Me.stockAuthor)
        Me.Controls.Add(Me.stockType_view_drop)
        Me.Controls.Add(Me.stockID_view)
        Me.Controls.Add(Me.stockQuantity)
        Me.Controls.Add(Me.stockTitle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "stocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stocks"
        CType(Me.searchBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Private WithEvents stockTitle As TextBox
    Private WithEvents stockQuantity As TextBox
    Friend WithEvents stockID_view As Label
    Friend WithEvents stockType_view_drop As ComboBox
    Friend WithEvents stockAuthor As ComboBox
    Friend WithEvents stockPublisher As ComboBox
    Friend WithEvents stockUpdatedDate As Label
    Friend WithEvents stockCreatedDate As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents searchBtn As PictureBox
    Friend WithEvents deleteBtn As PictureBox
    Friend WithEvents editBtn As PictureBox
    Friend WithEvents addBtn As PictureBox
    Private WithEvents searchBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents PictureBox8 As PictureBox
End Class
