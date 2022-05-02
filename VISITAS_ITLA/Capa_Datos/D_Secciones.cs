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
    public class D_Secciones
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarSeccion(E_Secciones seccion)
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_SECCION", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", seccion.NumeroEdifico);
            cmd.Parameters.AddWithValue("@NOMBRE_SECCION", seccion.Nombre);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void LlenarCombobox(ComboBox cmb)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VER_SECCIONES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            leer = cmd.ExecuteReader();

            //List<E_Edificios> listar = new List<E_Edificios>();
            while (leer.Read())
            {
                cmb.Items.Add(leer["NOMBRE"].ToString());
            }
            conexion.Close();
            leer.Close();
        }

        public void LlenarComboboxSeccionesPorEdificio(ComboBox cmb, int buscar) 
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_SECCIONES_POR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NUMERO_DE_EDIFICIO", buscar);
            cmd.ExecuteNonQuery();
            leer = cmd.ExecuteReader();

            //List<E_Edificios> listar = new List<E_Edificios>();
            while (leer.Read())
            {
                cmb.Items.Add(leer["NOMBRE"].ToString());
            }
            conexion.Close();
            leer.Close();
        }
    }
}
