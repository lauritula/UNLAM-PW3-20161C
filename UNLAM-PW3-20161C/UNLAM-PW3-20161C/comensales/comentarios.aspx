<%@ Page Title="" Language="C#" MasterPageFile="~/comensales/Comensal.master" AutoEventWireup="true" CodeBehind="comentarios.aspx.cs" Inherits="UNLAM_PW3_20161C.comensales.comentarios" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>


<asp:Content ID="body" ContentPlaceHolderID="comensalBody" runat="server">
    <h1>Comentarios y puntuaciones</h1>
    <br />
    <asp:GridView ID="gvEventosFinalizados" runat="server" CssClass="table table-striped table-hover"></asp:GridView>
    <br />
    <asp:Label ID="lblPuntuacion" runat="server" Text="Puntuacion: " CssClass="col-lg-2 control-label"></asp:Label>
    <br />
    <asp:ListBox ID="lbPuntacion" runat="server" CssClass="form-control" CausesValidation="True">
        <asp:ListItem Value="5">Muy bueno</asp:ListItem>
        <asp:ListItem Value="4">Bueno</asp:ListItem>
        <asp:ListItem Value="3">Mas o menos</asp:ListItem>
        <asp:ListItem Value="2">Malo</asp:ListItem>
        <asp:ListItem Value="1">Muy malo</asp:ListItem>
    </asp:ListBox>
    <br />
    <uc1:ucSimpleLabelText runat="server" ID="sltComentario" />
    <br />
    <asp:Button ID="btnComentario" runat="server" Text="Puntua y Comenta" CssClass="btn btn-primary" OnClick="btnComentario_Click"/>
</asp:Content>