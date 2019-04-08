<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Restaurant.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#FF3300" Height="334px" HorizontalAlign="Center">
            <br />
            <br />
            <br />
            Import pagat:
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Escolleix dia</asp:ListItem>
                <asp:ListItem Value="dl">Dilluns</asp:ListItem>
                <asp:ListItem Value="dm">Dimarts</asp:ListItem>
                <asp:ListItem Value="dm">Dimecres</asp:ListItem>
                <asp:ListItem Value="dj">Dijous</asp:ListItem>
                <asp:ListItem Value="dv">Divendres</asp:ListItem>
                <asp:ListItem Value="ds">Dissabte</asp:ListItem>
                <asp:ListItem Value="dg">Diumenge</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
    </form>
</body>
</html>
