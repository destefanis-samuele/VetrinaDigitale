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

        public bool ControllaFornitore(string nome, string email, string telefono, int idCitta)
        {
            string query = "SELECT COUNT(*) FROM FORNITORI WHERE nome = @nome AND email = @email AND telefono = @telefono AND idCitta = @idCitta";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
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
                throw new Exception("Errore durante il controllo del fornitore: " + ex.Message);
            }
        }

        public void InserisciFornitore(string nome, string email, string telefono, int idCitta)
        {
            string query = "INSERT INTO FORNITORI (nome, email, telefono, idCitta) VALUES (@nome, @email, @telefono, @idCitta)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
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
                throw new Exception("Errore durante l'inserimento del fornitore: " + ex.Message);
            }
        }

        public void ModificaFornitore(int idFornitore, string nome, string email, string telefono, int idCitta)
        {
            string query = "UPDATE FORNITORI SET nome = @nome, email = @email, telefono = @telefono, idCitta = @idCitta WHERE idFornitore = @idFornitore";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idFornitore", idFornitore);
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
                throw new Exception("Errore durante la modifica del fornitore: " + ex.Message);
            }
        }

        public bool Presente(string tabella, string idFornitore, int id)
        {
            string query = $"SELECT COUNT(*) FROM {tabella} WHERE {idFornitore} = @id";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il controllo della presenza del fornitore: " + ex.Message);
            }
        }

        public void EliminaFornitore(int idFornitore)
        {
            string query = "DELETE FROM FORNITORI WHERE idFornitore = @idFornitore";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idFornitore", idFornitore);
            try
            {
                ado.EseguiNonQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante l'eliminazione del fornitore: " + ex.Message);
            }
        }
    }
}
