Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.Linq
Imports System.Data.SqlClient
Public Class RegistroContext
    Inherits DbContext

    Public Sub New()
        Me.Database.Connection.ConnectionString = Comuns.Get_StringConexao()
    End Sub

    Public Property ManipularRegistro As DbSet(Of Registro)

    Public Function InserirRegistro(ByVal Nome As String, ByVal Login As String, ByVal Email As String, ByVal Senha As String) As Boolean
        Try
            Dim RegistroInserir As New Registro
            RegistroInserir.Nome = Nome
            RegistroInserir.Login = Login
            RegistroInserir.Email = Email
            RegistroInserir.Senha = Senha
            ManipularRegistro.Add(RegistroInserir)
            SaveChanges()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function LoginExiste(ByVal Login As String, ByVal Senha As String) As Boolean
        Try
            Dim registro As New Registro
            Dim logins As Object = From r In Me.ManipularRegistro Where r.Login = Login And r.Senha = Senha

            For Each registro In logins
                If registro.Login = Login Then
                    If registro.Senha = Senha Then
                        Return True
                        Exit Function
                    End If
                End If
            Next

            Return False
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function DeleteRegistro(ByVal IDRegistro As Integer) As Boolean
        Try
            Dim Connection As New SqlConnection(Comuns.Get_StringConexao())
            Dim Command As New SqlCommand

            Command.CommandText = "DELETE from Registro where ID = @ID"
            Command.Connection = Connection
            Command.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))

            Command.Parameters("@ID").Value = IDRegistro

            Command.Connection.Open()
            Command.ExecuteNonQuery()
            Command.Connection.Close()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class