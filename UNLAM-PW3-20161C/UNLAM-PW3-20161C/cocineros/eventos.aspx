<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.eventos" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>

<asp:Content ID="head" ContentPlaceHolderID="cocineroHead" runat="server">

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Cree su evento</h1>
    <br /> 
<uc1:ucSimpleLabelText runat="server" ID="sltNombreEvento" />
    <br />
    <asp:Label ID="lblFechaEvento" runat="server" Text="Fecha del evento: " CssClass="col-lg-2 control-label"></asp:Label>
     <asp:Calendar ID="fechaEvento" runat="server" ></asp:Calendar>
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltDescripcion" />
        <br />
<uc1:ucSimpleLabelText runat="server" ID="sltCantComensales" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltUbicacion" />
    <br />
    <asp:Label ID="lblRecetas" runat="server" Text="Recetas propuestas: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:DropDownList ID="recetas" runat="server" CssClass="form-control">
        <asp:ListItem>Sushi</asp:ListItem>
    </asp:DropDownList>
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltFotoEvento" />  
    <br />
    <asp:Button ID="btnCrearEvento" runat="server" Text="Crear evento" OnClick="btnCrearEvento_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnCancelarEvento" runat="server" Text="Cancelar Evento" CssClass="btn btn-primary"/>

</asp:Content>