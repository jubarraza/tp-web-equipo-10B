using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TP_web_equipo_10B
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente();

                nuevo.Documento = txtDni.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Email = txtEmail.Text;
                nuevo.Direccion = txtDireccion.Text;
                nuevo.Ciudad = txtCiudad.Text;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}