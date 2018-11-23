using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }
        
        private void tsbVerEspecialidades_Click(object sender, EventArgs e)
        {
            DatosEspecialidad DE = new DatosEspecialidad();

            try
            {
                dgvBuscar.DataSource = DE.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbBuscarDatosPaciente_Click(object sender, EventArgs e)
        {
            frmPlanillaPaciente planilla = new frmPlanillaPaciente();
            planilla.Show();
        }

        private void tsbBuscarMedicos_Click(object sender, EventArgs e)
        {
            frmPlanillaMedicos planilla = new frmPlanillaMedicos();
            planilla.Show();
        }

        private void tsbListarOS_Click(object sender, EventArgs e)
        {
            DatosOS OS = new DatosOS();

            try
            {

            dgvBuscar.DataSource = OS.listarOS();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}


        //HACER LOS ELIMINAR Y MODIFICAR!!!
