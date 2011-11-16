using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WIA;
using System.IO;
using AccesoDatos;
using System.Data.SqlClient;
using PDFView;

namespace ErpGaceta
{
    public partial class frm_SetData : Form
    {
        private ReglasNegocioDistribuidores.MaestroDistribuidores ParmetrosImagenes = new ReglasNegocioDistribuidores.MaestroDistribuidores();
        private DataTable MaestroImagenes = new DataTable();
        DataSet MiDataSetImagenes = new DataSet();
        private IDataReader ReadQuery;

        private String Archivo = "";
        private string str_OBSERVACION_OK;
        private string str_USUARIO_OK;
        private DateTime FECHA_OK;
        private string str_CHECK_OK;
        

        public frm_SetData()
        {
            InitializeComponent();
        }

        private void frm_SetData_Load(object sender, EventArgs e)
        {
            //this.panel1.AutoScroll = true;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                MuestraDatosImagenes();
                if (Principal.Action == "0")
                {  // SOLO PARA ALMACEN
                    button1.Visible = true;
                    cmdGrabar.Visible = true;
                    panel1.Enabled = true;
                    panel2.Visible = false;
                    if (str_CHECK_OK == "1")
                    {
                        panel1.Enabled = false;
                        panel2.Visible = true;
                        panel2.Enabled = false;
                        button1.Visible = false;
                        cmdGrabar.Visible = false;
                        textBox1.Text = str_OBSERVACION_OK;
                        chkOK.Checked = true;
                        lblTextos.Text = "User: " + str_USUARIO_OK + " :: " + FECHA_OK.ToString();
                        cmdGrabaOK.Visible = false;
                    }
                }
                else
                { // SOLO PARA VENTAS
                    button1.Visible = false;
                    cmdGrabar.Visible = false;
                    panel1.Enabled = false;
                    panel2.Visible = true;
                    if (str_CHECK_OK=="1")
                    {
                        textBox1.Text = str_OBSERVACION_OK;
                        chkOK.Checked =true;
                        lblTextos.Text = "User: " + str_USUARIO_OK + " :: " +FECHA_OK.ToString();
                        cmdGrabaOK.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.Cursor = Cursors.Default;
        }
        private void MuestraDatosImagenes()
        {

            byte[] FileBinary;
            ParmetrosImagenes.NUMERO = Principal.Numero;
            ParmetrosImagenes.ID_CLIENTE = Principal.IdCliente;
            ParmetrosImagenes.FECHA_ENVIO = DateTime.Now;
            ParmetrosImagenes.HORA_ENVIO = DateTime.Now;
            ParmetrosImagenes.DESTINO = "";
            ParmetrosImagenes.NRO_DOC = "";
            ParmetrosImagenes.OTRO_DATO = "";
            ParmetrosImagenes.NRO_CAJAS = 0;
            ParmetrosImagenes.NRO_SOBRES = 0;
            ParmetrosImagenes.NOMBRE_ARCHIVO = new Byte[10];
            ParmetrosImagenes.TIPO_ARCHIVO = "";
            ParmetrosImagenes.ERRORES = "";
            //FileStream fs;                          // Writes the BLOB to a file (*.bmp).
            //BinaryWriter bw;                        // Streams the BLOB to the FileStream object.
            try
            {
                cdmGrabarArchivo.Visible = false;
                ReadQuery = ParmetrosImagenes.OpenDistribImagenes(ParmetrosImagenes);
                while (ReadQuery.Read())
                {
                    cdmGrabarArchivo.Visible = true;
                    if (ReadQuery["TIPO_ARCHIVO"].ToString() != "")
                    {
                        FileBinary = (byte[])ReadQuery["NOMBRE_ARCHIVO"];
                        ParmetrosImagenes.TIPO_ARCHIVO = ReadQuery["TIPO_ARCHIVO"].ToString();
                        dtfecha1.Value = Convert.ToDateTime(ReadQuery["FECHA_ENVIO"].ToString());
                        dtfecha2.Value = Convert.ToDateTime(ReadQuery["HORA_ENVIO"].ToString());
                        txtDestino.Text = ReadQuery["DESTINO"].ToString();
                        txtNroDoc.Text = ReadQuery["NRO_DOC"].ToString();
                        txtOtroDato.Text = ReadQuery["OTRO_DATO"].ToString();
                        txtNroCajas.Text = ReadQuery["NRO_CAJAS"].ToString();
                        txtNroSobres.Text = ReadQuery["NRO_SOBRES"].ToString();
                        txtAgencia.Text = ReadQuery["AGENCIA"].ToString();
                        txtImporte.Text = ReadQuery["IMPORTE"].ToString();
                        str_OBSERVACION_OK = ReadQuery["OBSERVACION_OK"].ToString();
                        str_USUARIO_OK = ReadQuery["USUARIO_OK"].ToString();
                        FECHA_OK = Convert.ToDateTime(ReadQuery["FECHA_OK"].ToString());
                        str_CHECK_OK = ReadQuery["CHECK_OK"].ToString();

                        string tmpPathfile = Application.StartupPath + "\\" + System.IO.Path.GetRandomFileName();
                        tmpPathfile = tmpPathfile.Replace(".", "");
                        // fs = new FileStream(tmpPathfile + ".pdf",FileMode.OpenOrCreate, FileAccess.Write);
                        SqlBlob2File(tmpPathfile + ".pdf", Principal.Numero.ToString(), Principal.IdCliente);
                        //bw = new BinaryWriter(fs);
                        //MemoryStream ms = new MemoryStream(ExtraerImagen(Principal.Numero, Principal.IdCliente));
                        //bw.Close();
                        //fs.Close();
                        Archivo = tmpPathfile + ".pdf";
                        pdfViewer1.FileName = Archivo;
                        //Me.PictureBox1.Image = Image.FromStream(ms)
                    }
                    else
                    {
                        ParmetrosImagenes.TIPO_ARCHIVO = ReadQuery["TIPO_ARCHIVO"].ToString();
                        txtDestino.Text = ReadQuery["DESTINO"].ToString();
                        txtNroDoc.Text = ReadQuery["NRO_DOC"].ToString();
                        txtOtroDato.Text = ReadQuery["OTRO_DATO"].ToString();
                        txtNroCajas.Text = ReadQuery["NRO_CAJAS"].ToString();
                        txtNroSobres.Text = ReadQuery["NRO_SOBRES"].ToString();
                        txtAgencia.Text = ReadQuery["AGENCIA"].ToString();
                        txtImporte.Text = ReadQuery["IMPORTE"].ToString();
                        str_OBSERVACION_OK = ReadQuery["OBSERVACION_OK"].ToString();
                        str_USUARIO_OK = ReadQuery["USUARIO_OK"].ToString();
                        FECHA_OK = Convert.ToDateTime(ReadQuery["FECHA_OK"].ToString());
                        str_CHECK_OK = ReadQuery["CHECK_OK"].ToString();
                    }
                }
                ReadQuery.Close();
            }
            catch (Exception ex)
            {
                ReadQuery.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void SqlBlob2File(string DocName, string Numero, string IdCliente)
        {
            SqlConnection cn = new SqlConnection("Data Source=SERVIDOR6;initial catalog=COMERCIAL;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("Select NOMBRE_ARCHIVO From REGISTRO_DISTRIB_DET_01 Where NUMERO = " + Numero.ToString() + " and ID_CLIENTE = '" + IdCliente.ToString() + "' ", cn);
            //            cmd.Parameters.AddWithValue("@DocName", DocName);
            cn.Open();
            using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                if (dr.Read())
                {
                    System.IO.FileStream fs = new System.IO.FileStream(DocName, System.IO.FileMode.Create);
                    byte[] b = (byte[])dr["NOMBRE_ARCHIVO"];
                    fs.Write(b, 0, b.Length);
                    fs.Close();
                }
            }
            cn.Close();
        }
        private byte[] ExtraerImagen(Double Numero, string IDCliente)
        {
            SqlConnection cn = new SqlConnection("Data Source=SERVIDOR6;initial catalog=COMERCIAL;Integrated Security=True;");
            DataSet ds = new DataSet();
            string SqlSelect = "Select NOMBRE_ARCHIVO From REGISTRO_DISTRIB_DET_01 Where NUMERO = " + Numero.ToString() + " and ID_CLIENTE = '" + IDCliente.ToString() + "' ";
            SqlCommand Command = new SqlCommand(SqlSelect, cn);
            cn.Open();
            byte[] MyPhoto = (byte[])Command.ExecuteScalar();
            cn.Close();
            return MyPhoto;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.DefaultExt = "pdf";
                dlg.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                Archivo = dlg.FileName;
                pdfViewer1.FileName = Archivo;
                cmdGrabar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            cmdGrabar.Enabled = false;
            try
            {
                ParmetrosImagenes.NUMERO = Principal.Numero;
                ParmetrosImagenes.ID_CLIENTE = Principal.IdCliente;
                ParmetrosImagenes.FECHA_ENVIO = dtfecha1.Value;
                ParmetrosImagenes.HORA_ENVIO = dtfecha2.Value;
                ParmetrosImagenes.DESTINO = txtDestino.Text;
                ParmetrosImagenes.NRO_DOC = txtNroDoc.Text;
                ParmetrosImagenes.OTRO_DATO = txtOtroDato.Text;
                ParmetrosImagenes.NRO_CAJAS = Convert.ToInt16(txtNroCajas.Text.ToString());
                ParmetrosImagenes.NRO_SOBRES = Convert.ToInt16(txtNroSobres.Text.ToString());
                ParmetrosImagenes.NOMBRE_ARCHIVO = new Byte[10];
                ParmetrosImagenes.TIPO_ARCHIVO = "application/pdf";
                ParmetrosImagenes.AGENCIA = txtAgencia.Text;
                if (txtImporte.Text.ToString().Length != 0)
                {
                    if (ReglasNegocioDistribuidores.LeftRightMid.IsNumeric(txtImporte.Text) == true)
                    {
                        ParmetrosImagenes.IMPORTE = Convert.ToDouble(txtImporte.Text.ToString());
                    }
                    else
                    {
                        ParmetrosImagenes.IMPORTE = 0;
                    }
                }
                else
                {
                    ParmetrosImagenes.IMPORTE = 0;
                }
                ParmetrosImagenes.ERRORES = "";
                ParmetrosImagenes.TIPO_ACCION = "0";
                FileInfo info = new FileInfo(Archivo);
                byte[] content = new byte[info.Length];
                FileStream imagestream = info.OpenRead();
                imagestream.Read(content, 0, content.Length);
                imagestream.Close();
                ParmetrosImagenes.NOMBRE_ARCHIVO = content;
                ParmetrosImagenes.CrearRegDistribImagenes(ParmetrosImagenes);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Cursor = Cursors.Default;
            cmdGrabar.Enabled = true;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cdmGrabarArchivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.DefaultExt = "pdf";
            DialogSave.Filter = "Pdf File (*.pdf)|*.pdf";
            DialogSave.AddExtension = true;
            DialogSave.RestoreDirectory = true;
            DialogSave.Title = "Where do you want to save the file?";
            DialogSave.InitialDirectory = Archivo.Substring(1, 2) + "/";
            DialogSave.FileName = Archivo;
            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show("Selectionaste el fichero: " + DialogSave.FileName);
                CopyFiles(Archivo, DialogSave.FileName);
            }
            else
            {
                MessageBox.Show("Cerrarte la ventana o pulsaste cancelar.");
            }
            DialogSave.Dispose();
            DialogSave = null;
        }
        private static bool CopyFiles(string sSource, string sDestn)
        {
            try
            {
                if (File.Exists(sSource) == true)
                {
                    File.Copy(sSource, sDestn);
                    return true;
                }
                else
                {
                    MessageBox.Show("Specifed file does not exist");
                    return false;
                }
            }
            catch (FileNotFoundException exFile)
            {
                MessageBox.Show("File Not Found " + exFile.Message);
                return false;
            }
            catch (DirectoryNotFoundException exDir)
            {
                MessageBox.Show("Directory Not Found " + exDir.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void chkOK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOK.Checked == true)
            {
                cmdGrabaOK.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                cmdGrabaOK.Visible = false;
                textBox1.Visible = false;
            }

        }

        private void cmdGrabaOK_Click(object sender, EventArgs e)
        {
            ParmetrosImagenes.NUMERO = Principal.Numero;
            ParmetrosImagenes.ID_CLIENTE = Principal.IdCliente;
            ParmetrosImagenes.OBSERVACION_OK = textBox1.Text;
            ParmetrosImagenes.TIPO_ACCION = "1";
            ParmetrosImagenes.ERRORES = "";
            ParmetrosImagenes.SaveObservacionOK(ParmetrosImagenes);
        }
    }
}
