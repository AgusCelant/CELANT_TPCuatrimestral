using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevoTurno_Click(object sender, EventArgs e)
        {

            Nuevo_Turno turno = new Nuevo_Turno();
            //turno.MdiParent = this;            // COMO HACER QUE SE ABRA SOLO UNA VENTANA EN EL ESPACOP DEL MENU RPINCIPAL
            turno.Show();
                     
        }

        private void tsbEliminarDatos_Click(object sender, EventArgs e)
        {
            Eliminar_Turno turno = new Eliminar_Turno();

            turno.Show();
        }

        private void tsbModificarTurnos_Click(object sender, EventArgs e)
        {
            Modificat_Turno turno = new Modificat_Turno();
            turno.Show();
        }

        private void tsbBuscarTurno_Click(object sender, EventArgs e)
        {
            Buscar_Turno turno = new Buscar_Turno();

            turno.Show();
        }
    }
}
