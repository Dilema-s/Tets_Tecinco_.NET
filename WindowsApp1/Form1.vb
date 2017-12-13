Imports WindowsApp1.ServiceReference2

Public Class Form1

    Public Shared formulario As Integer = 0


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_altaPersona_Click(sender As Object, e As EventArgs) Handles btn_altaPersona.Click
        Try

            GuardarUsuario()

        Catch ex As Exception

            MsgBox("Ha ocurrido un error para Conectarse al WebService!", MsgBoxStyle.Critical, "Advertencia")

        End Try
    End Sub

    Sub GuardarUsuario()

        'Crea la referencia al web service 

        Dim jws As New ServiceReference2.ServiceSoapClient
        Dim resultado As Boolean = True
        Dim nombreApellido As String = ""
        Dim edad As Integer = 0

        Dim mensaje As New System.Text.StringBuilder()

        If Me.txtNombreApellido.Text.Length > 3 Then
            nombreApellido = Me.txtNombreApellido.Text

        Else
            mensaje.Append("EL NOMBRE Y APELLIDO DEBE TENER MÁS DE 3 CARÁCTERES" + vbCr)
            resultado = False
        End If



        Dim fechaNacieminto As DateTime = Me.fechaNacimiento.Value

        Try

            edad = Convert.ToInt32(Me.edad.Value)

        Catch ex As Exception
            mensaje.Append("INGRESE SOLO NÚMEROS PARA LA EDAD" + vbCr)
            resultado = False
        End Try

        If edad <= 0 Then
            mensaje.Append("LA EDAD NO PUEDE SER 0 NI NEGATIVA" + vbCr)
            resultado = False
        End If


        Dim sexo As Integer = 0

        If rbMasculino.Checked Then
            sexo = 2
        Else
            sexo = 1
        End If

        If resultado Then
            'Llama al metodo altaPersona

            'Si devuelve verdadero es porque se inserto ese dato

            Dim funciono As Boolean = jws.altaPersona(nombreApellido, fechaNacieminto, edad, sexo)

            ' MsgBox(funciono)

            If funciono Then

                MsgBox("El usuario ha sido registrado Correctamente!", MsgBoxStyle.Information, "Notificacion")

            Else

                MsgBox("El usuario No ha sido registrado, Verifique!", MsgBoxStyle.Exclamation, "Notificacion")

            End If
        Else
            MsgBox(mensaje.ToString(), MsgBoxStyle.Exclamation, "Notificacion")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        If Frm_bajaModificar.id_persona1 > 0 Then
            lbTitulo.Text = "MODIFICAR PERSONA"
            btn_altaPersona.Visible = False
            btnModificar.Visible = True
            txtNombreApellido.Text = Frm_bajaModificar.nombre
            edad.Value = Frm_bajaModificar.edad
            fechaNacimiento.Value = Frm_bajaModificar.fecha
            If Frm_bajaModificar.sexo = "MASCULINO" Then
                rbMasculino.Select()
            Else
                rbFemenino.Select()

            End If

        Else
            btnModificar.Visible = False
            btn_altaPersona.Visible = True
            rbMasculino.Checked = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BAJAPERSONAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BAJAPERSONAToolStripMenuItem.Click
        Dim frm As Form
        'codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
        'If frm = Nothing Then

        '    frm.Select()

        '    frm.Show()
        '    frm.WindowState = FormWindowState.Normal

        'Else

        frm = New Frm_bajaModificar()
        formulario = 1
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Normal
        'End If
    End Sub

    Private Sub MODIFICARPERSONAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARPERSONAToolStripMenuItem.Click
        Dim frm As Form
        'codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
        'If frm = Nothing Then

        '    frm.Select()

        '    frm.Show()
        '    frm.WindowState = FormWindowState.Normal

        'Else

        frm = New Frm_bajaModificar()
        formulario = 2
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Normal
        'End If
    End Sub

    Private Sub LISTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTAToolStripMenuItem.Click
        Dim frm As Form
        'codigo para validar si el formulario no esta abierto con anterioridad, si no lo abre
        'If frm = Nothing Then

        '    frm.Select()

        '    frm.Show()
        '    frm.WindowState = FormWindowState.Normal

        'Else

        frm = New Frm_bajaModificar()
        formulario = 3
        frm.ShowDialog()
        frm.WindowState = FormWindowState.Normal
        'End If
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            ModificarUsuario(Frm_bajaModificar.id_persona1)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception

            MsgBox("Ha ocurrido un error para Conectarse al WebService!", MsgBoxStyle.Critical, "Advertencia")

        End Try
    End Sub

    Sub ModificarUsuario(ByVal id_persona As Integer)

        'Crea la referencia al web service 

        Dim jws As New ServiceReference2.ServiceSoapClient
        Dim resultado As Boolean = True
        Dim nombreApellido As String = ""
        Dim edad As Integer = 0

        Dim mensaje As New System.Text.StringBuilder()

        If Me.txtNombreApellido.Text.Length > 3 Then
            nombreApellido = Me.txtNombreApellido.Text

        Else
            mensaje.Append("EL NOMBRE Y APELLIDO DEBE TENER MÁS DE 3 CARÁCTERES" + vbCr)
            resultado = False
        End If



        Dim fechaNacieminto As DateTime = Me.fechaNacimiento.Value

        Try

            edad = Convert.ToInt32(Me.edad.Value)

        Catch ex As Exception
            mensaje.Append("INGRESE SOLO NÚMEROS PARA LA EDAD" + vbCr)
            resultado = False
        End Try

        If edad <= 0 Then
            mensaje.Append("LA EDAD NO PUEDE SER 0 NI NEGATIVA" + vbCr)
            resultado = False
        End If


        Dim sexo As Integer = 0

        If rbMasculino.Checked Then
            sexo = 2
        Else
            sexo = 1
        End If

        If resultado Then
            'Llama al metodo altaPersona

            'Si devuelve verdadero es porque se inserto ese dato

            Dim funciono As Boolean = jws.modificarPersona(id_persona, nombreApellido, fechaNacieminto, edad, sexo)

            ' MsgBox(funciono)

            If funciono = True Then

                MsgBox("Los Datos del Usuario Se han Actualizado Correctamente!", MsgBoxStyle.Information, "Notificacion")

            Else

                MsgBox("Los Datos del Usuario No Se han Podido Actualizar, Verifique!", MsgBoxStyle.Exclamation, "Notificacion")

            End If
        Else
            MsgBox(mensaje.ToString(), MsgBoxStyle.Exclamation, "Notificacion")
        End If



    End Sub
End Class
