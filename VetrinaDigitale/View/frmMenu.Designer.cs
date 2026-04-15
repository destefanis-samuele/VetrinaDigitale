namespace VetrinaDigitale.View
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnMagazzino = new System.Windows.Forms.Button();
            this.btnVendite = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnFornitori = new System.Windows.Forms.Button();
            this.btnOrdini = new System.Windows.Forms.Button();
            this.btnGeneri = new System.Windows.Forms.Button();
            this.btnMarche = new System.Windows.Forms.Button();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnTaglie = new System.Windows.Forms.Button();
            this.btnColori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMagazzino
            // 
            this.btnMagazzino.Location = new System.Drawing.Point(76, 47);
            this.btnMagazzino.Name = "btnMagazzino";
            this.btnMagazzino.Size = new System.Drawing.Size(122, 59);
            this.btnMagazzino.TabIndex = 0;
            this.btnMagazzino.Text = "MAGAZZINO";
            this.btnMagazzino.UseVisualStyleBackColor = true;
            this.btnMagazzino.Click += new System.EventHandler(this.btnMagazzino_Click);
            // 
            // btnVendite
            // 
            this.btnVendite.Location = new System.Drawing.Point(234, 47);
            this.btnVendite.Name = "btnVendite";
            this.btnVendite.Size = new System.Drawing.Size(122, 59);
            this.btnVendite.TabIndex = 1;
            this.btnVendite.Text = "VENDITE";
            this.btnVendite.UseVisualStyleBackColor = true;
            this.btnVendite.Click += new System.EventHandler(this.btnVendite_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(387, 47);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(122, 59);
            this.btnClienti.TabIndex = 2;
            this.btnClienti.Text = "CLIENTI";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnFornitori
            // 
            this.btnFornitori.Location = new System.Drawing.Point(537, 47);
            this.btnFornitori.Name = "btnFornitori";
            this.btnFornitori.Size = new System.Drawing.Size(122, 59);
            this.btnFornitori.TabIndex = 3;
            this.btnFornitori.Text = "FORNITORI";
            this.btnFornitori.UseVisualStyleBackColor = true;
            this.btnFornitori.Click += new System.EventHandler(this.btnFornitori_Click);
            // 
            // btnOrdini
            // 
            this.btnOrdini.Location = new System.Drawing.Point(76, 168);
            this.btnOrdini.Name = "btnOrdini";
            this.btnOrdini.Size = new System.Drawing.Size(122, 59);
            this.btnOrdini.TabIndex = 4;
            this.btnOrdini.Text = "ORDINI";
            this.btnOrdini.UseVisualStyleBackColor = true;
            // 
            // btnGeneri
            // 
            this.btnGeneri.Location = new System.Drawing.Point(234, 168);
            this.btnGeneri.Name = "btnGeneri";
            this.btnGeneri.Size = new System.Drawing.Size(122, 59);
            this.btnGeneri.TabIndex = 5;
            this.btnGeneri.Text = "GENERI";
            this.btnGeneri.UseVisualStyleBackColor = true;
            // 
            // btnMarche
            // 
            this.btnMarche.Location = new System.Drawing.Point(387, 168);
            this.btnMarche.Name = "btnMarche";
            this.btnMarche.Size = new System.Drawing.Size(122, 59);
            this.btnMarche.TabIndex = 6;
            this.btnMarche.Text = "MARCHE";
            this.btnMarche.UseVisualStyleBackColor = true;
            // 
            // btnCategorie
            // 
            this.btnCategorie.Location = new System.Drawing.Point(537, 168);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(122, 59);
            this.btnCategorie.TabIndex = 7;
            this.btnCategorie.Text = "CATEGORIE";
            this.btnCategorie.UseVisualStyleBackColor = true;
            // 
            // btnTaglie
            // 
            this.btnTaglie.Location = new System.Drawing.Point(76, 262);
            this.btnTaglie.Name = "btnTaglie";
            this.btnTaglie.Size = new System.Drawing.Size(122, 59);
            this.btnTaglie.TabIndex = 8;
            this.btnTaglie.Text = "TAGLIE";
            this.btnTaglie.UseVisualStyleBackColor = true;
            // 
            // btnColori
            // 
            this.btnColori.Location = new System.Drawing.Point(234, 262);
            this.btnColori.Name = "btnColori";
            this.btnColori.Size = new System.Drawing.Size(122, 59);
            this.btnColori.TabIndex = 9;
            this.btnColori.Text = "COLORI";
            this.btnColori.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColori);
            this.Controls.Add(this.btnTaglie);
            this.Controls.Add(this.btnCategorie);
            this.Controls.Add(this.btnMarche);
            this.Controls.Add(this.btnGeneri);
            this.Controls.Add(this.btnOrdini);
            this.Controls.Add(this.btnFornitori);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnVendite);
            this.Controls.Add(this.btnMagazzino);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "MENU\'";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMagazzino;
        private System.Windows.Forms.Button btnVendite;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnFornitori;
        private System.Windows.Forms.Button btnOrdini;
        private System.Windows.Forms.Button btnGeneri;
        private System.Windows.Forms.Button btnMarche;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnTaglie;
        private System.Windows.Forms.Button btnColori;
    }
}