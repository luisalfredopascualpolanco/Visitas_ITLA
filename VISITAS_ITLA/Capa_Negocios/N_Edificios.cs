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
    public class N_Edificios
    {
        D_Edificios objDato = new D_Edificios();
        public void InsertandoEdificio(E_Edificios edificio, E_Secciones seccion) 
        {
            objDato.InsertarEdificio(edificio, seccion);
        }

        public void ModificandoEdificio(E_Edificios edificio, E_Secciones seccion) 
        {
            objDato.ModificarEdificio(edificio, seccion);
        }

        public void LlenandoCombobox(ComboBox cmb) 
        {
            objDato.LlenarCombobox(cmb);
        }
    }
}
