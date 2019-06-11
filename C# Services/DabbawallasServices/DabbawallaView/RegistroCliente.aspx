<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="DabbawallaView.RegistroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
                <h1 class="header center teal-text text-lighten-2">Registro Cliente</h1>
                <div class="row center">
                  <h4 class="header col s12 text-lighten-2 black-text">Se parte de nuestra familia</h4>
                </div>
              </div>
            </div>
            <div class="parallax"><img src="FondoCliente.jpg" alt="Unsplashed background img 1"></div>
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
            <div class="container col s12 m4 l8">
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
                              <asp:TextBox ID="txCelular"  type="text" placeholder="Celular" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                          <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txDireccionHogar"  type="text" placeholder="Direccion Hogar" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>
                            <div class="row">
                            <div class="input-field col s12">
                              <asp:TextBox ID="txDireccionTrabajo"  type="text" placeholder="Direccion Trabajo" runat="server"></asp:TextBox> <br />
                            </div>
                          </div>

                           <div class="row">
                            <div class="input-field col s6">
                                <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlComunaHogar" runat="server">
                                    <asp:ListItem >Comuna Hogar</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="input-field col s6">
                                <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlComunaTrabajo" runat="server">
                                     <asp:ListItem >Comuna Trabajo</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                          </div>
                         
                          <asp:Button type="submit" runat="server" Text="Registrarse" class="btn btn-large" OnClick="Register"/>     
                      </div>
                </div>
        <!--  Scripts-->
  <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>f
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
