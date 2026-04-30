using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using VetrinaDigitale.Controller;

namespace VetrinaDigitale.View
{
    public partial class frmGeneri : Form
    {
        public frmGeneri()
        {
            InitializeComponent();
        }

        clsGeneriController generiController;

        private void frmGeneri_Load(object sender, EventArgs e)
        {
            generiController = new clsGeneriController();

            caricaDgvGeneri();
        }

        private void caricaDgvGeneri()
        {
            dgvGeneri.DataSource = null;
            dgvGeneri.DataSource = generiController.GetAllGeneri();
            dgvGeneri.Columns["idGenere"].Visible = false;
            dgvGeneri.AutoResizeRows();
            dgvGeneri.AutoResizeColumns();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            string genere = txtGenere.Text.Trim();
            if (!generiController.ControllaGenere(genere))
            {
                generiController.InserisciGenere(genere);
                Reset();
            }
            else
                MessageBox.Show("Il genere esiste già.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dgvGeneri.CurrentRow == null)
            {
                MessageBox.Show("Selezionare un genere da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string genere = txtGenere.Text.Trim();
            if (!generiController.ControllaGenere(genere))
            {
                int idGenere = Convert.ToInt32(dgvGeneri.CurrentRow.Cells["idGenere"].Value);
                generiController.AggiornaGenere(idGenere, genere);
                Reset();
            }
            else
            {
                MessageBox.Show("Il genere esiste già.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvGeneri.CurrentRow == null)
            {
                MessageBox.Show("Selezionare un genere da eliminare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idGenere = Convert.ToInt32(dgvGeneri.CurrentRow.Cells["idGenere"].Value);
            if (generiController.ControllaIdGenere(idGenere))
            {
                MessageBox.Show("Non è possibile eliminare questo genere perché è associato a uno o più prodotti.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                generiController.EliminaGenere(idGenere);
                Reset();
            }
        }

        private void dgvGeneri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            if (riga >= 0)
                txtGenere.Text = dgvGeneri.Rows[riga].Cells["genere"].Value.ToString();
        }

        private void Reset()
        {
            txtGenere.Text = "";
            caricaDgvGeneri();
        }
    }
}
