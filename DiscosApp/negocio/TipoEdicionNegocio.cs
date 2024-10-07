using accesoDatos;
using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class TipoEdicionNegocio
    {
        public List<TipoEdicion> listaTipoEdicion()
        {

            List<TipoEdicion> lista = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion From TiposEdicion");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
    }
}
