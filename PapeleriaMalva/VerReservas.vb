Imports System.Data.SqlClient

Public Class VerReservas
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet
    Dim codr, f, codc, i, nc, codv, con As String

    Private Sub VerReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            Conexion.Open()

            consulta = New SqlCommand("Select Reservas.*, Clientes.nombre, Ventas.facturado from Reservas,Clientes,Ventas where reservas.codcli=clientes.codcli and reservas.codventa=ventas.codventa and ventas.codcli=clientes.codcli;", Conexion)

            ' Rellemos el datareader con los datos
            Mireader = consulta.ExecuteReader()
            ' Leemos el datareader
            While Mireader.Read()
                ' Mostramos los datos de los clientes
                codr = Mireader("codres").ToString
                f = Mireader("fecha").ToString
                codc = Mireader("codcli").ToString
                i = Mireader("importe").ToString
                nc = Mireader("nombre").ToString
                codv = Mireader("codventa").ToString
                con = Mireader("facturado").ToString
                If Not f = "" Then
                    dg.Rows.Add(codr, CDate(f), codc, nc, codv, i, con)
                Else
                    dg.Rows.Add(codr, "", codc, nc, codv, i, con)
                End If
            End While
            Mireader.Close()
            Conexion.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

   
    Private Sub bmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmostrar.Click
        Try
            cres = dg.Item(0, dg.CurrentRow.Index).Value.ToString
            fec = dg.Item(1, dg.CurrentRow.Index).Value.ToString
            ccl = dg.Item(2, dg.CurrentRow.Index).Value.ToString
            impo = CDbl(dg.Item(5, dg.CurrentRow.Index).Value)
            vres = dg.Item(4, dg.CurrentRow.Index).Value.ToString
            Me.Close()
        Catch ex As Exception
            MsgBox("Debe seleccionar un item de la lista")
        End Try
    End Sub
End Class