<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
        <asp:Panel ID="Panel1" runat="server" BackColor="#CC9900" Height="340px" HorizontalAlign="Center">
            Calculadora DUAL v1.0<br />
            <br />
            Primer operand<asp:TextBox ID="op1" runat="server"></asp:TextBox>
            <br />
            Segon operand<asp:TextBox ID="op2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="suma" runat="server" OnClick="Operacio_Click" Text="+" Width="30px" />
            <asp:Button ID="resta" runat="server" OnClick="Operacio_Click" Text="-" Width="30px" />
            <asp:Button ID="mult" runat="server" OnClick="Operacio_Click" Text="*" Width="30px" />
            <asp:Button ID="div" runat="server" OnClick="Operacio_Click" Text="/" Width="30px" />
            <br />
            <br />
            <br />
            Altres operacions:
            <asp:DropDownList ID="DDaltresOps" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDaltresOps_SelectedIndexChanged">
                <asp:ListItem Value="Tría opció"></asp:ListItem>
                <asp:ListItem Value="f">Factorial</asp:ListItem>
                <asp:ListItem Value="abs">Valor absolut</asp:ListItem>
                <asp:ListItem Value="mcm">MCM</asp:ListItem>
                <asp:ListItem Value="primer">És primer?</asp:ListItem>
                <asp:ListItem Value="major">Major</asp:ListItem>
                <asp:ListItem Value="menor">Menor</asp:ListItem>
                <asp:ListItem Value="avg">Mitja</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="resposta" runat="server" Font-Names="Arial" Text="Resultat"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
