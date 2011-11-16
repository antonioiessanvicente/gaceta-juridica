using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using WIA;

namespace sacnner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                using (WiaScannerAdapter adapter = new WiaScannerAdapter())
    {
         try
         {
              Image image = adapter.ScanImage(ImageFormat.Bmp, @"c:\temp\test.bmp");
              pictureBox1.Image = image;
         }
         catch (WiaOperationException ex)
         {
              MessageBox.Show(ex.Message + "Error Code: " + ex.ErrorCode);
         }
    }
        }

    }

}
