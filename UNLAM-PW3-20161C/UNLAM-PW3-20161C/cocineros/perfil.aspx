<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.perfil" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>

<asp:Content ID="head" ContentPlaceHolderID="cocineroHead" runat="server">

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Su perfíl</h1>
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltFechaRegistro" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltEmailPerfil" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltRecetasPerfil" />
    <br />
    <asp:Label ID="lblRecetasPerfil" runat="server" Text="Sus recetas: " CssClass="col-lg-2 control-label"></asp:Label>
    <br />
    <asp:Label ID="lblEventosPerfil" runat="server" Text="Sus eventos: " CssClass="col-lg-2 control-label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnVolverPerfil" runat="server" Text="Volver" CssClass="btn btn-primary"/>
    <br />

</asp:Content>