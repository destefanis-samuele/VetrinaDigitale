namespace VetrinaDigitale.View
{
    partial class frmColori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColori));
            this.dgvColori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColori
            // 
            this.dgvColori.AllowUserToAddRows = false;
            this.dgvColori.AllowUserToDeleteRows = false;
            this.dgvColori.AllowUserToResizeColumns = false;
            this.dgvColori.AllowUserToResizeRows = false;
            this.dgvColori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColori.Location = new System.Drawing.Point(12, 12);
            this.dgvColori.Name = "dgvColori";
            this.dgvColori.ReadOnly = true;
            this.dgvColori.RowHeadersWidth = 51;
            this.dgvColori.RowTemplate.Height = 24;
            this.dgvColori.Size = new System.Drawing.Size(776, 279);
            this.dgvColori.TabIndex = 0;
            // 
            // frmColori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvColori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmColori";
            this.Text = "GESTIONE COLORI";
            this.Load += new System.EventHandler(this.frmColori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColori;
    }
}