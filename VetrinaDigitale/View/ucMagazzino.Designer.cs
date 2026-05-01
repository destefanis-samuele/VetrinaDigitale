namespace VetrinaDigitale.View
{
    partial class ucMagazzino
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
            this.dgvMagazzino = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMagazzino
            // 
            this.dgvMagazzino.AllowUserToAddRows = false;
            this.dgvMagazzino.AllowUserToDeleteRows = false;
            this.dgvMagazzino.AllowUserToResizeColumns = false;
            this.dgvMagazzino.AllowUserToResizeRows = false;
            this.dgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzino.Location = new System.Drawing.Point(16, 16);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.ReadOnly = true;
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.RowTemplate.Height = 24;
            this.dgvMagazzino.Size = new System.Drawing.Size(845, 301);
            this.dgvMagazzino.TabIndex = 1;
            this.dgvMagazzino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazzino_CellClick);
            // 
            // ucMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMagazzino);
            this.Name = "ucMagazzino";
            this.Size = new System.Drawing.Size(873, 344);
            this.Load += new System.EventHandler(this.ucMagazzino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagazzino;
    }
}
