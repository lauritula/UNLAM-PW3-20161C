<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuCocinero.ascx.cs" Inherits="UNLAM_PW3_20161C.ucMenuCocinero" %>
<asp:Panel ID="Panel1" runat="server">
    <nav class="navbar navbar-inverse">
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
      <ul class="nav navbar-nav">
        <li><asp:HyperLink ID="hlRecetas" runat="server" NavigateUrl="~/cocineros/recetas.aspx">Crear Recetas</asp:HyperLink></li>
        <li><asp:HyperLink ID="hlPerfil" runat="server" NavigateUrl="~/cocineros/perfil.aspx">Perfil del Cocinero</asp:HyperLink></li>
        <li><asp:HyperLink ID="hlCancelar" runat="server" NavigateUrl="~/cocineros/cancelar.aspx">Cancelar Eventos</asp:HyperLink></li>
        <li><asp:HyperLink ID="hlEventos" runat="server" NavigateUrl="~/cocineros/eventos.aspx">Crear Evento de Cocina</asp:HyperLink></li>
      </ul>
         <ul class="nav navbar-nav navbar-right">
        <li><asp:Label ID="lblUsuarioConectado" runat="server" Text="Label" CssClass="navbar-brand"></asp:Label>
            </li>
        <li><asp:LinkButton ID="lbLogOut" runat="server" OnClick="lbLogOut_Click" CssClass="btn btn-default" CausesValidation="False">Cerrar Sesion</asp:LinkButton></li>
        </ul>
      </div>
    </nav>
</asp:Panel>