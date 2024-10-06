using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
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


        public bool ConsultarDni(string DNI)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("select * from Clientes where Documento like @DNI");
                datos.SetearParametro("@DNI", DNI);
                datos.EjecutarLectura();
                if(datos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Cliente obtenerCliente(string DNI)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente aux = new Cliente();

            try
            {
                datos.SetearConsulta("select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes WHERE Documento = @DNI");
                datos.SetearParametro("@DNI", DNI);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Ciudad = (string)datos.Lector["Ciudad"];
                    aux.Cp = (int)datos.Lector["CP"];
                }
                    return aux;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public Cliente obtenerCliente(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente aux = new Cliente();

            try
            {
                datos.SetearConsulta("select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes WHERE Id = @Id");
                datos.SetearParametro("@Id", id);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Documento = (string)datos.Lector["Documento"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.Email = (string)datos.Lector["Email"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.Ciudad = (string)datos.Lector["Ciudad"];
                    aux.Cp = (int)datos.Lector["CP"];
                }
                return aux;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public int ConsultarID(string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            int id;

            try
            {
                datos.SetearConsulta("select Id from Clientes WHERE Documento = @DNI");
                datos.SetearParametro("@DNI", dni);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    return (int)datos.Lector["Id"];
                }
                
                return -1; //no existe

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void ModificarCliente(Cliente aux)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("UPDATE Clientes SET Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Direccion = @Direccion, Ciudad = @Ciudad, CP = @Cp WHERE Id = @Id");

                datos.SetearParametro("@Documento", aux.Documento);
                datos.SetearParametro("@Nombre", aux.Nombre);
                datos.SetearParametro("@Apellido", aux.Apellido);
                datos.SetearParametro("@Email", aux.Email);
                datos.SetearParametro("@Direccion", aux.Direccion);
                datos.SetearParametro("@Ciudad", aux.Ciudad);
                datos.SetearParametro("@Cp", aux.Cp);
                datos.SetearParametro("@Id", aux.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
