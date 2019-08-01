CREATE DATABASE produtodb;

USE produtodb;

DROP TABLE IF EXISTS Produtos;

CREATE TABLE Produtos(
ProdutoId INT AUTO_INCREMENT,
Nome VARCHAR(80) NOT NULL,
Categoria VARCHAR(50) NOT NULL,
Preco DECIMAL (10,2) NOT NULL,
PRIMARY KEY(ProdutoId)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

LOCK TABLES Produtos WRITE;
INSERT INTO Produtos VALUES(1, 'Playstation 4', 'Video Game', '1565.99');
INSERT INTO Produtos VALUES(2, 'XBOX One', 'Video Game', '1256.33');
INSERT INTO Produtos VALUES(3, 'Nintendo Switch', 'Video Game', '1799.88');
UNLOCK TABLES;