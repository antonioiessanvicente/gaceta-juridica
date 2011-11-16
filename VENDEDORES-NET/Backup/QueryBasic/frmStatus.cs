using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueryBasic
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        public void Show(string Message)
        {
            lblStatus.Text = Message;
            this.Show();
            Application.DoEvents();
        }
    }
}
