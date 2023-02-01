Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class cliente
    Dim con As New SqlConnection(My.Settings.conection)
    Dim mensaje, sentencia As String
    Sub EjecutarSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("select * from ingreso where usuario = '" + txt_nombre.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dtg1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Try
            Dim da As New SqlDataAdapter("Select * From Ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class