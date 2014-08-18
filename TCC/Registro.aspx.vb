Public Class Registro1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnCadastrar_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Try
            Dim registro As New RegistroContext
            registro.InserirRegistro(txtNome.Text, txtLogin.Text, txtEmail.Text, txtSenha.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class