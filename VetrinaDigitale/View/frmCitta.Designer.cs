namespace VetrinaDigitale.View
{
    partial class frmCitta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitta));
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.lblCAP = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.dgvCitta = new System.Windows.Forms.DataGridView();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(60, 41);
            this.lblCitta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(58, 21);
            this.lblCitta.TabIndex = 0;
            this.lblCitta.Text = "Città:";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(172, 41);
            this.txtCitta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(165, 28);
            this.txtCitta.TabIndex = 1;
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(172, 89);
            this.txtCAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(165, 28);
            this.txtCAP.TabIndex = 3;
            // 
            // lblCAP
            // 
            this.lblCAP.AutoSize = true;
            this.lblCAP.Location = new System.Drawing.Point(60, 89);
            this.lblCAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAP.Name = "lblCAP";
            this.lblCAP.Size = new System.Drawing.Size(52, 21);
            this.lblCAP.TabIndex = 2;
            this.lblCAP.Text = "CAP:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(172, 147);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(165, 28);
            this.txtProvincia.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(60, 147);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(86, 21);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Text = "Provincia";
            // 
            // dgvCitta
            // 
            this.dgvCitta.AllowUserToAddRows = false;
            this.dgvCitta.AllowUserToDeleteRows = false;
            this.dgvCitta.AllowUserToResizeColumns = false;
            this.dgvCitta.AllowUserToResizeRows = false;
            this.dgvCitta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitta.Location = new System.Drawing.Point(392, 41);
            this.dgvCitta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCitta.Name = "dgvCitta";
            this.dgvCitta.ReadOnly = true;
            this.dgvCitta.RowHeadersWidth = 51;
            this.dgvCitta.RowTemplate.Height = 24;
            this.dgvCitta.Size = new System.Drawing.Size(524, 214);
            this.dgvCitta.TabIndex = 6;
            this.dgvCitta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitta_CellClick);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(50, 214);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(128, 56);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(205, 214);
            this.btnElimina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(128, 56);
            this.btnElimina.TabIndex = 8;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // frmCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 308);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvCitta);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.lblCAP);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.lblCitta);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCitta";
            this.Text = "GESTIONE CITTA\'";
            this.Load += new System.EventHandler(this.frmCitta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.Label lblCAP;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.DataGridView dgvCitta;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnElimina;
    }
}