using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*importamos*/
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Semana04.Models
{
    public class EstudianteDao
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection cn = new SqlConnection   (cadena);

        public string insertar(Estudiante obj)
        {
            String rpta = null;
            try
            {
                SqlCommand cmd = new SqlCommand();

                /*aqui le paso la sentencia sql*/
                cmd.CommandText = "insert into estudiante values (@nom, @ape, @tel, @cor)";

                cmd.Parameters.AddWithValue("@nom", obj.nombre);
                cmd.Parameters.AddWithValue("@ape", obj.apellido);
                cmd.Parameters.AddWithValue("@tel", obj.telefono);
                cmd.Parameters.AddWithValue("@cor", obj.correo);

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cn.Open();
                /*enviar la orden de comando a la bd*/
                cmd.ExecuteNonQuery();
                cn.Close();
                /*liberar los recursos del comando*/
                cmd.Dispose();
                rpta = "ok";
            }
            catch(SqlException e)
            {
                rpta = "no";
            }

            return rpta;
        }

    }
}