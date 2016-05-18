<%@ Page Title="" Language="C#" MasterPageFile="~/cocineros/Cocinero.master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="UNLAM_PW3_20161C.cocineros.perfil" %>

<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc1" TagName="ucSimpleLabelText" %>
<%@ Register Src="~/ucListado.ascx" TagPrefix="uc2" TagName="ucListado" %>

<asp:Content ID="body" ContentPlaceHolderID="cocineroBody" runat="server">

    <h1>Su perfíl</h1>
    <br />
    <asp:Label ID="lblFechaRegistro" runat="server" Text="Fecha de registro: " ></asp:Label>
    <asp:Label ID="lblFecha" runat="server" Text="20/15/2015"></asp:Label>
    <br />
    <asp:Label ID="lblEmail" runat="server" Text="Email: " ></asp:Label>
    <asp:Label ID="lblEmail1" runat="server" Text="maria@bodegon.com"></asp:Label>
    <br />
    <asp:Label ID="lblCantRecetas" runat="server" Text="Cantidad de Recetas: "></asp:Label>
    <asp:Label ID="lblCantidad" runat="server" Text="30"></asp:Label>
    <br />
    <asp:Label ID="lblRecetasPerfil" runat="server" Text="Sus recetas: " ></asp:Label>
    <asp:GridView ID="gvRecetasPerfil" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="Nombre" />
            <asp:BoundField HeaderText="Tiempo coccion" />
            <asp:BoundField HeaderText="Descripsion" />
            <asp:BoundField HeaderText="Ingredientes" />
            <asp:BoundField HeaderText="Tipo" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
    <asp:Label ID="lblEventosPerfil" runat="server" Text="Sus eventos: " ></asp:Label>
    <asp:GridView ID="gvEventosPerfil" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField HeaderText="Nombre" />
            <asp:BoundField HeaderText="Fecha de Evento" />
            <asp:BoundField HeaderText="Descripsion" />
            <asp:BoundField HeaderText="Recetas propuestas" />
            <asp:BoundField HeaderText="Cantidad maxima de comensales" />
            <asp:BoundField HeaderText="Ubicacion" />
            <asp:BoundField HeaderText="Foto" />
            <asp:BoundField HeaderText="Precio" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <br />
    <br />


</asp:Content>