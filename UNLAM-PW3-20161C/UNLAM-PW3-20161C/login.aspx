<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="UNLAM_PW3_20161C.login" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<%@ Register Src="ucSimpleLabelText.ascx" TagPrefix="uc2" TagName="ucSimpleLabelText" %>

<asp:Content ID="head" ContentPlaceHolderID="anonimoHead" runat="server">

</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <uc1:ucMenuAnonimo ID="ucMenuAnonimo1" runat="server" />
    <uc2:ucSimpleLabelText runat="server" id="sltEmail" />
    <br />
    <uc2:ucSimpleLabelText runat="server" id="sltPassword" TextMode="Password"/>
    <br />
    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar"  CssClass="btn btn-primary"/>
</asp:Content>
