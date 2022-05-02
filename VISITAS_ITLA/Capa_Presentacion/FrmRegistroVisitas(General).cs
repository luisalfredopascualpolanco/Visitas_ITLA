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
using System.IO;

namespace Capa_Presentacion
{
    public partial class FrmRegistroVisitas_General_ : Form
    {
        public FrmRegistroVisitas_General_()
        {
            InitializeComponent();
        }
        N_Visitas objNvisitas = new N_Visitas();
        E_Visitas objEvisitas = new E_Visitas();
        N_Edificios objNedificios = new N_Edificios();
        E_Edificios objEedificios = new E_Edificios();
        N_Secciones objNsecciones = new N_Secciones();
        string ruta;

        private void visitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistroVisitas_General_ visita = new FrmRegistroVisitas_General_();
            visita.Show();
            this.Hide();
        }

        private void visitasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarVisita_General_ visita = new FrmConsultarVisita_General_();
            visita.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void FrmRegistroVisitas_General__Load(object sender, EventArgs e)
        {
            objNedificios.LlenandoCombobox(cmbEdificio);
        }

        private void cmbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();
            int buscar = int.Parse(cmbEdificio.Text);
            objNsecciones.llenandoComboboxSeccionesporEdificios(cmbDestino, buscar);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
                else if (cmbEdificio.Text is null)
                {
                    MessageBox.Show("Debes de llenar el campo Edificio");
                }
                else if (txtMotivoVisita.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Motivo de Visita");
                }
                else if (cmbDestino.Text is null)
                {
                    MessageBox.Show("Debes de llenar el campo Destino");
                }
                else
                {
                    FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(stream);
                    FileInfo fi = new FileInfo(ruta);


                    byte[] binData = new byte[stream.Length];

                    stream.Read(binData, 0, Convert.ToInt32(stream.Length));


                    ptbfoto.Image = Image.FromStream(stream);
                    objEvisitas.Nombres = txtNombres.Text.ToString().ToUpper();
                    objEvisitas.Apellidos = txtApellidos.Text.ToString().ToUpper();
                    objEvisitas.Carrera = txtCarrera.Text.ToString().ToUpper();
                    objEvisitas.Correo = txtCorreo.Text.ToString().ToUpper();
                    objEvisitas.Edificio = int.Parse(cmbEdificio.Text);
                    objEvisitas.FechaYHoraEntrada = dtpFechaEntrada.Value;
                    objEvisitas.FechaYHoraSalida = dtpFechaSalida.Value;
                    objEvisitas.MotivoVisita = txtMotivoVisita.Text.ToString().ToUpper();
                    objEvisitas.Destino = cmbDestino.Text.ToString().ToUpper();
                    objEvisitas.Foto = binData;
                    objNvisitas.InsertandoVisitas(objEvisitas);
                    MessageBox.Show("Visita agregado");
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtCarrera.Text = "";
                    txtCorreo.Text = "";
                    cmbEdificio.Text = "";
                    txtMotivoVisita.Text = "";
                    cmbDestino.Text = "";
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo agregar la visita");
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog examinar = new OpenFileDialog();
            examinar.Filter = "image files|*.jpg;*.png;*.gif;*.ico;.*;";
            DialogResult dres1 = examinar.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            ruta = examinar.FileName;
            ptbfoto.Image = Image.FromFile(examinar.FileName);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
