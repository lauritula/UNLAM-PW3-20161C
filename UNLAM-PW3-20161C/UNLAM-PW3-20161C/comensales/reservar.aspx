﻿<%@ Page Title="" Language="C#" MasterPageFile="~/comensales/Comensal.master" AutoEventWireup="true" CodeBehind="reservar.aspx.cs" Inherits="UNLAM_PW3_20161C.comensales.reservar" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>


<asp:Content ID="body" ContentPlaceHolderID="comensalBody" runat="server">
    <h1>Eventos disponibles para reservar</h1>
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">  
</asp:ScriptManager> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">  
    <contenttemplate>  
    <asp:GridView ID="gvEventosDisponibles" runat="server" CssClass="table table-striped table-hover" GridLines="None"
         AlternatingRowStyle-CssClass="alt" OnSelectedIndexChanged="gvEventosDisponibles_SelectedIndexChanged" >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
    <Columns>
    <asp:BoundField DataField="IdEvento" Visible="true"   HeaderText="Evento N°"/>
    <asp:BoundField DataField="IdUsuario" Visible="false"   HeaderText="Id de Usuario" />  
    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />  
    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />  
    <asp:BoundField DataField="Descripcion" HeaderText="Descripsion" /> 
    <asp:BoundField DataField="CantidadComensales" HeaderText="Cantidad de comensales" /> 
    <asp:BoundField DataField="Ubicacion" HeaderText="Ubicacion del Evento" /> 
    <asp:BoundField DataField="Precio" HeaderText="Precio" />
    <asp:BoundField DataField="NombreFoto" HeaderText="Foto" />  
        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
</Columns>
                        <SelectedRowStyle CssClass="info" />  
            </asp:GridView>  
    </contenttemplate>  
</asp:UpdatePanel>  
    <br />
    <asp:Label ID="lblElegirMenu" runat="server" Text="Menu a elegir:" CssClass="col-lg-2 control-label"></asp:Label>
    <asp:DropDownList ID="ddlMenu" runat="server" CausesValidation="True" CssClass="form-control">
        <asp:ListItem>Seleccione una opción</asp:ListItem>

    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="rfvMenu" runat="server" ErrorMessage="Debe seleccionar un Menu" CssClass="text-danger" ControlToValidate="ddlMenu" Display="Dynamic" Font-Bold="False" InitialValue="Seleccione una opción" SetFocusOnError="True"></asp:RequiredFieldValidator>
    <br />
    <uc1:ucSimpleLabelText runat="server" ID="sltReservaComensales" />
    <asp:RegularExpressionValidator ID="revCantComensales" runat="server" ErrorMessage="Solo puede ingresar numeros" ValidationExpression="^[0-9]*$" ControlToValidate="sltReservaComensales$txtBox" CssClass="text-danger"></asp:RegularExpressionValidator>
    <br />
<asp:Button ID="btnReservar" runat="server" Text="Reservar asistencia" CssClass="btn btn-primary" OnClick="btnReservar_Click"/>

</asp:Content>