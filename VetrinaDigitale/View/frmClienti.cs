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
    public partial class frmClienti : Form
    {
        public frmClienti()
        {
            InitializeComponent();
        }

        clsClientiController clientiController;

        private void frmClienti_Load(object sender, EventArgs e)
        {
            clientiController = new clsClientiController();

            caricaDgvClienti();

            caricaCmbCitta();
        }

        private void caricaDgvClienti()
        {
            dgvClienti.DataSource = null;
            dgvClienti.DataSource = clientiController.GetAllClienti();
            dgvClienti.Columns["idCliente"].Visible = false;
            dgvClienti.Columns["idCitta"].Visible = false;
            dgvClienti.AutoResizeColumns();
            dgvClienti.AutoResizeRows();
        }

        private void caricaCmbCitta()
        {
            cmbCitta.DataSource = null;
            cmbCitta.DataSource = clientiController.GetAllCitta();
            cmbCitta.DisplayMember = "citta";
            cmbCitta.ValueMember = "idCitta";
        }

        private void dgvClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            if (riga >= 0)
            {
                txtCognome.Text = dgvClienti.Rows[riga].Cells["cognome"].Value.ToString();
                txtNome.Text = dgvClienti.Rows[riga].Cells["nome"].Value.ToString();
                txtEmail.Text = dgvClienti.Rows[riga].Cells["email"].Value.ToString();
                txtTelefono.Text = dgvClienti.Rows[riga].Cells["telefono"].Value.ToString();
                cmbCitta.SelectedValue = dgvClienti.Rows[riga].Cells["idCitta"].Value;
            }
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            if (!clientiController.ControllaCliente(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue))
            {
                clientiController.InserisciCliente(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue);
                Reset();
            }
            else
                MessageBox.Show("Il cliente è già presente nel database.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (dgvClienti.CurrentRow == null)
            {
                MessageBox.Show("Seleziona un cliente da modificare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!clientiController.ControllaCliente(txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue))
            {
                int idCliente = Convert.ToInt32(dgvClienti.CurrentRow.Cells["idCliente"].Value);
                clientiController.AggiornaCliente(idCliente, txtCognome.Text, txtNome.Text, txtEmail.Text, txtTelefono.Text, (int)cmbCitta.SelectedValue);
                Reset();
            }
            else
                MessageBox.Show("Il cliente è già presente nel database.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (dgvClienti.CurrentRow == null)
            {
                MessageBox.Show("Seleziona un cliente da eliminare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idCliente = Convert.ToInt32(dgvClienti.CurrentRow.Cells["idCliente"].Value);
            if (clientiController.ControllaIdCliente(idCliente))
            {
                if (MessageBox.Show("Sei sicuro di voler eliminare il cliente selezionato?", "Conferma eliminazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientiController.EliminaCliente(idCliente);
                    Reset();
                }
            }
        }

        private void Reset()
        {
            caricaDgvClienti();
            txtCognome.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cmbCitta.SelectedIndex = 0;
        }

        private void btnAggiungiCitta_Click(object sender, EventArgs e)
        {
            frmCitta frmCitta = new frmCitta();
            frmCitta.ShowDialog();
            caricaCmbCitta();
        }
    }
}
