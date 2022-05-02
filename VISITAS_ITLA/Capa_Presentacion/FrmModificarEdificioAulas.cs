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
    public partial class FrmModificarEdificioAulas : Form
    {
        public FrmModificarEdificioAulas()
        {
            InitializeComponent();
        }

        N_Secciones objSeccion = new N_Secciones();
        N_Edificios objEdificio = new N_Edificios();
        E_Edificios objEEdificio = new E_Edificios();
        E_Secciones objESecciones = new E_Secciones();
        private void FrmModificarEdificioAulas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar() 
        {
            cmbDepartamento.Items.Clear();
            cmbNumeroEdificio.Items.Clear();
            objEdificio.LlenandoCombobox(cmbNumeroEdificio);
            objSeccion.LlenandoCombobox(cmbDepartamento);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarEdificio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNumeroEdificio.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo # de edificio");
                }
                else if (cmbDepartamento.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Departamento");
                }
                else
                {
                    objEEdificio.NumeroEdificio = int.Parse(cmbNumeroEdificio.Text.ToUpper());
                    objESecciones.Nombre = cmbDepartamento.Text.ToString().ToUpper();
                    objEdificio.InsertandoEdificio(objEEdificio, objESecciones);
                    MessageBox.Show("Edificio Agregado");
                    Actualizar();
                    cmbDepartamento.Text = "";
                    cmbNumeroEdificio.Text = "";
                    txtDepartamentoNuevo.Text = "";
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el edificio. VERIFIQUE QUE EL EDIFICIO Y EL DEPARTAMENTO NO EXISTAN");
            }
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNumeroEdificio.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo # de edificio");
                }
                else if (cmbDepartamento.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Departamento");
                }
                else 
                {
                    objESecciones.NumeroEdifico = int.Parse(cmbNumeroEdificio.Text.ToUpper());
                    objESecciones.Nombre = cmbDepartamento.Text.ToString().ToUpper();
                    objSeccion.InsertandoSeccion(objESecciones);
                    MessageBox.Show("Seccion Agregada");
                    Actualizar();
                    cmbDepartamento.Text = "";
                    cmbNumeroEdificio.Text = "";
                    txtDepartamentoNuevo.Text = "";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el departamento. VERIFIQUE QUE EL EDIFICIO YA EXISTE Y QUE EL DEPARTAMENTO NO EXISTA");               
            }
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNumeroEdificio.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo # de edificio");
                }
                else if (cmbDepartamento.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Departamento");
                }
                else if (txtDepartamentoNuevo.Text == "")
                {
                    MessageBox.Show("Debes de llenar el campo Departamento(Nuevo)");
                }
                else 
                {
                    objEEdificio.NumeroEdificio = int.Parse(cmbNumeroEdificio.Text);
                    objESecciones.Nombre = cmbDepartamento.Text.ToUpper();
                    objESecciones.NombreNuevo = txtDepartamentoNuevo.Text.ToUpper();
                    objEdificio.ModificandoEdificio(objEEdificio, objESecciones);
                    Actualizar();
                    cmbDepartamento.Text = "";
                    cmbNumeroEdificio.Text = "";
                    txtDepartamentoNuevo.Text = "";
                    MessageBox.Show("Edificio Actualizado");
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo modificar el edificio. VERIFIQUE QUE EL EDIFICIO Y LA SECCION EXISTAN");               
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
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
