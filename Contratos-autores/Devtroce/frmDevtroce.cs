using System;
using System.Windows.Forms;
using System.Drawing;
using AccesoDatos.Orm;

namespace Devtroce
{
    public partial class frmMaestro : Form
    {
        public frmMaestro()
        {
            InitializeComponent();
        }

        private Maestro maestro = new Maestro();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //AccesoDatos.Conexion.IniciarSesion("192.168.0.6", "temporal", "acceso_vendedores", "navidad-2010");
                AccesoDatos.Conexion.IniciarSesion("localhost", "juridica");
                MessageBox.Show(@"Se conecto exitosamente, más le vale!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                int ancho = 30;
                dgvMaestro.DataSource = maestro.Buscar("","",1 );
            dgvMaestro.Refresh();
            FormatGridWithTableStyles();
            dgvMaestro.Columns[0].Visible = false;
            dgvMaestro.Columns[14].Visible = false;
            dgvMaestro.Columns[15].Visible = false;
            dgvMaestro.Columns[13].Visible = false;

            DataGridViewColumn COL01 = new DataGridViewColumn();
            COL01 = dgvMaestro.Columns["T_STK"];
            COL01.ReadOnly = true;
            COL01.Visible = true;
            COL01.HeaderText = "T_STK";
            COL01.Width = ancho;
            COL01.DefaultCellStyle.BackColor = Color.YellowGreen;
            COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL01.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL02 = new DataGridViewColumn();
            COL02 = dgvMaestro.Columns["T_MOV"];
            COL02.ReadOnly = true;
            COL02.Visible = true;
            COL02.HeaderText = "T_MOV";
            COL02.Width = ancho;
            COL02.DefaultCellStyle.BackColor = Color.YellowGreen;
            COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL02.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL03 = new DataGridViewColumn();
            COL03 = dgvMaestro.Columns["SALDOS"];
            COL03.ReadOnly = true;
            COL03.Visible = true;
            COL03.HeaderText = "SALDOS";
            COL03.Width = ancho;
            COL03.DefaultCellStyle.BackColor = Color.CadetBlue;
            COL03.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL03.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL04 = new DataGridViewColumn();
            COL04 = dgvMaestro.Columns["STK_INI"];
            COL04.Width = ancho;
            COL04.DefaultCellStyle.BackColor = Color.DarkGoldenrod;
            COL04.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL04.DefaultCellStyle.Format = "#,###";

            DataGridViewColumn COL05 = new DataGridViewColumn();
            COL05 = dgvMaestro.Columns["O_S"];
            COL05.Width = ancho;
            COL05.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL05.DefaultCellStyle.Format = "#,###";
            COL05.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL06 = new DataGridViewColumn();
            COL06 = dgvMaestro.Columns["GUIAS"];
            COL06.Width = ancho;
            COL06.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL06.DefaultCellStyle.Format = "#,###";
            COL06.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL07 = new DataGridViewColumn();
            COL07 = dgvMaestro.Columns["F_CAN"];
            COL07.Width = ancho;
            COL07.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL07.DefaultCellStyle.Format = "#,###";
            COL07.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL08 = new DataGridViewColumn();
            COL08 = dgvMaestro.Columns["F_PEN"];
            COL08.Width = ancho;
            COL08.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL08.DefaultCellStyle.Format = "#,###";
            COL08.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL09 = new DataGridViewColumn();
            COL09 = dgvMaestro.Columns["F_CTA"];
            COL09.Width = ancho;
            COL09.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL09.DefaultCellStyle.Format = "#,###";
            COL09.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL010 = new DataGridViewColumn();
            COL010 = dgvMaestro.Columns["DEVOL"];
            COL010.Width = ancho;
            COL010.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL010.DefaultCellStyle.Format = "#,###";
            COL010.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            DataGridViewColumn COL011 = new DataGridViewColumn();
            COL011 = dgvMaestro.Columns["E_SUS"];
            COL011.Width = ancho;
            COL011.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            COL011.DefaultCellStyle.Format = "#,###";
            COL011.DefaultCellStyle.BackColor = Color.DarkGoldenrod;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void FormatGridWithTableStyles()
        {
            dgvMaestro.BackColor = Color.GhostWhite;
            dgvMaestro.BackgroundColor = Color.Lavender;
            dgvMaestro.BorderStyle = BorderStyle.None;
            dgvMaestro.Font = new Font("Tahoma", (float)8.0);
            DataGridTableStyle grdTableStyle1 = new DataGridTableStyle();
            grdTableStyle1.AlternatingBackColor = Color.GhostWhite;
            grdTableStyle1.BackColor = Color.GhostWhite;
            grdTableStyle1.ForeColor = Color.MidnightBlue;
            grdTableStyle1.GridLineColor = Color.RoyalBlue;
            grdTableStyle1.HeaderBackColor = Color.MidnightBlue;
            grdTableStyle1.HeaderFont = new Font("Tahoma", (float)8.0, FontStyle.Bold);
            grdTableStyle1.HeaderForeColor = Color.Lavender;
            grdTableStyle1.SelectionBackColor = Color.Teal;
            grdTableStyle1.SelectionForeColor = Color.PaleGreen;
            grdTableStyle1.MappingName = "Suscripciones";
            grdTableStyle1.PreferredColumnWidth = 125;
            grdTableStyle1.PreferredRowHeight = 15;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        { Application.Exit(); }

    }
}
