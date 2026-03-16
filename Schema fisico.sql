--CREAZIONE TABELLE

--MARCHE
CREATE TABLE MARCHE (
	idMarca INT PRIMARY KEY IDENTITY(1,1),
	marca VARCHAR(100) NOT NULL,
	CONSTRAINT UNQ_marca UNIQUE (marca)
)

--CATEGORIE
CREATE TABLE CATEGORIE (
	idCategoria INT PRIMARY KEY IDENTITY(1,1),
	categoria VARCHAR(100) NOT NULL,
	CONSTRAINT UNQ_categoria UNIQUE (categoria)
)

--GENERI
CREATE TABLE GENERI (
	idGenere INT PRIMARY KEY IDENTITY(1,1),
	genere VARCHAR(50) NOT NULL,
	CONSTRAINT UNQ_genere UNIQUE (genere)
)

--PRODOTTI
CREATE TABLE PRODOTTI (
	idProdotto INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	idMarca INT NOT NULL,
	idCategoria INT NOT NULL,
	idGenere INT NOT NULL,
	prezzo DECIMAL(10, 2) NOT NULL CHECK (prezzo >= 0),
	descrizione VARCHAR(200) NULL,
	attivo BIT NOT NULL DEFAULT 1,
	FOREIGN KEY (idMarca) REFERENCES MARCHE (idMarca),
	FOREIGN KEY (idCategoria) REFERENCES CATEGORIE (idCategoria),
	FOREIGN KEY (idGenere) REFERENCES GENERI (idGenere),
	CONSTRAINT UNQ_nome_marca UNIQUE (nome, idMarca)
)

--TAGLIE
CREATE TABLE TAGLIE (
	idTaglia INT PRIMARY KEY IDENTITY(1,1),
	taglia VARCHAR(50) NOT NULL,
	CONSTRAINT UNQ_taglia UNIQUE (taglia)
)

--COLORI
CREATE TABLE COLORI (
	idColore INT PRIMARY KEY IDENTITY(1,1),
	colore VARCHAR(50) NOT NULL,
	CONSTRAINT UNQ_colore UNIQUE (colore)
)

--VARIANTI_PRODOTTO
CREATE TABLE VARIANTI_PRODOTTO (
	idVariante INT PRIMARY KEY IDENTITY(1,1),
	idProdotto INT NOT NULL,
	idTaglia INT NOT NULL,
	idColore INT NOT NULL,
	quantitaDisponibile INT NOT NULL CHECK (quantitaDisponibile >= 0),
	FOREIGN KEY (idProdotto) REFERENCES PRODOTTI (idProdotto),
	FOREIGN KEY (idTaglia) REFERENCES TAGLIE (idTaglia),
	FOREIGN KEY (idColore) REFERENCES COLORI (idColore),
	CONSTRAINT UNQ_variante UNIQUE (idProdotto, idTaglia, idColore)
)

--CITTA
CREATE TABLE CITTA (
	idCitta INT PRIMARY KEY IDENTITY(1,1),
	citta VARCHAR(100) NOT NULL,
	CAP VARCHAR(10) NOT NULL,
	provincia VARCHAR(100) NOT NULL
)

--CLIENTI
CREATE TABLE CLIENTI (
	idCliente INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	cognome VARCHAR(100) NOT NULL,
	idCitta INT NOT NULL,
	telefono VARCHAR(20),
	email VARCHAR(100) NOT NULL UNIQUE,
	FOREIGN KEY (idCitta) REFERENCES CITTA (idCitta)
)

--METODI_PAGAMENTO
CREATE TABLE METODI_PAGAMENTO (
	idMetodo INT PRIMARY KEY IDENTITY(1,1),
	metodo VARCHAR(100) NOT NULL,
	CONSTRAINT UNQ_metodo UNIQUE (metodo)
)

--SCONTRINI
CREATE TABLE SCONTRINI (
	idScontrino INT PRIMARY KEY IDENTITY(1,1),
	dataVendita DATE NOT NULL DEFAULT CONVERT(DATE, GETDATE(), 105),
	oraVendita TIME NOT NULL DEFAULT CONVERT(TIME, GETDATE(), 108),
	idCliente INT NULL,
	idMetodo INT NOT NULL,
	totale DECIMAL(10, 2) NOT NULL CHECK (totale >= 0),
	FOREIGN KEY (idCliente) REFERENCES CLIENTI (idCliente),
	FOREIGN KEY (idMetodo) REFERENCES METODI_PAGAMENTO (idMetodo)
)

