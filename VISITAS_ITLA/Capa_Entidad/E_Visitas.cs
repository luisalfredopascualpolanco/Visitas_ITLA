using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Visitas
    {
        private int _IdVisita;
        private string _Nombres;
        private string _Apellidos;
        private string _Carrera;
        private string _Correo;
        private int _Edificio;
        private DateTime _FechaYHoraEntrada;
        private DateTime _FechaYHoraSalida;
        private string _MotivoVisita;
        private byte[] _Foto;
        private string _Destino;

        public int IdVisita { get => _IdVisita; set => _IdVisita = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public int Edificio { get => _Edificio; set => _Edificio = value; }
        public DateTime FechaYHoraEntrada { get => _FechaYHoraEntrada; set => _FechaYHoraEntrada = value; }
        public DateTime FechaYHoraSalida { get => _FechaYHoraSalida; set => _FechaYHoraSalida = value; }
        public string MotivoVisita { get => _MotivoVisita; set => _MotivoVisita = value; }
        public byte[] Foto { get => _Foto; set => _Foto = value; }
        public string Destino { get => _Destino; set => _Destino = value; }
    }
}
