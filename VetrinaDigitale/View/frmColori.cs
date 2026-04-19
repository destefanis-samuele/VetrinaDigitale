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
    public partial class frmColori : Form
    {
        public frmColori()
        {
            InitializeComponent();
        }

        clsColoriController coloriController;

        private void frmColori_Load(object sender, EventArgs e)
        {
            coloriController = new clsColoriController();

            caricaDgvColori();
        }

        private void caricaDgvColori()
        {
            dgvColori.DataSource = null;
            dgvColori.DataSource = coloriController.GetAllColori();
            dgvColori.Columns["idColore"].Visible = false;
            dgvColori.AutoResizeRows();
            dgvColori.AutoResizeColumns();
        }
    }
}
