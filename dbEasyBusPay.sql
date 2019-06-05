CREATE DATABASE dbEasyBusPay;
USE dbEasyBusPay;

CREATE TABLE tb_user (
	IdUser			INT PRIMARY KEY IDENTITY,
	NomeUser		VARCHAR(60) NOT NULL,
	EmailUser		VARCHAR(60) NOT NULL,
	PasswordUser	VARCHAR(20) NOT NULL,
	TipoUser		CHAR(1) NOT NULL,
	Master			BIT default(0)
);

CREATE TABLE tb_linha (
	IdLinha			INT PRIMARY KEY IDENTITY,
	NumeroLinha		VARCHAR(4)	 NOT NULL,
	PontoInicio		VARCHAR(30)	 NOT NULL,
	PontoFinal		VARCHAR(30)	 NOT NULL,
	ValorPassagem	MONEY NOT NULL,
	LinhaAtiva		BIT default(1),
	Catraca			BIT default(0)
)

INSERT INTO tb_user (NomeUser, EmailUser, PasswordUser, TipoUser) VALUES ('Admin' , 'admin@admin.com', 'admin', '1');

UPDATE tb_user SET Master = 1 WHERE IdUser = 1;


SELECT * FROM tb_linha;