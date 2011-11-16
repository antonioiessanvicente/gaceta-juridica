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
    public partial class frmAsociarAutorCliente : Form
    {
        private Maestro maestro2 = new Maestro();
        public frmAsociarAutorCliente()
        {
            InitializeComponent();
        }
        private void frmAsociarAutorCliente_Load(object sender, EventArgs e)
        {
            try
            {
                LeeDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LeeDatos()
        {
            try
            {
                maestro2.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                maestro2.ERRORES = "";
                dg_AutoresClientes.DataSource = maestro2.LeeAutoresClientes(maestro2);
                dg_AutoresClientes.Refresh();

                // DataGrid1.Rows.Count
                if (dg_AutoresClientes.Rows.Count > 0)
                {
                    DataGridViewColumn COL01 = new DataGridViewColumn();
                    COL01 = dg_AutoresClientes.Columns["COD_CONTRATO"];
                    COL01.Visible = false;

                    DataGridViewColumn COL02 = new DataGridViewColumn();
                    COL02 = dg_AutoresClientes.Columns["ID_AUTOR"];
                    COL02.Visible = false;

                    DataGridViewColumn COL03 = new DataGridViewColumn();
                    COL03 = dg_AutoresClientes.Columns["ID_CLIENTE"];
                    COL03.Visible = false;

                    DataGridViewColumn COL04 = new DataGridViewColumn();
                    COL04 = dg_AutoresClientes.Columns["NOMBRE_AUTOR"];
                    COL04.Visible = true;
                    COL04.Width = 300;
                    COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    COL04.HeaderText = "NOMBRE DEL AUTOR";
                    //COL04.DefaultCellStyle.Format = "dd-MMM-yy";
                    DataGridViewColumn COL05 = new DataGridViewColumn();
                    COL05 = dg_AutoresClientes.Columns["CLIENTE_AUTOR"];
                    COL05.Width = 300;
                    COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    COL05.HeaderText = "CLIENTE - AUTOR";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmdAcept_Click(object sender, EventArgs e)
        {

        }

        private void cmdAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(dg_AutoresClientes.Rows[dg_AutoresClientes.CurrentCell.RowIndex].Cells[0].Value.ToString()) > 0)
                {
                    string Cod_Contrato = dg_AutoresClientes.Rows[dg_AutoresClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string Id_autor = dg_AutoresClientes.Rows[dg_AutoresClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    Form frmClientes = new frmClientes();
                    frmClientes.ShowDialog();
                    if (ContratoActual.ACTION == "OK")
                    {
                        maestro2.CODIGO_CONTRATO = Cod_Contrato;
                        maestro2.ID_AUTOR = Id_autor;
                        maestro2.ID_CLIENTE = ContratoActual.ID_CLIENTE;
                        maestro2.ERRORES = "";
                        maestro2.UpdateClientesAutores(maestro2);
                        LeeDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
