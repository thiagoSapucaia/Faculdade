<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestaRE.aspx.cs" Inherits="RegExpression.TestaRE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.'org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:TextBox ID="txtTexto" runat="server" TextMode="MultiLine" Height="140px" Width="307px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnVerificar" runat="server" Text="Verificar" OnClick="btnVerificar_Click" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
        <p>
            <asp:ListBox ID="lbxListaErro" runat="server">
            </asp:ListBox>
        </p>
    </div>
    </form>
</body>
</html>
