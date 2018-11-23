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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class AltaPaciente : Form
    {
        public AltaPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Direccion direccionAux { get; set; }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            Paciente P = new Paciente();
            try
            {
                if (P.direccion == null)
                {
                    P.direccion = new Dominio.Direccion();
                }

                frmDireccion ventanaDrieccion = new frmDireccion(P.direccion);
                ventanaDrieccion.ShowDialog();
                txtDireccionPaciente.Text = P.direccion.ToString();
                direccionAux = P.direccion;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            DatosPaciente Pac = new DatosPaciente();
            Paciente nuevo = new Paciente();
            nuevo.direccion = new Dominio.Direccion();
            nuevo.OS = new ObraSocial();


            //PASO EL ID DE LA OS DE LA COMBOBOX A UNA VARIABLE TIPO INT 
            int id = Convert.ToInt32(cboOS.SelectedValue.ToString());
           

            try
            {

                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.DNI = int.Parse(txtDNI.Text);
                nuevo.Fnac = dtpPaciente.Value;
                nuevo.Nafiliado = int.Parse(txtNumeroOS.Text);
                nuevo.direccion = direccionAux;

                nuevo.OS.OS = cboOS.Text;
                nuevo.OS.IdOS = id;

                Pac.AltaPaciente(nuevo);
                Close();

                MessageBox.Show("Paciente Cargado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaPaciente_Load(object sender, EventArgs e)
        {
            DatosOS OS= new DatosOS();
            cboOS.DataSource = OS.listarOS();
            cboOS.ValueMember = "IdOS";
            cboOS.DisplayMember = "OS";
        }

       
    }
}
