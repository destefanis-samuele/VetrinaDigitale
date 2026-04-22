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
    public class clsCittaController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsCittaController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetAllCitta()
        {
            string query = "SELECT idCitta, citta, CAP, provincia FROM CITTA ORDER BY citta";
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
                throw new Exception("Errore durante il caricamento delle città: " + ex.Message);
            }
            return dt;
        }

        public bool ControllaCitta(string citta, string CAP, string provincia)
        {
            string query = "SELECT COUNT(*) FROM CITTA WHERE citta = @citta AND CAP = @CAP AND provincia = @provincia";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@citta", citta);
            cmd.Parameters.AddWithValue("@CAP", CAP);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo della città: " + ex.Message);
            }
        }

        public void InserisciCitta(string citta, string CAP, string provincia)
        {
            string query = "INSERT INTO CITTA (citta, CAP, provincia) VALUES (@citta, @CAP, @provincia)";
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@citta", citta);
            cmd.Parameters.AddWithValue("@CAP", CAP);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            try
            {
                ado.EseguiNonQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'inserimento della città: " + ex.Message);
            }
        }

        public void EliminaCitta(string citta, string CAP, string provincia)
        {
            string query = "DELETE FROM CITTA WHERE citta = @citta AND CAP = @CAP AND provincia = @provincia";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@citta", citta);
            cmd.Parameters.AddWithValue("@CAP", CAP);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'eliminazione della città: " + ex.Message);
            }
        }
    }
}
