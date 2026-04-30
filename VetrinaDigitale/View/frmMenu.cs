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
        }

        private void MostraSchermata(UserControl control)
        {
            panelContenuto.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenuto.Controls.Add(control);
        }

        private void btnMagazzino_Click(object sender, EventArgs e)
        {
            //frmMagazzino frmMagazzino = new frmMagazzino();
            //frmMagazzino.Show();

            ucMagazzino ucMagazzino = new ucMagazzino();
            MostraSchermata(ucMagazzino);
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            //frmClienti frmClienti = new frmClienti();
            //frmClienti.Show();

            ucClienti ucClienti = new ucClienti();
            MostraSchermata(ucClienti);
        }

        private void btnVendite_Click(object sender, EventArgs e)
        {
            //frmVendite frmVendite = new frmVendite();
            //frmVendite.Show();

            ucVendite ucVendite = new ucVendite();
            MostraSchermata(ucVendite);
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            //frmFornitori frmFornitori = new frmFornitori();
            //frmFornitori.Show();

            ucFornitori ucFornitori = new ucFornitori();
            MostraSchermata(ucFornitori);
        }

        private void btnGeneri_Click(object sender, EventArgs e)
        {
            //frmBaseGenerica frm = new frmBaseGenerica("GENERI", "genere", "idGenere", "GESTIONE GENERI", "PRODOTTI", "idGenere");
            //frm.ShowDialog();

            ucBaseGenerica uc = new ucBaseGenerica("GENERI", "genere", "idGenere", "GESTIONE GENERI", "PRODOTTI", "idGenere");
            MostraSchermata(uc);
        }

        private void btnMarche_Click(object sender, EventArgs e)
        {
            //frmBaseGenerica frm = new frmBaseGenerica("MARCHE", "marca", "idMarca", "GESTIONE MARCHE", "PRODOTTI", "idMarca");
            //frm.ShowDialog();

            ucBaseGenerica uc = new ucBaseGenerica("MARCHE", "marca", "idMarca", "GESTIONE MARCHE", "PRODOTTI", "idMarca");
            MostraSchermata(uc);
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            //frmBaseGenerica frm = new frmBaseGenerica("CATEGORIE", "categoria", "idCategoria", "GESTIONE CATEGORIE", "PRODOTTI", "idCategoria");
            //frm.ShowDialog();

            ucBaseGenerica uc = new ucBaseGenerica("CATEGORIE", "categoria", "idCategoria", "GESTIONE CATEGORIE", "PRODOTTI", "idCategoria");
            MostraSchermata(uc);
        }

        private void btnTaglie_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("TAGLIE", "taglia", "idTaglia", "GESTIONE TAGLIE", "VARIANTI_PRODOTTO", "idTaglia");
            MostraSchermata(uc);
        }

        private void btnColori_Click(object sender, EventArgs e)
        {
            ucBaseGenerica uc = new ucBaseGenerica("COLORI", "colore", "idColore", "GESTIONE COLORI", "VARIANTI_PRODOTTO", "idColore");
            MostraSchermata(uc);
        }
    }
}
