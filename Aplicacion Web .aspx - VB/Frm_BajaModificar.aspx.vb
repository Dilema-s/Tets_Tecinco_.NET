Imports Negocio_logica
Public Class Frm_BajaModificar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getAll()
    End Sub

    Private Sub getAll()

        Try
            Dim blanquito As Persona = New Persona()
            repeater.DataSource = blanquito.getPersonas()
            repeater.DataBind()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub baja1_ServerClick(sender As Object, e As EventArgs) Handles baja1.ServerClick

        Try
            Dim blanquito As Persona = New Persona()
            If blanquito.bajaPersona(Text1.Value) Then
                MsgBox("EXITO")
            Else
                MsgBox("ERROR baja")
            End If
        Catch ex As Exception
            MsgBox("ERROR baja")
        End Try
        getAll()

    End Sub

    Private Sub btnModificar_ServerClick(sender As Object, e As EventArgs) Handles btnModificar.ServerClick
        Try
            Dim blanquito As Persona = New Persona()

            Dim sex As Integer
            If masculino1.Checked Then
                sex = 2
            Else
                sex = 1
            End If

            If blanquito.modificarPersona(id_persona.Value, nombreApellido.Value, fechaN.Value, edad.Value, sex) Then
                MsgBox("EXITO")
            Else
                MsgBox("ERROR Modificar Persona")
            End If
        Catch ex As Exception
            MsgBox("ERROR Modificar Persona")
        End Try
        getAll()
    End Sub
End Class