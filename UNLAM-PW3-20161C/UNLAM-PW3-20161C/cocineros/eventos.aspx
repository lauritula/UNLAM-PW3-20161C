<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.eventos" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Cree su evento</h1>
    <br /> 
<uc1:ucSimpleLabelText runat="server" ID="sltNombreEvento" />
    <br />
    <asp:Label ID="lblFechaEvento" runat="server" Text="Fecha del evento: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:TextBox ID="txtFechaEvento" runat="server" type="date" CssClass="form-control" />
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltDescripcion" />
        <br />
<uc1:ucSimpleLabelText runat="server" ID="sltPrecio" />
        <br />
<uc1:ucSimpleLabelText runat="server" ID="sltCantComensales" />
    <asp:RegularExpressionValidator ID="revCantidadComensales" runat="server"  CssClass="text-danger" 
        ErrorMessage="Debe ingresar solo numeros" 
        ControlToValidate="sltCantComensales$txtBox" ValidationExpression="/^([0-9])*$/" Display="Dynamic"></asp:RegularExpressionValidator>
    <br />
<uc1:ucSimpleLabelText runat="server" ID="sltUbicacion" />
    <br />
    <asp:Label ID="lblRecetas" runat="server" Text="Recetas propuestas: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:CheckBoxList ID="cblRecetas" runat="server" CssClass="form-control" CausesValidation="True">
    </asp:CheckBoxList>
    <asp:RequiredFieldValidator ID="rfvCblRecetas" runat="server" ErrorMessage="Campo requerido" Display="Dynamic" CssClass="text-danger" ControlToValidate="cblRecetas"></asp:RequiredFieldValidator>

    <br />
    <asp:Label ID="lblFotoEvento" runat="server" Text="Foto del Evento: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:FileUpload ID="fuFotoEvento" runat="server" />
    <asp:TextBox ID="txtFotoEvento" runat="server" Visible="false" ReadOnly="True"></asp:TextBox>
    <asp:Label ID="lblFileOk" runat="server" Text="" CssClass="text-danger"></asp:Label>
    <asp:RequiredFieldValidator ID="rfvRequerido" runat="server" ErrorMessage="Campo requerido" ControlToValidate="fuFotoEvento" Display="Dynamic" CssClass="text-danger"></asp:RequiredFieldValidator>      
    <br />
    <asp:Button ID="btnCrearEvento" runat="server" Text="Crear evento" OnClick="btnCrearEvento_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnCancelarEvento" runat="server" Text="Cancelar Evento" CssClass="btn btn-primary" UseSubmitBehavior="False" />

</asp:Content>