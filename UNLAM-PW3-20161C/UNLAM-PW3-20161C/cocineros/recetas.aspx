<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="recetas.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.recetas" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Cree su receta</h1>
<uc1:ucSimpleLabelText runat="server" ID="sltRecetaNombre" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltTiempoCoccion" />
    <asp:RangeValidator ID="rvTiempoCoccion" runat="server" ErrorMessage="Debe ingresar un tiempo valido en minutos" Display="Dynamic" CssClass="text-danger" ControlToValidate="sltTiempoCoccion$txtBox" MinimumValue="0" MaximumValue="9999"></asp:RangeValidator>
    <asp:RegularExpressionValidator ID="revTiempoCoc" runat="server"  CssClass="text-danger" 
        ErrorMessage="Debe ingresar solo numeros" 
        ControlToValidate="sltTiempoCoccion$txtBox" ValidationExpression="/^([0-9])*$/" Display="Dynamic"></asp:RegularExpressionValidator>

    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltRecetaDescripcion" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltIngredientes" />
    <br />
    <asp:Label ID="lblTipo" runat="server" Text="Tipo " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:DropDownList ID="ingredientes" runat="server" CssClass="form-control">
        <asp:ListItem>Seleccione una opción</asp:ListItem>
        <asp:ListItem Value="1">Gourmet</asp:ListItem>
        <asp:ListItem Value="2">Diet</asp:ListItem>
        <asp:ListItem Value="3">Casera</asp:ListItem>
        <asp:ListItem Value="4">Oriental</asp:ListItem>
        <asp:ListItem Value="5">Delicateces</asp:ListItem>
    </asp:DropDownList><asp:RequiredFieldValidator ID="rfvRequerido" runat="server" ErrorMessage="Campo requerido" Display="Dynamic" CssClass="text-danger" ControlToValidate="ingredientes"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnCargarReceta" runat="server" Text="Cargar Receta" CssClass="btn btn-primary" OnClick="btnCargarReceta_Click"/>
    <br />

</asp:Content>