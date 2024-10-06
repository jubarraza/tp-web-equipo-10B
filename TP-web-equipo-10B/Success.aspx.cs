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
                    lblVoucher.Text = "El voucher registrado es: " + voucher;
                    lblPremio.Text = "El premio seleccionado es el #" + premioId;
                    lblDniCliente.Text = "El DNI del cliente registrado es: " + clienteDni;


                    Voucher v = negVoucher.BuscarVoucher(voucher);
                    v.IdCliente = negCliente.ConsultarID(clienteDni);
                    v.FechaCanje = DateTime.Now;
                    v.IdArticulo = int.Parse(premioId);

                    negVoucher.UsarVoucher(v);

                }
                else
                {
                    Session.Add("error","Falta alguno de los datos necesarios para el registro.\nPor favor vuelva a la pagina principal e intentelo de nuevo.");
                    Response.Redirect("Error.aspx", false);
                }


                

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
        


        
    }
}