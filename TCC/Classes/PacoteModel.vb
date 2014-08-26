Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Pacote")> _
Public Class Pacote

    <Key()> _
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
    Public Property Id() As Integer

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Descricao() As String

    <Required(ErrorMessage:="Campo Obrigatório")> _
    Public Property Preco() As Double
End Class
