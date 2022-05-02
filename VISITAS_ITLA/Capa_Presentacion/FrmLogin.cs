using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Entidad;

namespace Capa_Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        E_Usuarios EntidadUsuario = new E_Usuarios();
        N_Usuarios NegocioUsuario = new N_Usuarios();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                EntidadUsuario.NombreUsuario = txtUsuario.Text.ToString();
                EntidadUsuario.Contraseña = txtContraseña.Text.ToString();
                string tipo = NegocioUsuario.ValidandoUsuario(EntidadUsuario);
                if (tipo is null)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
                else if (tipo == "ADMINISTRADOR")
                {
                    FrmRegistroVisitas formulario = new FrmRegistroVisitas();
                    formulario.Show();
                    this.Hide();
                }
                else 
                {
                    FrmRegistroVisitas_General_ visita = new FrmRegistroVisitas_General_();
                    visita.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, comuniquese con soporte técnico");
            }
                  
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
