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
    }
}
