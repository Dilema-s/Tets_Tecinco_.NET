Imports negocio_Logica

Public Class Frm_ABMLPerona

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mensaje.InnerText = "exito???"
    End Sub

    Private Sub btnAceptar_ServerClick(sender As Object, e As EventArgs) Handles btnAceptar.ServerClick
        Dim sex As Integer

        If femenino1.Checked Then
            sex = 1
        Else
            sex = 2
        End If


        Try
            Dim blanquito As Persona = New Persona(nombreApellido.Value, Convert.ToDateTime(fechaN.Value), edad.Value, sex, 0)
            If blanquito.altaPersona() Then

                modal1.Value = "exito?"

                nombreApellido.Value = ""
                fechaN.Value = ""
                edad.Value = 0
                MsgBox("ÉXITO")
            Else
                mensaje.Attributes.Add("Value", "ERROR, CARGANDO USUARIO")
                MsgBox("ERROR DANDO DE ALTA USUARIO")
            End If
        Catch ex As Exception
            MsgBox("ERROR DANDO DE ALTA USUARIO")
        End Try




    End Sub
End Class