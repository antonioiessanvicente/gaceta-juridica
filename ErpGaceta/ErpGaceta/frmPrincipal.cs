using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AccesoDatos;
using System.Linq;

namespace ErpGaceta
{
    public partial class frmPrincipal : Form
    {


        
        Form frm_Dist_Dist;
        Form frm_Busquedas;
        Form frm_Factura;
        Form frm_Boleta;
        Form frm_NotasCredito;
        Form frm_NotasDebito;

        Form frm_Guias;
        Form frm_OrdSal;
        Form frm_Reingreso;
        Form frm_RegEntrega;
        Form frm_Cobranzas;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void OpenfrmOrdSal()
        {
            if (!this.MdiChildren.Contains(frm_OrdSal))
            {
                frm_OrdSal = new frmVerDetalleDocumentos();
                frm_OrdSal.MdiParent = this;
                frm_OrdSal.Show();
            }
            else
            { frm_OrdSal.Focus(); }
        }

        private void OpenfrmGuias()
        {
            if (!this.MdiChildren.Contains(frm_Guias))
            {
                frm_Guias = new frmVerDetalleDocumentos();
                frm_Guias.MdiParent = this;
                frm_Guias.Show();
            }
            else
            { frm_Guias.Focus(); }
        }

        private void OpenReingreso()
        {
            if (!this.MdiChildren.Contains(frm_Reingreso))
            {
                frm_Reingreso = new frmVerDetalleDocumentos();
                frm_Reingreso.MdiParent = this;
                frm_Reingreso.Show();
            }
            else
            { frm_Reingreso.Focus(); }
        }

        private void OpenRegistroEntrega()
        {
            if (!this.MdiChildren.Contains(frm_RegEntrega))
            {
                frm_RegEntrega = new frmVerDetalleDocumentos();
                frm_RegEntrega.MdiParent = this;
                frm_RegEntrega.Show();
            }
            else
            { frm_RegEntrega.Focus(); }
        }

        private void OpenfrmBoleta()
        {
            if (!this.MdiChildren.Contains(frm_Boleta))
            {
                frm_Boleta = new frmFacturas();
                frm_Boleta.MdiParent = this;
                frm_Boleta.Show();
            }
            else
            { frm_Boleta.Focus(); }
        }

        private void OpenfrmFactura()
        {
            if (!this.MdiChildren.Contains(frm_Factura))
            {
                frm_Factura = new frmFacturas();
                frm_Factura.MdiParent = this;
                frm_Factura.Show();
            }
            else
            { frm_Factura.Focus(); }
        }

        private void OpenfrmCobranzas()
        {
            if (!this.MdiChildren.Contains(frm_Cobranzas))
            {
                frm_Cobranzas = new frmCobranza();
                frm_Cobranzas.AutoScroll = true;
                frm_Cobranzas.MdiParent = this;
                frm_Cobranzas.Show();
            }
            else
            { frm_Cobranzas.Focus(); }
        }

        private void OpenNotasCredito()
        {
            if (!this.MdiChildren.Contains(frm_NotasCredito))
            {
                frm_NotasCredito = new frmFacturas();
                frm_NotasCredito.MdiParent = this;
                frm_NotasCredito.Show();
            }
            else
            { frm_NotasCredito.Focus(); }
        }

        private void OpenNotasDebito()
        {
            if (!this.MdiChildren.Contains(frm_NotasDebito))
            {
                frm_NotasDebito = new frmFacturas();
                frm_NotasDebito.MdiParent = this;
                frm_NotasDebito.Show();
            }
            else
            { frm_NotasDebito.Focus(); }
        }

        private void OpenfrmDistDistribuidores()
        {
            if (!this.MdiChildren.Contains(frm_Dist_Dist))
            {
                frm_Dist_Dist = new frm_DistribucionDist();
                frm_Dist_Dist.AutoScroll = true;
                frm_Dist_Dist.MdiParent = this;
                frm_Dist_Dist.Show();
            }
            else
            { frm_Dist_Dist.Focus(); }
        }

