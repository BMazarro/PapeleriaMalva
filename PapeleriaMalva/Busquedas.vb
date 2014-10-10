Imports System.Data.SqlClient

Public Class Busquedas
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim item As Integer

    Dim codv, f, codc, i, nc As String

    Private Sub Busquedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.Items.Add("Nº VENTA")
            ComboBox1.Items.Add("COD. CLIENTE")
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

        If item = 1 Then
            If IsNumeric(tbuscar.Text) And Not tbuscar.Text = "" Then
                Try
                    Conexion.Open()
                    consulta = New SqlCommand("Select Ventas.codventa,Ventas.fecha,Ventas.codcli,Ventas.importe,Clientes.nombre from Ventas,Clientes where codventa='" & cadena & "' and Ventas.codcli=Clientes.codcli;", Conexion)
                    ' Rellemos el datareader con los datos
                    Mireader = consulta.ExecuteReader()
                    ' Leemos el datareader
                    While Mireader.Read()
                        ' Mostramos los datos de los clientes
                        codv = Mireader("codventa").ToString
                        f = Mireader("fecha").ToString
                        codc = Mireader("codcli").ToString
                        i = Mireader("importe").ToString
                        nc = Mireader("nombre").ToString
                        If Not f = "" Then
                            dg.Rows.Add(codv, CDate(f), codc, nc, Format(CDbl(i), "N2"))
                        Else
                            dg.Rows.Add(codv, "", codc, nc, Format(CDbl(i), "N2"))
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

                MsgBox("El nº de la venta debe ser un valor numérico")
            End If
        Else
            If IsNumeric(tbuscar.Text) And Not tbuscar.Text = "" Then
                Try
                    Conexion.Open()
                    consulta = New SqlCommand("Select Ventas.codventa,Ventas.fecha,Ventas.codcli,Ventas.importe,Clientes.nombre from Ventas,Clientes where Clientes.codcli='" & cadena & "' and Clientes.codcli=Ventas.codcli;", Conexion)
                    ' Rellemos el datareader con los datos
                    Mireader = consulta.ExecuteReader()
                    ' Leemos el datareader
                    While Mireader.Read()
                        ' Mostramos los datos de los clientes
                        codv = Mireader("codventa").ToString
                        f = Mireader("fecha").ToString
                        codc = Mireader("codcli").ToString
                        i = Mireader("importe").ToString
                        nc = Mireader("nombre").ToString
                        If Not f = "" Then
                            dg.Rows.Add(codv, CDate(f), codc, nc, Format(CDbl(i), "N2"))
                        Else
                            dg.Rows.Add(codv, "", codc, nc, Format(CDbl(i), "N2"))
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
                MsgBox("El nº del cliente debe ser un valor numérico")
            End If
        End If
        tbuscar.Text = ""
        baceptar.Enabled = True

    End Sub

   
    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        Try
            cv = dg.Item(0, dg.CurrentRow.Index).Value.ToString
            f = dg.Item(1, dg.CurrentRow.Index).Value.ToString
            cc = dg.Item(2, dg.CurrentRow.Index).Value.ToString
            imp = CDbl(dg.Item(4, dg.CurrentRow.Index).Value)
            Me.Close()
        Catch ex As Exception
            MsgBox("Debe seleccionar un item de la lista")
        End Try
    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class