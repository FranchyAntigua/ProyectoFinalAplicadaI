create database PppFinal
go
Use PppFinal
go
create table Usuarios(
UsuarioId int identity primary key,
Nombre varchar(50),
Email varchar(50),
NivelUsuario int, 
Usuario varchar(30),
Contrasena varchar(20),
Confirmar varchar(20),
FechaIngreso datetime

)
insert into Usuarios values('Franchy Antigua','antigua95@gmail.com',0,'Admin',1234,1234,'2019/07/20')

select * from Usuarios
