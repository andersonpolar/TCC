Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Logar_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogar.Click
        Try
            Dim login As New LoginContext
            login.EfetuarLogin(txtLogin.Text, txtSenha.Text)
        Catch ex As Exception

        End Try
    End Sub

End Class