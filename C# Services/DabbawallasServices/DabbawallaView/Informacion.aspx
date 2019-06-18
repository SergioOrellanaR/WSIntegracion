<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="DabbawallaView.Informacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <ul class="collection">
            <li class="collection-item avatar">
                <i class=" large material-icons circle red">account_circle</i>
                Nombre:&nbsp<asp:Label runat="server" Text="" ID="lblDataNombre"></asp:Label>
                <p>
                    <asp:Label runat="server">Rol: </asp:Label>&nbsp<asp:Label runat="server" Text="" ID="lblDataRol"></asp:Label>
                    
                <br>
                    <asp:Label runat="server" Text="Dirección Hogar: " ID="lblDireccionHogar"></asp:Label>&nbsp<asp:Label runat="server" Text="" ID="lblDataDirHog"></asp:Label>
                <br>
                    <asp:Label runat="server" Text="Dirección Trabajo:" ID="lblDireccionTrabajo"></asp:Label>&nbsp<asp:Label runat="server" Text="" ID="lblDataDirTra"></asp:Label>
                    <br>
                    <asp:Label runat="server" Text="Dabbawalla Encargado: " ID="lblDabbawallaEncargado"></asp:Label>&nbsp<asp:Label runat="server" Text="" ID="lblDataDabEncargado"></asp:Label>
                    <br>
                    <asp:Label runat="server" Text="Supervisor Encargado: " ID="lblSupervisorEncargado"></asp:Label>&nbsp<asp:Label runat="server" Text="" ID="lblDataSupEncargado"></asp:Label>
                </p>
                <a href="Informacion.aspx" class="secondary-content"><i class="material-icons">grade</i></a>
            </li>           
        </ul>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
