<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="DabbawallaView.Tickets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="section">
            <div class="col s12 center">
                    <h3><i class="mdi-content-send brown-text"></i></h3>
                    <h4>Beneficios de la Suscripción</h4>

            </div>
            <!--   Icon Section   -->
            <div class="row">
                <div class="col s12 m10">
                    <div class="icon-block">
                        <div class="col s12 m7">
                          <div class="card-large card-panel hoverable">
                            <div class="card-image ">
                              <img src="dabbawalla_tarjeta.jpg">
                              <h4>Administrador de Tickets</h4>
                            </div>
                            <div class="card-content">
                              <p>I am a very simple card. I am good at containing small bits of information.
                              I am convenient because I require little markup to use effectively.</p>
                            </div>
                            <div class="card-action">
                               <asp:Button type="submit" runat="server" Text="Enviar Ticket" CssClass="btn btn-large" Enabled="true" />
                               <asp:Button type="submit" runat="server" Text="Cerrar Ticket" CssClass="btn btn-large red" Enabled="false"/>
                            </div>
                          </div>
                        </div> 
                    </div>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
</asp:Content>
