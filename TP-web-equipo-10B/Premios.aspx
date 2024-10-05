<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TP_web_equipo_10B.Premios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .img-small {
            height: 350px;
            width: 90%;
            object-fit: scale-down;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="mb-xl-3">

   <div class="mb-3 row">
      <h1>Eleccion del premio</h1>
      <p>En esta seccion podras seleccionar entre los premios disponibles</p>
   </div>

   <div class="row row-cols-3 g-4">

     <asp:Repeater runat="server" ID="rp_Repetidor" OnItemDataBound="rp_Repetidor_ItemDataBound">
         <ItemTemplate>
             <div class="col">
                 <div class="card">

                     <!-- carousel -->
                   <div id="carousel<%#Eval("Id")%>" class="carousel slide carousel-dark">
                       <div class="carousel-inner">
      
                    <asp:Repeater runat="server" ID="rpImagenes">
                      <ItemTemplate>
      
                         <div id="imgDiv" class="carousel-item" runat="server">
                         <asp:Image ImageUrl='<%#Eval("UrlImagen") %>' runat="server" CssClass="d-block w-100 img-small" AlternateText="Imagen Articulo" ID="imgControl"/>
                         </div>

                         </ItemTemplate>
                       </asp:Repeater>

                    <!-- controles del carousel -->
                    <div id="carouselControl" runat="server">
                    <button class="carousel-control-prev" id="btnAtras" type="button" data-bs-target="#carousel<%#Eval("Id")%>" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Anterior</span>
                    </button>

                    <button class="carousel-control-next" id="btnAdelante" type="button" data-bs-target="#carousel<%#Eval("Id")%>" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Siguiente</span>
                    </button>
                    </div> <!-- cierra controles de carousel -->

                     </div> <!-- cierra el carousel inner -->
                 </div> <!-- cierra el carousel slide -->
                 
                 <div class="card-body">
                     <h5 class="card-title"><%# Eval("Id") %> - <%# Eval("Nombre") %></h5>
                     <p class="card-text"><%# Eval("Descripcion") %></p>
                     <div class="button-center card border-0">
                     <asp:Button Text="Quiero este premio" runat="server" ID="btnPremio" CssClass="btn btn-primary" OnClick="btnPremio_Click" CommandArgument='<%# Eval("Id") %>' />
                     </div>
                 </div> <!-- cierra el card body -->

                    </div> <!-- cierra class card -->
                </div> <!-- cierra class col -->
            </ItemTemplate>
        </asp:Repeater>

    </div> <!-- cierra class row row-cols-1 -->
</div> <!-- cierra class mb-xl-3 -->

</asp:Content>
