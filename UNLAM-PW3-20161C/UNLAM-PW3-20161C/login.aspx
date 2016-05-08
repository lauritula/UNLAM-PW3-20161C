<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UNLAM_PW3_20161C.login" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<asp:Content ID="head" ContentPlaceHolderID="anonimoHead" runat="server">

</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <uc1:ucMenuAnonimo ID="ucMenuAnonimo1" runat="server" />
     <p>
    Email:
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
</p>
<p>
    Contraseña:<asp:TextBox ID="txtContrasena" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" />
</p>
</asp:Content>
