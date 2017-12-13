Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient


Public Class Persona


    'ATRIBUTOS'
    Private id_persona As Integer
    Private nombreApellido As String
    Private fechaNacimiento As DateTime
    Private edad As Integer
    Private sexo As Integer
    Private baja As Integer


    'CONSTRUCTOR'
    Public Sub New()
        'id_persona = id
        'metodo para leer una persona por id'
    End Sub

    'CONSTRUCTOR'
    Public Sub New(ByVal nombreApellido As String, ByVal fechaNacimiento As DateTime, ByVal edad As Integer, ByVal sexo As Integer, ByVal baja As Integer)
        Me.nombreApellido = nombreApellido
        Me.fechaNacimiento = fechaNacimiento
        Me.edad = edad
        Me.sexo = sexo
        Me.baja = baja
    End Sub


    'METODOS GET'
    Function getNombreApellido() As String
        Return Me.nombreApellido
    End Function

    Public Function getId_persona() As Integer
        Return Me.id_persona
    End Function

    Public Function getFechaNacimiento() As DateTime
        Return Me.fechaNacimiento
    End Function

    Public Function getEdad() As Integer
        Return Me.edad
    End Function

    Public Function getSexo() As Integer
        Return Me.sexo
    End Function

    Public Function getBaja() As Integer
        Return Me.baja
    End Function

    'METODOS SET'
    Sub setNombreApellido(ByVal nombreApellido As String)
        Me.nombreApellido = nombreApellido
    End Sub

    Sub setIdPersona(ByVal id_persona As Integer)
        Me.id_persona = id_persona
    End Sub

    Sub setFechaNacimiento(ByVal fechaNacieminto As DateTime)
        Me.fechaNacimiento = fechaNacieminto
    End Sub

    Sub setEdad(ByVal edad As Integer)
        Me.edad = edad
    End Sub

    Sub setSexo(ByVal sexo As Integer)
        Me.sexo = sexo
    End Sub

    Sub setBaja(ByVal baja As Integer)
        Me.baja = baja
    End Sub


    'ALTA PERSONA
    Public Function altaPersona() As Boolean
        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        Dim resultado As Boolean = False

        Try
            conexion = New SqlConnection(ConfigurationManager.AppSettings("MyDbConn1"))

            comando = New SqlCommand(" INSERT INTO persona (id_persona, nombreApellido, fNacimiento, edad, sexo ,baja) VALUES ((select MAX (id_persona) + 1 from persona) ,@nombreApellido ,@fNacimiento , @edad, @sexo , 0)", conexion)

            comando.Parameters.AddWithValue("@nombreApellido", getNombreApellido)

            comando.Parameters.AddWithValue("@fNacimiento", getFechaNacimiento.ToString("yyyy-MM-ddTHH:mm:ss.fffffff"))
            comando.Parameters.AddWithValue("@edad", getEdad)
            comando.Parameters.AddWithValue("@sexo", getSexo)
            comando.Parameters.AddWithValue("@baja", getBaja)

            conexion.Open()
            comando.ExecuteNonQuery()


            resultado = True


        Catch ex As Exception
            MsgBox(ex.Message)
            resultado = False
            conexion = Nothing
        End Try

        conexion.Close()
        Return resultado
    End Function

    'BAJA PERSONA   
    Public Function bajaPersona(ByVal id_persona As Integer) As Boolean
        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        conexion = New SqlConnection(ConfigurationManager.AppSettings("MyDbConn1"))
        comando = New SqlCommand("UPDATE persona SET  baja = 1 WHERE id_persona = @id_persona and baja = 0", conexion)
        comando.Parameters.AddWithValue("@id_persona", id_persona)

        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    'MODIFICAR PERSONA
    Public Function modificarPersona(ByVal id_persona As Integer, ByVal nombreApellido As String, ByVal fechaNacimiento As DateTime, ByVal edad As Integer, ByVal sexo As Integer) As Boolean
        Dim conexion As SqlConnection
        Dim comando As SqlCommand

        conexion = New SqlConnection(ConfigurationManager.AppSettings("MyDbConn1"))
        comando = New SqlCommand("UPDATE persona SET nombreApellido = @nombre, fNacimiento = @fNacimiento , edad = @edad, sexo = @sexo WHERE id_persona = @id_persona and baja = 0", conexion)

        comando.Parameters.AddWithValue("@nombre", nombreApellido)
        comando.Parameters.AddWithValue("@fNacimiento", fechaNacimiento)
        comando.Parameters.AddWithValue("@edad", edad)
        comando.Parameters.AddWithValue("@sexo", sexo)
        comando.Parameters.AddWithValue("@id_persona", id_persona)


        Try
            conexion.Open()
            comando.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'LISTA PERSONAS PARA CONSUMIR POR WEBSERVICE
    Public Function getAll() As List(Of Persona)
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim reader As SqlDataReader

        conexion = New SqlConnection(ConfigurationManager.AppSettings("MyDbConn1"))
        comando = New SqlCommand("select p.id_persona, p.nombreApellido ,p.fNacimiento, p.edad,s.sexo,s.id_sexo from persona p inner join sexo s on s.id_sexo = p.sexo where p.baja = 0", conexion)
        Dim blanquito As Persona

        Dim lista As List(Of Persona) = New List(Of Persona)
        Try
            conexion.Open()
            reader = comando.ExecuteReader

            Do While reader.HasRows

                Do While reader.Read()
                    blanquito = New Persona(reader.GetString(1), reader.GetDateTime(2), reader.GetInt32(3), reader.GetInt16(5), 0)
                    blanquito.setIdPersona(reader.GetInt32(0))

                    lista.Add(blanquito)

                Loop

                reader.NextResult()
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
            lista = Nothing
        End Try

        conexion.Close()

        Return lista

    End Function

    Public Function getPersonas() As SqlDataReader
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim reader As SqlDataReader

        conexion = New SqlConnection(ConfigurationManager.AppSettings("MyDbConn1"))
        comando = New SqlCommand("select p.id_persona, p.nombreApellido ,p.fNacimiento, p.edad,s.sexo from persona p inner join sexo s on s.id_sexo = p.sexo where p.baja = 0", conexion)


        Dim lista As List(Of Persona) = New List(Of Persona)
        Try
            conexion.Open()
            reader = comando.ExecuteReader
            Return reader

        Catch ex As Exception
            MsgBox(ex.Message)
            reader = Nothing
        End Try

        conexion.Close()

        Return reader

    End Function

End Class


