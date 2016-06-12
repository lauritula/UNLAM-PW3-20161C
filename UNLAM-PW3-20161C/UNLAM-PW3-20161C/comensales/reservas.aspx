<%@ Page Title="" Language="C#" MasterPageFile="~/comensales/Comensal.master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="UNLAM_PW3_20161C.comensales.reservas" %>

<asp:Content ID="body" ContentPlaceHolderID="comensalBody" runat="server">
    <h1>Sus Reservas Activas</h1>
    <br />
    
    <asp:GridView ID="gvReservasActivas" runat="server" CssClass="table table-striped table-hover">
    </asp:GridView>
    <br />
    <h1>Sus Reservas Finalizadas</h1>
    
    <asp:GridView ID="gvEventosFinalizados" runat="server" CssClass="table table-striped table-hover">
    <Columns>
        <asp:BoundField DataField="eventoReserva" HtmlEncode="False"
             DataFormatString="<a target='_self' href='comentarios.aspx?evento={0}'>Comentar</a>" ItemStyle-CssClass="btn btn-primary"/>
    </Columns>
    </asp:GridView>
    <br />
</asp:Content>