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
    public partial class frmDireccion : Form
    {
        //public string calle { get; set; }
        //public int numero { get; set; }
        //public Localidades localidad { get; set; }
        //public string cp { get; set; }
        
        public frmDireccion()
        {
            InitializeComponent();
        }



        private Direccion direccion;
        

        public frmDireccion(Direccion direccion) {

            InitializeComponent();
            this.direccion = direccion;
        }

        //BOTON ACEPTAR
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            direccion.Calle = txtCalle.Text;
            direccion.Numero = int.Parse(txtNumero.Text);
            direccion.Localidad = (Localidad)cboLocalidad.SelectedItem;

            //this.calle = txtCalle.Text.Trim();
            //this.numero = int.Parse(txtNumero.Text);
            //this.localidad = new Localidades();
            //this.localidad.Descripcion = cboLocalidad.SelectedItem.ToString();
            //this.cp = localidad.CPostal;
            Close();
        }
        
        //BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //CARGA DE PANTALLA
        private void Direccion_Load(object sender, EventArgs e)
        {
            DatosLocalidad NegLocalidad = new DatosLocalidad();
            try
            {
                cboLocalidad.DataSource = NegLocalidad.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
