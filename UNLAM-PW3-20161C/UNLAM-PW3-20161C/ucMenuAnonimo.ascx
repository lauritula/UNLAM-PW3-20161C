<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucMenuAnonimo.ascx.cs" Inherits="UNLAM_PW3_20161C.ucMenuAnonimo" %>
<asp:Panel ID="Panel1" runat="server">
    
    <asp:HyperLink ID="hlInicio" runat="server" NavigateUrl="~/default.aspx" CssClass="btn btn-primary">Inicio</asp:HyperLink>
    <asp:HyperLink ID="hlLogin" runat="server" NavigateUrl="~/login.aspx" CssClass="btn btn-primary">Login</asp:HyperLink>
    <asp:HyperLink ID="hlRegistracion" runat="server" 
        NavigateUrl="~/registracion.aspx" CssClass="btn btn-primary">Registración</asp:HyperLink>
    
</asp:Panel>

