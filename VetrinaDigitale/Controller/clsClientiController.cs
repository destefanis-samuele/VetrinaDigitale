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
            string query = "SELECT idCliente, nome, cognome, telefono, email, CITTA.idCitta AS idCitta, citta + ' (' + provincia + ')' AS citta FROM CLIENTI, CITTA WHERE CLIENTI.idCitta = CITTA.idCitta ORDER BY nome, cognome";
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

        public bool ControllaCliente(string cognome, string nome, string email, string telefono, int idCitta)
        {
            string query = "SELECT COUNT(*) FROM CLIENTI WHERE cognome = @cognome AND nome = @nome AND email = @email AND telefono = @telefono AND idCitta = @idCitta";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@cognome", cognome);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@idCitta", idCitta);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo del cliente: " + ex.Message);
            }
        }

        public void InserisciCliente(string cognome, string nome, string email, string telefono, int idCitta)
        {
            string query = "INSERT INTO CLIENTI (cognome, nome, email, telefono, idCitta) VALUES (@cognome, @nome, @email, @telefono, @idCitta)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@cognome", cognome);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@idCitta", idCitta);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'inserimento del cliente: " + ex.Message);
            }
        }

        public int GetIdCliente(string cognome, string nome, string email, string telefono, int idCitta)
        {
            string query = "SELECT idCliente FROM CLIENTI WHERE cognome = @cognome AND nome = @nome AND email = @email AND telefono = @telefono AND idCitta = @idCitta";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@cognome", cognome);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@idCitta", idCitta);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il recupero dell'ID del cliente: " + ex.Message);
            }
        }

        public void AggiornaCliente(int idCliente, string cognome, string nome, string email, string telefono, int idCitta)
        {
            string query = "UPDATE CLIENTI SET cognome = @cognome, nome = @nome, email = @email, telefono = @telefono, idCitta = @idCitta WHERE idCliente = @idCliente";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            cmd.Parameters.AddWithValue("@cognome", cognome);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@idCitta", idCitta);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'aggiornamento del cliente: " + ex.Message);
            }
        }

        public void EliminaCliente(int idCliente)
        {
            string query = "DELETE FROM CLIENTI WHERE idCliente = @idCliente";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'eliminazione del cliente: " + ex.Message);
            }
        }

        public bool ControllaIdCliente(int idCliente)
        {
            string query = "SELECT COUNT(*) FROM CLIENTI WHERE idCliente = @idCliente";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo dell'ID del cliente: " + ex.Message);
            }
        }
    }
}
