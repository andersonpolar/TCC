Public Class Convidados1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnGravar_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Try
            Dim convidado As New ConvidadosContext
            convidado.InserirConvidados(txtNome.Text, txtEmail.Text, txtTelefone.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class