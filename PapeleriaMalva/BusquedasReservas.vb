Imports System.Data.SqlClient

Public Class BusquedasReservas

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim Mireader2 As SqlDataReader
    Dim item As Integer

    Dim codr, f, codc, i, nc, codv As String

    Private Sub BusquedasReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.Items.Add("Nº RESERVA")
            ComboBox1.Items.Add("CODIGO DE CLIENTE")
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
                    consulta = New SqlCommand("Select Reservas.codres,Reservas.fecha,Reservas.codcli,Reservas.importe,Reservas.codventa,Clientes.nombre from Reservas,Clientes where codres='" & cadena & "' and Reservas.codcli=Clientes.codcli;", Conexion)
                    ' Rellemos el datareader con los datos
                    Mireader = consulta.ExecuteReader()

                    'consulta = New SqlCommand("Select Ventas.conreserva from Reservas,Ventas where codres='" & cadena & "' and Reservas.codventa=Ventas.codventa;", Conexion)
                    '' Rellemos el datareader con los datos
                    'Mireader2 = consulta.ExecuteReader()

                    ' Leemos el datareader
                    While Mireader.Read()
                        ' Mostramos los datos de los clientes
                        codr = Mireader("codres").ToString
                        f = Mireader("fecha").ToString
                        codc = Mireader("codcli").ToString
                        i = Mireader("importe").ToString
                        nc = Mireader("nombre").ToString
                        codv = Mireader("codventa").ToString

                        If Not f = "" Then
                            dg.Rows.Add(codr, CDate(f), codc, nc, codv, Format(CDbl(i), "N2"))
                        Else
                            dg.Rows.Add(codr, "", codc, nc, codv, Format(CDbl(i), "N2"))
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
                MsgBox("El nº de la reserva debe ser un valor numérico")
            End If
        Else
            If IsNumeric(tbuscar.Text) And Not tbuscar.Text = "" Then
                Try
                    Conexion.Open()
                    consulta = New SqlCommand("Select Reservas.codres,Reservas.fecha,Reservas.codcli,Reservas.importe,Reservas.codventa,Clientes.nombre from Reservas,Clientes where Reservas.codcli='" & cadena & "' and Clientes.codcli=Reservas.codcli;", Conexion)
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
                        If Not f = "" Then
                            dg.Rows.Add(codr, CDate(f), codc, nc, codv, Format(CDbl(i), "N2"))
                        Else
                            dg.Rows.Add(codr, "", codc, nc, codv, Format(CDbl(i), "N2"))
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