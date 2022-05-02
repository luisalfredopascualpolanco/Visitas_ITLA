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
    public partial class FrmConsultarVisitas : Form
    {
        public FrmConsultarVisitas()
        {
            InitializeComponent();
        }
        N_Edificios objdato = new N_Edificios();
        N_Visitas objvisita = new N_Visitas();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultarVisitas_Load(object sender, EventArgs e)
        {
            objdato.LlenandoCombobox(cmbEdificio);
        }

        private void btnBuscarVisita_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objvisita.ListarVisita(cmbEdificio.Text);
        }

        private void cmbEdificio_SelectedIndexChanged(object sender, EventArgs e)
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
