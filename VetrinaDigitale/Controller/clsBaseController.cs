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
    public class clsBaseController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        private string nomeTabella;
        private string nomeCampo;
        private string nomeId;

        public clsBaseController(string tabella, string campo, string id)
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);

            nomeTabella = tabella;
            nomeCampo = campo;
            nomeId = id;
        }

        public DataTable GetDati()
        {
            string query = $"SELECT {nomeId}, {nomeCampo} FROM {nomeTabella} ORDER BY {nomeCampo}";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            return ado.EseguiQuery(cmd);
        }

        public bool Esiste(string valore)
        {
            string query = $"SELECT COUNT(*) FROM {nomeTabella} WHERE {nomeCampo} = @valore";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@valore", valore);

            return Convert.ToInt32(ado.EseguiScalar(cmd)) > 0;
        }

        public void Inserisci(string valore)
        {
            string query = $"INSERT INTO {nomeTabella} ({nomeCampo}) VALUES (@valore)";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@valore", valore);

            ado.EseguiNonQuery(cmd);
        }

        public void Aggiorna(int id, string valore)
        {
            string query = $"UPDATE {nomeTabella} SET {nomeCampo} = @valore WHERE {nomeId} = @id";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@valore", valore);
            cmd.Parameters.AddWithValue("@id", id);

            ado.EseguiNonQuery(cmd);
        }

        public void Elimina(int id)
        {
            string query = $"DELETE FROM {nomeTabella} WHERE {nomeId} = @id";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@id", id);

            ado.EseguiNonQuery(cmd);
        }
    }
}
