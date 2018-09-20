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

            DatosPaciente DP = new DatosPaciente();

            try
            {
                dgvBuscarTurno.DataSource = DP.listar();
    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
