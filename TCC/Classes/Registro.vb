Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.Linq
Public Class RegistroContext
    Inherits DbContext

    Public Sub New()
        Me.Database.Connection.ConnectionString = Comuns.Get_StringConexao()
        Me.Database.CreateIfNotExists()
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
End Class