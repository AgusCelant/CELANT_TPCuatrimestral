using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AltaEsecialidad : Form
    {
        public AltaEsecialidad()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DatosEspecialidad E = new DatosEspecialidad();
            Especialidad NuevaEsepecialidad = new Especialidad();

            try
            {
                NuevaEsepecialidad.DescEspecialidad = txtNombreEspecialidad.Text;

                E.AltaEspecialidad(NuevaEsepecialidad);

                MessageBox.Show("ESPECIALIDAD AGREGADA CON EXITO.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
