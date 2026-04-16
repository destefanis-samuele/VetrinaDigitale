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
using System.IO;
using VetrinaDigitale.Controller;
using VetrinaDigitale.View;
//using VetrinaDigitale.Model;

namespace VetrinaDigitale.View
{
    public partial class frmLogin : Form
    {
        clsLoginController loginController = new clsLoginController();
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkPassword.Checked;
        }

        private void btnAccedi_Click(object sender, EventArgs e)
        {
            if (loginController.ControllaUtente(txtUsername.Text, txtPassword.Text))
            {
                frmMenu frmMenu = new frmMenu();
                this.Hide();
                frmMenu.ShowDialog();
            }
            else
            {
                lblMessaggio.Text = "Username o password errati.";
                lblMessaggio.ForeColor = Color.Red;
                lblMessaggio.Visible = true;
            }
        }
    }
}
