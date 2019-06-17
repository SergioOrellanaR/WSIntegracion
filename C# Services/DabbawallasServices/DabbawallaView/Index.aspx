<%@ Page Language="C#" MasterPageFile="~/NormalMasterpage.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DabbawallaView.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="index-banner" class="parallax-container">
        <div class="section no-pad-bot">
            <div class="container">
                <br>
                <br>
                <h1 class="header center teal-text text-lighten-2">Dabbawallas Chile</h1>
                <div class="row center">
                    <h4 class="header col s12 text-lighten-2 black-text">Conoce mas acerca de nosotros</h4>
                </div>
                <div class="row center">
                    <a href="#" id="download-button" class="btn-large waves-effect waves-light teal lighten-1">Conocenos</a>
                </div>
                <br>
                <br>
            </div>
        </div>
        <div class="parallax">
            <img src="Fondo1.jpg" alt="Unsplashed background img 1"></div>
    </div>

    <!--   Registro seccion  -->
    <div id="registro" class="modal">
        <h5 class="modal-close">&#10005;</h5>
        <div class="modal-content center">
            <div class="card">
                <div class="card-content">
                    <p>I am a very simple card. I am good at containing small bits of information. I am convenient because I require little markup to use effectively.</p>
                </div>
                <div class="card-tabs">
                    <ul class="tabs tabs-fixed-width">
                        <li class="tab"><a class="active" href="#test4">Cliente</a></li>
                        <li class="tab"><a href="#test5">Dabbawea</a></li>
                        <li class="tab"><a href="#test6">Supervisor</a></li>
                    </ul>
                </div>
                <div class="card-content grey lighten-4">
                    <div id="test4">
                        <div class="row col s12">
                            <div class="row">
                                <div class="input-field col s6">
                                    <asp:TextBox ID="txUsername" type="text" placeholder="Username" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                                <div class="input-field col s6">
                                    <asp:TextBox ID="txPassword" type="password" placeholder="Contraseña" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <asp:TextBox ID="txNombre" type="text" placeholder="Nombre" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <asp:TextBox ID="txApellido" type="text" placeholder="Apellido" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <asp:TextBox ID="txEmail" type="email" placeholder="Email" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <asp:TextBox ID="txCelular" type="number" placeholder="Celular" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="input-field col s12">
                                    <asp:TextBox ID="txIdSupervisor" type="number" placeholder="ID Supervisor" runat="server"></asp:TextBox>
                                    <br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col s12">
                                    This is an inline input field:
                              <div class="input-field inline">
                                  <input id="email_inline" type="email" class="validate">
                                  <label for="email_inline">Email</label>
                                  <span class="helper-text" data-error="wrong" data-success="right">Helper text</span>
                              </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div id="test5">
                        test2
                    </div>
                    <div id="test6">Test 3</div>
                </div>
            </div>
        </div>
    </div>
    <!--   fin seccion registro  -->
    <div class="container">
        <div class="section">

            <!--   Icon Section   -->
            <div class="row">
                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">flash_on</i></h2>
                        <h5 class="center">Speeds up development</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
                    </div>
                </div>

                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">group</i></h2>
                        <h5 class="center">User Experience Focused</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget Additionally, a single underlying responsive system across all platforms allow for a more unified user experience.</p>
                    </div>
                </div>

                <div class="col s12 m4">
                    <div class="icon-block">
                        <h2 class="center brown-text"><i class="material-icons">settings</i></h2>
                        <h5 class="center">Easy to work with</h5>

                        <p class="light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
                    </div>
                </div>
            </div>

        </div>
    </div>


    <div class="parallax-container valign-wrapper">
        <div class="section no-pad-bot">
            <div class="container">
                <div class="row center">
                    <h5 class="header col s12 light">A modern responsive front-end framework based on Material Design</h5>
                </div>
            </div>
        </div>
        <div class="parallax">
            <img src="Fondo2.jpg" alt="Unsplashed background img 2">
        </div>
    </div>

    <div class="container">
        <div class="section">

            <div class="row">
                <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Contact Us</h4>
                    <p class="left-align light">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget, bibendum sollicitudin lacus. Aliquam eleifend sollicitudin diam, eu mattis nisl maximus sed. Nulla imperdiet semper molestie. Morbi massa odio, condimentum sed ipsum ac, gravida ultrices erat. Nullam eget dignissim mauris, non tristique erat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;</p>
                </div>
            </div>

        </div>
    </div>


    <div class="parallax-container valign-wrapper">
        <div class="section no-pad-bot">
            <div class="container">
                <div class="row center">
                    <h5 class="header col s12 light">A modern responsive front-end framework based on Material Design</h5>
                </div>
            </div>
        </div>
        <div class="parallax">
            <img src="background3.jpg" alt="Unsplashed background img 3"></div>
    </div>
</asp:Content>






