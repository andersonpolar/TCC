Imports System.Data.Entity
Imports System.Collections.Generic
Imports System.Linq
Public Class PacoteContext
    Inherits DbContext

    Public Sub New()
        Me.Database.Connection.ConnectionString = Comuns.Get_StringConexao()
        Me.Database.CreateIfNotExists()
    End Sub

    Public Property ManipularPacotes As DbSet(Of Pacote)

    Public Function InserirPacote(ByVal Descricao As String, ByVal Preco As Double) As Boolean
        Try
            Dim PacoteInserir As New Pacote
            PacoteInserir.Descricao = Descricao
            PacoteInserir.Preco = Preco
            ManipularPacotes.Add(PacoteInserir)
            SaveChanges()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class