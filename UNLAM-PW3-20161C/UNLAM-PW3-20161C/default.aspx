<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="UNLAM_PW3_20161C._default" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<asp:Content ID="head" ContentPlaceHolderID="anonimoHead" runat="server">

</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <uc1:ucMenuAnonimo ID="ucMenuAnonimo1" runat="server" />
</asp:Content>
