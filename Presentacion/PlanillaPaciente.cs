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
    public partial class PlanillaPaciente : Form
    {
        public PlanillaPaciente()
        {
            InitializeComponent();
        }

        private void PlanillaPaciente_Load(object sender, EventArgs e)
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
    }
}
