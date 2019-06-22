<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="AlertasActivas.aspx.cs" Inherits="DabbawallaView.AlertasActivas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="lblMensajeVacio" runat="server" Text="No tiene alertas activas" Visible = "false"></asp:Label>
        <asp:Gridview CssClass="responsive-table" runat="server" ID="grdAlertasActivas">
            
        </asp:Gridview>
    </div>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
