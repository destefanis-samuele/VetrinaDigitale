namespace VetrinaDigitale.View
{
    partial class ucResi
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScontrino = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.lblNumeroScontrino = new System.Windows.Forms.Label();
            this.dgvResi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScontrino
            // 
            this.txtScontrino.Location = new System.Drawing.Point(161, 43);
            this.txtScontrino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtScontrino.Name = "txtScontrino";
            this.txtScontrino.Size = new System.Drawing.Size(80, 28);
            this.txtScontrino.TabIndex = 0;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(292, 23);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(130, 66);
            this.btnCerca.TabIndex = 1;
            this.btnCerca.Text = "CERCA";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // lblNumeroScontrino
            // 
            this.lblNumeroScontrino.AutoSize = true;
            this.lblNumeroScontrino.Location = new System.Drawing.Point(33, 46);
            this.lblNumeroScontrino.Name = "lblNumeroScontrino";
            this.lblNumeroScontrino.Size = new System.Drawing.Size(108, 21);
            this.lblNumeroScontrino.TabIndex = 2;
            this.lblNumeroScontrino.Text = "Scontrino n°";
            // 
            // dgvResi
            // 
            this.dgvResi.AllowUserToAddRows = false;
            this.dgvResi.AllowUserToDeleteRows = false;
            this.dgvResi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResi.Location = new System.Drawing.Point(37, 108);
            this.dgvResi.MultiSelect = false;
            this.dgvResi.Name = "dgvResi";
            this.dgvResi.RowHeadersVisible = false;
            this.dgvResi.RowHeadersWidth = 51;
            this.dgvResi.RowTemplate.Height = 24;
            this.dgvResi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResi.Size = new System.Drawing.Size(903, 254);
            this.dgvResi.TabIndex = 3;
            // 
            // ucResi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvResi);
            this.Controls.Add(this.lblNumeroScontrino);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtScontrino);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucResi";
            this.Size = new System.Drawing.Size(967, 749);
            this.Load += new System.EventHandler(this.ucResi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScontrino;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Label lblNumeroScontrino;
        private System.Windows.Forms.DataGridView dgvResi;
    }
}
