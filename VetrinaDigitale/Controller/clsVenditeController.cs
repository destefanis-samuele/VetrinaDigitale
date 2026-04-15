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
    public class clsVenditeController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsVenditeController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetAllClienti()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idCliente, cognome + ' ' + nome AS cliente FROM CLIENTI";
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

        public DataTable GetAllMetodiPagamento()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idMetodo, metodo FROM METODI_PAGAMENTO";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei metodi di pagamento: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetAllProdottiDisponibili()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idProdotto, nome + ' - €' + CAST(prezzo AS VARCHAR) AS nomeCompleto FROM PRODOTTI WHERE attivo = 1 ORDER BY nomeCompleto";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei prodotti disponibili: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetTaglieByProdotto(int idProdotto)
        {
            DataTable dt = new DataTable();
            string query = "SELECT VARIANTI_PRODOTTO.idTaglia, taglia FROM VARIANTI_PRODOTTO, TAGLIE WHERE VARIANTI_PRODOTTO.idTaglia = TAGLIE.idTaglia AND idProdotto = @idProdotto";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idProdotto", idProdotto);
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento delle taglie: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetColoriByTaglia(int idTaglia)
        {
            DataTable dt = new DataTable();
            string query = "SELECT VARIANTI_PRODOTTO.idColore, colore FROM VARIANTI_PRODOTTO, COLORI WHERE VARIANTI_PRODOTTO.idColore = COLORI.idColore AND idTaglia = @idTaglia";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idTaglia", idTaglia);
            try
            {
                dt = ado.EseguiQuery(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei colori: " + ex.Message);
            }
            return dt;
        }

        public int GetQuantitaDisponibile(int idProdotto, int idTaglia, int idColore)
        {
            int quantita;
            DataTable dt = new DataTable();
            string query = "SELECT quantitaDisponibile FROM VARIANTI_PRODOTTO WHERE idProdotto = @idProdotto AND idTaglia = @idTaglia AND idColore = @idColore";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idProdotto", idProdotto);
            cmd.Parameters.AddWithValue("@idTaglia", idTaglia);
            cmd.Parameters.AddWithValue("@idColore", idColore);
            try
            {
                quantita = Convert.ToInt32(ado.EseguiScalar(cmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento della quantità disponibile: " + ex.Message);
            }
            return quantita;
        }
    }
}
