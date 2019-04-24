<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <form id="form1" runat="server">
       <h2>Mastermind</h2>
       <span class="byline">Fer un algoritme que generi un nombre aleatori de 4 xifres. L’usuari llavors ha d’introduir 
        nombres de 4 xifres fins que l’encerti o be hagi fet N intents. El nombre d’intents també els ha d’introduir l’usuari.
        A cada nombre de 4 xifres que introdueixi l’usuari, el programa li ha de dir si el nombre que ha d’endevinar és
        més gran o més petit. Si l’usuari l’encerta en un nombre de vegades menor que N, ha guanyat, sinó, ha perdut. 
        <br />
        </span>
        <br />
        <br />
        Intents:<br />
        <asp:TextBox ID="TextBox1" runat="server" required ="true" ></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Comença" OnClick="Button1_Click" />
        <br />
        <br />
        Número:<br />
        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Try!" />
        <br />
        <br />
        <!-- Shit I don't like but I have to -->
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
            <asp:Label ID="Label3" runat="server" Text="¿?"></asp:Label>
            <br />
        
    </form>
    
</asp:Content>
