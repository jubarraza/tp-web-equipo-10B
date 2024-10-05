using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Text;
using System.EnterpriseServices;
using static AjaxControlToolkit.AsyncFileUpload.Constants;


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
                /* Cliente nuevo = new Cliente();
                 ClienteNegocio clienteNegocio = new ClienteNegocio();

                 nuevo.Documento = txtDni.Text;
                 nuevo.Nombre = txtNombre.Text;
                 nuevo.Apellido = txtApellido.Text;
                 nuevo.Email = txtEmail.Text;
                 nuevo.Direccion = txtDireccion.Text;
                 nuevo.Ciudad = txtCiudad.Text;
                 nuevo.Cp = int.Parse(txtCP.Text);

                

                clienteNegocio.AgregarCliente(nuevo);*/

                Validarcompleto();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        private bool Validarcompleto()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                lblDniError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombreError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                lblApellidoError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                lblDireccionError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                lblCiudadError.Visible = true;
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCP.Text))
            {
                lblCpError.Visible = true;
                return false;
            }
            return true;
        }


    }
}