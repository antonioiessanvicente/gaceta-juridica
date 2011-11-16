using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccesoDatos;

namespace ErpGaceta
{
    public partial class frm_LlenarData : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores Parmetros = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private DataTable Detalle_Datos = new DataTable();
        DataSet MiDataSet_Detalle = new DataSet(); 
        public frm_LlenarData()
        {
            InitializeComponent();
        }
        private void frm_LlenarData_Load(object sender, EventArgs e)
        {
            try
            {
                MuestraDatos_Detalle();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MuestraDatos_Detalle()
        {
            try
            {
                Parmetros.NUMERO = Principal.Numero;
                Detalle_Datos = Parmetros.ObtieneMuestraDataImgenFile(Parmetros);
                Detalle_Datos.TableName = "MASTER_IMAGE";
                MiDataSet_Detalle.Tables.Clear();
                MiDataSet_Detalle.Tables.Add(Detalle_Datos);
                dgImagenes.DataSource = MiDataSet_Detalle.Tables["MASTER_IMAGE"].DefaultView;
                
                 DataGridViewColumn COL00 = new DataGridViewColumn();
                 COL00 = dgImagenes.Columns["ID_CLIENTE"];
                 COL00.Width = 90;
                 COL00.HeaderText = "COD CLIENTE";

                 DataGridViewColumn COL01 = new DataGridViewColumn();
                 COL01 = dgImagenes.Columns["NOMBRE_RAZON_SOCIAL"];
                 COL01.Width = 400;
                 COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                 COL01.HeaderText = "NOMBRE DEL CLIENTE";

                 DataGridViewColumn COL02 = new DataGridViewColumn();
                 COL02 = dgImagenes.Columns["FECHA_ENVIO"];
                 COL02.Width = 80;
                 COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                 COL02.HeaderText = "FECHA E";
                 COL02.DefaultCellStyle.Format = "dd-MMM-yyyy";

                 DataGridViewColumn COL03 = new DataGridViewColumn();
                 COL03 = dgImagenes.Columns["HORA_ENVIO"];
                 COL03.Width = 80;
                 COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                 COL03.DefaultCellStyle.Format = "hh:mm tt";
                 COL03.HeaderText = "HORA";

                 DataGridViewColumn COL04 = new DataGridViewColumn();
                 COL04 = dgImagenes.Columns["DESTINO"];
                 COL04.Width = 150;
                 COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                 COL04.HeaderText = "DESTINO";

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgImagenes.Columns["NRO_DOC"];
                COL06.Width = 80;
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL06.HeaderText = "DOCUMENTO";

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgImagenes.Columns["OTRO_DATO"];
                COL07.Width = 100;
                COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL07.HeaderText = "OTRO DATO";

                DataGridViewColumn COL08 = new DataGridViewColumn();
                COL08 = dgImagenes.Columns["NRO_CAJAS"];
                COL08.Width = 50;
                COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL08.HeaderText = "CAJAS";

                DataGridViewColumn COL09 = new DataGridViewColumn();
                COL09 = dgImagenes.Columns["NRO_SOBRES"];
                COL09.Width = 50;
                COL09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL09.HeaderText = "SOBRES";

                DataGridViewColumn COL10 = new DataGridViewColumn();
                COL10 = dgImagenes.Columns["TIPO_ARCHIVO"];
                COL10.Width = 0;
                COL10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                



            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Principal.TipoProceso == "1")
            {
                this.Cursor = Cursors.WaitCursor;
                Principal.IdCliente = dgImagenes.CurrentRow.Cells[0].Value.ToString();
                if (Principal.IdCliente.Length != 0)
                {
                    Principal.Action = "0";
                    Form rptReportes = new frm_SetData();
                    rptReportes.ShowDialog();
                    MuestraDatos_Detalle();
                }
                this.Cursor = Cursors.Default;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgImagenes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Principal.IdCliente = dgImagenes.CurrentRow.Cells[0].Value.ToString();
            
            if (Principal.IdCliente.Length != 0)
            {
                Principal.Action = "1";
                Form rptReportes = new frm_SetData();
                rptReportes.ShowDialog();
            }
            this.Cursor = Cursors.Default;
        }

        private void dgImagenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
