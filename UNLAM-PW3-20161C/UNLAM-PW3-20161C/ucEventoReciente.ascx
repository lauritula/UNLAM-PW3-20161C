<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucEventoReciente.ascx.cs" Inherits="UNLAM_PW3_20161C.ucEventoReciente" %>

    <asp:HyperLink ID="hlEventoReciente" runat="server" CssClass="eventoReciente" NavigateUrl="~/x.aspx">
        <div id="evento1" class="evento1">
            <asp:Image ID="imgEvento" runat="server" CssClass="imgEvento" ImageUrl="img/eventos/x.jpg" /> 
            <div id="erPrecio">
                <asp:Label ID="lblPrecio" runat="server" Text="precio" CssClass="labelEventoReciente"></asp:Label>
            </div>
            <div id="erNombre">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="labelEventoReciente"></asp:Label>           
            </div>
            <div id="erPuntuacion">
                <asp:Label ID="lblPuntuacion" runat="server" Text="puntuacion" CssClass="labelEventoReciente"></asp:Label>
            </div>

        </div>
    </asp:HyperLink>