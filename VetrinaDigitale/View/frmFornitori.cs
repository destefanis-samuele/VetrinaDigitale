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
    public partial class frmFornitori : Form
    {
        public frmFornitori()
        {
            InitializeComponent();
        }

        clsFornitoriController fornitoriController;

        private void frmFornitori_Load(object sender, EventArgs e)
        {
            fornitoriController = new clsFornitoriController();

            caricaCmbCitta();

            caricaDgvFornitori();
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
    }
}
