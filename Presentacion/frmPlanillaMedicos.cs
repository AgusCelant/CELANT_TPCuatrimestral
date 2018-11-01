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
    public partial class frmPlanillaMedicos : Form
    {
        public frmPlanillaMedicos()
        {
            InitializeComponent();
        }

        private void PlanillaMedicos_Load(object sender, EventArgs e)
        {
            DatosMedicos DM = new DatosMedicos();

            try
            {
                dgvPlanillaMedicos.DataSource = DM.ListarMedicos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarPlanilla()
        {

            DatosMedicos DM = new DatosMedicos();
            try
            {
            dgvPlanillaMedicos.DataSource = DM.ListarMedicos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            Medico eliminar;
            DatosMedicos negMedico = new DatosMedicos();

            try
            {
                eliminar = (Medico)dgvPlanillaMedicos.CurrentRow.DataBoundItem;
                negMedico.EliminarMedico(eliminar.IdMedico);
                CargarPlanilla();
                MessageBox.Show("Profesional Eliminado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {  //ARREGLAR LA MODIFICACION!!!
            Medico Modificar;
            try
            {
            Modificar = (Medico)dgvPlanillaMedicos.CurrentRow.DataBoundItem;
            AltaMedico Modi = new AltaMedico(Modificar);
            Modi.ShowDialog();
            CargarPlanilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
