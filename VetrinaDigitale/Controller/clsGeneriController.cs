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

        public bool ControllaGenere(string genere)
        {
            string query = "SELECT COUNT(*) FROM GENERI WHERE genere = @genere";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@genere", genere);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;

            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo del genere: " + ex.Message);
            }
        }

        public void InserisciGenere(string genere)
        {
            string query = "INSERT INTO GENERI (genere) VALUES (@genere)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@genere", genere);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'inserimento del genere: " + ex.Message);
            }
        }

        public void AggiornaGenere(int idGenere, string genere)
        {
            string query = "UPDATE GENERI SET genere = @genere WHERE idGenere = @idGenere";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idGenere", idGenere);
            cmd.Parameters.AddWithValue("@genere", genere);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'aggiornamento del genere: " + ex.Message);
            }
        }

        public bool ControllaIdGenere(int idGenere)
        {
            string query = "SELECT COUNT(*) FROM PRODOTTI WHERE idGenere = @idGenere";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idGenere", idGenere);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo dell'id del genere: " + ex.Message);
            }
        }

        public void EliminaGenere(int idGenere)
        {
            string query = "DELETE FROM GENERI WHERE idGenere = @idGenere";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idGenere", idGenere);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'eliminazione del genere: " + ex.Message);
            }
        }
    }
}