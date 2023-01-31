using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
// para tener accesso
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {
            List<Permiso> lista = new List<Permiso>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.IdRol, p.NombreMenu FROM PERMISO p");
                    query.AppendLine("INNER JOIN ROL r ON r.IdRol = p.IdRol");
                    query.AppendLine("INNER JOIN USUARIO u ON u.IdRol = r.IdRol");
                    query.AppendLine("WHERE u.IdUsuario = @idUsuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    //abrir la cadena de conexion
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) } ,
                                NombreMenu = dr["NombreMenu"].ToString()
                            });
                        }

                    }
                }
                catch (Exception e)
                {
                    lista = new List<Permiso>();
                }
            }

            return lista;
        }
    }
}
