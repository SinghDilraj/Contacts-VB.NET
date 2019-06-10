Imports System.Data.OleDb

Public Class FormAccount
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

    Private Sub FormAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserEmail.Text = Email
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Hide()
        Dim formLogin As New FormLogin()
        formLogin.Show()
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