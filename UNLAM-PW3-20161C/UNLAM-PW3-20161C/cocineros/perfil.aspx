<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.perfil" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>
<%@ Register Src="~/ucListado.ascx" TagPrefix="uc2" TagName="ucListado" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Su perfíl</h1>
    <br />
    <asp:Label ID="lblFechaRegistro" runat="server" Text="Fecha de registro: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="" CssClass="col-lg-2 control-label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:Label ID="lblEmail1" runat="server" Text="" CssClass="col-lg-2 control-label"></asp:Label>
    <br /><br />
    <asp:Label ID="lblCantRecetas" runat="server" Text="Cantidad de Recetas: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:Label ID="lblCantidad" runat="server" Text="" CssClass="col-lg-2 control-label"></asp:Label>
    <br /><br />
    <br />
    <asp:Label ID="lblRecetasPerfil" runat="server" Text="Sus recetas: " ></asp:Label>
    <asp:GridView ID="gvRecetasPerfil" runat="server" CssClass="table table-striped table-hover" GridLines="None"
         AlternatingRowStyle-CssClass="alt">
    <Columns>
    <asp:BoundField DataField="IdReceta" Visible="true"   HeaderText="Receta N°"/>
    <asp:BoundField DataField="IdUsuario" Visible="false"   HeaderText="Id de Usuario" />  
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />  
    <asp:BoundField DataField="TiempoCoccion" HeaderText="Tiempo de coccion" />  
    <asp:BoundField DataField="Descripcion" HeaderText="Descripsion/Pasos" /> 
    <asp:BoundField DataField="Ingredientes" HeaderText="Ingredientes" /> 
    <asp:BoundField DataField="Tipo" HeaderText="Tipo" /> 
    </Columns>
    </asp:Gridview>
    <br />
    <asp:Label ID="lblEventosPerfil" runat="server" Text="Sus eventos: " ></asp:Label>
    <asp:GridView ID="gvEventosPerfil" runat="server" CssClass="table table-striped table-hover" GridLines="None"
         AlternatingRowStyle-CssClass="alt">
    <Columns>
    <asp:BoundField DataField="IdEvento" Visible="true"   HeaderText="Evento N°"/>
    <asp:BoundField DataField="IdUsuario" Visible="false"   HeaderText="Id de Usuario" />  
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />  
    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />  
    <asp:BoundField DataField="Descripcion" HeaderText="Descripsion" /> 
    <asp:BoundField DataField="CantidadComensales" HeaderText="Cantidad de comensales" /> 
    <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion del Evento" /> 
    <asp:BoundField DataField="NombreFoto" HeaderText="Foto" /> 
    <asp:BoundField DataField="Precio" HeaderText="Precio" /> 
    <asp:BoundField DataField="Estado" HeaderText="Estado del Evento" /> 
    </Columns>
    </asp:GridView>

    <br />
    <br />


</asp:Content>