create database PruebaF
go
Use PruebaF
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

create table Clientes(
ClienteId int identity primary key,
Fecha datetime,
Nombres varchar(50),
Cedula varchar(13),
Direccion varchar(100),
Email varchar(100),
Celular varchar(13),
Telefono varchar(13),
UsuarioId int
)

