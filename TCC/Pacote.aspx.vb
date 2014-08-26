Public Class Pacote1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnGravar_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        Try
            Dim pacote As New PacoteContext
            If pacote.InserirPacote(txtPacote.Text, txtPreco.Text) = True Then

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class