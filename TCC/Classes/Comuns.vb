Imports System.Web
Public Class Comuns 

    Public Shared Function GetDadoWebConfig(ByVal Chave As String) As String
        Return ConfigurationManager.AppSettings(Chave)
    End Function
    Public Shared Function Get_StringConexao() As String
        Try
            Dim Conexao As String = ConfigurationManager.ConnectionStrings("Conexao").ConnectionString
            Return Conexao
        Catch
            Return Err.Description
        End Try
    End Function
End Class
