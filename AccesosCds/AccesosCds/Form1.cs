using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccesoDatos;

namespace AccesosCds
{
    public partial class Form1 : Form
    {
        private ReglasNegocio.MaestroActivacionCds ParmetrosDocumentos = new ReglasNegocio.MaestroActivacionCds();
        private DataTable dt_productos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                AccesoDatos.Conexion.IniciarSesion("192.168.0.1", "DATA_DATA","mmendoza","princesa...");

                dt_productos = ParmetrosDocumentos.MostrarProductos();
                cbProductos.DataSource = dt_productos;
                cbProductos.DisplayMember = "NAME_PROD";
                cbProductos.ValueMember = "CODIGO";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }

        }
        private void LimpiaData()
        {
            txtCliente.Text = "";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            panel2.Enabled = false;
        }
        private void cmdValida_Click(object sender, EventArgs e)
        {
             try
            {
            LimpiaData();
            ParmetrosDocumentos.CODIGO_PROD = Convert.ToInt16(cbProductos.SelectedValue.ToString()) ;
            ParmetrosDocumentos.NRO_PIN = txtNroPin.Text ;
            IDataReader Datos_cab = ParmetrosDocumentos.LeerDatos(ParmetrosDocumentos);
            while (Datos_cab.Read())
            {
                txtCliente.Text = Datos_cab["data_nrs"].ToString();
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                dateTimePicker3.Visible = false;
                panel2.Enabled = true;
                if (Convert.ToDouble(Datos_cab["VECES"].ToString()) == 1)
                {
                    dateTimePicker1.Visible = true;
                    dateTimePicker1.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora"].ToString());
                }

                if (Convert.ToDouble(Datos_cab["VECES"].ToString()) == 2)
                {
                    dateTimePicker1.Visible = true;
                    dateTimePicker1.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora"].ToString());
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora2"].ToString());
                }

                if (Convert.ToDouble(Datos_cab["VECES"].ToString()) == 3)
                {
                    dateTimePicker1.Visible = true;
                    dateTimePicker1.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora"].ToString());
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora2"].ToString());
                    dateTimePicker3.Visible = true;
                    dateTimePicker3.Value = Convert.ToDateTime(Datos_cab["data_fecha_hora3"].ToString());
                }
                
            }
            Datos_cab.Close();
            }
             catch (Exception ex)
             {
                 MessageBox.Show("Error : " + ex.Message.ToString());
             }

        }

        private void cbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiaData();
        }

        private void txtNroPin_TextChanged(object sender, EventArgs e)
        {
            LimpiaData();
        }

        private void cmdDctaUno_Click(object sender, EventArgs e)
        {
            try
            {
                ParmetrosDocumentos.CODIGO_PROD = Convert.ToInt16(cbProductos.SelectedValue.ToString()) ;
                ParmetrosDocumentos.NRO_PIN = txtNroPin.Text;
                ParmetrosDocumentos.CANTIDAD = 1;
                ParmetrosDocumentos.Descontar(ParmetrosDocumentos);
                LimpiaData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }

        }

        private void cmdDctaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                ParmetrosDocumentos.CODIGO_PROD = Convert.ToInt16(cbProductos.SelectedValue.ToString());
                ParmetrosDocumentos.NRO_PIN = txtNroPin.Text;
                ParmetrosDocumentos.CANTIDAD = 0;
                ParmetrosDocumentos.Descontar(ParmetrosDocumentos);
                LimpiaData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }

        }
    }
}
