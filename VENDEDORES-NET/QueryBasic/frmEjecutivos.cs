using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueryBasic
{
    public partial class frmEjecutivos : Form
    {
        protected DataSet EjecutivosData = new DataSet();
        protected BorderStyle DefaultGridBorderStyle;

        public frmEjecutivos()
        {
            InitializeComponent();
        }

        private void frmEjecutivos_Load(object sender, EventArgs e)
        {
            Opendata();
        }
        private void Opendata()
        {
            try
            {
                SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                // Open the connection
                //                conn.Open();
                SqlCommand xSqlCommand = new SqlCommand("dbo.paGetEjecutivos", xSqlConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@COD_EMPRESA", SqlDbType.NVarChar).Value = ActualUser.cod_empresa;
                xSqlCommand.Connection.Open();

                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataSet xDataSet = new DataSet();
                xSqlDataAdapter.Fill(xDataSet, "ejecutivos");
                xSqlDataAdapter.Dispose();

                dgEjecutivos.DataSource = xDataSet;
                dgEjecutivos.DataMember = "ejecutivos";
                dgEjecutivos.Refresh();
                FormatGridWithTableStyles();
                dgEjecutivos.Columns[3].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormatGridWithTableStyles()
        {
            dgEjecutivos.BackColor = Color.GhostWhite;
            dgEjecutivos.BackgroundColor = Color.Lavender;
            dgEjecutivos.BorderStyle = BorderStyle.None;
            dgEjecutivos.Font = new Font("Tahoma", (float)8.0);
            DataGridTableStyle grdTableStyle1 = new DataGridTableStyle();
            grdTableStyle1.AlternatingBackColor = Color.GhostWhite;
            grdTableStyle1.BackColor = Color.GhostWhite;
            grdTableStyle1.ForeColor = Color.MidnightBlue;
            grdTableStyle1.GridLineColor = Color.RoyalBlue;
            grdTableStyle1.HeaderBackColor = Color.MidnightBlue;
            grdTableStyle1.HeaderFont = new Font("Tahoma", (float)8.0, FontStyle.Bold);
            grdTableStyle1.HeaderForeColor = Color.Lavender;
            grdTableStyle1.SelectionBackColor = Color.Teal;
            grdTableStyle1.SelectionForeColor = Color.PaleGreen;
            grdTableStyle1.MappingName = "ejecutivos";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }

        private void dgEjecutivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgEjecutivos.CurrentCell != null)
            {
                EjecutivoActual.clave = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                EjecutivoActual.nombre = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                EjecutivoActual.email = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                frmEmails frm_frmEmails = new frmEmails();
                frm_frmEmails.ShowDialog();
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cmdEnvioPassword_Click(object sender, EventArgs e)
        {
            if (dgEjecutivos.CurrentCell != null)
            {
                EjecutivoActual.clave = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                EjecutivoActual.nombre = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                EjecutivoActual.email = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                frmEmails frm_frmEmails = new frmEmails();
                frm_frmEmails.ShowDialog();
            }
        }

        private void cmdSelected_Click(object sender, EventArgs e)
        {
            if (dgEjecutivos.CurrentCell != null)
            {
                EjecutivoActual.clave = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                EjecutivoActual.nombre = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                EjecutivoActual.email = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                EjecutivoActual.id_vendedor = dgEjecutivos.Rows[dgEjecutivos.CurrentCell.RowIndex].Cells[2].Value.ToString();
                this.Dispose();
            }
        }

    }
}
