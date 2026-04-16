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
            this.dgvGeneri.Size = new System.Drawing.Size(776, 275);
            this.dgvGeneri.TabIndex = 0;
            // 
            // frmGeneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGeneri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGeneri";
            this.Text = "GESTIONE GENERI";
            this.Load += new System.EventHandler(this.frmGeneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneri;
    }
}