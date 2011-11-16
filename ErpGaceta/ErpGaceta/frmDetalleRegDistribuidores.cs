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
    public partial class frmDetalleRegDistribuidores : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores Parmetros = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private DataTable Maestro = new DataTable();
        private DataTable Detalle = new DataTable();
        DataSet MiDataSet = new DataSet();        

        public frmDetalleRegDistribuidores()
        {
            InitializeComponent();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
            MuestraDatos();
            //btnFinalizar.Enabled = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private String FechaDigitos(String strvalor) 
        {
            if (strvalor.Length == 1)
            { return "0" + strvalor; }
            else
            { return strvalor; }
        }

        private void MuestraDatos()
        {
            try
            {
                String fechaI = dtFechaIni.Value.Year.ToString() + FechaDigitos(dtFechaIni.Value.Month.ToString()) + FechaDigitos(dtFechaIni.Value.Day.ToString());
                String fechaF = dtFechaFin.Value.Year.ToString() + FechaDigitos(dtFechaFin.Value.Month.ToString()) + FechaDigitos(dtFechaFin.Value.Day.ToString());
                //int ancho = 30;
                Parmetros.FECHA_INI = fechaI;
                Parmetros.FECHA_FIN = fechaF;
                if (this.radioButton1.Checked == true)
                {
                    Parmetros.TIPO_DIST = "002";
                }
                else
                {
                    Parmetros.TIPO_DIST = "003";
                }
                Parmetros.COD_EMPRESA = Principal.strCodEmpresa;
                Maestro = Parmetros.ObtieneDataDistribuidores(Parmetros);
                Maestro.TableName = "MASTER";
                if (Maestro.Rows.Count > 0)
                {
                    btnFinalizar.Enabled = true;
                }
                else
                {
                    btnFinalizar.Enabled = false;
                }
                MiDataSet.Tables.Clear();
                MiDataSet.Tables.Add(Maestro);

                dgRegistros.DataSource = MiDataSet.Tables["MASTER"].DefaultView;
                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgRegistros.Columns["ID_CLIENTE"];
                COL00.Width = 90;
                COL00.HeaderText = "COD CLIENTE";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgRegistros.Columns["FECHA_EMISION"];
                COL01.Width = 80;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "FECHA";
                COL01.DefaultCellStyle.Format = "dd-MMM-yyyy";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgRegistros.Columns["CLAVE"];
                COL02.Width = 100;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "DOCUMENTO";

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgRegistros.Columns["NOMBRE_RAZON_SOCIAL"];
                COL03.Width = 500;
                COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL03.HeaderText = "NOMBRE DEL CLIENTE";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgRegistros.Columns["ID_PRODUCTO"];
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL04.HeaderText = "COD PRODUCTO";
                COL04.Visible = false;

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgRegistros.Columns["CANTIDAD"];
                COL05.Width = 50;
                COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL05.HeaderText = "CANTIDAD";

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgRegistros.Columns["DETALLE"];
                COL06.Width = 500;
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL06.HeaderText = "DETALLE DEL PRODUCTO";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void MuestraDatos_01(double Numero)
        {
            try
            {
                Parmetros.NUMERO = Numero;
                Maestro = Parmetros.ObtieneDataDistribuidores_01(Parmetros);
                Maestro.TableName = "MASTER";

                MiDataSet.Tables.Clear();
                MiDataSet.Tables.Add(Maestro);

                dgRegistros.DataSource = MiDataSet.Tables["MASTER"].DefaultView;

                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgRegistros.Columns["ID_CLIENTE"];
                COL00.Width = 90;
                COL00.HeaderText = "COD CLIENTE";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgRegistros.Columns["FECHA_EMISION"];
                COL01.Width = 80;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "FECHA";
                COL01.DefaultCellStyle.Format = "dd-MMM-yyyy";

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgRegistros.Columns["CLAVE"];
                COL02.Width = 100;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "DOCUMENTO";

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgRegistros.Columns["NOMBRE_RAZON_SOCIAL"];
                COL03.Width = 500;
                COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL03.HeaderText = "NOMBRE DEL CLIENTE";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgRegistros.Columns["ID_PRODUCTO"];
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL04.HeaderText = "COD PRODUCTO";
                COL04.Visible = false;

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgRegistros.Columns["CANTIDAD"];
                COL05.Width = 50;
                COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL05.HeaderText = "CANTIDAD";

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgRegistros.Columns["DETALLE"];
                COL06.Width = 500;
                COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL06.HeaderText = "DETALLE DEL PRODUCTO";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDetalle.TextLength != 0)
                {

                    Parmetros.NUMERO = Principal.Numero;
                    Parmetros.DESCRIPCION = txtDetalle.Text;
                    Parmetros.ERRORES = "";
                    Parmetros.FECHA_INI = dtFechaIni.Value.Year.ToString() + FechaDigitos(dtFechaIni.Value.Month.ToString()) + FechaDigitos(dtFechaIni.Value.Day.ToString());
                    Parmetros.FECHA_FIN = dtFechaFin.Value.Year.ToString() + FechaDigitos(dtFechaFin.Value.Month.ToString()) + FechaDigitos(dtFechaFin.Value.Day.ToString());
                    Parmetros.CrearRegDistribuidores(Parmetros);
                    Parmetros.COD_EMPRESA = Principal.strCodEmpresa;
                    if (Parmetros.ERRORES.ToString() != "")
                    {
                        MessageBox.Show(Parmetros.ERRORES.ToString());
                    }
                    else
                    {
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Debe de ingresar una descripción");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void dgRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDetalleRegDistribuidores_Load(object sender, EventArgs e)
        {
            btnFinalizar.Enabled = false;
            if (Principal.Numero != 0)
            {
                //panel1.Enabled = false;
                txtDetalle.Text =Principal.Descripcion;
                dtFechaIni.Value = Principal.fechaIni;
                dtFechaFin.Value = Principal.fechaFin;
                cmdRefresh.Enabled = false;
                txtDetalle.Enabled = false;
                dtFechaIni.Enabled = false;
                dtFechaFin.Enabled = false;
                MuestraDatos_01(Principal.Numero);
            }
            else
            {
                //panel1.Enabled = true;
                cmdRefresh.Enabled = true;
                txtDetalle.Enabled = true;
                dtFechaIni.Enabled = true;
                dtFechaFin.Enabled = true;
            }
            if (Principal.TipoProceso == "1")
            {
                panel1.Enabled=false;
                btnFinalizar.Enabled = false;
            }

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            cmdRefresh.Enabled = true;
            txtDetalle.Enabled = true;
            dtFechaIni.Enabled = true;
            dtFechaFin.Enabled = true;
        }
    }
}
