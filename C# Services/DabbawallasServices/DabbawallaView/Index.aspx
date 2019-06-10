<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="DabbawallaView.Index" %>

<!DOCTYPE html>

<html lang="en">
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <title>Dabbawallas - Chile</title>

  <!-- CSS  -->
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">  
  <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection"/>
  <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection"/>
  <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
  <nav class="white" role="navigation">
    <div class="nav-wrapper container">
      <a id="logo-container" href="Index.aspx" class="brand-logo">Dabbaweas</a>
      <ul class="right hide-on-med-and-down">
          <a href="#login" class="waves-effect waves-light btn modal-trigger">Login</a>          
          <a class='dropdown-trigger btn' href='#' data-target='dropdown1'>Registro</a>
      </ul>

      <ul id="nav-mobile" class="sidenav">
          <a href="#login" class="waves-effect waves-light btn">Login</a>          
      </ul>
      <a href="#" data-target="nav-mobile" class="sidenav-trigger"><i class="material-icons">menu</i></a>
      
    </div>
  </nav>

  <!-- Dropdown Structure -->
  <ul id='dropdown1' class='dropdown-content'>
        <li><a href="RegistroCliente.aspx">Cliente</a></li>
        <li class="divider" tabindex="-1"></li>
        <li><a href="RegistroSupervisor.aspx">Supervisor</a></li>
        <li class="divider" tabindex="-1"></li>
        <li><a href="RegistroDabbawalla.aspx" >Dabbawalla</a></li>
        <li class="divider" tabindex="-1"></li>
   </ul>


  <div id="index-banner" class="parallax-container">
    <div class="section no-pad-bot">
      <div class="container">
        <br><br>
        <h1 class="header center teal-text text-lighten-2">Dabbawallas Chile</h1>
        <div class="row center">
          <h4 class="header col s12 text-lighten-2 black-text">Conoce mas acerca de nosotros</h4>
        </div>
        <div class="row center">
          <a href="#" id="download-button" class="btn-large waves-effect waves-light teal lighten-1">Conocenos</a>
        </div>
        <br><br>

      </div>
    </div>
    <div class="parallax"><img src="Fondo1.jpg" alt="Unsplashed background img 1"></div>
  </div>

    <!--   Login Section   -->        

        <div id="login" class="modal ">
          <h5 class="modal-close">&#10005;</h5>
          <div class="modal-content center">
            <h4>Inicio Sesión</h4>
            <br>

              <div class="input-field">
                <i class="material-icons prefix">person</i>
                <asp:TextBox ID="txUser"  type="text" placeholder="Username" runat="server"></asp:TextBox><br />
              </div>
              <br>

              <div class="input-field">
                <i class="material-icons prefix">lock</i>
                <asp:TextBox ID="txPass" class="col-xs-12 col-sm-12 col-md-12 col-lg-12 noMarr" type="password" placeholder="Contraseña" runat="server"></asp:TextBox> <br />
              </div>
              <br>

              <div class="left" style="margin-left:20px;">
                <input type="checkbox" id="check">
                <label for="check">Remember Me</label>
              </div>
              <br>
                <asp:Button type="submit" runat="server" Text="Ingresar" class="btn btn-large"/>                    
          </div>
        </div>
    <!--   fin seccion login  -->
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
                    <li class="tab"><a class="active"href="#test4">Cliente</a></li>
                    <li class="tab"><a href="#test5">Dabbawea</a></li>
                    <li class="tab"><a href="#test6">Supervisor</a></li>
                  </ul>
                </div>
                <div class="card-content grey lighten-4">
                  <div id="test4">
                      <div class="row col s12">
                          <div class="row">
                            <div class="input-field col s6">
                              <asp:TextBox ID="txUsername"  type="text" placeholder="Username" runat="server"></asp:TextBox> <br />
                            </div>
                            <div class="input-field col s6">
                               <asp:TextBox ID="txPassword"  type="password" placeholder="Contraseña" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                               <asp:TextBox ID="txNombre"  type="text" placeholder="Nombre" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txApellido"  type="text" placeholder="Apellido" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txEmail"  type="email" placeholder="Email" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txCelular"  type="number" placeholder="Celular" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txIdSupervisor"  type="number" placeholder="ID Supervisor" runat="server"></asp:TextBox> <br />
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
    <div class="parallax"><img src="Fondo2.jpg" alt="Unsplashed background img 2"></div>
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
    <div class="parallax"><img src="background3.jpg" alt="Unsplashed background img 3"></div>
  </div>

  <footer class="page-footer teal">
    <div class="container">
      <div class="row">
        <div class="col l6 s12">
          <h5 class="white-text">Company Bio</h5>
          <p class="grey-text text-lighten-4">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam scelerisque id nunc nec volutpat. Etiam pellentesque tristique arcu, non consequat magna fermentum ac. Cras ut ultricies eros. Maecenas eros justo, ullamcorper a sapien id, viverra ultrices eros. Morbi sem neque, posuere et pretium eget</p>
        </div>
        <div class="col l3 s12">
          <h5 class="white-text">Settings</h5>
          <ul>
            <li><a class="white-text" href="#!">Link 1</a></li>
            <li><a class="white-text" href="#!">Link 2</a></li>
            <li><a class="white-text" href="#!">Link 3</a></li>
            <li><a class="white-text" href="#!">Link 4</a></li>
          </ul>
        </div>
        <div class="col l3 s12">
          <h5 class="white-text">Connect</h5>
          <ul>
            <li><a class="white-text" href="#!">Link 1</a></li>
            <li><a class="white-text" href="#!">Link 2</a></li>
            <li><a class="white-text" href="#!">Link 3</a></li>
            <li><a class="white-text" href="#!">Link 4</a></li>
          </ul>
        </div>
      </div>
    </div>
    <div class="footer-copyright">
      <div class="container">
      Desarrollado por <a class="brown-text text-lighten-3" href="http://novasmart.com">NovaSmart</a>
      </div>
    </div>
  </footer>


  <!--  Scripts-->
  <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
  <script src="js/materialize.js"></script>
  <script src="js/init.js"></script>
    <script>
        $(document).ready(function(){
  		    $('.modal').modal();
        });

        $(document).ready(function(){
            $('.tabs').tabs();
        });
        $('.dropdown-trigger').dropdown();
    </script>


        </form>
  </body>

</html>


