using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Edificios
    {
        private int _IdEdificio;
        private int _NumeroEdificio;

        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public int NumeroEdificio { get => _NumeroEdificio; set => _NumeroEdificio = value; }
    }
}
