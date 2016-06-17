<%@ Page Title="" Language="C#" MasterPageFile="~/Anonimo.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="UNLAM_PW3_20161C._default" %>
<%@ Register src="ucMenuAnonimo.ascx" tagname="ucMenuAnonimo" tagprefix="uc1" %>
<%@ Register Src="ucEventoReciente.ascx" TagPrefix="uc2" TagName="ucEventoReciente" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="anonimoBody">
    <div id="eventosRecientes">
        <uc2:ucEventoReciente runat="server" id="ucEventoReciente0" />
        <uc2:ucEventoReciente runat="server" ID="ucEventoReciente1" />
        <uc2:ucEventoReciente runat="server" ID="ucEventoReciente2" />
        <uc2:ucEventoReciente runat="server" ID="ucEventoReciente3" />
        <uc2:ucEventoReciente runat="server" ID="ucEventoReciente4" />
        <uc2:ucEventoReciente runat="server" ID="ucEventoReciente5" />
    </div>
</asp:Content>
