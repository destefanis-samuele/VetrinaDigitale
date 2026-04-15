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
            dgvClienti.DataSource = null;
            dgvClienti.DataSource = clientiController.GetAllClienti();
            dgvClienti.Columns["idCitta"].Visible = false;
            dgvClienti.AutoResizeColumns();
            dgvClienti.AutoResizeRows();

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

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            //int idCitta = (int)cmbCitta.SelectedValue;
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {

        }
    }
}
