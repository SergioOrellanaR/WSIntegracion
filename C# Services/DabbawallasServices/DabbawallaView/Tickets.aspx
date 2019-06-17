<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="DabbawallaView.Tickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container col s12 m4 l8">
        <div class="section">
            <div class="col s12 center">
                <h3><i class="mdi-content-send brown-text"></i></h3>
                <h4>Tickets</h4>
                <h6>Estado actual de su ticket: <asp:Label runat="server" Text="no hay ticket activo"></asp:Label></h6>
            </div>
        </div>
        <div class="row">
            <div class="input-field col s6">
                <div class="card-large card-panel hoverable">
                    <div class="card-image ">
                        <img src="dabbawalla_tarjeta.jpg" height="300" width="570">
                        <h4>Abre tus Tickets</h4>
                    </div>
                    <div class="card-content">
                        <p>
                            I am a very simple card. I am good at containing small bits of information.
                              I am convenient because I require little markup to use effectively.
                        </p>
                    </div>
                    <div class="card-action">
                        <asp:TextBox ID="txUsuario" type="text" placeholder="Usuario" runat="server"></asp:TextBox>
                        <asp:Button type="submit" runat="server" Text="Enviar Ticket" CssClass="btn btn-large" Enabled="true" />
                    </div>
                </div>
            </div>
            <div class="input-field col s6">
                <div class="icon-block">
                    <div class="card-large card-panel hoverable">
                        <div class="card-image ">
                            <img src="dabbawalla_tarjeta.jpg" height="300" width="550">
                            <h4>Cierra tus Tickets</h4>
                        </div>
                        <div class="card-content">
                            <p>
                                I am a very simple card. I am good at containing small bits of information.
                              I am convenient because I require little markup to use effectively.
                            </p>
                        </div>
                        <div class="card-action">
                            <label>Califica nuestro servicio</label>
                            <asp:DropDownList class="form-control dropdown-trigger btn-small" ID="ddlCalificacion" runat="server">
                                <asp:ListItem Text="1"></asp:ListItem>
                                <asp:ListItem Text="2"></asp:ListItem>
                                <asp:ListItem Text="3"></asp:ListItem>
                                <asp:ListItem Text="4"></asp:ListItem>
                                <asp:ListItem Text="5"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button type="submit" runat="server" Text="Cerrar Ticket" CssClass="btn btn-large red" Enabled="false" />
                        </div>
                    </div>
                </div>
            </div>
            <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
            <asp:Button type="submit" runat="server" Text="Enviar Alerta" CssClass="btn btn-large red" Enabled="false" />

        </div>

    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
