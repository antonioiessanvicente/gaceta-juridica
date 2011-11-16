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
    public partial class frmSuscripciones : Form
    {
        protected DataSet ClientesSuscripciones = new DataSet();
        public frmSuscripciones()
        {
            InitializeComponent();
        }
        private void FormatGridWithTableStyles()
        {
            dgSuscripciones.BackColor = Color.GhostWhite;
            dgSuscripciones.BackgroundColor = Color.Lavender;
            dgSuscripciones.BorderStyle = BorderStyle.None;
            dgSuscripciones.Font = new Font("Tahoma", (float)8.0);
            DataGridTableStyle grdTableStyle1 = new DataGridTableStyle();
            grdTableStyle1.AlternatingBackColor = Color.GhostWhite;
            grdTableStyle1.BackColor = Color.GhostWhite;
            grdTableStyle1.ForeColor = Color.MidnightBlue;
            grdTableStyle1.GridLineColor = Color.RoyalBlue;
            grdTableStyle1.HeaderBackColor = Color.MidnightBlue;
            grdTableStyle1.HeaderFont = new Font("Tahoma", (float)9.0, FontStyle.Bold);
            grdTableStyle1.HeaderForeColor = Color.Lavender;
            grdTableStyle1.SelectionBackColor = Color.Teal;
            grdTableStyle1.SelectionForeColor = Color.PaleGreen;
            grdTableStyle1.MappingName = "Suscripciones";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }
        private void frmSuscripciones_Load(object sender, EventArgs e)
        {
            //ClienteActual.Id_cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //ClienteActual.Nombre_cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //[]
            try
            {
                SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                // Open the connection
//                conn.Open();
                SqlCommand xSqlCommand = new SqlCommand("dbo.paGetSuscripClientes", xSqlConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@ID_CLIENTE", SqlDbType.NVarChar).Value = ClienteActual.Id_cliente;
                xSqlCommand.Parameters.Add("@COD_EMPRESA", SqlDbType.NVarChar).Value = ActualUser.cod_empresa;
                xSqlCommand.Connection.Open();

                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataSet xDataSet = new DataSet();
                xSqlDataAdapter.Fill(xDataSet,"Suscripciones");
                xSqlDataAdapter.Dispose();

                dgSuscripciones.DataSource = xDataSet;
                dgSuscripciones.DataMember = "Suscripciones";
                dgSuscripciones.Refresh();
                //FormatGridWithTableStyles();
                dgSuscripciones.Columns[0].Visible = false;
                dgSuscripciones.Columns[6].Visible = false;
                dgSuscripciones.Columns[7].Visible = false;
                dgSuscripciones.Columns[8].Visible = false;
                dgSuscripciones.Columns[10].Visible = false;
                dgSuscripciones.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgSuscripciones.CurrentCell != null)
            {
                ClienteActual.Id_Suscripcion = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[10].Value.ToString());
                ClienteActual.cantidad = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[3].Value.ToString());
                ClienteActual.nro_contrato = dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[4].Value.ToString();
                ClienteActual.Nombre_Suscripcion = dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (ClienteActual.Id_Suscripcion != 0)
                {
                    EstadosCuenta frm_EstadosCuenta = new EstadosCuenta();
                    frm_EstadosCuenta.ShowDialog();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dgSuscripciones.CurrentCell != null)
            {
                ClienteActual.Id_Suscripcion = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[10].Value.ToString());
                ClienteActual.cantidad = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[3].Value.ToString());
                ClienteActual.nro_contrato = dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[4].Value.ToString();
                if (ClienteActual.Id_Suscripcion != 0)
                {
                    frm_MaterialEntregado frmMaterialEntregado = new frm_MaterialEntregado();
                    frmMaterialEntregado.ShowDialog();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgSuscripciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgSuscripciones.CurrentCell != null)
            {
                ClienteActual.Id_Suscripcion = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[10].Value.ToString());
                ClienteActual.cantidad = System.Convert.ToInt32(dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[3].Value.ToString());
                ClienteActual.nro_contrato = dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[4].Value.ToString();
                ClienteActual.Nombre_Suscripcion = dgSuscripciones.Rows[dgSuscripciones.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (ClienteActual.Id_Suscripcion != 0)
                {
                    EstadosCuenta frm_EstadosCuenta = new EstadosCuenta();
                    frm_EstadosCuenta.ShowDialog();
                }
            }
        }

        private void dgSuscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
