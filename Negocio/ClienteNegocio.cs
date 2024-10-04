using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void AgregarCliente(Cliente inscripcion) 
        {   
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("insert into Clientes values(@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @Cp)");
                datos.SetearParametro("@Documento", inscripcion.Documento);
                datos.SetearParametro("@Nombre", inscripcion.Nombre);
                datos.SetearParametro("@Apellido", inscripcion.Apellido);
                datos.SetearParametro("@Email", inscripcion.Email);
                datos.SetearParametro("@Direccion", inscripcion.Direccion);
                datos.SetearParametro("@Ciudad", inscripcion.Ciudad);
                datos.SetearParametro("@Cp", inscripcion.Cp);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
              
                throw ex;
              
            }
            finally
            {
                datos.CerrarConexion();
            }
        
        }
    }
}
