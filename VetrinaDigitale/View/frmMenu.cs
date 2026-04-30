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

        private void btnMagazzino_Click(object sender, EventArgs e)
        {
            frmMagazzino frmMagazzino = new frmMagazzino();
            frmMagazzino.Show();
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            frmClienti frmClienti = new frmClienti();
            frmClienti.Show();
        }

        private void btnVendite_Click(object sender, EventArgs e)
        {
            frmVendite frmVendite = new frmVendite();
            frmVendite.Show();
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            frmFornitori frmFornitori = new frmFornitori();
            frmFornitori.Show();
        }

        private void btnGeneri_Click(object sender, EventArgs e)
        {
            frmBaseGenerica frm = new frmBaseGenerica("GENERI", "genere", "idGenere", "GESTIONE GENERI");
            frm.ShowDialog();
        }

        private void btnMarche_Click(object sender, EventArgs e)
        {
            frmBaseGenerica frm = new frmBaseGenerica("MARCHE", "marca", "idMarca", "GESTIONE MARCHE");
            frm.ShowDialog();
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            frmBaseGenerica frm = new frmBaseGenerica("CATEGORIE", "categoria", "idCategoria", "GESTIONE CATEGORIE");
            frm.ShowDialog();
        }

        private void btnTaglie_Click(object sender, EventArgs e)
        {
            frmBaseGenerica frm = new frmBaseGenerica("TAGLIE", "taglia", "idTaglia", "GESTIONE TAGLIE");
            frm.ShowDialog();
        }

        private void btnColori_Click(object sender, EventArgs e)
        {
            frmBaseGenerica frm = new frmBaseGenerica("COLORI", "colore", "idColore", "GESTIONE COLORI");
            frm.ShowDialog();
        }
    }
}
