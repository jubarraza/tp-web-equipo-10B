<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP_web_equipo_10B.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Incluir Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;600&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>


    <style>
        body {
            font-family: 'Poppins', sans-serif;
            background: url('https://cdn.cbeditz.com/cbeditz/preview/blue-white-gradiant-powerpoint-background-2-116109704563a3dqfntna.jpg') no-repeat center center fixed;
            background-size: cover;
        }

        .img-small {
            height: 350px;
            width: 90%;
            object-fit: scale-down;
        }

        h1 {
            font-weight: 700;
        }

        p{
            font-weight: 400;
            font-size:larger;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row mb-4 mt-5">
    <h1 class="text-center">¡Participá en nuestra promoción exclusiva de 10bStore!</h1>
    </div>
    <div class="row mb-4">
    <p>Con tan solo realizar una compra superior a $5000 en cualquiera de nuestras sucursales recibiras en tu ticket un codigo para poder participar por fabulosos premios.</p>
    <p>Esta promocion es muy especial porque VOS sos el que va a elegir por que premio queres participar. Todos los premios se estaran sorteando entre los participantes que lo hayan seleccionado.</p> 
    <p class="text-center text-bg-secondary col-9 ms-xl-auto me-auto" >¡Si ya tenes tu codigo, seguí los pasos a continuación y registra tu voucher para obtener fantásticos premios!</p>
    </div>

    <div class=" row">
    <div class="col-6">
        <h4 class="text-center mb-3">Premios 🎁</h4>
        <!-- carousel -->
        <div id="carouselImagenes" class="carousel slide carousel-dark " data-bs-ride="carousel">
            <div class="carousel-inner">

                <asp:Repeater runat="server" ID="rpImagenes">
                    <ItemTemplate>

                        <div id="imgDiv" class="carousel-item" runat="server">
                            <asp:Image ImageUrl='<%#Eval("UrlImagen") %>' runat="server" CssClass="d-block w-100 img-small" AlternateText="Imagen Articulo" ID="imgControl" />
                        </div>

                    </ItemTemplate>
                </asp:Repeater>

                <!-- controles del carousel -->
                <div id="carouselControl" runat="server">
                    <button class="carousel-control-prev" id="btnAtras" type="button" data-bs-target="#carouselImagenes" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Anterior</span>
                    </button>

                    <button class="carousel-control-next" id="btnAdelante" type="button" data-bs-target="#carouselImagenes" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Siguiente</span>
                    </button>
                </div>
                <!-- cierra controles de carousel -->

            </div>
            <!-- cierra el carousel inner -->
        </div>
        <!-- cierra el carousel slide -->

    </div>



    <div class="card col-5 align-items-center align-self-center h-100">
        <div class="card-body">
            <h2>Paso a paso para participar:</h2>
            <ol>
                <li>Realizá una compra en <strong>10bStore</strong>.</li>
                <li>Cargá el código del voucher que recibiste.</li>
                <li>Elegí el premio que más te guste.</li>
                <li>Ingresá tus datos y aceptá los términos y condiciones.</li>
            </ol>
        <!-- button trigger modal -->
        <div class="button-center card border-0">
            <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#examplemodal">
                Ingresa tu Voucher
            </button>
        </div>
        </div>
        </div>
</div>

            <div>
        

        <!-- modal -->
        <div class="modal fade" id="examplemodal" tabindex="-1" aria-labelledby="examplemodallabel" aria-hidden="true">
          <div class="modal-dialog">
            <div class="modal-content">
              <div class="modal-header">
                <h1 class="modal-title fs-5" id="examplemodallabel">Ingresa el Codigo recibido por tu compra</h1>                
                <asp:Button ID="btnCerrar" CssClass="btn-close" Onclick="btnCerrar_Click" data-bs-dismiss="modal" aria-label="close" runat="server"/>
              </div>
              <div class="modal-body">
                  <div class="input-group mb-3">
                      <asp:TextBox cssclass="form-control" type="password" ID="txtPassword" placeholder="Codigo..." runat="server" MaxLength="50"></asp:TextBox>                    
                  
                  <button id="show_password" class="btn btn-primary" type="button" onclick="mostrarPassword()"> <span class="fa fa-eye-slash icon"></span> </button>
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

<script type="text/javascript">
    function mostrarPassword() {
        var passwordField = document.getElementById('<%= txtPassword.ClientID %>'); 
        var icon = document.querySelector('#show_password .icon'); 

        if (passwordField.type === "password") {
            passwordField.type = "text"; 
            icon.classList.remove("fa-eye-slash"); 
            icon.classList.add("fa-eye");
        } else {
            passwordField.type = "password"; 
            icon.classList.remove("fa-eye");
            icon.classList.add("fa-eye-slash"); 
        }
    }
</script>

</asp:Content>
