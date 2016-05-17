<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="recetas.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.recetas" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Cree su receta</h1>
<uc1:ucSimpleLabelText runat="server" ID="sltRecetaNombre" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltTiempoCoccion" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltRecetaDescripcion" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltIngredientes" />
    <br />
    <asp:Label ID="lblTipo" runat="server" Text="Tipo " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:DropDownList ID="ingredientes" runat="server" CssClass="form-control">
        <asp:ListItem>Seleccione una opción</asp:ListItem>
        <asp:ListItem>Gourmet</asp:ListItem>
        <asp:ListItem>Diet</asp:ListItem>
        <asp:ListItem>Casera</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="btnCargarReceta" runat="server" Text="Cargar Receta" CssClass="btn btn-primary"/>
    <br />

</asp:Content>