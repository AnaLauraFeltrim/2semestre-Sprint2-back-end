create database M_Peoples

use M_Peoples


create table Funcionarios(
IdFuncionario int primary key  identity,
Nome varchar(200),
Sobrenome varchar(200)
)

insert into Funcionarios(Nome, Sobrenome)
values ('Catarina', 'Strada' ),
	   ('Tadeu', 'Vitteli')

select * from Funcionarios