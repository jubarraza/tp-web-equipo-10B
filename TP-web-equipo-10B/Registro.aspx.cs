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
                Cliente nuevo = new Cliente();
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                ResetearError();

                if (Validarcompleto() && AceptarTerminos())
                {                   
                    nuevo.Documento = txtDni.Text;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Email = txtEmail.Text;
                    nuevo.Direccion = txtDireccion.Text;
                    nuevo.Ciudad = txtCiudad.Text;
                    nuevo.Cp = int.Parse(txtCP.Text);

                    clienteNegocio.AgregarCliente(nuevo);

                    Response.Redirect("Success.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        private bool AceptarTerminos() 
        {
            if(checkCondiciones.Checked == true) 
            { 
                return true;
            }
            else
            {
                lblCondicionesError.Visible = true;
                return false;
            }
        }


        private bool Validarcompleto()
        {
            bool band = true;
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {     
                    lblDniError.Text = "Ingrese DNI";
                    lblDniError.Visible = true;
                    band = false;         
            }
            if (txtDni.Text.Length != 8 || VerificarNumeros(txtDni.Text))
            {
                lblDniError.Text = "Debe ingresar un DNI valido";
                lblDniError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblNombreError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                lblApellidoError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblEmailError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                lblDireccionError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                lblCiudadError.Visible = true;
                band = false;
            }
            if (string.IsNullOrWhiteSpace(txtCP.Text))
            {
                lblCpError.Visible = true;
                band = false;
            }

            if(band)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        private bool VerificarNumeros(string texto)
        {
            foreach (char N in texto)
            {
                if (char.IsLetter(N))
                {
                    return true;
                }
            }
            return false;
        }

        private void ResetearError()
        {
            lblDniError.Visible = false;
            lblNombreError.Visible = false;
            lblApellidoError.Visible = false;
            lblEmailError.Visible=false;
            lblDireccionError.Visible=false;
            lblCiudadError.Visible=false;
            lblCpError.Visible=false;
            lblCondicionesError.Visible=false;
        }
 


    }
}