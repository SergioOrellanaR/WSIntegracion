﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="DabbawallaView.Informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <ul class="collection">
            <li class="collection-item avatar">
                <i class=" large material-icons circle red">account_circle</i>
                Nombre:&nbsp<asp:Label runat="server" Text="Claudio Rios"></asp:Label>
                <p>
                    <asp:Label runat="server">Rol:</asp:Label>&nbsp<asp:Label runat="server" Text="Supervisor"></asp:Label>
                    
                <br>
                    <asp:Label runat="server" Text="Dirección Hogar:"></asp:Label>&nbsp<asp:Label runat="server" Text="Los memes #1423"></asp:Label>
                <br>
                    <asp:Label runat="server" Text="Dirección Trabajo:"></asp:Label>&nbsp<asp:Label runat="server" Text="Los memes #1423"></asp:Label>
                    <br>
                    <asp:Label runat="server" Text="Dabbawalla Encargado:"></asp:Label>&nbsp<asp:Label runat="server" Text="Chino Rios"></asp:Label>
                    <br>
                    <asp:Label runat="server" Text="Supervisor Encargado:"></asp:Label>&nbsp<asp:Label runat="server" Text="Gaston Gaudio"></asp:Label>
                </p>
                <a href="Informacion.aspx" class="secondary-content"><i class="material-icons">grade</i></a>
            </li>           
        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
