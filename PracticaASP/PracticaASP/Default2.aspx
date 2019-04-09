<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <form id="form1" runat="server">
       <h2>Nombre perfecte</h2>
       <span class="byline">Fer un algoritme que indiqui si un nombre és perfecte. Un nombre n és perfecte si és la
        suma de tots els seus divisors, incloent-hi l’u i sense incloure’l a ell mateix. Així, 6 és un nombre perfecte, per que
        6 = 3+2+1, o sigui, la suma de tots els seus divisors menys ell mateix.</span>
            <br />
            <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="És perfecte?" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
    
</asp:Content>

