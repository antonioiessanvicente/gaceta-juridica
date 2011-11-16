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
    public partial class frmSalidas : Form
    {
        private Maestro maestro3 = new Maestro();
        private BindingSource BindingSource1 = new BindingSource();
        public frmSalidas()
        {
            InitializeComponent();
        }

        private void frmSalidas_Load(object sender, EventArgs e)
        {
            try
            {
                maestro3.ERRORES = "";
                maestro3.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                BindingSource1.DataSource = maestro3.getSalidasResumen(maestro3);
                dgvMaestro.MultiSelect = false;
                dgvMaestro.DataSource = BindingSource1.DataSource;
                dgvMaestro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgvMaestro.Columns["ID_CLIENTE"];
                COL00.ReadOnly = true;
                COL00.Visible = false;
                COL00.HeaderText = "CODIGO";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgvMaestro.Columns["NOMBRE_RAZON_SOCIAL"];
                COL01.ReadOnly = true;
                COL01.Visible = true;
                COL01.HeaderText = "NOMBRE DEL AUTOR - CLIENTES";
                COL01.Width = 250;

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
                COL02.Width = 250;

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgvMaestro.Columns["CANTIDAD"];
                COL04.ReadOnly = true;
                COL04.Visible = true;
                COL04.HeaderText = "CANTIDAD";
                COL04.Width = 100;
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvMaestro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ContratoActual.ID_CLIENTE = dgvMaestro.Rows[dgvMaestro.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ContratoActual.ID_PRODUCTO = int.Parse( dgvMaestro.Rows[dgvMaestro.CurrentCell.RowIndex].Cells[2].Value.ToString());
            if (ContratoActual.ID_CLIENTE != "")
            {
                Form frm_Detsalidas = new frmDetSalidas();
                frm_Detsalidas.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
