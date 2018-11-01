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
using Dominio;

namespace Presentacion
{
    public partial class frmPlanillaPaciente : Form
    {
        public frmPlanillaPaciente()
        {
            InitializeComponent();
        }

        private void PlanillaPaciente_Load(object sender, EventArgs e)
        {
            DatosPaciente DP = new DatosPaciente();
            try
            {
                dgvPlanillaPacientes.DataSource = DP.listar();
                dgvPlanillaPacientes.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarPlanilla()
        {

            DatosPaciente DP = new DatosPaciente();
            try
            {
                dgvPlanillaPacientes.DataSource = DP.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            Paciente eliminar;
            DatosPaciente negPaciente = new DatosPaciente();

            try
            {
                eliminar = (Paciente)dgvPlanillaPacientes.CurrentRow.DataBoundItem;
                negPaciente.EliminarPaciente(eliminar.IdPaciente);
                CargarPlanilla();
                MessageBox.Show("Paciente Eliminado.");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