--RIGHE_SCONTRINO
CREATE TABLE RIGHE_SCONTRINO (
	idRiga INT PRIMARY KEY IDENTITY(1,1),
	idScontrino INT NOT NULL,
	idVariante INT NOT NULL,
	quantita INT NOT NULL CHECK (quantita > 0),
	prezzoUnitario DECIMAL(10, 2) NOT NULL CHECK (prezzoUnitario >= 0),
	FOREIGN KEY (idScontrino) REFERENCES SCONTRINI (idScontrino),
	FOREIGN KEY (idVariante) REFERENCES VARIANTI_PRODOTTO (idVariante),
	CONSTRAINT UNQ_riga_scontrino UNIQUE (idScontrino, idVariante)
)

--RESI
CREATE TABLE RESI (
	idReso INT PRIMARY KEY IDENTITY(1,1),
	idRiga INT NOT NULL,
	dataReso DATE NOT NULL DEFAULT CONVERT(DATE, GETDATE(), 105),
	oraReso TIME NOT NULL DEFAULT CONVERT(TIME, GETDATE(), 108),
	quantita INT NOT NULL CHECK (quantita > 0),
	motivo VARCHAR(200) NOT NULL,
	FOREIGN KEY (idRiga) REFERENCES RIGHE_SCONTRINO (idRiga)
)

--FORNITORI
CREATE TABLE FORNITORI (
	idFornitore INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	telefono VARCHAR(20),
	email VARCHAR(100) NOT NULL UNIQUE,
	idCitta INT NOT NULL,
	FOREIGN KEY (idCitta) REFERENCES CITTA (idCitta)
)

--ORDINI
CREATE TABLE ORDINI (
	idOrdine INT PRIMARY KEY IDENTITY(1,1),
	dataOrdine DATE NOT NULL DEFAULT CONVERT(DATE, GETDATE(), 105),
	idFornitore INT NOT NULL,
	totale DECIMAL(10, 2) NOT NULL CHECK (totale >= 0),
	FOREIGN KEY (idFornitore) REFERENCES FORNITORI (idFornitore)
)

--DETTAGLI_ORDINI
CREATE TABLE DETTAGLI_ORDINI (
	idDettaglioOrdine INT PRIMARY KEY IDENTITY(1,1),
	idOrdine INT NOT NULL,
	idVariante INT NOT NULL,
	quantita INT NOT NULL CHECK (quantita > 0),
	prezzoUnitario DECIMAL(10, 2) NOT NULL CHECK (prezzoUnitario >= 0),
	FOREIGN KEY (idOrdine) REFERENCES ORDINI (idOrdine),
	FOREIGN KEY (idVariante) REFERENCES VARIANTI_PRODOTTO (idVariante),
	CONSTRAINT UNQ_dettaglio_ordine UNIQUE (idOrdine, idVariante)
)


--INDICI

--prodotti
CREATE INDEX IDX_prodotti_marca ON PRODOTTI (idMarca)
CREATE INDEX IDX_prodotti_categoria ON PRODOTTI (idCategoria)
CREATE INDEX IDX_prodotti_genere ON PRODOTTI (idGenere)

--varianti_prodotto
CREATE INDEX IDX_varianti_taglia ON VARIANTI_PRODOTTO (idTaglia)
CREATE INDEX IDX_varianti_colore ON VARIANTI_PRODOTTO (idColore)

--clienti
CREATE INDEX IDX_clienti_citta ON CLIENTI (idCitta)

--scontrini
CREATE INDEX IDX_scontrini_cliente ON SCONTRINI (idCliente)
CREATE INDEX IDX_scontrini_metodo ON SCONTRINI (idMetodo)
CREATE INDEX IDX_scontrini_data ON SCONTRINI (dataVendita)

--righe_scontrino
CREATE INDEX IDX_righe_scontrino ON RIGHE_SCONTRINO (idScontrino)
CREATE INDEX IDX_righe_variante ON RIGHE_SCONTRINO (idVariante)

--resi
CREATE INDEX IDX_resi_riga ON RESI (idRiga)

--ordini
CREATE INDEX IDX_ordini_fornitore ON ORDINI (idFornitore)
CREATE INDEX IDX_ordini_data ON ORDINI (dataOrdine)

--dettagli_ordini
CREATE INDEX IDX_dettagli_ordini ON DETTAGLI_ORDINI (idOrdine)
CREATE INDEX IDX_dettagli_variante ON DETTAGLI_ORDINI (idVariante)