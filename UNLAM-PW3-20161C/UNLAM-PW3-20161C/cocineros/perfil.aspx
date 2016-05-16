<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.perfil" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>
<%@ Register Src="~/ucListado.ascx" TagPrefix="uc2" TagName="ucListado" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Su perfíl</h1>
    <br />
    <asp:Label ID="lblFechaRegistro" runat="server" Text="Fecha de registro: " ></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="20/15/2015"></asp:Label>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email: " ></asp:Label>
    <asp:Label ID="lblEmail1" runat="server" Text="maria@bodegon.com"></asp:Label>
    <br />
    <asp:Label ID="lblCantRecetas" runat="server" Text="Cantidad de Recetas: "></asp:Label>
    <asp:Label ID="lblCantidad" runat="server" Text="30"></asp:Label>
    <br />
    <asp:Label ID="lblRecetasPerfil" runat="server" Text="Sus recetas: " ></asp:Label>
    <uc2:ucListado runat="server" id="ucRecetas" />
    <br />
    <asp:Label ID="lblEventosPerfil" runat="server" Text="Sus eventos: " ></asp:Label>
    <uc2:ucListado runat="server" id="ucEventos" />
    <br />
    <br />


</asp:Content>