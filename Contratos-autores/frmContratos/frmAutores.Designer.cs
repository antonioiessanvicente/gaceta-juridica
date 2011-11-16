namespace frmContratos
{
    partial class frmAutores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdAcept = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dg_Contratos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Contratos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdAcept);
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 46);
            this.panel1.TabIndex = 0;
            // 
            // cmdAcept
            // 
            this.cmdAcept.Image = global::frmContratos.Properties.Resources.Cancelar;
            this.cmdAcept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAcept.Location = new System.Drawing.Point(415, 3);
            this.cmdAcept.Name = "cmdAcept";
            this.cmdAcept.Size = new System.Drawing.Size(119, 35);
            this.cmdAcept.TabIndex = 1;
            this.cmdAcept.Text = "CANCELAR";
            this.cmdAcept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAcept.UseVisualStyleBackColor = true;
            this.cmdAcept.Click += new System.EventHandler(this.cmdAcept_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Image = global::frmContratos.Properties.Resources.Aceptar;
            this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancel.Location = new System.Drawing.Point(42, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(137, 35);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "ACEPTAR";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dg_Contratos);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 402);
            this.panel2.TabIndex = 1;
            // 
            // dg_Contratos
            // 
            this.dg_Contratos.AllowUserToAddRows = false;
            this.dg_Contratos.AllowUserToDeleteRows = false;
            this.dg_Contratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Contratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Contratos.Location = new System.Drawing.Point(3, 3);
            this.dg_Contratos.Name = "dg_Contratos";
            this.dg_Contratos.Size = new System.Drawing.Size(549, 396);
            this.dg_Contratos.TabIndex = 29;
            // 
            // frmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ":::::     LISTA DE AUTORES      :::::";
            this.Load += new System.EventHandler(this.frmAutores_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Contratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dg_Contratos;
        private System.Windows.Forms.Button cmdAcept;
        private System.Windows.Forms.Button cmdCancel;
    }
}