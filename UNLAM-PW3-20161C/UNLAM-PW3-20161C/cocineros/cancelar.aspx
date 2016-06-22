<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="cancelar.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.cancelar" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">
    <h1>Eventos para cancelar</h1>
    <br />
    <asp:GridView ID="gvEventosCancelar" runat="server" CssClass="table table-striped table-hover" GridLines="None"
         AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="gvEventosCancelar_SelectedIndexChanged">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
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

        <asp:CommandField SelectText="Cancelar" ShowSelectButton="True" />
    </Columns>
                 <SelectedRowStyle CssClass="danger" />  
    </asp:Gridview>

</asp:Content>