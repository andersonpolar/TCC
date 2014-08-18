<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="TCC._Default" %>
<%@ Register TagPrefix="uc1" TagName="Menu" Src="ASCS/Menu.ascx" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html>
<head>
    <title>Página Principal</title>
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
    <link href="starter-template.css" rel="stylesheet" />
</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
        <div id="header">
            <uc1:Menu ID="Menu1" runat="server"></uc1:Menu>
            <br style="clear: both" />
        </div>
        <div class="container">

            <div class="starter-template">
            </div>

        </div><!-- /.container -->

    </form>
</body>
</html>
