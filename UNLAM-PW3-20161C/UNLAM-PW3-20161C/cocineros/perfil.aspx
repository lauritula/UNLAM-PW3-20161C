<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.perfil" %>
<asp:Content ID="head" ContentPlaceHolderID="cocineroHead" runat="server">

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <asp:Label ID="lblPerfilCocinero" runat="server" Text="Su perfíl "></asp:Label>
    <br />
    <asp:Label ID="lblFechaRegistracion" runat="server" Text="Fecha de registración"></asp:Label>
&nbsp;<asp:TextBox ID="txtFechaRegistro" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCantidadRecetas" runat="server" Text="Cantidad de recetas "></asp:Label>
    <asp:TextBox ID="cantRecetasPerfil" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRecetasPerfil" runat="server" Text="Sus recetas"></asp:Label>
&nbsp;<br />
    <asp:Label ID="lblEventosPerfil" runat="server" Text="Sus eventos"></asp:Label>
    <br />
    <asp:Button ID="btnVolverPerfil" runat="server" Text="Volver" />
    <br />

</asp:Content>