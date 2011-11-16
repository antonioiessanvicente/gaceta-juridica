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
    public partial class frmClientes : Form
    {
        private Maestro maestro = new Maestro();
        private BindingSource BindingSource1 = new BindingSource();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                ListaClientes();
                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgvMaestro.Columns["ID_CLIENTE"];
                COL00.ReadOnly = true;
                COL00.Visible = false;
                COL00.HeaderText = "CODIGO";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgvMaestro.Columns["NOMBRE_CLIENTE"];
                COL01.ReadOnly = true;
                COL01.Visible = true;
                COL01.HeaderText = "NOMBRE DEL CLIENTE";
                COL01.Width = 350;

                
                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgvMaestro.Columns["DIRECCION"];
                COL02.ReadOnly = true;
                COL02.Visible = true;
                COL02.HeaderText = "DIRECCION";
                COL02.Width = 350;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ListaClientes()
        {
            try
            {
                maestro.ERRORES = "";
                BindingSource1.DataSource = maestro.LeeClientesAutores(maestro);
                dgvMaestro.MultiSelect = false;
                dgvMaestro.DataSource = BindingSource1.DataSource;
                dgvMaestro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void FormatGridWithTableStyles()
        {
            dgvMaestro.BackColor = Color.GhostWhite;
            dgvMaestro.BackgroundColor = Color.Lavender;
            dgvMaestro.BorderStyle = BorderStyle.None;
            dgvMaestro.Font = new Font("Tahoma", (float)7.0);
            DataGridTableStyle grdTableStyle1 = new DataGridTableStyle();
            grdTableStyle1.AlternatingBackColor = Color.GhostWhite;
            grdTableStyle1.BackColor = Color.GhostWhite;
            grdTableStyle1.ForeColor = Color.MidnightBlue;
            grdTableStyle1.GridLineColor = Color.RoyalBlue;
            grdTableStyle1.HeaderBackColor = Color.MidnightBlue;
            grdTableStyle1.HeaderFont = new Font("Tahoma", (float)7.0, FontStyle.Bold);
            grdTableStyle1.HeaderForeColor = Color.Lavender;
            grdTableStyle1.SelectionBackColor = Color.Teal;
            grdTableStyle1.SelectionForeColor = Color.PaleGreen;
            grdTableStyle1.MappingName = "Suscripciones";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }
        public int Buscar(string Columna, string texto, BindingSource BindingSource)
        {
            try
            {
                if (BindingSource1.DataSource == null)
                {
                    return -1;
                }
                BindingSource.Filter = "[" + Columna + "] like '%" + texto.Trim() + "%'";
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return -1;
        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            int ret = Buscar("NOMBRE_CLIENTE", txtBuscar.Text.Trim(), BindingSource1);
        }

        private void dgvMaestro_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            ContratoActual.ID_CLIENTE = dgvMaestro.Rows[dgvMaestro.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (ContratoActual.ID_CLIENTE != "")
            {
                ContratoActual.ACTION = "OK";
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            ContratoActual.ID_CLIENTE = "";
            ContratoActual.ACTION = "CANCEL";
            this.Hide();
        }

        private void dgvMaestro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
