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

            frmNuevoTurno turno = new frmNuevoTurno();
            turno.MdiParent = this;            // COMO HACER QUE SE ABRA SOLO UNA VENTANA EN EL ESPACOP DEL MENU RPINCIPAL
            turno.Show();
                     
        }

        private void tsbEliminarDatos_Click(object sender, EventArgs e)
        {
            frmEliminarTurno turno = new frmEliminarTurno();
            turno.MdiParent = this;
            turno.Show();
        }

        private void tsbModificarTurnos_Click(object sender, EventArgs e)
        {
            frmModificarTurno turno = new frmModificarTurno();
            turno.MdiParent = this;
            turno.Show();
        }

        private void tsbBuscarTurno_Click(object sender, EventArgs e)
        {
            frmListar turno = new frmListar();
            turno.MdiParent = this;
            turno.Show();
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMedico Alta = new AltaMedico();
            Alta.MdiParent = this;
            Alta.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPaciente Alta = new AltaPaciente();
            Alta.MdiParent = this;
            Alta.Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaObSocial Alta = new AltaObSocial();
            Alta.MdiParent = this;
            Alta.Show();
        }
    }
}
