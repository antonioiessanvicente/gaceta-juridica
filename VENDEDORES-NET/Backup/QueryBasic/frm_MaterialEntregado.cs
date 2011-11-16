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
    public partial class frm_MaterialEntregado : Form
    {
        public frm_MaterialEntregado()
        {
            InitializeComponent();
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
        private void frm_MaterialEntregado_Load(object sender, EventArgs e)
        {
            //dgMaterialEntergado
            try
            {
                SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                // Open the connection
                //                conn.Open();
                SqlCommand xSqlCommand = new SqlCommand("dbo.paEntregaMaterial", xSqlConnection);
                xSqlCommand.CommandType = CommandType.StoredProcedure;
                xSqlCommand.Parameters.Add("@ID_CLIENTE", SqlDbType.NVarChar).Value = ClienteActual.Id_cliente;
                xSqlCommand.Parameters.Add("@ID_SUSCRIPCION", SqlDbType.NVarChar).Value = ClienteActual.Id_Suscripcion;
                xSqlCommand.Connection.Open();

                SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                DataSet xDataSet = new DataSet();
                xSqlDataAdapter.Fill(xDataSet, "MaterialEntregado");
                xSqlDataAdapter.Dispose();

                dgMaterialEntergado.DataSource = xDataSet;
                dgMaterialEntergado.DataMember = "MaterialEntregado";
                dgMaterialEntergado.Refresh();
                FormatGridWithTableStyles();
                dgMaterialEntergado.Columns[3].Visible = false;
                dgMaterialEntergado.Columns[4].Visible = true;
                dgMaterialEntergado.Columns[5].Visible = false;
                //dgMaterialEntergado.Columns[6].Visible = false;
                //dgMaterialEntergado.Columns[7].Visible = false;
                //dgMaterialEntergado.Columns[8].Visible = false;
                //dgMaterialEntergado.Columns[10].Visible = false;
                //dgMaterialEntergado.Columns[11].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
