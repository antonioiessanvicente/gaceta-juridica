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
    public partial class frmVerDetalleDocumentos : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores ParmetrosDocumentos = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private DataTable MaestroDocumentos = new DataTable();
        private DataTable ListaDocumentos = new DataTable();
        DataSet MiDataSetImagenes = new DataSet();
        private IDataReader ReadQuery;
        private DataTable dt_NRO_SERIE;
        private double TotalRegistros;
        private double RegistroActual;
        private string Tipo_Documento;
        private string Numero_serie;
        private string Numero_Doc;
        private int intAmbito;

        public frmVerDetalleDocumentos()
        {
            InitializeComponent();
        }

        private void frmVerDetalleDocumentos_Load(object sender, EventArgs e)
        {
            intAmbito = 0;
            Principal.intVentanas++;
            // Principal.CLAVE = dgvBusquedas.CurrentRow.Cells[4].Value.ToString();
            try
            {
                Tipo_Documento = Principal.TIPO_DOCUMENTO;
                Numero_serie = "";
                Numero_Doc = "";
                switch (Tipo_Documento)
                {
                    case "03":
                        this.Text = "Guias";
                        break;
                    case "04":
                        this.Text = "Orden Salida";
                        break;
                    case "09":
                        this.Text = "Reingreso";
                        break;
                    case "20":
                        this.Text = "Registro Entrega";
                        break;
                }
                panel2.Enabled = false;
                panel3.Enabled = false;
                Muestra_RegistroActual(-1);
                ParmetrosDocumentos.COD_DOC = Tipo_Documento;
                ParmetrosDocumentos.COD_EMPRESA = Principal.strCodEmpresa;
                dt_NRO_SERIE = ParmetrosDocumentos.OpenDataSeries(ParmetrosDocumentos);
                cbSerie.DataSource = dt_NRO_SERIE;
                cbSerie.DisplayMember = "DET_SERIE";
                cbSerie.ValueMember = "NRO_SERIE";
                //cbSerie.SelectedValue = "";
                if (dt_NRO_SERIE.Rows.Count > 0)
                {
                    cbSerie.SelectedValue = dt_NRO_SERIE.Rows[0].ItemArray[0];
                    cbSerie.Enabled = true;
                    Numero_serie = dt_NRO_SERIE.Rows[0].ItemArray[0].ToString();
                    ParmetrosDocumentos.NRO_SERIE = Numero_serie;
                    ListaDocumentos = ParmetrosDocumentos.GetNroDocumentos(ParmetrosDocumentos);
                    TotalRegistros = ListaDocumentos.Rows.Count - 1;
                    RegistroActual = TotalRegistros;
                    Muestra_RegistroActual(RegistroActual);
                    Controles(2);
                }
                else
                {
                    cbSerie.Enabled = false;
                    if (Principal.CLAVE.ToString().Length != 0)
                    {
                        Controles(1);
                        Muestra_RegistroActual(0);
                    }

                }
                intAmbito = 1;
            }
            catch (Exception ex)
            {
                ReadQuery.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            Controles(3);
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            Controles(2);
        }

        private void cbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Para cada Serie de comprobante
            if (intAmbito == 1)
            {
                if (Principal.CLAVE.ToString().Length == 0)
                {
                    ParmetrosDocumentos.COD_DOC = Tipo_Documento;
                    if (cbSerie.SelectedValue.ToString().Length == 3)
                    {
                        Numero_serie = cbSerie.SelectedValue.ToString();
                        ParmetrosDocumentos.NRO_SERIE = Numero_serie;
                        ListaDocumentos = ParmetrosDocumentos.GetNroDocumentos(ParmetrosDocumentos);
                        TotalRegistros = ListaDocumentos.Rows.Count - 1;
                        RegistroActual = TotalRegistros;
                        Muestra_RegistroActual(RegistroActual);
                    }
                    else
                    {
                        Muestra_RegistroActual(-1);
                    }
                }
            }
        }

        private void cmdFirts_Click(object sender, EventArgs e)
        {
            RegistroActual = 0;
            Muestra_RegistroActual(RegistroActual);
        }

        private void cmdLast_Click(object sender, EventArgs e)
        {
            RegistroActual = TotalRegistros;
            Muestra_RegistroActual(RegistroActual);
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            if (RegistroActual < TotalRegistros)
            {
                RegistroActual = RegistroActual + 1;
                Muestra_RegistroActual(RegistroActual);
            }
            else
            {
                RegistroActual = 0;
                Muestra_RegistroActual(RegistroActual);
            }
        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            if (RegistroActual > 0)
            {
                RegistroActual = RegistroActual - 1;
                Muestra_RegistroActual(RegistroActual);
            }
            else
            {
                RegistroActual = TotalRegistros;
                Muestra_RegistroActual(RegistroActual);
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (intAmbito == 1)
            {
                Muestra_RegistroActual(-1);
                //intAmbito = 1;
                if (txtNumero.Text.ToString().Length == 7)
                { // Muestar el Detalle

                    int NroRegistro = Existe_nro_Doc(txtNumero.Text);
                    if (NroRegistro == -1)
                    {
                        MessageBox.Show("No existe informacion sobre el Nro de Comprobante ingresado");
                        RegistroActual = TotalRegistros;
                        Muestra_RegistroActual(RegistroActual);
                    }
                    else
                    {
                        RegistroActual = NroRegistro;
                        // UBICAR LA FILA ACTUAL
                        Muestra_RegistroActual(RegistroActual);

                    }
                }
                else
                {
                    Muestra_RegistroActual(-1);
                }
            }
        }

        private void txtNumero_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text.ToString().Length > 0)
            {
                if (txtNumero.Text.ToString().Length != 7)
                {
                    txtNumero.Text = ParmetrosDocumentos.Right(("0000000" + txtNumero.Text.ToString()).ToString(), 7);
                }
            }
        }

        private void frmVerDetalleDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.intVentanas--;
        }

        private void Muestra_Detalle_RegistroActual(string ClaveDoc)
        {
            ParmetrosDocumentos.CLAVE = ClaveDoc;
            dbDetalleDocumento.DataSource = ParmetrosDocumentos.OpenDataDocumentos_Det(ParmetrosDocumentos);
            //                DET.ID_NUMERO, DET.ID_PRODUCTO,  PRODUCTOS.DETALLE, DET.CANTIDAD, DET.PRECIO_U, DET.SUB_TOTAL
            DataGridViewColumn COL01 = new DataGridViewColumn();
            COL01 = dbDetalleDocumento.Columns["ID_NUMERO"];
            COL01.ReadOnly = true;
            COL01.Visible = true;
            COL01.HeaderText = "N°";
            COL01.Width = 25;
            COL01.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL02 = new DataGridViewColumn();
            COL02 = dbDetalleDocumento.Columns["ID_PRODUCTO"];
            COL02.ReadOnly = true;
            COL02.Visible = true;
            COL02.HeaderText = "COD";
            COL02.Width = 40;
            COL02.DefaultCellStyle.Format = "####";

            DataGridViewColumn COL03 = new DataGridViewColumn();
            COL03 = dbDetalleDocumento.Columns["DETALLE"];
            COL03.ReadOnly = true;
            COL03.Visible = true;
            COL03.HeaderText = "DETALLE DEL PRODUCTO";
            COL03.Width = 350;

            DataGridViewColumn COL04 = new DataGridViewColumn();
            COL04 = dbDetalleDocumento.Columns["CANTIDAD"];
            COL04.ReadOnly = true;
            COL04.Visible = true;
            COL04.HeaderText = "CANT.";
            COL04.Width = 50;
            COL04.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL05 = new DataGridViewColumn();
            COL05 = dbDetalleDocumento.Columns["PRECIO_U"];
            COL05.ReadOnly = true;
            COL05.Visible = true;
            COL05.HeaderText = "PRECIO U";
            COL05.Width = 80;
            COL05.DefaultCellStyle.Format = "#,##0.00";

            DataGridViewColumn COL06 = new DataGridViewColumn();
            COL06 = dbDetalleDocumento.Columns["SUB_TOTAL"];
            COL06.ReadOnly = true;
            COL06.Visible = true;
            COL06.HeaderText = "SUB_TOTAL";
            COL06.Width = 80;
            COL06.DefaultCellStyle.Format = "#,##0.00";

            DataGridViewColumn COL07 = new DataGridViewColumn();
            COL07 = dbDetalleDocumento.Columns["ID_TIPO_SALIDA"];
            COL07.ReadOnly = true;
            COL07.Visible = true;
            COL07.HeaderText = "C_S";
            COL07.Width = 40;


            DataGridViewColumn COL08 = new DataGridViewColumn();
            COL08 = dbDetalleDocumento.Columns["DETALLE_TIPO_SALIDA"];
            COL08.ReadOnly = true;
            COL08.Visible = true;
            COL08.HeaderText = "CONCEPTO DE SALIDA";
            COL08.Width = 150;

        }

        private void Controles(int valor)
        {
            switch (valor)
            {
                case 1:
                    tsbNew.Enabled = false;
                    tsbUndo.Enabled = false;
                    tsbSave.Enabled = false;
                    tsbPrint.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbPrintSeries.Enabled = false;
                    tsbClose.Enabled = true;
                    panel5.Enabled = false;
                    panel2.Enabled = false;
                    break;
                case 2:
                    tsbNew.Enabled = true;
                    tsbUndo.Enabled = false;
                    tsbSave.Enabled = false;
                    tsbPrint.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbPrintSeries.Enabled = true;
                    tsbClose.Enabled = true;
                    panel5.Enabled = true;
                    panel2.Enabled = true;
                    cbSerie.Enabled = true;
                    txtNumero.Enabled = true;
                    dtpFecha.Enabled = false;
                    break;
                case 3:
                    tsbNew.Enabled = false;
                    tsbUndo.Enabled = true;
                    tsbSave.Enabled = true;
                    tsbPrint.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbPrintSeries.Enabled = false;
                    tsbClose.Enabled = false;
                    panel5.Enabled = false;
                    panel2.Enabled = true;
                    cbSerie.Enabled = false;
                    txtNumero.Enabled = true;
                    dtpFecha.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void Muestra_RegistroActual(double Registro_Actual)
        {
            if (Registro_Actual == -1)
            {
                if (intAmbito == 0)
                {
                    txtNumero.Text = "";
                }
                dtpFecha.Value = DateTime.Now;
                txtCodCliente.Text = "";
                txtNomCli.Text = "";
                txtDirCli.Text = "";
                txtDirCliEnt.Text = "";
                txtCodVend.Text = "";
                txtNombVend.Text = "";
                txtOtros.Text = "";
                txtReferencia.Text = "";
                txtSubTotal.Text = "0.00";
                txtTotalNeto.Text = "0.00";
                txtTotalIGV.Text = "0.00";
                txtTotalBruto.Text = "0.00";
                txtPorcIGV.Text = "0.00";
                txtPorcDcto.Text = "0.00";
                txtValDcto.Text = "0.00";
                txtSinValComerc.Text = "0.00";
                txtNrosEnLetras.Text = "";
                rbtSoles.Checked = true;
                rbtDolares.Checked = false;
                Muestra_Detalle_RegistroActual(Tipo_Documento);
                // intAmbito = 0;
            }
            else
            {
                if (Principal.CLAVE.ToString().Length == 0)
                {
                    DataRow row = ListaDocumentos.Rows[(int)Registro_Actual];

                    Numero_Doc = row.ItemArray[0].ToString();
                    txtNumero.Text = Numero_Doc;
                    ParmetrosDocumentos.COD_DOC = Tipo_Documento;
                    ParmetrosDocumentos.NRO_SERIE = Numero_serie;
                    ParmetrosDocumentos.NUMERO_DOC = Numero_Doc;
                }
                else
                {
                    txtNumero.Text = Numero_Doc;
                    ParmetrosDocumentos.COD_DOC = Principal.CLAVE.ToString().Substring(0, 2);
                    ParmetrosDocumentos.NRO_SERIE = (Principal.CLAVE.ToString().Substring(0, 6)).Substring(3, 3);
                    ParmetrosDocumentos.NUMERO_DOC = Principal.CLAVE.ToString().Substring(7, 7);
                }
                IDataReader Datos_cab = ParmetrosDocumentos.OpenGetdataCabecera(ParmetrosDocumentos);
                while (Datos_cab.Read())
                {
                    dtpFecha.Value = Convert.ToDateTime(Datos_cab["FECHA_EMISION"].ToString());
                    txtCodCliente.Text = Datos_cab["ID_CLIENTE"].ToString();
                    txtNomCli.Text = Datos_cab["NOMBRE_RAZON_SOCIAL"].ToString();
                    txtDirCli.Text = Datos_cab["DIRECCION"].ToString();
                    txtDirCliEnt.Text = Datos_cab["DIRECCION_ENTREGA"].ToString();
                    txtCodVend.Text = Datos_cab["ID_VENDEDOR"].ToString();
                    txtNombVend.Text = Datos_cab["NOMBRE_VENDEDOR"].ToString();
                    txtOtros.Text = Datos_cab["ORDEN_COMPRA"].ToString();
                    txtReferencia.Text = Datos_cab["REFERENCIA"].ToString();
                    if (Datos_cab["ID_MONEDA"].ToString() == "S")
                    {
                        rbtSoles.Checked = true;
                        rbtDolares.Checked = false;
                    }
                    else
                    {
                        rbtSoles.Checked = false;
                        rbtDolares.Checked = true;
                    }
                    if (Datos_cab["ESTADO_DOC"].ToString() == "A")
                    {
                        txtSituacion.Text = "VIGENTE";
                        txtSituacion.BackColor = Color.Green;
                    }
                    else
                    {
                        txtSituacion.Text = "ANULADO";
                        txtSituacion.BackColor = Color.Red;
                    }

                    txtSubTotal.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_GENERAL"].ToString()));
                    txtTotalNeto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_NETO"].ToString()));
                    txtTotalIGV.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_IGV_VALOR"].ToString()));
                    txtTotalBruto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_BRUTO"].ToString()));
                    txtPorcIGV.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_IGV_PORCENTAJE"].ToString()));
                    txtPorcDcto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_DOC_PORCENTAJE"].ToString()));
                    txtValDcto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_DOC_VALOR"].ToString()));
                    txtSinValComerc.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_DCTO_SIN_VALOR"].ToString()));
                    txtNrosEnLetras.Text = Datos_cab["NRO_EN_LETRAS"].ToString();
                }
                Datos_cab.Close();
                Muestra_Detalle_RegistroActual(Tipo_Documento + "-" + ParmetrosDocumentos.NRO_SERIE + "-" + ParmetrosDocumentos.NUMERO_DOC);
            }
        }

        private int Existe_nro_Doc(string Nro_doc)
        {
            int Filas = -1;
            if (intAmbito == 1)
            {
                int nVeces = 0;
                foreach (DataRow r in ListaDocumentos.Rows)
                {
                    if (r[0].ToString() == Nro_doc.ToString())
                    {
                        Filas = nVeces;
                        break;
                    }
                    nVeces = nVeces + 1;
                }
            }
            else
            {
                Filas = 0;
            }
            return Filas;
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtNumero.Text.ToString().Length > 0)
                {
                    if (txtNumero.Text.ToString().Length != 7)
                    {
                        txtNumero.Text = ParmetrosDocumentos.Right(("0000000" + txtNumero.Text.ToString()).ToString(), 7);
                    }
                }
            }
        }
    }
}
