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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void CargarPlanillaEspecialidad()
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

        private void CargarPlanillaOS()
        {

           DatosOS DOS = new DatosOS();
            try
            {
                dgvBuscar.DataSource = DOS.listarOS();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.Columns[0].HeaderText == "IdEspecialidad")
            {
                Especialidad eliminar;
                DatosEspecialidad negEspecialidad = new DatosEspecialidad();

                try
                {
                    eliminar = (Especialidad)dgvBuscar.CurrentRow.DataBoundItem;
                    negEspecialidad.EliminarEspecialidad(eliminar.IdEspecialidad);

                    CargarPlanillaEspecialidad();
                    MessageBox.Show("ESPECIALIDAD ELIMINADA CON EXITO.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (dgvBuscar.Columns[0].HeaderText == "IdOS")
            {
                ObraSocial eliminar;
                DatosOS negObraSocial = new DatosOS();
                try
                {
                    eliminar = (ObraSocial)dgvBuscar.CurrentRow.DataBoundItem;
                    negObraSocial.EliminarOS(eliminar.IdOS);

                    CargarPlanillaOS();
                    MessageBox.Show("OBRA SOCIAL ELIMINADA CON EXITO.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        //int ID;
        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    if (dgvBuscar.Columns[0].HeaderText == "IdEspecialidad")
        //    {
        //        Especialidad Modificar;
        //        AltaEspecialidad modificarEspecilaidad = new AltaEspecialidad(ID);

        //        try
        //        {
        //            Modificar = (Especialidad)dgvBuscar.CurrentRow.DataBoundItem;
        //            modificarEspecilaidad.Show();

                    
                    
        //            CargarPlanillaEspecialidad();
        //            MessageBox.Show("ESPECIALIDAD MODIFICADA CON EXITO");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }
        //    }
        //}
    }
}
         //HACER LOS  MODIFICAR!!!
