using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_web_equipo_10B
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VoucherNegocio negVoucher = new VoucherNegocio();
            ArticuloNegocio negArticulo = new ArticuloNegocio();
            ClienteNegocio negCliente = new ClienteNegocio();

            try
            {
                string voucher = (string)Session["Voucher"];
                string premioId = (string)Session["premioID"];
                string clienteDni = (string)Session["cliente"];

                if (voucher != null && premioId != null && clienteDni != null) 
                {
                    Cliente cliente = ObtenerClienteRegistrado(clienteDni);
                    Articulo premio = ObtenerPremioElegido(premioId);



                    lblVoucher.Text = "El voucher registrado es: " + voucher.ToUpper();
                    lblPremio.Text = "El premio seleccionado es el #" + premioId + " - " + premio.Nombre;
                    lblDniCliente.Text = "El cliente registrado es: " + cliente.Nombre + " " + cliente.Apellido + " - DNI: " + clienteDni;


                    Voucher v = negVoucher.BuscarVoucher(voucher);
                    v.IdCliente = cliente.Id;
                    v.FechaCanje = DateTime.Now;
                    v.IdArticulo = int.Parse(premioId);

                    negVoucher.UsarVoucher(v);

                }
                else
                {
                    Session.Add("error","Falta alguno de los datos necesarios para el registro.\nPor favor vuelva a la pagina principal e intentelo de nuevo.");
                    //Response.Redirect("Error.aspx", false);
                }


                

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
        
        private Articulo ObtenerPremioElegido(string id)
        {
            Articulo aux = new Articulo();
            ArticuloNegocio neg = new ArticuloNegocio();

            aux = neg.BuscarArticulo(int.Parse(id));

            return aux;
        }

        private Cliente ObtenerClienteRegistrado(string clienteDNI)
        {
            Cliente aux = new Cliente();
            ClienteNegocio neg = new ClienteNegocio();

            aux = neg.obtenerCliente(clienteDNI);

            return aux;
        }


    }
}