namespace VetrinaDigitale.View
{
    partial class frmGeneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneri));
            this.dgvGeneri = new System.Windows.Forms.DataGridView();
            this.lblGenere = new System.Windows.Forms.Label();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneri
            // 
            this.dgvGeneri.AllowUserToAddRows = false;
            this.dgvGeneri.AllowUserToDeleteRows = false;
            this.dgvGeneri.AllowUserToResizeColumns = false;
            this.dgvGeneri.AllowUserToResizeRows = false;
            this.dgvGeneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneri.Location = new System.Drawing.Point(12, 12);
            this.dgvGeneri.Name = "dgvGeneri";
            this.dgvGeneri.ReadOnly = true;
            this.dgvGeneri.RowHeadersWidth = 51;
            this.dgvGeneri.RowTemplate.Height = 24;
            this.dgvGeneri.Size = new System.Drawing.Size(193, 414);
            this.dgvGeneri.TabIndex = 0;
            this.dgvGeneri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneri_CellClick);
            // 
            // lblGenere
            // 
            this.lblGenere.AutoSize = true;
            this.lblGenere.Location = new System.Drawing.Point(268, 49);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(55, 16);
            this.lblGenere.TabIndex = 1;
            this.lblGenere.Text = "Genere:";
            // 
            // txtGenere
            // 
            this.txtGenere.Location = new System.Drawing.Point(329, 49);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(182, 22);
            this.txtGenere.TabIndex = 2;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(312, 249);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(141, 51);
            this.btnElimina.TabIndex = 16;
            this.btnElimina.Text = "ELIMINA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(312, 173);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(141, 51);
            this.btnSalva.TabIndex = 15;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(312, 104);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(141, 51);
            this.btnNuovo.TabIndex = 14;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // frmGeneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.dgvGeneri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneri";
            this.Text = "GESTIONE GENERI";
            this.Load += new System.EventHandler(this.frmGeneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneri;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNuovo;
    }
}