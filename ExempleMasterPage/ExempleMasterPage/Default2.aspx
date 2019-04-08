<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Salutacions</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Hola"></asp:Label>
</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="English" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Italiano" />
</p>
</asp:Content>

