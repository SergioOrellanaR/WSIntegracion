<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="AlertasActivas.aspx.cs" Inherits="DabbawallaView.AlertasActivas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <asp:Gridview CssClass="responsive-table" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="idCliente" SortExpression="Cliente"> </asp:TemplateField>
                <asp:TemplateField HeaderText="FechaAlerta" SortExpression="Fecha"> </asp:TemplateField>
            </Columns>
        </asp:Gridview>
    </div>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
