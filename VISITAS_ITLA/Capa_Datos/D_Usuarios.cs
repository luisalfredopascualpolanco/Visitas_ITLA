using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Data;


namespace Capa_Datos
{
    public class D_Usuarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarUsuario(E_Usuarios usuarios) 
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRES",usuarios.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", usuarios.Apellidos);
            cmd.Parameters.AddWithValue("@FECHA_DE_NACIMIENTO", usuarios.FechaNacimiento);
            cmd.Parameters.AddWithValue("@TIPO_DE_USUARIO", usuarios.TipoUsuario);
            cmd.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", usuarios.NombreUsuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuarios.Contraseña);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public string ValidarUsuario(E_Usuarios usuario) 
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VALIDAR_USUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE_DE_USUARIO", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.Contraseña);
            leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                usuario.TipoUsuario = leer.GetString(0);
            }
            // string TipoDeUsuario = Convert.ToString(leer);
            /*List<E_Usuarios> TipoDeUsuario = new List<E_Usuarios>();
            while (leer.Read()) 
            {
                TipoDeUsuario.Add(new E_Usuarios
                {
                    TipoUsurio = leer.GetString(0)
                });
            }*/            
            conexion.Close();
            leer.Close();
            return usuario.TipoUsuario;
        }
    }
}
