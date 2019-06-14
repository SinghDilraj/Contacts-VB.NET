Imports System.Data.OleDb
Imports System.IO
Imports ClosedXML.Excel

Public Class FormContacts
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
            Dim adapter As New OleDbDataAdapter($"select Email, GivenName from Contacts where ContactID={ContactIds.Item("ContactID")}", connection)
            adapter.Fill(table)
        End While

        ListContacts.DataSource = table

        connection.Dispose()
    End Sub

    Private Sub ToExcel_Click(sender As Object, e As EventArgs) Handles ToExcel.Click
        Dim datatable As New DataTable()

        For Each column As DataGridViewColumn In ListContacts.Columns
            datatable.Columns.Add(column.HeaderText, column.ValueType)
        Next

        For Each row As DataGridViewRow In ListContacts.Rows
            datatable.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                datatable.Rows(datatable.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next

        Dim Path As String = Directory.GetCurrentDirectory()
        Dim folderPath As String = "Path/../../../Excel/"
        Dim fileName As String = $"ContactsFor{Email}.xlsx"
        Dim fileDir As String = Directory.GetParent(folderPath + fileName).ToString()

        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Using wb As New XLWorkbook()
            wb.Worksheets.Add(datatable, "Contacts")
            wb.SaveAs(folderPath & Convert.ToString(fileName))
        End Using

        MsgBox($"Exported Successfully. File Name ->> {fileName}.", MsgBoxStyle.Information)
        Process.Start("explorer.exe", fileDir)
    End Sub

    Private Sub ButtonAccount_Click(sender As Object, e As EventArgs) Handles ButtonAccount.Click
        Dim formAccount As New FormAccount With {
            .Email = Email
        }
        formAccount.Show()
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