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

INSERT INTO tb_user (NomeUser, EmailUser, PasswordUser, TipoUser) VALUES ('Admin' , 'admin@admin.com', 'admin', '1');

SELECT * FROM tb_user;

SELECT IdUser, NomeUser, EmailUser, TipoUser, Master FROM tb_user WHERE EmailUser = 'admin@admin.com' AND PasswordUSer = 'admin';

UPDATE tb_user SET Master = 1 WHERE IdUser = 2;