<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuComensal.ascx.cs" Inherits="UNLAM_PW3_20161C.ucMenuComensal" %>


<asp:Panel ID="Panel1" runat="server">
    <asp:HyperLink ID="hlReservar" runat="server" 
        NavigateUrl="~/comensales/reservar.aspx">Reservar Evento</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlReservas" runat="server" 
        NavigateUrl="~/comensales/reservas.aspx">Mis Reservas</asp:HyperLink>
    <br />
    <asp:HyperLink ID="hlComentarios" runat="server" 
        NavigateUrl="~/comensales/comentarios.aspx">Puntuacion y comentarios de eventos finalizados</asp:HyperLink>
</asp:Panel>



