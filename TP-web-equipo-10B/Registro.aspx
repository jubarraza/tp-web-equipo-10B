<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TP_web_equipo_10B.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h1>Registrate!!!</h1>
        <br />
        <div class="col-10">
            <div class="col-4">
                <label for="txtDni" class="form-label">DNI</label>
                <asp:TextBox runat="server" ID="txtDni" class="form-control" />
            </div>
            <br />
            <div class="row">
                <div class="col order-first">
                    <div class="col-12">
                        <label for="txtNombre" class="form-label">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" class="form-control" />
                    </div>
                </div>
                <div class="col">
                    <div class="col-12">
                        <label for="txtApellido" class="form-label">Apellido</label>
                        <asp:TextBox runat="server" ID="txtApellido" class="form-control" />
                    </div>
                </div>
                <div class="col order-last">
                    <div class="col-12">
                        <label for="txtEmail" class="form-label">Email</label>
                        <asp:TextBox runat="server" ID="txtEmail" class="form-control" />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-6">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDireccion" class="form-control" />
                </div>
                <div class="col-4">
                    <label for="txtCalle" class="form-label">Calle</label>
                    <asp:TextBox runat="server" ID="txtCalle" class="form-control" />
                </div>
                <div class="col-2">
                    <label for="txtCP" class="form-label">CP</label>
                    <asp:TextBox runat="server" ID="txtCP" class="form-control" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
