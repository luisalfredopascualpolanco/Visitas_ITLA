using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class N_Secciones
    {
        D_Secciones objDato = new D_Secciones();
        public void InsertandoSeccion(E_Secciones seccion) 
        {
            objDato.InsertarSeccion(seccion);
        }
        public void LlenandoCombobox(ComboBox cmb)
        {
            objDato.LlenarCombobox(cmb);
        }

        public void llenandoComboboxSeccionesporEdificios(ComboBox cmb, int buscar) 
        {
            objDato.LlenarComboboxSeccionesPorEdificio(cmb,buscar);
        }
    }
}
