<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs" Inherits="UNLAM_PW3_20161C.registracion" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<asp:Content ID="head" ContentPlaceHolderID="anonimoHead" runat="server">

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <uc1:ucMenuAnonimo ID="ucMenuAnonimo1" runat="server" />
    <p>
    Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
</p>
<p>
    Email:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
</p>
<p>
    Password:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtContrasenia" runat="server"></asp:TextBox>
</p>
<p>
    Confirmacion de Password:&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtConfirmacion" runat="server"></asp:TextBox>
</p>
<p>
    Perfil:
    <asp:RadioButtonList ID="rblPerfil" runat="server" Height="16px" 
        Width="251px">
        <asp:ListItem>Cocinero</asp:ListItem>
        <asp:ListItem>Comensal</asp:ListItem>
    </asp:RadioButtonList>
</p>
<p>
    <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" />
</p>
</asp:Content>


