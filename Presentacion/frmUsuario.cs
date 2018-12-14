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
    public partial class frmUsuario : Form
    {
        private Usuarios Usuarios;

        public frmUsuario()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DatosUsuario DU = new DatosUsuario();
            try
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("INGRESAR USUARIO.");
                }
                if (txtPass.Text == "")
                {
                    MessageBox.Show("INGRESAR CONTRASEÑA.");
                }

                else
                {
                    Usuarios = new Usuarios();
                    Usuarios.Descripcion = txtUsuario.Text;
                    Usuarios.Pass = int.Parse(txtPass.Text);
                    if (DU.Validar(Usuarios))
                    {
                        if (Usuarios.Descripcion != "ADMIN")
                        {      string datos;
                               datos = txtUsuario.Text + " - " + int.Parse(txtPass.Text);

                            frmPlanillaTurnosDelMedico turnosDelMedico = new frmPlanillaTurnosDelMedico();
                            turnosDelMedico.lblNombreMedico.Text = datos;
                            turnosDelMedico.Show();
                        }

                        else
                        {
                            frmMenuPrincipal Menu = new frmMenuPrincipal();
                            Menu.Show();
                        }
                    }

                    else
                    {
                        MessageBox.Show("USUSARIO O CONTRASEÑA INCORRECTOS.");
                    }
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
