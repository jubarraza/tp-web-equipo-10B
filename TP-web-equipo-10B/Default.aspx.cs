using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TP_web_equipo_10B
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ImagenNegocio negocioImg = new ImagenNegocio();
                    rpImagenes.DataSource = negocioImg.Listar();
                    rpImagenes.DataBind();

                    //buscamos el div que contiene la imagen y lo convertimos a HTMLGenericControl para acceder a sus atributos HTML
                    var imgDiv = rpImagenes.Items[0].FindControl("imgDiv") as HtmlGenericControl;

                    imgDiv.Attributes.Add("class", "carousel-item active");

                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }


        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                string voucher = txtPassword.Text;
                VoucherNegocio voucherNeg = new VoucherNegocio();
                bool voucherValido = voucherNeg.buscarVoucherValido(voucher);
                if (voucherValido)
                {
                    Session.Add("voucher", txtPassword.Text);
                    Response.Redirect("Premios.aspx", false);
                }
                else
                {
                    Session.Add("error", "El voucher ingresado no es valido");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
            

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }
    }
}