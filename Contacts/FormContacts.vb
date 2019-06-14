Imports System.Data.OleDb

Public Class FormContacts
    Dim x, y As Integer
    Dim newPoint As New Point
    Public Email As String
    Dim connection As New OleDbConnection(My.Settings.ContactsConnectionString)
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub MouseDownEvent(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Location.X
        y = Control.MousePosition.Y - Location.Y

    End Sub

    Private Sub FormContacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim GetUserId As New OleDbCommand("select UserID from Users where Email=?", connection)
        GetUserId.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email
        Dim UserId = Convert.ToInt32(GetUserId.ExecuteScalar())

        Dim GetContactIDs As New OleDbCommand("select ContactID from UsersContacts where UserID=?", connection)
        GetContactIDs.Parameters.AddWithValue("@1", OleDbType.Integer).Value = UserId
        Dim ContactIds = GetContactIDs.ExecuteReader()

        Dim table As New DataTable()

        While ContactIds.Read()
            Dim adapter As New OleDbDataAdapter($"select Email from Contacts where ContactID={ContactIds.Item("ContactID")}", connection)
            adapter.Fill(table)
        End While

        ListContacts.DataSource = table
        ListContacts.DisplayMember = "Email"
        ListContacts.ValueMember = "Email"
        connection.Dispose()
    End Sub

    Private Sub ButtonAddContact_Click(sender As Object, e As EventArgs) Handles ButtonAddContact.Click
        Dim formAddContact As New FormAddContact With {
            .Email = Email
        }
        formAddContact.Show()
        Close()
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