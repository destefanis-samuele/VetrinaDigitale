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
    public class clsMagazzinoController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsMagazzinoController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetAllProdotti()
        {
            DataTable dt = new DataTable();
            string query = "SELECT v.idVariante, p.nome AS prodotto, t.taglia, c.colore, v.quantitaDisponibile FROM VARIANTI_PRODOTTO v JOIN PRODOTTI p ON v.idProdotto = p.idProdotto JOIN TAGLIE t ON v.idTaglia = t.idTaglia JOIN COLORI c ON v.idColore = c.idColore";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei prodotti: " + ex.Message);
            }
            return dt;
        }
    }
}
