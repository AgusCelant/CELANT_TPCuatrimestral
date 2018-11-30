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
                nuevoMedico.OS = new List<ObraSocial>();
                nuevoMedico.Dia = new List<Dia>();

                foreach (var item in lstbCargaEspecialidades.Items)
                {
                    nuevoMedico.Especialidades.Add((Especialidad)item);
                }

                foreach (var item in lstbCargaOS.Items)
                {
                    nuevoMedico.OS.Add((ObraSocial)item);
                }
                
                //ARREGLAR LOS DIAS Y HORARIOS, PORQUE MUESTRA TODOS?
                foreach (var item in lstbxDias.Items)
                {
                    nuevoMedico.Dia.Add((Dia)item);
                }

                medicosService.AltaMedico(ref nuevoMedico);
 
                DatosHorasXDias DH = new DatosHorasXDias();

                foreach (var item in lstbCargaHorasDias.Items)
                {
                    DH.AltaHorasXDias((TurnoHorario)item,nuevoMedico);
                }
               
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

            DatosDias DD = new DatosDias();
            try
            {
                lstbxDias.DataSource = DD.listar();
                lstbxDias.ValueMember = "IdDay";
                lstbxDias.DisplayMember = "Day";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


            // reemplazar esta NEGRADA con un select * from horasinit/horasend

            lstbxHoraEnntrada.Items.Add(0);
            lstbxHoraEnntrada.Items.Add(1);
            lstbxHoraEnntrada.Items.Add(2);
            lstbxHoraEnntrada.Items.Add(3);
            lstbxHoraEnntrada.Items.Add(4);
            lstbxHoraEnntrada.Items.Add(5);
            lstbxHoraEnntrada.Items.Add(6);
            lstbxHoraEnntrada.Items.Add(7);
            lstbxHoraEnntrada.Items.Add(8);
            lstbxHoraEnntrada.Items.Add(9);
            lstbxHoraEnntrada.Items.Add(10);
            lstbxHoraEnntrada.Items.Add(11);
            lstbxHoraEnntrada.Items.Add(12);
            lstbxHoraEnntrada.Items.Add(13);
            lstbxHoraEnntrada.Items.Add(14);
            lstbxHoraEnntrada.Items.Add(15);
            lstbxHoraEnntrada.Items.Add(16);
            lstbxHoraEnntrada.Items.Add(17);
            lstbxHoraEnntrada.Items.Add(18);
            lstbxHoraEnntrada.Items.Add(19);
            lstbxHoraEnntrada.Items.Add(20);
            lstbxHoraEnntrada.Items.Add(21);
            lstbxHoraEnntrada.Items.Add(22);
            lstbxHoraEnntrada.Items.Add(23);

            lstbxHoraSalida.Items.Add(0);
            lstbxHoraSalida.Items.Add(1);
            lstbxHoraSalida.Items.Add(2);
            lstbxHoraSalida.Items.Add(3);
            lstbxHoraSalida.Items.Add(4);
            lstbxHoraSalida.Items.Add(5);
            lstbxHoraSalida.Items.Add(6);
            lstbxHoraSalida.Items.Add(7);
            lstbxHoraSalida.Items.Add(8);
            lstbxHoraSalida.Items.Add(9);
            lstbxHoraSalida.Items.Add(10);
            lstbxHoraSalida.Items.Add(11);
            lstbxHoraSalida.Items.Add(12);
            lstbxHoraSalida.Items.Add(13);
            lstbxHoraSalida.Items.Add(14);
            lstbxHoraSalida.Items.Add(15);
            lstbxHoraSalida.Items.Add(16);
            lstbxHoraSalida.Items.Add(17);
            lstbxHoraSalida.Items.Add(18);
            lstbxHoraSalida.Items.Add(19);
            lstbxHoraSalida.Items.Add(20);
            lstbxHoraSalida.Items.Add(21);
            lstbxHoraSalida.Items.Add(22);
            lstbxHoraSalida.Items.Add(23);
            
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

        private void btnCargarHorariosDias_Click(object sender, EventArgs e)
        {
            TurnoHorario TH = new TurnoHorario();

            TH.Horainit = (int)lstbxHoraEnntrada.SelectedItem;
            TH.HoraFin = (int)lstbxHoraSalida.SelectedItem;
            TH.IdDia = ((Dia)lstbxDias.SelectedItem).IdDay;

            lstbCargaHorasDias.Items.Add(TH);
        }
    }
}