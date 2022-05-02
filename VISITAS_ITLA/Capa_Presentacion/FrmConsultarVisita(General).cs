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
    public partial class FrmConsultarVisita_General_ : Form
    {
        public FrmConsultarVisita_General_()
        {
            InitializeComponent();
        }
        N_Edificios objdato = new N_Edificios();
        N_Visitas objvisita = new N_Visitas();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistroVisitas_General_ visita = new FrmRegistroVisitas_General_();
            visita.Show();
            this.Hide();
        }

        private void edificiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void visitasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarVisita_General_ visita = new FrmConsultarVisita_General_();
            visita.Show();
            this.Hide();
        }

        private void btnBuscarVisita_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objvisita.ListarVisita(cmbEdificio.Text);
        }

        private void FrmConsultarVisita_General__Load(object sender, EventArgs e)
        {
            objdato.LlenandoCombobox(cmbEdificio);
        }
    }
}
