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

create table Articulos(
ArticuloId int identity primary key,
Nombre varchar(50),
Descripcion varchar(50),
Costo decimal(8,2),
Precio decimal(8,2),
Ganancia decimal(8,2),
Inventario decimal(8,2),
)

create table EntradaArticulos(
EntradaId int identity primary key,
Fecha datetime,
ArticuloId int,
Cantidad decimal (8,2),
)

