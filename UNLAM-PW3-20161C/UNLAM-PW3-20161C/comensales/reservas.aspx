<%@ Page Title="" Language="C#" MasterPageFile="~/comensales/Comensal.master" AutoEventWireup="true" CodeBehind="reservas.aspx.cs" Inherits="UNLAM_PW3_20161C.comensales.reservas" %>

<asp:Content ID="body" ContentPlaceHolderID="comensalBody" runat="server">
    <h1>Sus Reservas</h1>
    <br />
    <asp:GridView ID="gvReservas" runat="server" CssClass="table table-striped table-hover">
    </asp:GridView>
</asp:Content>