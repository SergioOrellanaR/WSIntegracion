<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Suscripcion.aspx.cs" Inherits="DabbawallaView.Suscripcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="parallax-container valign-wrapper">
        <div class="section no-pad-bot">
            <div class="container">
                <div class="row center">
                    <h5 class="header col s12 light">A modern responsive front-end framework based on Material Design</h5>
                </div>
            </div>
        </div>
        <div class="parallax">
            <img src="Fondo2.jpg" alt="Unsplashed background img 2"></div>
    </div>

    <div class="container">
        <div class="section">
            <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Beneficios de la Suscripción</h4>

            </div>
            <!--   Icon Section   -->
            <div class="row">
                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">flash_on</i></h2>
                        <h5 class="center">Rapidez de Servicio</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
                    </div>
                </div>

                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">group</i></h2>
                        <h5 class="center">Nunca estaras solo</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget Additionally, a single underlying responsive system across all platforms allow for a more unified user experience.</p>
                    </div>
                </div>

                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">settings</i></h2>
                        <h5 class="center">Funciones de pedido</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
                    </div>
                </div>
            </div>

        </div>
    </div>
    
    <div class="container">
        <div class="section">
            <div class="row">
                <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Suscribete Aqui</h4> <asp:Button type="submit" runat="server" Text="Suscribete" CssClass="btn btn-large" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
