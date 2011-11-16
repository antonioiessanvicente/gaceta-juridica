namespace QueryBasic
{
    partial class frmDetalleKardex
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
            this.bnCerrar = new System.Windows.Forms.Button();
            this.dgKardexDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKardexDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCerrar
            // 
            this.bnCerrar.Image = global::QueryBasic.Properties.Resources._return;
            this.bnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCerrar.Location = new System.Drawing.Point(2, 3);
            this.bnCerrar.Name = "bnCerrar";
            this.bnCerrar.Size = new System.Drawing.Size(112, 32);
            this.bnCerrar.TabIndex = 7;
            this.bnCerrar.Text = "CERRAR";
            this.bnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCerrar.UseVisualStyleBackColor = true;
            this.bnCerrar.Click += new System.EventHandler(this.bnCerrar_Click);
            // 
            // dgKardexDetalle
            // 
            this.dgKardexDetalle.AllowUserToAddRows = false;
            this.dgKardexDetalle.AllowUserToDeleteRows = false;
            this.dgKardexDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKardexDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgKardexDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKardexDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKardexDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKardexDetalle.Location = new System.Drawing.Point(2, 38);
            this.dgKardexDetalle.MultiSelect = false;
            this.dgKardexDetalle.Name = "dgKardexDetalle";
            this.dgKardexDetalle.ReadOnly = true;
            this.dgKardexDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKardexDetalle.Size = new System.Drawing.Size(679, 505);
            this.dgKardexDetalle.TabIndex = 6;
            this.dgKardexDetalle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgMaterialEntergado_MouseDoubleClick);
            // 
            // frmDetalleKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 555);
            this.Controls.Add(this.bnCerrar);
            this.Controls.Add(this.dgKardexDetalle);
            this.Name = "frmDetalleKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDetalleKardex";
            this.Load += new System.EventHandler(this.frmDetalleKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKardexDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnCerrar;
        private System.Windows.Forms.DataGridView dgKardexDetalle;
    }
}