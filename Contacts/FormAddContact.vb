Imports System.Data.OleDb

Public Class FormAddContact
    Dim x, y As Integer
    Dim newPoint As New Point
    Public Email As String
    Dim connection As New OleDbConnection(My.Settings.ContactsConnectionString)
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim formContacts As New FormContacts With {
            .Email = Email
        }
        Close()
        formContacts.Show()
    End Sub

    Private Sub MouseDownEvent(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Location.X
        y = Control.MousePosition.Y - Location.Y

    End Sub

    Private Sub ButtonAddContact_Click(sender As Object, e As EventArgs) Handles ButtonAddContact.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim GetUserId As New OleDbCommand("select UserID from Users where Email=?", connection)
        GetUserId.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email
        Dim UserId = Convert.ToInt32(GetUserId.ExecuteScalar())

        If ContactEmail IsNot Nothing Then
            Dim cmnd As New OleDbCommand("Insert Into Contacts([Email]) Values (?)", connection)
            cmnd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactEmail.Text
            cmnd.ExecuteNonQuery()

            Dim comand As New OleDbCommand("select ContactID from Contacts where Email=?", connection)
            comand.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactEmail.Text
            Dim ContactId = Convert.ToInt32(comand.ExecuteScalar())

            Dim comnd As New OleDbCommand("Insert Into UsersContacts([UserID], [ContactID]) Values (?, ?)", connection)
            comnd.Parameters.AddWithValue("@1", OleDbType.Integer).Value = UserId
            comnd.Parameters.AddWithValue("@2", OleDbType.Integer).Value = ContactId
            comnd.ExecuteNonQuery()
        Else
            MsgBox("Contact Email is Required.", MsgBoxStyle.Critical)
        End If

        connection.Dispose()

        Dim formContacts As New FormContacts With {
            .Email = Email
        }
        Close()
        formContacts.Show()
    End Sub

    Private Sub MouseMoveEvent(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X -= x
            newPoint.Y -= y
            Location = newPoint
            Application.DoEvents()
        End If
    End Sub
End Class