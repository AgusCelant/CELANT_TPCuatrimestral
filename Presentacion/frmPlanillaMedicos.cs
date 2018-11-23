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

        private void btnVerEspecialidades_Click(object sender, EventArgs e)
        {
            DatosEspecialidad DE = new DatosEspecialidad();
            int ID;
            try
            {
                ID = (int)dgvPlanillaMedicos.CurrentCell.Value;
                
                dgvVerEspecialidades.DataSource = DE.ListarXmedico(ID);
                dgvVerEspecialidades.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                MessageBox.Show("SELECCIONAR SOLO ID");
            }
        }

        private void btnVerOS_Click(object sender, EventArgs e)
        {
            DatosOS DOS = new DatosOS();
            int ID;
            try
            {
                ID = (int)dgvPlanillaMedicos.CurrentCell.Value;
                dgvVerOS.DataSource = DOS.ListarXmedico(ID);
                dgvVerOS.Columns[0].Visible = false;
                dgvVerOS.Columns[2].Visible = false;
                dgvVerOS.Columns[3].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDias_Click(object sender, EventArgs e)
        {
            DatosDias DD = new DatosDias();
            int ID;
            try
            {
                ID = (int)dgvPlanillaMedicos.CurrentCell.Value;
                dgvDias.DataSource = DD.ListarXMedico(ID);
                dgvDias.Columns[0].HeaderText = "ID";
                dgvDias.Columns[1].HeaderText = "Dia";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            DatosHorasXDias HD = new DatosHorasXDias();
            int IDM, IDD;
            try
            {
                IDM = (int)dgvPlanillaMedicos.CurrentCell.Value;
                IDD = (int)dgvDias.CurrentCell.Value;
                dgvHoras.DataSource = HD.ListarXHoraXdiaXmed(IDM, IDD);

                dgvHoras.Columns[0].HeaderText = "Hora Inicio";
                dgvHoras.Columns[1].HeaderText = "Hora Fin";

                dgvHoras.Columns[2].Visible = false;
                dgvHoras.Columns[3].Visible = false;
                dgvHoras.Columns[4].Visible = false;
                dgvHoras.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
