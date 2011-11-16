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
    public partial class frmBusquedas : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores maestro = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private BindingSource BindingSource1 = new BindingSource();

        private ContextMenu contextMenuForColumn2 = new ContextMenu();

        public frmBusquedas()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBusquedas_Load(object sender, EventArgs e)
        {
            try
            {
                // Add context mneu items
                contextMenuForColumn2.MenuItems.Add("Ver Detalle de Guia ?", new EventHandler(Muestra_Datos_Guia));
                // Initialize data
                this.dateTimePicker1.Value = System.DateTime.Now;
                this.dateTimePicker2.Value = System.DateTime.Now;
                txtCliente.Text = "";
                txtProducto.Text = "";
                //Open data
                if (ListarDatos() == false)
                {
                    MessageBox.Show("LISTA DE DATOS NO HA CONCLUIDO SATISFACTORIAME");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        ///<summary>
        ///Muestra_Datos_Guia
        ///</summary>
        ///<remarks>
        ///Modulo para mostrar el detalle de los documentos
        ///Fecha      : 17-Jun-2011
        ///Autor(es)  : Grupo de desarrollo de Gaceta Jurídica (Marco Mendoza)
        ///Copyright (c) Gaceta Jurídica S.A.
        ///</remarks>
        private void Muestra_Datos_Guia(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Principal.IdCliente = dgvBusquedas.CurrentRow.Cells[2].Value.ToString();
            Principal.CLAVE =  dgvBusquedas.CurrentRow.Cells[4].Value.ToString().Replace("GR-","03-");
            Principal.TIPO_DOCUMENTO = "03";
            if (Principal.CLAVE.Length != 0)
            {
                Principal.Action = "1";
                Form frm_Ver_Documento = new frmVerDetalleDocumentos();
                frm_Ver_Documento.ShowDialog();

            }
            this.Cursor = Cursors.Default;
        }

        private Boolean ListarDatos()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                maestro.COD_EMPRESA = Principal.strCodEmpresa;
                maestro.STR_FECHA_INI = maestro.FechaToSql(dateTimePicker1.Value);
                maestro.STR_FECHA_FIN = maestro.FechaToSql(dateTimePicker2.Value);
                if (rbFechaReg.Checked == true)
                {
                    maestro.TIPO_DIST = "0";
                }
                else
                {
                    maestro.TIPO_DIST = "1";
                }
                BindingSource1.DataSource = maestro.ObtieneDataDistribuidores_02(maestro);
                //dgvMaestro.DataSource = maestro.Buscar();
                dgvBusquedas.MultiSelect = false;
                dgvBusquedas.DataSource = BindingSource1.DataSource;
                //dgvBusquedas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dgvBusquedas.Font = "";
                dgvBusquedas.Columns[4].Visible = false;
                dgvBusquedas.Columns[8].Visible = false;
                dgvBusquedas.Columns[11].Visible = false;

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgvBusquedas.Columns["FECHA_ENVIO"];
                COL01.ReadOnly = true;
                COL01.Visible = true;
                COL01.HeaderText = "FECHA ENVIO";
                COL01.Width = 70;
                //COL01.DefaultCellStyle.Format = "#,###";
                COL01.DefaultCellStyle.Format = "dd-MMM-yy";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgvBusquedas.Columns["DESCRIPCION"];
                COL02.ReadOnly = true;
                COL02.Visible = false;
                //COL01.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL02a = new DataGridViewColumn();
                COL02a = dgvBusquedas.Columns["ESCANEADO"];
                COL02a.ReadOnly = true;
                COL02a.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL02a.Width = 40;

                DataGridViewColumn COL02b = new DataGridViewColumn();
                COL02b = dgvBusquedas.Columns["INFORMADO"];
                COL02b.ReadOnly = true;
                COL02b.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL02b.Width = 40;

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgvBusquedas.Columns["FECHA_EMISION"];
                COL03.ReadOnly = true;
                COL03.Visible = true;
                COL03.HeaderText = "FECHA EMIS";
                COL03.Width = 70;
                //COL01.DefaultCellStyle.Format = "#,###";
                COL03.DefaultCellStyle.Format = "dd-MMM-yy";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgvBusquedas.Columns["CLAVE"];
                COL04.ReadOnly = true;
                COL04.Visible = true;
                COL04.HeaderText = "N° DOC";
                COL04.Width = 95;

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgvBusquedas.Columns["NOMBRE_RAZON_SOCIAL"];
                COL05.ReadOnly = true;
                COL05.Visible = true;
                COL05.HeaderText = "NOMBRE DEL CLIENTE";
                COL05.Width = 300;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgvBusquedas.Columns["CANTIDAD"];
                COL06.ReadOnly = true;
                COL06.Visible = true;
                COL06.HeaderText = "CANTIDAD";
                COL06.Width = 50;
                COL06.DefaultCellStyle.Format = "#,###";

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgvBusquedas.Columns["DETALLE"];
                COL07.ReadOnly = true;
                COL07.Visible = true;
                COL07.HeaderText = "NOMBRE DEL PRODUCTO";
                COL07.Width = 500;

                this.Cursor = Cursors.Default;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
                return false;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            int ret = Buscar(txtCliente.Text.Trim(), txtProducto.Text.Trim(), BindingSource1);
        }
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            int ret = Buscar(txtCliente.Text.Trim(), txtProducto.Text.Trim(), BindingSource1);
        }
        public int Buscar(string textoCliente, string textoProducto, BindingSource BindingSource)
        {
            string strFilter;
            if (textoCliente != "")
            {
                strFilter = "[NOMBRE_RAZON_SOCIAL] like '%" + textoCliente.Trim() + "%'";
            }
            else
            {
                strFilter = "[NOMBRE_RAZON_SOCIAL] like '%'";
            }
            if (textoProducto != "")
            {
                strFilter = strFilter + " AND [DETALLE] like '%" + textoProducto.Trim() + "%'";
            }
            else
            {
                strFilter = strFilter + " AND [DETALLE] like '%'";
            }

            try
            {
                if (BindingSource1.DataSource == null)
                {
                    return -1;
                }
                BindingSource.Filter = strFilter;
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return -1;
        }
        private void dgvBusquedas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //
            this.Cursor = Cursors.WaitCursor;
            Principal.IdCliente = dgvBusquedas.CurrentRow.Cells[4].Value.ToString();
            Principal.Numero = Convert.ToDouble(dgvBusquedas.CurrentRow.Cells[11].Value.ToString());
            if (Principal.IdCliente.Length != 0)
            {
                Principal.Action = "1";
                Form rptReportes = new frm_SetData();
                rptReportes.ShowDialog();
                if (Principal.Action == "1")
                {  // SOLO PARA EL AREA COMERCIAL
                    ListarDatos();
                }
            }
            this.Cursor = Cursors.Default;
        }
        private void dgvBusquedas_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (dgvBusquedas.CurrentCell.ColumnIndex == 6)
                    {
                        contextMenuForColumn2.MenuItems.Clear();
                        contextMenuForColumn2.MenuItems.Add("VER DETALLE : " + dgvBusquedas.CurrentRow.Cells[6].Value.ToString(), new EventHandler(Muestra_Datos_Guia));
                        contextMenuForColumn2.Show(dgvBusquedas, new Point(e.X, e.Y));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void rbFechaReg_CheckedChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ListarDatos();
        }
    }
}
