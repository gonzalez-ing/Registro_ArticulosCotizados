CREATE DATABASE ArticulosDb
Go
CREATE TABLE Articulos
(
	Id int primary key identity,
	Fecha DateTime,
	Descripcion Varchar(max),
	Precio Money,
	Cantidad int,
	CantidadCotizada int
);