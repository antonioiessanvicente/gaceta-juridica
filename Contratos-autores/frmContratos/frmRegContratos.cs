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
    public partial class frmRegContratos : Form
    {
        private Maestro maestro = new Maestro();
        private DataTable Maestro = new DataTable();
        private DataTable Detalle = new DataTable();
        DataSet MiDataSet = new DataSet();
        public frmRegContratos()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegContratos_Load(object sender, EventArgs e)
        {
            try
            {
                //AccesoDatos.Conexion.IniciarSesion("192.168.0.6", "temporal", "acceso_vendedores", "navidad-2010");
                AccesoDatos.Conexion.IniciarSesion("192.168.0.6", "juridica");
                //MessageBox.Show(@"Se conecto exitosamente, más le vale!");
                MuestraDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MuestraDatos()
        {
            try
            {
                //int ancho = 30;
                Maestro = maestro.LeerContratos();
                Maestro.TableName = "MASTER";
                Detalle = maestro.LeeProductosContrato();
                Detalle.TableName = "DETAILS";

                
                MiDataSet.Tables.Add(Maestro);
                MiDataSet.Tables.Add(Detalle);

                dg_Productos.DataSource = MiDataSet.Tables["DETAILS"].DefaultView;
                dg_Contratos.DataSource = MiDataSet.Tables["MASTER"].DefaultView;

                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dg_Productos.Columns["COD_CONTRATO"];
                COL00.Visible = false;
                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dg_Productos.Columns["ID_PRODUCTO"];
                COL01.Width = 60;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "CODIGO";
                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dg_Productos.Columns["DETALLE"];
                COL02.Width = 600;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "DETALLE DEL PRODUCTO";

                


                BindingManagerBase currency;
                currency = this.BindingContext[dg_Contratos.DataSource];
                currency.PositionChanged += new EventHandler(Binding_PositionChanged);
                MostrarDetalle();

                DataGridViewColumn COL_00 = new DataGridViewColumn();
                COL_00 = dg_Contratos.Columns["CODIGO_CONTRATO"];
                COL_00.Visible = false;

                DataGridViewColumn COL_01 = new DataGridViewColumn();
                COL_01 = dg_Contratos.Columns["TITULO_OBRA"];
                COL_01.Width = 300;
                COL_01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL_01.HeaderText = "TITULO - OBRA";

                DataGridViewColumn COL_02 = new DataGridViewColumn();
                COL_02 = dg_Contratos.Columns["NRO_EJEMPLARES_CONT"];
                COL_02.Width = 60;
                COL_02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_02.HeaderText = "# EJEMPL.";

                DataGridViewColumn COL_03 = new DataGridViewColumn();
                COL_03 = dg_Contratos.Columns["NRO_IMPRESIONES"];
                COL_03.Width = 60;
                COL_03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_03.HeaderText = "# IMPRES.";

                DataGridViewColumn COL_04 = new DataGridViewColumn();
                COL_04 = dg_Contratos.Columns["VALOR_CONTRATO"];
                COL_04.Width = 60;
                COL_04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_04.HeaderText = "VAL. CONTRATO";

                DataGridViewColumn COL_05 = new DataGridViewColumn();
                COL_05 = dg_Contratos.Columns["ID_MONEDA"];
                COL_05.Width = 60;
                COL_05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_05.HeaderText = "MONEDA";

                DataGridViewColumn COL_06 = new DataGridViewColumn();
                COL_06 = dg_Contratos.Columns["FECHA_ENTREGA_TEXTOS"];
                COL_06.Width = 80;
                COL_06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_06.HeaderText = "FECHA TXT";
                COL_06.DefaultCellStyle.Format = "dd-MMM-yy";

                DataGridViewColumn COL_07 = new DataGridViewColumn();
                COL_07 = dg_Contratos.Columns["OBSERVACION"];
                COL_07.Width = 300;
                COL_07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_07.HeaderText = "OBSERVACION";

                DataGridViewColumn COL_08 = new DataGridViewColumn();
                COL_08 = dg_Contratos.Columns["FIRMA_TEXTOS"];
                COL_08.Width = 60;
                COL_08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_08.HeaderText = "FIRMA TXT";

                DataGridViewColumn COL_09 = new DataGridViewColumn();
                COL_09 = dg_Contratos.Columns["PAGO_ADELANTADO"];
                COL_09.Width = 60;
                COL_09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_09.HeaderText = "PAGO ADEL";

                DataGridViewColumn COL_10 = new DataGridViewColumn();
                COL_10 = dg_Contratos.Columns["FECHA_PAGO"];
                COL_10.Width = 80;
                COL_10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_10.HeaderText = "FECHA PAGO";
                COL_10.DefaultCellStyle.Format = "dd-MMM-yy";

                DataGridViewColumn COL_11 = new DataGridViewColumn();
                COL_11 = dg_Contratos.Columns["VALOR_PAGO"];
                COL_11.Width = 60;
                COL_11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL_11.HeaderText = "VALOR PAGO";

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void MostrarDetalle()
        {
            if (this.BindingContext[dg_Contratos.DataSource].Position != -1)
            {
                string filter;
                DataRowView selectedRow;
                // Selecciona la Fila actual.

                selectedRow = (DataRowView)this.BindingContext[dg_Contratos.DataSource].Current;
                // Crea un filtro con la expresion
                filter = "COD_CONTRATO='" + selectedRow.Row.ItemArray[0].ToString() + "'";
                // Modifica la vista de la tabla
                MiDataSet.Tables["DETAILS"].DefaultView.RowFilter = filter;
            }

        }
        private void Binding_PositionChanged(object sender, System.EventArgs e)
        {
            MostrarDetalle();
        }

        private void FormatGridWithTableStyles()
        {
            dg_Contratos.BackColor = Color.GhostWhite;
            dg_Contratos.BackgroundColor = Color.Lavender;
            dg_Contratos.BorderStyle = BorderStyle.None;
            dg_Contratos.Font = new Font("Tahoma", (float)8.0);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           try
            {
                //ClienteActual.ID_PRODUCTO = Convert.ToInt16(dgMaterialEntergado.Rows[dgMaterialEntergado.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ContratoActual.CODIGO_CONTRATO = "0";
                ContratoActual.ID_AUTOR = "";
                ContratoActual.TITULO_OBRA = "";
                ContratoActual.ID_PRODUCTO = 0;
                ContratoActual.NRO_EJEMPLARES_CONT = 0;
                ContratoActual.NRO_IMPRESIONES = 0;
                ContratoActual.VALOR_CONTRATO = 0;
                ContratoActual.ID_MONEDA = "";
                ContratoActual.FECHA_ENTREGA_TEXTOS = System.DateTime.Now;
                ContratoActual.OBSERVACION = "";
                ContratoActual.FIRMA_TEXTOS = "";
                ContratoActual.PAGO_ADELANTADO = "";
                ContratoActual.FECHA_PAGO = System.DateTime.Now;
                ContratoActual.VALOR_PAGO = 0;
                Form childForm = new frmEditContratos();
                //childForm.MdiParent = this;
                childForm.ShowDialog();
                if (ContratoActual.ACTION == "OK")
                {
                    maestro.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                    maestro.ID_AUTOR = ContratoActual.ID_AUTOR;
                    maestro.TITULO_OBRA = ContratoActual.TITULO_OBRA;
                    maestro.ID_PRODUCTO = ContratoActual.ID_PRODUCTO;
                    maestro.NRO_EJEMPLARES_CONT = ContratoActual.NRO_EJEMPLARES_CONT;
                    maestro.NRO_IMPRESIONES = ContratoActual.NRO_IMPRESIONES;
                    maestro.VALOR_CONTRATO = ContratoActual.VALOR_CONTRATO;
                    maestro.ID_MONEDA = ContratoActual.ID_MONEDA;
                    maestro.FECHA_ENTREGA_TEXTOS = ContratoActual.FECHA_ENTREGA_TEXTOS;
                    maestro.OBSERVACION = ContratoActual.OBSERVACION;
                    maestro.FIRMA_TEXTOS = ContratoActual.FIRMA_TEXTOS;
                    maestro.PAGO_ADELANTADO = ContratoActual.PAGO_ADELANTADO;
                    maestro.FECHA_PAGO = ContratoActual.FECHA_PAGO;
                    maestro.VALOR_PAGO = ContratoActual.VALOR_PAGO;
                    maestro.ERRORES = "";
                    maestro.CrearContratos(maestro);
                    MessageBox.Show(@"Se a creado un nuevo registro! ");
                    MuestraDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //ClienteActual.ID_PRODUCTO = Convert.ToInt16(dgMaterialEntergado.Rows[dgMaterialEntergado.CurrentCell.RowIndex].Cells[0].Value.ToString());
                ContratoActual.CODIGO_CONTRATO = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                ContratoActual.TITULO_OBRA = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                ContratoActual.ID_PRODUCTO = 0;
                ContratoActual.NRO_EJEMPLARES_CONT = int.Parse(dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[2].Value.ToString());
                ContratoActual.NRO_IMPRESIONES = int.Parse(dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[3].Value.ToString());
                ContratoActual.VALOR_CONTRATO = float.Parse(dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[4].Value.ToString());
                if (dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[5].Value.ToString() == "SOL")
                {
                    ContratoActual.ID_MONEDA = "S";
                }
                else
                {
                    ContratoActual.ID_MONEDA = "D";      
                }
                ContratoActual.FECHA_ENTREGA_TEXTOS = DateTime.Parse( dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[6].Value.ToString());
                ContratoActual.OBSERVACION = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[7].Value.ToString();
                if (dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[8].Value.ToString() == "SI")
                {
                    ContratoActual.FIRMA_TEXTOS = "1";
                }
                else
                {
                    ContratoActual.FIRMA_TEXTOS = "0";
                }
                if (dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[9].Value.ToString() == "SI")
                {
                    ContratoActual.PAGO_ADELANTADO = "1";
                }
                else
                {
                    ContratoActual.PAGO_ADELANTADO = "0";
                }
                ContratoActual.FECHA_PAGO = DateTime.Parse(dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[10].Value.ToString());
                ContratoActual.VALOR_PAGO = float.Parse(dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[11].Value.ToString());
                Form childForm = new frmEditContratos();
                //childForm.MdiParent = this;
                childForm.ShowDialog();
                if (ContratoActual.ACTION == "OK")
                {
                    maestro.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                    maestro.ID_AUTOR = ContratoActual.ID_AUTOR;
                    maestro.TITULO_OBRA = ContratoActual.TITULO_OBRA;
                    maestro.ID_PRODUCTO = ContratoActual.ID_PRODUCTO;
                    maestro.NRO_EJEMPLARES_CONT = ContratoActual.NRO_EJEMPLARES_CONT;
                    maestro.NRO_IMPRESIONES = ContratoActual.NRO_IMPRESIONES;
                    maestro.VALOR_CONTRATO = ContratoActual.VALOR_CONTRATO;
                    maestro.ID_MONEDA = ContratoActual.ID_MONEDA;
                    maestro.FECHA_ENTREGA_TEXTOS = ContratoActual.FECHA_ENTREGA_TEXTOS;
                    maestro.OBSERVACION = ContratoActual.OBSERVACION;
                    maestro.FIRMA_TEXTOS = ContratoActual.FIRMA_TEXTOS;
                    maestro.PAGO_ADELANTADO = ContratoActual.PAGO_ADELANTADO;
                    maestro.FECHA_PAGO = ContratoActual.FECHA_PAGO;
                    maestro.VALOR_PAGO = ContratoActual.VALOR_PAGO;
                    maestro.ERRORES = "";
                    maestro.UpdateContratos(maestro);
                    MessageBox.Show(@"Se a modificado el registro seleccionado!");
                    MiDataSet.Tables.Remove(Maestro);
                    MiDataSet.Tables.Remove(Detalle);
                    Maestro.Clear();
                    Detalle.Clear();
                    MuestraDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result1 = MessageBox.Show("Esta seguro de Eliminar el Registro Seleccionado ?",
                "Important Question", MessageBoxButtons.YesNo);
                 if (result1 == DialogResult.Yes )
                 {
                    maestro.CODIGO_CONTRATO = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    maestro.ERRORES = "";
                    maestro.DeleteContratos(maestro);
                    MessageBox.Show(@"Se a Eliminado el registro seleccionado!");
                    MiDataSet.Tables.Remove(Maestro);
                    MiDataSet.Tables.Remove(Detalle);
                    Maestro.Clear();
                    Detalle.Clear();
                    MuestraDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + maestro.ERRORES);
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoActual.CODIGO_CONTRATO = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Form childFormIngresos = new frmIngresos();
                childFormIngresos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dg_Contratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                ContratoActual.CODIGO_CONTRATO = dg_Contratos.Rows[dg_Contratos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                Form childFormSalidas = new frmSalidas();
                childFormSalidas.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
