<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TP_web_equipo_10B.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .form-check {
            padding-left: 0rem;
        }
    </style>


    <asp:ScriptManager ID="ScmValidar" runat="server" />

    <asp:Panel ID="VentanaModal" runat="server">
        <div class="modal fade" id="Modal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Ingresa el Codigo de tu Vaucher! </h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <p id="txttexto" style="text-align:center" >Ojala funcione</p>
                        .
                    </div>
                    <div class="modal-footer">
                        <asp:Button id="btAceptarModal" Text="Aceptar" class="btn btn-primary" runat="server" />           
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>

    <div class="row">
        <h1>Registrate!!!</h1>
        <br />
        <div class="col-10">
            <div class="col-4">
                <label for="txtDni" class="form-label">DNI</label>
                <asp:TextBox runat="server" ID="txtDni" class="form-control" placeholder="99999999" />
            </div>
            <br />
            <div class="row">
                <div class="col order-first">
                    <div class="col-12">
                        <label for="txtNombre" class="form-label">Nombre</label>
                        <asp:TextBox runat="server" ID="txtNombre" class="form-control" placeholder="Homero" />
                    </div>
                </div>
                <div class="col">
                    <div class="col-12">
                        <label for="txtApellido" class="form-label">Apellido</label>
                        <asp:TextBox runat="server" ID="txtApellido" class="form-control" placeholder="Thompson" />
                    </div>
                </div>
                <div class="col order-last">
                    <div class="col-12">
                        <label for="txtEmail" class="form-label">Email</label>
                        <asp:TextBox runat="server" ID="txtEmail" class="form-control" placeholder="miemail@email.com" />
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-6">
                    <label for="txtDireccion" class="form-label">Dirección</label>
                    <asp:TextBox runat="server" ID="txtDireccion" class="form-control" placeholder="Mi Ciudad" />
                </div>
                <div class="col-4">
                    <label for="txtCiudad" class="form-label">Ciudad</label>
                    <asp:TextBox runat="server" ID="txtCiudad" class="form-control" placeholder="Calle 123" />
                </div>
                <div class="col-2">
                    <label for="txtCP" class="form-label">CP</label>
                    <asp:TextBox runat="server" ID="txtCP" class="form-control" placeholder="xxxx" />
                </div>
            </div>
            <br />
            <div class="form-check">
                <asp:CheckBox ID="checkCondiciones" class="form-check-label" runat="server" />
                <label for="checkCondiciones" class="form-check-label">Acepto los términos y condiones</label>
            </div>
            <br />
            <div class="col-3">
                <asp:Button Text="Participar!!!" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
            </div>
        </div>

        <asp:Button  ID="BtVtmd1" Text="MostrarModal" runat="server" style="display: none"/>

    </div>

    <ajaxToolkit:ModalPopupExtender ID="AjVentanaModal" runat="server" OkControlID="btAceptarModal" CancelControlID="btAceptarModal"
        TargetControlID="BtVtmd1" PopupControlID="VentanaModal" ></ajaxToolkit:ModalPopupExtender>


</asp:Content>
