Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form1
    Dim con As New SqlConnection(My.Settings.conection)
    Dim da As New SqlCommand

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If txt_usuario.Text = "Jose" And txt_contraseña.Text = "1234J" Then
            Me.Hide()
            administrador.Show()

        ElseIf txt_usuario.Text = "Canelin" And txt_contraseña.Text = "1234C" Then
            Me.Hide()
            secretario.Show()

        ElseIf txt_usuario.Text = "Gabo" And txt_contraseña.Text = "1234G" Then
            Me.Hide()
            cliente.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
