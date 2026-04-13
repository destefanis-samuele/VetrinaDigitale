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
        public clsLoginController()
        {
            // Default DB path on the user's Desktop: %USERPROFILE%\Desktop\Progetto\DB_INVENTARIO.MDF
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
        }
        public bool ControllaUtente(string username, string password)
        {
            try
            {
                string dbFile = dbName;
                if (!File.Exists(dbFile))
                {
                    throw new FileNotFoundException("File database non trovato: " + dbFile);
                }
                ADOSQLServer2017 db = new ADOSQLServer2017(dbFile);
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) FROM UTENTI WHERE USERNAME = @username AND PASSWORD = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = db.EseguiScalar(cmd);
                    return Convert.ToInt32(result) == 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo dell'utente: " + ex.Message);
            }
        }
    }
}