        private void OpenBusquedas()
        {
            if (!this.MdiChildren.Contains(frm_Busquedas))
            {
                frm_Busquedas = new frmBusquedas();
                frm_Busquedas.AutoScroll = true;
                frm_Busquedas.MdiParent = this;
                frm_Busquedas.Show();
            }
            else
            { frm_Busquedas.Focus(); }
        }

        private void OpenForms(Infragistics.Win.UltraWinExplorerBar.ItemEventArgs ee)
        {
            switch (ee.Item.Group.ToString())
            {
                case "VENTAS - DOCUMENTOS":
                    switch (ee.Item.ToString())
                    {
                        case "Facturas":
                            Principal.TIPO_DOCUMENTO = "01";
                            Principal.CLAVE = "";
                            OpenfrmFactura();
                            break;
                        case "Boletas":
                            Principal.TIPO_DOCUMENTO = "02";
                            Principal.CLAVE = "";
                            OpenfrmBoleta();
                            break;
                        case "Guias de Remision":
                            Principal.TIPO_DOCUMENTO = "03";
                            Principal.CLAVE = "";
                            OpenfrmGuias();
                            break;
                        case "Ordenes de Salida":
                            Principal.TIPO_DOCUMENTO = "04";
                            Principal.CLAVE = "";
                            OpenfrmOrdSal();
                            break;
                        case "Notas de Credito":
                            Principal.TIPO_DOCUMENTO = "05";
                            Principal.CLAVE = "";
                            OpenNotasCredito();
                            break;
                        case "Notas de Debito":
                            Principal.TIPO_DOCUMENTO = "06";
                            Principal.CLAVE = "";
                            OpenNotasDebito();
                            break;
                        case "Reingresos":
                            Principal.TIPO_DOCUMENTO = "09";
                            Principal.CLAVE = "";
                            OpenReingreso();
                            break;
                        case "Reg. Entrega a Suscriptores":
                            Principal.TIPO_DOCUMENTO = "20";
                            Principal.CLAVE = "";
                            OpenRegistroEntrega();
                            break;
                    }
                    break;
                case "VENTAS - PROCESOS":
                    switch (ee.Item.ToString())
                    {
                        case "Distribución  de distribuidores":
                            OpenfrmDistDistribuidores();
                            break;
                        case "Boletas de ventas":
                            //OpenfrmBoletas();
                            break;
                        case "Busquedas":
                            OpenBusquedas();
                            break;
                    }
                    break;
                case "VENTAS - REPORTES":
                    switch (ee.Item.ToString())
                    {
                        case "Cobranzas":
                            OpenfrmCobranzas();
                            break;
                    }
                    break;
                case "CAJA":
                    break;
                default:
                    break;
            }
        }

        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            OpenForms(e);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Principal.intVentanas = 0;
            try
            {
                string ruta = System.IO.Directory.GetCurrentDirectory() + "\\Config\\Configuracion.ini";
                if (System.IO.File.Exists(ruta) == true)
                {
                    StreamReader obj = new StreamReader(ruta);
                    Principal.Server = obj.ReadLine().ToString();
                    Principal.DataBase = obj.ReadLine().ToString();
                    Principal.strCodEmpresa = obj.ReadLine().ToString();
                    Principal.TipoProceso = obj.ReadLine().ToString();
                    obj.Close();
                    AccesoDatos.Conexion.IniciarSesion(Principal.Server, Principal.DataBase);
                    MuestraEmpresas();
                }
                else
                {
                    MessageBox.Show("No existe Archivo de configuracion");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
                Application.Exit();
            }
            finally
            {
                GC.Collect();
            }
        }

        private void CambioEmpresas_Click(object sender, EventArgs e)
        {
            if (Principal.intVentanas == 0)
            {
                Form frm_CambioEmpresas = new frmCambioEmpresas();
                frm_CambioEmpresas.ShowDialog();
                MuestraEmpresas();
            }
            else
            {
                MessageBox.Show("Primero, cierre todas las Ventanas");
            }
        }

        private void MuestraEmpresas()
        {
            if (Principal.TipoProceso == "2")
            {
                this.Text = "FORMULARIO PRINCIPAL - ALMACEN";
            }
            else
            {
                this.Text = "FORMULARIO PRINCIPAL - VENTAS " + (Principal.strCodEmpresa == "0" ? "COMERCIAL" : "EX-VIPSA");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
