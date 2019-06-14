<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Email
        '
        Me.Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Email.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.SystemColors.Window
        Me.Email.Location = New System.Drawing.Point(116, 186)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(194, 19)
        Me.Email.TabIndex = 1
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.SystemColors.Window
        Me.Password.Location = New System.Drawing.Point(116, 262)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(194, 19)
        Me.Password.TabIndex = 2
        Me.Password.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(60, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 1)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Location = New System.Drawing.Point(60, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 1)
        Me.Panel2.TabIndex = 6
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(97, 314)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(129, 31)
        Me.ButtonLogin.TabIndex = 7
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.ForeColor = System.Drawing.Color.White
        Me.ButtonRegister.Location = New System.Drawing.Point(97, 386)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(129, 31)
        Me.ButtonRegister.TabIndex = 8
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.SystemColors.Window
        Me.ButtonClose.Location = New System.Drawing.Point(306, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(27, 25)
        Me.ButtonClose.TabIndex = 9
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ButtonClose)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 25)
        Me.Panel3.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Contacts.My.Resources.Resources.PasswordIcon
        Me.PictureBox3.Location = New System.Drawing.Point(60, 251)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Contacts.My.Resources.Resources.EmailIcon
        Me.PictureBox2.Location = New System.Drawing.Point(60, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Contacts.My.Resources.Resources.contactsBookIcon
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(148, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Or"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 429)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Email As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
