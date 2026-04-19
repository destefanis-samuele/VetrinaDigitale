namespace VetrinaDigitale.View
{
    partial class frmTaglie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaglie));
            this.dgvTaglie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaglie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaglie
            // 
            this.dgvTaglie.AllowUserToAddRows = false;
            this.dgvTaglie.AllowUserToDeleteRows = false;
            this.dgvTaglie.AllowUserToResizeColumns = false;
            this.dgvTaglie.AllowUserToResizeRows = false;
            this.dgvTaglie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaglie.Location = new System.Drawing.Point(12, 12);
            this.dgvTaglie.Name = "dgvTaglie";
            this.dgvTaglie.ReadOnly = true;
            this.dgvTaglie.RowHeadersWidth = 51;
            this.dgvTaglie.RowTemplate.Height = 24;
            this.dgvTaglie.Size = new System.Drawing.Size(776, 282);
            this.dgvTaglie.TabIndex = 0;
            // 
            // frmTaglie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTaglie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaglie";
            this.Text = "GESTIONE TAGLIE";
            this.Load += new System.EventHandler(this.frmTaglie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaglie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaglie;
    }
}