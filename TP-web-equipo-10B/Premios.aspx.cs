using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TP_web_equipo_10B
{
    public partial class Premios : System.Web.UI.Page
    {
        public List<Imagen> ImagenesArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            try
            {
                if (!IsPostBack)
                {
                    List<Articulo> lista = artNegocio.listar();
                    rp_Repetidor.DataSource = lista;
                    rp_Repetidor.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void btnPremio_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((Button)sender).CommandArgument;

                Session.Add("premioID", id);
                Response.Write("ID de articulo elegido " + id);
            }
            catch (Exception ex)
            {
                //Session.Add("error", ex);
                //Response.Redirect("Error.aspx");
                Response.Write(ex.ToString());
            }
        }

        protected List<Imagen> ObtenerImagenesPorArticulo(int articuloId)
        {
            try
            {
                ImagenNegocio imgNegocio = new ImagenNegocio();

                List<Imagen> lista = imgNegocio.Listar();
                ImagenesArticulo = new List<Imagen>();

                foreach (Imagen img in lista)
                {
                    if (img.Articulo.Id == articuloId)
                    {
                        ImagenesArticulo.Add(img);
                    }
                }

                return ImagenesArticulo;
            }
            catch (Exception ex)
            {
                //Session.Add("error", ex);
                //Response.Redirect("Error.aspx");
                Response.Write(ex.ToString());
                throw;
            }
        }

        protected void rp_Repetidor_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            try
            {
                //obtenemos el artículo actual
                Articulo articulo = (Articulo)e.Item.DataItem;

                //buscamos el repeater de imagenes que esta anidado y lo guardamos en una variable 
                Repeater rpImagenes = (Repeater)e.Item.FindControl("rpImagenes");


                //carga de las imágenes para el artículo actual
                rpImagenes.DataSource = ObtenerImagenesPorArticulo(articulo.Id);
                rpImagenes.DataBind();



                if (rpImagenes.Items.Count > 0) //si hay imagenes para el articulo
                {
                    for (int i = 0; i < rpImagenes.Items.Count; i++)
                    {
                        //buscamos el div que contiene la imagen y lo convertimos a HTMLGenericControl para acceder a sus atributos HTML
                        var imgDiv = rpImagenes.Items[i].FindControl("imgDiv") as HtmlGenericControl;

                        if (i == 0) //si es la primera imagen en class ponemos active para que lo muestre
                        {
                            imgDiv.Attributes.Add("class", "carousel-item active");
                        }
                        else //resto de imagenes
                        {
                            imgDiv.Attributes.Add("class", "carousel-item");
                        }
                    }


                }
                else  //si el articulo no tiene imagenes
                {
                    //agregamos el item al Repetidor
                    AgregarPlaceholder(rpImagenes);

                    //ocultamos los controles del carousel
                    var flechas = e.Item.FindControl("carouselControl") as HtmlGenericControl;
                    flechas.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //Session.Add("error", ex);
                //Response.Redirect("Error.aspx");
                Response.Write(ex.ToString());
            }
        }

        private void AgregarPlaceholder(Repeater rpImagenes)
        {
            try
            {
                // guardamos la imagen que usaremos cuando no haya imágenes
                string placeholderImagen = "https://www.asociart.com.ar/wp-content/uploads/2023/10/placeholder-17.png";

                // creamos un nuevo item para el repeater de imagen
                RepeaterItem placeholderItem = new RepeaterItem(0, ListItemType.Item);

                // creamos manualmente los controles div e imagen necesarios
                HtmlGenericControl imgDiv = new HtmlGenericControl("div");
                imgDiv.Attributes.Add("class", "carousel-item active");

                HtmlImage imgControl = new HtmlImage();
                imgControl.Src = placeholderImagen;
                imgControl.Alt = "Sin imagen";
                imgControl.Attributes.Add("class", "d-block w-100 img-small");

                // agregamos la Imagen al Div
                imgDiv.Controls.Add(imgControl);

                // agregamos el Div al Item
                placeholderItem.Controls.Add(imgDiv);

                // agregamos el Item al Repeater
                rpImagenes.Controls.Add(placeholderItem);
            }
            catch (Exception ex)
            {
                //Session.Add("error", ex);
                //Response.Redirect("Error.aspx");
                Response.Write(ex.ToString());
            }
        }
    }
}