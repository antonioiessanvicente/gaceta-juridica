namespace AccesosCds
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.txtNroPin = new System.Windows.Forms.TextBox();
            this.cmdValida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdDctaUno = new System.Windows.Forms.Button();
            this.cmdDctaTodos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProductos
            // 
            this.cbProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(13, 28);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(289, 24);
            this.cbProductos.TabIndex = 0;
            this.cbProductos.SelectedValueChanged += new System.EventHandler(this.cbProductos_SelectedValueChanged);
            // 
            // txtNroPin
            // 
            this.txtNroPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroPin.Location = new System.Drawing.Point(12, 75);
            this.txtNroPin.Name = "txtNroPin";
            this.txtNroPin.Size = new System.Drawing.Size(181, 22);
            this.txtNroPin.TabIndex = 1;
            this.txtNroPin.TextChanged += new System.EventHandler(this.txtNroPin_TextChanged);
            // 
            // cmdValida
            // 
            this.cmdValida.Location = new System.Drawing.Point(211, 59);
            this.cmdValida.Name = "cmdValida";
            this.cmdValida.Size = new System.Drawing.Size(91, 40);
            this.cmdValida.TabIndex = 2;
            this.cmdValida.Text = "VALIDAR";
            this.cmdValida.UseVisualStyleBackColor = true;
            this.cmdValida.Click += new System.EventHandler(this.cmdValida_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(13, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 147);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy HH:MM:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy HH:MM:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(86, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd-MMM-yyyy HH:MM:ss";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(86, 119);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1° Activ.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2° Activ.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3° Activ.";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(3, 4);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(283, 57);
            this.txtCliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRODUCTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "NUMERO PIN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdDctaTodos);
            this.panel2.Controls.Add(this.cmdDctaUno);
            this.panel2.Location = new System.Drawing.Point(12, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 36);
            this.panel2.TabIndex = 6;
            // 
            // cmdDctaUno
            // 
            this.cmdDctaUno.Location = new System.Drawing.Point(14, 4);
            this.cmdDctaUno.Name = "cmdDctaUno";
            this.cmdDctaUno.Size = new System.Drawing.Size(126, 23);
            this.cmdDctaUno.TabIndex = 0;
            this.cmdDctaUno.Text = "DESCONTAR 1";
            this.cmdDctaUno.UseVisualStyleBackColor = true;
            this.cmdDctaUno.Click += new System.EventHandler(this.cmdDctaUno_Click);
            // 
            // cmdDctaTodos
            // 
            this.cmdDctaTodos.Location = new System.Drawing.Point(146, 4);
            this.cmdDctaTodos.Name = "cmdDctaTodos";
            this.cmdDctaTodos.Size = new System.Drawing.Size(126, 23);
            this.cmdDctaTodos.TabIndex = 1;
            this.cmdDctaTodos.Text = "DESCONTAR TODOS";
            this.cmdDctaTodos.UseVisualStyleBackColor = true;
            this.cmdDctaTodos.Click += new System.EventHandler(this.cmdDctaTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 302);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdValida);
            this.Controls.Add(this.txtNroPin);
            this.Controls.Add(this.cbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACCESOS - ACTIVACION DE CD\'S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.TextBox txtNroPin;
        private System.Windows.Forms.Button cmdValida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdDctaTodos;
        private System.Windows.Forms.Button cmdDctaUno;
    }
}

