Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.Linq
Public Class ConvidadosContext
    Inherits DbContext

    Public Sub New()
        Me.Database.Connection.ConnectionString = Comuns.Get_StringConexao()
        Me.Database.CreateIfNotExists()
    End Sub

    Public Property ManipularConvidados As DbSet(Of Convidados)

    Public Function InserirConvidados(ByVal Nome As String, ByVal Email As String, ByVal Telefone As String) As Boolean
        Try
            Dim ConvidadoInserir As New Convidados
            ConvidadoInserir.Nome = Nome
            ConvidadoInserir.Email = Email
            ConvidadoInserir.Telefone = Telefone
            ManipularConvidados.Add(ConvidadoInserir)
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