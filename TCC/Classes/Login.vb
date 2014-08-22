Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.Linq

Public Class LoginContext
    Inherits DbContext

    Public Sub New()
        Me.Database.Connection.ConnectionString = Comuns.Get_StringConexao()
        Me.Database.CreateIfNotExists()
    End Sub

    Public Property EfetuarLogin As DbSet(Of Login)

    Public Function Logar(ByVal Login As String, ByVal Senha As String) As Boolean
        Try
            Dim UsuarioLogar As New Login
            UsuarioLogar.Login = Login
            UsuarioLogar.Senha = Senha
            EfetuarLogin.Add(UsuarioLogar)
            SaveChanges()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function Database() As Object
        Throw New NotImplementedException
    End Function

    Private Sub SaveChanges()
        Throw New NotImplementedException
    End Sub

End Class
