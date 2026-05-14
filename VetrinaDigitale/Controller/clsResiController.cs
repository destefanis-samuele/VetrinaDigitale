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
    public class clsResiController
    {
        private string dbName;
        private ADOSQLServer2017 ado;

        public clsResiController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
            ado = new ADOSQLServer2017(dbName);
        }

        public DataTable GetRigheScontrinoPerReso(int idScontrino)
        {
            DataTable dt = new DataTable();

            string query = "SELECT RIGHE_SCONTRINO.idRiga, VARIANTI_PRODOTTO.idVariante, PRODOTTI.nome AS Prodotto, TAGLIE.taglia AS Taglia, COLORI.colore AS Colore, RIGHE_SCONTRINO.prezzoUnitario AS Prezzo, RIGHE_SCONTRINO.quantita AS QuantitaAcquistata, ISNULL((SELECT SUM(RESI.quantita) FROM RESI WHERE RESI.idRiga = RIGHE_SCONTRINO.idRiga),0) AS QuantitaResa, RIGHE_SCONTRINO.quantita - ISNULL((SELECT SUM(RESI.quantita) FROM RESI WHERE RESI.idRiga = RIGHE_SCONTRINO.idRiga),0) AS QuantitaDisponibile " +
                "FROM RIGHE_SCONTRINO, VARIANTI_PRODOTTO, PRODOTTI, TAGLIE, COLORI " +
                "WHERE RIGHE_SCONTRINO.idVariante = VARIANTI_PRODOTTO.idVariante AND VARIANTI_PRODOTTO.idProdotto = PRODOTTI.idProdotto AND VARIANTI_PRODOTTO.idTaglia = TAGLIE.idTaglia AND VARIANTI_PRODOTTO.idColore = COLORI.idColore AND RIGHE_SCONTRINO.idScontrino = @idScontrino";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idScontrino", idScontrino);

            try
            {
                dt = ado.EseguiQuery(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento delle righe dello scontrino: " + ex.Message);
            }

            return dt;
        }
    }
}
