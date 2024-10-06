using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {        
        public List<Voucher> Listar()
        {
            List<Voucher> listadoVoucher = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("select CodigoVoucher from Vouchers where IdCliente is Null and FechaCanje is null and IdArticulo is Null");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Voucher aux = new Voucher();
                    aux.CodigoVoucher = (string)datos.Lector["CodigoVoucher"];


                    listadoVoucher.Add(aux);

                }
                return listadoVoucher;
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

        public bool buscarVoucherValido(string codigoVoucher)
        {
            List<Voucher> listado = new List<Voucher>();
            VoucherNegocio voucherListado = new VoucherNegocio();
            listado = voucherListado.Listar();

            foreach (Voucher voucher in listado)
            {
                if (voucher.CodigoVoucher.ToLower() == codigoVoucher.ToLower())
                {
                    return true;
                }

            }
            return false;
        }

        public Voucher BuscarVoucher(string codigo)
        {
            try
            {
                List<Voucher> listado = new List<Voucher>();
                VoucherNegocio voucherListado = new VoucherNegocio();
                listado = voucherListado.Listar();

                foreach (Voucher voucher in listado)
                {
                    if (voucher.CodigoVoucher.ToLower() == codigo.ToLower())
                    {
                        return voucher;
                    }

                }

                return null;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UsarVoucher(Voucher v) 
        {
            List<Voucher> listadoVoucher = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("Update Vouchers SET IdCliente = @IdCliente, FechaCanje = @Fecha, IdArticulo = @IdArticulo WHERE CodigoVoucher = @Codigo");
                datos.SetearParametro("@IdCliente", v.IdCliente);
                datos.SetearParametro("@Fecha", v.FechaCanje);
                datos.SetearParametro("@IdArticulo", v.IdArticulo);
                datos.SetearParametro("@Codigo", v.CodigoVoucher);
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
