using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryBasic
{
    public partial class Login : Form
    {
        //protected DataSet logindata = new DataSet();
        DataTable logindata = new DataTable();
        static string Connectionstring = Conection.conectionstring;
        public Login()
        {
            InitializeComponent();   
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            
            frmStatus frmStatusMessage = new frmStatus();
            try
            {
                String str_dominio;
                frmStatusMessage.Show("Conectando y validando información on SERVER GACETAJURIDICA");
                SqlConnection comercialConnection = new SqlConnection(Connectionstring);
                if (radioButton1.Checked == true)
                {
                    str_dominio = "@gacetajuridica.com.pe";
                }
                else
                {
                    str_dominio = "@contadoresyempresas.com.pe";
                }

                SqlDataAdapter LoginAdapter = new SqlDataAdapter(
                    "SELECT SUPERVISORES, NOMBRE, CORREO, ID_VENDEDOR, NOMBRE_VENDEDOR1, clave, cod_empresa, TIPO_USUARIO FROM ACCESO_VENDEDORES where correo = '" + txtUser.Text + str_dominio.ToString() + "' and clave = '" + txtPass.Text + "'", comercialConnection);
                LoginAdapter.Fill(logindata);
                if (logindata.Rows.Count ==1)
                {
                    ActualUser.tipo_usuario = logindata.Rows[0]["TIPO_USUARIO"].ToString();
                    if (ActualUser.tipo_usuario == "1")
                    {
                        ActualUser.usuario = logindata.Rows[0]["nombre_vendedor1"].ToString(); 
                        ActualUser.id_vendedor = "";
                        ActualUser.email = logindata.Rows[0]["correo"].ToString();
                        ActualUser.cod_empresa = logindata.Rows[0]["cod_empresa"].ToString();
                        ActualUser.Supervisor = logindata.Rows[0]["nombre_vendedor1"].ToString();

                        EjecutivoActual.id_vendedor = "";
                        EjecutivoActual.email = "";
                        EjecutivoActual.nombre = "";
                    }
                    else
                    {
                        ActualUser.Supervisor = "";
                        ActualUser.usuario = logindata.Rows[0]["nombre_vendedor1"].ToString();
                        ActualUser.id_vendedor = logindata.Rows[0]["id_vendedor"].ToString();
                        ActualUser.email = logindata.Rows[0]["correo"].ToString();
                        ActualUser.cod_empresa = logindata.Rows[0]["cod_empresa"].ToString();

                        EjecutivoActual.id_vendedor = logindata.Rows[0]["id_vendedor"].ToString();
                        EjecutivoActual.email = logindata.Rows[0]["correo"].ToString();
                        EjecutivoActual.nombre = logindata.Rows[0]["nombre_vendedor1"].ToString();
                    }
                    frmStatusMessage.Close();
                    this.Hide();
                    Principal FormPrincipal = new Principal();
                    FormPrincipal.Show();
                }
                else
                {
                    frmStatusMessage.Close();
                    MessageBox.Show("Datos incorrectos : Usuario o Clave no válidos");
                }
            }
            catch (Exception ex)
            {
                frmStatusMessage.Close();
                MessageBox.Show(Conection.error_coneccion + " :::: " + Conection.conectionstring + " :::: " + ex.Message.ToString());
                    Application.Exit();
            }
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }


        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

    }
}
