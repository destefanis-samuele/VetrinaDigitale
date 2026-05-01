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
    public partial class ucBaseGenerica : UserControl
    {
        private clsBaseController controller;

        private string nomeId;
        private string nomeCampo;

        private string tabellaControllo;
        private string campoControllo;

        private string _testoLbl;

        public ucBaseGenerica(string tabella, string campo, string id, string testoLbl, string tabellaCtrl, string campoCtrl)
        {
            InitializeComponent();

            controller = new clsBaseController(tabella, campo, id);

            nomeId = id;
            nomeCampo = campo;

            tabellaControllo = tabellaCtrl;
            campoControllo = campoCtrl;
            
            _testoLbl = testoLbl;

            lblNome.Text = $"{nomeCampo}:";
        }

        private void ucBaseGenerica_Load(object sender, EventArgs e)
        {
            CaricaDati();

            PopolaLbl();
        }

        private void PopolaLbl()
        {
            var menu = FindForm() as frmMenu;
            menu?.AggiornaLbl(_testoLbl);
        }

        private void CaricaDati()
        {
            dgvDati.DataSource = null;
            dgvDati.DataSource = controller.GetDati();
            dgvDati.Columns[nomeId].Visible = false;
            dgvDati.ClearSelection();
            dgvDati.AutoResizeColumns();
            dgvDati.AutoResizeRows();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            string valore = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(valore))
            {
                MessageBox.Show("Inserire un valore.");
                return;
            }

            if (!controller.Esiste(valore))
            {
                controller.Inserisci(valore);
                Reset();
                MessageBox.Show($"{nomeCampo} inserito con successo.", "Inserimento riuscito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Valore già esistente.");
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dgvDati.CurrentRow == null)
            {
                MessageBox.Show("Seleziona una riga.");
                return;
            }

            string valore = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(valore))
            {
                MessageBox.Show("Inserire un valore.");
                return;
            }

            if (!controller.Esiste(valore))
            {
                int id = Convert.ToInt32(dgvDati.CurrentRow.Cells[nomeId].Value);
                controller.Aggiorna(id, valore);
                Reset();
                MessageBox.Show($"{nomeCampo} aggiornato con successo.", "Modifica riuscita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Valore già esistente o non modificato.");
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvDati.CurrentRow == null)
            {
                MessageBox.Show("Seleziona una riga.");
                return;
            }

            int id = Convert.ToInt32(dgvDati.CurrentRow.Cells[nomeId].Value);

            DialogResult res = MessageBox.Show("Sei sicuro?", "Conferma", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                if (!controller.Presente(tabellaControllo, campoControllo, id))
                {
                    controller.Elimina(id);
                    Reset();
                    MessageBox.Show($"{nomeCampo} eliminato con successo.", "Eliminazione riuscita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Non è possibile eliminare questo elemento perché è associato a uno o più record in un'altra tabella.");
            }
        }

        private void dgvDati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtNome.Text = dgvDati.Rows[e.RowIndex].Cells[nomeCampo].Value.ToString();
        }

        private void Reset()
        {
            txtNome.Clear();
            dgvDati.ClearSelection();
            txtNome.Focus();
            CaricaDati();
        }
    }
}