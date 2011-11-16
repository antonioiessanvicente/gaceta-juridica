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
    public partial class frmDetalleKardex : Form
    {
        public frmDetalleKardex()
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
                int ancho = 6;
                // Open the connection
                SqlCommand xSqlCommand = new SqlCommand("dbo.paKardexVendedoresDetalle2010", xSqlConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@strIdvendedor", SqlDbType.NVarChar).Value = EjecutivoActual.id_vendedor;
                xSqlCommand.Parameters.Add("@cod_empresa", SqlDbType.NVarChar).Value = ActualUser.cod_empresa;
                xSqlCommand.Parameters.Add("@id_producto ", SqlDbType.Int).Value = ClienteActual.ID_PRODUCTO;
                xSqlCommand.Connection.Open();
                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataSet xDataSet = new DataSet();
                xSqlDataAdapter.Fill(xDataSet, "DetalleKardex");
                xSqlDataAdapter.Dispose();

                dgKardexDetalle.DataSource = xDataSet;
                dgKardexDetalle.DataMember = "DetalleKardex";
                dgKardexDetalle.Refresh();
                FormatGridWithTableStyles();
                dgKardexDetalle.Columns[11].Visible = false;

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgKardexDetalle.Columns["FECHA_EMISION"];
                COL04.Width = ancho;
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL04.DefaultCellStyle.Format = "dd-MMM-yy";

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgKardexDetalle.Columns["O_S"];
                COL05.Width = ancho;
                COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL05.DefaultCellStyle.Format = "#,###";
                COL05.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgKardexDetalle.Columns["GUIAS"];
                COL06.Width = ancho;
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL06.DefaultCellStyle.Format = "#,###";
                COL06.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgKardexDetalle.Columns["F_CAN"];
                COL07.Width = ancho;
                COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL07.DefaultCellStyle.Format = "#,###";
                COL07.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL08 = new DataGridViewColumn();
                COL08 = dgKardexDetalle.Columns["F_PEN"];
                COL08.Width = ancho;
                COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL08.DefaultCellStyle.Format = "#,###";
                COL08.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL09 = new DataGridViewColumn();
                COL09 = dgKardexDetalle.Columns["F_CTA"];
                COL09.Width = ancho;
                COL09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL09.DefaultCellStyle.Format = "#,###";
                COL09.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL010 = new DataGridViewColumn();
                COL010 = dgKardexDetalle.Columns["DEVOL"];
                COL010.Width = ancho;
                COL010.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL010.DefaultCellStyle.Format = "#,###";
                COL010.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL011 = new DataGridViewColumn();
                COL011 = dgKardexDetalle.Columns["E_SUS"];
                COL011.Width = ancho;
                COL011.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL011.DefaultCellStyle.Format = "#,###";
                COL011.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

                DataGridViewColumn COL12 = new DataGridViewColumn();
                COL12 = dgKardexDetalle.Columns["T_STK"];
                COL12.Width = 3;
                COL12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL12.DefaultCellStyle.Format = "#,###";
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
            dgKardexDetalle.BackColor = Color.GhostWhite;
            dgKardexDetalle.BackgroundColor = Color.Lavender;
            dgKardexDetalle.BorderStyle = BorderStyle.None;
            dgKardexDetalle.Font = new Font("Tahoma", (float)8.0);
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
            grdTableStyle1.PreferredColumnWidth = 10;
            grdTableStyle1.PreferredRowHeight = 15;
            
        }
        private void frmDetalleKardex_Load(object sender, EventArgs e)
        {
            Opendata();
        }
        private void bnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgMaterialEntergado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgKardexDetalle.CurrentCell != null)
            {
                ClienteActual.clave_doc = dgKardexDetalle.Rows[dgKardexDetalle.CurrentCell.RowIndex].Cells[11].Value.ToString();
                frmDetalleDoc frm_Detalle_Doc = new frmDetalleDoc();
                frm_Detalle_Doc.ShowDialog();
            }
        }
    }
}
