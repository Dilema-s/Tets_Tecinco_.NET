
Imports WindowsApp1.ServiceReference2
Imports System.Data.SqlClient

Public Class Frm_bajaModificar

    Private Sub Frm_bajaModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.formulario = 1 Then
            btnModificar.Visible = False
        Else
            If Form1.formulario = 2 Then
                btnEliminar.Visible = False
            Else
                btnModificar.Visible = False
                btnEliminar.Visible = False
            End If
        End If

        actualizarPersonas()


    End Sub


    Public Shared id_persona1 As Integer = 0 ' declararla como public shared te permite usarla en todo el proyecto.
    Public Shared nombre As String = "" ' declararla como public shared te permite usarla en todo el proyecto.
    Public Shared fecha As DateTime ' declararla como public shared te permite usarla en todo el proyecto.
    Public Shared edad As Integer = 0 ' declararla como public shared te permite usarla en todo el proyecto.
    Public Shared sexo As String = 0 ' declararla como public shared te permite usarla en todo el proyecto.

    Private Sub actualizarPersonas()
        Try
            Dim ws As New ServiceReference2.ServiceSoapClient


            Dim lista As List(Of String) = New List(Of String)

            lista = ws.getAll()
            Dim sexo As String

            Dim tabla As DataTable = New DataTable

            tabla.Columns.Add("id_persona")
            tabla.Columns.Add("nombreApellido")
            tabla.Columns.Add("fechaNacimiento")
            tabla.Columns.Add("edad")
            tabla.Columns.Add("sexo")

            For i = 0 To lista.Count - 1 Step +6
                If lista.Item(4 + i).ToString() = 1 Then
                    sexo = "FEMENINO"
                Else
                    sexo = "MASCULINO"
                End If

                tabla.Rows.Add(lista.Item(0 + i).ToString(), lista.Item(1 + i).ToString(), lista.Item(2 + i).ToString(), lista.Item(3 + i).ToString(), sexo)

            Next i

            dgvPersona.DataSource = tabla


        Catch ex As Exception

            MsgBox("Ha ocurrido un error para Conectarse al WebService!", MsgBoxStyle.Critical, "Advertencia")

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim selectedRowCount As Integer = dgvPersona.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            If selectedRowCount = 1 Then
                Dim indice As Integer = dgvPersona.SelectedRows(0).Index

                id_persona1 = Convert.ToInt32(dgvPersona.Rows(indice).Cells(0).Value)
                nombre = Convert.ToString(dgvPersona.Rows(indice).Cells(1).Value)
                fecha = Convert.ToDateTime(dgvPersona.Rows(indice).Cells(2).Value)
                edad = Convert.ToInt32(dgvPersona.Rows(indice).Cells(3).Value)
                sexo = Convert.ToString(dgvPersona.Rows(indice).Cells(4).Value)
                Dim frm As Form
                frm = New Form1
                Dim result As DialogResult = frm.ShowDialog()
                If DialogResult.OK Then
                    actualizarPersonas()
                End If



            End If

        Else

            MsgBox("POR FAVOR SELECCIONE UNA PERSONA")
        End If


    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            BajaUsuario()
            actualizarPersonas()

        Catch ex As Exception

            MsgBox("Ha ocurrido un error para Conectarse al WebService!", MsgBoxStyle.Critical, "Advertencia")

        End Try


    End Sub

    Sub BajaUsuario()

        'Crea la referencia al web service 

        Dim ws As New ServiceReference2.ServiceSoapClient
        Dim selectedRowCount As Integer = dgvPersona.Rows.GetRowCount(DataGridViewElementStates.Selected)

        If selectedRowCount > 0 Then

            If selectedRowCount = 1 Then
                Dim indice As Integer = dgvPersona.SelectedRows(0).Index

                id_persona1 = Convert.ToInt32(dgvPersona.Rows(indice).Cells(0).Value)

                Dim funciono As Boolean = ws.bajaPersona(id_persona1)

                ' MsgBox(funciono)

                If funciono Then

                    MsgBox("El usuario ha sido dadode baja Correctamente!", MsgBoxStyle.Information, "Notificacion")

                Else

                    MsgBox("El usuario NO ha sido dado de baja, Verifique!", MsgBoxStyle.Exclamation, "Notificacion")

                End If

            End If

        Else

            MsgBox("POR FAVOR SELECCIONE UNA PERSONA")
        End If

    End Sub







End Class
