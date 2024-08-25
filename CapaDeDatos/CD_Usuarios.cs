using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDeDatos
{
    public class CD_Usuarios
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            using (SqlConnection oconeccion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT * FROM users";

                    SqlCommand cmd = new SqlCommand(query, oconeccion);
                    cmd.CommandType = CommandType.Text;
                    oconeccion.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader()) 
                    {
                       while (dr.Read()) {
                            lista.Add(new Usuarios()
                            {
                                id =  Convert.ToInt32(dr["ID"]),
                                nombre = dr["nombre"].ToString(),   
                            });

                            }
                    }
                }
                catch (Exception ex) { 
                    lista = new List<Usuarios>();
            }
        }
            return lista;
    
    }
    }
}
