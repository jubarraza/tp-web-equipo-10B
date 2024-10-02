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

        <div class="row row-cols-1 row-cols-md-3 g-4">

            <% foreach (Dominio.Articulo art in ListaArticulos)
                {
                    foreach (Dominio.Imagen img in ListaImagenes)
                    {
                        if (img.Articulo.Id == art.Id)
                        {
                            ImagenesArticulo.Add(img);
                        }

                    }%>

            <div class="col">
                <div class="card h-100">

                    <!-- carousel -->
                    <div id="carousel<%: art.Id %>" class="carousel slide carousel-dark" >
                        <div class="carousel-inner">
                            <% for (int i = 0; i < ImagenesArticulo.Count; i++)
                                { %>
                            <div class="carousel-item <%: (i == 0) ? "active" : "" %>">
                                <img src="<%: ImagenesArticulo[i].UrlImagen %>" class="d-block w-100 img-small" alt="Imagen del artículo">
                            </div>
                            <% } %>
                        </div>

                        <!-- controles del carousel -->
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%: art.Id %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>

                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%: art.Id %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>
                   
                    <!-- Contenido de la Card -->
                    <div class="card-body">
                        <h5 class="card-title"><%: art.Nombre %></h5>
                        <p class="card-text"><%: art.Descripcion %></p>
                        <div class="button-center card border-0">
                            <asp:Button Text="Quiero este premio!" runat="server" ID="btnPremio" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>

            <%  ImagenesArticulo.Clear();

                } %>
        </div>
    </div>

</asp:Content>
