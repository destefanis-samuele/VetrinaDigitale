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
            this.dgvMagazzino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMagazzino.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzino.Location = new System.Drawing.Point(20, 21);
            this.dgvMagazzino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.ReadOnly = true;
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.RowTemplate.Height = 24;
            this.dgvMagazzino.Size = new System.Drawing.Size(1056, 395);
            this.dgvMagazzino.TabIndex = 1;
            this.dgvMagazzino.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazzino_CellClick);
            // 
            // ucMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMagazzino);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucMagazzino";
            this.Size = new System.Drawing.Size(1091, 452);
            this.Load += new System.EventHandler(this.ucMagazzino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagazzino;
    }
}
