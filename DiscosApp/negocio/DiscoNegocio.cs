using accesoDatos;
using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocio
{
    public class DiscoNegocio
    {
        public List<Disco> listar()
        {
            //creacion de ua lista de discos y de una instancia de la clase AccesoDatos para acceder a sus metodos
            List<Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            //Agregar los valores de las propiedades del disco
            try
            {
                //setear consulta
                datos.setearConsulta(@"Select D.Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, 
                                       IdEstilo,IdTipoEdicion, E.Descripcion Estilo, T.Descripcion TipoEdicion, Activo 
                                       From dbo.DISCOS as D 
                                       inner join  ESTILOS as E on E.Id = D.IdEstilo 
                                       inner join TIPOSEDICION as T on T.Id = D.IdTipoEdicion");

                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = datos.Lector["Titulo"].ToString();
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = datos.Lector["UrlImagenTapa"].ToString();

                    aux.Estilo = new dominio.Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    aux.Activo = (bool)datos.Lector["Activo"];

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

        public void Agregar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"INSERT INTO DISCOS
                                    (Titulo, FechaLanzamiento, CantidadCanciones,
                                    UrlImagenTapa, IdEstilo, IdTipoEdicion, Activo)
                                    VALUES 
                                    (@Titulo, @FechaLanzamiento, @CantidadCanciones, 
                                    @UrlImagenTapa, @IdEstilo, @IdTipoEdicion, @Activo)");

                datos.agregarParametros("@Titulo", disco.Titulo);
                datos.agregarParametros("@FechaLanzamiento", disco.FechaLanzamiento);
                datos.agregarParametros("@CantidadCanciones", disco.CantidadCanciones);
                datos.agregarParametros("@UrlImagenTapa", disco.UrlImagenTapa);
                datos.agregarParametros("@IdEstilo", disco.Estilo.Id);
                datos.agregarParametros("@IdTipoEdicion", disco.TipoEdicion.Id);
                datos.agregarParametros("@Activo", disco.Activo);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void Modificar(Disco disco)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"UPDATE DISCOS 
                                    SET Titulo = @Titulo, FechaLanzamiento = @FechaLanzamiento,
                                    CantidadCanciones = @CantidadCanciones, UrlImagenTapa = @UrlImagenTapa, 
                                    IdEstilo = @IdEstilo, IdTipoEdicion = @IdTipoEdicion, Activo = @Activo)
                                    WHERE  Id = @Id");

                datos.agregarParametros("@Id", disco.Id);

                datos.agregarParametros("@Titulo", disco.Titulo);
                datos.agregarParametros("@FechaLanzamiento", disco.FechaLanzamiento);
                datos.agregarParametros("@CantidadCanciones", disco.CantidadCanciones);
                datos.agregarParametros("@UrlImagenTapa", disco.UrlImagenTapa);
                datos.agregarParametros("@IdEstilo", disco.Estilo.Id);
                datos.agregarParametros("@IdTipoEdicion", disco.TipoEdicion.Id);
                datos.agregarParametros("@Activo", disco.Activo);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void EliminarLogico(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE DISCOS SET Activo = 0 WHERE  Id = @id");
                datos.agregarParametros("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Disco> Filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> discos = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"Select D.Id, D.Titulo, D.FechaLanzamiento, CantidadCanciones, UrlImagenTapa, 
                                       IdEstilo,IdTipoEdicion, E.Descripcion Estilo, T.Descripcion TipoEdicion, Activo 
                                       From dbo.DISCOS as D 
                                       inner join  ESTILOS as E on E.Id = D.IdEstilo 
                                       inner join TIPOSEDICION as T on T.Id = D.IdTipoEdicion
                                       Where ";

                if (campo == "Titulo")
                {
                    switch (criterio)
                    {
                        case "Contiene":
                            consulta += "D.Titulo like '%" + filtro + "%'";
                            break;
                        case "Comienza con":
                            consulta += "D.Titulo like '" + filtro + "%'";

                            break;
                        case "Termina con":
                            consulta += "D.Titulo like '%" + filtro + "'";
                            break;
                    }
                }
                else if (campo == "Año")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += $"D.FechaLanzamiento > {filtro}";
                            break;
                        case "Menor a":
                            consulta += $"D.FechaLanzamiento < {filtro}";
                            break;
                        case "Igual a":
                            consulta += $"D.FechaLanzamiento = {filtro}";
                            break;
                    }
                }
                else if (campo == "Estilo")
                {
                    if (!string.IsNullOrEmpty(criterio))
                        consulta += $"E.Descripcion = '{criterio}' AND D.Titulo like '%{filtro}%'";
                }
                else if (campo == "Formato")
                {
                    if (!string.IsNullOrEmpty(criterio))
                        consulta += $"T.Descripcion = '{criterio}' AND D.Titulo like '%{filtro}%'";
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = datos.Lector["Titulo"].ToString();
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = datos.Lector["UrlImagenTapa"].ToString();

                    aux.Estilo = new dominio.Estilo();
                    aux.Estilo.Id = (int)datos.Lector["IdEstilo"];
                    aux.Estilo.Descripcion = (string)datos.Lector["Estilo"];

                    aux.TipoEdicion = new TipoEdicion();
                    aux.TipoEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TipoEdicion.Descripcion = (string)datos.Lector["TipoEdicion"];

                    aux.Activo = (bool)datos.Lector["Activo"];

                    discos.Add(aux);
                }
                return discos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
