Imports System.Data.OleDb

Public Class FormLogin
    Dim connection As New OleDbConnection(My.Settings.ContactsConnectionString)

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If Email.Text = Nothing Or Password.Text = Nothing Then
            MsgBox("Please enter your Email and password.", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from Users where Email=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            cmd.Dispose()
            If (count > 0) Then
                MsgBox("Login Successfull.", MsgBoxStyle.Information)
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
            Dim cmd As New OleDbCommand("select count(*) from Users where Email=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("User Cannot be Registered.", MsgBoxStyle.Critical)
            Else
                Dim cmnd As New OleDbCommand("Insert into Users([Email], [Password]) Values (?, ?)", connection)
                cmnd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = Email.Text
                cmnd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text
                cmnd.ExecuteNonQuery()
                cmnd.Dispose()

                MsgBox("Registration Successful.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
