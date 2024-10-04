<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_web_equipo_10B.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido</h1>

            <div>
                <!-- button trigger modal -->
        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#examplemodal">
          Ingresa tu Voucher
        </button>

        <!-- modal -->
        <div class="modal fade" id="examplemodal" tabindex="-1" aria-labelledby="examplemodallabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h1 class="modal-title fs-5" id="examplemodallabel">Ingresa el Codigo de tu Vaucher! </h1>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="close"></button>
              </div>
              <div class="modal-body">
                  <div class="col-auto">
                    <label for="inputPassword2" class="visually-hidden">Password</label>
                    <input type="password" class="form-control" id="inputPassword2" placeholder="Codigo">
                  </div>
              </div>
              <div class="modal-footer">
                <button type="button" class="btn btn-primary">siguiente</button>
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">cancelar</button>
              </div>
            </div>
          </div>
        </div>
    </div>

</asp:Content>
