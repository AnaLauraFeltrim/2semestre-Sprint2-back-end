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

alter table Funcionarios
add DataNasc date

update Funcionarios
set DataNasc = '09-08-2001'
where IdFuncionario = 1;

update Funcionarios
set DataNasc = '23-03-2003'
where IdFuncionario = 2;

select * from Funcionarios