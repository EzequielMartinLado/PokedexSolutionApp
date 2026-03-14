    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=LADO-EZEQUIEL\\SQLEXPRESS01; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();

        }

        public void setQuery(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }
        public void ejecutarLector()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void setParameter(string name,object value )
        {
            comando.Parameters.AddWithValue(name, value);
        }
        public void cerrarConexion()
        {
            if(lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
