namespace ErpGaceta
{
    partial class frm_SetData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtfecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtOtroDato = new System.Windows.Forms.TextBox();
            this.txtNroCajas = new System.Windows.Forms.TextBox();
            this.txtNroSobres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.pdfViewer1 = new PDFView.PDFViewer();
            this.cdmGrabarArchivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtfecha2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTextos = new System.Windows.Forms.Label();
            this.cmdGrabaOK = new System.Windows.Forms.Button();
            this.chkOK = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtfecha1
            // 
            this.dtfecha1.CustomFormat = "dd-MMM-yyyy";
            this.dtfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfecha1.Location = new System.Drawing.Point(6, 26);
            this.dtfecha1.Name = "dtfecha1";
            this.dtfecha1.Size = new System.Drawing.Size(93, 20);
            this.dtfecha1.TabIndex = 0;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(197, 26);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(136, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "UBICAR ARCHIVO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(6, 65);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(102, 20);
            this.txtNroDoc.TabIndex = 4;
            // 
            // txtOtroDato
            // 
            this.txtOtroDato.Location = new System.Drawing.Point(114, 65);
            this.txtOtroDato.Name = "txtOtroDato";
            this.txtOtroDato.Size = new System.Drawing.Size(135, 20);
            this.txtOtroDato.TabIndex = 5;
            // 
            // txtNroCajas
            // 
            this.txtNroCajas.Location = new System.Drawing.Point(255, 65);
            this.txtNroCajas.Name = "txtNroCajas";
            this.txtNroCajas.Size = new System.Drawing.Size(55, 20);
            this.txtNroCajas.TabIndex = 6;
            this.txtNroCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNroSobres
            // 
            this.txtNroSobres.Location = new System.Drawing.Point(322, 65);
            this.txtNroSobres.Name = "txtNroSobres";
            this.txtNroSobres.Size = new System.Drawing.Size(74, 20);
            this.txtNroSobres.TabIndex = 7;
            this.txtNroSobres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "FECHA DE ENVIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DESTINO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "N° DE DOC.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "OTRO DATO ADICIONAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "N° CAJAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "N° SOBRES";
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Enabled = false;
            this.cmdGrabar.Location = new System.Drawing.Point(720, 2);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(87, 26);
            this.cmdGrabar.TabIndex = 16;
            this.cmdGrabar.Text = "GRABAR";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(808, 2);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(87, 26);
            this.cmdCerrar.TabIndex = 17;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.AllowBookmarks = true;
            this.pdfViewer1.AutoScroll = true;
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pdfViewer1.FileName = null;
            this.pdfViewer1.Location = new System.Drawing.Point(8, 103);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(887, 548);
            this.pdfViewer1.TabIndex = 19;
            this.pdfViewer1.UseXPDF = true;
            // 
            // cdmGrabarArchivo
            // 
            this.cdmGrabarArchivo.Location = new System.Drawing.Point(500, 0);
            this.cdmGrabarArchivo.Name = "cdmGrabarArchivo";
            this.cdmGrabarArchivo.Size = new System.Drawing.Size(202, 26);
            this.cdmGrabarArchivo.TabIndex = 20;
            this.cdmGrabarArchivo.Text = "Exportar como Archivo PDF";
            this.cdmGrabarArchivo.UseVisualStyleBackColor = true;
            this.cdmGrabarArchivo.Click += new System.EventHandler(this.cdmGrabarArchivo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtAgencia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtfecha1);
            this.panel1.Controls.Add(this.dtfecha2);
            this.panel1.Controls.Add(this.txtDestino);
            this.panel1.Controls.Add(this.txtNroDoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOtroDato);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNroCajas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNroSobres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 94);
            this.panel1.TabIndex = 21;
            // 
            // dtfecha2
            // 
            this.dtfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtfecha2.Location = new System.Drawing.Point(105, 26);
            this.dtfecha2.Name = "dtfecha2";
            this.dtfecha2.Size = new System.Drawing.Size(86, 20);
            this.dtfecha2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "HORA-ENVIO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTextos);
            this.panel2.Controls.Add(this.cmdGrabaOK);
            this.panel2.Controls.Add(this.chkOK);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(513, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 68);
            this.panel2.TabIndex = 22;
            // 
            // lblTextos
            // 
            this.lblTextos.AutoSize = true;
            this.lblTextos.Location = new System.Drawing.Point(4, 55);
            this.lblTextos.Name = "lblTextos";
            this.lblTextos.Size = new System.Drawing.Size(0, 13);
            this.lblTextos.TabIndex = 3;
            // 
            // cmdGrabaOK
            // 
            this.cmdGrabaOK.Location = new System.Drawing.Point(288, 29);
            this.cmdGrabaOK.Name = "cmdGrabaOK";
            this.cmdGrabaOK.Size = new System.Drawing.Size(91, 23);
            this.cmdGrabaOK.TabIndex = 2;
            this.cmdGrabaOK.Text = "GRABAR";
            this.cmdGrabaOK.UseVisualStyleBackColor = true;
            this.cmdGrabaOK.Visible = false;
            this.cmdGrabaOK.Click += new System.EventHandler(this.cmdGrabaOK_Click);
            // 
            // chkOK
            // 
            this.chkOK.AutoSize = true;
            this.chkOK.Location = new System.Drawing.Point(288, 6);
            this.chkOK.Name = "chkOK";
            this.chkOK.Size = new System.Drawing.Size(91, 17);
            this.chkOK.TabIndex = 1;
            this.chkOK.Text = "Informado OK";
            this.chkOK.UseVisualStyleBackColor = true;
            this.chkOK.CheckedChanged += new System.EventHandler(this.chkOK_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.MaxLength = 150;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(278, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(339, 26);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(136, 20);
            this.txtAgencia.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "AGENCIA";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(401, 65);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(74, 20);
            this.txtImporte.TabIndex = 8;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "IMPORTE";
            // 
            // frm_SetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cdmGrabarArchivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGrabar);
            this.Name = "frm_SetData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "INFORMACION :::  DATOS ESCANEADOS";
            this.Load += new System.EventHandler(this.frm_SetData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtfecha1;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtOtroDato;
        private System.Windows.Forms.TextBox txtNroCajas;
        private System.Windows.Forms.TextBox txtNroSobres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdCerrar;
        private PDFView.PDFViewer pdfViewer1;
        private System.Windows.Forms.Button cdmGrabarArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdGrabaOK;
        private System.Windows.Forms.CheckBox chkOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtfecha2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgencia;
    }
}