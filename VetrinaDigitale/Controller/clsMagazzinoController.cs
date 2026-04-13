using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using ADOSQLServer2017_ns;
using System.Data.SqlClient;

namespace VetrinaDigitale.Controller
{
    public class clsMagazzinoController
    {
        private string dbName;

        public clsMagazzinoController()
        {
            dbName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Progetto", "DB", "Inventario.mdf");
        }

        public DataTable GetProdotti()
        {
            try
            {
                string dbFile = dbName;
                if (!File.Exists(dbFile))
                {
                    throw new FileNotFoundException("File database non trovato: " + dbFile);
                }

                ADOSQLServer2017 db = new ADOSQLServer2017(dbFile);
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText =
                        "SELECT p.idProdotto, p.nome, m.marca AS Marca, c.categoria AS Categoria, g.genere AS Genere, p.prezzo, p.descrizione, vp.idVariante, t.taglia AS Taglia, co.colore AS Colore, vp.quantitaDisponibile " +
                        "FROM PRODOTTI p " +
                        "LEFT JOIN MARCHE m ON p.idMarca = m.idMarca " +
                        "LEFT JOIN CATEGORIE c ON p.idCategoria = c.idCategoria " +
                        "LEFT JOIN GENERI g ON p.idGenere = g.idGenere " +
                        "LEFT JOIN VARIANTI_PRODOTTO vp ON p.idProdotto = vp.idProdotto " +
                        "LEFT JOIN TAGLIE t ON vp.idTaglia = t.idTaglia " +
                        "LEFT JOIN COLORI co ON vp.idColore = co.idColore " +
                        "WHERE p.attivo = 1";

                    DataTable dt = db.EseguiQuery(cmd);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante il caricamento dei prodotti: " + ex.Message);
            }
        }
    }
}
