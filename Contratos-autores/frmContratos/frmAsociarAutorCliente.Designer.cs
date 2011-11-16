namespace frmContratos
{
    partial class frmAsociarAutorCliente
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dg_AutoresClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdAcept = new System.Windows.Forms.Button();
            this.cmdAsociar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AutoresClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dg_AutoresClientes);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 312);
            this.panel3.TabIndex = 33;
            // 
            // dg_AutoresClientes
            // 
            this.dg_AutoresClientes.AllowUserToAddRows = false;
            this.dg_AutoresClientes.AllowUserToDeleteRows = false;
            this.dg_AutoresClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_AutoresClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AutoresClientes.Location = new System.Drawing.Point(3, 3);
            this.dg_AutoresClientes.Name = "dg_AutoresClientes";
            this.dg_AutoresClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_AutoresClientes.Size = new System.Drawing.Size(557, 301);
            this.dg_AutoresClientes.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdAcept);
            this.panel1.Controls.Add(this.cmdAsociar);
            this.panel1.Location = new System.Drawing.Point(581, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 309);
            this.panel1.TabIndex = 34;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = global::frmContratos.Properties.Resources.Cancelar;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCancel.Location = new System.Drawing.Point(3, 242);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(115, 59);
            this.cmdCancel.TabIndex = 15;
            this.cmdCancel.Text = "CERRAR";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdAcept
            // 
            this.cmdAcept.Image = global::frmContratos.Properties.Resources.Aceptar;
            this.cmdAcept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAcept.Location = new System.Drawing.Point(5, 172);
            this.cmdAcept.Name = "cmdAcept";
            this.cmdAcept.Size = new System.Drawing.Size(109, 64);
            this.cmdAcept.TabIndex = 14;
            this.cmdAcept.Text = "ACEPTAR";
            this.cmdAcept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAcept.UseVisualStyleBackColor = true;
            this.cmdAcept.Visible = false;
            this.cmdAcept.Click += new System.EventHandler(this.cmdAcept_Click);
            // 
            // cmdAsociar
            // 
            this.cmdAsociar.Image = global::frmContratos.Properties.Resources.Autores;
            this.cmdAsociar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdAsociar.Location = new System.Drawing.Point(3, 12);
            this.cmdAsociar.Name = "cmdAsociar";
            this.cmdAsociar.Size = new System.Drawing.Size(109, 57);
            this.cmdAsociar.TabIndex = 0;
            this.cmdAsociar.Text = "RELACIONAR";
            this.cmdAsociar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAsociar.UseVisualStyleBackColor = true;
            this.cmdAsociar.Click += new System.EventHandler(this.cmdAsociar_Click);
            // 
            // frmAsociarAutorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmAsociarAutorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAsociarAutorCliente";
            this.Load += new System.EventHandler(this.frmAsociarAutorCliente_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AutoresClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dg_AutoresClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdAsociar;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdAcept;
    }
}