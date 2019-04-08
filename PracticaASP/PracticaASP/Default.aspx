<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
    <header class="major">
	    <h2>Restaurant</h2>
		    <span class="byline">Fer un nou projecte per implementar la caixa de pagament d’un restaurant que cobra els menús
            dels dies laborables a 10€ i dels festius a 14€. Fer un algoritme que demani a l’usuari un número de l’1 al 7 que
            indica el dia de la setmana, i la quantitat d’euros que ha pagat el client. Llavors l’algoritme ha de donar error si el
            client ha pagat menys del que correspon segons el dia, o bé el canvi que se li ha de tornar, si ha pagat més. </span>
            <br />
            <br />
        Import total pagat:<br />
        <asp:TextBox ID="importe"  runat="server"></asp:TextBox>
        <br />
            
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged2" AutoPostBack="True">
            <asp:ListItem>Escolleix dia</asp:ListItem>
            <asp:ListItem Value="1">Dilluns</asp:ListItem>
            <asp:ListItem Value="1">Dimarts</asp:ListItem>
            <asp:ListItem Value="1">Dimecres</asp:ListItem>
            <asp:ListItem Value="1">Dijous</asp:ListItem>
            <asp:ListItem Value="1">Divendres</asp:ListItem>
            <asp:ListItem Value="2">Dissabte</asp:ListItem>
            <asp:ListItem Value="2">Diumenge</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="resul" runat="server">Import</asp:Label>
            
    </header>

    </form>

</asp:Content>

