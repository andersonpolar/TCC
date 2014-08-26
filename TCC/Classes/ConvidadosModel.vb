Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Convidados")> _
Public Class Convidados

    <Key()> _
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
    Public Property Id() As Integer

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Nome() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Email() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Telefone() As String
End Class
