using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;
using System.Data;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class D_Edificios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarEdificio(E_Edificios edificio, E_Secciones seccion)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", edificio.NumeroEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION", seccion.Nombre);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarEdificio(E_Edificios edificio, E_Secciones seccion)
        {
            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", edificio.NumeroEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION_VIEJO", seccion.Nombre);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION_NUEVO", seccion.NombreNuevo);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public void LlenarCombobox(ComboBox cmb) 
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VER_EDIFICIOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            leer = cmd.ExecuteReader();

            //List<E_Edificios> listar = new List<E_Edificios>();
            while (leer.Read()) 
            {
                cmb.Items.Add(leer["NUMERO_DE_EDIFICIO"].ToString());
            }
            conexion.Close();
            leer.Close();            
        }
    }
}
