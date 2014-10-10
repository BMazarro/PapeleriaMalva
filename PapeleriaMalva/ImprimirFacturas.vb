Imports System.Data.SqlClient

Public Class ImprimirFacturas
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Private Sub ImprimirFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        dg.Rows.Clear()
        Dim tipo As String
        ' Cargamos los datos de las facturas
        Try
            Conexion.Open()
            tipo = "N"
            consulta = New SqlCommand("Select codfact, fecha, codcli, impreso, porcentajeiva, formapago, total, sustituida from Facturas", Conexion)
            Mireader = consulta.ExecuteReader() ' Devuelve un conjunto de registros
            While Mireader.Read
                ''Dim c As String
                ''c = Mireader.GetValue(2).ToString
                ''If Not c = 1 Then
                ''    dg.Rows.Add(Mireader.GetValue(0), Format(Mireader.GetValue(1), "d"), Mireader.GetValue(2), Mireader.GetValue(3), Mireader.GetValue(4), Mireader.GetValue(5), Mireader.GetValue(6), tipo, Mireader.GetValue(7))
                ''End If
                dg.Rows.Add(Mireader.GetValue(0), Format(Mireader.GetValue(1), "d"), Mireader.GetValue(2), Mireader.GetValue(3), Mireader.GetValue(4), Mireader.GetValue(5), Mireader.GetValue(6), tipo, Mireader.GetValue(7))
            End While
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
        End Try

        Try
            Conexion.Open()
            tipo = "R"
            consulta = New SqlCommand("Select codfact, fecha, codcli, impreso, porcentajeiva, formapago, total from FacturasRectificativas", Conexion)
            Mireader = consulta.ExecuteReader() ' Devuelve un conjunto de registros
            While Mireader.Read
                dg.Rows.Add(Mireader.GetValue(0), Format(Mireader.GetValue(1), "d"), Mireader.GetValue(2), Mireader.GetValue(3), Mireader.GetValue(4), Mireader.GetValue(5), Mireader.GetValue(6), tipo)
            End While
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim codigo As String
        Dim cliente As String

        codigo = CStr(dg.SelectedRows(0).Cells(0).Value)
        cliente = CStr(dg.SelectedRows(0).Cells(2).Value)
        ' Creamos una nueva conexion
        Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        ' Creamos un Visor
        Dim visor As New Visor
        ' Creamos un dataset
        Dim dataset As New PapeleriaDataSet
        ' Creamos un Listado para Albaranes
        Dim listado As New Factura
        ' Creamos un DataAdapter
        Dim da1 As SqlClient.SqlDataAdapter


        ' Creamos las consultas y rellenamos el dataset 
        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Facturas WHERE Facturas.codfact= '" & codigo & "';", Conexion2)
        da1.Fill(dataset, "FACTURAS")
        da1 = New SqlClient.SqlDataAdapter("SELECT LineasFactura.* FROM LineasFactura WHERE LineasFactura.codfact = '" & codigo & "';", Conexion2)

        Try
            da1.Fill(dataset, "LINEASFACTURA")
        Catch ex As System.Data.ConstraintException
            da1.Fill(dataset, "LINEASFACTURA")
        End Try

        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Clientes WHERE Clientes.codcli = '" & cliente & "';", Conexion2)
        da1.Fill(dataset, "CLIENTES")
        da1 = New SqlClient.SqlDataAdapter("SELECT FormasPago.* FROM FormasPago, FacturaS WHERE Facturas.formapago = FormasPago.tipo and Facturas.codfact= '" & codigo & "';", Conexion2)
        Try
            da1.Fill(dataset, "FORMASPAGO")
        Catch ex As System.Data.ConstraintException
            da1.Fill(dataset, "FORMASPAGO")
        End Try
        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa;", Conexion2)
        da1.Fill(dataset, "EMPRESA")
        '---Cerramos la conexion 
        Conexion2.Close()

        ' Preparamos el Visor 
        visor.CrViewer.ReportSource = listado
        listado.SetDataSource(dataset)

        ' Mostramos el Visor
        visor.Show()



        'Mostramos los parámetros de los datos de Empresa
        'listado.SetParameterValue("nombre", razon.ToString)
        'listado.SetParameterValue("domicilio", domicilio.ToString)
        'listado.SetParameterValue("localidad", localidad.ToString)
        'listado.SetParameterValue("provincia", provincia.ToString)
        'listado.SetParameterValue("cp", cp.ToString)
        'listado.SetParameterValue("nif", nif.ToString)
        'listado.SetParameterValue("telefono", telefono.ToString)


        ' Ponemos la factura impresa
        Try
            Conexion.Open()
            consulta = New SqlCommand("Update Facturas set impreso = 'S' where codfact = '" & codigo & "'", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
        Finally
            Conexion.Close()
        End Try
       
    End Sub
End Class