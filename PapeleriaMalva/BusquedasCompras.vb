Imports System.Data.SqlClient

Public Class BusquedasCompras
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim item As Integer

    Dim codc, f, codp, i, np As String

    Private Sub BusquedasCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.Items.Add("Nº COMPRA")
            ComboBox1.Items.Add("CODIGO CLIENTE")
            ComboBox1.SelectedIndex = 0
            baceptar.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        dg.Rows.Clear()

        item = CInt(ComboBox1.SelectedIndex + 1)
        Dim cadena As String
        cadena = tbuscar.Text

        If item = 1 Then        ' Está buscando por nº de compra
            If IsNumeric(tbuscar.Text) And Not tbuscar.Text = "" Then
                Try
                    Conexion.Open()
                    consulta = New SqlCommand("Select Compras.codcompra,Compras.fecha,Compras.codprov,Compras.total,Proveedores.nombre from Compras,Proveedores where Compras.codcompra='" & cadena & "' and Compras.codprov=Proveedores.codprov;", Conexion)
                    ' Rellemos el datareader con los datos
                    Mireader = consulta.ExecuteReader()
                    ' Leemos el datareader
                    While Mireader.Read()
                        ' Mostramos los datos de los clientes
                        codc = Mireader("codcompra").ToString
                        f = Mireader("fecha").ToString
                        codp = Mireader("codprov").ToString
                        i = Mireader("total").ToString
                        np = Mireader("nombre").ToString
                        If Not f = "" Then
                            dg.Rows.Add(codc, CDate(f), codp, np, i)
                        Else
                            dg.Rows.Add(codc, "", codp, np, i)
                        End If
                    End While
                    Mireader.Close()
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    'MsgBox("No ha introducido ningun código de cliente")
                    Mireader.Close()
                    Conexion.Close()
                End Try
            Else

                MsgBox("El nº de la compra debe ser un valor numérico")
            End If

        ElseIf item = 2 Then    ' Está buscando por el codigo del proveedor

            If IsNumeric(tbuscar.Text) And Not tbuscar.Text = "" Then
                Try
                    Conexion.Open()
                    consulta = New SqlCommand("Select Compras.codcompra,Compras.fecha,Compras.codprov,Compras.total,Proveedores.nombre from Compras,Proveedores where Compras.codprov='" & cadena & "' and Compras.codprov=Proveedores.codprov;", Conexion)
                    ' Rellemos el datareader con los datos
                    Mireader = consulta.ExecuteReader()
                    ' Leemos el datareader
                    While Mireader.Read()
                        ' Mostramos los datos de los clientes
                        codc = Mireader("codcompra").ToString
                        f = Mireader("fecha").ToString
                        codp = Mireader("codprov").ToString
                        i = Mireader("total").ToString
                        np = Mireader("nombre").ToString
                        If Not f = "" Then
                            dg.Rows.Add(codc, CDate(f), codp, np, i)
                        Else
                            dg.Rows.Add(codc, "", codp, np, i)
                        End If

                    End While
                    Mireader.Close()
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    'MsgBox("No ha introducido ningun código de cliente")
                    Mireader.Close()
                    Conexion.Close()

                End Try
            Else
                MsgBox("El nº del proveedor debe ser un valor numérico")
            End If
        End If
        tbuscar.Text = ""
        baceptar.Enabled = True

    End Sub

    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        Try
            cco = dg.Item(0, dg.CurrentRow.Index).Value.ToString
            fe = dg.Item(1, dg.CurrentRow.Index).Value.ToString
            cpr = dg.Item(2, dg.CurrentRow.Index).Value.ToString
            im = CDbl(dg.Item(4, dg.CurrentRow.Index).Value)
            Me.Close()
        Catch ex As Exception
            MsgBox("Debe seleccionar un item de la lista")
        End Try
    End Sub
End Class