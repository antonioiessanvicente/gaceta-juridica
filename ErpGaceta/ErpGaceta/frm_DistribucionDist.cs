using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErpGaceta
{
    public partial class frm_DistribucionDist : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores ParmetrosCab = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private DataTable MaestroCab = new DataTable();
        DataSet MiDataSetCab = new DataSet();        

        public frm_DistribucionDist()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Principal.TipoProceso == "0")
            {
                Principal.fechaIni = DateTime.Now;
                Principal.fechaFin = DateTime.Now;
                Principal.Numero = 0;
                Principal.Descripcion = "";
                Form childForm = new frmDetalleRegDistribuidores();
                childForm.ShowDialog();
                MuestraDatosCab();
            }
        }

        private void frm_DistribucionDist_Load(object sender, EventArgs e)
        {
            try
            {
                MuestraDatosCab();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MuestraDatosCab()
        {
            try
            {
                ParmetrosCab.COD_EMPRESA = Principal.strCodEmpresa;
                ParmetrosCab.TIPO_PROCESO = Principal.TipoProceso;
                MaestroCab = ParmetrosCab.LeedatosRegDistribuidoresCab(ParmetrosCab);
                MaestroCab.TableName = "MAESTRO";

                MiDataSetCab.Tables.Clear();
                MiDataSetCab.Tables.Add(MaestroCab);

                dgCabecera.DataSource = MiDataSetCab.Tables["MAESTRO"].DefaultView;
                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgCabecera.Columns["NUMERO"];
                COL00.Width = 90;
                COL00.HeaderText = "N° REG";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgCabecera.Columns["FECHA"];
                COL01.Width = 80;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "FECHA";
                COL01.DefaultCellStyle.Format = "dd-MMM-yyyy";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgCabecera.Columns["DESCRIPCION"];
                COL02.Width = 200;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "DESCRIPCION";

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgCabecera.Columns["SITUACION"];
                COL03.Width = 100;
                COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL03.HeaderText = "SITUACION";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgCabecera.Columns["FECHA_INI"];
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL04.HeaderText = "FECHA I";
                COL04.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL04.Width = 80;

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgCabecera.Columns["FECHA_FIN"];
                COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL05.HeaderText = "FECHA F";
                COL05.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL05.Width = 80;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgCabecera.Columns["FECHA_SISTEMA"];
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL06.HeaderText = "FECHA S";
                COL06.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL06.Width = 80;

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgCabecera.Columns["USER_MODIFICADO"];
                COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL07.HeaderText = "USER MOD";

                DataGridViewColumn COL08 = new DataGridViewColumn();
                COL08 = dgCabecera.Columns["FECHA_MODIFICADO"];
                COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL08.HeaderText = "FECHA MOD";
                COL08.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL08.Width = 80;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCabecera_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // DOBLE CLIEN EN EL GRID VIEW
            Principal.Descripcion = dgCabecera.CurrentRow.Cells[2].Value.ToString();
            if (Principal.Descripcion.Length != 0)
            {
                Principal.Numero = Convert.ToDouble(dgCabecera.CurrentRow.Cells[0].Value.ToString());

                Form rptReportes = new frm_LlenarData();
                rptReportes.ShowDialog();
            }
            //Principal.fechaIni =  Convert.ToDateTime(dgCabecera.CurrentRow.Cells[4].Value.ToString()); 
            //Principal.fechaFin = Convert.ToDateTime(dgCabecera.CurrentRow.Cells[5].Value.ToString()); 
            //Principal.Numero = Convert.ToDouble(dgCabecera.CurrentRow.Cells[0].Value.ToString()); 
            //Principal.Descripcion = dgCabecera.CurrentRow.Cells[2].Value.ToString();
            //if (Principal.Descripcion.Length != 0)
            //{
            //    Form childForm = new frmDetalleRegDistribuidores();
            //    childForm.ShowDialog();
            //    MuestraDatosCab();
            //}
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Principal.Descripcion = dgCabecera.CurrentRow.Cells[2].Value.ToString();
            if (Principal.Descripcion.Length != 0)
            {
                Principal.Numero = Convert.ToDouble(dgCabecera.CurrentRow.Cells[0].Value.ToString());
                Form rptReportes = new frm_Reportes();
                rptReportes.ShowDialog();
            }
        }

        private void RegDatos_Click(object sender, EventArgs e)
        {
            Principal.Descripcion = dgCabecera.CurrentRow.Cells[2].Value.ToString();
            if (Principal.Descripcion.Length != 0)
            {
                Principal.Numero = Convert.ToDouble(dgCabecera.CurrentRow.Cells[0].Value.ToString());

                Form rptReportes = new frm_LlenarData();
                rptReportes.ShowDialog();
            }
        }

        private void dgCabecera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
