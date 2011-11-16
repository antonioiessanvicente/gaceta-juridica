using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace frmContratos
{
    public partial class frmContratos : Form
    {
        public frmContratos()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //newToolStripButton.Enabled = false;
            Form childForm = new frmRegContratos();
            childForm.MdiParent = this;
            childForm.Show();
        }

 

       



        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
