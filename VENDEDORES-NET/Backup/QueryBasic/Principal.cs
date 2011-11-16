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
    public partial class Principal : Form
    {
        private int childFormNumber = 0;
        Clientes childClientes = new Clientes();
        
        public Principal()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            if (EjecutivoActual.id_vendedor != "")
            {
                Clientes frm_Clientes = new Clientes();
                frm_Clientes.MdiParent = this;
                frm_Clientes.Text = "Window : Clientes ";
                frm_Clientes.WindowState = FormWindowState.Maximized;
                frm_Clientes.Show();
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void iconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            if (EjecutivoActual.id_vendedor != "")
            {
                ActualUser.tipo_kardex = "1";
                frmKardexVendedores frm_KardexVendedores = new frmKardexVendedores();
                frm_KardexVendedores.MdiParent = this;
                frm_KardexVendedores.Text = "Window : Kardex Actual - Saldos ";
                frm_KardexVendedores.WindowState = FormWindowState.Maximized;
                frm_KardexVendedores.Show();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (EjecutivoActual.id_vendedor != "")
            {
                ActualUser.tipo_kardex = "0";
                frmKardexVendedores frm_KardexVendedores_historico = new frmKardexVendedores();
                frm_KardexVendedores_historico.MdiParent = this;
                frm_KardexVendedores_historico.Text = "Window : Kardex  Historico";
                frm_KardexVendedores_historico.WindowState = FormWindowState.Maximized;
                frm_KardexVendedores_historico.Show();
            }
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            if (ActualUser.tipo_usuario == "0")
            {
                toolStripButton2.Visible = false;
                this.Text = "SISTEMA DE CONSULTAS (c)GACETA JURIDICA S.A. (2010 v1)    [Usuario Actual = " + ActualUser.usuario + "]";
            }
            else
            {
                toolStripButton2.Visible = true;
                this.Text = "SISTEMA DE CONSULTAS (c)GACETA JURIDICA S.A. (2010 v1)    [Usuario Actual = " + ActualUser.usuario + "]";
            }
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            //MessageBox.Show("Evento timer " + Tiempo.tiempo.ToString());
            lblTiempo.Text = Tiempo.tiempo.ToString() + " - " + DateTime.Now.ToString();
            //statusStrip.Text = Tiempo.tiempo.ToString();
        }
        private void Principal_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("The method or operation is not implemented.");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
                frmEjecutivos frm_frmEjecutivos = new frmEjecutivos();
                frm_frmEjecutivos.Text = "USUARIO : " + ActualUser.Supervisor + " [ LISTA DE EJECUTIVOS ]";
                frm_frmEjecutivos.ShowDialog();
                if (EjecutivoActual.id_vendedor != "")
                {
                    if (ActualUser.tipo_usuario == "0")
                    {
                        this.Text = "SISTEMA DE CONSULTAS (c)GACETA JURIDICA S.A. (2010 v1)    [Usuario Actual = " + ActualUser.usuario + "]";
                    }
                    else
                    {
                        this.Text = "SISTEMA DE CONSULTAS (c)GACETA JURIDICA S.A. (2010 v1)    [Usuario Actual = " + ActualUser.usuario  + "] / " + EjecutivoActual.nombre;
                    }

                }

        }
    }
}
