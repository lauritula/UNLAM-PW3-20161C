<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="cancelar.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.cancelar" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">
    <h1>Eventos para cancelar</h1>
    <br />
    <asp:GridView ID="gvEventosCancelar" runat="server" CssClass="table table-striped table-hover">
    </asp:GridView>
    <asp:Button ID="btnCancelarEvento" runat="server" Text="Cancelar Evento" CssClass="btn btn-primary" OnClick="btnCancelarEvento_Click" />

</asp:Content>