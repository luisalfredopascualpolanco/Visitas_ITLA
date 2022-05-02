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
    public class D_Visitas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public List<E_Visitas> ListarVisitas(string buscar) 
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VISITAS_POR_EDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@EDIFICIO", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Visitas> Listar = new List<E_Visitas>();
            while (LeerFilas.Read()) 
            {
                Listar.Add(new E_Visitas
                {
                    IdVisita = LeerFilas.GetInt32(0),
                    Nombres = LeerFilas.GetString(1),
                    Apellidos = LeerFilas.GetString(2),
                    Carrera = LeerFilas.GetString(3),
                    Correo = LeerFilas.GetString(4),
                    Edificio = LeerFilas.GetInt32(5),
                    FechaYHoraEntrada = LeerFilas.GetDateTime(6),
                    FechaYHoraSalida = LeerFilas.GetDateTime(7),
                    MotivoVisita = LeerFilas.GetString(8),
                   // Foto = LeerFilas.getbuffer(9),
                    Destino = LeerFilas.GetString(9)
                }); ;
            }
            conexion.Close();
            LeerFilas.Close();
            return Listar;
        }
        public void InsertarVisita(E_Visitas visita)
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_VISITA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRES", visita.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", visita.Apellidos);
            cmd.Parameters.AddWithValue("@CARRERA", visita.Carrera);
            cmd.Parameters.AddWithValue("@CORREO", visita.Correo);
            cmd.Parameters.AddWithValue("@EDIFICIO", visita.Edificio);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_ENTRADA", visita.FechaYHoraEntrada);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_SALIDA", visita.FechaYHoraSalida);
            cmd.Parameters.AddWithValue("@MOTIVO_DE_VISITA", visita.MotivoVisita);
            cmd.Parameters.AddWithValue("@AULA_O_LUGAR_AL_QUE_SE_DIRIGE", visita.Destino);
            cmd.Parameters.AddWithValue("@FOTO", visita.Foto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
