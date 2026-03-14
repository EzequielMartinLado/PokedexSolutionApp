using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> Listar()
        {
            List<Elemento> listElements = new List<Elemento>();
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setQuery("SELECT id, descripcion FROM ELEMENTOS");
                dato.ejecutarLector();

                while (dato.Lector.Read())
                {
                    Elemento auxiliar = new Elemento();
                    auxiliar.Id = (int)dato.Lector["Id"];
                    auxiliar.Descripcion = (string)dato.Lector["Descripcion"];
                    listElements.Add(auxiliar);
                }


                return listElements;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }

       
    }
}
