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
    public partial class frmCambioEmpresas : Form
    {
        public frmCambioEmpresas()
        {
            InitializeComponent();
        }

        private void frmCambioEmpresas_Load(object sender, EventArgs e)
        {
            if (Principal.strCodEmpresa == "0")
            {
                rbtOpcion1.Checked = true;
                rbtOpcion2.Checked = false;
            }
            else
            {
                rbtOpcion1.Checked = false;
                rbtOpcion2.Checked = true;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbtOpcion1.Checked == true)
            {
                Principal.strCodEmpresa = "0";
            }
            else
            {
                Principal.strCodEmpresa = "1";
            }
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
