using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using ADOSQLServer2017_ns;
using System.Data.SqlClient;

namespace VetrinaDigitale.Controller
{
    public class clsLoginController
    {
        private string dbName;
        private ADOSQLServer2017 ado;
        public clsLoginController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }
        public bool ControllaUtente(string username, string password)
        {
            SqlCommand cmd = new SqlCommand();
            object result;
            cmd.CommandText = "SELECT COUNT(1) FROM UTENTI WHERE USERNAME = @username AND PASSWORD = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            try
            {
                result = ado.EseguiScalar(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo dell'utente: " + ex.Message);
            }
            return Convert.ToInt32(result) == 1;
        }
    }
}
