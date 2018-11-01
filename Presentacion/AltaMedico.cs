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
    public partial class AltaMedico : Form
    {
        private Medico med = null;

        public AltaMedico()
        {
            InitializeComponent();
        }

        public AltaMedico(Medico modi)
        {
            InitializeComponent();
            med = modi;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            DatosMedicos medicosService = new DatosMedicos();
            Medico nuevoMedico = new Medico();
            try
            {
                nuevoMedico.Nombre = txtNombreMedico.Text;
                nuevoMedico.Apellido = txtApelidoMedico.Text;
                nuevoMedico.Edad = int.Parse(txtEdadMedico.Text);
                nuevoMedico.Fnac = dtpNacimientoMedico.Value;
                nuevoMedico.Nmatricula = int.Parse(txtMatriculaMedico.Text);
                nuevoMedico.Especialidades = new List<Especialidad>();

                foreach (var item in lstbCargaEspecialidades.Items)
                {
                    nuevoMedico.Especialidades.Add((Especialidad)item);
                }

                medicosService.AltaMedico(nuevoMedico);

                Close();

                MessageBox.Show("Profesional Cargado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaMedico_Load(object sender, EventArgs e)
        {
            DatosOS DOS = new DatosOS();
            lstbxOS.DataSource = DOS.listarOS();
            lstbxOS.ValueMember = "IdOS";
            lstbxOS.DisplayMember = "OS";

            DatosEspecialidad Especialidad = new DatosEspecialidad();
            lstbxEspecialidades.DataSource = Especialidad.listar();
            lstbxEspecialidades.ValueMember = "IdEspecialidad";
            lstbxEspecialidades.DisplayMember = "DescEspecialidad";


            try
            {
                if (med != null)
                {
                    txtNombreMedico.Text = med.Nombre;
                    txtApelidoMedico.Text = med.Apellido;
                    txtEdadMedico.Text = med.Edad.ToString();
                    dtpNacimientoMedico.Text = med.Fnac.ToString();
                    txtMatriculaMedico.Text = med.Nmatricula.ToString();
                    // med.especialidad.DescEspecialidad = cboEspecialidades.SelectedItem.ToString();
                    //med.OS.Nombre = cboOS.SelectedItem.ToString(); 
                    Text = "Modificacion de Datos";
                }
                else
                {
                    med = new Medico();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPasarEspecialidades_Click(object sender, EventArgs e)
        {
            lstbCargaEspecialidades.ValueMember = lstbxEspecialidades.ValueMember;
            lstbCargaEspecialidades.DisplayMember = lstbxEspecialidades.DisplayMember;

            if (lstbCargaEspecialidades.Items.Contains(lstbxEspecialidades.SelectedItem) == true)
            {
                MessageBox.Show("YA ESTA CARGADA ESA ESPECIALIDAD, SELECCIONE OTRA.");
                return;
            }

            if (lstbxEspecialidades.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HAY ESPECIALIDADES SELECCIONADAS, SELECCIONE AL MENOS UNA ESPECIALIDAD PARA CARGAR EN LA LISTA.");
            }

            else
            {
                lstbCargaEspecialidades.Items.Add(lstbxEspecialidades.SelectedItem);
            }
        }

        private void btnPasarOS_Click(object sender, EventArgs e)
        {
            lstbCargaOS.ValueMember = lstbxOS.ValueMember;
            lstbCargaOS.DisplayMember = lstbxOS.DisplayMember;

            if (lstbCargaOS.Items.Contains(lstbxOS.SelectedItem) == true)
            {
                MessageBox.Show("YA ESTA CARGADA ESA OBRA SOCIAL, SELECCIONE OTRA.");
                return;
            }

            if (lstbxOS.SelectedItems.Count == 0)
            {
                MessageBox.Show("NO HAY OBRAS SOCIALES SELECCIONADAS, SELECCIONE AL MENOS UNA OBRA SOCIAL PARA CARGAR EN LA LISTA.");
            }

            else
            {
                lstbCargaOS.Items.Add(lstbxOS.SelectedItem);
            }
        }
    }
}