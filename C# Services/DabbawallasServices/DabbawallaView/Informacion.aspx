<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="DabbawallaView.Informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <ul class="collection">
            <li class="collection-item avatar">
                <i class=" large material-icons circle red">account_circle</i>
                <asp:Label runat="server" CssClass="title">Nombre</asp:Label>
                <p>
                    <asp:Label runat="server">Ciudad</asp:Label>
                <br>
                    <asp:Label runat="server">Direccion</asp:Label>
                </p>
                <a href="Informacion.aspx" class="secondary-content"><i class="material-icons">grade</i></a>
            </li>           
        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
