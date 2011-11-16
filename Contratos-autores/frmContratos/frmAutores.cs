using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AccesoDatos.Orm;

namespace frmContratos
{
    public partial class frmAutores : Form
    {
        private Maestro maestro1 = new Maestro();
        public frmAutores()
        {
            InitializeComponent();
        }

        private void cmdAcept_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            maestro1.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
            try
            {
                dg_Contratos.DataSource = maestro1.LeeAutores(maestro1);
                dg_Contratos.Refresh();
                dg_Contratos.Columns[2].Visible = false;

                // customize dataviewgrid, add checkbox column
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.Width = 30;
                checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dg_Contratos.Columns.Insert(0, checkboxColumn);
                // add checkbox header
                Rectangle rect = dg_Contratos.GetCellDisplayRectangle(0, -1, true);
                // set checkbox header to center of header cell. +1 pixel to position correctly.
                rect.X = rect.Location.X + (rect.Width / 4);
                CheckBox checkboxHeader = new CheckBox();
                checkboxHeader.Name = "checkboxHeader";
                checkboxHeader.Size = new Size(18, 18);
                checkboxHeader.Location = rect.Location;
                checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
                dg_Contratos.Controls.Add(checkboxHeader);

                DataGridViewColumn COL01 = new DataGridViewColumn();
                COL01 = dg_Contratos.Columns["ID_AUTOR"];
                COL01.Width = 60;
                COL01.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                COL01.HeaderText = "CODIGO";
                //COL04.DefaultCellStyle.Format = "dd-MMM-yy";
                DataGridViewColumn COL02 = new DataGridViewColumn();
                COL02 = dg_Contratos.Columns["NOMBRE_AUTOR"];
                COL02.Width = 380;
                COL02.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                COL02.HeaderText = "NOMBRE DEL AUTOR";

                


                VerificaAutores();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void VerificaAutores()
        {
            int Chequeo;
            for (int i = 0; i < dg_Contratos.RowCount; i++)
            {
                Chequeo = Convert.ToInt16(dg_Contratos.Rows[i].Cells[3].Value);
                if (Chequeo != 0)
                {
                    dg_Contratos[0, i].Value = true;
                }
            }
        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dg_Contratos.RowCount; i++)
            {
                dg_Contratos[0, i].Value = ((CheckBox)dg_Contratos.Controls.Find("checkboxHeader", true)[0]).Checked;
            }
            dg_Contratos.EndEdit();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            int NUMERO = 0;
            Boolean boolCheck;
            for (int i = 0; i < dg_Contratos.RowCount; i++)
            {
                boolCheck = Convert.ToBoolean(dg_Contratos.Rows[i].Cells[0].Value);
                if (boolCheck == true)
                {
                    NUMERO++;
                    maestro1.CODIGO_CONTRATO = ContratoActual.CODIGO_CONTRATO;
                    maestro1.ID_AUTOR = Convert.ToString(dg_Contratos.Rows[i].Cells[1].Value);
                    maestro1.ID_NUMERO = NUMERO;
                    maestro1.ERRORES = "";
                    maestro1.InsAutoresPorContrato(maestro1);
                    if (maestro1.ERRORES.ToString() != "")
                    {
                        MessageBox.Show(@maestro1.ERRORES.ToString());
                    }
                }
            }
            this.Hide();

        }
    }
}
