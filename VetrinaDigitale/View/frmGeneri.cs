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
    public partial class frmGeneri : Form
    {
        public frmGeneri()
        {
            InitializeComponent();
        }

        clsGeneriController generiController = new clsGeneriController();

        private void frmGeneri_Load(object sender, EventArgs e)
        {
            caricaDgvGeneri();
        }

        private void caricaDgvGeneri()
        {
            dgvGeneri.DataSource = null;
            dgvGeneri.DataSource = generiController.GetAllGeneri();
            dgvGeneri.Columns["idGenere"].Visible = false;
            dgvGeneri.AutoResizeRows();
            dgvGeneri.AutoResizeColumns();
        }
    }
}
