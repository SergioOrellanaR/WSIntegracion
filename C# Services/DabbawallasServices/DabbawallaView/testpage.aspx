<%@ Page Title="" Language="C#" MasterPageFile="~/Logeado.Master" AutoEventWireup="true" CodeBehind="testpage.aspx.cs" Inherits="DabbawallaView.testpage" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <!-- Aqui debiesen ir elementos del header propios que no se encuentran en la masterpage -->
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div class="row">
                <div class="input-field col s6">
                    <asp:DropDownList class="form-control dropdown-trigger btn" ID="ddlComunaHogar" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
</asp:Content>


<asp:Content ID="ContentScripts" ContentPlaceHolderID="ContentPlaceHolderScripts" runat="server">
    <!-- Aqui debiesen ir scripts propios de una página -->
</asp:Content>
