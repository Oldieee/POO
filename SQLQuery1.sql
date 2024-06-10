IF EXISTS(SELECT 1 FROM sys.tables WHERE name = 'reg') DROP TABLE reg
CREATE TABLE reg
(
	id INT  PRIMARY KEY IDENTITY (1,1),
	nume    VARCHAR(MAX) NULL,
	prenume VARCHAR(MAX) NULL,
	telefon VARCHAR(MAX) NULL,
	email   VARCHAR(MAX) NULL,
	pwd     VARCHAR(MAX) NULL,
	adresa   VARCHAR(MAX) NULL,
	data_created DATE NULL,
)
SELECT * FROM reg