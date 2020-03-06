create database M_Peoples
go

use M_Peoples
go

create table TipoUsuario(
IdTipoUsuario int primary key identity,
Titulo varchar(200)
)
go

create table Usuario(
IdUsuario int primary key identity,
Email varchar(200),
Senha varchar(200),
IdTipoUusuario int foreign key references TipoUsuario(IdTipoUsuario)
)
go

create table Funcionarios(
IdFuncionario int primary key  identity,
Nome varchar(200),
Sobrenome varchar(200),
DataNasc date,
IdUsuario int foreign key references Usuario(IdUsuario)
)
go

insert into TipoUsuario(Titulo)
values ('Administrador' ),
	   ('Usuario')

insert into Usuario(Email, Senha, IdTipoUusuario)
values ('nicolas@gmail.com', 'otario123', 2 ),
	   ('dudsprado@gmail.com', 'duds321', 2),
	   ('catarinastrada@gmail.com', 'catarina123', 1),
	   ('tadeu@gmail.com', 'tadeu123', 1)

insert into Funcionarios(Nome, Sobrenome, DataNasc, IdUsuario)
values ('Catarina', 'Strada', '09-08-2001', 3 ),
	   ('Tadeu', 'Vitteli', '23-03-2003', 4),
	   ('Eduardo', 'Prado', '17-01-2003', 2),
	   ('Nicolas', 'Freitas', '13-08-2003', 1)


select * from Funcionarios

