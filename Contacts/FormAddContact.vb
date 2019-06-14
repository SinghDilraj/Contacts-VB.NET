Imports System.Data.OleDb

Public Class FormAddContact
    Dim x, y As Integer
    Dim newPoint As New Point
    Public Email As String
    Dim connection As New OleDbConnection(My.Settings.ContactsConnectionString)
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Dim formAccount As New FormAccount With {
            .Email = Email
        }
        formAccount.Show()
        Close()
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

        If ContactEmail IsNot Nothing And ContactName IsNot Nothing Then
            If ContactEmail.Text.Contains("@") And
                ContactEmail.Text.Contains(".") And
                ContactEmail.Text.Length > 5 Then

                Dim AddContact As New OleDbCommand("Insert Into Contacts([Email], [GivenName]) Values (?, ?)", connection)
                AddContact.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactEmail.Text
                AddContact.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactName.Text
                AddContact.ExecuteNonQuery()

                Dim GetContactId As New OleDbCommand("select ContactID from Contacts where Email=?", connection)
                GetContactId.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = ContactEmail.Text
                Dim ContactId = Convert.ToInt32(GetContactId.ExecuteScalar())

                Dim CreateRelation As New OleDbCommand("Insert Into UsersContacts([UserID], [ContactID]) Values (?, ?)", connection)
                CreateRelation.Parameters.AddWithValue("@1", OleDbType.Integer).Value = UserId
                CreateRelation.Parameters.AddWithValue("@2", OleDbType.Integer).Value = ContactId
                CreateRelation.ExecuteNonQuery()

                Dim formContacts As New FormContacts With {
                .Email = Email
                }
                Close()
                formContacts.Show()

                connection.Close()
            Else
                MsgBox("Invalid Email. Must include '@' and '.' characters.", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Contact Email and Name is Required.", MsgBoxStyle.Critical)
        End If

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