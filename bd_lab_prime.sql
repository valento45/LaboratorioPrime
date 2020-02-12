use master;
GO

drop database bd_lab_prime;
GO
create database bd_lab_prime;
GO

use bd_lab_prime;
GO

CREATE SCHEMA prime;
GO


create table prime.usuario_tb(
id_usuario int identity not null primary key,
login varchar(30) not null,
senha varchar(30) not null,
nome varchar(150) not null,
funcao varchar(30) null,
documento varchar(20) null,
cpf varchar(20) null,
modulos varchar(20) null,
observacao varchar(100) null,
permissao varchar(10) null,
user_atv bit null
);
GO

select * from prime.usuario_tb