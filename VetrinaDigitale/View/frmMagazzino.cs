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
    public partial class frmMagazzino : Form
    {
        clsMagazzinoController magazzinoController;
        public frmMagazzino()
        {
            InitializeComponent();
            CaricaProdotti();
        }

        private void CaricaProdotti()
        {
            try
            {
                magazzinoController = new clsMagazzinoController();
                DataTable dt = magazzinoController.GetProdotti();
                dgvMagazzino.DataSource = null;
                dgvMagazzino.DataSource = dt;
                dgvMagazzino.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore caricamento prodotti: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
