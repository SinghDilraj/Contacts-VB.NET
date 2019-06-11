<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddContact
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ContactEmail = New System.Windows.Forms.TextBox()
        Me.ButtonAddContact = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ButtonClose)
        Me.Panel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 25)
        Me.Panel3.TabIndex = 12
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
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(45, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 1)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Contacts.My.Resources.Resources.EmailIcon
        Me.PictureBox2.Location = New System.Drawing.Point(45, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'ContactEmail
        '
        Me.ContactEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ContactEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactEmail.ForeColor = System.Drawing.SystemColors.Window
        Me.ContactEmail.Location = New System.Drawing.Point(101, 184)
        Me.ContactEmail.Name = "ContactEmail"
        Me.ContactEmail.Size = New System.Drawing.Size(194, 19)
        Me.ContactEmail.TabIndex = 17
        '
        'ButtonAddContact
        '
        Me.ButtonAddContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ButtonAddContact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddContact.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddContact.ForeColor = System.Drawing.Color.White
        Me.ButtonAddContact.Location = New System.Drawing.Point(118, 257)
        Me.ButtonAddContact.Name = "ButtonAddContact"
        Me.ButtonAddContact.Size = New System.Drawing.Size(102, 31)
        Me.ButtonAddContact.TabIndex = 18
        Me.ButtonAddContact.Text = "Add Contact"
        Me.ButtonAddContact.UseVisualStyleBackColor = False
        '
        'FormAddContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 429)
        Me.Controls.Add(Me.ButtonAddContact)
        Me.Controls.Add(Me.ContactEmail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAddContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAddContact"
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContactEmail As TextBox
    Friend WithEvents ButtonAddContact As Button
End Class
