namespace VetrinaDigitale.View
{
    partial class ucOrdini
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
            this.lblFornitore = new System.Windows.Forms.Label();
            this.cmbFornitore = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProdotto = new System.Windows.Forms.Label();
            this.cmbProdotto = new System.Windows.Forms.ComboBox();
            this.cmbVariante = new System.Windows.Forms.ComboBox();
            this.lblVariante = new System.Windows.Forms.Label();
            this.lblQta = new System.Windows.Forms.Label();
            this.nudQta = new System.Windows.Forms.NumericUpDown();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dgvRighe = new System.Windows.Forms.DataGridView();
            this.lblScritta = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRighe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFornitore
            // 
            this.lblFornitore.AutoSize = true;
            this.lblFornitore.Location = new System.Drawing.Point(58, 63);
            this.lblFornitore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFornitore.Name = "lblFornitore";
            this.lblFornitore.Size = new System.Drawing.Size(86, 21);
            this.lblFornitore.TabIndex = 0;
            this.lblFornitore.Text = "Fornitore:";
            // 
            // cmbFornitore
            // 
            this.cmbFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornitore.FormattingEnabled = true;
            this.cmbFornitore.Location = new System.Drawing.Point(158, 59);
            this.cmbFornitore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFornitore.Name = "cmbFornitore";
            this.cmbFornitore.Size = new System.Drawing.Size(205, 29);
            this.cmbFornitore.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(606, 76);
            this.dtpData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(249, 28);
            this.dtpData.TabIndex = 2;
            this.dtpData.Value = new System.DateTime(2026, 5, 1, 16, 20, 50, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(506, 84);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(59, 21);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // lblProdotto
            // 
            this.lblProdotto.AutoSize = true;
            this.lblProdotto.Location = new System.Drawing.Point(58, 168);
            this.lblProdotto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdotto.Name = "lblProdotto";
            this.lblProdotto.Size = new System.Drawing.Size(89, 21);
            this.lblProdotto.TabIndex = 4;
            this.lblProdotto.Text = "Prodotto:";
            // 
            // cmbProdotto
            // 
            this.cmbProdotto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdotto.FormattingEnabled = true;
            this.cmbProdotto.Location = new System.Drawing.Point(158, 168);
            this.cmbProdotto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProdotto.Name = "cmbProdotto";
            this.cmbProdotto.Size = new System.Drawing.Size(205, 29);
            this.cmbProdotto.TabIndex = 5;
            this.cmbProdotto.SelectedIndexChanged += new System.EventHandler(this.cmbProdotto_SelectedIndexChanged);
            // 
            // cmbVariante
            // 
            this.cmbVariante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariante.FormattingEnabled = true;
            this.cmbVariante.Location = new System.Drawing.Point(158, 230);
            this.cmbVariante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVariante.Name = "cmbVariante";
            this.cmbVariante.Size = new System.Drawing.Size(205, 29);
            this.cmbVariante.TabIndex = 7;
            // 
            // lblVariante
            // 
            this.lblVariante.AutoSize = true;
            this.lblVariante.Location = new System.Drawing.Point(58, 230);
            this.lblVariante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariante.Name = "lblVariante";
            this.lblVariante.Size = new System.Drawing.Size(83, 21);
            this.lblVariante.TabIndex = 6;
            this.lblVariante.Text = "Variante";
            // 
            // lblQta
            // 
            this.lblQta.AutoSize = true;
            this.lblQta.Location = new System.Drawing.Point(58, 295);
            this.lblQta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQta.Name = "lblQta";
            this.lblQta.Size = new System.Drawing.Size(91, 21);
            this.lblQta.TabIndex = 8;
            this.lblQta.Text = "Quantità:";
            // 
            // nudQta
            // 
            this.nudQta.Location = new System.Drawing.Point(158, 295);
            this.nudQta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQta.Name = "nudQta";
            this.nudQta.Size = new System.Drawing.Size(150, 28);
            this.nudQta.TabIndex = 9;
            this.nudQta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(58, 361);
            this.lblPrezzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(66, 21);
            this.lblPrezzo.TabIndex = 10;
            this.lblPrezzo.Text = "Prezzo:";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(158, 361);
            this.txtPrezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(205, 28);
            this.txtPrezzo.TabIndex = 11;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(118, 425);
            this.btnAggiungi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(119, 41);
            this.btnAggiungi.TabIndex = 12;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvRighe
            // 
            this.dgvRighe.AllowUserToAddRows = false;
            this.dgvRighe.AllowUserToDeleteRows = false;
            this.dgvRighe.AllowUserToResizeColumns = false;
            this.dgvRighe.AllowUserToResizeRows = false;
            this.dgvRighe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRighe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRighe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnElimina});
            this.dgvRighe.Location = new System.Drawing.Point(426, 168);
            this.dgvRighe.Name = "dgvRighe";
            this.dgvRighe.ReadOnly = true;
            this.dgvRighe.RowHeadersWidth = 51;
            this.dgvRighe.RowTemplate.Height = 24;
            this.dgvRighe.Size = new System.Drawing.Size(518, 278);
            this.dgvRighe.TabIndex = 13;
            this.dgvRighe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRighe_CellContentClick);
            // 
            // lblScritta
            // 
            this.lblScritta.AutoSize = true;
            this.lblScritta.Location = new System.Drawing.Point(478, 477);
            this.lblScritta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScritta.Name = "lblScritta";
            this.lblScritta.Size = new System.Drawing.Size(67, 21);
            this.lblScritta.TabIndex = 14;
            this.lblScritta.Text = "Totale:";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.ForeColor = System.Drawing.Color.Lime;
            this.lblTotale.Location = new System.Drawing.Point(614, 477);
            this.lblTotale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(70, 27);
            this.lblTotale.TabIndex = 15;
            this.lblTotale.Text = "€0.00";
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalva.Location = new System.Drawing.Point(244, 530);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(119, 41);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.BackColor = System.Drawing.Color.Red;
            this.btnAnnulla.Location = new System.Drawing.Point(581, 530);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(119, 41);
            this.btnAnnulla.TabIndex = 17;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = false;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.HeaderText = "Elimina";
            this.btnElimina.MinimumWidth = 6;
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.ReadOnly = true;
            this.btnElimina.Text = "❌";
            // 
            // ucOrdini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.lblScritta);
            this.Controls.Add(this.dgvRighe);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.nudQta);
            this.Controls.Add(this.lblQta);
            this.Controls.Add(this.cmbVariante);
            this.Controls.Add(this.lblVariante);
            this.Controls.Add(this.cmbProdotto);
            this.Controls.Add(this.lblProdotto);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cmbFornitore);
            this.Controls.Add(this.lblFornitore);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucOrdini";
            this.Size = new System.Drawing.Size(1122, 686);
            this.Load += new System.EventHandler(this.ucOrdini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRighe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFornitore;
        private System.Windows.Forms.ComboBox cmbFornitore;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProdotto;
        private System.Windows.Forms.ComboBox cmbProdotto;
        private System.Windows.Forms.ComboBox cmbVariante;
        private System.Windows.Forms.Label lblVariante;
        private System.Windows.Forms.Label lblQta;
        private System.Windows.Forms.NumericUpDown nudQta;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dgvRighe;
        private System.Windows.Forms.Label lblScritta;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.DataGridViewButtonColumn btnElimina;
    }
}
