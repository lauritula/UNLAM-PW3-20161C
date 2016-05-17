<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="registracion.aspx.cs" Inherits="UNLAM_PW3_20161C.registracion" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<%@ Register Src="~/ucSimpleLabelText.ascx" TagPrefix="uc2" TagName="ucSimpleLabelText" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <br />
    <uc2:ucSimpleLabelText ID="sltNombre" runat="server" />
    <br />
    <uc2:ucSimpleLabelText ID="sltEmail" runat="server" />
    <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Debe ser un Email valido" CssClass="text-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="sltEmail$txtBox" Display="Dynamic"></asp:RegularExpressionValidator>
    <br />
    <uc2:ucSimpleLabelText ID="sltPassword" runat="server"/>
    <asp:RegularExpressionValidator ID="revPassword" runat="server"  CssClass="text-danger" ErrorMessage="Debe contener 8 Caracteres minimo, empezar con Mayuscula y contener al menos un Numero" ControlToValidate="sltPassword$txtBox" ValidationExpression="((?=.*\d)^[A-Z].*.{7,20})" Display="Dynamic"></asp:RegularExpressionValidator>
    <br />
    <uc2:ucSimpleLabelText ID="sltConPassword" runat="server"/>
    <asp:CompareValidator ID="cvMismaContraseña" runat="server" Display="Dynamic" CssClass="text-danger" ErrorMessage="Deben ser campos iguales" ControlToCompare="sltPassword$txtBox" ControlToValidate="sltConPassword$txtBox"></asp:CompareValidator>
    <br />
    <asp:Label ID="lblPerfil" runat="server" Text="Perfil: " CssClass="col-lg-2 control-label"></asp:Label>
    <asp:RadioButtonList ID="rblPerfil" runat="server" Height="16px" Width="251px" >
        <asp:ListItem>Cocinero</asp:ListItem>
        <asp:ListItem>Comensal</asp:ListItem>
    </asp:RadioButtonList><asp:RequiredFieldValidator ID="rfvPerfil" runat="server" CssClass="text-danger" ErrorMessage="Campo requerido" ControlToValidate="rblPerfil" Display="Dynamic"></asp:RequiredFieldValidator>
    <asp:Button ID="btnRegistrarse" runat="server" Text="Registrarse" OnClick="btnRegistrarse_Click" CssClass="btn btn-primary"/>
</asp:Content>


