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
    public partial class frmFacturas : Form
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

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
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
                    case "01":
                        this.Text = "Facturas";
                        break;
                    case "02":
                        this.Text = "Boletas";
                        break;
                    case "05":
                        this.Text = "N.de Crédito";
                        break;
                    case "06":
                        this.Text = "N. de Débito";
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

        private void cbSerie_SelectedValueChanged(object sender, EventArgs e)
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

        private void txtNumero_TextChanged_1(object sender, EventArgs e)
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

        private void cmdFirts_Click(object sender, EventArgs e)
        {
            RegistroActual = 0;
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

        private void cmdLast_Click(object sender, EventArgs e)
        {
            RegistroActual = TotalRegistros;
            Muestra_RegistroActual(RegistroActual);
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            Controles(3);
        }

        private void rsUndo_Click(object sender, EventArgs e)
        {
            Controles(2);
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

        private void frmFacturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.intVentanas--;
        }

        private void Muestra_Detalle_RegistroActual(string ClaveDoc)
        {
            ParmetrosDocumentos.CLAVE = ClaveDoc;
            dbDetalleDocumento.DataSource = ParmetrosDocumentos.OpenDataDocumentos_Det(ParmetrosDocumentos);
            //                DET.ID_NUMERO, DET.ID_PRODUCTO,  PRODUCTOS.DETALLE, DET.CANTIDAD, DET.PRECIO_U, DET.SUB_TOTAL
            DataGridViewColumn COL01 = new DataGridViewColumn();
            COL01 = dbDetalleDocumento.Columns["ITEM"];
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
            COL07 = dbDetalleDocumento.Columns["TIPO_MOV"];
            COL07.ReadOnly = true;
            COL07.Visible = true;
            COL07.HeaderText = "C_S";
            COL07.Width = 40;


            DataGridViewColumn COL08 = new DataGridViewColumn();
            COL08 = dbDetalleDocumento.Columns["DETALLE_MOV"];
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
                    tsNew.Enabled = false;
                    tsUndo.Enabled = false;
                    tsSave.Enabled = false;
                    tsPrint.Enabled = false;
                    tsDelete.Enabled = false;
                    tsPrintSerie.Enabled = false;
                    tsClose.Enabled = true;
                    panel5.Enabled = false;
                    panel2.Enabled = false;
                    break;
                case 2:
                    tsNew.Enabled = true;
                    tsUndo.Enabled = false;
                    tsSave.Enabled = false;
                    tsPrint.Enabled = true;
                    tsDelete.Enabled = true;
                    tsPrintSerie.Enabled = true;
                    tsClose.Enabled = true;
                    panel5.Enabled = true;
                    panel2.Enabled = true;
                    cbSerie.Enabled = true;
                    txtNumero.Enabled = true;
                    dtpFecha.Enabled = false;
                    break;
                case 3:
                    tsNew.Enabled = false;
                    tsUndo.Enabled = true;
                    tsSave.Enabled = true;
                    tsPrint.Enabled = false;
                    tsDelete.Enabled = false;
                    tsPrintSerie.Enabled = false;
                    tsClose.Enabled = false;
                    panel5.Enabled = false;
                    panel2.Enabled = true;
                    cbSerie.Enabled = false;
                    txtNumero.Enabled = true;
                    dtpFecha.Enabled = true;
                    BlanquearDatos();
                    break;
                default:
                    break;
            }
        }
        private void BlanquearDatos()
        {
            //dgvDetallePagos.DataSource = "";
            //dbDetalleDocumento.DataSource = "";
            txtNumero.Text = txtNumero.Text;

            LimpiarDatos();
            Muestra_Detalle_RegistroActual("02-001-xxxxxxx");
        }
        private void LimpiarDatos()
        {
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
            txtFamilia.Text = "";
            rbtSoles.Checked = true;
            rbtDolares.Checked = false;
        }
        private void Muestra_RegistroActual(double Registro_Actual)
        {
            Double Total_Documento = 0;
            string strEstado = "";
            if (Registro_Actual == -1)
            {
                if (intAmbito == 0)
                {
                    txtNumero.Text = "";
                }
                LimpiarDatos();
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
                    strEstado = Datos_cab["ESTADO_DOC"].ToString();
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

                    txtTotalNeto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_BRUTO"].ToString()));
                    txtTotalIGV.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_IGV_VALOR"].ToString()));
                    txtTotalBruto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_NETO"].ToString()));

                    Total_Documento = Convert.ToDouble(Datos_cab["TOTAL_NETO"].ToString());

                    txtPorcIGV.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_IGV_PORCENTAJE"].ToString()));
                    txtPorcDcto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_DOC_PORCENTAJE"].ToString()));
                    txtValDcto.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["DCTO_DOC_VALOR"].ToString()));
                    txtSinValComerc.Text = String.Format("{0:,0.00}", Convert.ToDouble(Datos_cab["TOTAL_DCTO_SIN_VALOR"].ToString()));
                    txtNrosEnLetras.Text = Datos_cab["NRO_EN_LETRAS"].ToString();
                    txtFamilia.Text = "FAMILIA : " + Datos_cab["DETALLE_FAMILIA"].ToString();
                }
                Datos_cab.Close();
                Detalle_Pagos(Tipo_Documento + "-" + ParmetrosDocumentos.NRO_SERIE + "-" + ParmetrosDocumentos.NUMERO_DOC, Total_Documento, strEstado);
                Muestra_Detalle_RegistroActual(Tipo_Documento + "-" + ParmetrosDocumentos.NRO_SERIE + "-" + ParmetrosDocumentos.NUMERO_DOC);
            }
        }

        private void Detalle_Pagos(string Clave_Doc, Double Total_Doc, string str_Estado)
        {
            try
            {
                double Total = 0;
                ParmetrosDocumentos.CLAVE = Clave_Doc;
                dgvDetallePagos.DataSource = ParmetrosDocumentos.OpenDetallePagos(ParmetrosDocumentos);
                DataGridViewColumn COL00 = new DataGridViewColumn();
                COL00 = dgvDetallePagos.Columns["COD"];
                COL00.Width = 60;
                COL00.HeaderText = "COD";

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dgvDetallePagos.Columns["Fecha_Pago"];
                COL01.HeaderText = "FECHA E";
                COL01.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL01.Width = 80;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dgvDetallePagos.Columns["MON"];
                COL02.Width = 35;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL02.HeaderText = "MON";

                DataGridViewColumn COL03 = new DataGridViewColumn();
                COL03 = dgvDetallePagos.Columns["TP"];
                COL03.Width = 35;
                COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL03.HeaderText = "TP";

                DataGridViewColumn COL04 = new DataGridViewColumn();
                COL04 = dgvDetallePagos.Columns["VALOR_PAGO"];
                COL04.Width = 80;
                COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL04.HeaderText = "PAGOS";
                COL04.DefaultCellStyle.Format = "#,##0.00";

                DataGridViewColumn COL05 = new DataGridViewColumn();
                COL05 = dgvDetallePagos.Columns["NRO_PLANILLA"];
                COL05.ReadOnly = true;
                COL05.Visible = true;
                COL05.HeaderText = "N°PLANI.";
                COL05.Width = 80;

                DataGridViewColumn COL06 = new DataGridViewColumn();
                COL06 = dgvDetallePagos.Columns["NRO_CHEQLET"];
                COL06.ReadOnly = true;
                COL06.Visible = true;
                COL06.HeaderText = "N° CH/LT";
                COL06.Width = 80;

                DataGridViewColumn COL07 = new DataGridViewColumn();
                COL07 = dgvDetallePagos.Columns["FECHA_EMISION"];
                COL07.HeaderText = "FECHA E";
                COL07.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL08 = new DataGridViewColumn();
                COL08 = dgvDetallePagos.Columns["FECHA_VENCIMIENTO"];
                COL08.HeaderText = "FECHA V";
                COL08.DefaultCellStyle.Format = "dd-MMM-yyyy";
                COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL09 = new DataGridViewColumn();
                COL09 = dgvDetallePagos.Columns["ID_BANCO"];
                COL09.HeaderText = "COD BCO";
                COL09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL10 = new DataGridViewColumn();
                COL10 = dgvDetallePagos.Columns["ID_CLIENTE"];
                COL10.HeaderText = "COD CLIE";
                COL10.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL11 = new DataGridViewColumn();
                COL11 = dgvDetallePagos.Columns["REFERENCIA"];
                COL11.HeaderText = "REF";
                COL11.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL12 = new DataGridViewColumn();
                COL12 = dgvDetallePagos.Columns["NOMBRE_BANCO"];
                COL12.HeaderText = "BANCO";
                COL12.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL13 = new DataGridViewColumn();
                COL13 = dgvDetallePagos.Columns["DETALLE_CUENTA"];
                COL13.HeaderText = "DETALLE";
                COL13.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL14 = new DataGridViewColumn();
                COL14 = dgvDetallePagos.Columns["LOCALIDAD"];
                COL14.HeaderText = "LOCALIDAD";
                COL14.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL15 = new DataGridViewColumn();
                COL15 = dgvDetallePagos.Columns["NOMBRE_TIPO_PLANILLA"];
                COL15.HeaderText = "TIPO PLANILLA";
                COL15.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL15.Width = 120;
 
                DataGridViewColumn COL16 = new DataGridViewColumn();
                COL16 = dgvDetallePagos.Columns["NUMERO_ING_CAJA"];
                COL16.HeaderText = "N° IC";
                COL16.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL17 = new DataGridViewColumn();
                COL17 = dgvDetallePagos.Columns["IDCLAVE"];
                COL17.HeaderText = "CLAVE 1";
                COL17.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL18 = new DataGridViewColumn();
                COL18 = dgvDetallePagos.Columns["CLAVE_DEP"];
                COL18.HeaderText = "CLAVE DEP";
                COL18.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewColumn COL19 = new DataGridViewColumn();
                COL19 = dgvDetallePagos.Columns["USUARIO_SISTEMA"];
                COL19.HeaderText = "USER SYSTEM";
                COL19.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL19.Width = 160;

                DataGridViewColumn COL20 = new DataGridViewColumn();
                COL20 = dgvDetallePagos.Columns["FECHA_SISTEMA"];
                COL20.HeaderText = "DATE SYSTEM";
                COL20.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL20.Width = 120;


                Int32 i;
                DataGridViewCell dgc;
                //Recorremos el DataGridView con un bucle for
                for (i = 0; i < dgvDetallePagos.Rows.Count; i++)
                {
                    dgc = dgvDetallePagos.Rows[i].Cells[4];
                    Total += Convert.ToDouble(dgc.Value.ToString());
                }

                if (str_Estado == "I")
                {
                    txtSaldos02.Text = "";
                }
                else
                {
                    txtSaldos02.Text = String.Format("{0:,0.00}", Total_Doc - Total);
                    if ((Total_Doc - Total) == 0)
                    {
                        txtSaldos02.BackColor = Color.Cyan;
                    }
                    else
                    {
                        txtSaldos02.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

    }
}
