<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSimpleLabelText.ascx.cs" Inherits="UNLAM_PW3_20161C.ucSimpleLabelText" %>
<div class="form-group">
    <asp:Label ID="lblTextBox" runat="server" Text="Label" CssClass="col-lg-2 control-label"></asp:Label>
    <div class="col-lg-10">
    <asp:TextBox ID="txtBox" runat="server" CssClass="form-control"></asp:TextBox><asp:RequiredFieldValidator ID="rfvRequerido" runat="server" ErrorMessage="Campo requerido" ControlToValidate="txtBox" Display="Dynamic"></asp:RequiredFieldValidator>
    </div>

</div>