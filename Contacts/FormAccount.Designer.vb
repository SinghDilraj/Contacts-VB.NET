<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccount
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Contacts = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.UserEmail = New System.Windows.Forms.TextBox()
        Me.Welcome = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ButtonClose)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 25)
        Me.Panel3.TabIndex = 11
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Contacts.My.Resources.Resources.contactsBookIcon
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Contacts
        '
        Me.Contacts.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Contacts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Contacts.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contacts.ForeColor = System.Drawing.Color.White
        Me.Contacts.Location = New System.Drawing.Point(99, 240)
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Size = New System.Drawing.Size(129, 31)
        Me.Contacts.TabIndex = 13
        Me.Contacts.Text = "Contacts"
        Me.Contacts.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Location = New System.Drawing.Point(99, 310)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(129, 31)
        Me.Logout.TabIndex = 14
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'UserEmail
        '
        Me.UserEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.UserEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserEmail.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserEmail.ForeColor = System.Drawing.SystemColors.Window
        Me.UserEmail.Location = New System.Drawing.Point(34, 193)
        Me.UserEmail.Name = "UserEmail"
        Me.UserEmail.ShortcutsEnabled = False
        Me.UserEmail.Size = New System.Drawing.Size(267, 25)
        Me.UserEmail.TabIndex = 15
        Me.UserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Welcome
        '
        Me.Welcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Welcome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Welcome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Welcome.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.ForeColor = System.Drawing.SystemColors.Window
        Me.Welcome.Location = New System.Drawing.Point(115, 148)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.ShortcutsEnabled = False
        Me.Welcome.Size = New System.Drawing.Size(97, 25)
        Me.Welcome.TabIndex = 16
        Me.Welcome.Text = "Welcome"
        Me.Welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 429)
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.UserEmail)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Contacts)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAccount"
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Contacts As Button
    Friend WithEvents Logout As Button
    Friend WithEvents UserEmail As TextBox
    Friend WithEvents Welcome As TextBox
End Class
