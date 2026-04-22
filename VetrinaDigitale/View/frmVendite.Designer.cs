namespace VetrinaDigitale.View
{
    partial class frmVendite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendite));
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.lblMetodoPagamento = new System.Windows.Forms.Label();
            this.lblPrototto = new System.Windows.Forms.Label();
            this.cmbProdotto = new System.Windows.Forms.ComboBox();
            this.cmbTaglia = new System.Windows.Forms.ComboBox();
            this.lblTaglia = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.lblColore = new System.Windows.Forms.Label();
            this.lblQta = new System.Windows.Forms.Label();
            this.nudQta = new System.Windows.Forms.NumericUpDown();
            this.lblQtaDisponibile = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dgvScontrino = new System.Windows.Forms.DataGridView();
            this.lblTotale = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.lblPrezzo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScontrino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(80, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(30, 28);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(158, 24);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbMetodoPagamento
            // 
            this.cmbMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPagamento.FormattingEnabled = true;
            this.cmbMetodoPagamento.Location = new System.Drawing.Point(276, 28);
            this.cmbMetodoPagamento.Name = "cmbMetodoPagamento";
            this.cmbMetodoPagamento.Size = new System.Drawing.Size(158, 24);
            this.cmbMetodoPagamento.TabIndex = 3;
            // 
            // lblMetodoPagamento
            // 
            this.lblMetodoPagamento.AutoSize = true;
            this.lblMetodoPagamento.Location = new System.Drawing.Point(297, 9);
            this.lblMetodoPagamento.Name = "lblMetodoPagamento";
            this.lblMetodoPagamento.Size = new System.Drawing.Size(125, 16);
            this.lblMetodoPagamento.TabIndex = 2;
            this.lblMetodoPagamento.Text = "Metodo pagamento";
            // 
            // lblPrototto
            // 
            this.lblPrototto.AutoSize = true;
            this.lblPrototto.Location = new System.Drawing.Point(27, 86);
            this.lblPrototto.Name = "lblPrototto";
            this.lblPrototto.Size = new System.Drawing.Size(61, 16);
            this.lblPrototto.TabIndex = 4;
            this.lblPrototto.Text = "Prodotto:";
            // 
            // cmbProdotto
            // 
            this.cmbProdotto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdotto.FormattingEnabled = true;
            this.cmbProdotto.Location = new System.Drawing.Point(121, 86);
            this.cmbProdotto.Name = "cmbProdotto";
            this.cmbProdotto.Size = new System.Drawing.Size(158, 24);
            this.cmbProdotto.TabIndex = 5;
            this.cmbProdotto.SelectedIndexChanged += new System.EventHandler(this.cmbProdotto_SelectedIndexChanged);
            // 
            // cmbTaglia
            // 
            this.cmbTaglia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaglia.FormattingEnabled = true;
            this.cmbTaglia.Location = new System.Drawing.Point(121, 158);
            this.cmbTaglia.Name = "cmbTaglia";
            this.cmbTaglia.Size = new System.Drawing.Size(158, 24);
            this.cmbTaglia.TabIndex = 7;
            this.cmbTaglia.SelectedIndexChanged += new System.EventHandler(this.cmbTaglia_SelectedIndexChanged);
            // 
            // lblTaglia
            // 
            this.lblTaglia.AutoSize = true;
            this.lblTaglia.Location = new System.Drawing.Point(27, 158);
            this.lblTaglia.Name = "lblTaglia";
            this.lblTaglia.Size = new System.Drawing.Size(49, 16);
            this.lblTaglia.TabIndex = 6;
            this.lblTaglia.Text = "Taglia:";
            // 
            // cmbColore
            // 
            this.cmbColore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Location = new System.Drawing.Point(121, 204);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(158, 24);
            this.cmbColore.TabIndex = 9;
            this.cmbColore.SelectedIndexChanged += new System.EventHandler(this.cmbColore_SelectedIndexChanged);
            // 
            // lblColore
            // 
            this.lblColore.AutoSize = true;
            this.lblColore.Location = new System.Drawing.Point(27, 204);
            this.lblColore.Name = "lblColore";
            this.lblColore.Size = new System.Drawing.Size(50, 16);
            this.lblColore.TabIndex = 8;
            this.lblColore.Text = "Colore:";
            // 
            // lblQta
            // 
            this.lblQta.AutoSize = true;
            this.lblQta.Location = new System.Drawing.Point(26, 250);
            this.lblQta.Name = "lblQta";
            this.lblQta.Size = new System.Drawing.Size(59, 16);
            this.lblQta.TabIndex = 10;
            this.lblQta.Text = "Quantità:";
            // 
            // nudQta
            // 
            this.nudQta.Location = new System.Drawing.Point(121, 248);
            this.nudQta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQta.Name = "nudQta";
            this.nudQta.ReadOnly = true;
            this.nudQta.Size = new System.Drawing.Size(120, 22);
            this.nudQta.TabIndex = 11;
            this.nudQta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQtaDisponibile
            // 
            this.lblQtaDisponibile.AutoSize = true;
            this.lblQtaDisponibile.Location = new System.Drawing.Point(100, 282);
            this.lblQtaDisponibile.Name = "lblQtaDisponibile";
            this.lblQtaDisponibile.Size = new System.Drawing.Size(42, 16);
            this.lblQtaDisponibile.TabIndex = 12;
            this.lblQtaDisponibile.Text = "prova";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(69, 320);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(109, 31);
            this.btnAggiungi.TabIndex = 13;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvScontrino
            // 
            this.dgvScontrino.AllowUserToAddRows = false;
            this.dgvScontrino.AllowUserToDeleteRows = false;
            this.dgvScontrino.AllowUserToResizeColumns = false;
            this.dgvScontrino.AllowUserToResizeRows = false;
            this.dgvScontrino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScontrino.Location = new System.Drawing.Point(300, 72);
            this.dgvScontrino.Name = "dgvScontrino";
            this.dgvScontrino.ReadOnly = true;
            this.dgvScontrino.RowHeadersWidth = 51;
            this.dgvScontrino.RowTemplate.Height = 24;
            this.dgvScontrino.Size = new System.Drawing.Size(488, 179);
            this.dgvScontrino.TabIndex = 14;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Location = new System.Drawing.Point(495, 279);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(42, 16);
            this.lblTotale.TabIndex = 15;
            this.lblTotale.Text = "prova";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(498, 354);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(109, 31);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.Text = "CONFERMA";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(118, 123);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(42, 16);
            this.lblPrezzo.TabIndex = 17;
            this.lblPrezzo.Text = "prova";
            // 
            // frmVendite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.lblTotale);
            this.Controls.Add(this.dgvScontrino);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.lblQtaDisponibile);
            this.Controls.Add(this.nudQta);
            this.Controls.Add(this.lblQta);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.lblColore);
            this.Controls.Add(this.cmbTaglia);
            this.Controls.Add(this.lblTaglia);
            this.Controls.Add(this.cmbProdotto);
            this.Controls.Add(this.lblPrototto);
            this.Controls.Add(this.cmbMetodoPagamento);
            this.Controls.Add(this.lblMetodoPagamento);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVendite";
            this.Text = "GESTIONE VENDITE";
            this.Load += new System.EventHandler(this.frmVendite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScontrino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbMetodoPagamento;
        private System.Windows.Forms.Label lblMetodoPagamento;
        private System.Windows.Forms.Label lblPrototto;
        private System.Windows.Forms.ComboBox cmbProdotto;
        private System.Windows.Forms.ComboBox cmbTaglia;
        private System.Windows.Forms.Label lblTaglia;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Label lblColore;
        private System.Windows.Forms.Label lblQta;
        private System.Windows.Forms.NumericUpDown nudQta;
        private System.Windows.Forms.Label lblQtaDisponibile;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dgvScontrino;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Label lblPrezzo;
    }
}