Imports System.Data.OleDb

Public Class FormLogin
    Dim x, y As Integer
    Dim newPoint As New Point
    Dim connection As New OleDbConnection(My.Settings.ContactsConnectionString)

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If Email.Text = Nothing Or Password.Text = Nothing Then
            MsgBox("Please enter your Email and password.", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim UserExists As New OleDbCommand("select count(*) from Users where Email=? and Password=?", connection)
            UserExists.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text
            UserExists.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text

            Dim count = Convert.ToInt32(UserExists.ExecuteScalar())
            UserExists.Dispose()

            If (count > 0) Then
                Dim formAccount As New FormAccount With {
                    .Email = Email.Text
                }
                formAccount.Show()
                Hide()
            Else
                MsgBox("Invalid Email or Password.", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If Email.Text = Nothing Or Password.Text = Nothing Then
            MsgBox("Please enter your Email and password.", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim UserExists As New OleDbCommand("select count(*) from Users where Email=?", connection)
            UserExists.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text

            Dim count = Convert.ToInt32(UserExists.ExecuteScalar())

            If (count > 0) Then
                MsgBox("User Cannot be Registered.", MsgBoxStyle.Critical)
            Else
                Dim Register As New OleDbCommand("Insert into Users([Email], [Password]) Values (?, ?)", connection)
                Register.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text
                Register.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text
                Register.ExecuteNonQuery()
                Register.Dispose()

                MsgBox("Registration Successful.", MsgBoxStyle.Information)
                Password.Text = ""
            End If
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub MouseDownEvent(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        x = Control.MousePosition.X - Location.X
        y = Control.MousePosition.Y - Location.Y

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
