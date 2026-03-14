using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Net;
using System.Xml.Linq;
using System.Runtime.Remoting.Channels;

namespace Negocio
{
    public class PokemonNegocio
    {
        //Me va a permitir crear la conexión a la BD
        //Dónde van a estar todos los métodos que me permiten crear al conexión
        public List<Pokemon> ListarPokemon()
        {
            List<Pokemon> listPokemon = new List<Pokemon>();
            AccesoDatos dato = new AccesoDatos();

            try
            {
                dato.setQuery("SELECT P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = p.IdTipo AND D.ID = P.IdDebilidad AND P.activo = 1");
                dato.ejecutarLector();

                while (dato.Lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Id = (int)dato.Lector["Id"];
                    auxiliar.Numero = (int)dato.Lector["Numero"];
                    auxiliar.Nombre = (string)dato.Lector["Nombre"];
                    auxiliar.Descripcion = (string)dato.Lector["Descripcion"];
                    /*
                    if (!(dato.Lector.IsDBNull(dato.Lector.GetOrdinal("UrlImagen"))))
                        auxiliar.UrlImagen = (string)dato.Lector["UrlImagen"];
                    */
                    if (!(dato.Lector["UrlImagen"] is DBNull))
                        auxiliar.UrlImagen = (string)dato.Lector["UrlImagen"];
                    auxiliar.Tipo = new Elemento();
                    auxiliar.Tipo.Id = (int)dato.Lector["IdTipo"];
                    auxiliar.Tipo.Descripcion = (string)dato.Lector["Tipo"];
                    auxiliar.Debilidad = new  Elemento();
                    auxiliar.Debilidad.Id = (int)dato.Lector["IdDebilidad"];
                    auxiliar.Debilidad.Descripcion = (string)dato.Lector["Debilidad"];
                    listPokemon.Add(auxiliar);
                }
                
                return listPokemon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { dato.cerrarConexion(); }
        }
        public void Agregar(Pokemon pokemonNew)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setQuery($"Insert into Pokemons (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) Values (@numero, '@nombre', '@descripcion', 1, @idTipo, @idDebilidad, @urlImagen)");
                dato.setParameter("@numero", pokemonNew.Numero);
                dato.setParameter("@nombre", pokemonNew.Nombre);
                dato.setParameter("@descripcion", pokemonNew.Descripcion);
                dato.setParameter("@idTipo", pokemonNew.Tipo.Id);
                dato.setParameter("@idDebilidad", pokemonNew.Debilidad.Id);
                dato.setParameter("@urlImagen", pokemonNew.UrlImagen);
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { dato.cerrarConexion(); }
        }
        public void Modificar(Pokemon pokemon)
        {
            //Podríamos hacerlo en un atributo privado, para no tener que repetirlo cada vez
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setQuery("UPDATE pokemons SET numero = @numero, nombre = @nombre, descripcion = @descripcion, urlImagen = @urlImagen, idTipo = @idTipo, idDebilidad = @idDebilidad WHERE id = @id");
                dato.setParameter("@numero", pokemon.Numero);
                dato.setParameter("@nombre", pokemon.Nombre);
                dato.setParameter("@descripcion", pokemon.Descripcion);
                dato.setParameter("@urlImagen", pokemon.UrlImagen);
                dato.setParameter("@idTipo", pokemon.Tipo.Id);
                dato.setParameter("@idDebilidad", pokemon.Debilidad.Id);
                dato.setParameter("@id", pokemon.Id);

                dato.ejecutarAccion();
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

        public void EliminarFisico (int id)
        {
            try
            {
                AccesoDatos dato = new AccesoDatos();
                dato.setQuery("DELETE FROM pokemons WHERE id = @id");
                dato.setParameter("@id", id);
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarLogico(int id)
        {
            try
            {
                AccesoDatos dato = new AccesoDatos();
                dato.setQuery("UPDATE pokemons SET activo = 0 where id = @id");
                dato.setParameter("@id", id);
                dato.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Pokemon> Filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> listaPokemon = new List<Pokemon>();
            AccesoDatos dato = new AccesoDatos();
            try
            {
                string consulta = "SELECT P.Id, P.Numero, P.Nombre, P.Descripcion, P.UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad FROM POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE E.Id = p.IdTipo AND D.ID = P.IdDebilidad AND P.activo = 1 AND ";
                if(campo == "Número")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "P.Numero > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "P.Numero < " + filtro;
                            break;
                        default:
                            consulta += "P.Numero = " + filtro;
                            break;
                    }
                }else if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "P.Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "P.Nombre like '%" + filtro + "'"; 
                            break;
                        default:
                            consulta += "P.Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += "E.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "E.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "E.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                dato.setQuery(consulta);
                dato.ejecutarLector();
                while (dato.Lector.Read())
                {
                    Pokemon auxiliar = new Pokemon();
                    auxiliar.Id = (int)dato.Lector["Id"];
                    auxiliar.Numero = (int)dato.Lector["Numero"];
                    auxiliar.Nombre = (string)dato.Lector["Nombre"];
                    auxiliar.Descripcion = (string)dato.Lector["Descripcion"];
                    if (!(dato.Lector["UrlImagen"] is DBNull))
                        auxiliar.UrlImagen = (string)dato.Lector["UrlImagen"];
                    auxiliar.Tipo = new Elemento();
                    auxiliar.Tipo.Id = (int)dato.Lector["IdTipo"];
                    auxiliar.Tipo.Descripcion = (string)dato.Lector["Tipo"];
                    auxiliar.Debilidad = new Elemento();
                    auxiliar.Debilidad.Id = (int)dato.Lector["IdDebilidad"];
                    auxiliar.Debilidad.Descripcion = (string)dato.Lector["Debilidad"];
                    listaPokemon.Add(auxiliar);
                }

                return listaPokemon;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}