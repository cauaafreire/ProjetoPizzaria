-- CRIANDO O BANCO DE DADOS
CREATE DATABASE BDPzzaria1;

-- USANDO BANCO DE DADOS 
USE BDPzzaria1;

-- CRIANDO AS TABELAS DO BANCO DE DADOS 
CREATE TABLE tbPedido (
	CodPedido int primary key auto_increment,
	tipoPizza Varchar(50),
    valorPizza Varchar(50),
    valorOpcao Varchar(50),
    valorTotal Varchar(50)
)

-- CONSULTANDO A TABELA DO BANCO DE DADOS 
SELECT * FROM tbPedido;