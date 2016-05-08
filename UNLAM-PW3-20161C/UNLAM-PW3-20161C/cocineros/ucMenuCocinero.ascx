<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuCocinero.ascx.cs" Inherits="UNLAM_PW3_20161C.ucMenuCocinero" %>
<asp:Panel ID="Panel1" runat="server">
    <asp:HyperLink ID="hlRecetas" runat="server" 
        NavigateUrl="~/cocineros/recetas.aspx">Crear Recetas</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlEventos" runat="server" 
        NavigateUrl="~/cocineros/eventos.aspx">Crear Evento de Cocina</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlPerfil" runat="server" 
        NavigateUrl="~/cocineros/perfil.aspx">Perfil del Cocinero</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlCancelar" runat="server" 
        NavigateUrl="~/cocineros/cancelar.aspx">Cancelar Eventos</asp:HyperLink>
</asp:Panel>