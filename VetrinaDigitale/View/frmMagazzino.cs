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
using VetrinaDigitale.Controller;

namespace VetrinaDigitale.View
{
    public partial class frmMagazzino : Form
    {
        clsMagazzinoController magazzinoController;
        public frmMagazzino()
        {
            InitializeComponent();
        }

        /*
         * ATT!!!
         * Colorare le righe della dgv se la qtà disp è <:
         * - 5 --> giallo
         * - 0 --> rosso
         */

        private void frmMagazzino_Load(object sender, EventArgs e)
        {
            magazzinoController = new clsMagazzinoController();

            CaricaProdotti();
        }

        private void CaricaProdotti()
        {
            try
            {
                dgvMagazzino.DataSource = null;
                dgvMagazzino.DataSource = magazzinoController.GetAllProdotti();
                dgvMagazzino.Columns["idVariante"].Visible = false;
                dgvMagazzino.AutoResizeRows();
                dgvMagazzino.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore caricamento prodotti: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
