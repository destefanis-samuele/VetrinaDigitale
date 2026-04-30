namespace VetrinaDigitale.View
{
    partial class ucClienti
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
            this.btnAggiungiCitta = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.cmbCitta = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAggiungiCitta
            // 
            this.btnAggiungiCitta.Location = new System.Drawing.Point(241, 450);
            this.btnAggiungiCitta.Name = "btnAggiungiCitta";
            this.btnAggiungiCitta.Size = new System.Drawing.Size(138, 51);
            this.btnAggiungiCitta.TabIndex = 29;
            this.btnAggiungiCitta.Text = "AGGIUNGI CITTA\'";
            this.btnAggiungiCitta.UseVisualStyleBackColor = true;
            this.btnAggiungiCitta.Click += new System.EventHandler(this.btnAggiungiCitta_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(529, 464);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(141, 51);
            this.btnElimina.TabIndex = 28;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(529, 388);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(141, 51);
            this.btnSalva.TabIndex = 27;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(529, 319);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(141, 51);
            this.btnNuovo.TabIndex = 26;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(104, 445);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(33, 16);
            this.lblCitta.TabIndex = 25;
            this.lblCitta.Text = "Città";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(261, 402);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(173, 22);
            this.txtTelefono.TabIndex = 24;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(318, 383);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(38, 402);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(167, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(96, 383);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(261, 338);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(173, 22);
            this.txtCognome.TabIndex = 20;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(318, 319);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(66, 16);
            this.lblCognome.TabIndex = 19;
            this.lblCognome.Text = "Cognome";
            // 
            // cmbCitta
            // 
            this.cmbCitta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitta.FormattingEnabled = true;
            this.cmbCitta.Location = new System.Drawing.Point(38, 464);
            this.cmbCitta.Name = "cmbCitta";
            this.cmbCitta.Size = new System.Drawing.Size(167, 24);
            this.cmbCitta.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(38, 338);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 22);
            this.txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(96, 319);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // dgvClienti
            // 
            this.dgvClienti.AllowUserToAddRows = false;
            this.dgvClienti.AllowUserToDeleteRows = false;
            this.dgvClienti.AllowUserToResizeColumns = false;
            this.dgvClienti.AllowUserToResizeRows = false;
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(18, 21);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.ReadOnly = true;
            this.dgvClienti.RowHeadersWidth = 51;
            this.dgvClienti.RowTemplate.Height = 24;
            this.dgvClienti.Size = new System.Drawing.Size(776, 277);
            this.dgvClienti.TabIndex = 15;
            this.dgvClienti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClienti_CellClick);
            // 
            // ucClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAggiungiCitta);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.cmbCitta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvClienti);
            this.Name = "ucClienti";
            this.Size = new System.Drawing.Size(813, 537);
            this.Load += new System.EventHandler(this.ucClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiCitta;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.ComboBox cmbCitta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvClienti;
    }
}
