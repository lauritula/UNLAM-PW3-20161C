﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="eventoReciente.aspx.cs" Inherits="UNLAM_PW3_20161C.eventoReciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="anonimoBody" runat="server">
    <h1><asp:Label ID="lblNombre" runat="server" Text="nombre"></asp:Label></h1>
    <div class="EventoReciente"><asp:Image ID="imgEvento" runat="server" CssClass="imgEventoReciente"/></div>
    <div class="EventoReciente">
    <h2><asp:Label ID="lblPrec" runat="server" Text="Precio:" CssClass="labelEventoReciente"></asp:Label>
    <asp:Label ID="lblSimbolo" runat="server" Text="$" CssClass="labelEventoReciente"></asp:Label>
    <asp:Label ID="lblPrecio" runat="server" Text="precio" CssClass="labelEventoReciente"></asp:Label></h2>
    <br />
    <h2><asp:Label ID="lblPuntua" runat="server" Text="Puntuacion:" CssClass="labelEventoReciente">

        </asp:Label><asp:Label ID="lblPuntuacion" runat="server" Text="puntuacion" CssClass="labelEventoReciente"></asp:Label></h2>
        
    </div>

    <br />
    <asp:Label ID="Comentarios" runat="server" Text="Comentarios:" CssClass="labelEventoReciente"></asp:Label>

    <asp:GridView ID="gvComentarios" runat="server" CssClass="table table-striped table-hover">
<Columns>
    <asp:BoundField DataField="IdComentario" Visible="false"   HeaderText="Id de Comentario"/>
    <asp:BoundField DataField="IdUsuario" Visible="false"   HeaderText="Id de Usuario" />  
    <asp:BoundField DataField="Puntuacion" HeaderText="Puntuacion" /> 
    <asp:BoundField DataField="Comentarios1" HeaderText="Precio" /> 
    </Columns>
    </asp:GridView>

</asp:Content>
