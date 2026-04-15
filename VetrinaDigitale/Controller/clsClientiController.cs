using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using System.Data;
using ADOSQLServer2017_ns;
using System.Data.SqlClient;

namespace VetrinaDigitale.Controller
{
    public class clsClientiController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsClientiController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetAllClienti()
        {
            DataTable dt = new DataTable();
            string query = "SELECT nome, cognome, telefono, email, CITTA.idCitta, citta + ' (' + provincia + ')' AS citta FROM CLIENTI, CITTA WHERE CLIENTI.idCitta = CITTA.idCitta ORDER BY nome, cognome";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei clienti: " + ex.Message);
            }
            return dt;
        }

        public object GetAllCitta()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idCitta, citta + ' (' + provincia + ')' AS citta FROM CITTA ORDER BY citta";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento delle città: " + ex.Message);
            }
            return dt;
        }
    }
}
