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
    public class clsFornitoriController
    {
        private string dbName;
        private ADOSQLServer2017 ado;
        public clsFornitoriController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetAllCitta()
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

        public DataTable GetAllFornitori()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idFornitore, nome, email, telefono, FORNITORI.idCitta, CITTA.citta + ' (' +  CITTA.provincia + ')' AS citta FROM FORNITORI, CITTA WHERE FORNITORI.idCitta = CITTA.idCitta ORDER BY nome";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei fornitori: " + ex.Message);
            }
            return dt;
        }
    }
}
