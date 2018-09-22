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
    public partial class Buscar_Turno : Form
    {
        public Buscar_Turno()
        {
            InitializeComponent();
        }

        private void Buscar_Turno_Load(object sender, EventArgs e)
        {
            //Buscar_Turno BT = new Buscar_Turno();         --> PREGUNTAR COMO SE HACE PARA QUE LA VENTANA QUEDE DENTRO DEL DGV
            //BT.MdiParent = this;
            //BT.Show();

        }

        private void tsbBusquedaTurno_Click(object sender, EventArgs e)
        {
            DatosEspecialidad DE = new DatosEspecialidad();

            try
            {
                dgvBuscarTurno.DataSource = DE.listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbBuscarDatosPaciente_Click(object sender, EventArgs e)
        {
            PlanillaPaciente planilla = new PlanillaPaciente();
            planilla.Show();
        }
    }
}
