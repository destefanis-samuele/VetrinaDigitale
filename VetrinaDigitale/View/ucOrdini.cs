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
    public partial class ucOrdini : UserControl
    {
        private string _testoLbl;
        public ucOrdini(string testoLbl)
        {
            InitializeComponent();
            _testoLbl = testoLbl;
        }

        clsOrdiniController ordiniController = new clsOrdiniController();
        List<clsOrdiniController.RigaOrdine> righe = new List<clsOrdiniController.RigaOrdine>();

        private void ucOrdini_Load(object sender, EventArgs e)
        {
            caricaFornitori();
            caricaProdotti();
            PopolaLbl();
            btnElimina.Text = "❌";
        }

        private void PopolaLbl()
        {
            var menu = FindForm() as frmMenu;
            menu?.AggiornaLbl(_testoLbl);
        }

        private void caricaProdotti()
        {
            cmbProdotto.DataSource = null;
            DataTable dt = ordiniController.GetAllProdotti();
            cmbProdotto.DisplayMember = "nome";
            cmbProdotto.ValueMember = "idProdotto";
            cmbProdotto.DataSource = dt;
        }

        private void caricaFornitori()
        {
            cmbFornitore.DataSource = null;
            cmbFornitore.DataSource = ordiniController.GetAllFornitori();
            cmbFornitore.DisplayMember = "nome";
            cmbFornitore.ValueMember = "idFornitore";
        }

        private void cmbProdotto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdotto.SelectedValue == null) return;

            if (cmbProdotto.SelectedValue == null || !int.TryParse(cmbProdotto.SelectedValue.ToString(), out int idProdotto))
                return;
            cmbVariante.DataSource = null;
            DataTable dt = ordiniController.GetVariante(idProdotto);
            cmbVariante.DisplayMember = "variante";
            cmbVariante.ValueMember = "idVariante";
            cmbVariante.DataSource = dt;
            cmbVariante.SelectedIndex = 0;

            txtPrezzo.Text = "";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (cmbVariante.SelectedValue == null) return;

            int idVariante = Convert.ToInt32(cmbVariante.SelectedValue);
            int quantita = Convert.ToInt32(nudQta.Value);
            if (!decimal.TryParse(txtPrezzo.Text, out decimal prezzo))
            {
                MessageBox.Show("Prezzo non valido");
                return;
            }

            var esistente = righe.FirstOrDefault(r => r.IdVariante == idVariante);
            if (esistente != null)
                esistente.Quantita += quantita;
            else
            {
                righe.Add(new clsOrdiniController.RigaOrdine
                {
                    IdVariante = idVariante,
                    Prodotto = cmbProdotto.Text,
                    Variante = cmbVariante.Text,
                    Quantita = quantita,
                    Prezzo = prezzo
                });
            }

            aggiornaGriglia();
            resetInput();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (righe.Count == 0)
            {
                MessageBox.Show("Aggiungere almeno una riga all'ordine.");
                return;
            }

            int idFornitore = Convert.ToInt32(cmbFornitore.SelectedValue);

            try
            {
                ordiniController.SalvaOrdine(idFornitore, dtpData.Value, righe);

                MessageBox.Show("Ordine salvato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio dell'ordine: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRighe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            if (e.ColumnIndex == 0)
            {
                righe.RemoveAt(riga);
                aggiornaGriglia();
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            if (righe.Count > 0)
            {
                if (MessageBox.Show("Sei sicuro di voler annullare l'ordine?", "Conferma annullamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    reset();
                }
            }
        }

        private void reset()
        {
            righe.Clear();
            dgvRighe.DataSource = null;
            cmbProdotto.SelectedIndex = -1;
            cmbVariante.DataSource = null;
            nudQta.Value = 1;
            txtPrezzo.Text = string.Empty;
            lblTotale.Text = "0.00";
            cmbFornitore.SelectedIndex = -1;
            dtpData.Value = DateTime.Now;
        }

        private void resetInput()
        {
            cmbVariante.SelectedIndex = -1;
            nudQta.Value = 1;
            txtPrezzo.Text = string.Empty;
        }

        private void aggiornaGriglia()
        {
            dgvRighe.DataSource = null;
            dgvRighe.DataSource = righe;
            dgvRighe.Columns["idVariante"].Visible = false;

            lblTotale.Text = "€" + righe.Sum(r => r.Subtotale).ToString("0.00");
        }
    }
}
