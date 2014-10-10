Imports System.Data.SqlClient

Public Class FacturarCaja
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Dim fechahoy As String

    Private Sub FacturarCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        bfacturar.Enabled = False
        Dim v As String
        Dim fe As Date
        Dim im, iva, base As Double
        Dim porc As Integer
        dg.Rows.Clear()
        fechahoy = DateTime.Now().ToShortDateString()
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select Ventas.codventa,Ventas.fecha,Ventas.baseimponible,Ventas.porcentajeiva,Ventas.iva,Ventas.importe from Ventas where fecha='" & fechahoy & "' and Ventas.codcli=1;", Conexion)
            ' Rellemos el datareader con los datos
            Mireader = consulta.ExecuteReader()
            ' Leemos el datareader
            While Mireader.Read()
                ' Mostramos los datos de los clientes
                v = Mireader("codventa").ToString
                fe = Mireader("fecha").ToString
                base = Mireader("baseimponible").ToString
                porc = Mireader("porcentajeiva").ToString()
                iva = Mireader("iva").ToString()
                im = Mireader("importe").ToString
                dg.Rows.Add(v, CDate(fe), base, porc, iva, im)
            End While
            Mireader.Close()
            Conexion.Close()

            CalcularImportes()
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("No ha introducido ningun código de cliente")
            Mireader.Close()
            Conexion.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub CalcularImportes()
        Dim a, b As Double
        Dim imponible As Double
        ' Calculamos la linea correspondiente
        Dim importetotal As Double = 0.0
        For i = 0 To dg.RowCount - 1
            importetotal = importetotal + dg.Item(2, i).Value
        Next
        lbase.Text = Format(importetotal, "N2")
        ltotal.Text = Format(importetotal, "N2")
        Mireader.Close()
        Conexion.Close()
        bfacturar.Enabled = True
    End Sub

    Private Sub bfacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bfacturar.Click
        Dim cant As Integer = 0
        Dim contador As Integer = 0
        Dim codigoF As String
        ' Calcula la cantidad de facturas
        Try
            Conexion.Open()
            ' Obtenemos el Nº de Factura contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codfact) from Facturas", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número
            codigoF = (contador + 1).ToString
            Conexion.Close()
            'MsgBox("Hay " & contador & " facturas")
        Catch ex As Exception
            Conexion.Close()
        End Try

        Try  ' Damos de alta la cabecera de la factura
            Conexion.Open()
            consulta = New SqlCommand("Insert into Facturas (codfact,fecha,codcli,total,formapago)" &
                " values('" & codigoF & "','" &
                fechahoy & "','" & "1" & "'," & ltotal.Text.Replace(".", "").Replace(",", ".") & ",'" & "1" & "');", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("Factura dada de alta")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try 'Damos de alta el cuerpo de la factura
            Conexion.Open()
            consulta = New SqlCommand("Insert into LineasFactura(codfact,numlinea,descripcion) values ('" &
                                          codigoF & "','" & "1" & "','" &
                                          "CAJA DIARIA" & "')", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("LineasFactura dada de alta")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub
End Class