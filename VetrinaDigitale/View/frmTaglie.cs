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
    public partial class frmTaglie : Form
    {
        public frmTaglie()
        {
            InitializeComponent();
        }

        clsTaglieController taglieController;

        private void frmTaglie_Load(object sender, EventArgs e)
        {
            taglieController = new clsTaglieController();

            caricaDgvTaglie();
        }

        private void caricaDgvTaglie()
        {
            dgvTaglie.DataSource = null;
            dgvTaglie.DataSource = taglieController.GetAllTaglie();
            dgvTaglie.Columns["idTaglia"].Visible = false;
            dgvTaglie.AutoResizeRows();
            dgvTaglie.AutoResizeColumns();
        }
    }
}
