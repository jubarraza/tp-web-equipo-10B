<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_web_equipo_10B.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Bienvenido</h1>

            <div>
                <!-- button trigger modal -->
        <div class="d-grid gap-2 col-4 mx-auto">
            <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#examplemodal">
              Ingresa tu Voucher
            </button>
        </div>

        <!-- modal -->
        <div class="modal fade" id="examplemodal" tabindex="-1" aria-labelledby="examplemodallabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h1 class="modal-title fs-5" id="examplemodallabel">Ingresa el Codigo de tu Vaucher! </h1>                
                <asp:Button ID="btnCerrar" CssClass="btn-close" Onclick="btnCerrar_Click" data-bs-dismiss="modal" aria-label="close" runat="server"/>
              </div>
              <div class="modal-body">
                  <div class="col-auto">
                    <label for="txtPassword2" class="visually-hidden">Password</label>
                      <asp:TextBox type="password" cssclass="form-control" ID="txtPassword" placeholder="Codigo..." runat="server"></asp:TextBox>                    
                  </div>
              </div>
              <div class="modal-footer">
                <asp:Button ID="btnSiguiente" CssClass="btn btn-primary" OnClick="btnSiguiente_Click" runat="server" Text="Siguiente" />
                <asp:Button ID="btnCancelar" CssClass="btn btn-secondary" OnClick="btnCancelar_Click" runat="server" Text="Cancelar" />                
              </div>
            </div>
          </div>
        </div>
    </div>

</asp:Content>
