namespace ErpGaceta
{
    partial class frmCobranza
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butProcess = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductosDetalle = new System.Windows.Forms.CheckBox();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.cbProductos = new System.Windows.Forms.CheckBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.rbCobradores = new System.Windows.Forms.RadioButton();
            this.dtFechaIni = new System.Windows.Forms.DateTimePicker();
            this.rbTipoDistr = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvDetalle);
            this.panel2.Location = new System.Drawing.Point(9, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 423);
            this.panel2.TabIndex = 1;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(7, 3);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(879, 417);
            this.dgvDetalle.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butProcess);
            this.panel3.Controls.Add(this.butPrint);
            this.panel3.Controls.Add(this.butExit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbProductosDetalle);
            this.panel3.Controls.Add(this.cbFamilia);
            this.panel3.Controls.Add(this.cbProductos);
            this.panel3.Controls.Add(this.dtFechaFin);
            this.panel3.Controls.Add(this.rbCobradores);
            this.panel3.Controls.Add(this.dtFechaIni);
            this.panel3.Controls.Add(this.rbTipoDistr);
            this.panel3.Controls.Add(this.rbClientes);
            this.panel3.Controls.Add(this.rbVendedor);
            this.panel3.Location = new System.Drawing.Point(9, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 55);
            this.panel3.TabIndex = 2;
            // 
            // butProcess
            // 
            this.butProcess.Location = new System.Drawing.Point(492, 23);
            this.butProcess.Name = "butProcess";
            this.butProcess.Size = new System.Drawing.Size(75, 23);
            this.butProcess.TabIndex = 6;
            this.butProcess.Text = "PROCESAR";
            this.butProcess.UseVisualStyleBackColor = true;
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(573, 23);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(75, 23);
            this.butPrint.TabIndex = 7;
            this.butPrint.Text = "IMPRIMIR";
            this.butPrint.UseVisualStyleBackColor = true;
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(654, 23);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(75, 23);
            this.butExit.TabIndex = 8;
            this.butExit.Text = "SALIR";
            this.butExit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GRUPOS VIGENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FECHA FINAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FECHA INICIAL";
            // 
            // cbProductosDetalle
            // 
            this.cbProductosDetalle.AutoSize = true;
            this.cbProductosDetalle.Location = new System.Drawing.Point(733, 21);
            this.cbProductosDetalle.Name = "cbProductosDetalle";
            this.cbProductosDetalle.Size = new System.Drawing.Size(153, 17);
            this.cbProductosDetalle.TabIndex = 5;
            this.cbProductosDetalle.Text = "Incluir Productos Resumen";
            this.cbProductosDetalle.UseVisualStyleBackColor = true;
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(186, 25);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(300, 21);
            this.cbFamilia.TabIndex = 2;
            this.cbFamilia.SelectedIndexChanged += new System.EventHandler(this.cbFamilia_SelectedIndexChanged);
            this.cbFamilia.SelectedValueChanged += new System.EventHandler(this.cbFamilia_SelectedValueChanged);
            // 
            // cbProductos
            // 
            this.cbProductos.AutoSize = true;
            this.cbProductos.Location = new System.Drawing.Point(733, 4);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(141, 17);
            this.cbProductos.TabIndex = 4;
            this.cbProductos.Text = "Incluir Productos Detalle";
            this.cbProductos.UseVisualStyleBackColor = true;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CustomFormat = "dd-MMM-yyyy";
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFin.Location = new System.Drawing.Point(98, 26);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(82, 20);
            this.dtFechaFin.TabIndex = 1;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaFin_ValueChanged);
            // 
            // rbCobradores
            // 
            this.rbCobradores.AutoSize = true;
            this.rbCobradores.Location = new System.Drawing.Point(579, 3);
            this.rbCobradores.Name = "rbCobradores";
            this.rbCobradores.Size = new System.Drawing.Size(79, 17);
            this.rbCobradores.TabIndex = 3;
            this.rbCobradores.Text = "Cobradores";
            this.rbCobradores.UseVisualStyleBackColor = true;
            this.rbCobradores.CheckedChanged += new System.EventHandler(this.rbCobradores_CheckedChanged);
            // 
            // dtFechaIni
            // 
            this.dtFechaIni.CustomFormat = "dd-MMM-yyyy";
            this.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaIni.Location = new System.Drawing.Point(7, 26);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Size = new System.Drawing.Size(85, 20);
            this.dtFechaIni.TabIndex = 0;
            this.dtFechaIni.ValueChanged += new System.EventHandler(this.dtFechaIni_ValueChanged);
            // 
            // rbTipoDistr
            // 
            this.rbTipoDistr.AutoSize = true;
            this.rbTipoDistr.Checked = true;
            this.rbTipoDistr.Location = new System.Drawing.Point(426, 2);
            this.rbTipoDistr.Name = "rbTipoDistr";
            this.rbTipoDistr.Size = new System.Drawing.Size(70, 17);
            this.rbTipoDistr.TabIndex = 2;
            this.rbTipoDistr.TabStop = true;
            this.rbTipoDistr.Text = "Tipo Dist.";
            this.rbTipoDistr.UseVisualStyleBackColor = true;
            this.rbTipoDistr.CheckedChanged += new System.EventHandler(this.rbTipoDistr_CheckedChanged);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(358, 3);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(62, 17);
            this.rbClientes.TabIndex = 0;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rbClientes_CheckedChanged);
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(502, 2);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 1;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ErpGaceta.Properties.Resources.VIEW21B;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Procesar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::ErpGaceta.Properties.Resources.Print;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Imprimir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::ErpGaceta.Properties.Resources.Ret;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Cerrar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // frmCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 524);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmCobranza";
            this.Text = "Cobranzas";
            this.Load += new System.EventHandler(this.frmCobranza_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFamilia;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaIni;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button butProcess;
        private System.Windows.Forms.Button butPrint;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.CheckBox cbProductosDetalle;
        private System.Windows.Forms.CheckBox cbProductos;
        private System.Windows.Forms.RadioButton rbCobradores;
        private System.Windows.Forms.RadioButton rbTipoDistr;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}