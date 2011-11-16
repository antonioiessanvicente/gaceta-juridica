using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ErpGaceta
{
    public partial class frm_Reportes : Form
    {
        public frm_Reportes()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void frm_Reportes_Load(object sender, EventArgs e)
        {
            string Filename = Environment.CurrentDirectory + "\\Reporte001.rpt";
            try
            {

                string strConnection = "Provider=sqloledb;Server=192.168.0.6;Database=COMERCIAL; Trusted_Connection=yes;Encrypt=yes;";
                OleDbConnection Connection = new OleDbConnection(strConnection);
                string strSQL = "select * from view_GetDataDistribuidores where numero = " + Principal.Numero.ToString();
                OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Connection);
                DataSet DS = new DataSet();
                DA.Fill(DS, "Customers");
                if (System.IO.File.Exists(Filename) == false)
                {
                    throw (new Exception("Imposible de localizar el archivo : " + Filename));
                }
                ReportDocument cr = new ReportDocument();
                cr.Load(Filename);
                cr.SetDataSource(DS.Tables["Customers"]);

                this.crystalReportViewer1.ShowRefreshButton = false;
                this.crystalReportViewer1.ShowCloseButton = false;
                this.crystalReportViewer1.ShowGroupTreeButton = false;

                this.crystalReportViewer1.ReportSource = cr;

                //                CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //CrystalDecisions.CrystalReports.Engine.d
                //                rpt.Load(Filename);
                //                rpt.DataSourceConnections();
                //                rpt.SetParameterValue("@Numero", Principal.Numero);
                //rpt.SetDatabaseLogon( "SA", "123456");
                //                this.crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " " + Filename);
            }
            
        }
    }
}
