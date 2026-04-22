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
            this.lblCitta.Location = new System.Drawing.Point(48, 31);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(36, 16);
            this.lblCitta.TabIndex = 0;
            this.lblCitta.Text = "Città:";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(138, 31);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(133, 22);
            this.txtCitta.TabIndex = 1;
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(138, 68);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(133, 22);
            this.txtCAP.TabIndex = 3;
            // 
            // lblCAP
            // 
            this.lblCAP.AutoSize = true;
            this.lblCAP.Location = new System.Drawing.Point(48, 68);
            this.lblCAP.Name = "lblCAP";
            this.lblCAP.Size = new System.Drawing.Size(37, 16);
            this.lblCAP.TabIndex = 2;
            this.lblCAP.Text = "CAP:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(138, 112);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(133, 22);
            this.txtProvincia.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(48, 112);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(63, 16);
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
            this.dgvCitta.Location = new System.Drawing.Point(314, 31);
            this.dgvCitta.Name = "dgvCitta";
            this.dgvCitta.ReadOnly = true;
            this.dgvCitta.RowHeadersWidth = 51;
            this.dgvCitta.RowTemplate.Height = 24;
            this.dgvCitta.Size = new System.Drawing.Size(419, 163);
            this.dgvCitta.TabIndex = 6;
            this.dgvCitta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitta_CellClick);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(40, 163);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(102, 43);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(164, 163);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(102, 43);
            this.btnElimina.TabIndex = 8;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // frmCitta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 235);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvCitta);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.lblCAP);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.lblCitta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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