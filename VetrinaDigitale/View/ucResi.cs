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
    public partial class ucResi : UserControl
    {
        private string _testoLbl;
        public ucResi(string testoLbl)
        {
            InitializeComponent();
            _testoLbl = testoLbl;
        }

        clsResiController resiController = new clsResiController();

        private void ucResi_Load(object sender, EventArgs e)
        {
            configuraDgv(dgvResi);
            PopolaLbl();
        }

        private void PopolaLbl()
        {
            var menu = FindForm() as frmMenu;
            menu?.AggiornaLbl(_testoLbl);
        }

        private void configuraDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Seleziona";
            chk.HeaderText = "✓";
            dgv.Columns.Add(chk);

            DataGridViewTextBoxColumn idRiga = new DataGridViewTextBoxColumn();
            idRiga.Name = "idRiga";
            idRiga.DataPropertyName = "idRiga";
            idRiga.Visible = false;
            dgvResi.Columns.Add(idRiga);

            DataGridViewTextBoxColumn idVariante = new DataGridViewTextBoxColumn();
            idVariante.Name = "idVariante";
            idVariante.DataPropertyName = "idVariante";
            idVariante.Visible = false;
            dgvResi.Columns.Add(idVariante);

            DataGridViewTextBoxColumn prodotto = new DataGridViewTextBoxColumn();
            prodotto.Name = "Prodotto";
            prodotto.HeaderText = "Prodotto";
            prodotto.DataPropertyName = "Prodotto";
            prodotto.ReadOnly = true;
            dgvResi.Columns.Add(prodotto);

            DataGridViewTextBoxColumn taglia = new DataGridViewTextBoxColumn();
            taglia.Name = "Taglia";
            taglia.HeaderText = "Taglia";
            taglia.DataPropertyName = "Taglia";
            taglia.ReadOnly = true;
            dgvResi.Columns.Add(taglia);

            DataGridViewTextBoxColumn colore = new DataGridViewTextBoxColumn();
            colore.Name = "Colore";
            colore.HeaderText = "Colore";
            colore.DataPropertyName = "Colore";
            colore.ReadOnly = true;
            dgvResi.Columns.Add(colore);

            DataGridViewTextBoxColumn prezzo = new DataGridViewTextBoxColumn();
            prezzo.Name = "Prezzo";
            prezzo.HeaderText = "Prezzo";
            prezzo.DataPropertyName = "Prezzo";
            prezzo.ReadOnly = true;
            dgvResi.Columns.Add(prezzo);

            DataGridViewTextBoxColumn quantitaAcq = new DataGridViewTextBoxColumn();
            quantitaAcq.Name = "QuantitaAcquistata";
            quantitaAcq.HeaderText = "Acquistati";
            quantitaAcq.DataPropertyName = "QuantitaAcquistata";
            quantitaAcq.ReadOnly = true;
            dgvResi.Columns.Add(quantitaAcq);

            DataGridViewTextBoxColumn quantitaResa = new DataGridViewTextBoxColumn();
            quantitaResa.Name = "QuantitaResa";
            quantitaResa.HeaderText = "Già Resi";
            quantitaResa.DataPropertyName = "QuantitaResa";
            quantitaResa.ReadOnly = true;
            dgvResi.Columns.Add(quantitaResa);

            DataGridViewTextBoxColumn quantitaDisp = new DataGridViewTextBoxColumn();
            quantitaDisp.Name = "QuantitaDisponibile";
            quantitaDisp.HeaderText = "Disponibili";
            quantitaDisp.DataPropertyName = "QuantitaDisponibile";
            quantitaDisp.ReadOnly = true;
            dgvResi.Columns.Add(quantitaDisp);

            DataGridViewTextBoxColumn quantitaRendere = new DataGridViewTextBoxColumn();
            quantitaRendere.Name = "QuantitaDaRendere";
            quantitaRendere.HeaderText = "Da Rendere";
            dgvResi.Columns.Add(quantitaRendere);

            DataGridViewComboBoxColumn motivo = new DataGridViewComboBoxColumn();
            motivo.Name = "Motivo";
            motivo.HeaderText = "Motivo";
            motivo.Items.Add("Difettoso");
            motivo.Items.Add("Taglia errata");
            motivo.Items.Add("Cambio prodotto");
            motivo.Items.Add("Ripensamento");
            motivo.Items.Add("Altro");
            dgvResi.Columns.Add(motivo);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            if (txtScontrino.Text.Trim() == "")
            {
                MessageBox.Show("Inserisci un numero di scontrino valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int idScontrino = Convert.ToInt32(txtScontrino.Text);

            dgvResi.DataSource = resiController.GetRigheScontrinoPerReso(idScontrino);

            foreach (DataGridViewRow row in dgvResi.Rows)
            {
                int disponibile = Convert.ToInt32(row.Cells["QuantitaDisponibile"].Value);

                if (disponibile == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.Cells["Seleziona"].ReadOnly = true;
                }
            }

        }

        private void dgvResi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            int colonna = e.ColumnIndex;
            if (dgvResi.Columns[colonna].Name == "QuantitaDaRendere")
            {
                DataGridViewRow row = dgvResi.Rows[riga];
                if (row.Cells["QuantitaDaRendere"].Value == null)
                    return;

                int qtaDaRendere;
                bool valido = int.TryParse(row.Cells["QuantitaDaRendere"].Value.ToString(), out qtaDaRendere);
                if (!valido || qtaDaRendere <= 0)
                {
                    MessageBox.Show("Inserisci una quantità valida");
                    row.Cells["QuantitaDaRendere"].Value = null;
                    return;
                }

                int disponibile = Convert.ToInt32(row.Cells["QuantitaDisponibile"].Value);
                if (qtaDaRendere > disponibile)
                {
                    MessageBox.Show("Quantità da rendere superiore a quella disponibile.");
                    row.Cells["QuantitaDaRendere"].Value = null;
                    return;
                }
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            List<clsResiController.RigaReso> righe = new List<clsResiController.RigaReso>();

            foreach (DataGridViewRow row in dgvResi.Rows)
            {
                bool selezionato = false;
                if (row.Cells["Seleziona"].Value != null)
                    selezionato = Convert.ToBoolean(row.Cells["Seleziona"].Value);

                if (!selezionato)
                    continue;

                if (row.Cells["QuantitaDaRendere"].Value == null)
                {
                    MessageBox.Show("Inserisci la quantità da rendere per tutti gli articoli selezionati.");
                    return;
                }

                if (row.Cells["Motivo"].Value == null)
                {
                    MessageBox.Show("Seleziona un motivo per tutti gli articoli selezionati.");
                    return;
                }

                clsResiController.RigaReso riga = new clsResiController.RigaReso();
                riga.IdRiga = Convert.ToInt32(row.Cells["idRiga"].Value);
                riga.IdVariante = Convert.ToInt32(row.Cells["idVariante"].Value);
                riga.Quantita = Convert.ToInt32(row.Cells["QuantitaDaRendere"].Value);
                riga.Motivo = row.Cells["Motivo"].Value.ToString();
                righe.Add(riga);
            }

            if (righe.Count == 0)
            {
                MessageBox.Show("Seleziona almeno un articolo da rendere.");
                return;
            }

            try
            {
                resiController.SalvaReso(righe);

                MessageBox.Show("Reso salvato con successo.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvResi.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio del reso: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
