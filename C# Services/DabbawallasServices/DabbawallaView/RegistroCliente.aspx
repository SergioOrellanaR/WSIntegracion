<%@ Page Language="C#" MasterPageFile="~/NormalMasterpage.Master" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="DabbawallaView.RegistroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col s12 m4 l8">
        <div class="row col s12">
            <div class="row">
                <div class="input-field col s6">
                    <asp:TextBox ID="txUsername" type="text" placeholder="Username" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldUsername" runat="server" ErrorMessage="Se requiere que ingrese username" ControlToValidate="txUsername"></asp:RequiredFieldValidator>
                </div>
                <div class="input-field col s6">
                    <asp:TextBox ID="txPassword" type="password" placeholder="Contraseña" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" runat="server" ErrorMessage="Se requiere que ingrese password" ControlToValidate="txPassword"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txNombre" type="text" placeholder="Nombre" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldNombre" runat="server" ErrorMessage="Se requiere que ingrese nombre" ControlToValidate="txNombre"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txApellido" type="text" placeholder="Apellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldApellido" runat="server" ErrorMessage="Se requiere que ingrese apellido" ControlToValidate="txApellido"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txEmail" type="email" placeholder="Email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldEmail" runat="server" ErrorMessage="Se requiere que ingrese email" ControlToValidate="txEmail"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txCelular" type="text" placeholder="Celular" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldCelular" runat="server" ErrorMessage="Se requiere que ingrese celular" ControlToValidate="txCelular"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txDireccionHogar" type="text" placeholder="Direccion Hogar" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldDireccionHogar" runat="server" ErrorMessage="Se requiere que ingrese dirección de hogar" ControlToValidate="txDireccionHogar"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="row">
                <div class="input-field col s12">
                    <asp:TextBox ID="txDireccionTrabajo" type="text" placeholder="Direccion Trabajo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldDireccionTrabajo" runat="server" ErrorMessage="Se requiere que ingrese dirección de trabajo" ControlToValidate="txDireccionTrabajo"></asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>

            <div class="row">
                <div class="input-field col s6">
                    <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlComunaHogar" runat="server">
                        <asp:ListItem>Comuna Hogar</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="input-field col s6">
                    <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlComunaTrabajo" runat="server">
                        <asp:ListItem>Comuna Trabajo</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <asp:Button type="submit" runat="server" Text="Registrarse" class="btn btn-large" OnClick="Register" />
        </div>
    </div>
</asp:Content>
