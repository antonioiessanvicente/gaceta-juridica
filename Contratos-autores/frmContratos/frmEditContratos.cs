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
   
    public partial class frmEditContratos : Form
    {
        private Maestro maestro1 = new Maestro();
        public frmEditContratos()
        {
            InitializeComponent();
        }

        private void frmEditContratos_Load(object sender, EventArgs e)
        {
            try
            {
                if (ContratoActual.CODIGO_CONTRATO.ToString() == "0")
                {
                    button2.Enabled=false;
                    button1.Enabled = false;
                }
                maestro1.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                maestro1.ERRORES = "";
                //AccesoDatos.Conexion.IniciarSesion(".", "juridica");
                //comboBox1.SelectedValue = ContratoActual.ID_AUTOR;
                textBox1.Text = ContratoActual.TITULO_OBRA;
                textBox2.Text = ContratoActual.NRO_EJEMPLARES_CONT.ToString();
                textBox4.Text = ContratoActual.NRO_IMPRESIONES.ToString();
                if (ContratoActual.ID_MONEDA == "S" )
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                textBox3.Text = ContratoActual.VALOR_CONTRATO.ToString();
                dateTimePicker1.Value = ContratoActual.FECHA_ENTREGA_TEXTOS;

                if (ContratoActual.FIRMA_TEXTOS == "1" )
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                if (ContratoActual.PAGO_ADELANTADO == "1")
                {
                    checkBox2.Checked = true;
                    dateTimePicker2.Value = ContratoActual.FECHA_PAGO;
                    textBox6.Text = ContratoActual.VALOR_PAGO.ToString();
                    dateTimePicker2.Enabled = true;
                    textBox6.Enabled = true;
                }
                else
                {
                    checkBox2.Checked = false;
                    dateTimePicker2.Value = ContratoActual.FECHA_PAGO;
                    textBox6.Text = ContratoActual.VALOR_PAGO.ToString();
                    dateTimePicker2.Enabled = false;
                    textBox6.Enabled = false;
                }
                MuestraAutores();
                MuestraProductos();
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MuestraProductos()
        {
            try
            {
                dg_productos.DataSource = maestro1.LeeProductosPorContrato(maestro1);
                dg_productos.Refresh();

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dg_productos.Columns["ID_PRODUCTO"];
                COL01.Width = 60;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "CODIGO";
                //COL04.DefaultCellStyle.Format = "dd-MMM-yy";
                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dg_productos.Columns["DETALLE"];
                COL02.Width = 320;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "DETALLE DEL PRODUCTO";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void MuestraAutores()
        {
            try
            {
                dg_Contratos.DataSource = maestro1.LeeAutoresPorContrato(maestro1);
                dg_Contratos.Refresh();
                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dg_Contratos.Columns["ID_AUTOR"];
                COL01.Width = 60;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "CODIGO";
                //COL04.DefaultCellStyle.Format = "dd-MMM-yy";
                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dg_Contratos.Columns["NOMBRE_AUTOR"];
                COL02.Width = 320;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "NOMBRE DEL AUTOR";
                // DataGrid1.Rows.Count
                if (dg_Contratos.Rows.Count  > 0) 
                {
                    ts_autores_clientes.Visible = true;
                }
                else

                {
                    ts_autores_clientes.Visible = false;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void cmdAcept_Click(object sender, EventArgs e)
        {
            // ContratoActual.ID_AUTOR = comboBox1.SelectedValue.ToString();
            ContratoActual.TITULO_OBRA = textBox1.Text;
            ContratoActual.NRO_EJEMPLARES_CONT = int.Parse(textBox2.Text);
            ContratoActual.NRO_IMPRESIONES = int.Parse(textBox4.Text);
            if (radioButton1.Checked == true)
            {
                ContratoActual.ID_MONEDA = "S";
            }
            else
            {
                ContratoActual.ID_MONEDA = "D";
            }
            ContratoActual.VALOR_CONTRATO = float.Parse(textBox3.Text);
            ContratoActual.FECHA_ENTREGA_TEXTOS = dateTimePicker1.Value;
            if (checkBox1.Checked == true)
            {
                ContratoActual.FIRMA_TEXTOS = "1";
            }
            else
            {
                ContratoActual.FIRMA_TEXTOS = "0";
            }

            if (checkBox2.Checked == true)
            {
                ContratoActual.PAGO_ADELANTADO = "1";
                ContratoActual.FECHA_PAGO = dateTimePicker2.Value;
                ContratoActual.VALOR_PAGO = float.Parse(textBox6.Text);
            }
            else
            {
                ContratoActual.PAGO_ADELANTADO = "0";
                ContratoActual.FECHA_PAGO = System.DateTime.Now;
                ContratoActual.VALOR_PAGO = 0;
            }
            ContratoActual.ACTION = "OK";
            this.Hide();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            ContratoActual.ACTION = "CANCEL";
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                dateTimePicker2.Enabled = false;
                textBox6.Enabled = false;
            }
            else
            {
                dateTimePicker2.Enabled = true;
                textBox6.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAutores = new frmAutores();
            frmAutores.ShowDialog();
            MuestraAutores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm_Productos = new frmProductos();
            frm_Productos.ShowDialog();
            MuestraProductos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm_AutorCliente = new frmAsociarAutorCliente();
            frm_AutorCliente.ShowDialog();
        }


    }
}
