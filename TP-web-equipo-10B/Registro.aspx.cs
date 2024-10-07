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
using System.Text.RegularExpressions;
using System.Net.Mail;


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
                ClienteNegocio negociocliente = new ClienteNegocio();


                if (Validarcompleto())
                {
                    if (AceptarTerminos())
                    {
                        if (negociocliente.ConsultarDni(txtDni.Text) == false)
                        {
                            CrearCliente();
                        }
                        else
                        {
                            Cliente modificado = negociocliente.obtenerCliente(txtDni.Text);
                            modificado.Nombre = txtNombre.Text;
                            modificado.Apellido = txtApellido.Text;
                            modificado.Email = txtEmail.Text;
                            modificado.Direccion = txtDireccion.Text;
                            modificado.Ciudad = txtCiudad.Text;
                            modificado.Cp = int.Parse(txtCP.Text);

                            negociocliente.ModificarCliente(modificado);
                        }

                        //envio del correo de confirmacion
                        EnviarCorreo(txtEmail.Text, txtNombre.Text, txtApellido.Text);

                        Session.Add("cliente", txtDni.Text);

                        Response.Redirect("Success.aspx", false);

                    }
                    else
                    {
                        lblCondicionesError.Visible = true;
                    }

                }

            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }

        private void EnviarCorreo(string destinatario, string nombre, string apellido)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("10b.Store.promo@gmail.com");
                correo.To.Add(destinatario);
                correo.Subject = "10bStore - Confirmación de participación en la promo Compra, Elegi y Gana";
                correo.Body = $@"
                                    <html>
                                    <body>
                                        <h2>¡Gracias por tu participación!</h2>
                                        <p> Hola {nombre} {apellido},</p>
                                        <p>Te confirmamos que tu participación en la promoción <strong>Compra, Elegí y Ganá</strong> ha quedado registrada correctamente.</p>
                                        <p>¡Mucha suerte! 🍀🍀</p>
                                        <hr/>
                                        <p><small>Este es un mensaje automático, por favor no responda a este correo.</small></p>
                                    </body>
                                    </html>";
                correo.IsBodyHtml = true;

                // Enviar el correo usando la configuración del web.config
                SmtpClient smtp = new SmtpClient();
                smtp.Send(correo);
                Console.WriteLine("Correo enviado a " + destinatario);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }

        private void CrearCliente()
        {
            try
            {
                Cliente nuevo = new Cliente();
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                ResetearError();


                nuevo.Documento = txtDni.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Email = txtEmail.Text;
                nuevo.Direccion = txtDireccion.Text;
                nuevo.Ciudad = txtCiudad.Text;
                nuevo.Cp = int.Parse(txtCP.Text);

                clienteNegocio.AgregarCliente(nuevo);


            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
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
            try
            {
                bool band = true;
                if (string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    lblDniError.Text = "Ingrese DNI";
                    lblDniError.Visible = true;
                    band = false;
                }
                if (txtDni.Text.Length < 8 || VerificarNumeros(txtDni.Text))
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
                else
                {
                    lblNombreError.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    lblApellidoError.Visible = true;
                    band = false;
                }
                else
                {
                    lblApellidoError.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    lblEmailError.Visible = true;
                    band = false;
                }
                else
                {
                    lblEmailError.Visible = false;
                }

                if (!validarEmail(txtEmail.Text))
                {
                    lblEmailError.Text = "Debe ingresar un email valido";
                    lblEmailError.Visible = true;
                    band = false;
                }

                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    lblDireccionError.Visible = true;
                    band = false;
                }
                else
                {
                    lblDireccionError.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(txtCiudad.Text))
                {
                    lblCiudadError.Visible = true;
                    band = false;
                }
                else
                {
                    lblCiudadError.Visible = false;
                }

                if (string.IsNullOrWhiteSpace(txtCP.Text) || VerificarNumeros(txtCP.Text))
                {
                    lblCpError.Visible = true;
                    band = false;
                }
                else
                {
                    lblCpError.Visible = false;
                }

                if (band)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx", false);
                throw;
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
 
        private bool validarEmail(string email)
        {
            string formato;
            formato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]w+)*";
            if(Regex.Replace(email,formato,string.Empty).Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDni.Text.Length < 8 || VerificarNumeros(txtDni.Text))
                {
                    lblDniError.Text = "Debe ingresar un DNI valido";
                    lblDniError.Visible = true;
                    LimpiarCampos();
                }
                else //tiene formato correcto
                {
                    lblDniError.Visible = false;
                    ClienteNegocio negocioCliente = new ClienteNegocio();
                    Cliente aux = new Cliente();

                    if (negocioCliente.ConsultarDni(txtDni.Text))
                    {
                        aux = negocioCliente.obtenerCliente(txtDni.Text);

                        txtDni.Text = aux.Documento;
                        txtNombre.Text = aux.Nombre;
                        txtApellido.Text = aux.Apellido;
                        txtEmail.Text = aux.Email;
                        txtDireccion.Text = aux.Direccion;
                        txtCiudad.Text = aux.Ciudad;
                        txtCP.Text = aux.Cp.ToString();
                    }
                    else
                    {
                        lblDniError.Visible = false;
                        LimpiarCampos();
                    }

                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

            

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtCP.Text = "";
        }

    }
}