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

            string dataVendita = DateTime.Now.ToString("dd/MM/yyyy");

            caricaCmbProdotto();

            impostaDgvScontrino(dgvScontrino, "idVariante;Prodotto;Taglia;Colore;Quantità;Totale", "idVariante;Prodotto;Taglia;Colore;Quantita;Totale");
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
            cmbProdotto.DisplayMember = "nomeCompleto";
            cmbProdotto.ValueMember = "idProdotto";
            cmbProdotto.DataSource = dt;
            cmbProdotto.SelectedIndex = 0;
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
            cmbCliente.DataSource = venditeController.GetAllClienti();
            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "idCliente";
        }

        private void cmbProdotto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProdotto = Convert.ToInt32(cmbProdotto.SelectedValue);
            cmbTaglia.DataSource = null;
            DataTable dt = venditeController.GetTaglieByProdotto(idProdotto);
            cmbTaglia.DisplayMember = "taglia";
            cmbTaglia.ValueMember = "idTaglia";
            cmbTaglia.DataSource = dt;
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
                int idProdotto = Convert.ToInt32(cmbProdotto.SelectedValue);
                int idTaglia = Convert.ToInt32(cmbTaglia.SelectedValue);
                int idColore = Convert.ToInt32(cmbColore.SelectedValue);
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
                        aggiornaTotale();
                        return;
                    }
                }

                dgvScontrino.Rows.Add(
                    idVariante,
                    cmbProdotto.Text,
                    cmbTaglia.Text,
                    cmbColore.Text,
                    qta,
                    qta * prezzo
                );

                dgvScontrino.AutoResizeRows();
                dgvScontrino.AutoResizeColumns();

                aggiornaTotale();
            }
        }

        private void aggiornaTotale()
        {
            double totale = 0;

            foreach (DataGridViewRow row in dgvScontrino.Rows)
            {
                if (row.Cells["Totale"].Value != null)
                    totale += Convert.ToDouble(row.Cells["Totale"].Value);
            }

            lblTotale.Text = "Totale: € " + totale.ToString("0.00");
        }
    }
}
