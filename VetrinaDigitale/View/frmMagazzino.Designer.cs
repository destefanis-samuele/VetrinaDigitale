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
            this.dgvMagazzino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzino.Location = new System.Drawing.Point(12, 12);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.ReadOnly = true;
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.RowTemplate.Height = 24;
            this.dgvMagazzino.Size = new System.Drawing.Size(776, 350);
            this.dgvMagazzino.TabIndex = 0;
            // 
            // frmMagazzino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMagazzino);
            this.Name = "frmMagazzino";
            this.Text = "frmMagazzino";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMagazzino;
    }
}