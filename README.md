# Vetrina Digitale

## Descrizione del progetto

**Vetrina Digitale** è un software gestionale sviluppato per il negozio di abbigliamento *Destefanis Roberto*, progettato per semplificare e digitalizzare la gestione quotidiana dell’attività commerciale.

L’applicazione consente di amministrare prodotti, varianti, clienti, ordini, vendite e resi attraverso un’interfaccia moderna e intuitiva sviluppata in **C# Windows Forms** con database **SQL Server**.

Il progetto nasce con l’obiettivo di migliorare l’organizzazione interna del negozio, velocizzare le operazioni di vendita e mantenere sotto controllo il magazzino in modo preciso ed efficiente.

---

# Funzionalità principali

## Gestione prodotti
- Inserimento nuovi prodotti
- Modifica ed eliminazione prodotti
- Gestione stato prodotto attivo/non attivo
- Associazione di:
  - marca
  - categoria
  - genere
  - descrizione
  - prezzo

## Gestione varianti
Ogni prodotto può avere diverse varianti:
- taglia
- colore
- quantità disponibile

Il sistema permette di monitorare in tempo reale la disponibilità del magazzino.

## Gestione clienti
- Registrazione clienti
- Modifica dati anagrafici
- Gestione città e recapiti
- Associazione acquisti effettuati

## Gestione vendite
- Creazione scontrini
- Inserimento prodotti nello scontrino
- Calcolo automatico del totale
- Gestione metodo di pagamento
- Salvataggio storico vendite

## Gestione resi
- Registrazione resi
- Quantità resa
- Motivo del reso
- Aggiornamento automatico del magazzino

## Gestione ordini fornitori
- Creazione ordini
- Associazione fornitore
- Inserimento prodotti ordinati
- Quantità e prezzo unitario
- Calcolo totale ordine

---

# Tecnologie utilizzate

| Tecnologia | Utilizzo |
|---|---|
| C# | Logica applicativa |
| Windows Forms | Interfaccia grafica |
| SQL Server | Database relazionale |
| ADO.NET | Connessione database |
| Visual Studio | Ambiente di sviluppo |

---

# Struttura del database

Il database è composto dalle seguenti tabelle principali:

- MARCHE
- CATEGORIE
- GENERI
- PRODOTTI
- TAGLIE
- COLORI
- VARIANTI_PRODOTTO
- CLIENTI
- CITTA
- SCONTRINI
- RIGHE_SCONTRINO
- RESI
- FORNITORI
- ORDINI
- DETTAGLI_ORDINI
- METODI_PAGAMENTO

---

# Relazioni principali

## Prodotti
Ogni prodotto:
- appartiene a una marca
- appartiene a una categoria
- appartiene a un genere

## Varianti prodotto
Ogni variante collega:
- prodotto
- taglia
- colore

## Vendite
Uno scontrino può contenere più righe di vendita.

Ogni riga contiene:
- variante acquistata
- quantità
- prezzo unitario

## Resi
Ogni reso è collegato a una specifica riga dello scontrino.

## Ordini
Ogni ordine:
- appartiene a un fornitore
- contiene più dettagli ordine

---

# Obiettivi del progetto

Gli obiettivi principali del software sono:

- migliorare la gestione del negozio
- velocizzare le operazioni quotidiane
- ridurre errori manuali
- mantenere il controllo del magazzino
- rendere più semplice la gestione delle vendite
- digitalizzare l’archiviazione dei dati

---

# Caratteristiche del software

## Interfaccia intuitiva
L’applicazione è stata progettata per essere semplice da utilizzare anche da utenti con poca esperienza informatica.

## Controlli automatici
Sono presenti:
- controlli sui campi obbligatori
- controlli sulle quantità
- controlli sui duplicati
- validazioni dei dati inseriti

## Ottimizzazione database
Il database utilizza:
- chiavi primarie
- chiavi esterne
- vincoli UNIQUE
- CHECK constraints
- indici SQL per migliorare le prestazioni

---

# Possibili sviluppi futuri

- Dashboard statistiche vendite
- Grafici andamento negozio
- Gestione utenti e login
- Backup automatici
- Esportazione PDF degli scontrini
- Stampa documenti ordine
- Sistema notifiche magazzino
- Gestione barcode

---

# Conclusione

Vetrina Digitale rappresenta una soluzione completa per la gestione di un negozio di abbigliamento, combinando semplicità d’uso, organizzazione dei dati e automazione delle operazioni principali.

Il progetto ha permesso di applicare concretamente competenze di:
- programmazione ad oggetti
- progettazione database
- sviluppo interfacce grafiche
- gestione dati tramite SQL Server

realizzando un software realmente utilizzabile in un contesto lavorativo reale.
