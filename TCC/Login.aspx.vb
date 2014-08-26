Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Logar_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogar.Click
        Try
            Dim registro As New RegistroContext

            If txtLogin.Text = "" Then
                lblError.Text = "Preencha o nome de usuário."
            End If
            If txtSenha.Text = "" Then
                lblError.Text = "Preencha a senha."
            End If

            If (registro.LoginExiste(txtLogin.Text, txtSenha.Text) = True) Then
                Session("Logado") = "true"
                lblError.Text = "Logado"
            Else
                Session("Logado") = "false"
                lblError.Text = "Login ou senha incorretos."
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class