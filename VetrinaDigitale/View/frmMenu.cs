using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace VetrinaDigitale.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lblDescrizione.Text = "";
        }

        private void MostraSchermata(UserControl control)
        {
            panelContenuto.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenuto.Controls.Add(control);
        }

        public void AggiornaLbl(string testo)
        {
            lblDescrizione.Text = testo;
        }

        private void btnMagazzino_Click(object sender, EventArgs e)
        {
            ucMagazzino ucMagazzino = new ucMagazzino("Gestione magazzino");
            MostraSchermata(ucMagazzino);
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            ucClienti ucClienti = new ucClienti("Gestione clienti");
            MostraSchermata(ucClienti);
        }

        private void btnVendite_Click(object sender, EventArgs e)
        {
            ucVendite ucVendite = new ucVendite("Gestione vendite");
            MostraSchermata(ucVendite);
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            ucFornitori ucFornitori = new ucFornitori("Gestione fornitori");
            MostraSchermata(ucFornitori);
        }

        private void btnOrdini_Click(object sender, EventArgs e)
        {
            ucOrdini uc = new ucOrdini("Gestione ordini");
            MostraSchermata(uc);
        }
        private void btnGeneri_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("GENERI", "genere", "idGenere", "Gestione generi", "PRODOTTI", "idGenere");
            MostraSchermata(uc);
        }

        private void btnMarche_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("MARCHE", "marca", "idMarca", "Gestione marche", "PRODOTTI", "idMarca");
            MostraSchermata(uc);
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("CATEGORIE", "categoria", "idCategoria", "Gestione categorie", "PRODOTTI", "idCategoria");
            MostraSchermata(uc);
        }

        private void btnTaglie_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("TAGLIE", "taglia", "idTaglia", "Gestione taglie", "VARIANTI_PRODOTTO", "idTaglia");
            MostraSchermata(uc);
        }

        private void btnColori_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("COLORI", "colore", "idColore", "Gestione colori", "VARIANTI_PRODOTTO", "idColore");
            MostraSchermata(uc);
        }

        private void btnResi_Click(object sender, EventArgs e)
        {
            ucResi ucResi = new ucResi("Gestione resi");
            MostraSchermata(ucResi);
        }
    }
}
