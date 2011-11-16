using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ErpGaceta
{
    public partial class frmCobranza : Form
    {
        private ReglasNegocioDistribuidores.ClassGenericos ParmetrosGenericos = new ReglasNegocioDistribuidores.ClassGenericos();
        private DataTable dt_FAMILIAS;
        private ReglasNegocioDistribuidores.ClassCobranzas ParametrosCobranzas = new ReglasNegocioDistribuidores.ClassCobranzas();
        private DataTable dt_Cobranzas;
        private ReglasNegocioDistribuidores.LeftRightMid ParametrosLefRigh = new ReglasNegocioDistribuidores.LeftRightMid();
        public frmCobranza()
        {
            InitializeComponent();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }
        private void GetCobranzas()
        {
//            ParametrosCobranzas.FECHA_INI = ParametrosLefRigh.FechaToTextSQL(dtFechaIni.Value);
//            ParametrosCobranzas.FECHA_FIN = ParametrosLefRigh.FechaToTextSQL(dtFechaFin.Value);
            panel3.Enabled = false;
            panel2.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            ParametrosCobranzas.FECHA_INI = dtFechaIni.Value;
            ParametrosCobranzas.FECHA_FIN = dtFechaFin.Value;
            ParametrosCobranzas.COD_EMPRESA = Principal.strCodEmpresa;
            if (rbClientes.Checked == true)
            {
                ParametrosCobranzas.TIPO = 1;
            }
            if (rbTipoDistr.Checked == true)
            {
                ParametrosCobranzas.TIPO = 3;
            }
            if (rbVendedor.Checked == true)
            {
                ParametrosCobranzas.TIPO = 2;
            }
            if (rbCobradores.Checked == true)
            {
                ParametrosCobranzas.TIPO = 5;
            }
            ParametrosCobranzas.PARAMETRO = "%";
            if (cbFamilia.SelectedItem != null)
            {
                ParametrosCobranzas.ID_FAMILIA = cbFamilia.SelectedItem.ToString();
            }
            else
            {
                ParametrosCobranzas.ID_FAMILIA = "%";
            }
            dt_Cobranzas = ParametrosCobranzas.ObtieneDataCobranzas(ParametrosCobranzas);
            dgvDetalle.DataSource = dt_Cobranzas;
            panel3.Enabled = true;
            panel2.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void frmCobranza_Load(object sender, EventArgs e)
        {
            ParmetrosGenericos.COD_EMPRESA = Principal.strCodEmpresa;
            dt_FAMILIAS = ParmetrosGenericos.ObtieneFamilias(ParmetrosGenericos);
            cbFamilia.DataSource = dt_FAMILIAS;
            cbFamilia.DisplayMember = "DETALLE_FAMILIA";
            cbFamilia.ValueMember = "ID_FAMILIA";
            dtFechaIni.Value = DateTime.Today;
            dtFechaFin.Value = DateTime.Today;
        }

        private void dtFechaIni_ValueChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void dtFechaFin_ValueChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void rbClientes_CheckedChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void rbTipoDistr_CheckedChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void rbCobradores_CheckedChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFamilia_SelectedValueChanged(object sender, EventArgs e)
        {
            GetCobranzas();
        }
    }
}
