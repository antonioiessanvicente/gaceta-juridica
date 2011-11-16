namespace QueryBasic
{
    partial class frmKardexVendedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMaterialEntergado = new System.Windows.Forms.DataGridView();
            this.bnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialEntergado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMaterialEntergado
            // 
            this.dgMaterialEntergado.AllowUserToAddRows = false;
            this.dgMaterialEntergado.AllowUserToDeleteRows = false;
            this.dgMaterialEntergado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaterialEntergado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgMaterialEntergado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaterialEntergado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMaterialEntergado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMaterialEntergado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMaterialEntergado.Location = new System.Drawing.Point(4, 36);
            this.dgMaterialEntergado.MultiSelect = false;
            this.dgMaterialEntergado.Name = "dgMaterialEntergado";
            this.dgMaterialEntergado.ReadOnly = true;
            this.dgMaterialEntergado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMaterialEntergado.Size = new System.Drawing.Size(721, 423);
            this.dgMaterialEntergado.TabIndex = 2;
            this.dgMaterialEntergado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgMaterialEntergado_MouseDoubleClick);
            // 
            // bnCerrar
            // 
            this.bnCerrar.Image = global::QueryBasic.Properties.Resources._return;
            this.bnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCerrar.Location = new System.Drawing.Point(4, 1);
            this.bnCerrar.Name = "bnCerrar";
            this.bnCerrar.Size = new System.Drawing.Size(112, 32);
            this.bnCerrar.TabIndex = 5;
            this.bnCerrar.Text = "CERRAR";
            this.bnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCerrar.UseVisualStyleBackColor = true;
            this.bnCerrar.Click += new System.EventHandler(this.bnCerrar_Click);
            // 
            // frmKardexVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 471);
            this.Controls.Add(this.bnCerrar);
            this.Controls.Add(this.dgMaterialEntergado);
            this.Name = "frmKardexVendedores";
            this.Text = "frmKardexVendedores";
            this.Load += new System.EventHandler(this.frmKardexVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterialEntergado)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dgMaterialEntergado;
        private System.Windows.Forms.Button bnCerrar;
    }
}