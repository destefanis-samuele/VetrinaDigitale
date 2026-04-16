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
    public partial class frmMarche : Form
    {
        public frmMarche()
        {
            InitializeComponent();
        }

        clsMarcheController marcheController;

        private void frmMarche_Load(object sender, EventArgs e)
        {
            marcheController = new clsMarcheController();

            caricaDgvMarche();
        }

        private void caricaDgvMarche()
        {
            dgvMarche.DataSource = null;
            dgvMarche.DataSource = marcheController.GetAllMarche();
            dgvMarche.Columns["idMarca"].Visible = false;
            dgvMarche.AutoResizeColumns();
            dgvMarche.AutoResizeRows();
        }
    }
}
