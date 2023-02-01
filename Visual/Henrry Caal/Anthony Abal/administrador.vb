Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class administrador
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
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg1.CellContentClick

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

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sentencia = "Delete ingreso Where usuario= '" + txt_nombre.Text + "'"
        mensaje = "Datos eliminados"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
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

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "update ingreso set contraseña='" + txt_contraseña.Text + "',Rol='" + txt_roll.Text + "' where usuario = '" + txt_nombre.Text + "'"
        mensaje = "Datos actualizados correctamente"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *From ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sentencia = "Insert into Ingreso values('" + txt_nombre.Text + "','" + txt_contraseña.Text + "','" + txt_roll.Text + "')"
        mensaje = "Datos Insertados Correctamente"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("select *From Ingreso", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtg1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class