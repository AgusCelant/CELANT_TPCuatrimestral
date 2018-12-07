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
    public partial class frmNuevoTurno : Form
    {
        public frmNuevoTurno()
        {
            InitializeComponent();
        }

        private void frmNuevoTurno_Load(object sender, EventArgs e)
        {
            //AutocompletarNombre();
            //AutocompletarApellido();
            AutocompletarOS();
            AutocompletarEspecialidad();
            AutocompleteMedico();

            

            CargarPlanilla();

        }

        public void AutocompletarNombre(int DNI)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
           

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NOMBRE FROM PACIENTE WHERE DOCUMENTO =" + DNI;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                //AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();

                while (lector.Read())
                {
                    txtNombre.Text = lector.GetString(0);

                    //MiColeccion.Add(lector.GetString(0));
                }
                
                //txtNombre.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AutocompletarApellido(int DNI)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT APELLIDO FROM PACIENTE WHERE DOCUMENTO=" + DNI;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                //AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();

                while (lector.Read())
                {
                    txtApellido.Text = lector.GetString(0);
                   // MiColeccion.Add(lector.GetString(0));
                }

                //txtApellido.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AutocompletarNroOS(int DNI)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NROAFILIADO FROM PACIENTE WHERE DOCUMENTO=" + DNI;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

               // AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();

                while (lector.Read())
                {
                    txtNroOS.Text = Convert.ToString((int)lector["NROAFILIADO"]);

                    //MiColeccion.Add(lector.GetString(0));
                }

               // txtNroOS.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AutocompletarOS()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<ObraSocial> lista = new List<ObraSocial>();

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NOMBRE FROM OBRASOCIAL ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();

                while (lector.Read())
                {
                    MiColeccion.Add(lector.GetString(0));
                }

               txtOBSocial.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AutocompletarEspecialidad()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Especialidad> lista = new List<Especialidad>();

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT DESCRIPCION FROM ESPECIALIDADES ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();

                while (lector.Read())
                {
                    MiColeccion.Add(lector.GetString(0));
                }

                txtEspecialidad.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void AutocompleteMedico()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Medico> lista = new List<Medico>();

            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NOMBRE, APELLIDO, NMATRICULA FROM MEDICOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                AutoCompleteStringCollection MiColeccion = new AutoCompleteStringCollection();


                while (lector.Read())
                {
                     string medico = "";

                    medico = lector.GetString(0) + " " + lector.GetString(1) + ", " + (int)lector["Nmatricula"];
                    MiColeccion.Add(medico);
                }

                txtMedico.AutoCompleteCustomSource = MiColeccion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int BuscarDNI, IDPaciente;

            DatosPaciente DP = new DatosPaciente();
            BuscarDNI = int.Parse(txtDNI.Text);
            IDPaciente = DP.BuscarIDPaciente(BuscarDNI);

            string BuscarEspecialidad;
            int IDEspecialidad;

            DatosEspecialidad DE = new DatosEspecialidad();
            BuscarEspecialidad = txtEspecialidad.Text.ToString();
            IDEspecialidad = DE.BuscarIDEspecialidad(BuscarEspecialidad);

            string BuscarOS;
            int IDOS;

            DatosOS DOS = new DatosOS();
            BuscarOS = txtOBSocial.Text.ToString();
            IDOS = DOS.BuscarIDOS(BuscarOS);

            string BuscarNroMatricula;
            int IDMedico;
            DatosMedicos DM = new DatosMedicos();
            BuscarNroMatricula = txtMedico.Text.Substring(txtMedico.Text.Length - 4);
            IDMedico = DM.BuscarIDMedico(BuscarNroMatricula);
            
            DatosTurno DT = new DatosTurno();
            Turno T = new Turno();

            T.P = new Paciente();
            T.E = new Especialidad();
            T.OS = new ObraSocial();
            T.M = new Medico();
            

            try
            {
                T.P.IdPaciente = IDPaciente;
                T.E.IdEspecialidad = IDEspecialidad;
                T.OS.IdOS = IDOS;
                T.M.IdMedico = IDMedico;
                T.FechaTurno = dtpFehaTurno.Value;
                T.Valor = int.Parse(txtValorConsulta.Text);
                DT.AltaTurno(T);

                MessageBox.Show("Turno Agregado Correctamente");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void CargarPlanilla()
        {
            DatosTurno DT = new DatosTurno();
            Turno T = new Turno();
            try
            {
                dgvListaTurnos.DataSource = DT.ListarTurnos();
                
                dgvListaTurnos.Columns[1].Visible = false;
                dgvListaTurnos.Columns[2].Visible = false;
                dgvListaTurnos.Columns[3].Visible = false;
                dgvListaTurnos.Columns[4].Visible = false;

                dgvListaTurnos.Columns[7].HeaderText = "Nombre Paciente";
                dgvListaTurnos.Columns[8].HeaderText = "Apellido Paciente";
                dgvListaTurnos.Columns[9].HeaderText = "DNI";
                dgvListaTurnos.Columns[10].HeaderText = "Nro Afiliado";
                dgvListaTurnos.Columns[11].HeaderText = "Nombre Medico";
                dgvListaTurnos.Columns[12].HeaderText = "Apellido Medico";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
         
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
        
            try
            {
                conexion.ConnectionString = @"initial catalog=CLINICA; data source=DESKTOP-2IGJU5O\SQLEXPRESS; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"SELECT T.IDTURNO, T.FECHA, P.NOMBRE, P.APELLIDO, P.DOCUMENTO, P.NROAFILIADO, M.APELLIDO AS 'A.MEDICO', M.NOMBRE AS 'N.MEDICO',
                E.DESCRIPCION AS 'ESPECIALIDAD', OS.NOMBRE AS 'OBRA SOCIAL', T.VALOR FROM TURNOS AS T
                INNER JOIN PACIENTE AS P ON T.IDPACIENTE = P.IDPACIENTE
                INNER JOIN MEDICOS AS M ON T.IDMEDICO = M.IDMEDICO
                INNER JOIN ESPECIALIDADES AS E ON E.IDESPECIALIDAD = T.IDESPECIALIDAD
                INNER JOIN OBRASOCIAL AS OS ON OS.IDOS = T.IDOBS 
                WHERE P.DOCUMENTO LIKE('%"+ txtFiltrar.Text +"%')";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(comando);

                DA.Fill(DT);

                dgvListaTurnos.DataSource = DT;

                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCompletarDatos_Click(object sender, EventArgs e)
        {
            AutocompletarNombre(int.Parse(txtDNI.Text));
            AutocompletarApellido(int.Parse(txtDNI.Text));
            AutocompletarNroOS(int.Parse(txtDNI.Text));
            
            


            
        }
    }
}
