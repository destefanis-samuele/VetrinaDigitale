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
    public partial class ucFornitori : UserControl
    {
        private string _testoLbl;

        public ucFornitori(string testoLbl)
        {
            InitializeComponent();
            _testoLbl = testoLbl;
        }

        clsFornitoriController fornitoriController;

        private void ucFornitori_Load(object sender, EventArgs e)
        {
            fornitoriController = new clsFornitoriController();

            caricaCmbCitta();

            caricaDgvFornitori();

            PopolaLbl();
        }

        private void PopolaLbl()
        {
            var menu = FindForm() as frmMenu;
            menu?.AggiornaLbl(_testoLbl);
        }

        private void caricaDgvFornitori()
        {
            dgvFornitori.DataSource = null;
            dgvFornitori.DataSource = fornitoriController.GetAllFornitori();
            dgvFornitori.Columns["idFornitore"].Visible = false;
            dgvFornitori.Columns["idCitta"].Visible = false;
            dgvFornitori.AutoResizeColumns();
            dgvFornitori.AutoResizeRows();
        }

        private void caricaCmbCitta()
        {
            cmbCitta.DataSource = null;
            cmbCitta.DataSource = fornitoriController.GetAllCitta();
            cmbCitta.DisplayMember = "citta";
            cmbCitta.ValueMember = "idCitta";
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            if (!fornitoriController.ControllaFornitore(txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue))
            {
                fornitoriController.InserisciFornitore(txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue);
                Reset();
            }
            else
                MessageBox.Show("Il fornitore è già presente nel database.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Reset()
        {
            caricaDgvFornitori();
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cmbCitta.SelectedIndex = 0;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dgvFornitori.CurrentRow == null)
            {
                MessageBox.Show("Selezionare un fornitore da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!fornitoriController.ControllaFornitore(txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue))
            {
                int idFornitore = Convert.ToInt32(dgvFornitori.CurrentRow.Cells["idFornitore"].Value);
                fornitoriController.ModificaFornitore(idFornitore, txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue);
                Reset();
            }
            else
                MessageBox.Show("Il fornitore è già presente nel database.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvFornitori.CurrentRow == null)
            {
                MessageBox.Show("Selezionare un fornitore da eliminare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idFornitore = Convert.ToInt32(dgvFornitori.CurrentRow.Cells["idFornitore"].Value);
            if (!fornitoriController.Presente("Ordini", "idFornitore", idFornitore))
            {
                DialogResult res = MessageBox.Show("Sei sicuro?", "Conferma", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    fornitoriController.EliminaFornitore(idFornitore);
                    Reset();
                }
            }
            else
                MessageBox.Show("Non è possibile eliminare questo fornitore perché è associato a uno o più ordini.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvFornitori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            if (riga >= 0)
            {
                txtNome.Text = dgvFornitori.Rows[riga].Cells["nome"].Value.ToString();
                txtEmail.Text = dgvFornitori.Rows[riga].Cells["email"].Value.ToString();
                txtTelefono.Text = dgvFornitori.Rows[riga].Cells["telefono"].Value.ToString();
                cmbCitta.SelectedValue = dgvFornitori.Rows[riga].Cells["idCitta"].Value;
            }
        }

        private void btnAggiungiCitta_Click(object sender, EventArgs e)
        {
            frmCitta frmCitta = new frmCitta();
            frmCitta.ShowDialog();
            caricaCmbCitta();
        }
    }
}
