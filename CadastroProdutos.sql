CREATE DATABASE CadastroProduto;

USE CadastroProduto;

CREATE TABLE Produto(
	Id INT PRIMARY KEY AUTO_INCREMENT,
    Nome VARCHAR (100),
    Preco DECIMAL (10,2)
);

