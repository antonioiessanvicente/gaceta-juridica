using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccesoDatos.Orm;

namespace frmContratos
{
    public partial class frmDetSalidas : Form
    {
        private Maestro maestro4 = new Maestro();
        private BindingSource BindingSource4 = new BindingSource();
        public frmDetSalidas()
        {
            InitializeComponent();
        }

        private void frmDetSalidas_Load(object sender, EventArgs e)
        {
            try
            {
                maestro4.ERRORES = "";
                maestro4.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                maestro4.ID_CLIENTE = ContratoActual.ID_CLIENTE;
                maestro4.ID_PRODUCTO = ContratoActual.ID_PRODUCTO;
                BindingSource4.DataSource = maestro4.getSalidasDetalle(maestro4);
                dgvMaestro.MultiSelect = false;
                dgvMaestro.DataSource = BindingSource4.DataSource;
                dgvMaestro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgvMaestro.Columns["DOCMTO"];
                COL00.ReadOnly = true;
                COL00.Visible = true;
                COL00.HeaderText = "DCMTO";
                COL00.Width = 100;

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgvMaestro.Columns["FECHA_EMISION"];
                COL01.ReadOnly = true;
                COL01.Visible = true;
                COL01.HeaderText = "FECHA";
                COL01.DefaultCellStyle.Format = "dd-MMM-yy";
                COL01.Width = 80;

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgvMaestro.Columns["ID_PRODUCTO"];
                COL03.ReadOnly = true;
                COL03.Visible = false;
                COL03.HeaderText = "ID_PRODUCTO";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgvMaestro.Columns["DETALLE"];
                COL02.ReadOnly = true;
                COL02.Visible = true;
                COL02.HeaderText = "DETALLE DEL PRODUCTO";
                COL02.Width = 445;

                
                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgvMaestro.Columns["ID_TIPO_SALIDA"];
                COL04.ReadOnly = true;
                COL04.Visible = true;
                COL04.HeaderText = "COD";
                COL04.Width = 30;

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgvMaestro.Columns["CANTIDAD"];
                COL05.ReadOnly = true;
                COL05.Visible = true;
                COL05.HeaderText = "CANTIDAD";
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL05.Width = 60;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgvMaestro.Columns["CLAVE"];
                COL06.ReadOnly = true;
                COL06.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
