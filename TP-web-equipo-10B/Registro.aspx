<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TP_web_equipo_10B.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .form-check {
            padding-left: 0rem;
        }
    </style>



    <div class="row">
        <h1>Registrate!!!</h1>
        <br />
        <div class="col-10">
            <div class="col-4">
                <label for="txtDni" class="form-label">DNI</label>
                <asp:TextBox runat="server" ID="txtDni" class="form-control" placeholder="99999999" />
                <div id="DniAlert" class="form-text">
                    <asp:Label runat="server" ID="lblDniError" CssClass="text-danger" Visible="false" Text="Ingrese DNI" />
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col order-first">
                    <div class="col-12">
                        <label for="txtNombre" class="form-label">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" class="form-control" placeholder="Homero" />
                        <div id="NombreAlert" class="form-text">
                            <asp:Label runat="server" ID="lblNombreError" CssClass="text-danger" Visible="false" Text="Ingrese Nombre" />
                        </div>
                    </div>
                </div>

                <div class="col">
                    <div class="col-12">
                        <label for="txtApellido" class="form-label">Apellido</label>
                        <asp:TextBox runat="server" ID="txtApellido" class="form-control" placeholder="Thompson" />
                        <div id="ApellidoAlert" class="form-text">
                            <asp:Label runat="server" ID="lblApellidoError" CssClass="text-danger" Visible="false" Text="Ingrese Apellido" />
                        </div>
                    </div>
                </div>
                <div class="col order-last">
                    <div class="col-12">
                        <label for="txtEmail" class="form-label">Email</label>
                        <asp:TextBox runat="server" ID="txtEmail" class="form-control" placeholder="miemail@email.com"/>
                        <div id="EmailAlert" class="form-text">
                            <asp:Label runat="server" ID="lblEmailError" CssClass="text-danger" Visible="false" Text="Ingrese Email" />
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-6">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDireccion" class="form-control" placeholder="Mi Ciudad" />
                    <div id="DireccionAlert" class="form-text">
                        <asp:Label runat="server" ID="lblDireccionError" CssClass="text-danger" Visible="false" Text="Ingrese Direccion" />
                    </div>
                </div>
                <div class="col-4">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="txtCiudad" class="form-control" placeholder="Calle 123" />
                    <div id="CiudadAlert" class="form-text">
                        <asp:Label runat="server" ID="lblCiudadError" CssClass="text-danger" Visible="false" Text="Ingrese Ciudad" />
                    </div>
                </div>
                <div class="col-2">
                    <label for="txtCP" class="form-label">CP</label>
                    <asp:TextBox runat="server" ID="txtCP" class="form-control" placeholder="xxxx" />
                    <div id="CP" class="form-text">
                        <asp:Label runat="server" ID="lblCpError" CssClass="text-danger" Visible="false" Text="Ingrese CP" />
                    </div>
                </div>
            </div>
            <br />
            <div class="form-check">
                <asp:CheckBox ID="checkCondiciones" class="form-check-label" runat="server" />
                <label for="checkCondiciones" class="form-check-label">Acepto los términos y condiones</label>
                <div id="NombreHelp" class="form-text">
                    <asp:Label runat="server" ID="lblCondicionesError" CssClass="text-danger" Visible="false" Text="Debe aceptar los terminos y condiciones para participar" />
                </div>
            </div>
            <br />
            <div class="col-3">
                <asp:Button Text="Participar!!!" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
            </div>
        </div>
    </div>

</asp:Content>
