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
    public partial class frmKardexVendedores : Form
    {
        
        public frmKardexVendedores()
        {
            InitializeComponent();
        }

        private void Opendata()
        {
            frmStatus frmStatusMessage = new frmStatus();
            frmStatusMessage.Show("Rerecuperando Informacion del Servidor de GACETA JURIDICA");
            try
            {
                SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                int ancho = 8;
                // Open the connection
                //                conn.Open();
                SqlCommand xSqlCommand = new SqlCommand("dbo.paKardexVendedores", xSqlConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@strIdvendedor", SqlDbType.NVarChar).Value = EjecutivoActual.id_vendedor;
                xSqlCommand.Parameters.Add("@cod_empresa", SqlDbType.NVarChar).Value = ActualUser.cod_empresa;
                xSqlCommand.Parameters.Add("@Check", SqlDbType.NVarChar).Value = ActualUser.tipo_kardex;
                xSqlCommand.Connection.Open();

                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataSet xDataSet = new DataSet();
                xSqlDataAdapter.Fill(xDataSet, "KardexVendedores");
                xSqlDataAdapter.Dispose();

                dgMaterialEntergado.DataSource = xDataSet;
                dgMaterialEntergado.DataMember = "KardexVendedores";
                dgMaterialEntergado.Refresh();
                FormatGridWithTableStyles();
                dgMaterialEntergado.Columns[0].Visible = false;
                dgMaterialEntergado.Columns[14].Visible = false;
                dgMaterialEntergado.Columns[15].Visible = false;
                dgMaterialEntergado.Columns[13].Visible = false;

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgMaterialEntergado.Columns["T_STK"];
                COL01.ReadOnly = true;
                COL01.Visible = true;
                COL01.HeaderText = "T_STK";
                COL01.Width = ancho;
                COL01.DefaultCellStyle.BackColor = Color.YellowGreen;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgMaterialEntergado.Columns["T_MOV"];
                COL02.ReadOnly = true;
                COL02.Visible = true;
                COL02.HeaderText = "T_MOV";
                COL02.Width = ancho;
                COL02.DefaultCellStyle.BackColor = Color.YellowGreen;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL02.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgMaterialEntergado.Columns["SALDOS"];
                COL03.ReadOnly = true;
                COL03.Visible = true;
                COL03.HeaderText = "SALDOS";
                COL03.Width = ancho;
                COL03.DefaultCellStyle.BackColor = Color.CadetBlue;
                COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL03.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgMaterialEntergado.Columns["STK_INI"];
                COL04.Width = ancho;
                COL04.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL04.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgMaterialEntergado.Columns["O_S"];
                COL05.Width = ancho;
                COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL05.DefaultCellStyle.Format = "#,###";
                COL05.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgMaterialEntergado.Columns["GUIAS"];
                COL06.Width = ancho;
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL06.DefaultCellStyle.Format = "#,###";
                COL06.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgMaterialEntergado.Columns["F_CAN"];
                COL07.Width = ancho;
                COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL07.DefaultCellStyle.Format = "#,###";
                COL07.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL08 = new DataGridViewColumn();
                COL08 = dgMaterialEntergado.Columns["F_PEN"];
                COL08.Width = ancho;
                COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL08.DefaultCellStyle.Format = "#,###";
                COL08.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL09 = new DataGridViewColumn();
                COL09 = dgMaterialEntergado.Columns["F_CTA"];
                COL09.Width = ancho;
                COL09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL09.DefaultCellStyle.Format = "#,###";
                COL09.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL010 = new DataGridViewColumn();
                COL010 = dgMaterialEntergado.Columns["DEVOL"];
                COL010.Width = ancho;
                COL010.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL010.DefaultCellStyle.Format = "#,###";
                COL010.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL011 = new DataGridViewColumn();
                COL011 = dgMaterialEntergado.Columns["E_SUS"];
                COL011.Width = ancho;
                COL011.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL011.DefaultCellStyle.Format = "#,###";
                COL011.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                frmStatusMessage.Close();
            }
        }
        private void FormatGridWithTableStyles()
        {
            dgMaterialEntergado.BackColor = Color.GhostWhite;
            dgMaterialEntergado.BackgroundColor = Color.Lavender;
            dgMaterialEntergado.BorderStyle = BorderStyle.None;
            dgMaterialEntergado.Font = new Font("Tahoma", (float)8.0);
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
            grdTableStyle1.MappingName = "Suscripciones";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }

        private void frmKardexVendedores_Load(object sender, EventArgs e)
        {
            Opendata();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // frmStatusMessage.Close();
        }
        private void bnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void rbSoloSaldos_CheckedChanged(object sender, EventArgs e)
        {
            Opendata();
        }
        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            Opendata();
        }
        private void dgMaterialEntergado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgMaterialEntergado.CurrentCell != null)
            {
                ClienteActual.ID_PRODUCTO = Convert.ToInt16(dgMaterialEntergado.Rows[dgMaterialEntergado.CurrentCell.RowIndex].Cells[0].Value.ToString());
                frmDetalleKardex frm_frmDetalleKardex = new frmDetalleKardex();
                frm_frmDetalleKardex.ShowDialog();
            }
        }
    }
}
