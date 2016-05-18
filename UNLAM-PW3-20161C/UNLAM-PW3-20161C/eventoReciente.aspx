<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="eventoReciente.aspx.cs" Inherits="UNLAM_PW3_20161C.eventoReciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="anonimoBody" runat="server">
    <h1><asp:Label ID="lblNombre" runat="server" Text="nombre"></asp:Label></h1>
    <div class="EventoReciente"><asp:Image ID="imgEvento" runat="server" CssClass="imgEventoReciente"/></div>
    <div class="EventoReciente">
    <h2><asp:Label ID="lblSimbolo" runat="server" Text="$" CssClass="labelEventoReciente"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" Text="precio" CssClass="labelEventoReciente"></asp:Label></h2>
    <br />
    <h2><asp:Label ID="lblPuntuacion" runat="server" Text="puntuacion" CssClass="labelEventoReciente"></asp:Label></h2>
        
    </div>

    <br />
    <asp:Label ID="Comentarios" runat="server" Text="Comentarios:" CssClass="labelEventoReciente"></asp:Label>

    <asp:GridView ID="gvComentarios" runat="server">
    </asp:GridView>

</asp:Content>
