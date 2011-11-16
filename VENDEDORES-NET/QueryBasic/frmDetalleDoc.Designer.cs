namespace QueryBasic
{
    partial class frmDetalleDoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dteFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOtros = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgDetalleDoc = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.txtDctoSV = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.txtDctoV = new System.Windows.Forms.TextBox();
            this.txtDctoP = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dteFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dceFechaAnulacion = new System.Windows.Forms.DateTimePicker();
            this.txtPagos = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.cmdDetallePago = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDoc)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dteFecha);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(2, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox4.Location = new System.Drawing.Point(114, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "FECHA EMIS.";
            // 
            // dteFecha
            // 
            this.dteFecha.CustomFormat = "dd-MMM-yy";
            this.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteFecha.Location = new System.Drawing.Point(114, 34);
            this.dteFecha.Name = "dteFecha";
            this.dteFecha.Size = new System.Drawing.Size(96, 20);
            this.dteFecha.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumero.Location = new System.Drawing.Point(42, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(65, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Text = "9999999";
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.Info;
            this.txtSerie.Location = new System.Drawing.Point(7, 35);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(29, 20);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.Text = "999";
            // 
            // txtRef
            // 
            this.txtRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtRef.Location = new System.Drawing.Point(7, 9);
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.Size = new System.Drawing.Size(100, 20);
            this.txtRef.TabIndex = 0;
            this.txtRef.Text = "SERIE Y N° FACT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOtros);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(226, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtOtros
            // 
            this.txtOtros.BackColor = System.Drawing.SystemColors.Info;
            this.txtOtros.Location = new System.Drawing.Point(6, 33);
            this.txtOtros.Name = "txtOtros";
            this.txtOtros.ReadOnly = true;
            this.txtOtros.Size = new System.Drawing.Size(218, 20);
            this.txtOtros.TabIndex = 7;
            this.txtOtros.Text = "9999999";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox12.Location = new System.Drawing.Point(6, 13);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(159, 20);
            this.textBox12.TabIndex = 6;
            this.textBox12.Text = "OTROS DATOS DE INTERES";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDNI);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.txtRUC);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(2, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.Info;
            this.txtDNI.Location = new System.Drawing.Point(380, 10);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(68, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.Text = "10429365";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox10.Location = new System.Drawing.Point(342, 10);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(32, 20);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "DNI";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox9.Location = new System.Drawing.Point(165, 10);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(86, 20);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "CODIGO / RUC";
            // 
            // txtRUC
            // 
            this.txtRUC.BackColor = System.Drawing.SystemColors.Info;
            this.txtRUC.Location = new System.Drawing.Point(254, 10);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.ReadOnly = true;
            this.txtRUC.Size = new System.Drawing.Size(82, 20);
            this.txtRUC.TabIndex = 6;
            this.txtRUC.Text = "1010429365-0";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox7.Location = new System.Drawing.Point(12, 10);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(123, 20);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = "DATOS DEL CLIENTE";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Info;
            this.txtDireccion.Location = new System.Drawing.Point(12, 54);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(436, 20);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Text = "SERIE Y N° FACT";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombre.Location = new System.Drawing.Point(12, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(436, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Text = "SERIE Y N° FACT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgDetalleDoc);
            this.groupBox4.Location = new System.Drawing.Point(2, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 276);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dgDetalleDoc
            // 
            this.dgDetalleDoc.AllowUserToAddRows = false;
            this.dgDetalleDoc.AllowUserToDeleteRows = false;
            this.dgDetalleDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleDoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDetalleDoc.Location = new System.Drawing.Point(7, 14);
            this.dgDetalleDoc.Name = "dgDetalleDoc";
            this.dgDetalleDoc.ReadOnly = true;
            this.dgDetalleDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalleDoc.Size = new System.Drawing.Size(711, 256);
            this.dgDetalleDoc.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox18);
            this.groupBox5.Controls.Add(this.txtVendedor);
            this.groupBox5.Controls.Add(this.txtReferencia);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(456, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 88);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox18.Location = new System.Drawing.Point(7, 37);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(203, 20);
            this.textBox18.TabIndex = 5;
            this.textBox18.Text = "DATOS DEL EJECUTIVO DE VENTAS";
            // 
            // txtVendedor
            // 
            this.txtVendedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtVendedor.Location = new System.Drawing.Point(7, 58);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(251, 20);
            this.txtVendedor.TabIndex = 4;
            this.txtVendedor.Text = "SERIE Y N° FACT";
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.SystemColors.Info;
            this.txtReferencia.Location = new System.Drawing.Point(7, 13);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.ReadOnly = true;
            this.txtReferencia.Size = new System.Drawing.Size(251, 20);
            this.txtReferencia.TabIndex = 3;
            this.txtReferencia.Text = "SERIE Y N° FACT";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotal);
            this.groupBox6.Controls.Add(this.txtIGV);
            this.groupBox6.Controls.Add(this.txtSubTotal);
            this.groupBox6.Controls.Add(this.textBox24);
            this.groupBox6.Controls.Add(this.textBox23);
            this.groupBox6.Controls.Add(this.textBox22);
            this.groupBox6.Controls.Add(this.txtDctoSV);
            this.groupBox6.Controls.Add(this.textBox17);
            this.groupBox6.Controls.Add(this.txtDctoV);
            this.groupBox6.Controls.Add(this.txtDctoP);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(2, 410);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(611, 61);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotal.Location = new System.Drawing.Point(510, 35);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(95, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "9999999";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIGV
            // 
            this.txtIGV.BackColor = System.Drawing.SystemColors.Info;
            this.txtIGV.Location = new System.Drawing.Point(409, 35);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.ReadOnly = true;
            this.txtIGV.Size = new System.Drawing.Size(95, 20);
            this.txtIGV.TabIndex = 11;
            this.txtIGV.Text = "9999999";
            this.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtSubTotal.Location = new System.Drawing.Point(308, 35);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(95, 20);
            this.txtSubTotal.TabIndex = 10;
            this.txtSubTotal.Text = "9999999";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox24.Location = new System.Drawing.Point(510, 9);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(95, 20);
            this.textBox24.TabIndex = 9;
            this.textBox24.Text = "TOTAL";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox23.Location = new System.Drawing.Point(409, 9);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(95, 20);
            this.textBox23.TabIndex = 8;
            this.textBox23.Text = "I.G.V.";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox22.Location = new System.Drawing.Point(308, 9);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(95, 20);
            this.textBox22.TabIndex = 7;
            this.textBox22.Text = "SUB TOTAL";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDctoSV
            // 
            this.txtDctoSV.BackColor = System.Drawing.SystemColors.Info;
            this.txtDctoSV.Location = new System.Drawing.Point(153, 35);
            this.txtDctoSV.Name = "txtDctoSV";
            this.txtDctoSV.ReadOnly = true;
            this.txtDctoSV.Size = new System.Drawing.Size(140, 20);
            this.txtDctoSV.TabIndex = 6;
            this.txtDctoSV.Text = "9999999";
            this.txtDctoSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox17.Location = new System.Drawing.Point(153, 9);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(140, 20);
            this.textBox17.TabIndex = 5;
            this.textBox17.Text = "DSCTO S/VAL COMERC.";
            // 
            // txtDctoV
            // 
            this.txtDctoV.BackColor = System.Drawing.SystemColors.Info;
            this.txtDctoV.Location = new System.Drawing.Point(73, 35);
            this.txtDctoV.Name = "txtDctoV";
            this.txtDctoV.ReadOnly = true;
            this.txtDctoV.Size = new System.Drawing.Size(74, 20);
            this.txtDctoV.TabIndex = 4;
            this.txtDctoV.Text = "9999999";
            this.txtDctoV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDctoP
            // 
            this.txtDctoP.BackColor = System.Drawing.SystemColors.Info;
            this.txtDctoP.Location = new System.Drawing.Point(7, 35);
            this.txtDctoP.Name = "txtDctoP";
            this.txtDctoP.ReadOnly = true;
            this.txtDctoP.Size = new System.Drawing.Size(51, 20);
            this.txtDctoP.TabIndex = 3;
            this.txtDctoP.Text = "999";
            this.txtDctoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox14.Location = new System.Drawing.Point(7, 9);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(140, 20);
            this.textBox14.TabIndex = 1;
            this.textBox14.Text = "% Y VALOR DESCUENTO";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dteFechaPago);
            this.groupBox7.Controls.Add(this.dceFechaAnulacion);
            this.groupBox7.Controls.Add(this.txtPagos);
            this.groupBox7.Controls.Add(this.textBox33);
            this.groupBox7.Controls.Add(this.textBox35);
            this.groupBox7.Controls.Add(this.txtSituacion);
            this.groupBox7.Controls.Add(this.textBox38);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(2, 477);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(504, 61);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            // 
            // dteFechaPago
            // 
            this.dteFechaPago.CustomFormat = "dd-MMM-yy";
            this.dteFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteFechaPago.Location = new System.Drawing.Point(395, 32);
            this.dteFechaPago.Name = "dteFechaPago";
            this.dteFechaPago.Size = new System.Drawing.Size(96, 20);
            this.dteFechaPago.TabIndex = 14;
            this.dteFechaPago.Visible = false;
            // 
            // dceFechaAnulacion
            // 
            this.dceFechaAnulacion.CustomFormat = "dd-MMM-yy";
            this.dceFechaAnulacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dceFechaAnulacion.Location = new System.Drawing.Point(143, 32);
            this.dceFechaAnulacion.Name = "dceFechaAnulacion";
            this.dceFechaAnulacion.Size = new System.Drawing.Size(96, 20);
            this.dceFechaAnulacion.TabIndex = 13;
            // 
            // txtPagos
            // 
            this.txtPagos.BackColor = System.Drawing.SystemColors.Info;
            this.txtPagos.Location = new System.Drawing.Point(308, 32);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.ReadOnly = true;
            this.txtPagos.Size = new System.Drawing.Size(81, 20);
            this.txtPagos.TabIndex = 10;
            this.txtPagos.Text = "9999999";
            this.txtPagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox33.Location = new System.Drawing.Point(308, 9);
            this.textBox33.Name = "textBox33";
            this.textBox33.ReadOnly = true;
            this.textBox33.Size = new System.Drawing.Size(183, 20);
            this.textBox33.TabIndex = 7;
            this.textBox33.Text = "SITUACION DE PAGO / FECHA";
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox35.Location = new System.Drawing.Point(143, 9);
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(96, 20);
            this.textBox35.TabIndex = 5;
            this.textBox35.Text = "FECHA ANUL.";
            // 
            // txtSituacion
            // 
            this.txtSituacion.BackColor = System.Drawing.SystemColors.Info;
            this.txtSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacion.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacion.Location = new System.Drawing.Point(7, 35);
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.ReadOnly = true;
            this.txtSituacion.Size = new System.Drawing.Size(128, 20);
            this.txtSituacion.TabIndex = 4;
            this.txtSituacion.Text = "9999999";
            // 
            // textBox38
            // 
            this.textBox38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox38.Location = new System.Drawing.Point(7, 9);
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(128, 20);
            this.textBox38.TabIndex = 1;
            this.textBox38.Text = "SITUACION";
            // 
            // cmdDetallePago
            // 
            this.cmdDetallePago.Location = new System.Drawing.Point(512, 493);
            this.cmdDetallePago.Name = "cmdDetallePago";
            this.cmdDetallePago.Size = new System.Drawing.Size(84, 36);
            this.cmdDetallePago.TabIndex = 15;
            this.cmdDetallePago.Text = "DETALLE DE PAGO";
            this.cmdDetallePago.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Image = global::QueryBasic.Properties.Resources._return;
            this.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCerrar.Location = new System.Drawing.Point(566, 6);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(141, 39);
            this.cmdCerrar.TabIndex = 16;
            this.cmdCerrar.Text = "CERRAR";
            this.cmdCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click_1);
            // 
            // frmDetalleDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 542);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdDetallePago);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDetalleDoc";
            this.Text = "frmDetalleDoc";
            this.Load += new System.EventHandler(this.frmDetalleDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleDoc)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dteFecha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgDetalleDoc;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox txtDctoV;
        private System.Windows.Forms.TextBox txtDctoP;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox txtDctoSV;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dceFechaAnulacion;
        private System.Windows.Forms.TextBox txtPagos;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.Button cmdDetallePago;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.DateTimePicker dteFechaPago;
        
    }
}