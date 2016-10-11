using gestionbibliotecaMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gestionbibliotecaMVC.DAL
{
    public class EjemplarRepositoryImp:EjemplarRepository
    {
        private string conexionString = ConfigurationManager.ConnectionStrings["biblioteca"].ConnectionString;
        private IList<Ejemplar> ejemplares;

        public Guid create(Ejemplar ejemplar)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.Open();  
                SqlCommand cmd = new SqlCommand("addbook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoLibro", ejemplar.CodigoLibro);
                cmd.Parameters.AddWithValue("@codigoEjemplar", ejemplar.CodigoEjemplar);
                cmd.Parameters.AddWithValue("@codigoAutor", ejemplar.Autor.Codigo);
                cmd.Parameters.AddWithValue("@codigoEditorial", ejemplar.Editorial.Codigo);
                cmd.Parameters.AddWithValue("@nPaginas", ejemplar.NPaginas);
                cmd.ExecuteNonQuery();
               // success 
            }
            catch (Exception ex)
            {
                 // return error message
            }
            finally
            {
                con.Close();
            }
            return new Guid();
        }

        public void delete(Guid codigo)
        {
            SqlConnection con = new SqlConnection(conexionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("deleteEjemplar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();
            }
        }

        public IList<Ejemplar> getAll()
        {
            IList<Ejemplar> ejemplares = null;
            const string SQL = "getAllEjemplares";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {
                SqlCommand cmd = new SqlCommand(SQL, conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    
                    if (reader.HasRows)
                    {
                        
                      
                        Ejemplar ejemplar = null;
                        while (reader.Read())
                        {
                            ejemplar = parseEjemplar(reader);
                            ejemplares.Add(ejemplar);
                        }
                    }
                }
            }
            return ejemplares;
        }

        public Ejemplar getById(Guid codigo)
        {
            Ejemplar Ejemplar = null;
            const string SQL = "getEjemplarByID";

            using (SqlConnection conexion = new SqlConnection(conexionString))
            {

                SqlCommand command = new SqlCommand(SQL, conexion);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@pEjemplarId", codigo);
                conexion.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {//si devuelve datos

                        while (reader.Read())//cada vuelta es una tupla
                        {
                            Ejemplar = parseEjemplar(reader);
                        }
                    }
                }
            }
            return Ejemplar;
        }

        private Ejemplar parseEjemplar(SqlDataReader reader)
        {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar.CodigoEjemplar = new Guid(reader["codigoEjemplar"].ToString());
            ejemplar.CodigoLibro= new Guid(reader["codigoEjemplar"].ToString());
            ejemplar.Isbn= reader["isbn"].ToString();
            ejemplar.NPaginas= Convert.ToInt32(reader["npaginas"]) ;
            ejemplar.FPublicacion = (DateTime)reader["fPublicacion"]; ;
            return ejemplar;
        }

        public Ejemplar update(Ejemplar ejemplar)
        {
            SqlConnection con = new SqlConnection(conexionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("updatebook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoLibro", ejemplar.CodigoLibro);
                cmd.Parameters.AddWithValue("@codigoEjemplar", ejemplar.CodigoEjemplar);
                cmd.Parameters.AddWithValue("@codigoAutor", ejemplar.Autor.Codigo);
                cmd.Parameters.AddWithValue("@codigoEditorial", ejemplar.Editorial.Codigo);
                cmd.Parameters.AddWithValue("@npaginas", ejemplar.NPaginas);
                cmd.ExecuteNonQuery();
                return null; // success 
            }
            catch (Exception ex)
            {
                 // return error message
            }
            finally
            {
                con.Close();
            }
            return ejemplar;
        }
    }
}
