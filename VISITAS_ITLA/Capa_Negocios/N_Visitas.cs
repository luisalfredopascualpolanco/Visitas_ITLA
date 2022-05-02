using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class N_Visitas
    {
        D_Visitas objDato = new D_Visitas();
        public void InsertandoVisitas(E_Visitas visita) 
        {
            objDato.InsertarVisita(visita);
        }

        public List<E_Visitas> ListarVisita(string buscar) 
        {
            return objDato.ListarVisitas(buscar);
        }
    }
}
