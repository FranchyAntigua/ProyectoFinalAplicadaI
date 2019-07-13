Create database PFinal
go
Use PFinal
go
create table Usuarios(
UsuarioId int identity primary key,
FechaIngreso datetime,
Nombre varchar(50),
Email varchar(50),
NivelUsuario int, 
Usuario varchar(30),
Contrasena varchar(20),
Confirmar varchar(20)

)