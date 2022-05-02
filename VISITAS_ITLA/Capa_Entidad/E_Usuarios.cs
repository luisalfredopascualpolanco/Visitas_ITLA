using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Usuarios
    {
        private int _IdUsuario;
        private string _Nombres;
        private string _Apellidos;
        private DateTime _FechaNacimiento;
        private string _TipoUsuario;
        private string _NombreUsuario;
        private string _Contraseña;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
    }
}
