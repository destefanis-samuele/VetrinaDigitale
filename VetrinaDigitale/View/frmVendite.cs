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
    public partial class frmVendite : Form
    {
        public frmVendite()
        {
            InitializeComponent();
        }

        clsVenditeController venditeController;
        int idProdotto;
        int idTaglia;
        int idColore;

        private void frmVendite_Load(object sender, EventArgs e)
        {
            venditeController = new clsVenditeController();

            caricaCmbCliente();

            caricaCmbPagamanto();

            caricaCmbProdotto();

            impostaDgvScontrino(dgvScontrino, "idVariante;Prodotto;Taglia;Colore;Quantità;Prezzo;Totale", "idVariante;Prodotto;Taglia;Colore;Quantita;Prezzo;Totale");

            lblTotale.Text = "";
        }

        private void impostaDgvScontrino(DataGridView dgv, string intestazione, string nomi)
        {
            string[] colonne = intestazione.Split(';');
            string[] nomiArray = nomi.Split(';');
            dgv.ColumnCount = colonne.Length;
            for (int i = 0; i < colonne.Length; i++)
            {
                dgv.Columns[i].Name = nomiArray[i];
                dgv.Columns[i].HeaderText = colonne[i];
            }
            dgv.Columns[0].Visible = false;
        }

        private void caricaCmbProdotto()
        {
            cmbProdotto.DataSource = null;
            DataTable dt = venditeController.GetAllProdottiDisponibili();
            cmbProdotto.DisplayMember = "nome";
            cmbProdotto.ValueMember = "idProdotto";
            cmbProdotto.DataSource = dt;
            cmbProdotto.SelectedIndex = 0;
            idProdotto = Convert.ToInt32(cmbProdotto.SelectedValue);
        }

        private void caricaCmbPagamanto()
        {
            cmbMetodoPagamento.DataSource = null;
            cmbMetodoPagamento.DataSource = venditeController.GetAllMetodiPagamento();
            cmbMetodoPagamento.DisplayMember = "metodo";
            cmbMetodoPagamento.ValueMember = "idMetodo";
        }

        private void caricaCmbCliente()
        {
            cmbCliente.DataSource = null;
            DataTable dt = venditeController.GetAllClienti();

            DataRow riga = dt.NewRow();
            riga["idCliente"] = 0;
            riga["cliente"] = "";
            dt.Rows.InsertAt(riga, 0);

            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = dt;
            cmbCliente.SelectedIndex = 0;
        }

        private void cmbProdotto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProdotto = Convert.ToInt32(cmbProdotto.SelectedValue);
            cmbTaglia.DataSource = null;
            DataTable dt = venditeController.GetTaglieByProdotto(idProdotto);
            cmbTaglia.DisplayMember = "taglia";
            cmbTaglia.ValueMember = "idTaglia";
            cmbTaglia.DataSource = dt;

            lblPrezzo.Text = "Prezzo: € " + venditeController.GetPrezzo(idProdotto).ToString("0.00");
        }

        private void cmbTaglia_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTaglia = Convert.ToInt32(cmbTaglia.SelectedValue);
            cmbColore.DataSource = null;
            DataTable dt = venditeController.GetColoriByTaglia(idTaglia);
            cmbColore.DisplayMember = "colore";
            cmbColore.ValueMember = "idColore";
            cmbColore.DataSource = dt;
        }

        private void cmbColore_SelectedIndexChanged(object sender, EventArgs e)
        {
            idColore = Convert.ToInt32(cmbColore.SelectedValue);

            caricaDisponibilita();
        }

        private void caricaDisponibilita()
        {
            int qta = venditeController.GetQuantitaDisponibile(idProdotto, idTaglia, idColore);
            nudQta.Minimum = 1;
            nudQta.Maximum = qta;
            lblQtaDisponibile.Text = "Quantità disponibile: " + qta;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (cmbProdotto.SelectedIndex > -1 &&
                cmbTaglia.SelectedIndex > -1 &&
                cmbColore.SelectedIndex > -1)
            {
                int qta = Convert.ToInt32(nudQta.Value);


                int idVariante = venditeController.GetIdVariante(idProdotto, idTaglia, idColore);
                int quantitaDisponibile = venditeController.GetQuantitaDisponibile(idVariante);
                double prezzo = venditeController.GetPrezzo(idProdotto);

                if (qta > quantitaDisponibile)
                {
                    MessageBox.Show("Quantità non disponibile");
                    return;
                }

                foreach (DataGridViewRow row in dgvScontrino.Rows)
                {
                    if ((int)row.Cells["idVariante"].Value == idVariante)
                    {
                        int qtaAttuale = Convert.ToInt32(row.Cells["Quantita"].Value);
                        int nuovaQta = qtaAttuale + qta;

                        if (nuovaQta > quantitaDisponibile)
                        {
                            MessageBox.Show("Supera disponibilità");
                            return;
                        }

                        row.Cells["Quantita"].Value = nuovaQta;
                        row.Cells["Totale"].Value = nuovaQta * prezzo;
                        lblTotale.Text = "Totale: € " + calcolaTotale().ToString("0.00");
                        return;
                    }
                }

                dgvScontrino.Rows.Add(
                    idVariante,
                    cmbProdotto.Text,
                    cmbTaglia.Text,
                    cmbColore.Text,
                    qta,
                    prezzo,
                    qta * prezzo
                );

                dgvScontrino.AutoResizeRows();
                dgvScontrino.AutoResizeColumns();

                lblTotale.Text = "Totale: € " + calcolaTotale().ToString("0.00");
            }
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            if (dgvScontrino.Rows.Count == 0)
            {
                MessageBox.Show("Aggiungi almeno un prodotto");
                return;
            }
            
            int? idCliente = null;

            if (cmbCliente.SelectedIndex > 0)
                idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            int idMetodoPagamento = Convert.ToInt32(cmbMetodoPagamento.SelectedValue);
            double totale = calcolaTotale();
            int idScontrino = venditeController.InserisciScontrino(idCliente, idMetodoPagamento, totale);
            
            foreach (DataGridViewRow row in dgvScontrino.Rows)
            {
                int idVariante = Convert.ToInt32(row.Cells["idVariante"].Value);
                int quantita = Convert.ToInt32(row.Cells["Quantita"].Value);
                double prezzo = Convert.ToDouble(row.Cells["Prezzo"].Value);

                venditeController.InserisciRigaScontrino(idScontrino, idVariante, quantita, prezzo);

                venditeController.AggiornaQuantitaMagazzino(idVariante, quantita);
            }

            resetTotale();
        }

        private double calcolaTotale()
        {
            double totale = 0;

            foreach (DataGridViewRow row in dgvScontrino.Rows)
            {
                if (row.Cells["Totale"].Value != null)
                    totale += Convert.ToDouble(row.Cells["Totale"].Value);
            }
            return totale;
        }
        private void resetTotale()
        {
            lblTotale.Text = "";
            dgvScontrino.Rows.Clear();
            caricaCmbProdotto();
            nudQta.Value = 1;
            cmbTaglia.DataSource = null;
            cmbColore.DataSource = null;
            lblQtaDisponibile.Text = "";
        }

    }
}
