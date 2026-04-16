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
    public class clsGeneriController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsGeneriController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }
        public DataTable GetAllGeneri()
        {
            string query = "SELECT idGenere, genere FROM GENERI ORDER BY genere";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei generi: " + ex.Message);
            }
            return dt;
        }
    }
}
