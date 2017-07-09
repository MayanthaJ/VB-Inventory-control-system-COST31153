<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.UserNameTxtbox = New System.Windows.Forms.TextBox()
        Me.PwordTextbox = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(170, 132)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(145, 37)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Bookshop"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Purple
        Me.label3.Location = New System.Drawing.Point(170, 100)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(201, 37)
        Me.label3.TabIndex = 12
        Me.label3.Text = "Gunawardene "
        Me.label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(84, 100)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(101, 69)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label2.Location = New System.Drawing.Point(82, 256)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(85, 21)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Password"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(82, 217)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(89, 21)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Username"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.DimGray
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginBtn.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.loginBtn.Location = New System.Drawing.Point(177, 300)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(179, 27)
        Me.loginBtn.TabIndex = 8
        Me.loginBtn.Text = "Log in"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'UserNameTxtbox
        '
        Me.UserNameTxtbox.BackColor = System.Drawing.Color.White
        Me.UserNameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserNameTxtbox.Location = New System.Drawing.Point(177, 221)
        Me.UserNameTxtbox.Name = "UserNameTxtbox"
        Me.UserNameTxtbox.Size = New System.Drawing.Size(179, 20)
        Me.UserNameTxtbox.TabIndex = 6
        '
        'PwordTextbox
        '
        Me.PwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PwordTextbox.Location = New System.Drawing.Point(177, 260)
        Me.PwordTextbox.Name = "PwordTextbox"
        Me.PwordTextbox.Size = New System.Drawing.Size(179, 20)
        Me.PwordTextbox.TabIndex = 7
        Me.PwordTextbox.UseSystemPasswordChar = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.COST_VB.My.Resources.Resources._751
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 398)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.UserNameTxtbox)
        Me.Controls.Add(Me.PwordTextbox)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents loginBtn As Button
    Private WithEvents UserNameTxtbox As TextBox
    Private WithEvents PwordTextbox As TextBox
End Class
