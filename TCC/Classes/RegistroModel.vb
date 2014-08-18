Imports System.ComponentModel.DataAnnotations
<Table("Registro")> _
Public Class Registro

    <Key()> _
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
    Public Property Id() As Integer

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Nome() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Login() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Email() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Senha() As String
End Class
