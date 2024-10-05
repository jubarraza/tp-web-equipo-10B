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
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }
    }
}