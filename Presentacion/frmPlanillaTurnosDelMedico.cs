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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmPlanillaTurnosDelMedico : Form
    {
        public frmPlanillaTurnosDelMedico()
        {
            InitializeComponent();
        }

        private void frmPlanillaTurnosDelMedico_Load(object sender, EventArgs e)
        {
            DatosTurno DT = new DatosTurno();
            string Matricula;
            Matricula = lblNombreMedico.Text.Split('-').Last();

           dgvListado.DataSource =  DT.ListarTurnosXMedico(Matricula);
           dgvListado.Columns[0].Visible = false;
           dgvListado.Columns[1].Visible = false;
           dgvListado.Columns[2].Visible = false;
           dgvListado.Columns[3].Visible = false;
           dgvListado.Columns[4].Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string Matricula;
            Matricula = lblNombreMedico.Text.Split('-').Last();

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
                WHERE P.DOCUMENTO LIKE('%" + txtFiltrar.Text + "%') AND M.NMATRICULA= " + Matricula;
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

                DataTable DT = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(comando);

                DA.Fill(DT);

                dgvListado.DataSource = DT;

                conexion.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
