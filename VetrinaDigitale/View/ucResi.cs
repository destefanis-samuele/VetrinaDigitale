using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            DataGridViewTextBoxColumn chk = new DataGridViewTextBoxColumn();
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

            DataGridViewTextBoxColumn quantitaDisp = new DataGridViewTextBoxColumn();
            quantitaDisp.Name = "QuantitaDisponibile";
            quantitaDisp.HeaderText = "Disponibili";
            quantitaDisp.DataPropertyName = "QuantitaDisponibile";
            quantitaDisp.ReadOnly = true;
            dgvResi.Columns.Add(quantitaDisp);

            DataGridViewTextBoxColumn quantita = new DataGridViewTextBoxColumn();
            quantita.Name = "QuantitaDaRendere";
            quantita.HeaderText = "Da Rendere";
            dgvResi.Columns.Add(quantita);

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
    }
}
