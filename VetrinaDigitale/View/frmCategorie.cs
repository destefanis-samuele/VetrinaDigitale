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
    public partial class frmCategorie : Form
    {
        public frmCategorie()
        {
            InitializeComponent();
        }

        clsCategorieController categorieController;

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            categorieController = new clsCategorieController();

            caricaDgvCategorie();
        }

        private void caricaDgvCategorie()
        {
            dgvCategorie.DataSource = null;
            dgvCategorie.DataSource = categorieController.GetAllCategorie();
            dgvCategorie.Columns["idCategoria"].Visible = false;
            dgvCategorie.AutoResizeRows();
            dgvCategorie.AutoResizeColumns();
        }
    }
}
