IF EXISTS(SELECT 1 FROM sys.tables WHERE name = 'admin') DROP TABLE admin
CREATE TABLE admin
(
	id INT  PRIMARY KEY IDENTITY (1,1),
	email VARCHAR(MAX) NULL,
	username VARCHAR(MAX) NULL,
	pwd VARCHAR(MAX) NULL,
	data_created DATE NULL,
)
SELECT * FROM admin