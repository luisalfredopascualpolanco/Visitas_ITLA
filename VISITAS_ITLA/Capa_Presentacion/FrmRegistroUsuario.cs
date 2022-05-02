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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }
        N_Usuarios objNusuario = new N_Usuarios();
        E_Usuarios objEusuario = new E_Usuarios();
        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Nombres");
                }
                else if (txtApellidos.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Apellidos");
                }
                else if (cmbTipoDeUsuario.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Tipo de Usuario");
                }
                else if (txtNombreDeUsuario.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Nombre de Usuario");
                }
                else if (txtContraseña.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Contraseña");
                }
                else 
                {
                    objEusuario.Nombres = txtNombres.Text.ToString().ToUpper();
                    objEusuario.Apellidos = txtApellidos.Text.ToString().ToUpper();
                    objEusuario.FechaNacimiento = dtpFechaNacimiento.Value;
                    objEusuario.TipoUsuario = cmbTipoDeUsuario.Text.ToString().ToUpper();
                    objEusuario.NombreUsuario = txtNombreDeUsuario.Text.ToString().ToUpper();
                    objEusuario.Contraseña = txtContraseña.Text.ToString().ToUpper();
                    objNusuario.InsertandoUsuario(objEusuario);
                    MessageBox.Show("Usuario Agregado");
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    cmbTipoDeUsuario.Text = "";
                    txtNombreDeUsuario.Text = "";
                    txtContraseña.Text = "";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el usuario");                
            }
        }

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistroVisitas visita = new FrmRegistroVisitas();
            visita.Show();
            this.Hide();
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarEdificioAulas edificio = new FrmModificarEdificioAulas();
            edificio.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario usuario = new FrmRegistroUsuario();
            usuario.Show();
            this.Hide();
        }

        private void visitasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarVisitas visitas = new FrmConsultarVisitas();
            visitas.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
