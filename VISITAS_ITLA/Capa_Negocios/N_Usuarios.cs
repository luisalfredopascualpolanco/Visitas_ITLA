using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class N_Usuarios
    {
        D_Usuarios objDato = new D_Usuarios();
        public void InsertandoUsuario(E_Usuarios usuario)
        {
            objDato.InsertarUsuario(usuario);
        }

        public string ValidandoUsuario(E_Usuarios usuario) 
        {
            string tipodedato = objDato.ValidarUsuario(usuario);
            return tipodedato;
        }
    }
}
