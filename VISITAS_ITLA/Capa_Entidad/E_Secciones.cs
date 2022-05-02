using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Secciones
    {
        private int _IdSecciones;
        private string _Nombre;
        private int _NumeroEdifico;
        private string _NombreNuevo;

        public int IdSecciones { get => _IdSecciones; set => _IdSecciones = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int NumeroEdifico { get => _NumeroEdifico; set => _NumeroEdifico = value; }
        public string NombreNuevo { get => _NombreNuevo; set => _NombreNuevo = value; }
    }
}
