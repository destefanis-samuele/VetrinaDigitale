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
    public class clsOrdiniController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsOrdiniController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public class RigaOrdine
        {
            public int IdVariante { get; set; }
            public string Prodotto { get; set; }
            public string Variante { get; set; }
            public int Quantita { get; set; }
            public decimal Prezzo { get; set; }

            public decimal Subtotale => Quantita * Prezzo;
        }

        public DataTable GetAllFornitori()
        {
            DataTable dt = new DataTable();
            string query = "SELECT idFornitore, nome FROM FORNITORI ORDER BY nome";
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

        public DataTable GetAllProdotti()
        {
            string query = "SELECT idProdotto, nome FROM PRODOTTI WHERE attivo = 1";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            DataTable dt = new DataTable();
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

        public DataTable GetVariante(int idProdotto)
        {
            string query = "SELECT VARIANTI_PRODOTTO.idVariante, TAGLIE.taglia + ' - ' + COLORI.colore AS variante FROM VARIANTI_PRODOTTO, TAGLIE, COLORI WHERE VARIANTI_PRODOTTO.idTaglia = TAGLIE.idTaglia AND VARIANTI_PRODOTTO.idColore = COLORI.idColore AND VARIANTI_PRODOTTO.idProdotto = @idProdotto ORDER BY taglia, colore";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idProdotto", idProdotto);
            DataTable dt = new DataTable();
            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento delle varianti: " + ex.Message);
            }
            return dt;
        }

        public void SalvaOrdine(int idFornitore, DateTime data, List<RigaOrdine> righe)
        {
            SqlConnection conn = ado.GetConnection();
            SqlTransaction trans = conn.BeginTransaction();

            try
            {
                decimal totale = righe.Sum(r => r.Subtotale);

                string insertOrdineQuery = "INSERT INTO ORDINI (idFornitore, dataOrdine, totale) VALUES (@idFornitore, @data, @totale); SELECT SCOPE_IDENTITY();";

                SqlCommand cmdOrdine = new SqlCommand(insertOrdineQuery, conn, trans);
                cmdOrdine.Parameters.AddWithValue("@idFornitore", idFornitore);
                cmdOrdine.Parameters.AddWithValue("@data", data);
                cmdOrdine.Parameters.AddWithValue("@totale", totale);

                int idOrdine = Convert.ToInt32(ado.EseguiScalar(cmdOrdine));

                foreach (var riga in righe)
                {
                    // Inserisce la riga dell'ordine
                    string queryDettaglio = "INSERT INTO DETTAGLI_ORDINI (idOrdine, idVariante, quantita, prezzoUnitario) VALUES (@idOrdine, @idVariante, @quantita, @prezzo)";
                    SqlCommand cmdRiga = new SqlCommand(queryDettaglio, conn, trans);
                    cmdRiga.Parameters.AddWithValue("@idOrdine", idOrdine);
                    cmdRiga.Parameters.AddWithValue("@idVariante", riga.IdVariante);
                    cmdRiga.Parameters.AddWithValue("@quantita", riga.Quantita);
                    cmdRiga.Parameters.AddWithValue("@prezzo", riga.Prezzo);
                    ado.EseguiNonQuery(cmdRiga);

                    // Aggiorna la quantità disponibile della variante
                    string queryUpdate = "UPDATE VARIANTI_PRODOTTO SET quantitaDisponibile = quantitaDisponibile + @quantita WHERE idVariante = @idVariante";
                    SqlCommand cmdUpd = new SqlCommand(queryUpdate, conn, trans);
                    cmdUpd.Parameters.AddWithValue("@quantita", riga.Quantita);
                    cmdUpd.Parameters.AddWithValue("@idVariante", riga.IdVariante);
                    ado.EseguiNonQuery(cmdUpd);
                }

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception("Errore durante il salvataggio dell'ordine: " + ex.Message);
            }
        }
    }
}
