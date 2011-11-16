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
    public partial class EstadosCuenta : Form
    {
        DataTable SuscripData = new DataTable();
        public EstadosCuenta()
        {
            InitializeComponent();
        }
        private void ActivaControl(int valor)
        {
            switch (valor)
            {
                case 1:
                    txtIem01.Visible = true;
                    txtCuota01.Visible = true;
                    txtFecha01.Visible = true;
                    break;
                case 2:
                    txtIem02.Visible = true;
                    txtCuota02.Visible = true;
                    txtFecha02.Visible = true;
                    break;
                case 3:
                    txtIem03.Visible = true;
                    txtCuota03.Visible = true;
                    txtFecha03.Visible = true;
                    break;
                case 4:
                    txtIem04.Visible = true;
                    txtCuota04.Visible = true;
                    txtFecha04.Visible = true;
                    break;
                case 5:
                    txtIem05.Visible = true;
                    txtCuota05.Visible = true;
                    txtFecha05.Visible = true;
                    break;
                case 6:
                    txtIem06.Visible = true;
                    txtCuota06.Visible = true;
                    txtFecha06.Visible = true;
                    break;
                case 7:
                    txtIem07.Visible = true;
                    txtCuota07.Visible = true;
                    txtFecha07.Visible = true;
                    break;
                case 8:
                    txtIem08.Visible = true;
                    txtCuota08.Visible = true;
                    txtFecha08.Visible = true;
                    break;
                case 9:
                    txtIem09.Visible = true;
                    txtCuota09.Visible = true;
                    txtFecha09.Visible = true;
                    break;
                case 10:
                    txtIem10.Visible = true;
                    txtCuota10.Visible = true;
                    txtFecha10.Visible = true;
                    break;
                case 11:
                    txtIem11.Visible = true;
                    txtCuota11.Visible = true;
                    txtFecha11.Visible = true;
                    break;
                case 12:
                    txtIem12.Visible = true;
                    txtCuota12.Visible = true;
                    txtFecha12.Visible = true;
                    break;
            }

        }
        private void Muestra_valor(int valor, float valores, string fecha)
        {
            switch (valor)
            {
                case 1:
                    txtCuota01.Text = valores.ToString();
                    txtFecha01.Text = fecha.ToString();
                    break;
                case 2:
                    txtCuota02.Text = valores.ToString();
                    txtFecha02.Text = fecha.ToString();
                    break;
                case 3:
                    txtCuota03.Text = valores.ToString();
                    txtFecha03.Text = fecha.ToString();
                    break;
                case 4:
                    txtCuota04.Text = valores.ToString();
                    txtFecha04.Text = fecha.ToString();
                    break;
                case 5:
                    txtCuota05.Text = valores.ToString();
                    txtFecha05.Text = fecha.ToString();
                    break;
                case 6:
                    txtCuota06.Text = valores.ToString();
                    txtFecha06.Text = fecha.ToString();
                    break;
                case 7:
                    txtCuota07.Text = valores.ToString();
                    txtFecha07.Text = fecha.ToString();
                    break;
                case 8:
                    txtCuota08.Text = valores.ToString();
                    txtFecha08.Text = fecha.ToString();
                    break;
                case 9:
                    txtCuota09.Text = valores.ToString();
                    txtFecha09.Text = fecha.ToString();
                    break;
                case 10:
                    txtCuota10.Text = valores.ToString();
                    txtFecha10.Text = fecha.ToString();
                    break;
                case 11:
                    txtCuota11.Text = valores.ToString();
                    txtFecha11.Text = fecha.ToString();
                    break;
                case 12:
                    txtCuota12.Text = valores.ToString();
                    txtFecha12.Text = fecha.ToString();
                    break;
            }

        }
        private void EstadosCuenta_Load(object sender, EventArgs e)
        {
            frmStatus frmStatusMessage = new frmStatus();
            float fDebe = 0;
            float fPago = 0;
            float fDeuda = 0;
            try
            {
                frmStatusMessage.Show("Conectando y validando información on SERVER GACETAJURIDICa");
                SqlConnection comercialConnection = new SqlConnection(Conection.conectionstring);
                SqlDataAdapter LoginAdapter = new SqlDataAdapter("SELECT NRO_CONTRATO, VALOR_SUSCRIPCION,  NRO_CUOTAS, VALOR_01, VALOR_02, VALOR_03, VALOR_04, VALOR_05, VALOR_06, " +
                      " VALOR_07,VALOR_08,VALOR_09,VALOR_10,VALOR_11,VALOR_12,FECHA_01,FECHA_02,FECHA_03,FECHA_04,FECHA_05,FECHA_06,FECHA_07,FECHA_08,FECHA_09,FECHA_10," +
                      " FECHA_11, FECHA_12 From VISTA_SUSCRIPCIONES_NROS_CONTRATOS WHERE ID_CLIENTE = '" + ClienteActual.Id_cliente.ToString() + "' and id_suscripcion = " + ClienteActual.Id_Suscripcion.ToString(), comercialConnection);
                LoginAdapter.Fill(SuscripData);
                if (SuscripData.Rows.Count == 1)
                {
                    txtNroCuotas.Text = SuscripData.Rows[0]["NRO_CUOTAS"].ToString();
                    textBox1.Text = SuscripData.Rows[0]["NRO_CONTRATO"].ToString();
                    textBox2.Text = SuscripData.Rows[0]["VALOR_SUSCRIPCION"].ToString();
                    string fecha="";
                    float valor=0;
                    for (int i = 1; i <= System.Convert.ToInt32(txtNroCuotas.Text); i++)
                    {
                        ActivaControl(i);
                        switch (i)
                        {
                            case 1:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_01"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_01"].ToString());
                                break;
                            case 2:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_02"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_02"].ToString());
                                break;
                            case 3:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_03"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_03"].ToString());
                                break;
                            case 4:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_04"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_04"].ToString());
                                break;
                            case 5:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_05"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_05"].ToString());
                                break;
                            case 6:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_06"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_06"].ToString());
                                break;
                            case 7:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_07"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_07"].ToString());
                                break;
                            case 8:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_08"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_08"].ToString());
                                break;
                            case 9:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_09"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_09"].ToString());
                                break;
                            case 10:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_10"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_10"].ToString());
                                break;
                            case 11:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_11"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_11"].ToString());
                                break;
                            case 12:
                                fecha = DateTime.Parse(SuscripData.Rows[0]["FECHA_12"].ToString()).ToString("ddMMMyy");
                                valor = float.Parse(SuscripData.Rows[0]["VALOR_12"].ToString());
                                break;
                        }
                        fDeuda = fDeuda + valor;
                        Muestra_valor(i, valor, fecha);
                    }
                }
                else
                {
                    MessageBox.Show("No existe bdatos de contartos para este Tipo de Suscripcion");
                }
                //  INCIO::::   VALIDANDO LOS PAGOS DE LOS COMPROBANTES
                try
                {
                    SqlConnection xSqlConnection = new SqlConnection(Conection.conectionstring);
                    // Open the connection
                    //                conn.Open();
                    SqlCommand xSqlCommand = new SqlCommand("dbo.paGetPagosPorCuotas", xSqlConnection);
                    xSqlCommand.CommandType = CommandType.StoredProcedure;
                    xSqlCommand.Parameters.Add("@IDSUSCRIPCION", SqlDbType.Int).Value = int.Parse( ClienteActual.Id_Suscripcion.ToString());
                    xSqlCommand.Parameters.Add("@ID_CLIENTE", SqlDbType.NVarChar).Value = ClienteActual.Id_cliente;
                    xSqlCommand.Connection.Open();
                    SqlDataAdapter xSqlDataAdapter = new SqlDataAdapter(xSqlCommand);
                    DataSet xDataSet = new DataSet();
                    string fecha_e;
                    string fecha_p;
                    xSqlDataAdapter.Fill(xDataSet, "Pagos");
                    for (int i = 0; i < xDataSet.Tables["Pagos"].Rows.Count; i++)
                    {
                        int nro_Cuota = int.Parse(xDataSet.Tables["Pagos"].Rows[i]["NRO_PERIODO"].ToString());
                        fecha_e = DateTime.Parse(xDataSet.Tables["Pagos"].Rows[i]["FECHA_EMISION"].ToString()).ToString("ddMMMyy");
                        fecha_p = DateTime.Parse(xDataSet.Tables["Pagos"].Rows[i]["FECHA_PAGO"].ToString()).ToString("ddMMMyy");
                        fPago = fPago + float.Parse(xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString());
                        switch (nro_Cuota)
                        {
                            case 1:
                                txtDoc01.Visible = true;
                                txtVal01.Visible = true;
                                txtPago01.Visible = true;
                                txtDoc01.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal01.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago01.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 2:
                                txtDoc02.Visible = true;
                                txtVal02.Visible = true;
                                txtPago02.Visible = true;
                                txtDoc02.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal02.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago02.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 3:
                                txtDoc03.Visible = true;
                                txtVal03.Visible = true;
                                txtPago03.Visible = true;
                                txtDoc03.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal03.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago03.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 4:
                                txtDoc04.Visible = true;
                                txtVal04.Visible = true;
                                txtPago04.Visible = true;
                                txtDoc04.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal04.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago04.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 5:
                                txtDoc05.Visible = true;
                                txtVal05.Visible = true;
                                txtPago05.Visible = true;
                                txtDoc05.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal05.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago05.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 6:
                                txtDoc06.Visible = true;
                                txtVal06.Visible = true;
                                txtPago06.Visible = true;
                                txtDoc06.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal06.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago06.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 7:
                                txtDoc07.Visible = true;
                                txtVal07.Visible = true;
                                txtPago07.Visible = true;
                                txtDoc07.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal07.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago07.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 8:
                                txtDoc08.Visible = true;
                                txtVal08.Visible = true;
                                txtPago08.Visible = true;
                                txtDoc08.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal08.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago08.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 9:
                                txtDoc09.Visible = true;
                                txtVal09.Visible = true;
                                txtPago09.Visible = true;
                                txtDoc09.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal09.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago09.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 10:
                                txtDoc10.Visible = true;
                                txtVal10.Visible = true;
                                txtPago10.Visible = true;
                                txtDoc10.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal10.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago10.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 11:
                                txtDoc11.Visible = true;
                                txtVal11.Visible = true;
                                txtPago11.Visible = true;
                                txtDoc11.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal11.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago11.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                            case 12:
                                txtDoc12.Visible = true;
                                txtVal12.Visible = true;
                                txtPago12.Visible = true;
                                txtDoc12.Text = xDataSet.Tables["Pagos"].Rows[i]["CLAVE"].ToString();
                                txtVal12.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_NETO"].ToString() + " - " + fecha_e;
                                txtPago12.Text = xDataSet.Tables["Pagos"].Rows[i]["TOTAL_PAGO"].ToString() + " - " + fecha_p;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //  FIN::::   VALIDANDO LOS PAGOS DE LOS COMPROBANTES
                frmStatusMessage.Close();
                if (fDebe != 0)
                {
                    textBox5.BackColor = Color.FromArgb(255,128,128);
                }
                else
                {
                    textBox5.BackColor = Color.FromArgb(0,192,192);
                }
                fDebe = fDeuda - fPago;
                txtDeuda.Text = fDeuda.ToString();
                txtPago.Text = fPago.ToString();
                txtDebe.Text = fDebe.ToString();
            }
            catch
            {
                frmStatusMessage.Close();
                MessageBox.Show(Conection.error_coneccion);
                this.Hide();
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
