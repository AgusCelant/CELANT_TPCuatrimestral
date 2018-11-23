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
    public partial class AltaObSocial : Form
    {
        public AltaObSocial()
        {
            InitializeComponent();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DatosOS OS = new DatosOS();
            ObraSocial nuevo = new ObraSocial();
            try
            {
                nuevo.OS = txtNombre.Text;
                nuevo.Telefono = int.Parse(txtTelefonoOS.Text);
                nuevo.Mail = txtCorreoOS.Text;

                OS.AltaOS(nuevo);
                Close();

                MessageBox.Show("OBRA SOCIAL AGREGADA CON EXITO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //ARREGLAR LA MODIFICACION 
        //private void AltaObSocial_Load(object sender, EventArgs e)
        //{
        //    DatosOS OS = new DatosOS();

        //    try
        //    {
        //        if (obs != null)
        //        {
        //            txtNombre.Text = obs.OS;
        //            txtTelefonoOS.Text = obs.Telefono.ToString();
        //            txtCorreoOS.Text = obs.Mail;
        //            Text = "Modificacion de Datos De la Obra Social";
        //        }
        //        else {
        //            obs = new ObraSocial();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.ToString());
        //    }
        //}
    }
}
