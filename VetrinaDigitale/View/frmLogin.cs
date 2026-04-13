using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ADOSQLServer2017_ns;
using System.Data.SqlClient;

namespace VetrinaDigitale.View
{
    public partial class frmLogin : Form
    {
        // Default DB path on the user's Desktop: %USERPROFILE%\Desktop\Progetto\DB_INVENTARIO.MDF
        string dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");

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
            if (controllaUtente(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Accesso eseguito.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool controllaUtente(string username, string password)
        {
            try
            {
                string dbFile = dbName;
                if (!File.Exists(dbFile))
                {
                    MessageBox.Show("File database non trovato: " + dbFile, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                ADOSQLServer2017 db = new ADOSQLServer2017(dbFile);
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) FROM UTENTI WHERE USERNAME = @username AND PASSWORD = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = db.EseguiScalar(cmd);
                    int count = 0;
                    try { count = Convert.ToInt32(result); } catch { count = 0; }
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'accesso: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
    }
}
