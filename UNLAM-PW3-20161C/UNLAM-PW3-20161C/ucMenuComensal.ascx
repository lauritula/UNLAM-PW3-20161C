<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuComensal.ascx.cs" Inherits="UNLAM_PW3_20161C.ucMenuComensal" %>

<div id="cabecera" class="cabecera">
<img src="../img/baner.jpg" class="banner"/>
<asp:Panel ID="Panel1" runat="server">
    <nav class="navbar navbar-inverse">
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
      <ul class="nav navbar-nav">
        <li><asp:HyperLink ID="hlReservar" runat="server" 
        NavigateUrl="~/comensales/reservar.aspx">Reservar Evento</asp:HyperLink></li>
        <li><asp:HyperLink ID="hlReservas" runat="server" 
        NavigateUrl="~/comensales/reservas.aspx">Mis Reservas</asp:HyperLink></li>
      </ul>
        <ul class="nav navbar-nav navbar-right">
        <li><asp:Label ID="lblUsuarioConectado" runat="server" Text="Label" CssClass="navbar-brand"></asp:Label></li>
        <li><asp:LinkButton ID="lbLogOut" runat="server" OnClick="lbLogOut_Click"  CssClass="btn btn-default" CausesValidation="False">Cerrar Sesion</asp:LinkButton></li>
        </ul>
      </div>
    </nav>
</asp:Panel>
</div>
