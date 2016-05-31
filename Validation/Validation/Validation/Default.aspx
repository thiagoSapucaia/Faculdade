<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Validation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-3">Nome</div>
                <asp:TextBox runat="server" ID="txtNome" />
                <asp:RequiredFieldValidator ID="rqvNome"
                    runat="server" ControlToValidate="txtNome"
                    ErrorMessage="Campo obrigatório!" ForeColor="Red">*
                </asp:RequiredFieldValidator>
                <hr />

            </div>
            Data de Nascimento 
            <asp:TextBox runat="server" ID="txtDataNascimento" />
            <asp:RequiredFieldValidator ID="rqvDataNascimento"
                runat="server" ControlToValidate="txtDataNascimento"
                ErrorMessage="Campo obrigatório!" ForeColor="Red">*
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revDataNascimento"
                runat="server" ErrorMessage="Data de Nascimento inválida!"
                ForeColor="Red" ControlToValidate="txtDataNascimento"
                ValidationExpression="^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d">Data de Nascimento inválida!
            </asp:RegularExpressionValidator>
            <hr />
            Email
            <asp:TextBox runat="server" ID="txtEmail" />
            <asp:RequiredFieldValidator ID="rqvEmail"
                runat="server" ControlToValidate="txtEmail"
                ErrorMessage="Campo obrigatório!" ForeColor="Red">*
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail"
                runat="server" ErrorMessage="E-mail incorreto!"
                ForeColor="Red" ControlToValidate="txtEmail"
                ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*
            </asp:RegularExpressionValidator>
            <hr />
            <asp:Button ID="btnValidar" runat="server" Text="Validar" OnClick="btnValidar_Click" />
        </div>
    </form>
</body>
</html>
