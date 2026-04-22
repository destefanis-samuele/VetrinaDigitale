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
    public partial class frmCitta : Form
    {
        public frmCitta()
        {
            InitializeComponent();
        }

        clsCittaController cittaController;

        private void frmCitta_Load(object sender, EventArgs e)
        {
            cittaController = new clsCittaController();

            caricaDgvCitta();
        }

        private void caricaDgvCitta()
        {
            dgvCitta.DataSource = null;
            dgvCitta.DataSource = cittaController.GetAllCitta();
            dgvCitta.Columns["idCitta"].Visible = false;
            dgvCitta.AutoResizeColumns();
            dgvCitta.AutoResizeRows();
        }

        private void dgvCitta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex;
            if (riga >= 0)
            {
                txtCitta.Text = dgvCitta.Rows[riga].Cells["citta"].Value.ToString();
                txtCAP.Text = dgvCitta.Rows[riga].Cells["CAP"].Value.ToString();
                txtProvincia.Text = dgvCitta.Rows[riga].Cells["provincia"].Value.ToString();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (!cittaController.ControllaCitta(txtCitta.Text, txtCAP.Text, txtProvincia.Text))
            {
                cittaController.InserisciCitta(txtCitta.Text, txtCAP.Text, txtProvincia.Text);
                Reset();
            }
            else
                MessageBox.Show("La città inserita è già presente nel database.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Reset()
        {
            txtCitta.Text = "";
            txtCAP.Text = "";
            txtProvincia.Text = "";
            caricaDgvCitta();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if(txtProvincia.Text != "" && txtCitta.Text != "" && txtCAP.Text != "")
            {
                cittaController.EliminaCitta(txtCitta.Text, txtCAP.Text, txtProvincia.Text);
                Reset();
            }
             else
                MessageBox.Show("Selezionare una città da eliminare.", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
