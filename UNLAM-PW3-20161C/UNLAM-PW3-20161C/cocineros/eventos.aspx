<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.eventos" %>
<asp:Content ID="head" ContentPlaceHolderID="cocineroHead" runat="server">

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <asp:Label ID="lblEvento" runat="server" Text="Cree su evento"></asp:Label>
    <br />
    <asp:Label ID="lblNombreEvento" runat="server" Text="Nombre del evento"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombreEvento" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblFechaEvento" runat="server" Text="Fecha del evento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Calendar ID="fechaEvento" runat="server"></asp:Calendar>
    <br />
    <asp:Label ID="lblDescripcion" runat="server" Text="Descripción"></asp:Label>
&nbsp;
    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRecetas" runat="server" Text="Recetas propuestas"></asp:Label>
    <asp:DropDownList ID="recetas" runat="server">
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblCantComensales" runat="server" Text="Cantidad máxmima de comensales"></asp:Label>
&nbsp;<asp:TextBox ID="txtCantComensales" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblUbicacion" runat="server" Text="Ubicación"></asp:Label>
    <asp:TextBox ID="txtUbicacion" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblFoto" runat="server" Text="Foto del evento"></asp:Label>
    <br />
    <asp:Button ID="btnCrearEvento" runat="server" Text="Crear evento" />

    <br />
    <asp:Button ID="btnCancelarEvento" runat="server" Text="Cancelar Evento" />

</asp:Content>