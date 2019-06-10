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
        Dim cmd As New OleDbCommand("select Id from Users where Email=?", connection)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email
        Dim UserId = Convert.ToInt32(cmd.ExecuteScalar())

        Dim cmnd As New OleDbCommand("Insert Into Contacts([Email], [UserId]) Values (?, ?)", connection)
        cmnd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactEmail.Text
        cmnd.Parameters.AddWithValue("@2", OleDbType.Integer).Value = UserId
        cmnd.ExecuteNonQuery()

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