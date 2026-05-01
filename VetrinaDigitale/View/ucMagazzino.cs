using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetrinaDigitale.Controller;

namespace VetrinaDigitale.View
{
    public partial class ucMagazzino : UserControl
    {
        private string _testoLbl;
        public ucMagazzino(string testoLbl)
        {
            InitializeComponent();
            _testoLbl = testoLbl;
        }

        clsMagazzinoController magazzinoController;

        private void ucMagazzino_Load(object sender, EventArgs e)
        {
            magazzinoController = new clsMagazzinoController();

            CaricaProdotti();

            PopolaLbl();
        }

        private void PopolaLbl()
        {
            var menu = FindForm() as frmMenu;
            menu?.AggiornaLbl(_testoLbl);
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

        private void dgvMagazzino_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
