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
    public partial class Default : System.Web.UI.Page
    {
        private List<Voucher> listaVaucher;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsPostBack)
                {
                    VoucherNegocio voucherNeg = new VoucherNegocio();
                    listaVaucher = voucherNeg.Listar();
                    if (listaVaucher == null)
                    {
                        //Ningun Voucher Disponible
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            string voucher = txtPassword.Text;
            VoucherNegocio voucherNeg = new VoucherNegocio();
            bool voucherValido = voucherNeg.buscarVoucher(voucher);
            if (voucherValido)
            {
                Response.Redirect("Premios.aspx");
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