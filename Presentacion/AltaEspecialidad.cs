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
    public partial class AltaEspecialidad : Form
    {
        public AltaEspecialidad()
        {
            InitializeComponent();
        }

        int ID;

        public AltaEspecialidad(int ID)
        {
            InitializeComponent();
            this.ID = ID;
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

        //private void btnModificar_Click(object sender, EventArgs e)
        //{
        //    DatosEspecialidad E = new DatosEspecialidad();
        //    Especialidad ModificarEspecialidad = new Especialidad();

        //    try
        //    {
        //        ModificarEspecialidad.DescEspecialidad = txtNombreEspecialidad.Text;
        //        E.ModificarEspecialidad(ModificarEspecialidad);

        //        Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
