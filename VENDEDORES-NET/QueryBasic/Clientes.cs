using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QueryBasic
{
    public partial class Clientes : Form
    {
        protected DataSet ClientesData = new DataSet();
        protected BorderStyle DefaultGridBorderStyle;
        private BindingSource BindingSource1 = new BindingSource();
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ResetDemo();
            if (EjecutivoActual.id_vendedor != "")
            {
                BindDataGrid();
                FormatGridWithTableStyles();
            }
            else
            {
                MessageBox.Show("NO EXISTE INFORMACION DEL EJECUTIVO, SELECCIONE ALGUN EJECUTIVO DE VENTAS");
            }
        }
        private void BindDataGrid()
        {
            // Display a status message saying that we're attempting to connect.
            // This only needs to be done the very first time a connection is
            // attempted.  After we've determined that MSDE or SQL Server is
            // installed, this message no longer needs to be displayed.

            frmStatus frmStatusMessage = new frmStatus();
            frmStatusMessage.Show("Connecting to SQL Server of GACETA JURIDICA");
            // Attempt to connect to the local SQL server instance, and a local
            // MSDE installation (with Northwind).  

            bool IsConnecting = true;

            while (IsConnecting)
            {
                try
                {

                    // The SqlConnection class allows you to communicate with SQL Server.
                    // The constructor accepts a connection string an argument.  This
                    // connection string uses Integrated Security, which means that you 
                    // must have a login in SQL Server, or be part of the Administrators
                    // group for this to work.

                    SqlConnection comercialConnection = new SqlConnection(Conection.conectionstring);
                    SqlDataAdapter ClientesAdapter = new SqlDataAdapter(
                        "SELECT id_cliente, CLIENTE = RTRIM(LTRIM(nombre_razon_social))+' '+RTRIM(LTRIM(APELLIDO_P))+' '+RTRIM(LTRIM(APELLIDO_M)), Direccion, CONTACTO, EMAIL, TELEFONO_01, TELEFONO_02, MOVIL_01, DIRECCION_ENTREGA FROM clientes where id_vendedor = '" + EjecutivoActual.id_vendedor + "'", comercialConnection);
                    ClientesAdapter.Fill(ClientesData, "clientes");

                    // Data has been successfully retrieved, so break out of the loop.

                    IsConnecting = false;
                }
                catch
                {
                        // Unable to connect to SQL Server or MSDE
                        frmStatusMessage.Close();
                        MessageBox.Show("To run this Aplication, you must have conection to SERVER DATA; " +
                        "For instructions, contact to Suport Tecnic from 'GACETA JURIDICA'.");
                        Application.Exit();
                }
            }
            frmStatusMessage.Close();
            BindingSource1.DataSource = ClientesData.Tables["clientes"];
            //dgvMaestro.DataSource = maestro.Buscar();
            dgClientes.MultiSelect = false;
            dgClientes.DataSource = BindingSource1.DataSource;

            //dgClientes.DataSource = ClientesData.Tables["clientes"];
            
        }
        private void FormatGridWithTableStyles()
        {
            dgClientes.BackColor = Color.GhostWhite;
            dgClientes.BackgroundColor = Color.Lavender;
            dgClientes.BorderStyle = BorderStyle.None;
            dgClientes.Font = new Font("Tahoma", (float)8.0);
            DataGridTableStyle grdTableStyle1 = new DataGridTableStyle();
            grdTableStyle1.AlternatingBackColor = Color.GhostWhite;
            grdTableStyle1.BackColor = Color.GhostWhite;
            grdTableStyle1.ForeColor = Color.MidnightBlue;
            grdTableStyle1.GridLineColor = Color.RoyalBlue;
            grdTableStyle1.HeaderBackColor = Color.MidnightBlue;
            grdTableStyle1.HeaderFont = new Font("Tahoma", (float)9.0, FontStyle.Bold);
            grdTableStyle1.HeaderForeColor = Color.Lavender;
            grdTableStyle1.SelectionBackColor = Color.Teal;
            grdTableStyle1.SelectionForeColor = Color.PaleGreen;
            grdTableStyle1.MappingName = "clientes";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }
        private void ResetDemo()
        {
            if (ClientesData.Tables["clientes"] != null)
            {
                ClientesData.Tables["clientes"].Clear();
            }
            dgClientes.BackgroundColor = SystemColors.InactiveCaptionText;
            dgClientes.ResetBackColor();
            dgClientes.ResetForeColor();
            dgClientes.ResetText();
            dgClientes.BorderStyle = DefaultGridBorderStyle;
        }
        private void dgClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClienteActual.Id_cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
            ClienteActual.Nombre_cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            ClienteActual.Direccion_Cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[2].Value.ToString();
            ClienteActual.Email_Cliente = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[4].Value.ToString();
            ClienteActual.Vendedor_Supervisor = dgClientes.Rows[dgClientes.CurrentCell.RowIndex].Cells[3].Value.ToString();
            if (ClienteActual.Id_cliente != "")
            {
                frmSuscripciones frm_Suscripciones = new frmSuscripciones();
                frm_Suscripciones.ShowDialog();
            }
        }

        private void tbEstadosCuenta_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            int ret = Buscar(txtCliente.Text.Trim(), BindingSource1);
     
        }
        public int Buscar(string textoCliente,  BindingSource BindingSource)
        {
            string strFilter;
            if (textoCliente != "")
            {
                strFilter = "[CLIENTE] like '%" + textoCliente.Trim() + "%'";
            }
            else
            {
                strFilter = "[CLIENTE] like '%'";
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
    }
}
