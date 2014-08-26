<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="TCC.Login" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="ASCS/Menu.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logar</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1" />
    <meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1" />
    <meta name="vs_defaultClientScript" content="JavaScript" />
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="bootstrap3/css/bootstrap.min.css" rel="stylesheet" />
    <link href="bootstrap3/css/starter-template.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <uc1:Menu ID="Menu1" runat="server"></uc1:Menu>
            <br style="clear: both" />
        </div>
        <h1>Efetue o Login</h1>
        <asp:label>Login:</asp:label>
        <asp:TextBox runat="server" id="txtLogin"></asp:TextBox><br />
        <asp:label>Senha:</asp:label>
        <asp:TextBox runat="server" id="txtSenha"></asp:TextBox>
        <asp:Button id="btnLogar" type="submit" Text="Logar" runat="server"></asp:Button>
        <asp:label id="lblError" runat="server"></asp:label>
    </form>
</body>
</html>
