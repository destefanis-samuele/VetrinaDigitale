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
            frmGeneri frmGeneri = new frmGeneri();
            frmGeneri.Show();
        }

        private void btnMarche_Click(object sender, EventArgs e)
        {
            frmMarche frmMarche = new frmMarche();
            frmMarche.Show();
        }
    }
}
