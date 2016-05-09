<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs" Inherits="UNLAM_PW3_20161C.registracion" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc2" TagName="ucSimpleLabelText" %>

<asp:Content ID="head" ContentPlaceHolderID="anonimoHead" runat="server">

</asp:Content>

<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <uc1:ucMenuAnonimo ID="ucMenuAnonimo1" runat="server" />
    <br />
    <uc2:ucSimpleLabelText ID="sltNombre" runat="server" />
    <br />
    <uc2:ucSimpleLabelText ID="sltEmail" runat="server" />
    <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Debe ser un Email valido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="sltEmail$txtBox"></asp:RegularExpressionValidator>
    <br />
    <uc2:ucSimpleLabelText ID="sltPassword" runat="server"/>
    <asp:RegularExpressionValidator ID="revPassword" runat="server" ErrorMessage="Debe contener 8 Caracteres minimo, empezar con Mayuscula y contener al menos un Numero" ControlToValidate="sltPassword$txtBox" ValidationExpression="((?=.*\d)^[A-Z].*.{7,20})"></asp:RegularExpressionValidator>
    <br />
    <uc2:ucSimpleLabelText ID="sltConPassword" runat="server"/>
    <asp:CompareValidator ID="cvMismaContraseña" runat="server" Display="Dynamic" ErrorMessage="Deben ser campos iguales" ControlToCompare="sltPassword$txtBox" ControlToValidate="sltConPassword$txtBox"></asp:CompareValidator>
    <br />
    <asp:Label ID="lblPerfil" runat="server" Text="Perfil: "></asp:Label>
    <asp:RequiredFieldValidator ID="rfvPerfil" runat="server" ErrorMessage="Campo requerido" ControlToValidate="rblPerfil" Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:RadioButtonList ID="rblPerfil" runat="server" Height="16px" 
        Width="251px">
        <asp:ListItem>Cocinero</asp:ListItem>
        <asp:ListItem>Comensal</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" CssClass="btn btn-primary"/>
</asp:Content>


