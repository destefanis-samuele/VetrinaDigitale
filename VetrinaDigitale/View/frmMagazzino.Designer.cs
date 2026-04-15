namespace VetrinaDigitale.View
{
    partial class frmMagazzino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagazzino));
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
            this.dgvMagazzino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzino.Location = new System.Drawing.Point(12, 12);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.ReadOnly = true;
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.RowTemplate.Height = 24;
            this.dgvMagazzino.Size = new System.Drawing.Size(845, 342);
            this.dgvMagazzino.TabIndex = 0;
            // 
            // frmMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 443);
            this.Controls.Add(this.dgvMagazzino);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMagazzino";
            this.Text = "GESTIONE MAGAZZINO";
            this.Load += new System.EventHandler(this.frmMagazzino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagazzino;
    }
}