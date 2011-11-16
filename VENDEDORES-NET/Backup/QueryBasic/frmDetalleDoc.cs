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
    public partial class frmDetalleDoc : Form
    {
        public frmDetalleDoc()
        {
            InitializeComponent();
        }
        private void frmDetalleDoc_Load(object sender, EventArgs e)
        {
            int idTipo_documento = 0;
            try
            {
                SqlConnection comercialConnection = new SqlConnection(Conection.conectionstring);
                SqlCommand xSqlCommand = new SqlCommand("dbo.paDetalleDoc2010_C", comercialConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@clave", SqlDbType.NVarChar).Value = ClienteActual.clave_doc;
                xSqlCommand.Connection.Open();
                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataTable xDataTableSet = new DataTable();
                xSqlDataAdapter.Fill(xDataTableSet);
                xSqlDataAdapter.Dispose();
                if (xDataTableSet.Rows.Count == 1)
                {
                    textBox33.Visible = false;
                    txtPagos.Visible = false;
                    cmdDetallePago.Visible = false;
                    txtReferencia.Visible = false;
                    txtOtros.Visible = false;
                    switch (ClienteActual.clave_doc.ToString().Substring(0,2))
                    {
                        case "01":
                            txtRef.Text = "Serie y Numero";
                            idTipo_documento=1;
                            this.Text = "FACTURA DE VENTA ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "02":
                            txtRef.Text = "Serie y Numero";
                            idTipo_documento=1;
                            this.Text = "BOLETA DE VENTA ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "03":
                            txtRef.Text = "Serie y Numero";
                            this.Text = "ORDEN DE SALIDA ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "04":
                            txtRef.Text = "Serie y Numero";
                            this.Text = "GUIA DE REMISION ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "05":
                            txtRef.Text = "Serie y Numero";
                            this.Text = "NOTA DE CREDITO ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "09":
                            txtRef.Text = "Serie y Numero";
                            this.Text = "REINGRESO ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                        case "20":
                            txtRef.Text = "Serie y Numero";
                            this.Text = "REGISTRO DE ENTREGA AL SUSCRIPTOR ::::: N° " + ClienteActual.clave_doc.ToString().Substring(3, 11);
                            break;
                    }
                    txtSerie.Text = xDataTableSet.Rows[0]["NRO_SERIE"].ToString();
                    txtNumero.Text = xDataTableSet.Rows[0]["NUMERO"].ToString();    
                    dteFecha.Value = Convert.ToDateTime(xDataTableSet.Rows[0]["FECHA_EMISION"].ToString());
                    txtRUC.Text = xDataTableSet.Rows[0]["ID_CLIENTE"].ToString();
                    txtNombre.Text = xDataTableSet.Rows[0]["NOMBRE_CLIENTE"].ToString();
                    txtDireccion.Text = xDataTableSet.Rows[0]["DIRECCION"].ToString();
                    txtVendedor.Text = xDataTableSet.Rows[0]["VENDEDOR"].ToString();

                    txtDctoP.Text = Convert.ToDouble(xDataTableSet.Rows[0]["DCTO_DOC_PORCENTAJE"].ToString()).ToString("##,##0.00");
                    txtDctoV.Text = Convert.ToDouble(xDataTableSet.Rows[0]["DCTO_DOC_VALOR"].ToString()).ToString("##,##0.00");
                    txtDctoSV.Text = Convert.ToDouble(xDataTableSet.Rows[0]["TOTAL_DCTO_SIN_VALOR"].ToString()).ToString("##,##0.00");

                    txtSubTotal.Text = Convert.ToDouble(xDataTableSet.Rows[0]["TOTAL_NETO"].ToString()).ToString("##,##0.00");
                    txtIGV.Text = Convert.ToDouble(xDataTableSet.Rows[0]["DCTO_IGV_VALOR"].ToString()).ToString("##,##0.00");
                    txtTotal.Text = Convert.ToDouble(xDataTableSet.Rows[0]["TOTAL_BRUTO"].ToString()).ToString("##,##0.00");
                    txtSituacion.Text = xDataTableSet.Rows[0]["SITUACION"].ToString();
                    if (txtSituacion.Text == "VIGENTE")
                    {
                        textBox35.Visible=false;
                        dceFechaAnulacion.Visible = false;
                        textBox35.ForeColor = Color.Blue;
                    }
                    else
                    {
                        textBox35.Visible = true;
                        dceFechaAnulacion.Visible = true;
                        dceFechaAnulacion.Value = Convert.ToDateTime(xDataTableSet.Rows[0]["FECHA_ANULACION"].ToString());
                        textBox35.ForeColor = Color.Red;
                    }
                    if (idTipo_documento == 1)
                    {
                        textBox33.Visible = true;
                        txtPagos.Visible = true;
                        cmdDetallePago.Visible = true;
                        GetPagos(ClienteActual.clave_doc);
                    }
                        // Open the connection
                        try
                        {
                            SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                            SqlCommand xSql_Command = new SqlCommand("dbo.paDetalleDoc2010", xSqlConnection);
                            xSql_Command.CommandType = CommandType.StoredProcedure;
                            xSql_Command.Parameters.Add("@clave", SqlDbType.NVarChar).Value = ClienteActual.clave_doc;
                            xSql_Command.Connection.Open();

                            SqlDataAdapter xSql_DataAdapter = new SqlDataAdapter(xSql_Command);
                            DataSet xDataSet = new DataSet();
                            xSql_DataAdapter.Fill(xDataSet, "DetalleDoc");
                            xSql_DataAdapter.Dispose();

                            dgDetalleDoc.DataSource = xDataSet;
                            dgDetalleDoc.DataMember = "DetalleDoc";
                            dgDetalleDoc.Refresh();
                            FormatGridWithTableStyles();

                            DataGridViewColumn COL01 = new DataGridViewColumn();
                            COL01 = dgDetalleDoc.Columns["ID_NUMERO"];
                            COL01.ReadOnly = true;
                            COL01.Visible = true;
                            COL01.HeaderText = "N°";
                            COL01.Width = 30;
                            COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            COL01.DefaultCellStyle.Format = "###";

                            DataGridViewColumn COL02 = new DataGridViewColumn();
                            COL02 = dgDetalleDoc.Columns["ID_PRODUCTO"];
                            COL02.ReadOnly = true;
                            COL02.Visible = true;
                            COL02.HeaderText = "Cod";
                            COL02.Width = 50;
                            COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            COL02.DefaultCellStyle.Format = "####";

                            DataGridViewColumn COL03 = new DataGridViewColumn();
                            COL03 = dgDetalleDoc.Columns["CANTIDAD"];
                            COL03.ReadOnly = true;
                            COL03.Visible = true;
                            COL03.HeaderText = "Cantidad";
                            COL03.Width = 50;
                            COL03.DefaultCellStyle.BackColor = Color.CadetBlue;
                            COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            COL03.DefaultCellStyle.Format = "#,###";

                            DataGridViewColumn COL04 = new DataGridViewColumn();
                            COL04 = dgDetalleDoc.Columns["PRECIO_U"];
                            COL04.Width = 50;
                            COL04.HeaderText = "Precio U";
                            COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            COL04.DefaultCellStyle.Format = "#,##0.00";

                            DataGridViewColumn COL05 = new DataGridViewColumn();
                            COL05 = dgDetalleDoc.Columns["SUB_TOTAL"];
                            COL05.Width = 50;
                            COL05.HeaderText = "Sub Total";
                            COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            COL05.DefaultCellStyle.Format = "#,##0.00";

                            DataGridViewColumn COL06 = new DataGridViewColumn();
                            COL06 = dgDetalleDoc.Columns["DETALLE"];
                            COL06.Width = 350;
                            COL06.HeaderText = "Detalle";
                            COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                }
                else
                {
                    MessageBox.Show("NO EXISTE INFORMACION PARA SER MOSTRADO");
                }
            }
            catch
            {
                MessageBox.Show(Conection.error_coneccion);
                this.Hide();
            }
        }
        private void GetPagos(string clave)
        {
            Double fResultado = 0;
            SqlConnection comercial_Connection = new SqlConnection(Conection.conectionstring);
            SqlCommand x_SqlCommand = new SqlCommand("dbo.paGetPagos2010", comercial_Connection);
            x_SqlCommand.CommandType = CommandType.StoredProcedure;
            x_SqlCommand.Parameters.Add("@clave", SqlDbType.NVarChar).Value = ClienteActual.clave_doc;
            x_SqlCommand.Connection.Open();
            SqlDataAdapter x_SqlDataAdapter = new SqlDataAdapter(x_SqlCommand);
            DataTable x_DataTableSet = new DataTable();
            x_SqlDataAdapter.Fill(x_DataTableSet);
            x_SqlDataAdapter.Dispose();
            if (x_DataTableSet.Rows.Count == 1)
            {
                fResultado = Convert.ToDouble(x_DataTableSet.Rows[0]["TOTAL_PAGO"].ToString());
                txtPagos.Text = Convert.ToDouble(x_DataTableSet.Rows[0]["TOTAL_PAGO"].ToString()).ToString("##,##0.00");
                dteFechaPago.Value = Convert.ToDateTime(x_DataTableSet.Rows[0]["ULTIMA_FECHA"].ToString());
                if (fResultado == 0)
                {
                    cmdDetallePago.Visible = false;
                    dteFechaPago.Visible = false;
                }

            }
            else
            {
                txtPagos.Text = Convert.ToDouble(0).ToString("##,##0.00");
                dteFechaPago.Value = Convert.ToDateTime(DateTime.Now.ToString());
            }
        }
        private void FormatGridWithTableStyles()
        {
            dgDetalleDoc.BackColor = Color.GhostWhite;
            dgDetalleDoc.BackgroundColor = Color.Lavender;
            dgDetalleDoc.BorderStyle = BorderStyle.None;
            dgDetalleDoc.Font = new Font("Tahoma", (float)8.0);
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
            grdTableStyle1.MappingName = "DetalleDoc";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void cmdCerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
