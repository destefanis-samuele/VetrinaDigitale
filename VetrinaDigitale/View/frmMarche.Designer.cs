namespace VetrinaDigitale.View
{
    partial class frmMarche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarche));
            this.dgvMarche = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarche
            // 
            this.dgvMarche.AllowUserToAddRows = false;
            this.dgvMarche.AllowUserToDeleteRows = false;
            this.dgvMarche.AllowUserToResizeColumns = false;
            this.dgvMarche.AllowUserToResizeRows = false;
            this.dgvMarche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarche.Location = new System.Drawing.Point(12, 12);
            this.dgvMarche.Name = "dgvMarche";
            this.dgvMarche.ReadOnly = true;
            this.dgvMarche.RowHeadersWidth = 51;
            this.dgvMarche.RowTemplate.Height = 24;
            this.dgvMarche.Size = new System.Drawing.Size(776, 315);
            this.dgvMarche.TabIndex = 0;
            // 
            // frmMarche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMarche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMarche";
            this.Text = "GESTIONE MARCHE";
            this.Load += new System.EventHandler(this.frmMarche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarche;
    }
}