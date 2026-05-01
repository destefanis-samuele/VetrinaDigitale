namespace VetrinaDigitale.View
{
    partial class ucBaseGenerica
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
            this.btnNuovo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvDati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(588, 356);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(176, 67);
            this.btnElimina.TabIndex = 25;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(588, 256);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(176, 67);
            this.btnSalva.TabIndex = 24;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(588, 165);
            this.btnNuovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(176, 67);
            this.btnNuovo.TabIndex = 23;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(608, 79);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(270, 28);
            this.txtNome.TabIndex = 22;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(479, 83);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 21);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
            // 
            // dgvDati
            // 
            this.dgvDati.AllowUserToAddRows = false;
            this.dgvDati.AllowUserToDeleteRows = false;
            this.dgvDati.AllowUserToResizeColumns = false;
            this.dgvDati.AllowUserToResizeRows = false;
            this.dgvDati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDati.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDati.Location = new System.Drawing.Point(24, 30);
            this.dgvDati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDati.Name = "dgvDati";
            this.dgvDati.ReadOnly = true;
            this.dgvDati.RowHeadersWidth = 51;
            this.dgvDati.RowTemplate.Height = 24;
            this.dgvDati.Size = new System.Drawing.Size(410, 559);
            this.dgvDati.TabIndex = 20;
            this.dgvDati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDati_CellClick);
            // 
            // ucBaseGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvDati);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucBaseGenerica";
            this.Size = new System.Drawing.Size(894, 629);
            this.Load += new System.EventHandler(this.ucBaseGenerica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvDati;
    }
}
