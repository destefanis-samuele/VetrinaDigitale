namespace VetrinaDigitale.View
{
    partial class ucCitta
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
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.dgvCitta = new System.Windows.Forms.DataGridView();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.lblCAP = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.lblCitta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(150, 330);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(102, 43);
            this.btnElimina.TabIndex = 17;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(26, 330);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(102, 43);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // dgvCitta
            // 
            this.dgvCitta.AllowUserToAddRows = false;
            this.dgvCitta.AllowUserToDeleteRows = false;
            this.dgvCitta.AllowUserToResizeColumns = false;
            this.dgvCitta.AllowUserToResizeRows = false;
            this.dgvCitta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitta.Location = new System.Drawing.Point(300, 198);
            this.dgvCitta.Name = "dgvCitta";
            this.dgvCitta.ReadOnly = true;
            this.dgvCitta.RowHeadersWidth = 51;
            this.dgvCitta.RowTemplate.Height = 24;
            this.dgvCitta.Size = new System.Drawing.Size(419, 163);
            this.dgvCitta.TabIndex = 15;
            this.dgvCitta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitta_CellClick);
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(124, 279);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(133, 22);
            this.txtProvincia.TabIndex = 14;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(34, 279);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(63, 16);
            this.lblProvincia.TabIndex = 13;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(124, 235);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(133, 22);
            this.txtCAP.TabIndex = 12;
            // 
            // lblCAP
            // 
            this.lblCAP.AutoSize = true;
            this.lblCAP.Location = new System.Drawing.Point(34, 235);
            this.lblCAP.Name = "lblCAP";
            this.lblCAP.Size = new System.Drawing.Size(37, 16);
            this.lblCAP.TabIndex = 11;
            this.lblCAP.Text = "CAP:";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(124, 198);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(133, 22);
            this.txtCitta.TabIndex = 10;
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(34, 198);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(36, 16);
            this.lblCitta.TabIndex = 9;
            this.lblCitta.Text = "Città:";
            // 
            // ucCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvCitta);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.lblCAP);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.lblCitta);
            this.Name = "ucCitta";
            this.Size = new System.Drawing.Size(745, 571);
            this.Load += new System.EventHandler(this.ucCitta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.DataGridView dgvCitta;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.Label lblCAP;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label lblCitta;
    }
}
