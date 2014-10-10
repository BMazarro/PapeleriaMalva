Imports System.Data.SqlClient

Module VariablesGlobales
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader

    Public ventana As Integer       ' 1 esta en ventas | 2 esta en compras | 3 esta en reservas
    ' Variables de producto
    Public codproducto As String
    ' Variables de libros
    Public titulolibro As String
    Public autorlibro As String
    Public editoriallibro As String
    Public paginaslibro As String
    Public cursolibro As String
    Public stocklibro As Integer
    Public pvplibro As Double
    ' Variables de articulo
    Public codart As String
    Public descripcionart As String
    Public observacionesart As String
    Public stockart As Integer
    Public precioultcart As Double
    Public pvpart As Double
    Public fechaultcart As Date
    ' Variables de empresa
    Public razon As String
    Public nif As String
    Public domicilio As String
    Public cp As String
    Public localidad As String
    Public provincia As String
    Public telefono As String
    ' Variables de venta
    Public cv As String     ' cod venta
    Public f As Date        ' fecha de venta
    Public cc As String     ' cod cliente
    Public imp As Double    ' importe de venta
    ' Variables de compra
    Public cco As String    ' cod compra
    Public fe As Date       ' fecha de compra
    Public cpr As String    ' cod proveedor
    Public im As Double     ' importe de compra
    ' Variabled de reserva
    Public cres As String   ' cod reserva
    Public fec As Date      ' fecha de reserva
    Public ccl As String    ' cod cliente
    Public impo As Double   ' importe de reserva
    Public vres As String   ' venta asociada a la reserva

    Public Sub leerDatosEmpresa()
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select razon,domicilio,localidad,provincia,cp,nif,telefono from Empresa", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            razon = Mireader("razon").ToString
            domicilio = Mireader("domicilio").ToString
            localidad = Mireader("localidad").ToString
            provincia = Mireader("provincia").ToString
            cp = Mireader("cp").ToString
            nif = Mireader("nif").ToString
            telefono = Mireader("telefono").ToString
            Conexion.Close()
            'MsgBox("" & razon & " " & domicilio & " " & localidad)
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
            Mireader.Close()
        End Try
    End Sub
End Module
